using PizzaHut.Models.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models.MockRepositories
{
    public class MockUserRepository : IUserRepository
    {

        List<User> users;

        public MockUserRepository()
        {
            users = new List<User>()
            {
                new User{ID=1, Name="Anatoly",Email="comradeDyatlov@chernobyl.sssr", Address="Chernobyl",City="Pripyat",Phone = "070360498"},
                new User{ID=2, Name="Akimov",Email="comradeAkimov@chernobyl.sssr", Address="Chernobyl",City="Pripyat",Phone = "072435238"},
                new User{ID=3, Name="Scherbina",Email="comradeScherbia@redArmy.sssr", Address="Cremlj/12",City="Moscow",Phone = "075414570"},
            };
        }
        public User Add(User user)
        {
            int nextId = users.Max(p => p.ID) + 1;
            user.ID = nextId;
            users.Add(user);
            return user;
        }

        public User Delete(int id)
        {
            User user = users.FirstOrDefault(p => p.ID == id);
            users.Remove(user);
            return user;
        }

        public User Get(int id)
        {
            User user = users.FirstOrDefault(p => p.ID == id);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
           return users;
        }

        public User Update(User userChanges)
        {
            User user = users.FirstOrDefault(p => p.ID == userChanges.ID);
            if (user!= null)
            {
                user.Name = userChanges.Name;
                user.Email = userChanges.Email;
                user.Address = userChanges.Address;
                user.City = userChanges.City;
                user.Phone = userChanges.Phone;
            }
            return user;
        }
    }
}
