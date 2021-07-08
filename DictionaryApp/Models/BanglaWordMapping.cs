using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class BanglaWordMapping
    {
        public int BanglaWordMappingId { get; set; }

        public int WordId { get; set; }

        public int BanglaWordId { get; set; }

        public Word word { get; set; }
        public BanglaWord banglaWord { get; set; }
    }
}
