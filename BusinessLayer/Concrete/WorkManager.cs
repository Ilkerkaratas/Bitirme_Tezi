using BusinessLayer.Abstract;
using DataAcceLayer.Abstract;
using Entitylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WorkManager : IWorkService
    {
        IWorkDAL _workdal;
        public WorkManager(IWorkDAL workdal)
        {
            _workdal = workdal;
        }

        public Work GetByID(int id)
        {
            return _workdal.GetByID(id);
        }

        public List<Work> GetList()
        {
            return _workdal.GetlistAll();
        }

        public List<Work> GetListWithCategoryStatus()
        {
            return _workdal.GetListWithCategoryStatus();
        }

        public List<Work> GetWorkListWithCategory()
        {
            return _workdal.GetListWithCategory();
        }

        public void WorkAdd(Work work)
        {
            _workdal.Insert(work);
        }

        public void WorkDelete(Work work)
        {
            _workdal.Delete(work);
        }

        public void WorkUpdate(Work work)
        {
           _workdal.Update(work);
        }
    }
}

