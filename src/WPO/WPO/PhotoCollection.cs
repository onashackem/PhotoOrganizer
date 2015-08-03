using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPO
{
    public class PhotoCollection
    {
        public PhotoCollection(string folderName, string extension, params string[] images)
        {
            ImageFiles = images.Select(i => new FileInfo(Path.Combine(folderName, i + "." + extension))).ToList();
        }

        public List<FileInfo> ImageFiles { get; private set; }
    }
}
