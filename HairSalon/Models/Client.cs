using System.ComponentModel.DataAnnotations.Schema;
namespace HairSalon.Models
{

    public class Client
    {
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        [NotMapped()]
         public string Name =>$"{First_Name}{Last_Name}";

        public Client()
        {
            
            
        }


    }

}