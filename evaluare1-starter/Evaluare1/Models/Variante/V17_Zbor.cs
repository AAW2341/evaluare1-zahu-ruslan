namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 17  —  Zboruri
    //
    //  Controlerul tău:      ZboruriController
    //  Lista cu date:        BazaZboruri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Zboruri/Detalii/5
    //  Ruta (Sarcina 3):     zboruri/clasa/{clasa}  ->  acțiunea Clasa
    //  Adresa de test:       /zboruri/clasa/business
    //  Rezumat (Sarcina 4):  „Cel mai ieftin zbor” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Zbor
    {
        public int Id { get; set; }
        public string Destinatie { get; set; }
        public string Companie { get; set; }
        public string Clasa { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaZboruri
    {
        public static List<Zbor> Lista = new List<Zbor>
        {
            new Zbor { Id = 1, Destinatie = "Roma", Companie = "Wizz Air", Clasa = "Economic", Pret = 1900 },
            new Zbor { Id = 2, Destinatie = "Londra", Companie = "Air Moldova", Clasa = "Business", Pret = 9800 },
            new Zbor { Id = 3, Destinatie = "Paris", Companie = "Air France", Clasa = "Premium", Pret = 6400 },
            new Zbor { Id = 4, Destinatie = "Istanbul", Companie = "Turkish Airlines", Clasa = "Economic", Pret = 2600 },
            new Zbor { Id = 5, Destinatie = "Frankfurt", Companie = "Lufthansa", Clasa = "Business", Pret = 8700 },
            new Zbor { Id = 6, Destinatie = "Milano", Companie = "Wizz Air", Clasa = "Economic", Pret = 1500 },
            new Zbor { Id = 7, Destinatie = "Viena", Companie = "Austrian Airlines", Clasa = "Premium", Pret = 5200 }
        };
    }
}
