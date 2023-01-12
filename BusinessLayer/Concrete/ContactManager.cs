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
    public class ContactManager : IContactService
    {
        IContactDAL _ContactDAL;
        public ContactManager(IContactDAL contactDAL)
        {
            _ContactDAL = contactDAL;
        }

        public void ContactAdd(Contact contact)
        {
            _ContactDAL.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _ContactDAL.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _ContactDAL.Update(contact);
        }

        public Contact GetByID(int id)
        {
           return(_ContactDAL.GetByID(id));
        }

        public List<Contact> GetList()
        {
            return(_ContactDAL.GetlistAll());
        }
    }
}
