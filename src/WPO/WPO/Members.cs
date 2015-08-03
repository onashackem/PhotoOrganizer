using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPO
{
    [Flags]
    public enum Members
    {
        MichalAMaja = 1 << 0,
        Nasi = 1 << 1,
        Hanka = 1 << 2,
        Flechtnerovi = 1 << 3,
        Rumburk = 1 << 4,
        Dvorakovi = 1 << 5,
        Buresovi = 1 << 6,
        PavlaARobert = 1 << 7,
        Svedkyne = 1 << 8,
        Mews = 1 << 9,
        Troupovi = 1 << 10,        
        Ondrous = 1 << 11,
        Matty = 1 << 12,
        Kropackovi = 1 << 13,
        Lucka = 1 << 14,
        Krizovi = 1 << 15,
        GymCk = 1 << 16,
        Anicka = 1 << 17,
        Kebrlovi = 1 << 18,
        MisaL = 1 << 19,
        Lena = 1 << 20,
        Zuzca = 1 << 21,
        Simca = 1 << 22, 
        Martinove = 1 << 23,        

        All = 1 << 30
    }
}
