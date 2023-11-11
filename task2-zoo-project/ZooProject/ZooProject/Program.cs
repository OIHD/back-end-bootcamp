// Hayvanlar ve bakicilari ekleme listeleme ve silme
// gibi operasyonlari simule edecegiz

using ZooProject.Business;
using ZooProject.Data;
using ZooProject.Exceptions;
using ZooProject.Models;

IAnimalService animalService = new AnimalService(new AnimalRepository());
animalService.GetList();

Animal animal = new Animal()
{
    Id = 4,
    Name = "Na",
    AnimalFamily = 1,
    AnimalType = 1,
    PetSitterId = 1,
};

animalService.Add(animal);

animalService.Delete(3);