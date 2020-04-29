using System.Collections.Generic;


namespace HairSalon.Models
{

    public class Stylist
    {
        public Stylist()
        {
            this.clients = new HashSet<Client>();
            this.Name = first_name + last_name;
        }
        public int StylistId { get; set; }
        public string Name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public virtual ICollection<Client> clients { get; set; }
    }
}