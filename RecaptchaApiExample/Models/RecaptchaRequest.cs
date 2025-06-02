namespace RecaptchaApiExample.Models;

public class RecaptchaRequest
{
    public string Token { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
}
