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
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public int UserPhone { get; set; }
        public string Course { get; set; }
        
        public User()
        {
            UserName = "N/A";
            UserID = 0;
            UserEmail = "N/A";
            UserPhone = 0;
        }
        
        public User(string Name, int ID)
        {
            this.UserName = Name;
            this.UserID = ID;
        }
    }
}
