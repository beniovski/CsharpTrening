using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    class Asynchronus
    {

        public async Task Test()
        {
            var content =await GetContentAsync();
            Console.WriteLine(content);

        }

        public async Task<string> GetContentAsync()
        {
            HttpClient httpclient = new HttpClient();

            var response = await httpclient.GetAsync("https://jsonplaceholder.typicode.com/photos");
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        



    }
}
