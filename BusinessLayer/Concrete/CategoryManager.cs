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
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _CategoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _CategoryDAL = categoryDAL;
        }

        public void CategoryAdd(Category category)
        {
            _CategoryDAL.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _CategoryDAL.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _CategoryDAL.Update(category);
        }

        public Category GetByID(int id)
        {
            return _CategoryDAL.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _CategoryDAL.GetlistAll();
        }
        public List<Category> GetListWithStatus()
        {
            return _CategoryDAL.GetListWithStatus();
        }
    }
}
