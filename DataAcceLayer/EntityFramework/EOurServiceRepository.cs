using DataAcceLayer.Abstract;
using DataAcceLayer.Concrete;
using DataAcceLayer.Repositories;
using Entitylayer;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.EntityFramework
{
    public class EOurServiceRepository : GenericRepository<OurService>, IOurServiceDAL
    {
        public List<OurService> GetListWithStatus()
        {
            using (var c = new Context())
            {
                return c.ourServices.Where(x => x.OurServiceStatus == true).ToList();
            }

        }
    }
}
