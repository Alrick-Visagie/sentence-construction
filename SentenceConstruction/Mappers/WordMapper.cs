using SentenceConstruction.Models;
using SentenceConstruction.Repository.Models;
using System.Collections.Generic;

namespace SentenceConstruction.Mappers
{
    public static class WordMapper
    {
        public static WordDto Map(IEnumerable<Words> words)
        {
            var result = new WordDto();

            foreach (var word in words) 
            {
                if (word.Name == "Nouns")
                {
                    result.Nouns = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Verbs")
                {
                    result.Verbs = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Adjectives")
                {
                    result.Adjectives = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Adverbs") 
                {
                    result.Adverbs = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Pronouns")
                {
                    result.Pronouns = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Prepositions")
                {
                    result.Prepositions = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Conjunctions")
                {
                    result.Conjunctions = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Determiners")
                {
                    result.Determiners = new List<string>(word.Word.Split(','));
                }

                if (word.Name == "Exclamations")
                {
                    result.Exclamations = new List<string>(word.Word.Split(','));
                }
            }

            return result;
        }
    }
}
