using Microsoft.AspNetCore.Http;

namespace NikNokAPI.Models.File
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
