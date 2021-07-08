using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class BanglaWord
    {
        public int BanglaWordId { get; set; }
        public string text { get; set; }
        public List<BanglaWordMapping> banglaWordMappings { get; set; }
    }
}
