namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 15  —  Abonamente
    //
    //  Controlerul tău:      AbonamenteController
    //  Lista cu date:        BazaAbonamente.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Abonamente/Detalii/6
    //  Ruta (Sarcina 3):     abonamente/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /abonamente/tip/box
    //  Rezumat (Sarcina 4):  „Cel mai mic preț” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Abonament
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Sala { get; set; }
        public string Tip { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaAbonamente
    {
        public static List<Abonament> Lista = new List<Abonament>
        {
            new Abonament { Id = 1, Denumire = "Fitness nelimitat", Sala = "Atlet Club", Tip = "Fitness", Pret = 700 },
            new Abonament { Id = 2, Denumire = "Box pentru începători", Sala = "Ring Pro", Tip = "Box", Pret = 550 },
            new Abonament { Id = 3, Denumire = "Yoga dimineața", Sala = "Zen Studio", Tip = "Yoga", Pret = 450 },
            new Abonament { Id = 4, Denumire = "Fitness de zi", Sala = "Atlet Club", Tip = "Fitness", Pret = 500 },
            new Abonament { Id = 5, Denumire = "Box avansat", Sala = "Ring Pro", Tip = "Box", Pret = 650 },
            new Abonament { Id = 6, Denumire = "Yoga seara", Sala = "Zen Studio", Tip = "Yoga", Pret = 400 },
            new Abonament { Id = 7, Denumire = "Fitness și piscină", Sala = "Aqua Sport", Tip = "Fitness", Pret = 950 }
        };
    }
}
