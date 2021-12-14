using System;
using System.ComponentModel.DataAnnotations;

namespace MiPrimeraAplicacionWebASP.Models
{
    public class Contactos
    {
        [Key]
        public int idContacto {get; set;}

        [Required(ErrorMessage = "El nombre es requerido.")]
        [Display(Name = "Nombre" , Prompt ="Leidy")]
        public string Nombre {get; set;}
        
        [Required(ErrorMessage = "El apellido es requerido")]
        [Display(Name = "apellido", Prompt ="Santos")]
        public string Apellido {get; set;}
        
        [Required(ErrorMessage = "El telefono es requerido.")]
        [Display(Name = "telefono", Prompt ="2121-2828")]
        public string Telefono {get; set;}
        
        [Required(ErrorMessage = "La direccion es requerido")]
        [Display(Name = "direccion", Prompt ="Vivo en tu corazon.")]
        public string Direccion {get; set;}
    }
}