using System.Security.Cryptography.X509Certificates;
using clase3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;

namespace Herramientas_de_programacion.Pages
{
    public class GameListModel : PageModel
    {
        public List<Game> Games {get; set;} = new List<Game>();
        [BindProperty]

        public Game NewGame {get; set;}

        public string NombreDePropiedad{get; set;}

        public void OnGet()
        {
            Games = GameService.GetAll();
        }

         public IActionResult OnPost()
        {
            var newObject = NewGame;
            GameService.Create(newObject);
            return RedirectToAction("Get");
        }
    }
}
