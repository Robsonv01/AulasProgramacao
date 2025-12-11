using System;
using atividade.ead;

 Materia portugues  = new Materia("Português", 8.5);
        Materia matematica = new Materia("Matemática", 9.2);
        Materia geografia  = new Materia("Geografia", 7.0);
        Materia historia   = new Materia("História", 9.2);
        Materia fisica     = new Materia("Física", 6.8);

         List<Materia> materias = new List<Materia>
        {
            portugues,
            matematica,
            geografia,
            historia,
            fisica
        };

        ExibirMelhorMateria(materias);
    

void ExibirMelhorMateria(List<Materia> materias)
    {
        double maiorNota = 0;

        foreach (var m in materias)
        {
            if (m.Nota > maiorNota)
                maiorNota = m.Nota;
        }

        Console.WriteLine($"Maior nota: {maiorNota}");
        Console.WriteLine("Matérias com a melhor nota:");

        foreach (var m in materias)
        {
            if (m.Nota == maiorNota)
                Console.WriteLine("- " + m.Nome);
        }
    }
