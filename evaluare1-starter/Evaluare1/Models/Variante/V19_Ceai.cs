namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 19  —  Ceaiuri
    //
    //  Controlerul tău:      CeaiuriController
    //  Lista cu date:        BazaCeaiuri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Ceaiuri/Detalii/7
    //  Ruta (Sarcina 3):     ceaiuri/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /ceaiuri/tip/fructe
    //  Rezumat (Sarcina 4):  „Gramaj total” = suma valorilor câmpului Gramaj
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Ceai
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Producator { get; set; }
        public string Tip { get; set; }
        public int Gramaj { get; set; }
    }

    public static class BazaCeaiuri
    {
        public static List<Ceai> Lista = new List<Ceai>
        {
            new Ceai { Id = 1, Denumire = "Sencha", Producator = "Ahmad Tea", Tip = "Verde", Gramaj = 100 },
            new Ceai { Id = 2, Denumire = "Earl Grey", Producator = "Twinings", Tip = "Negru", Gramaj = 200 },
            new Ceai { Id = 3, Denumire = "Fructe de pădure", Producator = "Teekanne", Tip = "Fructe", Gramaj = 50 },
            new Ceai { Id = 4, Denumire = "Gunpowder", Producator = "Ahmad Tea", Tip = "Verde", Gramaj = 250 },
            new Ceai { Id = 5, Denumire = "Assam", Producator = "Twinings", Tip = "Negru", Gramaj = 100 },
            new Ceai { Id = 6, Denumire = "Ceylon", Producator = "Basilur", Tip = "Negru", Gramaj = 150 },
            new Ceai { Id = 7, Denumire = "Măceșe și hibiscus", Producator = "Teekanne", Tip = "Fructe", Gramaj = 75 }
        };
    }
}
