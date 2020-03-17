using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.Controllers
{
    public class ProdutoController : Controller
    {
        //[privado/public/protected] [TipoResultado] [Nome da Acao]
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}