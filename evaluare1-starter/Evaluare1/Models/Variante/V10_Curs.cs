namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 10  —  Cursuri
    //
    //  Controlerul tău:      CursuriController
    //  Lista cu date:        BazaCursuri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Cursuri/Detalii/6
    //  Ruta (Sarcina 3):     cursuri/domeniu/{domeniu}  ->  acțiunea Domeniu
    //  Adresa de test:       /cursuri/domeniu/design
    //  Rezumat (Sarcina 4):  „Durata totală” = suma valorilor câmpului Durata
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Curs
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Profesor { get; set; }
        public string Domeniu { get; set; }
        public int Durata { get; set; }
    }

    public static class BazaCursuri
    {
        public static List<Curs> Lista = new List<Curs>
        {
            new Curs { Id = 1, Titlu = "C# pentru începători", Profesor = "Ion Rusu", Domeniu = "Programare", Durata = 40 },
            new Curs { Id = 2, Titlu = "Figma de la zero", Profesor = "Ana Ciobanu", Domeniu = "Design", Durata = 24 },
            new Curs { Id = 3, Titlu = "SMM practic", Profesor = "Elena Lungu", Domeniu = "Marketing", Durata = 16 },
            new Curs { Id = 4, Titlu = "ASP.NET Core MVC", Profesor = "Victor Cojocaru", Domeniu = "Programare", Durata = 60 },
            new Curs { Id = 5, Titlu = "Photoshop", Profesor = "Maria Popa", Domeniu = "Design", Durata = 30 },
            new Curs { Id = 6, Titlu = "Python", Profesor = "Ion Rusu", Domeniu = "Programare", Durata = 48 },
            new Curs { Id = 7, Titlu = "Publicitate online", Profesor = "Elena Lungu", Domeniu = "Marketing", Durata = 12 }
        };
    }
}
