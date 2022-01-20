using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        // ilgili metot imzaları IUserRepository için de var
        /// <summary>
        /// Eğer user var ise true döner, yok ise false döner.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);

        User FindByName(string userName);

        User GetUser();
    }
}
