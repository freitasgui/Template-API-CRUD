using System.ComponentModel.DataAnnotations;

namespace templateAPI_core_7.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
    }
}
