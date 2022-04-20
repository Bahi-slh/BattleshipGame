using BattleshipGame.Data.DTOs;
using BattleshipGame.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipGame.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AttackController : ControllerBase
    {
        private readonly ILogger<AttackController> _logger;

        public AttackController(ILogger<AttackController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public ActionResult<Boolean> Post(AttackDto attackDto)
        {
            try
            {
                var boardConstructor = new BoardConstructor();
                var board = boardConstructor.ConstructBoard(attackDto.BoardRows, attackDto.BoardColumns);

                var Attack = new Attack();
                var result = Attack.AttackCell(board, attackDto.Row, attackDto.Column);
                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("There was an issue attacking the board");

            }
        }
    }
}
