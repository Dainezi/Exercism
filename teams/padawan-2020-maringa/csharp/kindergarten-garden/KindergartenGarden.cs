using System;
using System.Collections.Generic;

public enum Plant
{
    Violets = 'V',
    Radishes = 'R',
    Clover = 'C',
    Grass = 'G'
}

public class KindergartenGarden
{
    private List<Classes> Classe = new List<Classes>();
    private class Classes
    {
        public string Nome { get; set; }
        public string Planta { get; set; }
    }

    private string diagrama { get; set; }
    public string diagrama2 { get; set; }
    public KindergartenGarden(string diagram)
    {
        diagrama = diagram;
    }

    public IEnumerable<Plant> Plants(string student)
    {
        Classe.Add(new Classes
        {
            Nome = student
        });

        int fila1 = (diagrama.Length / 2) - 1;
        int fila2 = (diagrama.Length / 2) + 1;
        var listaCreche = new List<string>();
        foreach (var alunos in Classe)
        {
            int i = 0;
            if(alunos.Planta.Length <2)
            {
                for (i=0; i <= fila1; i++)
                {
                    alunos.Planta += diagrama[i];
                }
            }
        }
        foreach (var alunos in Classe)
        {
            int i = 0;
            if (alunos.Planta.Length < 4)
            {
                for (i = fila2; i <= student.Length; i++)
                {
                    alunos.Planta += diagrama[i];

                }
            }
        }
        return listaCreche.;
    }
}


