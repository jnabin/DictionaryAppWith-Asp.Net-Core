using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class Word
    {
        public int WordId { get; set; }

        public string text { get; set; }
        public List<Noun> nouns { get; set; }
        public List<ProNoun> proNouns { get; set; }
        public  List<WordSentence> wordSentences { get; set; }
    }
}
