using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class Employee : IEntity
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime HireDate { get; set; }
        public string City { get; set; }

        List<Employee> employees = new List<Employee>()
            {
                new Employee{ID=1, FirstName="Valery",LastName = "Legasov", Title="Chef",City="Kiev",HireDate = new DateTime(1986,04,25)},
                new Employee{ID=2, FirstName="Vasily",LastName = "Ignatenko", Title="Driver",City="Pripyat",HireDate = new DateTime(1984,02,12)},
                new Employee{ID=3, FirstName="Olga",LastName = "Poroshenko", Title="Chef",City="Kiev",HireDate = new DateTime(1986,11,05)},
            };


        public Employee Get(int id)
        {
            Employee employee = employees.FirstOrDefault(p => p.ID == id);
            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }




    }
}
