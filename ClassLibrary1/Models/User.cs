using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persia.DataLayer.Models
{
   public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }
    }
}
