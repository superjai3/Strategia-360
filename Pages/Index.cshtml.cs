using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Herramientas_de_programacion.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [DisplayName("Nombre de Usuario")]

        public string UserName {get; set;} = "usuario1";
        [DisplayName("Correo Electrónico")]
        [Required]

        public string Mail {get; set;} = "usuario1@gmail.com";
        
        public List<string> Servicios { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Servicios = new List<string>();
        }

        public void OnGet()
        {
           
           var list = new List<string>();

            list.Add("Desarrollo de Software");
            list.Add("Diseño de Experiencia de Usuario (UX/UI)");
            list.Add("Desarrollo de Aplicaciones Móviles");
            list.Add("Gestión de Proyectos y Consultoría Tecnológica");
            list.Add("Pruebas de Software y Seguridad");
            list.Add("Mantenimiento y Soporte de Sistemas");
            list.Add("Análisis de Datos y Business Intelligence");
            list.Add("Estrategia de Marketing y Investigación de Mercado");
            list.Add("Marketing Digital y Publicidad");
            list.Add("Relaciones Públicas y Eventos de Marca");

            Servicios = list;
        }
    }
}
     
     