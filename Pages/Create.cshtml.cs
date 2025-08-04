using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceExample.Model;
using SourceExample.Services;

public class CreateModel : PageModel
{
    [BindProperty]
    public TodoItem Item { get; set; } = new();

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        TodoService.Add(Item);
        return RedirectToPage("/Index");
    }
}
