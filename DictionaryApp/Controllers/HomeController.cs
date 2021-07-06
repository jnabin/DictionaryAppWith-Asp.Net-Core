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
                                text = word
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
                string nounText = Request.Form["Noun" + i];
                if(nounText != "")
                {
                    Noun noun = new Noun();
                    noun.WordId = wordid;
                    noun.word = dictContext.Set<Word>().Find(wordid);
                    noun.text = nounText;
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
                string proNounText = Request.Form["pronoun" + i];
                if (proNounText != "")
                {
                    ProNoun pnoun = new ProNoun();
                    pnoun.WordId = wordid;
                    pnoun.word = dictContext.Set<Word>().Find(wordid);
                    pnoun.text = proNounText;
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
                wordViewModel.nouns.Add(item.text);
            }
            foreach (var item in dictContext.Set<ProNoun>().Where(x => x.WordId == wordId))
            {
                wordViewModel.proNouns.Add(item.text);
            }

            List<Sentence> sentences1 = new List<Sentence>();
            foreach(var item in dictContext.Set<Sentence>().ToList())
            {
                if(item.SentenceText.Split(' ').Contains(value))
                {
                    wordViewModel.sentences.Add(item.SentenceText);
                }
            }
            return Json(new { nouns = wordViewModel.nouns, sentencesa = wordViewModel.sentences, pronouns = wordViewModel.proNouns });
           

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
