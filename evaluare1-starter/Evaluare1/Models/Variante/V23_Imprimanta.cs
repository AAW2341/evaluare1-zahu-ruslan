namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 23  —  Imprimante
    //
    //  Controlerul tău:      ImprimanteController
    //  Lista cu date:        BazaImprimante.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Imprimante/Detalii/3
    //  Ruta (Sarcina 3):     imprimante/tehnologie/{tehnologie}  ->  acțiunea Tehnologie
    //  Adresa de test:       /imprimante/tehnologie/laser
    //  Rezumat (Sarcina 4):  „Cel mai mic preț” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Imprimanta
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Marca { get; set; }
        public string Tehnologie { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaImprimante
    {
        public static List<Imprimanta> Lista = new List<Imprimanta>
        {
            new Imprimanta { Id = 1, Model = "LaserJet M110w", Marca = "HP", Tehnologie = "Laser", Pret = 2300 },
            new Imprimanta { Id = 2, Model = "EcoTank L3250", Marca = "Epson", Tehnologie = "Inkjet", Pret = 3600 },
            new Imprimanta { Id = 3, Model = "i-SENSYS LBP233", Marca = "Canon", Tehnologie = "Laser", Pret = 4100 },
            new Imprimanta { Id = 4, Model = "PIXMA G3410", Marca = "Canon", Tehnologie = "Inkjet", Pret = 3100 },
            new Imprimanta { Id = 5, Model = "ZD220 etichete", Marca = "Zebra", Tehnologie = "Termic", Pret = 5400 },
            new Imprimanta { Id = 6, Model = "DeskJet 2820", Marca = "HP", Tehnologie = "Inkjet", Pret = 1200 },
            new Imprimanta { Id = 7, Model = "QL-700 etichete", Marca = "Brother", Tehnologie = "Termic", Pret = 2900 }
        };
    }
}
