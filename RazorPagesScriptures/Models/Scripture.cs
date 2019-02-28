using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesScriptures.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Book { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Notes { get; set; }
       
    }
}
