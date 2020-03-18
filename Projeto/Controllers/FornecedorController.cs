using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class FornecedorController : Controller
    {
        //[privado/public/protected] [TipoResultado] [Nome da Acao]
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(FornecedorViewModel model)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
            }

            return View();
        }
    }
}