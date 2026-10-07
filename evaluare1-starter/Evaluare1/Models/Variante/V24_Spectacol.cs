namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 24  —  Spectacole
    //
    //  Controlerul tău:      SpectacoleController
    //  Lista cu date:        BazaSpectacole.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Spectacole/Detalii/1
    //  Ruta (Sarcina 3):     spectacole/gen/{gen}  ->  acțiunea Gen
    //  Adresa de test:       /spectacole/gen/comedie
    //  Rezumat (Sarcina 4):  „Cel mai lung spectacol” = cea mai mare valoare a câmpului Durata
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Spectacol
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Teatru { get; set; }
        public string Gen { get; set; }
        public int Durata { get; set; }
    }

    public static class BazaSpectacole
    {
        public static List<Spectacol> Lista = new List<Spectacol>
        {
            new Spectacol { Id = 1, Titlu = "O scrisoare pierdută", Teatru = "Teatrul Eugene Ionesco", Gen = "Comedie", Durata = 150 },
            new Spectacol { Id = 2, Titlu = "Hamlet", Teatru = "Teatrul Mihai Eminescu", Gen = "Drama", Durata = 190 },
            new Spectacol { Id = 3, Titlu = "La Traviata", Teatru = "Teatrul de Operă și Balet", Gen = "Opera", Durata = 165 },
            new Spectacol { Id = 4, Titlu = "Livada cu vișini", Teatru = "Teatrul Mihai Eminescu", Gen = "Drama", Durata = 140 },
            new Spectacol { Id = 5, Titlu = "Revizorul", Teatru = "Teatrul Satiricus", Gen = "Comedie", Durata = 125 },
            new Spectacol { Id = 6, Titlu = "Carmen", Teatru = "Teatrul de Operă și Balet", Gen = "Opera", Durata = 175 },
            new Spectacol { Id = 7, Titlu = "Unchiul Vania", Teatru = "Teatrul Eugene Ionesco", Gen = "Drama", Durata = 155 }
        };
    }
}
