using Microsoft.AspNetCore.Http;

namespace PortfolioApp.Business.Utils
{
    public interface IPictureFile
    {
        void AddFile(IFormFile picture, out string image);

        void DeleteFile(string picture);
    }
}
