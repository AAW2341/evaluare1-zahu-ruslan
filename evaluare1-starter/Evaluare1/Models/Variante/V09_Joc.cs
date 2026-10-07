namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 09  —  Jocuri video
    //
    //  Controlerul tău:      JocuriController
    //  Lista cu date:        BazaJocuri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Jocuri/Detalii/5
    //  Ruta (Sarcina 3):     jocuri/platforma/{platforma}  ->  acțiunea Platforma
    //  Adresa de test:       /jocuri/platforma/pc
    //  Rezumat (Sarcina 4):  „Cel mai mare preț” = cea mai mare valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Joc
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Studio { get; set; }
        public string Platforma { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaJocuri
    {
        public static List<Joc> Lista = new List<Joc>
        {
            new Joc { Id = 1, Titlu = "Minecraft", Studio = "Mojang", Platforma = "PC", Pret = 520 },
            new Joc { Id = 2, Titlu = "EA Sports FC 25", Studio = "EA Sports", Platforma = "PlayStation", Pret = 1290 },
            new Joc { Id = 3, Titlu = "Monument Valley", Studio = "ustwo games", Platforma = "Mobil", Pret = 79 },
            new Joc { Id = 4, Titlu = "Cyberpunk 2077", Studio = "CD Projekt", Platforma = "PC", Pret = 690 },
            new Joc { Id = 5, Titlu = "Gran Turismo 7", Studio = "Polyphony Digital", Platforma = "PlayStation", Pret = 1150 },
            new Joc { Id = 6, Titlu = "Stardew Valley", Studio = "ConcernedApe", Platforma = "PC", Pret = 270 },
            new Joc { Id = 7, Titlu = "Alto's Odyssey", Studio = "Snowman", Platforma = "Mobil", Pret = 99 }
        };
    }
}
