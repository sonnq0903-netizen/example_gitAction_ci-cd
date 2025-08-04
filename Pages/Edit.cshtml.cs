using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceExample.Model;
using SourceExample.Services;

public class EditModel : PageModel
{
    [BindProperty]
    public TodoItem Item { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var item = TodoService.Get(id);
        if (item is null) return RedirectToPage("/Index");

        Item = item;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        TodoService.Update(Item);
        return RedirectToPage("/Index");
    }
}
