using System;
using System.ComponentModel.DataAnnotations;

namespace MiPrimeraAplicacionWebASP.Models
{
    public class Vehiculo
    {
        [Key]
        public int VehiculoID {get; set;}

        [Required(ErrorMessage = "La Marca del Vehiculo es Obligatoria")]
        [Display(Name = "marca" , Prompt ="Toyota")]
        public string marca {get; set;}
        
        [Required(ErrorMessage = "El modelo del vehiculo es requerido")]
        [Display(Name = "modelo", Prompt ="Hilux")]
        public string modelo {get; set;}
        
        [Required(ErrorMessage = "Debe ingresar el Año")]
        [Display(Name = "anio", Prompt ="2021")]
        public string anio {get; set;}
        
        [Required(ErrorMessage = "Debe ingresar la descripcion del Vehiculo")]
        [Display(Name = "descripcion", Prompt ="Es un carro en buen estado, poco millaje y a buen precio.")]
        public string descripcion {get; set;}
    }
}

