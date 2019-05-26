using System;

namespace Gateway.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this Microsoft.AspNetCore.Http.HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this System.DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;
            //if true i bjen qe hala se ka ditlindjen 
            if(theDateTime.AddYears(age) > DateTime.Today)
            {
                age--;
            }
            return age;
        }
        
    }
}