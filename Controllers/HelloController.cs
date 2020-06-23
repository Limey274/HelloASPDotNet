using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers
{
   
    public class HelloController : Controller
    {
        //GET: /hello
               public IActionResult Index()
        {
                 string html = "<form method='post' action='/helloworld>" +
                            "<input type='text' name='name'/>" +
                             "<label= 'lang'> Choose a Language:</label >" +
                             "<select name = 'language'> " +
                 "<option value = 'English'> English </option>" +
                "<option value = 'Spanish'> Spanish </option>" +
                "<option value = 'French'> French </option>" +
                "<option value = 'German'> German </option>" +
                "<option value = 'Hindi'> Hindi </option>" +
                "<option value = 'Japanese'> Japenese </option>" +
                "</select>" +
                "<input type = 'submit' value = 'Say Hi'/>" +
                "</form>";
 

                return Content(html, "text/html");
        }

        // GET: /<controller>/welcome
        
        [HttpPost("/hello")]
        
        public IActionResult Welcome(string name = "World", string language = "English")
        {
            
            return Content(CreateMessage(name, language), "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            
            if (language == "English")
            {
                return "Hello ";
            }
            if ( language == "Spainish")
            {
                return "Hola";
            }
            else if (language == "French")
            {
                return "Bonjour ";
            }
            else if (language == "German")
            {
                return "Guten Tag ";
            }
            else if (language == "Hindi")
            {
                return "Namaste";
            }
            else if (language == "Japenese")
            {
                return "Konnichiwa";
            }
            else 
            {
                return "What was that?";
            };

            //return greeting + name;
        
        }
           
    }
}
