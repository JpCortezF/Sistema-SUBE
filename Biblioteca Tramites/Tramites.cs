using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Biblioteca_Usuarios;
using MySql.Data.MySqlClient;


namespace Biblioteca_Tramites
{
    [XmlRoot("Tramites")]
    public class Tramites : IMapeableTramites<Tramites>
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

        public Tramites(int claimId, int dniClaimer, string claimMessage, DateTime claimTime, int claimComplete)
        {
            this.claimId = claimId;
            this.dniClaimer = dniClaimer;
            this.claimMessage = claimMessage;
            this.claimTime = claimTime;
            this.claimComplete = (EClaimStatus)Enum.ToObject(typeof(EClaimStatus), claimComplete); ;
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

        public Tramites Map(MySqlDataReader reader)
        {
            int claimId = Convert.ToInt32(reader["idClaim"]);
            int dniClaimer = Convert.ToInt32(reader["dniClaimer"]);
            string claimMessage = reader["claimMessage"].ToString() ?? "";
            DateTime claimTime = Convert.ToDateTime(reader["claimTime"]);
            int claimComplete = Convert.ToInt32(reader["idClaimStatus"]);

            return new Tramites(claimId, dniClaimer, claimMessage, claimTime, claimComplete);
        }
    }
}
