using ZooProject.Models;

namespace ZooProject.Data;

public interface IAnimalRepository
{
    void Add(Animal animal);
    void Delete(int id);
    List<Animal> GetAllAnimals();
    Animal? GetAnimalById(int id);



}
