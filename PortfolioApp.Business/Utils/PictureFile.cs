using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace PortfolioApp.Business.Utils
{
    public class PictureFile : IPictureFile
    {
        public void AddFile(IFormFile picture, out string image)
        {
            try
            {
                var imageName = Guid.NewGuid() + Path.GetExtension(picture.FileName); // Benzersiz bir isim aldık
                var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imageName;
                var stream = new FileStream(path, FileMode.Create);
                picture.CopyTo(stream);
                image = imageName;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteFile(string picture)
        {
            var fullPath = "~/img/" + picture;

            try
            {
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
