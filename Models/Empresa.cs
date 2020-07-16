using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarGlass.Models
{
    public class Empresa
    {
        [Key]
        public int empresaId { get; set; }
        public string uf { get; set; }
        public string nomeFantasia { get; set; }
        public string cnpj { get; set; }

        public Empresa()
        {

        }




    }
}