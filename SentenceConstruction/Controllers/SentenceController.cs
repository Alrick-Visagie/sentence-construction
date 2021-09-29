using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SentenceConstruction.Models;
using SentenceConstruction.Serices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public List<SentenceDto> Get()
        {
            return _sentenceService.GetSentences();
        }

        [HttpPost]
        public void Save(SentenceDto sentence)
        {
             _sentenceService.SaveSentence(sentence);
        }
    }
}
