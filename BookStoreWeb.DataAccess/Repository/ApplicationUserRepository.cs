using BookStoreWeb.DataAccess.Data;
using BookStoreWeb.DataAccess.Repository.IRepository;
using BookStoreWeb.Models;
using BookStoreWeb.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreWeb.DataAccess.Repository
{
    public class ApplicationUserRepository: Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext db):base(db)
        {
        }

    }
}
