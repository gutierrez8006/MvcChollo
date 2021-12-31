using Microsoft.AspNetCore.Mvc;
using MvcChollos2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MvcChollos2.Controllers
{
    public class ChollosController : Controller
    {
        RepositoryChollos repo;

        public ChollosController()
        {
            this.repo = new RepositoryChollos();
        }

        public async Task<IActionResult> Index()
        {
            List<MvcChollos2.Models.Chollo> lista = this.repo.GetChollos();

            if (lista.Count() == 0)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://webchollos.scm.azurewebsites.net/api/");
                var byteArray = Encoding.ASCII.GetBytes("$WebChollos:0vC0eNk0Jgt5gpwskvKixppCKHgXAiKWeEaNX8BpgPYvGF2LN2XleqBtSasD");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                var response = await client.PostAsync("triggeredwebjobs/WebJobChollosProgramado/run", null);

                lista = this.repo.GetChollos();
            }

            return View(this.repo.GetChollos());
        }
    }
}
