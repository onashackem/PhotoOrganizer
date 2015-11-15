using System;

namespace WPO
{
    [Flags]
    public enum Members
    {
        MichalAMaja = 1 << 0,
        Klarka = 1 << 1,
        Babicky = 1 << 2,
        Flechtnerovi = 1 << 3,
        Rumburk = 1 << 4,
        Dvorakovi = 1 << 5,
        Buresovi = 1 << 6,
        PavlaARobert = 1 << 7,
        Druzicky = 1 << 8,
        Mews = 1 << 9,
        Stefkovi = 1 << 10,
        Ondrous = 1 << 11,
        Matty = 1 << 12,
        Kropackovi = 1 << 13,
        LuckaK = 1 << 14,
        Krizovi = 1 << 15,
        GymCk = 1 << 16,
        Anicka = 1 << 17,
        Kebrlovi = 1 << 18,
        MisaL = 1 << 19,
        Lena = 1 << 20,
        Martinove = 1 << 22,
        Krumlovaci = 1 << 21,
        JanaF = 1 << 22,
        Charlie = 1 << 23,

        Verejne = 1 << 30,
        KTisku = 1 << 31,
        My = 1 << 32,

        HermankovoKridlo = Klarka | Kropackovi | Krizovi,
        VeseleKridlo = Dvorakovi | Rumburk,
        GymplAll = JanaF | GymCk,
        MewsAll = Mews | Charlie,
        All = MichalAMaja | Klarka | Flechtnerovi | Rumburk | Dvorakovi | Buresovi | PavlaARobert | Druzicky | Mews | Martinove | My |
            Ondrous | Matty | Kropackovi | LuckaK | Krizovi | GymCk | Anicka | Kebrlovi | MisaL | Lena | Krumlovaci | Stefkovi | JanaF | Charlie
    }
}
