using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace HairSalon.Models
{

    public class Stylist
    {

        public int StylistId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public virtual ICollection<Client> clients { get; set; }
        
        [NotMapped()]
         public string Name =>$"{First_Name}{Last_Name}";
        public Stylist()
        {
            this.clients = new HashSet<Client>();
        }


    }
}