using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebInfectado.Models;
using WebInfectado.Services;

namespace WebInfectado.Controllers
{
    public class InfectadosController : Controller
    {
        private readonly InfectadoService _infectadoService;

        public InfectadosController(InfectadoService infectadoService)
        {
            _infectadoService = infectadoService;
        }

        public IActionResult Index()
        {
            var list = _infectadoService.ListarTodos();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
