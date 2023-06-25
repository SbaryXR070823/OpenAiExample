﻿using Microsoft.AspNetCore.Mvc;
using OpenAIApp.Services;


namespace OpenAIApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenAiController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOpenAiService _openAiService;

        public OpenAiController(
            ILogger<WeatherForecastController> logger,
            IOpenAiService openAiService)
        {
            _logger = logger;
            _openAiService = openAiService;
        }

        [HttpPost()]
        [Route("CompleteSentence")]
        public async Task<IActionResult> CompleteSentence(string text)
        {
            var result = await _openAiService.CompleteSentence(text);
            return Ok(result);
        }

        [HttpPost()]
        [Route("CompleteSentenceAdvance")]
        public async Task<IActionResult> CompleteSentenceAdvance(string text)
        {
            var result = await _openAiService.CompleteSentenceAdvance(text);
            return Ok(result);
        }


        [HttpPost()]
        [Route("AskQuestion")]
        public async Task<IActionResult> AskQuestion(string text)
        {
            var result = await _openAiService.CheckProgrammingLanguage(text);
            return Ok(result);
        }
    }
}