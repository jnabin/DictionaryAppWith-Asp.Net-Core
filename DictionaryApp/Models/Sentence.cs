using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class Sentence
    {
        public int SentenceId { get; set; }

        public string SentenceText { get; set; }

        public List<WordSentence> wordSentences { get; set; }
    }
}
