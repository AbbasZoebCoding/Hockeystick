using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HockeystickWebAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace HockeystickWebAPI.Controllers
{
    [EnableCors("Policy1")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        // GET api/image
        [HttpGet("api/image")]
        public ActionResult<string> Get()
        {
            return "This is the API Server for the Hockeystick applicaiton. Welcome!";
        }

        // POST api/image
        [Route("api/image/convert")]
        [HttpPost]
        public IActionResult POST([FromForm] ImageDTO body)
        {
            byte[] convertedImage = null;
            string type = "image/";

            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    body.File.CopyToAsync(memoryStream);
                    using (var img = Image.FromStream(memoryStream))
                    {
                        System.Drawing.Imaging.ImageFormat format;

                        switch (body.FileType)
                        {
                            case "GIF":
                                format = System.Drawing.Imaging.ImageFormat.Gif;
                                type = type + "gif";
                                break;
                            case "BMP":
                                format = System.Drawing.Imaging.ImageFormat.Bmp;
                                type = type + "x-ms-bmp";
                                break;
                            case "PNG":
                                format = System.Drawing.Imaging.ImageFormat.Png;
                                type = type + "png";
                                break;
                            case "JPG":
                                format = System.Drawing.Imaging.ImageFormat.Jpeg;
                                type = type + "jpeg";
                                break;
                            default:
                                format = System.Drawing.Imaging.ImageFormat.Jpeg;
                                type = type + "jpeg";
                                break;
                        }
                        img.Save(memoryStream, format);

                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, format);

                        convertedImage = ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return File(convertedImage, type);
        }
    }
}
