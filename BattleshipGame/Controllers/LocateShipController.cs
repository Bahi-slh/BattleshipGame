using BattleshipGame.BLL;
using BattleshipGame.Data.DTOs;
using BattleshipGame.Data.Interfaces;
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

    public class LocateShipController : ControllerBase
    {

        private readonly ILogger<ConstructBoardController> _logger;
        public LocateShipController(ILogger<ConstructBoardController> logger)
        {
            _logger = logger;
        }

        //[Route("constructBoard")]
        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public ActionResult<IShipLocator> Post([FromBody] ShipDto shipDto)
        {
            try
            {
                var shipConstructor = new ShipConstructor();
                var ship = shipConstructor.AddShip(shipDto.Ship);

                var boardConstructor = new BoardConstructor();
                var board = boardConstructor.ConstructBoard(shipDto.BoardRow, shipDto.BoardColumn);

                var shipLocator=new ShipLocator();
                shipLocator.LocateShip(shipDto.Row, shipDto.Column, ship, board, shipDto.Direction);

                return Ok("Ship located successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError("There was an issue adding ship to board" + ex.Message);
                return BadRequest("There was an issue adding ship to board");
            }
        }
    }
}
