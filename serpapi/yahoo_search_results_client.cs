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
  public class YahooSearchResultsClient : SerpApiClient
  {
    public YahooSearchResultsClient(Hashtable parameter, String apiKey) : base(parameter, apiKey, SerpApiClient.YAHOO_ENGINE) { }
  }
}