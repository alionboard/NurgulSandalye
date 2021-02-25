using NurgulSandalye.DataAccess.Abstract;
using NurgulSandalye.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurgulSandalye.DataAccess.Concrete.EfCore
{
    public class CategoryRepository :EfCoreGenericRepository<Category,NurgulSandalyeContext>,ICategoryRepository
    {
    }
}
