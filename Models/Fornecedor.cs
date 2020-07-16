using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarGlass.Models
{

    public class Fornecedor
    {
        [Key]
        public int empresaId { get; set; }
        public Empresa empresa { get; set; }
        public string nome { get; set; }
        public string documento { get; set; }
        public DateTime dataCadastro  { get; set; }    
        public List<string> telefones { get; set; }
        

        public Fornecedor ()
        {

        }
    }
}