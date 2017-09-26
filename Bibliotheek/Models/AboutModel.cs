using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotheek.Models
{
    public class AboutModel
    {
        public string Name { get; set; }

        public DateTime Now => DateTime.Now;
        public double DaysUntilBirthDay { get; set; }
    }
}
