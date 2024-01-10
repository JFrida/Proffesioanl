using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IFileWriter
    {
        void WriteInFile(float amount);
        void ReadFromFile();
    }
}
