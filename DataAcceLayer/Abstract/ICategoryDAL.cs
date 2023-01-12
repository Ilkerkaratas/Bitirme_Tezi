using Entitylayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.Abstract
{
    public interface ICategoryDAL:IGenericDAL<Category>
    {
        List<Category> GetListWithStatus();
    }
}
