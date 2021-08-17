using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteLefisc.Models;

namespace TesteLefisc.Controllers
{
    public class FornecedoresController : Controller
    {
        public IActionResult Index()
        {
            List<Fornecedores> list = new List<Fornecedores>();
            list.Add(new Fornecedores { Id = 1, Name = "Fornecedor1", Cpfcnpj = "000.000.000-00", Phone = "(00) 00000000" });
            list.Add(new Fornecedores { Id = 2, Name = "Fornecedor1", Cpfcnpj = "000.000.000-00", Phone = "(00) 00000000" });
            return View(list);
        }
    }
}
