using System.Collections.Generic;

namespace devicetracker.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}