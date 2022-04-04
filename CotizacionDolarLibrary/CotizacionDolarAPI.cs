using System;
using System.IO;
using System.Net;
using CotizacionDolarLibrary.DTO;
using Newtonsoft.Json;

namespace CotizacionDolarLibrary
{
    public static class CotizacionDolarAPI
    {
        public static CotizacionDolarDTO ObtenerCotizacionDolar(string url)
        {
            url = $"{url}/dolaroficial";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) 
                            return null;
                        else
                        { 
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                // Do something with responseBody
                                var result = JsonConvert.DeserializeObject<CotizacionDolarDTO>(responseBody);
                                return result;
                            }
                        }
                    }
                }
            }
            catch (WebException)
            {
                throw;
            }
        }

    }
}
