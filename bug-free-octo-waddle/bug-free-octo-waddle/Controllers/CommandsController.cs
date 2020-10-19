using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bug_free_octo_waddle.Data;
using bug_free_octo_waddle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bug_free_octo_waddle.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommandRepo _mockCommandRepo = new MockCommandRepo();

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _mockCommandRepo.GetAppCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _mockCommandRepo.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}