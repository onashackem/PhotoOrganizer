using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var folder = "Generated";
            var allCategory = Source.Configuration[Members.All];
            var allCategoryFiles = allCategory.SelectMany(v => v.ImageFiles).ToList();
            foreach (var kvp in Source.Configuration.Where(kvp => kvp.Key != Members.All))
            {
                var files = kvp.Value.SelectMany(v => v.ImageFiles).Concat(allCategoryFiles).ToList();
                var memberFolderPath = Path.Combine(folder, kvp.Key.ToString());
                var memberFolderInfo = new DirectoryInfo(memberFolderPath);

                memberFolderInfo.Create();
                foreach (var fileInfo in files)
                {
                    if (fileInfo.Exists)
                    {
                        fileInfo.CopyTo(Path.Combine(memberFolderPath, fileInfo.Name));
                    }
                    else 
                    {
                        Console.WriteLine("File " + fileInfo.FullName + " doesn't exist.");
                    }                    
                }
            }
        }
    }
}
