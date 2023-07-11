using System.ComponentModel.DataAnnotations;

namespace Lesson6.Models.ModelMetaDataTypes
{
    public class UserValidator
    {
        [EmailAddress(ErrorMessage = "Maili duzgun yaz")]
        public string Email { get; set; }

        [Required]
        [Range(10, 100)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Doldurmalisan burani!")]
        public double Rating { get; set; }
    }
}
