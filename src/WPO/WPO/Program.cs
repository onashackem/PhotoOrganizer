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
            var members = (Members.All | Members.Verejne | Members.FB).GetFlags().ToList();
            foreach (var member in members)
            {
                var allImages = Source.Collectons.SelectMany(c => c.GetImageFiles(member)).ToList();
                if (allImages.Count == 0)
                {
                    continue;
                }

                var memberFolderPath = Path.Combine(folder, member.ToString());
                var memberFolderInfo = new DirectoryInfo(memberFolderPath);

                if (memberFolderInfo.Exists)
                {
                    memberFolderInfo.Delete(recursive: true);
                }
                memberFolderInfo.Create();

                foreach (var imageInfo in allImages)
                {
                    if (imageInfo.Exists)
                    {
                        imageInfo.CopyTo(Path.Combine(memberFolderPath, imageInfo.Name));
                    }
                    else 
                    {
                        Console.WriteLine("File " + imageInfo.FullName + " doesn't exist.");
                    }                    
                }
            }

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    public static class Extensions
    {
        public static IEnumerable<TFlagEnum> GetFlags<TFlagEnum>(this TFlagEnum flags)
           where TFlagEnum : struct
        {
            var enumType = typeof(TFlagEnum);
            if (!enumType.IsFlagsEnum())
            {
                throw new InvalidOperationException(typeof(TFlagEnum).GetType().Name + " is not a flag enum.");
            }

            return enumType.GetValues<TFlagEnum>().Where(f => ((int)(object)flags & (int)(object)f) > 0).ToList();
        }

        public static bool IsFlagsEnum(this Type type)
        {
            return type.IsEnum && type.CustomAttributes.Any(a => a.AttributeType == typeof(FlagsAttribute));
        }

        public static IEnumerable<TEnum> GetValues<TEnum>(this Type enumType)
        {
            return enumType.GetValues().OfType<TEnum>().ToList();
        }

        public static IEnumerable<object> GetValues(this Type enumType)
        {
            var values = Enum.GetValues(enumType).OfType<object>();
            if (enumType.IsFlagsEnum())
            {
                // http://stackoverflow.com/a/600306
                values = values.Where(value =>
                {
                    var v = (int)value;
                    return (v != 0) && ((v & (v - 1)) == 0);
                });
            }
            return values.ToList();
        }
    }
}
