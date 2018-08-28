using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLStorage
{
    public interface IStorageItem
    {
        /// <summary>
        /// The name of the file or folder
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The "full path" of the file or folder, which should uniquely identify it within a given <see cref="IFileSystem"/>
        /// </summary>
        string Path { get; }
    }
}
