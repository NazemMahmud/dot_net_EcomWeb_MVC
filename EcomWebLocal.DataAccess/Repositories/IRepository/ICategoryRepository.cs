using EcomWebLocal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomWebLocal.DataAccess.Repositories.IRepository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        void Save();
        void Update(Category obj);
    }
}
