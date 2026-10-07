namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 22  —  Componente PC
    //
    //  Controlerul tău:      ComponenteController
    //  Lista cu date:        BazaComponente.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Componente/Detalii/4
    //  Ruta (Sarcina 3):     componente/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /componente/tip/ssd
    //  Rezumat (Sarcina 4):  „Cel mai mare preț” = cea mai mare valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Componenta
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Producator { get; set; }
        public string Tip { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaComponente
    {
        public static List<Componenta> Lista = new List<Componenta>
        {
            new Componenta { Id = 1, Denumire = "Ryzen 5 7600", Producator = "AMD", Tip = "CPU", Pret = 3900 },
            new Componenta { Id = 2, Denumire = "GeForce RTX 4060", Producator = "NVIDIA", Tip = "GPU", Pret = 6200 },
            new Componenta { Id = 3, Denumire = "Core i5-14400F", Producator = "Intel", Tip = "CPU", Pret = 3500 },
            new Componenta { Id = 4, Denumire = "SSD 990 EVO 1 TB", Producator = "Samsung", Tip = "SSD", Pret = 1700 },
            new Componenta { Id = 5, Denumire = "Radeon RX 7700 XT", Producator = "AMD", Tip = "GPU", Pret = 8100 },
            new Componenta { Id = 6, Denumire = "SSD NV2 500 GB", Producator = "Kingston", Tip = "SSD", Pret = 750 },
            new Componenta { Id = 7, Denumire = "Core i7-14700K", Producator = "Intel", Tip = "CPU", Pret = 7400 }
        };
    }
}
