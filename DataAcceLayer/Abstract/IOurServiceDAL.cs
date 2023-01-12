using Entitylayer;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.Abstract
{
    public interface IOurServiceDAL:IGenericDAL<OurService>
    {

        List<OurService> GetListWithStatus();
    }
}
