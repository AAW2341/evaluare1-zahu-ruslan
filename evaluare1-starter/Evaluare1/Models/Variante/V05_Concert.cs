namespace Evaluare1.Models
{
    // ====================================================================
    //  VARIANTA 05  —  Concerte
    //
    //  Controlerul tău:      ConcerteController
    //  Lista cu date:        BazaConcerte.Lista  (7 înregistrări)
    //  Detalii (Sarcina 2):  /Concerte/Detalii/3
    //  Ruta (Sarcina 3):     concerte/gen/{gen}  ->  acțiunea Gen
    //  Adresa de test:       /concerte/gen/pop
    //  Rezumat (Sarcina 4):  „Cel mai ieftin bilet” = cea mai mică valoare a câmpului Pret
    //
    //  Nu modifica acest fișier.
    // ====================================================================

    public class Concert
    {
        public int Id { get; set; }
        public string Interpret { get; set; }
        public string Sala { get; set; }
        public string Gen { get; set; }
        public int Pret { get; set; }
    }

    public static class BazaConcerte
    {
        public static List<Concert> Lista = new List<Concert>
        {
            new Concert { Id = 1, Interpret = "Zdob și Zdub", Sala = "Arena Chișinău", Gen = "Rock", Pret = 350 },
            new Concert { Id = 2, Interpret = "Ethno Jazz Band", Sala = "Sala cu Orgă", Gen = "Jazz", Pret = 200 },
            new Concert { Id = 3, Interpret = "Carla's Dreams", Sala = "Arena Chișinău", Gen = "Pop", Pret = 450 },
            new Concert { Id = 4, Interpret = "Gândul Mâței", Sala = "Palatul Național", Gen = "Rock", Pret = 300 },
            new Concert { Id = 5, Interpret = "Big Band Moldova", Sala = "Filarmonica Națională", Gen = "Jazz", Pret = 180 },
            new Concert { Id = 6, Interpret = "Irina Rimes", Sala = "Palatul Național", Gen = "Pop", Pret = 400 },
            new Concert { Id = 7, Interpret = "Alternosfera", Sala = "Arena Chișinău", Gen = "Rock", Pret = 320 }
        };
    }
}
