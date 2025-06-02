using System.ComponentModel.DataAnnotations;

namespace RecaptchaApiExample.Entities;

public class RecaptchaLog
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(45)]
    public string IpAddress { get; set; } = string.Empty;

    [Required]
    [MaxLength(500)]
    public string Token { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Action { get; set; } = string.Empty;

    public bool IsSuccess { get; set; }

    [MaxLength(255)]
    public string? Hostname { get; set; }

    [MaxLength(1000)]
    public string? ErrorCodes { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? ChallengeTimestamp { get; set; }
}
