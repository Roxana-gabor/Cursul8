using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cursul8.Models
{
    [Bind(Exclude = "Country")]

    
    public class ProjectEvaluation
    {
       public string name { get; set; }
        [StringLength(10)]
       public string city { get; set; }
        public string country { get; set; }
        [Range(1, 10)]
        public double rating { get; set; }
        public int id { get; set; }
    }
}