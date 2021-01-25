using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Selenium
{
    public class Config
    {
        public static string BaseUrl = "https://www.merrjep.com/";
        public static string BaseUrl1 = "https://intersportks.com/";
        public static string BaseUrl2 = "https://www.e-baa.com/";
        public static string BaseUrl3 = "http://www1.la.dell.com/content/default.aspx?c=ai&l=en&s=gen&~ck=pn&~ck=pn";
        public static string BaseUrl4 = "https://gjirafa50.com/";
        public static string ScreenshotDir = @"C:\ScreenshotDir";

        public static class Ebaa
        {
            public static string search = "mbushes te telefonit";
            public static string search1 = "kapela";
        }
         
        
        
        public static class Intersport
        {
            public static string search = "adidas";

        }
        public static class MerrJep
        {
            public static string search = "banes";
            public static string serach1 = "vetura";

        }

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "M0196";
                public static string Password = "Valid";
            }

            public static class Invalid
            {
                public static string Username = "M0196";
                public static string Password = "11111111";
            }
        }

        public static class AlertMessages
        {
            public static string ValidLink = "Linku eshte valid";
            public static string InvalidLink = "Linku eshte invalid";

            public static string ValidCredentials = "Arianit Gerqina";
            public static string InvalidCredentials = "Përdoruesi ose Fjalëkalimi është gabim.";
        }
    }
}
