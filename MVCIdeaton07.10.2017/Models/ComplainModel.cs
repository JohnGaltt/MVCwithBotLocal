using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIdeaton07._10._2017.Models
{
    public class ComplainModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }

    }
}