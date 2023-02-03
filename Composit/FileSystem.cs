using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    internal abstract class FileSystem
    {
        public abstract int GetSize();
    }

    internal class Directory : FileSystem
    {
        private List<FileSystem> _fileSystem;

        public override int GetSize()
        {
            var sum = 0;
            foreach (var item in _fileSystem)
            {
                sum += item.GetSize();
            }
            return sum;
        }
    }
    internal class File : FileSystem
    {
        public override int GetSize()
        {
            return 0;
        }
    }
}
