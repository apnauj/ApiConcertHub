using System.ComponentModel.DataAnnotations;

namespace ApiConcertHub.Models.DTO;

public class RegisterDTO
{
    [Required(ErrorMessage = "El mail es un campo obligatorio")]
    public string Mail { get; set; }
    [Required]
    [MinLength(8)]
    public string Password { get; set; }
    [Required]
    public string Role { get; set; }
}