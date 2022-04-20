using BattleshipGame.BLL;
using BattleshipGame.Data.Interfaces;
using BattleshipGame.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]

    public class ConstructBoardController : ControllerBase
    {
        private readonly ILogger<ConstructBoardController> _logger;
        public ConstructBoardController(ILogger<ConstructBoardController> logger)
        {
            _logger = logger;
        }

        //[Route("constructBoard")]
        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public ActionResult<IBoardConstructor> Post([FromBody] GameBoardDimention dimention)
        {
            try
            {
                var boardConstructor = new BoardConstructor();
                var gameBoard = boardConstructor.ConstructBoard(dimention.Rows, dimention.Columns);
                return Ok("New Board created successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError("Invalid Request at creating new board." + ex.Message);
                return BadRequest("Invalid Request");
            }
        }
    }
}
