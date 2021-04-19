using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HudanSpace.Models
{
    public class User
    {
        [Key]
        public string Name { get; set; }
        public int Id { get; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Course { get; set; }
        public User()
        {

        }
    }
}
