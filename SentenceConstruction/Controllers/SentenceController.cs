using Microsoft.AspNetCore.Mvc;
using SentenceConstruction.Models;
using SentenceConstruction.Serices;
using System.Collections.Generic;

namespace SentenceConstruction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentenceController : ControllerBase
    {
        private readonly ISentenceService _sentenceService;
        public SentenceController(ISentenceService sentenceService)
        {
            _sentenceService = sentenceService;
        }

        [HttpGet("GetSentences")]
        public List<SentenceDto> GetSentences()
        {
            return _sentenceService.GetSentences();
        }

        [HttpPost("SaveSentences")]
        public void SaveSentences(SentenceDto sentence)
        {
             _sentenceService.SaveSentence(sentence);
        }
    }
}
