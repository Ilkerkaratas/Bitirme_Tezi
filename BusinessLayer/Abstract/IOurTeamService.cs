using Entitylayer;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOurTeamService
    {
        void OurTeamAdd(OurTeam ourTeam);
        void OurTeamDelete(OurTeam ourTeam);
        void OurTeamUpdate(OurTeam ourTeam);
        List<OurTeam> GetList();
        OurTeam GetByID(int id);
        List<OurTeam> GetListWithStatus();
    }
}
