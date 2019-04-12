using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeopleAndCommunitiesWEB.Controllers
{
    public class CommunityController : ApiController
    {
        public IEnumerable<Community> Get()
        {
            using (Garden_ComEntities GcomEntities = new Garden_ComEntities())
            {
                return GcomEntities.Communities.ToList();
            }
        }

        public Community Get(int id)
        {
            using (Garden_ComEntities GcomEntities = new Garden_ComEntities())
            {
                return GcomEntities.Communities.FirstOrDefault(c => c.id == id);
            }
        }
    }
}
