using Entitylayer;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnnouncementService
    {
        void AnnouncementAdd(Announcement announcement);
        void AnnouncementDelete(Announcement announcement);
        void AnnouncementUpdate(Announcement announcement);
        List<Announcement> GetList();
    
        Announcement GetByID(int id);
        List<Announcement> GetListWithStatus();
    }
}
