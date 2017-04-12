using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Zani.Thomas._5i.XMLReadWrite.Controllers
{
    public class DefaultController : Controller
    {
        private Persone p{ get; set; }
        // GET: Default
        public ActionResult Index()
        {
            string nomeFile = HostingEnvironment.MapPath(@"~/App_Data/dati.xml");
          

            p = new Persone(nomeFile);
            p.Aggiungi();
            return View(p);
        }


            public ActionResult azione(string a)
        {
            return View(a);
        }

    
    }
}