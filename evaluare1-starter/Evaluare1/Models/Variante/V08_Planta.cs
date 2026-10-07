namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 08  —  Plante
    //
    //  Controlerul tău:      PlanteController
    //  Lista cu date:        BazaPlante.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Plante/Detalii/4
    //  Ruta (Sarcina 3):     plante/loc/{loc}  ->  acțiunea Loc
    //  Adresa de test:       /plante/loc/exterior
    //  Rezumat (Sarcina 4):  „Cel mai mic preț” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Planta
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Origine { get; set; }
        public string Loc { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaPlante
    {
        public static List<Planta> Lista = new List<Planta>
        {
            new Planta { Id = 1, Denumire = "Ficus", Origine = "Asia", Loc = "Interior", Pret = 250 },
            new Planta { Id = 2, Denumire = "Lavandă", Origine = "Europa", Loc = "Exterior", Pret = 90 },
            new Planta { Id = 3, Denumire = "Mușcată", Origine = "Africa", Loc = "Balcon", Pret = 75 },
            new Planta { Id = 4, Denumire = "Monstera", Origine = "America", Loc = "Interior", Pret = 480 },
            new Planta { Id = 5, Denumire = "Trandafir", Origine = "Asia", Loc = "Exterior", Pret = 140 },
            new Planta { Id = 6, Denumire = "Petunie", Origine = "America", Loc = "Balcon", Pret = 60 },
            new Planta { Id = 7, Denumire = "Sansevieria", Origine = "Africa", Loc = "Interior", Pret = 220 }
        };
    }
}
