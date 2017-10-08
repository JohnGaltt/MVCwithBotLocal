
using IdeatonEntityFram07._10._2017.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace IdeatonEntityFram07._10._2017.Controllers
{
    public class HomeController : Controller
    {
        #region Start Deser
        //public RootObject GetData()
        //{
        //    WebRequest request = WebRequest.Create(@"http://localhost:3979/api/messages");

        //    request.Method = "GET";
        //    request.ContentType = "text/html";

        //    WebResponse response = request.GetResponse();

        //    string answer = String.Empty;

        //    using (Stream stream = response.GetResponseStream())
        //    {
        //        using (StreamReader reader = new StreamReader(stream))
        //        {
        //            answer = reader.ReadToEnd();
        //        }
        //    }

        //    response.Close();

        //  

        //    return obj;
        //}

        #endregion
        ContextComplain DB = new ContextComplain();

        public ActionResult AllFile()
        {
            
            
            return View(list);
        }


        public ActionResult Index()
        {
        



            return View();

        }
        public static List<RootObject> list = new List<RootObject>();
        [HttpGet]
        public ActionResult BotData()
        {
            WebRequest request = WebRequest.Create(@"http://localhost:3979/api/messages");

            request.Method = "GET";
            request.ContentType = "application/json";

            WebResponse response = request.GetResponse();

            string answer = String.Empty;

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    answer = reader.ReadToEnd();
                }
            }
            //  IEnumerable<RootObject> Dbc = DB.ComplanDB;


            response.Close();
            var obj = JsonConvert.DeserializeObject<string>(answer,new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore});
            
            RootObject help = JsonConvert.DeserializeObject<RootObject>(obj);
            list.Add(help);
      
            return View();
        }
       

    }
}