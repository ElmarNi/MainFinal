using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Extensions
{
    public static class IFormFileEx
    {
        public async static Task<string> SavePhotoAsync(this IFormFile file, string root, string folder)
        {
            string path = Path.Combine(root, "img");
            string fileName = folder + "/" + Guid.NewGuid().ToString() + file.FileName;

            string resultPath = Path.Combine(path, fileName);

            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }
        public static bool RemovePhoto(string root, string filename)
        {
            string path = Path.Combine(root, "img", filename);
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            return false;
        }
    }
}
