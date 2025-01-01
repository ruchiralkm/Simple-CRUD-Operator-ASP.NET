using System.ComponentModel.DataAnnotations;

namespace ServiceSolution.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(300)]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
