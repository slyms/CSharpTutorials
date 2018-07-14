using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Google.Apis.Customsearch library
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace ConsoleApp1.Helper
{
    public static class GoogleAPIsHelper
    {
        public static Search CustomSearch(string search, int page = 1)
        {
            //Replace the apiKey and cx with your credentials
            string apiKey = "AIzaSyCuwJfZ0CGUAtvcwSZN_xBQfeF - vSW7ulo";
            string cx = "001759386422403413361:kh7ioarldps";
            string query = search;

            CustomsearchService service = new CustomsearchService(new BaseClientService.Initializer
            {
                ApplicationName = "Google Custom Search Demo",
                ApiKey = apiKey,
            });

            CseResource.ListRequest listRequest = service.Cse.List(query);
            listRequest.Cx = cx;
            listRequest.Start = page;
            Search gSearch = listRequest.Execute();
            
            return gSearch;
        }
    }
}
