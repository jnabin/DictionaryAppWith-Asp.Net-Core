using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class WordSentence
    {
        public int WordSentenceId { get; set; }

        public int WordId { get; set; }
        public virtual Word Word { get; set; }
        public int SentenceId { get; set; }
        public virtual Sentence Sentence { get; set; }


    }
}
