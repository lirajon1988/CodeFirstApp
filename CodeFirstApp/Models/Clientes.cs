using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models{

    public class Clientes{

        [Key]
        public int ClienteId { get; set; }

        [Required]
        [Display(Name ="Nome do Cliente")]
        public string NomeCliente { get; set; }

        [Required]
        [Display(Name ="Email do Cliente")]
        public string Email { get; set; }

    }
}