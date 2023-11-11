using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooProject.consts;

namespace ZooProject.Exceptions;

    public class AnimalNameExceptions : Exception
    {   
    public AnimalNameExceptions(string Name):base(Messages.BookNameExceptionMessage(Name)) 
    { }

    }
