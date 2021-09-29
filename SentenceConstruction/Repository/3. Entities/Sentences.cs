using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SentenceConstruction.Repository.Models
{
    public class Sentences
    {
        [Key]
        public string ID { get; set; }
        public string Sentence { get; set; }
    }
}
