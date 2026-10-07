namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 01  —  Medicamente
    //
    //  Controlerul tău:      MedicamenteController
    //  Lista cu date:        BazaMedicamente.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Medicamente/Detalii/4
    //  Ruta (Sarcina 3):     medicamente/forma/{forma}  ->  acțiunea Forma
    //  Adresa de test:       /medicamente/forma/sirop
    //  Rezumat (Sarcina 4):  „Cel mai mic preț” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Medicament
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Producator { get; set; }
        public string Forma { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaMedicamente
    {
        public static List<Medicament> Lista = new List<Medicament>
        {
            new Medicament { Id = 1, Denumire = "Paracetamol 500 mg", Producator = "Farmaprim", Forma = "Comprimate", Pret = 18 },
            new Medicament { Id = 2, Denumire = "Ibuprofen 200 mg", Producator = "Balkan Pharmaceuticals", Forma = "Comprimate", Pret = 35 },
            new Medicament { Id = 3, Denumire = "Nurofen pentru copii", Producator = "Reckitt", Forma = "Sirop", Pret = 92 },
            new Medicament { Id = 4, Denumire = "Ambroxol", Producator = "Farmaprim", Forma = "Sirop", Pret = 41 },
            new Medicament { Id = 5, Denumire = "Diclofenac gel", Producator = "Balkan Pharmaceuticals", Forma = "Unguent", Pret = 64 },
            new Medicament { Id = 6, Denumire = "Aspirină", Producator = "Bayer", Forma = "Comprimate", Pret = 27 },
            new Medicament { Id = 7, Denumire = "Fastum gel", Producator = "Menarini", Forma = "Unguent", Pret = 118 }
        };
    }
}
