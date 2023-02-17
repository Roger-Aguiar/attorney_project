public class PersonalDocumentValidator
{
    private string? Cpf { get; set; }
    private int verificationDigit;
    private int digit;

    public PersonalDocumentValidator(string? cpf)
    {
        Cpf = cpf;
    }

    public bool ValidateCPF()
    {
        bool firstDigit = FirstDigit();
        bool secondDigit = SecondDigit();
        return firstDigit && secondDigit == true ? true : false;
    } 

    private bool FirstDigit()
    {
        digit = 10;

        for (int i = 0; i < Cpf?.Length - 2; i++)
        {
            verificationDigit = verificationDigit + (digit * Convert.ToInt32(Cpf?[i].ToString()));
            digit--;
        }
        return ((((verificationDigit * 10) % 11) == Convert.ToInt32(Cpf?[9].ToString())) ? true : false);
    }

    private bool SecondDigit()
    {
        digit = 11;
        verificationDigit = 0;  

        for (int i = 0; i < Cpf?.Length - 1; i++)
        {
            verificationDigit = verificationDigit + (digit * Convert.ToInt32(Cpf?[i].ToString()));
            digit--;
        }
        return ((((verificationDigit * 10) % 11) == Convert.ToInt32(Cpf?[10].ToString())) ? true : false);;
    }
}