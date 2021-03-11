using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEx.Models;

namespace WebEx.Controllers
{
    public class AlunoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Funcionou";
            return View();
        }
        [HttpPost]
        public ActionResult Confirmar(AlunoViewModel objView)
        {
            if (objView.matricula != "")
                ViewBag.Mensagem = ViewBag.Mensagem + ": de novo";
            else
                ViewBag.Mensagem = ViewBag.Mensagem + ": erro";
            return View("Index");
        }
    }
}