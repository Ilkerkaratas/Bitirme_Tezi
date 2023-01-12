using Entitylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWorkService
    {
        void WorkAdd(Work work);
        void WorkDelete(Work work);
        void WorkUpdate(Work work);
        List<Work> GetList();
        Work GetByID(int id);
        List<Work> GetWorkListWithCategory();
        List<Work> GetListWithCategoryStatus();


    }
}
