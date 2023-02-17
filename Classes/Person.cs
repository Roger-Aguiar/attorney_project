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
            return new PersonalDocumentValidator(cPF).ValidateCPF() == false ? "CPF inválido" : cPF;
        } 
        set 
        {
            cPF = value;
        }
    }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public Address? Address { get; set; }
    public Guid Id { get; set; }
    public int IdPerson { get; set; }
}