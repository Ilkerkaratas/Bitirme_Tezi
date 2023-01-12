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
    public class OurTeamManager : IOurTeamService
    {
        IOurTeamDAL _OurTeamDAL;
        public OurTeamManager(IOurTeamDAL ourteamDAL)
        {
            _OurTeamDAL = ourteamDAL;
        }
        public OurTeam GetByID(int id)
        {
            return _OurTeamDAL.GetByID(id);
        }

        public List<OurTeam> GetList()
        {
            return _OurTeamDAL.GetlistAll();
        }

        public void OurTeamAdd(OurTeam ourTeam)
        {
            _OurTeamDAL.Insert(ourTeam);
        }

        public void OurTeamDelete(OurTeam ourTeam)
        {
            _OurTeamDAL.Delete(ourTeam);
        }

        public void OurTeamUpdate(OurTeam ourTeam)
        {
            _OurTeamDAL.Update(ourTeam);
        }
        public List<OurTeam> GetListWithStatus()
        {
            return _OurTeamDAL.GetListWithStatus();
        }
    }
}
