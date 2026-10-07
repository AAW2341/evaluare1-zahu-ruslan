namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 13  —  Expoziții
    //
    //  Controlerul tău:      ExpozitiiController
    //  Lista cu date:        BazaExpozitii.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Expozitii/Detalii/2
    //  Ruta (Sarcina 3):     expozitii/tema/{tema}  ->  acțiunea Tema
    //  Adresa de test:       /expozitii/tema/folclor
    //  Rezumat (Sarcina 4):  „Vizitatori în total” = suma valorilor câmpului Vizitatori
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Expozitie
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Muzeu { get; set; }
        public string Tema { get; set; }
        public int Vizitatori { get; set; }
    }

    public static class BazaExpozitii
    {
        public static List<Expozitie> Lista = new List<Expozitie>
        {
            new Expozitie { Id = 1, Denumire = "Arta contemporană din Moldova", Muzeu = "Muzeul Național de Artă", Tema = "Modern", Vizitatori = 1800 },
            new Expozitie { Id = 2, Denumire = "Covoare basarabene", Muzeu = "Muzeul de Etnografie", Tema = "Folclor", Vizitatori = 2300 },
            new Expozitie { Id = 3, Denumire = "Pictura secolului XIX", Muzeu = "Muzeul Național de Artă", Tema = "Clasic", Vizitatori = 1500 },
            new Expozitie { Id = 4, Denumire = "Fotografie urbană", Muzeu = "Galeria Constantin Brâncuși", Tema = "Modern", Vizitatori = 950 },
            new Expozitie { Id = 5, Denumire = "Portul popular", Muzeu = "Muzeul de Etnografie", Tema = "Folclor", Vizitatori = 2700 },
            new Expozitie { Id = 6, Denumire = "Grafică modernă", Muzeu = "Galeria Constantin Brâncuși", Tema = "Modern", Vizitatori = 700 },
            new Expozitie { Id = 7, Denumire = "Icoane vechi", Muzeu = "Muzeul de Istorie", Tema = "Clasic", Vizitatori = 1200 }
        };
    }
}
