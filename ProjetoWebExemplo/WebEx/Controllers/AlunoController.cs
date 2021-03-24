using Domain.Interfaces.Services;
using Infrastruct.DTO;
using Services.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebEx.Controllers
{
    public class AlunoController : Controller
    {
        IAlunoService _alunoService;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Pesquisar(AlunoDTO alunoDTO)
        {
            _alunoService = new AlunoService();

            return Json(_alunoService.FindByFilter(alunoDTO), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Adicionar(AlunoDTO alunoDTO)
        {
            try
            {
                _alunoService = new AlunoService();

                _alunoService.Add(alunoDTO);

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json( new { success = false, erro = ex.Message });
            }
        }
    }
}