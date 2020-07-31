﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApi {
    public class SunProcessor {
        public static async Task<SunModel> LoadSunInformation() {
            string url = "https://api.sunrise-sunset.org/json?lat=13.03887&lng=101.490104&date=today";
           
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url)) {
                if (response.IsSuccessStatusCode) {
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();
                    return result.Results;
                } else {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
