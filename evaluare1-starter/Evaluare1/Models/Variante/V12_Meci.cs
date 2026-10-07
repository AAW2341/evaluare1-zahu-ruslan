namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 12  —  Meciuri
    //
    //  Controlerul tău:      MeciuriController
    //  Lista cu date:        BazaMeciuri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Meciuri/Detalii/3
    //  Ruta (Sarcina 3):     meciuri/sport/{sport}  ->  acțiunea Sport
    //  Adresa de test:       /meciuri/sport/volei
    //  Rezumat (Sarcina 4):  „Spectatori în total” = suma valorilor câmpului Spectatori
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Meci
    {
        public int Id { get; set; }
        public string Echipe { get; set; }
        public string Stadion { get; set; }
        public string Sport { get; set; }
        public int Spectatori { get; set; }
    }

    public static class BazaMeciuri
    {
        public static List<Meci> Lista = new List<Meci>
        {
            new Meci { Id = 1, Echipe = "Sheriff – Milsami", Stadion = "Stadionul Sheriff", Sport = "Fotbal", Spectatori = 4800 },
            new Meci { Id = 2, Echipe = "Zimbru – Petrocub", Stadion = "Stadionul Zimbru", Sport = "Fotbal", Spectatori = 3200 },
            new Meci { Id = 3, Echipe = "Dacia – Bălți", Stadion = "Sala Polivalentă", Sport = "Volei", Spectatori = 650 },
            new Meci { Id = 4, Echipe = "Speranța – Codru", Stadion = "Stadionul Republican", Sport = "Fotbal", Spectatori = 2700 },
            new Meci { Id = 5, Echipe = "Universitatea – Politehnica", Stadion = "Sala Sporturilor", Sport = "Baschet", Spectatori = 900 },
            new Meci { Id = 6, Echipe = "Olimp – Cahul", Stadion = "Sala Polivalentă", Sport = "Volei", Spectatori = 540 },
            new Meci { Id = 7, Echipe = "Dinamo – Orhei", Stadion = "Sala Sporturilor", Sport = "Baschet", Spectatori = 1100 }
        };
    }
}
