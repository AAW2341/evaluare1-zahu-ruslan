namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 20  —  Electrocasnice
    //
    //  Controlerul tău:      ElectrocasniceController
    //  Lista cu date:        BazaElectrocasnice.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Electrocasnice/Detalii/2
    //  Ruta (Sarcina 3):     electrocasnice/clasa/{clasa}  ->  acțiunea Clasa
    //  Adresa de test:       /electrocasnice/clasa/b
    //  Rezumat (Sarcina 4):  „Cel mai mare preț” = cea mai mare valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Electrocasnic
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Marca { get; set; }
        public string Clasa { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaElectrocasnice
    {
        public static List<Electrocasnic> Lista = new List<Electrocasnic>
        {
            new Electrocasnic { Id = 1, Denumire = "Mașină de spălat WW80", Marca = "Samsung", Clasa = "B", Pret = 8900 },
            new Electrocasnic { Id = 2, Denumire = "Frigider No Frost", Marca = "Bosch", Clasa = "A", Pret = 15400 },
            new Electrocasnic { Id = 3, Denumire = "Cuptor cu microunde", Marca = "LG", Clasa = "C", Pret = 2100 },
            new Electrocasnic { Id = 4, Denumire = "Mașină de spălat vase", Marca = "Bosch", Clasa = "A", Pret = 11200 },
            new Electrocasnic { Id = 5, Denumire = "Aspirator robot", Marca = "Xiaomi", Clasa = "B", Pret = 4600 },
            new Electrocasnic { Id = 6, Denumire = "Uscător de rufe", Marca = "Whirlpool", Clasa = "B", Pret = 12800 },
            new Electrocasnic { Id = 7, Denumire = "Fierbător electric", Marca = "Philips", Clasa = "C", Pret = 750 }
        };
    }
}
