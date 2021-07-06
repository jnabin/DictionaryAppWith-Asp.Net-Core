using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class Noun
    {
        public int NounId { get; set; }
        public int WordId { get; set; }
        public int NounMappingWordId { get; set; }

        [ForeignKey("WordId")]
        public  Word word { get; set; }

        [ForeignKey("NounMappingWordId")]
        public  Word NounMappingWord { get; set; }
    }
}
