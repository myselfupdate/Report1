using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Report1.Models
{
    public class DataTable
    {
        [Key]
        public int zifu { get; set; }
        
        public int age { get; set; }
        //public int sales { get; set; }
        //public  int dislodge { get; set; }
        //public int payment { get; set; }
        //public int  debt{ get; set; }
        //public int  refund{ get; set; }
        //public int aggregate { get; set; }
    }
}