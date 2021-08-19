using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteLefisc.Models
{
    public class Fornecedores
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpfcnpj { get; set; }
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }

    }
}
