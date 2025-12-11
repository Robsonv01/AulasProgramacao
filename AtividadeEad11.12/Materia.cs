using System;
namespace atividade.ead;
public class Materia
{
    public string Nome { get; set; }
    public double Nota { get; set; }

    public Materia(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }
}