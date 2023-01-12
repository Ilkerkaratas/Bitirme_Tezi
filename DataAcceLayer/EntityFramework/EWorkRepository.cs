using DataAcceLayer.Abstract;
using DataAcceLayer.Concrete;
using DataAcceLayer.Repositories;
using Entitylayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.EntityFramework
{
    public class EWorkRepository : GenericRepository<Work>, IWorkDAL
    {
        public List<Work> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Works.Include(x => x.category).ToList();
            }

        }
        public List<Work> GetListWithCategoryStatus()
        {
            using (var c = new Context())
            {
                return c.Works.Include(x => x.category).Where(x => x.WorkStatus==true).ToList();
            }

        }
    }
}
