using System.ComponentModel.DataAnnotations;

namespace WebApplication15.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Cognome")]
        public string Surname { get; set; }
    }
}
