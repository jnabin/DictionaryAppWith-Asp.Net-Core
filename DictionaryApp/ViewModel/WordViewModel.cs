using DictionaryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.ViewModel
{
    public class WordViewModel
    {
        public List<string> proNouns = new List<string>();
        public List<string> nouns = new List<string>();
        public List<string> translation = new List<string>();
        public List<int> translationId = new List<int>();
        public List<int> proNounsId = new List<int>();
        public List<int> nounsId = new List<int>();
        public List<string> sentences = new List<string>();
    }
}
