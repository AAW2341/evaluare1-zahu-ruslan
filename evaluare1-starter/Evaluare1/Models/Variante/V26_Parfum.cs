namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 26  —  Parfumuri
    //
    //  Controlerul tău:      ParfumuriController
    //  Lista cu date:        BazaParfumuri.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Parfumuri/Detalii/2
    //  Ruta (Sarcina 3):     parfumuri/nota/{nota}  ->  acțiunea Nota
    //  Adresa de test:       /parfumuri/nota/citric
    //  Rezumat (Sarcina 4):  „Valoarea totală” = suma valorilor câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Parfum
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Marca { get; set; }
        public string Nota { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaParfumuri
    {
        public static List<Parfum> Lista = new List<Parfum>
        {
            new Parfum { Id = 1, Denumire = "Light Blue", Marca = "Dolce & Gabbana", Nota = "Citric", Pret = 1850 },
            new Parfum { Id = 2, Denumire = "Terre", Marca = "Hermès", Nota = "Lemnos", Pret = 2600 },
            new Parfum { Id = 3, Denumire = "J'adore", Marca = "Dior", Nota = "Floral", Pret = 2900 },
            new Parfum { Id = 4, Denumire = "Acqua di Parma Colonia", Marca = "Acqua di Parma", Nota = "Citric", Pret = 2400 },
            new Parfum { Id = 5, Denumire = "Santal 33", Marca = "Le Labo", Nota = "Lemnos", Pret = 4200 },
            new Parfum { Id = 6, Denumire = "Chance", Marca = "Chanel", Nota = "Floral", Pret = 2750 },
            new Parfum { Id = 7, Denumire = "Bleu", Marca = "Chanel", Nota = "Lemnos", Pret = 3100 }
        };
    }
}
