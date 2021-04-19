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
        public string UserName { get; set; }
        public int UserID { get; }
        public string UserEmail { get; set; }
        public int UserPhone { get; set; }
        public string Course { get; set; }
        public User()
        {

        }
    }
}
