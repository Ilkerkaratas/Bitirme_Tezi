using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcceLayer.Abstract;
using DataAcceLayer.Concrete;
using DataAcceLayer.Repositories;
using Entitylayer;
using Entitylayer.Concrete;

namespace DataAcceLayer.EntityFramework
{
    public class EOurTeamRepository:GenericRepository<OurTeam>,IOurTeamDAL
    {
        public List<OurTeam> GetListWithStatus()
        {
            using (var c = new Context())
            {
                return c.ourTeams.Where(x => x.OurTeamStatus == true).ToList();
            }

        }
    }
}
