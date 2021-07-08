using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class Word
    {
        public int WordId { get; set; }

        [Required]
        public string text { get; set; }

        public Boolean Mark { get; set; }

        public Boolean IsPublished { get; set; }

        [InverseProperty("word")]
        public List<Noun> nouns { get; set; }

        [InverseProperty("NounMappingWord")]
        public List<Noun> nounMapping { get; set; }

        [InverseProperty("word")]
        public List<ProNoun> proNouns { get; set; }

        [InverseProperty("ProNounMappingWord")]
        public List<ProNoun> proNounMapping { get; set; }

        public  virtual List<WordSentence> wordSentences { get; set; }

        public List<BanglaWordMapping> banglaWordMappings { get; set; }
    }
}
