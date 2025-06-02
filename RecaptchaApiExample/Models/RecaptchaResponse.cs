namespace RecaptchaApiExample.Models;

public class RecaptchaResponse
{
    public bool Success { get; set; }
    public DateTime ChallengeTs { get; set; }
    public string Hostname { get; set; } = string.Empty;
    public string[] ErrorCodes { get; set; } = Array.Empty<string>();
}
