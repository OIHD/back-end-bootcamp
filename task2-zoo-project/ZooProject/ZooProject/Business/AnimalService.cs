using ZooProject.Data;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Business;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public void Add(Animal animal)
    {
        AddRules(animal);
        _animalRepository.Add(animal);

        GetList();
    }

    public void Delete(int id)
    {
        try
        {
            _animalRepository.Delete(id);
            GetList();
        }
        catch (AnimalNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }


    }

    public void GetAnimalById(int id)
    {
        try
        {
            Animal? animal = _animalRepository.GetAnimalById(id);
            Console.WriteLine(animal);
        }
        catch (AnimalNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }


    }

    public void GetList()
    {
        List<Animal> animals = _animalRepository.GetAllAnimals();
        animals.ForEach(animal => Console.WriteLine(animal));
    }

    private void AddRules (Animal animal)
    {
        if (animal.Name.Length < 3)
        {
            throw new AnimalNameExceptions(animal.Name);
        }
    }

}
