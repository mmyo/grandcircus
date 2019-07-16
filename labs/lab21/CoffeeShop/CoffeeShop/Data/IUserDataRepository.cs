using CoffeeShop.Models;

namespace CoffeeShop.Data
{
    public interface IUserDataRepository
    {
        void Add(UserModel user);
        UserModel Get(int id);
        void Save(int id, UserModel user);
    }
}