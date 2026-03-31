using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
[Required]
 public  string Email { get; set; } = String.Empty;

 public required string Password { get; set; }
}
