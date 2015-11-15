using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace WPO
{
    public class PhotoCollection
    {
        public PhotoCollection(string folderName, string prefix, string extension, params Image[] images)
        {
            Images = images.ToList();
            FolderName = folderName;
            Prefix = prefix ?? "";
            Extension = extension;
        }

        private List<Image> Images { get; set; }
        private string FolderName { get; set; }
        private string Prefix { get; set; }
        private string Extension { get; set; }

        public List<FileInfo> GetImageFiles(Members member)
        {
            return Images.Where(i => i.Members.HasFlag(member)).Select(ImageFileInfo).ToList();
        }

        private FileInfo ImageFileInfo(Image image)
        {
            return new FileInfo(Path.Combine(FolderName, Prefix + image.Number + "." + Extension));
        }
    }

    public class Image
    {
        public Image(string number, Members members)
        {
            Number = number;
            Members = members;
        }

        public Image(string name, string extension, Members members)
        { 

}

        public string Number { get; private set; }
        public Members Members { get; private set; }
    }
}
