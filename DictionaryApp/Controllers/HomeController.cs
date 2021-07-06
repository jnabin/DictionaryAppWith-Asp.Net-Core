using DictionaryApp.Models;
using DictionaryApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Controllers
{
    public class HomeController : Controller
    {
        DictContext dictContext = new DictContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Word()
        {
            
            List<Word> words = new List<Word>();
            if (!dictContext.Words.Any())
            {

                if (System.IO.File.Exists(@"D:\AspCore\word.txt"))
                {

                    // Read file using StreamReader. Reads file line by line  
                    using (StreamReader file = new StreamReader(@"D:\AspCore\word.txt"))
                    {
                        int counter = 1;
                        string word;

                        while ((word = file.ReadLine()) != null)
                        {
                            words.Add(new Word
                            {
                                text = word,
                                Mark = true
                            });
                            counter++;
                        }
                        file.Close();
                    }
                }

                List<Word> sortedWord = words.OrderBy(x => x.text).ToList();
                dictContext.Words.AddRange(sortedWord);
                dictContext.SaveChanges();
            }
            List<Word> allWords = dictContext.Set<Word>().ToList();
            foreach(var item in allWords)
            {
                item.nouns = dictContext.Set<Noun>().Where(x => x.WordId == item.WordId).ToList();
                item.proNouns = dictContext.Set<ProNoun>().Where(x => x.WordId == item.WordId).ToList();
            }
            
            return View(allWords.OrderBy(x=>x.text));
        }
        [HttpGet]
        public IActionResult ManageWord()
        {
            
            List<Word> words = dictContext.Set<Word>().ToList().OrderBy(x=>x.text).ToList();
            ViewBag.words = words;
            
            return View();
        }

        [HttpPost]
        public IActionResult AddNoun()
        {
            int wordid =Convert.ToInt32(Request.Form["hiddeWord"]);
            dictContext.Set<Noun>().RemoveRange(dictContext.Set<Noun>().Where(x => x.WordId == wordid));
            dictContext.SaveChanges();
            for (int i=1; i<5; i++)
            {
                string nounId = Request.Form["Noun" + i];
                if(nounId != null)
                {
                    Noun noun = new Noun();
                    noun.WordId = wordid;
                    noun.word = dictContext.Set<Word>().Find(wordid);

                    noun.NounMappingWordId = Convert.ToInt32(nounId);
                    noun.NounMappingWord = dictContext.Set<Word>().Find(Convert.ToInt32(nounId));

                    dictContext.Nouns.Add(noun);
                    dictContext.SaveChanges();
                }
                
            }
            return RedirectToAction("Word");
        }

        [HttpPost]
        public IActionResult AddProNoun()
        {
            int wordid = Convert.ToInt32(Request.Form["hiddeWord"]);
            dictContext.Set<ProNoun>().RemoveRange(dictContext.Set<ProNoun>().Where(x => x.WordId == wordid));
            dictContext.SaveChanges();
            for (int i = 1; i < 5; i++)
            {
                string proNounId = Request.Form["pronoun" + i];
                if (proNounId != null)
                {
                    ProNoun pnoun = new ProNoun();
                    pnoun.WordId = wordid;
                    pnoun.word = dictContext.Set<Word>().Find(wordid);

                    pnoun.ProNounMappingWordId = Convert.ToInt32(proNounId);
                    pnoun.ProNounMappingWord = dictContext.Set<Word>().Find(Convert.ToInt32(proNounId));

                    dictContext.ProNouns.Add(pnoun);
                    dictContext.SaveChanges();
                }

            }
            return RedirectToAction("Word");
        }

        [HttpPost]
        public IActionResult AddESentence()
        {
            int wordid = Convert.ToInt32(Request.Form["hiddeWord"]);
            dictContext.Set<WordSentence>().RemoveRange(dictContext.Set<WordSentence>().Where(x => x.WordId == wordid));
            dictContext.SaveChanges();
 
            for (int i = 1; i < 5; i++)
            {
                string eSentenceText = Request.Form["ESentence" + i];
                List<Sentence> sentences = dictContext.Set<Sentence>().ToList();
                foreach(var item in sentences)
                {
                    if(item.SentenceText == eSentenceText)
                    {
                        dictContext.Set<Sentence>().Remove(dictContext.Set<Sentence>().Find(item.SentenceId));
                    }
                }
                if (eSentenceText != "")
                {
                    Sentence sentence = new Sentence();
                    sentence.SentenceText = eSentenceText;
                    dictContext.Sentences.Add(sentence);
                    dictContext.SaveChanges();

                    WordSentence wordSentence = new WordSentence();
                    wordSentence.SentenceId = sentence.SentenceId;
                    wordSentence.WordId = wordid;
                    dictContext.WordSentences.Add(wordSentence);
                    dictContext.SaveChanges();
                }

            }
            return RedirectToAction("Word");
        }

        [HttpPost]
        public JsonResult getWordDetails(string value)
        {
            
            if (dictContext.Set<Word>().Where(x => x.text == value).FirstOrDefault() == null)
            {
                return Json("not found");
            }          
            WordViewModel wordViewModel = new WordViewModel();
            int wordId = dictContext.Set<Word>().Where(x => x.text == value).FirstOrDefault().WordId;

            foreach(var item in dictContext.Set<Noun>().Where(x => x.WordId == wordId))
            {
                wordViewModel.nouns.Add(dictContext.Set<Word>().Find(item.NounMappingWordId).text);
            }
            foreach (var item in dictContext.Set<ProNoun>().Where(x => x.WordId == wordId))
            {
                wordViewModel.proNouns.Add(dictContext.Set<Word>().Find(item.ProNounMappingWordId).text);
            }

            List<Sentence> sentences1 = new List<Sentence>();
            foreach(var item in dictContext.Set<Sentence>().ToList())
            {
                if(item.SentenceText.Split(' ').Contains(value))
                {
                    wordViewModel.sentences.Add(item.SentenceText);
                }
            }
            return Json(new { wordId = wordId, nouns = wordViewModel.nouns, sentencesa = wordViewModel.sentences, pronouns = wordViewModel.proNouns });
           

        }

        public IActionResult DeleteWord(string value)
        {
            dictContext.Set<Word>().Remove(dictContext.Set<Word>().Find(Convert.ToInt32(value)));
            dictContext.SaveChanges();
            return Json("success");
        }

        [HttpPost]
        public JsonResult SearchWord(string value)
        {
            List<string> wordList = new List<string>();
            foreach(var item in dictContext.Set<Word>().ToList())
            {
                if (item.text.StartsWith(value))
                {
                    wordList.Add(item.text);
                }
            }
            return Json(new { wordList = wordList});
        }

        [HttpPost]
        public IActionResult AddWord(Word word)
        {
            if(dictContext.Set<Word>().ToList().Where(x => x.text == word.text).Any())
            {
                return RedirectToAction("ManageWord");
            }
            word.Mark = false;
            dictContext.Set<Word>().Add(word);
            dictContext.SaveChanges();
            return RedirectToAction("ManageWord");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
