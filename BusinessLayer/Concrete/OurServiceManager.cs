using BusinessLayer.Abstract;
using DataAcceLayer.Abstract;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OurServiceManager : IOurServiceService
    {

        IOurServiceDAL _OurServiceDAL;
        public OurServiceManager(IOurServiceDAL  ourServiceDAL)
        {
            _OurServiceDAL = ourServiceDAL;
        }

        public OurService GetById(int id)
        {
            return _OurServiceDAL.GetByID(id);
        }

        public List<OurService> GetList()
        {
            return _OurServiceDAL.GetlistAll();
        }

        public void OurServiceAdd(OurService ourService)
        {
            _OurServiceDAL.Insert(ourService);
        }

        public void OurServiceDelete(OurService ourService)
        {
            _OurServiceDAL.Delete(ourService);
        }

        public void OurServiceUpdate(OurService ourService)
        {
            _OurServiceDAL.Update(ourService);
        }
        public List<OurService> GetListWithStatus()
        {
            return _OurServiceDAL.GetListWithStatus();
        }
    }
}
