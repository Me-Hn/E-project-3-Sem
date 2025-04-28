using System.ComponentModel.DataAnnotations;

namespace WebApplication13.Models
{
    public class Role
    {
        [Key]
        public int Role_Id { get; set; }
        public string Roles { get; set; }
    }

}
