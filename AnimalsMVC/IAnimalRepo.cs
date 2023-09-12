using AnimalsMVC.Models;

namespace AnimalsMVC
{
    public interface IAnimalRepo
    {
        public IEnumerable<Animal> GetAllAnimals();
    }
}
