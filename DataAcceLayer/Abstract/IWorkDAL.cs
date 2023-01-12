using Entitylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.Abstract
{
    public interface IWorkDAL:IGenericDAL<Work>
    {
        List<Work> GetListWithCategory();
        List<Work> GetListWithCategoryStatus();
    }
}
