using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooProject.consts;

public class Messages
{
    public static string BookNameExceptionMessage(string title)
    {
        return $"{title}, en az 3 karakter olmalidir";
    }
}
