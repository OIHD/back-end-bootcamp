using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Exceptions
{
    internal class AnimalNotFoundException : Exception
    {
        public AnimalNotFoundException(int id) : base($"Id {id} ye ait hayvan bulunamadi") 
        {
            
        }

    }
}
