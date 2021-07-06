using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class ProNoun
    {
        public int ProNounId { get; set; }
       
        public int WordId { get; set; }

        public int ProNounMappingWordId { get; set; }

        [ForeignKey("WordId")]
        public Word word { get; set; }

        [ForeignKey("ProNounMappingWordId")]
        public Word ProNounMappingWord { get; set; }
    }
}
