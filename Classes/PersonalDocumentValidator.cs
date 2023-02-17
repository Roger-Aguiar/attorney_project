public class PersonalDocumentValidator
{
    private string? Cpf { get; set; }
    private int firstDigit;
    private int digit;

    public PersonalDocumentValidator(string? cpf)
    {
        Cpf = cpf;
    }

    public bool ValidateCPF() => (FirstDigit() && SecondDigit() == true ? true : false);

    private bool FirstDigit()
    {
        digit = 10;

        for (int i = 0; i < Cpf?.Length - 2; i++)
        {
            firstDigit = firstDigit + (digit * Convert.ToInt32(Cpf?[i].ToString()));
            digit--;
        }

        return (((firstDigit * 10) % 11) == (Cpf?.Length - 2));
    }

    private bool SecondDigit()
    {
        digit = 11;        

        for (int i = 0; i < Cpf?.Length - 1; i++)
        {
            firstDigit = firstDigit + (digit * Convert.ToInt32(Cpf?[i].ToString()));
            digit--;
        }

        return ((firstDigit = (firstDigit * 10)) == (Cpf?.Length - 1));
    }
}