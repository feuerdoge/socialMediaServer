using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socialMediaServer
{
    public class Kommentar
    {
        public int Id { get; set; }
        public string Nachricht { get; set; }
        public DateTime Timestamp { get; set; }
        public int AutorId { get; set; }
        public int? OberKommentarId { get; set; }
        public List<Kommentar> Antworten { get; set; }
        public Kommentar(int id, string nachricht, DateTime timestamp, int autorId, int? oberKommentarId)
        {
            Id = id;
            Nachricht = nachricht;
            Timestamp = timestamp;
            AutorId = autorId;
            OberKommentarId = oberKommentarId;
            Antworten = new List<Kommentar>();
        }
        public void FuegeAntwortHinzu(Kommentar kommentar)
        {
            Antworten.Add(kommentar);
        }
    }
}
