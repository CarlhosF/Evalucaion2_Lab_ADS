using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace _2Evaluacion_LabADS.Models
{
    public class Product
    {
        public Product() 
        {
        
        }
        public Product(int p,int s,int so,float pr, string d, string n)
        {
            this.IdProduct = p;
            this.IdProduct = s;
            this.price = pr;
            this.stock = so;
            this.description = d;
            this.name = n;
        }
        public int IdProduct { get; set; }
        public int IdStore { get; }


        [Display(Name = "Stock:")]
        [Required(ErrorMessage = "Requerido")]
        public int stock { get;  }



        [Display(Name = "Price:")]
        [Required(ErrorMessage = "Requerido")]
        public float price { get;  }



        [Display(Name = "Description:")]
        [MaxLength(length: 200, ErrorMessage = "máximo 200 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string description { get;  }



        [Display(Name = "Name:")]
        [MaxLength(length: 40, ErrorMessage = "máximo 40 caracteres")]
        [MinLength(length: 5, ErrorMessage = "minimo 5 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string name { get;  }


    }
}