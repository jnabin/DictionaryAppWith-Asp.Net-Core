using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class Noun
    {
        public int NounId { get; set; }
        [Required]
        public string text { get; set; }
        public int WordId { get; set; }
        public Word word { get; set; }
    }
}
