namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 14  —  Preparate din meniu
    //
    //  Controlerul tău:      PreparateController
    //  Lista cu date:        BazaPreparate.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Preparate/Detalii/1
    //  Ruta (Sarcina 3):     preparate/categorie/{categorie}  ->  acțiunea Categorie
    //  Adresa de test:       /preparate/categorie/grill
    //  Rezumat (Sarcina 4):  „Cel mai mic preț” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Preparat
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Bucatarie { get; set; }
        public string Categorie { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaPreparate
    {
        public static List<Preparat> Lista = new List<Preparat>
        {
            new Preparat { Id = 1, Denumire = "Salată grecească", Bucatarie = "Grecească", Categorie = "Salate", Pret = 95 },
            new Preparat { Id = 2, Denumire = "Plăcintă cu brânză", Bucatarie = "Moldovenească", Categorie = "Desert", Pret = 45 },
            new Preparat { Id = 3, Denumire = "Frigărui de porc", Bucatarie = "Moldovenească", Categorie = "Grill", Pret = 160 },
            new Preparat { Id = 4, Denumire = "Salată Caesar", Bucatarie = "Americană", Categorie = "Salate", Pret = 110 },
            new Preparat { Id = 5, Denumire = "Tiramisu", Bucatarie = "Italiană", Categorie = "Desert", Pret = 70 },
            new Preparat { Id = 6, Denumire = "Mici la grătar", Bucatarie = "Românească", Categorie = "Grill", Pret = 120 },
            new Preparat { Id = 7, Denumire = "Salată de vară", Bucatarie = "Moldovenească", Categorie = "Salate", Pret = 60 }
        };
    }
}
