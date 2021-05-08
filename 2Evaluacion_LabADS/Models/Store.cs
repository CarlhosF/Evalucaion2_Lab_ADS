using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace _2Evaluacion_LabADS.Models
{
    public class Store
    {
        public Store() { }
        public Store(int ids, Boolean ts, string d,string add) 
        {
            this.IdStore = ids;
            this.typeStore = ts;
            this.description = d;
            this.addressStore = add;
        }
        public int IdStore { get; set; }

        [Display(Name = "Type Store:")]
        [Required(ErrorMessage = "Requerido")]
        public Boolean typeStore { get;  }



        [Display(Name = "Description:")]
        [MaxLength(length: 200, ErrorMessage = "máximo 200 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string description { get; }



        [Display(Name = "Address Store:")]
        [MaxLength(length: 40, ErrorMessage = "máximo 40 caracteres")]
        [MinLength(length: 5, ErrorMessage = "minimo 5 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string addressStore { get; }
    }
}