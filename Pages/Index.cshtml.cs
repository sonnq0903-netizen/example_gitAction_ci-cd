using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceExample.Model;
using SourceExample.Services;
namespace SourceExample.Pages;

public class IndexModel : PageModel
{
    public List<TodoItem> Items { get; set; } = new();

    public void OnGet()
    {
        Items = TodoService.GetAll();
    }
}
