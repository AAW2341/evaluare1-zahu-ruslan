namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 28  —  Aplicații
    //
    //  Controlerul tău:      AplicatiiController
    //  Lista cu date:        BazaAplicatii.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Aplicatii/Detalii/1
    //  Ruta (Sarcina 3):     aplicatii/platforma/{platforma}  ->  acțiunea Platforma
    //  Adresa de test:       /aplicatii/platforma/linux
    //  Rezumat (Sarcina 4):  „Descărcări în total” = suma valorilor câmpului Descarcari
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Aplicatie
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Dezvoltator { get; set; }
        public string Platforma { get; set; }
        public int Descarcari { get; set; }
    }

    public static class BazaAplicatii
    {
        public static List<Aplicatie> Lista = new List<Aplicatie>
        {
            new Aplicatie { Id = 1, Denumire = "Notepad++", Dezvoltator = "Don Ho", Platforma = "Windows", Descarcari = 920 },
            new Aplicatie { Id = 2, Denumire = "GIMP", Dezvoltator = "GIMP Team", Platforma = "Linux", Descarcari = 640 },
            new Aplicatie { Id = 3, Denumire = "Telegram", Dezvoltator = "Telegram FZ", Platforma = "Android", Descarcari = 1500 },
            new Aplicatie { Id = 4, Denumire = "VLC", Dezvoltator = "VideoLAN", Platforma = "Windows", Descarcari = 1300 },
            new Aplicatie { Id = 5, Denumire = "Inkscape", Dezvoltator = "Inkscape Project", Platforma = "Linux", Descarcari = 410 },
            new Aplicatie { Id = 6, Denumire = "Duolingo", Dezvoltator = "Duolingo", Platforma = "Android", Descarcari = 1100 },
            new Aplicatie { Id = 7, Denumire = "7-Zip", Dezvoltator = "Igor Pavlov", Platforma = "Windows", Descarcari = 870 }
        };
    }
}
