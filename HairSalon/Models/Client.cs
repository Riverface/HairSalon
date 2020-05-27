using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped()]
         public string Name =>$"{FirstName} {LastName}";
    }
}