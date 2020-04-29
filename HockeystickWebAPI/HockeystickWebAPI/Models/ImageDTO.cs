using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeystickWebAPI.Models
{
    public class ImageDTO
    {
        public string FileType { get; set; }
        public IFormFile File { get; set; } 

    }
}
