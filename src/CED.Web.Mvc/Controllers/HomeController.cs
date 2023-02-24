using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CED.Controllers;

namespace CED.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CEDControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
