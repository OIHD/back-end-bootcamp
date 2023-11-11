using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.Models;

namespace ZooProject.Business;

internal interface IAnimalService
{
    void GetList();
    void Add(Animal animal);
    void Delete(int id);
    void GetAnimalById(int id);

}
