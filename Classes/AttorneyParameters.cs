using System.Globalization;

public class AttorneyParameters
{
    private string? title = "PROCURAÇÃO";
    private string? powers = @"Amplos, para o foro em geral, com a cláusula ad judicia para, 
        em qualquer Juízo, Tribunal ou Repartição Pública, propor contra quem de direito 
        as ações competentes e defendê-lo(s) nas contrárias, seguindo umas e outras, até 
        final decisão, usando os recursos legais e acompanhando-os, conferindo-lhe, ainda, 
        os poderes especiais para dar e receber quitação, confessar, transigir, desistir, 
        renunciar ao direito, retirar alvarás em Cartório, podendo, ainda substabelecer,
        no todo ou em parte, com ou sem reservas de poderes.";
    private string? specificPower = $"Atuar junto ao processo ";
    private string? safeguard = "Nos poderes ora conferidos não está o de confessar em juízo ou fora dele.";
    private string? deadline = "A presente procuração tem duração até o fim da ação.";
    private string? currentDate = DateTime.Now.ToString("D", (new CultureInfo("pt-BR")));

    public string? Title { get => title; set => title = value; }
    public Person? Customer { get; set; }
    public Person? Lawyer { get; set; }
    public string? Powers { get => powers; set => powers = value; }
    public string? SpecificPower { get => specificPower; set => specificPower = value; }
    public string? Safeguard { get => safeguard; set => safeguard = value; }
    public string? Deadline { get => deadline; set => deadline = value; }
    public string? CustomerName { get; set; }
    public string? CurrentDate { get => currentDate; set => currentDate = value; }
    public string? ActionName { get; set; }
}