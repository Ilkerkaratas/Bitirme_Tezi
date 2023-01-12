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
    public class EAnnouncementRepository: GenericRepository<Announcement>, IAnnouncementDAL
    {
        public List<Announcement> GetListWithStatus()
        {
            using (var c = new Context())
            {
                return c.announcements.Where(x => x.AnnouncementStatus == true).ToList();
            }

        }
    }
}
