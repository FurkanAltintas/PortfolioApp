using PortfolioApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.DataAccess.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    { 
        // ilgili metot imzaları IUserRepository için de var
        /// <summary>
        /// Eğer user var ise true döner, yok ise false döner.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);

        User GetUser();



        /// <summary>
        /// Atılan parametredeki değere göre tabloda o name değerine ait kullanıcı var mı ? var ise getir
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        User FindByName(string userName);
    }
}
