using Microsoft.AspNetCore.Mvc;
using ScriptManager.Application.Common.Dtos;
using ScriptManager.Application.Common.Interfaces;

namespace ScriptManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScriptController : ControllerBase
    {
        private readonly IScriptService _scriptService;
        public ScriptController(IScriptService scriptService)
        {
            _scriptService = scriptService;

        }
        [HttpGet]
        public async Task<IActionResult> GetScripts()
        {
            return Ok(await _scriptService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetScriptById(int id)
        {
            return Ok(await _scriptService.GetById(id));
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateUpdateScriptDto script)
        {
            return Ok(await _scriptService.Create(script));
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(CreateUpdateScriptDto script)
        {
            return Ok(await _scriptService.Update(script));
        }

    }
}