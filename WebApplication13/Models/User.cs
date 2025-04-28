using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebApplication13.Models
{
  
        public class User
        {
            [Key]
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string FullName { get; set; }
            public ICollection<Role> Role { get; set; } // Guest, Member, Customer
            public DateTime? RegistrationDate { get; set; }
            public string AccountStatus { get; set; }


        }

    
}
