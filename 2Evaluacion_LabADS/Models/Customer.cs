using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace _2Evaluacion_LabADS.Models
{
    public class Customer
    {
        public Customer() { }
        public Customer(int id,string naC,string LstN, string ema,string pass,string phon) 
        {
            this.IdCustomer = id;
            this.nameCustomer = naC;
            this.lastNameCustomer = LstN;
            this.emailCustomer = ema;
            this.passwordCustomer = pass;
            this.phoneNumber = phon;
        }
        public int IdCustomer { get; set; }



        [Display(Name = "Name Customer:")]
        [MaxLength(length: 40, ErrorMessage = "máximo 40 caracteres")]
        [MinLength(length: 5, ErrorMessage = "minimo 5 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string nameCustomer { get;  }



        [Display(Name = "Last Name Customer:")]
        [MaxLength(length: 40, ErrorMessage = "máximo 40 caracteres")]
        [MinLength(length: 5, ErrorMessage = "minimo 5 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string lastNameCustomer { get;  }



        [Display(Name = "Email Customer:")]
        [MaxLength(length: 200, ErrorMessage = "máximo 200 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string emailCustomer { get;  }



        [Display(Name = "Password Customer:")]
        [MaxLength(length: 200, ErrorMessage = "máximo 200 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string passwordCustomer { get;  }



        [Display(Name = "Phone Number:")]
        [MaxLength(length: 40, ErrorMessage = "máximo 40 caracteres")]
        [MinLength(length: 5, ErrorMessage = "minimo 5 caracteres")]
        [Required(ErrorMessage = "Requerido")]
        public string phoneNumber { get; }
    }
}