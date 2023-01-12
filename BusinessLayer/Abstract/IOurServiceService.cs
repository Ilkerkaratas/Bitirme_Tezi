using Entitylayer;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOurServiceService
    {
        void OurServiceAdd(OurService ourService);
        void OurServiceDelete(OurService ourService);
        void OurServiceUpdate(OurService ourService);
        List<OurService> GetList();
        List<OurService> GetListWithStatus();
        OurService GetById(int id);
    }
}
