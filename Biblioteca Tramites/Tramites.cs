using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Biblioteca_Usuarios;


namespace Biblioteca_TarjetaSube
{
    [XmlRoot("Tramites")]
    public class Tramites
    {
        int claimId;
        int dniClaimer;
        string claimMessage;
        DateTime claimTime;
        EClaimStatus claimComplete;

        public Tramites() { }

        public Tramites(int claimId, int dniClaimer, string claimMessage, DateTime claimTime, EClaimStatus claimComplete)
        {
            this.claimId = claimId;
            this.dniClaimer = dniClaimer;
            this.claimMessage = claimMessage;
            this.claimTime = claimTime;
            this.claimComplete = claimComplete;
        }

        [XmlElement("ClaimId")]
        public int ClaimId { get => claimId; set => claimId = value; }
        [XmlElement("DniClaimer")]
        public int DniClaimer { get => dniClaimer; set => dniClaimer = value; }
        [XmlElement("ClaimMessage")]
        public string ClaimMessage { get => claimMessage; set => claimMessage = value; }
        [XmlElement("ClaimTime")]
        public DateTime ClaimTime { get => claimTime; set => claimTime = value; }
        [XmlElement("ClaimComplete")]
        public EClaimStatus ClaimComplete { get => claimComplete; set => claimComplete = value; }
        [XmlElement("Passenger")]
        public Pasajero Passenger { get; }
    }
}
