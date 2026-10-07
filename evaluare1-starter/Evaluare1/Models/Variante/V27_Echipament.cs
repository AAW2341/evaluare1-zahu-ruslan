namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 27  —  Echipamente sportive
    //
    //  Controlerul tău:      EchipamenteController
    //  Lista cu date:        BazaEchipamente.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Echipamente/Detalii/7
    //  Ruta (Sarcina 3):     echipamente/sport/{sport}  ->  acțiunea Sport
    //  Adresa de test:       /echipamente/sport/tenis
    //  Rezumat (Sarcina 4):  „Valoarea totală” = suma valorilor câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Echipament
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Marca { get; set; }
        public string Sport { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaEchipamente
    {
        public static List<Echipament> Lista = new List<Echipament>
        {
            new Echipament { Id = 1, Denumire = "Minge de fotbal", Marca = "Adidas", Sport = "Fotbal", Pret = 450 },
            new Echipament { Id = 2, Denumire = "Rachetă de tenis", Marca = "Wilson", Sport = "Tenis", Pret = 1900 },
            new Echipament { Id = 3, Denumire = "Cască de ciclism", Marca = "Giro", Sport = "Ciclism", Pret = 1100 },
            new Echipament { Id = 4, Denumire = "Ghete de fotbal", Marca = "Nike", Sport = "Fotbal", Pret = 1600 },
            new Echipament { Id = 5, Denumire = "Mingi de tenis (set de 4)", Marca = "Head", Sport = "Tenis", Pret = 160 },
            new Echipament { Id = 6, Denumire = "Mănuși de ciclism", Marca = "Rockrider", Sport = "Ciclism", Pret = 250 },
            new Echipament { Id = 7, Denumire = "Apărători de tibie", Marca = "Puma", Sport = "Fotbal", Pret = 300 }
        };
    }
}
