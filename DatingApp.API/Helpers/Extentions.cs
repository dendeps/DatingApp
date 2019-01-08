using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extentions
    {
        public static void AddApplicationError(this HttpResponse response, string message){
            response.Headers.Add("AddApplication-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "AddApplication-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}