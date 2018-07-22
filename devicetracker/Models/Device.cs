using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace devicetracker.Models
{
    public class Device
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public virtual User User  { get; set; }
    }
}