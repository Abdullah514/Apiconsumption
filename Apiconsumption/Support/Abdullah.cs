namespace Apiconsumption.Controllers
{
    public class Abdullah
    {
        public HttpClient Initial()
        {
            var uname = new HttpClient();
            uname.BaseAddress = new Uri("https://localhost:7142/api/Names");
            return uname;
        }


    }
}