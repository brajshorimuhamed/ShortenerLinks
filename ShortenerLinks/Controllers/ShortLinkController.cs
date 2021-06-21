using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShortenerLinks.Models.Entities;
using ShortenerLinks.Models.Entities.Services.Service_Abstracts;

namespace ShortenerLinks.Controllers
{
    [Route("api/ShortLink")]
    [ApiController]
    public class ShortLinkController : ControllerBase
    {
        private readonly IShortUrlService _shortUrlService;

        public ShortLinkController(IShortUrlService shortUrlService)
        {
            _shortUrlService = shortUrlService;
        }

        // GET: api/ShortLink
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<ShortLink> shortLinks = _shortUrlService.GetLinks_Service();
            return Ok(shortLinks);
        }

        // GET: api/ShortLink/5
        [HttpGet("{shortUrl}", Name = "GetBy")]
        public IActionResult GetBy(string shortUrl, [FromBody] bool redirect = true)
        {
            ShortLink shortLink = _shortUrlService.GetItemFromDataStore(shortUrl);

            if (shortLink != null)
            {
                if (redirect)
                {
                    return Redirect(shortLink.LongURL);
                }
                else
                {
                    return Ok(shortUrl);
                }
            }

            return NotFound();
        }

        // POST: api/ShortLink
        [HttpPost]
        public IActionResult PostShortLink([FromBody] ShortURLRequestModel model)
        {
            if (ModelState.IsValid)
            {
                ShortURLResponseModel result = _shortUrlService.SaveItemToDataStore(model);
                if (result != null)
                    return Ok(result);
            }

            return BadRequest(ModelState.Values);
        }
    }
}
