using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeopleAndCommunitiesWEB.Controllers
{
    public class PersonController : ApiController
    {
        //WEB интерфейс взаимодействия различных сайтов со стороними приложениями.
        //API Application Programming Interface
        //API интерфейс взаимодействия между программами
        //REST Representational state transfer
        //При помощи http реквестов соединять разные части программы
        //Recieves HTTP requests from Clients and does whatever request needs
        //Get(Считывает) Post(Новая запись) Put(Апдейт) Delete
        //при помощи url rest api понимает с чем работать
        //как формат данных использует xml или json
        public IEnumerable<Person> Get()
        {
            using (Garden_ComEntities GcomEntities = new Garden_ComEntities())
            {
                return GcomEntities.People.ToList();
            }
        }

        public Person Get(int id)
        {
            using (Garden_ComEntities GcomEntities = new Garden_ComEntities())
            {
                return GcomEntities.People.FirstOrDefault( c => c.id == id);
            }
        }
    }
}
