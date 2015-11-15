﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPO
{
    public class Source
    {
        public static readonly IEnumerable<PhotoCollection> Collectons = new[]
        {
            new PhotoCollection("Final\\MiraB", "DSC_", "JPG", 
                new Image("8829", Members.HermanciSr | Members.Krizovi),
                new Image("8830", Members.FB),
                new Image("8832", Members.FB),
                new Image("8836", Members.Svedkyne),
                new Image("8837", Members.Svedkyne),
                new Image("8842", Members.Verejne),
                new Image("8850", Members.FB),
                new Image("8853", Members.FB),
                new Image("8854", Members.Svedkyne),
                new Image("8856", Members.GymCk | Members.Stefkovi),
                new Image("8857", Members.HermanciSr | Members.GymCk),
                new Image("8858", Members.Zuzca | Members.Simca | Members.Troupovi),
                new Image("8860", Members.Hanka),
                new Image("8861", Members.Dvorakovi | Members.Hanka | Members.Ondrous | Members.FB),
                new Image("8862", Members.Dvorakovi | Members.Hanka),
                new Image("8864", Members.FB),
                new Image("8866", Members.Hanka),
                new Image("8868", Members.Troupovi),
                new Image("8872", Members.Troupovi),
                new Image("8873", Members.Flechtnerovi),
                new Image("8874", Members.Flechtnerovi | Members.Ondrous),
                new Image("8876", Members.FB),
                new Image("8877", Members.FB),
                new Image("8878", Members.FB),
                new Image("8880", Members.FB),
                new Image("8881", Members.FB),
                new Image("8882", Members.Troupovi),
                new Image("8883", Members.GymCk | Members.Simca),
                new Image("8885", Members.GymCk),
                new Image("8886", Members.FB),
                new Image("8888", Members.FB),
                new Image("8889", Members.FB),
                new Image("8893", Members.Troupovi | Members.MichalAMaja),
                new Image("8894", Members.Troupovi | Members.MichalAMaja),
                new Image("8908", Members.VeseleKridlo | Members.Ondrous),
                new Image("8909", Members.HermanciSr | Members.Kropackovi | Members.Lucka | Members.Matty),
                new Image("8919", Members.HermanciSr),
                new Image("8919", Members.HermanciSr),
                new Image("8926", Members.Flechtnerovi),
                new Image("8927", Members.Flechtnerovi | Members.Svedkyne),
                new Image("8930", Members.Flechtnerovi | Members.Svedkyne),
                new Image("8931", Members.Flechtnerovi | Members.Svedkyne | Members.Mews),
                new Image("8932", Members.FB | Members.Anicka),
                new Image("8934", Members.FB | Members.Mews),
                new Image("8935", Members.Svedkyne),
                new Image("8936", Members.Flechtnerovi | Members.HermanciSr),
                new Image("8939", Members.Flechtnerovi | Members.HermanciSr),
                new Image("8940", Members.Flechtnerovi | Members.HermanciSr | Members.Hanka),
                new Image("8941", Members.MichalAMaja),
                new Image("8943", Members.Hanka | Members.Ondrous),
                new Image("8949", Members.MichalAMaja | Members.Troupovi | Members.Martinove),
                new Image("8959", Members.HermanciSr),
                new Image("8966", Members.FB),
                new Image("8969", Members.FB),
                new Image("8975", Members.FB | Members.MichalAMaja),
                new Image("8979", Members.FB),
                new Image("8988", Members.HermanciSr | Members.Matty),
                new Image("8989", Members.HermanciSr),
                new Image("8990", Members.HermanciSr),
                new Image("8991", Members.FB),
                new Image("8993", Members.HermanciSr),
                new Image("8994", Members.HermanciSr | Members.Flechtnerovi),
                new Image("8996", Members.Zuzca | Members.Troupovi),
                new Image("9000", Members.Anicka),
                new Image("9003", Members.Flechtnerovi),
                new Image("9005", Members.Flechtnerovi),
                new Image("9009", Members.HermanciSr),
                new Image("9011", Members.Kropackovi | Members.Rumburk),
                new Image("9015", Members.Rumburk),
                new Image("9017", Members.Anicka | Members.Svedkyne | Members.Buresovi),
                new Image("9019", Members.Svedkyne | Members.Troupovi),
                new Image("9020", Members.Svedkyne | Members.Ondrous),
                new Image("9021", Members.MichalAMaja),
                new Image("9022", Members.Buresovi | Members.MichalAMaja),
                new Image("9023", Members.MichalAMaja | Members.Buresovi | Members.Svedkyne),
                new Image("9024", Members.Buresovi | Members.Svedkyne | Members.Ondrous),
                new Image("9025", Members.Svedkyne),
                new Image("9026", Members.Hanka | Members.Ondrous | Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
                new Image("9000", Members.Anicka),
            ),
            new PhotoCollection("Photos\\RBK", "IMG_", "JPG",
                new Image("1779", Members.Buresovi | Members.Svedkyne),
                new Image("1780", Members.Verejne),
                new Image("1781", Members.Rumburk) 
            )
        };
    }
}
