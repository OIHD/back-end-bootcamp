using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Exceptions;
using ZooProject.Models;

namespace ZooProject.Data;

public class AnimalRepository : IAnimalRepository
{
    private readonly List<Animal> _animalData;

    public AnimalRepository()
    {
        _animalData = new List<Animal>()
        {
            new Animal{Id=1,Name="Boss RIFKI",AnimalFamily=1,AnimalType=1,PetSitterId=1},
            new Animal{Id=2,Name="Serafettin",AnimalFamily=1,AnimalType=2,PetSitterId=2},
            new Animal{Id=3,Name="Pamuk",AnimalFamily=1,AnimalType=2,PetSitterId=2}

        };
    }

    public void Add(Animal animal)
    {
        _animalData.Add(animal);
    }

    public void Delete(int id)
    {
        Animal? animal = _animalData.Where(x=>x.Id == id).SingleOrDefault();
        if (animal is null)
        {
            throw new AnimalNotFoundException(id);
        }
        _animalData.Remove(animal);

    }

    public List<Animal> GetAllAnimals()
    {
        return _animalData;
    }

    public Animal? GetAnimalById(int id)
    {
        Animal? animal = _animalData.SingleOrDefault(x => x.Id == id);
        if (animal==null)
        {
            throw new AnimalNotFoundException(id);
        }
        return animal;
    }
}
