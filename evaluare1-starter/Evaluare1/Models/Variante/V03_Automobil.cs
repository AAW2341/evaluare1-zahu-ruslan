namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 03  —  Automobile
    //
    //  Controlerul tău:      AutomobileController
    //  Lista cu date:        BazaAutomobile.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Automobile/Detalii/6
    //  Ruta (Sarcina 3):     automobile/combustibil/{combustibil}  ->  acțiunea Combustibil
    //  Adresa de test:       /automobile/combustibil/motorina
    //  Rezumat (Sarcina 4):  „Cea mai mare putere” = cea mai mare valoare a câmpului Putere
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Automobil
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Marca { get; set; }
        public string Combustibil { get; set; }
        public int Putere { get; set; }
    }

    public static class BazaAutomobile
    {
        public static List<Automobil> Lista = new List<Automobil>
        {
            new Automobil { Id = 1, Model = "Logan", Marca = "Dacia", Combustibil = "Benzina", Putere = 90 },
            new Automobil { Id = 2, Model = "Octavia", Marca = "Skoda", Combustibil = "Motorina", Putere = 150 },
            new Automobil { Id = 3, Model = "Model 3", Marca = "Tesla", Combustibil = "Electric", Putere = 283 },
            new Automobil { Id = 4, Model = "Golf", Marca = "Volkswagen", Combustibil = "Benzina", Putere = 130 },
            new Automobil { Id = 5, Model = "Duster", Marca = "Dacia", Combustibil = "Motorina", Putere = 115 },
            new Automobil { Id = 6, Model = "Leaf", Marca = "Nissan", Combustibil = "Electric", Putere = 150 },
            new Automobil { Id = 7, Model = "Corolla", Marca = "Toyota", Combustibil = "Benzina", Putere = 140 }
        };
    }
}
