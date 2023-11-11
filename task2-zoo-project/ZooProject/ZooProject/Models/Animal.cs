namespace ZooProject.Models;

public class Animal :EntityBase<int>
{
    public string Name { get; set; } // Hayvan adi veya fotosu
    public string AnimalType { get; set; } // Ornek kedi , birden cok kedi olabilir
    public string AnimalFamily { get; set; } // Ornek vahsi doga taglama olcak
    public string PetSitterId { get; set; } // Hayvanin bakicisinin idsi

    public override string ToString()
    {
        return $"Id: {Id} , Name: {Name} , Animal Type: {AnimalType} , Animal Family: {AnimalFamily} , Pet Sitters Id: {PetSitterId}";
    }



}
