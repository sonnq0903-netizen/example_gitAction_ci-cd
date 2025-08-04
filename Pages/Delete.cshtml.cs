using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceExample.Model;
using SourceExample.Services;

public class DeleteModel : PageModel
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
        TodoService.Delete(Item.Id);
        return RedirectToPage("/Index");
    }
}
