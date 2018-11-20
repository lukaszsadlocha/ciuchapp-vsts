using Microsoft.AspNetCore.Mvc;
using CiuchApp.Domain;
using CiuchApp.Dashboard.Services;
using Microsoft.Extensions.Logging;

namespace CiuchApp.Dashboard
{
    [ApiController]
    [Route("api/Pieces")]
    public class PiecesApiController : CiuchAppBaseApiController<Piece>
    {
        public PiecesApiController(ICrudService<Piece> serviceProvider, ILogger<Piece> logger) : base(serviceProvider, logger)
        {
        }

        //private readonly IPieceService _pieceService;

        //public PiecesApiController(IPieceService pieceService)
        //{
        //    this._pieceService = pieceService;
        //}
        //public UserManager<ApplicationUser> UserManager { get; private set; }

        //[HttpGet]
        //public IEnumerable<Piece> GetPieces()
        //{
        //    return _pieceService.GetPieces();
        //}

        //[HttpPut]
        //public IActionResult PutPiece([FromForm] Piece piece)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if(_pieceService.UpdatePiece(piece))
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public IActionResult PostPiece([FromForm] Piece piece)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    if (_pieceService.AddPiece(piece))
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}

        //[HttpDelete]
        //public IActionResult DeletePiece([FromForm] Piece piece)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (_pieceService.DeletePiece(piece))
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}

        //// GET: api/PiecesApi/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetPiece([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var piece = await _context.Pieces.FindAsync(id);

        //    if (piece == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(piece);
        //}

        // PUT: api/PiecesApi/5


        //private bool PieceExists(int id)
        //{
        //    return _context.Pieces.Any(e => e.Id == id);
        //}
    }
}