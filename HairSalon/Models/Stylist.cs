using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Client> clients { get; set; }
        [NotMapped()]
        public string Name => $"{FirstName}{LastName}";
        
        public Stylist()
        {
            this.clients = new HashSet<Client>();
        }
    }
}