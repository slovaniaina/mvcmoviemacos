using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public HelloWorldController()
        {
            
        }

		// 
		// GET: /HelloWorld/

		/*public string Index()
		{
			return "This is my default action...";
		}*/

		// 
		// GET: /HelloWorld/Welcome/ 

		public string Welcome(string name, int numtimes = 1)
		{
            if(!string.IsNullOrEmpty(name)){
                return HtmlEncoder.Default.Encode($" Hello {name} numtimes {numtimes}");
            }
            return "Name is null";
		}
    }
}
