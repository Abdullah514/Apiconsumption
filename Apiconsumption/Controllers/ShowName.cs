using Microsoft.AspNetCore.Mvc;
using Apiconsumption.Models;
using Newtonsoft.Json;

namespace Apiconsumption.Controllers
{
    public class ShowName : Controller
    {
        Abdullah name = new Abdullah();
        public async Task<ActionResult> Index()

        {
            List<Name> nlist = new List<Name>();
            HttpClient client = name.Initial();
            HttpResponseMessage res = await client.GetAsync("");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                nlist = JsonConvert.DeserializeObject<List<Name>>(result);
            }

            return View(nlist);
        }
    }
}
