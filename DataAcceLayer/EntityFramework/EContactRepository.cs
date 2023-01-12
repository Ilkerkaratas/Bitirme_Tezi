using DataAcceLayer.Abstract;
using DataAcceLayer.Repositories;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.EntityFramework
{
    public class EContactRepository: GenericRepository<Contact>, IContactDAL
    {
    }
}
