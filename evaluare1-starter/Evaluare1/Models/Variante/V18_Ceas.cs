namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 18  —  Ceasuri
    //
    //  Controlerul tău:      CeasuriController
    //  Lista cu date:        BazaCeasuri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Ceasuri/Detalii/3
    //  Ruta (Sarcina 3):     ceasuri/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /ceasuri/tip/mecanic
    //  Rezumat (Sarcina 4):  „Cel mai mare preț” = cea mai mare valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Ceas
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Marca { get; set; }
        public string Tip { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaCeasuri
    {
        public static List<Ceas> Lista = new List<Ceas>
        {
            new Ceas { Id = 1, Model = "Seiko 5 Sports", Marca = "Seiko", Tip = "Mecanic", Pret = 6800 },
            new Ceas { Id = 2, Model = "Casio G-Shock", Marca = "Casio", Tip = "Quartz", Pret = 2400 },
            new Ceas { Id = 3, Model = "Orient Bambino", Marca = "Orient", Tip = "Mecanic", Pret = 4300 },
            new Ceas { Id = 4, Model = "Apple Watch SE", Marca = "Apple", Tip = "Smart", Pret = 5600 },
            new Ceas { Id = 5, Model = "Tissot PRX", Marca = "Tissot", Tip = "Quartz", Pret = 7900 },
            new Ceas { Id = 6, Model = "Galaxy Watch 7", Marca = "Samsung", Tip = "Smart", Pret = 5200 },
            new Ceas { Id = 7, Model = "Citizen Tsuyosa", Marca = "Citizen", Tip = "Quartz", Pret = 6100 }
        };
    }
}
