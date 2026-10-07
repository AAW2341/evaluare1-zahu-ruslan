namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 21  —  Reviste
    //
    //  Controlerul tău:      RevisteController
    //  Lista cu date:        BazaReviste.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Reviste/Detalii/6
    //  Ruta (Sarcina 3):     reviste/domeniu/{domeniu}  ->  acțiunea Domeniu
    //  Adresa de test:       /reviste/domeniu/turism
    //  Rezumat (Sarcina 4):  „Cel mai mic preț” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Revista
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Editura { get; set; }
        public string Domeniu { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaReviste
    {
        public static List<Revista> Lista = new List<Revista>
        {
            new Revista { Id = 1, Titlu = "Tehnologii azi", Editura = "Media Nord", Domeniu = "Tehnologie", Pret = 45 },
            new Revista { Id = 2, Titlu = "Sport plus", Editura = "Sport Media", Domeniu = "Sport", Pret = 30 },
            new Revista { Id = 3, Titlu = "Drumeții prin Moldova", Editura = "Media Nord", Domeniu = "Turism", Pret = 55 },
            new Revista { Id = 4, Titlu = "Gadgeturi", Editura = "Tech Press", Domeniu = "Tehnologie", Pret = 60 },
            new Revista { Id = 5, Titlu = "Fotbal național", Editura = "Sport Media", Domeniu = "Sport", Pret = 25 },
            new Revista { Id = 6, Titlu = "Vacanțe", Editura = "Tur Press", Domeniu = "Turism", Pret = 40 },
            new Revista { Id = 7, Titlu = "Programatorul", Editura = "Tech Press", Domeniu = "Tehnologie", Pret = 50 }
        };
    }
}
