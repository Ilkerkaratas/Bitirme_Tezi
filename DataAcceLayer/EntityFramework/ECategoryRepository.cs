using DataAcceLayer.Abstract;
using DataAcceLayer.Concrete;
using DataAcceLayer.Repositories;
using Entitylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.EntityFramework
{
    public class ECategoryRepository : GenericRepository<Category>,ICategoryDAL
    {
        public List<Category> GetListWithStatus()
        {
            using (var c = new Context())
            {
                return c.Categories.Where(x => x.CategoryStatus == true).ToList();
            }

        }
    }
}
