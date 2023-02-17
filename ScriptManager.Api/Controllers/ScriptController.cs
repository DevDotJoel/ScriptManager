using Microsoft.AspNetCore.Mvc;
using ScriptManager.Application.Common.Interfaces;
using ScriptManager.Application.Common.Models.Script;

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