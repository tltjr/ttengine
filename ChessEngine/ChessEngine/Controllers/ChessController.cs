using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ChessEngine.Controllers
{
    [ApiController]
    public class ChessController : ControllerBase
    {
        [Route("initial")]
        [HttpGet]
        public IActionResult GetInitialBoard()
        {
            var board = new List<List<ChessPiece>>
            {
                new List<ChessPiece>
                {
                    new ChessPiece(true, 4),
                    new ChessPiece(true, 2),
                    new ChessPiece(true, 3),
                    new ChessPiece(true, 5),
                    new ChessPiece(true, 6),
                    new ChessPiece(true, 3),
                    new ChessPiece(true, 2),
                    new ChessPiece(true, 4)
                },
                new List<ChessPiece>
                {
                    new ChessPiece(true, 1),
                    new ChessPiece(true, 1),
                    new ChessPiece(true, 1),
                    new ChessPiece(true, 1),
                    new ChessPiece(true, 1),
                    new ChessPiece(true, 1),
                    new ChessPiece(true, 1),
                    new ChessPiece(true, 1)
                },
                new List<ChessPiece>
                {
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0)
                },
                new List<ChessPiece>
                {
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0)
                },
                new List<ChessPiece>
                {
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(false, 1),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0)
                },
                new List<ChessPiece>
                {
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0),
                    new ChessPiece(null, 0)
                },
                new List<ChessPiece>
                {
                    new ChessPiece(false, 1),
                    new ChessPiece(false, 1),
                    new ChessPiece(false, 1),
                    new ChessPiece(false, 1),
                    new ChessPiece(null, 0),
                    new ChessPiece(false, 1),
                    new ChessPiece(false, 1),
                    new ChessPiece(false, 1)
                },
                new List<ChessPiece>
                {
                    new ChessPiece(false, 4),
                    new ChessPiece(false, 2),
                    new ChessPiece(false, 3),
                    new ChessPiece(false, 5),
                    new ChessPiece(false, 6),
                    new ChessPiece(false, 3),
                    new ChessPiece(false, 2),
                    new ChessPiece(false, 4)
                }
            };
            return Ok(board);
        }
    }

    public class ChessPiece
    {
        public bool? IsBlack { get; set; }
        public PieceKind PieceKind { get; set; }

        public ChessPiece(bool? isBlack, int pieceKind)
        {
            IsBlack = isBlack;
            PieceKind = (PieceKind) pieceKind;
        }
    }

    public enum PieceKind
    {
        Empty = 0,
        Pawn = 1,
        Knight = 2,
        Bishop = 3,
        Rook = 4,
        Queen = 5,
        King = 6
    }
}
