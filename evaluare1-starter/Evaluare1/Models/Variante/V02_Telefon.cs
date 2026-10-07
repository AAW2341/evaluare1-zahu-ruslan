namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 02  —  Telefoane
    //
    //  Controlerul tău:      TelefoaneController
    //  Lista cu date:        BazaTelefoane.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Telefoane/Detalii/5
    //  Ruta (Sarcina 3):     telefoane/sistem/{sistem}  ->  acțiunea Sistem
    //  Adresa de test:       /telefoane/sistem/harmonyos
    //  Rezumat (Sarcina 4):  „Cel mai mare preț” = cea mai mare valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Telefon
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Producator { get; set; }
        public string Sistem { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaTelefoane
    {
        public static List<Telefon> Lista = new List<Telefon>
        {
            new Telefon { Id = 1, Model = "Galaxy A55", Producator = "Samsung", Sistem = "Android", Pret = 7999 },
            new Telefon { Id = 2, Model = "iPhone 16", Producator = "Apple", Sistem = "iOS", Pret = 17999 },
            new Telefon { Id = 3, Model = "Redmi Note 14", Producator = "Xiaomi", Sistem = "Android", Pret = 4599 },
            new Telefon { Id = 4, Model = "Pixel 9", Producator = "Google", Sistem = "Android", Pret = 13499 },
            new Telefon { Id = 5, Model = "iPhone 15", Producator = "Apple", Sistem = "iOS", Pret = 14299 },
            new Telefon { Id = 6, Model = "Nova 13", Producator = "Huawei", Sistem = "HarmonyOS", Pret = 8299 },
            new Telefon { Id = 7, Model = "Pura 70", Producator = "Huawei", Sistem = "HarmonyOS", Pret = 15999 }
        };
    }
}
