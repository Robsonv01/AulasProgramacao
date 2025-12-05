public class Aluno
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public double CalcularMedia()
    {
        return (Nota1 + Nota2) / 2;
    }

    public string VerificarSituacao()
    {
        double m = CalcularMedia();

        if (m >= 7) return "Aprovado";
        if (m >= 5) return "Recuperação";
        return "Reprovado";
    }
}
