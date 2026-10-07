namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 06  —  Hoteluri
    //
    //  Controlerul tău:      HoteluriController
    //  Lista cu date:        BazaHoteluri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Hoteluri/Detalii/7
    //  Ruta (Sarcina 3):     hoteluri/categorie/{categorie}  ->  acțiunea Categorie
    //  Adresa de test:       /hoteluri/categorie/standard
    //  Rezumat (Sarcina 4):  „Cel mai mare preț” = cea mai mare valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Hotel
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Oras { get; set; }
        public string Categorie { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaHoteluri
    {
        public static List<Hotel> Lista = new List<Hotel>
        {
            new Hotel { Id = 1, Denumire = "Hotel Cosmos", Oras = "Chișinău", Categorie = "Standard", Pret = 1200 },
            new Hotel { Id = 2, Denumire = "Radisson Blu Leogrand", Oras = "Chișinău", Categorie = "Lux", Pret = 2800 },
            new Hotel { Id = 3, Denumire = "Hotel Cahul", Oras = "Cahul", Categorie = "Economic", Pret = 650 },
            new Hotel { Id = 4, Denumire = "Hotel Bălți", Oras = "Bălți", Categorie = "Standard", Pret = 900 },
            new Hotel { Id = 5, Denumire = "Hostel Central", Oras = "Chișinău", Categorie = "Economic", Pret = 400 },
            new Hotel { Id = 6, Denumire = "Hotel Codru", Oras = "Ungheni", Categorie = "Standard", Pret = 850 },
            new Hotel { Id = 7, Denumire = "Château Vartely", Oras = "Orhei", Categorie = "Lux", Pret = 2400 }
        };
    }
}
