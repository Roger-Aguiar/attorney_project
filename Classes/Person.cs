public class Person
{
    private string? cPF;

    public string? Name { get; set; }
    public string? Nationality { get; set; }
    public string? CivelStatus { get; set; }
    public string? Profession { get; set; }
    public string? Identity { get; set; }
    public string? CPF 
    { 
        get 
        {
            return cPF;
        } 
        set 
        {
            cPF = value;
        }
    }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public Address? Address { get; set; }

    private bool ValidateCPF()
    {        
        return false;
    }
}