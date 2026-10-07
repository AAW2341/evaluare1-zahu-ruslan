namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 16  —  Apartamente
    //
    //  Controlerul tău:      ApartamenteController
    //  Lista cu date:        BazaApartamente.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Apartamente/Detalii/4
    //  Ruta (Sarcina 3):     apartamente/sector/{sector}  ->  acțiunea Sector
    //  Adresa de test:       /apartamente/sector/ciocana
    //  Rezumat (Sarcina 4):  „Cea mai mare suprafață” = cea mai mare valoare a câmpului Suprafata
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Apartament
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public string Camere { get; set; }
        public string Sector { get; set; }
        public int Suprafata { get; set; }
    }

    public static class BazaApartamente
    {
        public static List<Apartament> Lista = new List<Apartament>
        {
            new Apartament { Id = 1, Adresa = "str. Pușkin 22", Camere = "2 camere", Sector = "Centru", Suprafata = 58 },
            new Apartament { Id = 2, Adresa = "bd. Dacia 40", Camere = "3 camere", Sector = "Botanica", Suprafata = 72 },
            new Apartament { Id = 3, Adresa = "str. Mircea cel Bătrân 15", Camere = "1 cameră", Sector = "Ciocana", Suprafata = 38 },
            new Apartament { Id = 4, Adresa = "bd. Cuza Vodă 7", Camere = "2 camere", Sector = "Ciocana", Suprafata = 54 },
            new Apartament { Id = 5, Adresa = "str. București 61", Camere = "3 camere", Sector = "Centru", Suprafata = 95 },
            new Apartament { Id = 6, Adresa = "str. Decebal 99", Camere = "1 cameră", Sector = "Botanica", Suprafata = 41 },
            new Apartament { Id = 7, Adresa = "str. Armenească 12", Camere = "4 camere", Sector = "Centru", Suprafata = 120 }
        };
    }
}
