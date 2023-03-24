using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLogin.Controllers
{
    public class UsuarioController : Controller
    {
        #region [Properties]
        private readonly UsuarioDomain oUsuarioDomain = null;//new UsuarioDatabase();
        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioController()
        {
            oUsuarioDomain = new UsuarioDomain();
        }
        #endregion

        #region [ActionResult]
        public IActionResult Index()
        {
            var response = oUsuarioDomain.ValidateLogin("fer","123");
            return View();
        }

        #endregion
        
    }
}
