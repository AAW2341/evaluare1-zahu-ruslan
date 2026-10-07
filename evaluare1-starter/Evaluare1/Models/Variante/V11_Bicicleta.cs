namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 11  —  Biciclete
    //
    //  Controlerul tău:      BicicleteController
    //  Lista cu date:        BazaBiciclete.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Biciclete/Detalii/7
    //  Ruta (Sarcina 3):     biciclete/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /biciclete/tip/urban
    //  Rezumat (Sarcina 4):  „Cel mai mare preț” = cea mai mare valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Bicicleta
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Marca { get; set; }
        public string Tip { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaBiciclete
    {
        public static List<Bicicleta> Lista = new List<Bicicleta>
        {
            new Bicicleta { Id = 1, Model = "Rockrider ST 100", Marca = "Decathlon", Tip = "Munte", Pret = 5900 },
            new Bicicleta { Id = 2, Model = "Elops 120", Marca = "Decathlon", Tip = "Urban", Pret = 4200 },
            new Bicicleta { Id = 3, Model = "Turbo Vado", Marca = "Specialized", Tip = "Electric", Pret = 42000 },
            new Bicicleta { Id = 4, Model = "Marlin 5", Marca = "Trek", Tip = "Munte", Pret = 11500 },
            new Bicicleta { Id = 5, Model = "Hyde Pro", Marca = "Cube", Tip = "Urban", Pret = 15500 },
            new Bicicleta { Id = 6, Model = "Scale 980", Marca = "Scott", Tip = "Munte", Pret = 16900 },
            new Bicicleta { Id = 7, Model = "Reaction Hybrid", Marca = "Cube", Tip = "Electric", Pret = 38000 }
        };
    }
}
