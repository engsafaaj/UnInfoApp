using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UnInfoApp.Code
{
    public class HttpHelper
    {
        public async Task<string> GetResponeAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var respone=await client.GetAsync(url);
                if (respone.IsSuccessStatusCode)
                {
                    return await respone.Content.ReadAsStringAsync();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
