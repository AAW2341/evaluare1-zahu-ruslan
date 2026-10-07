namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 07  —  Instrumente muzicale
    //
    //  Controlerul tău:      InstrumenteController
    //  Lista cu date:        BazaInstrumente.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Instrumente/Detalii/1
    //  Ruta (Sarcina 3):     instrumente/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /instrumente/tip/digital
    //  Rezumat (Sarcina 4):  „Valoarea totală” = suma valorilor câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Instrument
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Producator { get; set; }
        public string Tip { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaInstrumente
    {
        public static List<Instrument> Lista = new List<Instrument>
        {
            new Instrument { Id = 1, Denumire = "Chitară clasică C40", Producator = "Yamaha", Tip = "Acustic", Pret = 2900 },
            new Instrument { Id = 2, Denumire = "Chitară electrică Stratocaster", Producator = "Fender", Tip = "Electric", Pret = 14500 },
            new Instrument { Id = 3, Denumire = "Pian digital P-45", Producator = "Yamaha", Tip = "Digital", Pret = 9800 },
            new Instrument { Id = 4, Denumire = "Vioară 4/4", Producator = "Stentor", Tip = "Acustic", Pret = 3600 },
            new Instrument { Id = 5, Denumire = "Chitară bas Jazz Bass", Producator = "Fender", Tip = "Electric", Pret = 16200 },
            new Instrument { Id = 6, Denumire = "Sintetizator CT-S300", Producator = "Casio", Tip = "Digital", Pret = 4200 },
            new Instrument { Id = 7, Denumire = "Ukulele", Producator = "Kala", Tip = "Acustic", Pret = 1500 }
        };
    }
}
