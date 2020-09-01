using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Given students' names along with the grade that they are in, create a roster for the school.
///
///In the end, you should be able to:
///
///Add a student's name to the roster for a grade
///"Add Jim to grade 2."
///"OK."
///Get a list of all students enrolled in a grade
///"Which students are in grade 2?"
///"We've only got Jim just now."
///Get a sorted list of all students in all grades.Grades should sort as 1, 2, 3, etc., and students within a grade should be sorted alphabetically by name.
///"Who all is enrolled in school right now?"
///"Grade 1: Anna, Barb, and Charlie. Grade 2: Alex, Peter, and Zoe. Grade 3…"
///Note that all our students only have one name. (It's a small town, what do you want?)
/// 
/// </summary>
public class GradeSchool
{
    private readonly List<Students> Estudantes = new List<Students>();
    private class Students
    {
        public string Nome { get; set; }
        public int Serie { get; set; }
    }

    public void Add(string student, int grade)
    {
        Estudantes.Add(new Students
        {
            Nome = student,
            Serie = grade
        });
    }

    public IEnumerable<string> Roster()
    {
        return Estudantes.OrderBy(item => item.Serie).ThenBy(item => item.Nome).Select(item => item.Nome);
    }

    public IEnumerable<string> Grade(int grade)
    {
        var serieEstudante = new List<string>();
        foreach (var pirralhos in Estudantes)
        {
            if (pirralhos.Serie == grade)
            {
                serieEstudante.Add(pirralhos.Nome);
            }
        }
    return serieEstudante.OrderBy(q => q);
    }
}