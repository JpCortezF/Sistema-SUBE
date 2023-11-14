using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_TarjetaSube
{
    [XmlRoot("Tramites")]
    public class Tramites
    {
        long claimId;
        string dniClaimer;
        string claimMessage;
        DateTime claimTime;
        string claimComplete;

        public Tramites() { }

        public Tramites(long claimId, string dniClaimer, string claimMessage, DateTime claimTime, string claimComplete)
        {
            this.claimId = claimId;
            this.dniClaimer = dniClaimer;
            this.claimMessage = claimMessage;
            this.claimTime = claimTime;
            this.ClaimComplete = claimComplete;
        }

        [XmlElement("ClaimId")]
        public long ClaimId { get => claimId; set => claimId = value; }
        [XmlElement("DniClaimer")]
        public string DniClaimer { get => dniClaimer; set => dniClaimer = value; }
        [XmlElement("ClaimMessage")]
        public string ClaimMessage { get => claimMessage; set => claimMessage = value; }
        [XmlElement("ClaimTime")]
        public DateTime ClaimTime { get => claimTime; set => claimTime = value; }
        [XmlElement("ClaimComplete")]
        public string ClaimComplete { get => claimComplete; set => claimComplete = value; }
    }
}
