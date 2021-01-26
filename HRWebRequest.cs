using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace HackerRankSolutions
{
    class HRWebRequest
    {

        public static int getCountries(string s, int p)
        {
            int count = -1;
            string url = $"https://jsonmock.hackerrank.com/api/countries/search?name={s}";
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Method = "GET";
            var getResponse = (HttpWebResponse)request.GetResponse();
            Stream newStream = getResponse.GetResponseStream();
            StreamReader sr = new StreamReader(newStream);
            var result = sr.ReadToEnd();
            Console.WriteLine(result);
            var countries = JsonConvert.DeserializeObject<Countries>(result);

            count = countries.data.Where(c => c.population > p).Count();

            return count;

        }

        public class Translations
        {
            public string de { get; set; }
            public string es { get; set; }
            public string fr { get; set; }
            public string it { get; set; }
            public string ja { get; set; }
            public string nl { get; set; }
            public string hr { get; set; }
        }

        public class CountryInfo
        {
            public string name { get; set; }
            public string nativeName { get; set; }
            public List<string> topLevelDomain { get; set; }
            public string alpha2Code { get; set; }
            public string numericCode { get; set; }
            public string alpha3Code { get; set; }
            public List<string> currencies { get; set; }
            public List<string> callingCodes { get; set; }
            public string capital { get; set; }
            public List<string> altSpellings { get; set; }
            public string relevance { get; set; }
            public string region { get; set; }
            public string subregion { get; set; }
            public List<string> language { get; set; }
            public List<string> languages { get; set; }
            public Translations translations { get; set; }
            public int population { get; set; }
            public List<object> latlng { get; set; }
            public string demonym { get; set; }
            public List<object> borders { get; set; }
            public List<string> timezones { get; set; }
        }

        public class Countries
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public List<CountryInfo> data { get; set; }
        }

    }
}
