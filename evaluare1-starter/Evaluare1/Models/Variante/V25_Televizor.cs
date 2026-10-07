namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 25  —  Televizoare
    //
    //  Controlerul tău:      TelevizoareController
    //  Lista cu date:        BazaTelevizoare.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Televizoare/Detalii/5
    //  Ruta (Sarcina 3):     televizoare/panou/{panou}  ->  acțiunea Panou
    //  Adresa de test:       /televizoare/panou/oled
    //  Rezumat (Sarcina 4):  „Cea mai mare diagonală” = cea mai mare valoare a câmpului Diagonala
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Televizor
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Marca { get; set; }
        public string Panou { get; set; }
        public int Diagonala { get; set; }
    }

    public static class BazaTelevizoare
    {
        public static List<Televizor> Lista = new List<Televizor>
        {
            new Televizor { Id = 1, Model = "Crystal UHD", Marca = "Samsung", Panou = "VA", Diagonala = 55 },
            new Televizor { Id = 2, Model = "OLED C4", Marca = "LG", Panou = "OLED", Diagonala = 65 },
            new Televizor { Id = 3, Model = "Bravia X75", Marca = "Sony", Panou = "IPS", Diagonala = 43 },
            new Televizor { Id = 4, Model = "QNED 80", Marca = "LG", Panou = "IPS", Diagonala = 50 },
            new Televizor { Id = 5, Model = "OLED Bravia 8", Marca = "Sony", Panou = "OLED", Diagonala = 55 },
            new Televizor { Id = 6, Model = "The Frame", Marca = "Samsung", Panou = "VA", Diagonala = 75 },
            new Televizor { Id = 7, Model = "P755", Marca = "TCL", Panou = "VA", Diagonala = 50 }
        };
    }
}
