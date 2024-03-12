using CryptoFinderAPI.Data;
using CryptoFinderAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CryptoFinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        private readonly DataContext _context;

        public CryptoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Crypto>>> GetAllCryptos()
        {
            var cryptos = await _context.Cryptos.ToListAsync();

            return Ok(cryptos);
        }


        [HttpGet("{id}")]
        //[Route("{id}")]
        public async Task<ActionResult<Crypto>> GetCrypto(int id)
        {
            var crypto = await _context.Cryptos.FindAsync(id);
            if(crypto is null)
                //return BadRequest();
                return BadRequest("Crypto not found.");

            return Ok(crypto);
        }


        [HttpPost]
        public async Task<ActionResult<List<Crypto>>> AddCrypto(Crypto crypto)
        {
            _context.Cryptos.Add(crypto);
            await _context.SaveChangesAsync();

            return Ok(await _context.Cryptos.ToListAsync());
        }


        [HttpPut]
        public async Task<ActionResult<List<Crypto>>> UpdateCrypto(Crypto crypto)
        {
            _context.Cryptos.Add(crypto);
            await _context.SaveChangesAsync();

            return Ok(await _context.Cryptos.ToListAsync());
        }

    }
}
