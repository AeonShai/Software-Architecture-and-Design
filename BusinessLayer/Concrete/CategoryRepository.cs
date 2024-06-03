using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntitiesLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class CategoryRepository:GenericRepository<Category>
    {
        DataContext db = new DataContext();


    }
}
