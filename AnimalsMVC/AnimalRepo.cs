using AnimalsMVC.Models;
using Dapper;
using System.Data;

namespace AnimalsMVC
{
    public class AnimalRepo : IAnimalRepo
    {
        private readonly IDbConnection _connection;

        public AnimalRepo(IDbConnection connection)
        {
            _connection = connection;
        }


        public IEnumerable<Animal> GetAllAnimals()
        {
            return _connection.Query<Animal>("SELECT * FROM animal_info;");
        }
    }
}
