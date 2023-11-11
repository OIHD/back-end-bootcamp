using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject.Models;

public class Sitters : EntityBase<int>
{
    public string SitterName { get; set; }
}
