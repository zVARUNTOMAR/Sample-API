using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Sample_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Video> getVideoInfo()
        {
             IEnumerable<Video> video = new List<Video>()
            {
                new Video() {
                    Id = 100,
                    VideoUrl = "https://player.vimeo.com/video/736034733",
                    Title = "Awesome Birthday"
                    ,IsRequired = true,
                },
                 new Video() {
                    Id = 200,
                    VideoUrl = "https://player.vimeo.com/video/736035090"
                    ,Title = "Halloween Fun",
                    IsRequired = false,
                 },
                  new Video() {
                    Id = 300,
                    VideoUrl = "https://player.vimeo.com/video/735711099"
                    ,Title = "Christmas Fun",
                    IsRequired= true
                  },
            };

            return video;
        }
    }
}
