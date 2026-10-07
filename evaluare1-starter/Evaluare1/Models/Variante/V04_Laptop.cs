namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 04  —  Laptopuri
    //
    //  Controlerul tău:      LaptopuriController
    //  Lista cu date:        BazaLaptopuri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Laptopuri/Detalii/2
    //  Ruta (Sarcina 3):     laptopuri/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /laptopuri/tip/gaming
    //  Rezumat (Sarcina 4):  „Valoarea totală” = suma valorilor câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Laptop
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Producator { get; set; }
        public string Tip { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaLaptopuri
    {
        public static List<Laptop> Lista = new List<Laptop>
        {
            new Laptop { Id = 1, Model = "IdeaPad 3", Producator = "Lenovo", Tip = "Office", Pret = 8999 },
            new Laptop { Id = 2, Model = "ROG Strix G16", Producator = "ASUS", Tip = "Gaming", Pret = 27999 },
            new Laptop { Id = 3, Model = "MacBook Air 13", Producator = "Apple", Tip = "Ultrabook", Pret = 21999 },
            new Laptop { Id = 4, Model = "Aspire 5", Producator = "Acer", Tip = "Office", Pret = 9499 },
            new Laptop { Id = 5, Model = "Legion 5", Producator = "Lenovo", Tip = "Gaming", Pret = 24999 },
            new Laptop { Id = 6, Model = "Zenbook 14", Producator = "ASUS", Tip = "Ultrabook", Pret = 18999 },
            new Laptop { Id = 7, Model = "Vostro 15", Producator = "Dell", Tip = "Office", Pret = 10499 }
        };
    }
}
