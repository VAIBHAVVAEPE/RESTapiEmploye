using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTapiEmploye.Model
{
    [Table("Employe")]
    public class Employe
    {
       [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
}
