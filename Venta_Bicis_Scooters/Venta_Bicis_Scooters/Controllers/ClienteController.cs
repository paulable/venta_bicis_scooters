﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Venta_Bicis_Scooters.Models;

namespace Venta_Bicis_Scooters.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        BD_VENTAS_BICICLETA_SCOOTEREntities db = new BD_VENTAS_BICICLETA_SCOOTEREntities();
        public ActionResult PrincipalCliente()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

    }
}