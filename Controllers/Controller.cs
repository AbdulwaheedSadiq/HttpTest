
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using resp;

namespace HttpTest{
    [ApiController]
    [Route("Api/HttpTest")]
    public class Controller:ControllerBase{

[HttpGet("{id}")]
        public async Task<string> get(int id) { 


         string Endpoint = "https://ors.brela.go.tz/um/load/load_nida/"+id;

         Response response = new Response();

         var client = new HttpClient();
         HttpResponseMessage r = await client.GetAsync(Endpoint);  

        var re = r.Content.ReadAsStringAsync().Result;

        // response.FIRSTNAME =re.FIRSTNAME;
        // response.MIDDLENAME = re.MIDDLENAME;
        // response.DATEOFBIRTH = re.DATEOFBIRTH;
        // response.NATIONALITY = re.NATIONALITY;
        // response.NIN = re.NIN;
        // response.SURNAME = re.SURNAME;
        // response.SEX = re.SEX;
        

        

         return re;

             }

    }

}