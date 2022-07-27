using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_app.Models
{
    public interface IPeopleService
    {
        public IList<Person> People { get; }

    }
    public class PeopleService : IPeopleService
    {
        private List<Person> _people=null;
        public PeopleService()
        {
            _people = new List<Person>();
            _people.Add(new Person { Name = "Mario", Surname="Rossi"});
            _people.Add(new Person { Name = "Mario2", Surname = "Rossi2" });
            _people.Add(new Person { Name = "Mario3", Surname = "Rossi3" });
            _people.Add(new Person { Name = "Mario4", Surname = "Rossi4" });

        }
         public IList<Person> People => _people;
    }
}
