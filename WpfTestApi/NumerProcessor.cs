using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApi {
    public class NumerProcessor {
        public static async Task<NumerModel> LoadNumerData() {
            string url = "http://localhost:5000/api/ch1";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url)) {
                if (response.IsSuccessStatusCode) {
                    NumerModel data = await response.Content.ReadAsAsync<NumerModel>();
                    return data;
                } else {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
