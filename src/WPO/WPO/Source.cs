using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPO
{
    public class Source
    {
        public static readonly Dictionary<Members, PhotoCollection[]> Configuration =
            new Dictionary<Members, PhotoCollection[]>
            {
                { 
                    Members.All,
                    new[]
                    {
                        new PhotoCollection("", "")
                    }
                },
            };
    }
}
