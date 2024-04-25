using SistemaCadastro.Models;
using SistemaCadastro.Repo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace SistemaCadastro.Controllers
{
    public class VeiculosController : Controller
    {
        private VeiculosRepo _repositorio;



        public ActionResult ObterVeiculos()
        {
            _repositorio = new VeiculosRepo();

            ModelState.Clear();
            return View(_repositorio.ObterVeiculos());
        }



        [HttpGet]
        public ActionResult IncluirVeiculo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IncluirVeiculo(Veiculos veiculoObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repositorio = new VeiculosRepo();

                    if (_repositorio.IncluirVeiculo(veiculoObj))
                    {
                        ViewBag.Mensagem = ("Veículo Cadastrado com Sucesso!");
                    }
                }

                return RedirectToAction("ObterVeiculos");
            }
            catch (Exception)
            {

                return View("ObterVeiculos");
            }

        }



        [HttpGet]
        public ActionResult AtualizarVeiculo(int id)
        {
            _repositorio = new VeiculosRepo();
            return View(_repositorio.ObterVeiculos().Find(t => t.VeiculosId == id));
        }

        [HttpPost]
        public ActionResult AtualizarVeiculo(int id, Veiculos veiculoObj)
        {
            try
            {
                _repositorio = new VeiculosRepo();
                
                if (_repositorio.AtualizarVeiculo(veiculoObj))
                {
                    ViewBag.Mensagem = "Veículo atualizado com sucesso!!";
                }
                return RedirectToAction("ObterVeiculos");
            }
            catch (Exception)
            {
                return View("ObterVeiculos");
            }
        }

        public ActionResult ExcluirVeiculo(int id)
        {
            try
            {
                _repositorio = new VeiculosRepo();
                if (_repositorio.ExcluirVeiculo(id))
                {
                    ViewBag.Mensagem = "Time excluído com sucesso";
                }

                return RedirectToAction("ObterVeiculos");
                
            }
            catch (Exception)
            {
                return View("ObterVeiculos");
            }
        }


    }

}