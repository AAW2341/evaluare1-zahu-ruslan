namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 29  —  Curse de autobuz
    //
    //  Controlerul tău:      CurseController
    //  Lista cu date:        BazaCurse.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Curse/Detalii/6
    //  Ruta (Sarcina 3):     curse/tip/{tip}  ->  acțiunea Tip
    //  Adresa de test:       /curse/tip/regional
    //  Rezumat (Sarcina 4):  „Cel mai ieftin bilet” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Cursa
    {
        public int Id { get; set; }
        public string Destinatie { get; set; }
        public string Transportator { get; set; }
        public string Tip { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaCurse
    {
        public static List<Cursa> Lista = new List<Cursa>
        {
            new Cursa { Id = 1, Destinatie = "Chișinău – Cahul", Transportator = "Cahul Trans", Tip = "Regional", Pret = 150 },
            new Cursa { Id = 2, Destinatie = "Cahul – Giurgiulești", Transportator = "Cahul Trans", Tip = "Local", Pret = 35 },
            new Cursa { Id = 3, Destinatie = "Cahul – Iași", Transportator = "Euro Bus", Tip = "Extern", Pret = 320 },
            new Cursa { Id = 4, Destinatie = "Cahul – Vulcănești", Transportator = "Sud Auto", Tip = "Local", Pret = 45 },
            new Cursa { Id = 5, Destinatie = "Cahul – Bălți", Transportator = "Nord Trans", Tip = "Regional", Pret = 230 },
            new Cursa { Id = 6, Destinatie = "Cahul – Comrat", Transportator = "Sud Auto", Tip = "Regional", Pret = 70 },
            new Cursa { Id = 7, Destinatie = "Cahul – Galați", Transportator = "Euro Bus", Tip = "Extern", Pret = 180 }
        };
    }
}
