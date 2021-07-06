using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApp.Models
{
    public class DictContext: DbContext
    {
        public DbSet<Word> Words { get; set; }
        public DbSet<Noun> Nouns { get; set; }
        public DbSet<ProNoun> ProNouns { get; set; }
        public DbSet<Sentence> Sentences { get; set; }

        public DbSet<WordSentence> WordSentences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\AspCore\dictionary.sqlite");
    }
}
