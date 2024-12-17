using System;
using System.ComponentModel.DataAnnotations;

namespace Workify.DTOs;

public class LoginUserDTO
{
    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}
