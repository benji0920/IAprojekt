using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
    }

    public void OnPost(string message)
    {
        // Guardamos el mensaje sin escaparlo para demostrar la vulnerabilidad XSS
        Message = message;
    }
}
