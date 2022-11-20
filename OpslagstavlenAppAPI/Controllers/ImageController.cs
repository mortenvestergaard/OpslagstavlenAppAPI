using Microsoft.AspNetCore.Mvc;
using System.IO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpslagstavlenAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        // GET: api/<ImageController>
        [HttpGet]
        [Route("GetImages")]
        public IEnumerable<string> Get()
        {
            string imagePath = @"C:\Users\mort286f\Pictures\OpslagstavleImages";
            List<string> images = Directory.GetFiles(imagePath, "*.*", SearchOption.TopDirectoryOnly).ToList();
            List<string> resultImages = new List<string>();

            foreach (string image in images)
            {
                resultImages.Add(Convert.ToBase64String(System.IO.File.ReadAllBytes(image)));
            }
            return resultImages;
        }

        //[HttpPost]
        //[Route("PostImage")]
        //public IEnumerable<string> Post()
        //{

        //}
    }
}
