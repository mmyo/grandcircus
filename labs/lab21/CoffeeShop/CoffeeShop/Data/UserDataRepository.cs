using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Data
{
    public class UserDataRepository
    {
        private readonly Dictionary<int, UserModel> _data =
            new Dictionary<int, UserModel>
            {
                { 1, new UserModel
                    {
                        UserName = "matthewyo",
                        FirstName = "Matt",
                        LastName = "Yo",
                        Email = "matt@grandcircus.co",
                        Password = "password"
                    }}
            };

        public UserModel Get(int id)
        {
            if (_data.TryGetValue(id, out var employee))
            {
                return employee;
            }

            return null;
        }

        public void Add(UserModel user)
        {
            var id = _data.Keys.Max() + 1;
            _data[id] = user;
        }

        public void Save(int id, UserModel user)
        {
            _data[id] = user;
        }
    }
}
