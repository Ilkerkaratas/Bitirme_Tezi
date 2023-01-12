using BusinessLayer.Abstract;
using DataAcceLayer.Abstract;
using Entitylayer;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDAL _AnnouncementDAL;
        public AnnouncementManager(IAnnouncementDAL announcementDAL)
        {
            _AnnouncementDAL = announcementDAL;
        }

        public void AnnouncementAdd(Announcement announcement)
        {
            _AnnouncementDAL.Insert(announcement);
        }

        public void AnnouncementDelete(Announcement announcement)
        {
            _AnnouncementDAL.Delete(announcement);
        }

        public void AnnouncementUpdate(Announcement announcement)
        {
            _AnnouncementDAL.Update(announcement);
        }

        public Announcement GetByID(int id)
        {
            return _AnnouncementDAL.GetByID(id);
        }

        public List<Announcement> GetList()
        {
            return _AnnouncementDAL.GetlistAll();
        }

      
        public List<Announcement> GetListWithStatus()
        {
            return _AnnouncementDAL.GetListWithStatus();
        }
    }
}
