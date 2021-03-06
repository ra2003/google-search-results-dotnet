using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/***
 * Client for SerpApi.com
 */
namespace SerpApi
{
  public class GoogleSearchResultsClient : SerpApiClient
  {

    public GoogleSearchResultsClient(Hashtable parameter, String apiKey) : base(parameter, apiKey, SerpApiClient.GOOGLE_ENGINE) { }

    public GoogleSearchResultsClient(String apiKey) : base(new Hashtable(), apiKey, SerpApiClient.GOOGLE_ENGINE) { }

    /*
     * Get list of location using Location API
     */
    public JArray GetLocation(string location, int limit)
    {
      string buffer = getRawResult("/locations.json", "location=" + location + "&limit=" + limit, false);
      return JArray.Parse(buffer);
    }
  }
}