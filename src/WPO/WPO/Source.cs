﻿using System.Collections.Generic;

namespace WPO
{
    public class Source
    {
        public static readonly IEnumerable<PhotoCollection> Collectons = new[]
        {
            new PhotoCollection("Final\\MiraB", "DSC_", "JPG",
                new Image("8830", Members.My),
                new Image("8832", Members.My),
                new Image("8832", Members.Matty | Members.Babicky | Members.Kropackovi),
                new Image("8836", Members.Druzicky),
                new Image("8837", Members.Druzicky | Members.MichalAMaja),
                new Image("8842", Members.Verejne),
                new Image("8849", Members.My),
                new Image("8850", Members.My),
                new Image("8854", Members.Druzicky),
                new Image("8856", Members.GymplAll | Members.Stefkovi | Members.MichalAMaja),
                new Image("8857", Members.Klarka | Members.JanaF),
                new Image("8858", Members.Krumlovaci),
                new Image("8859", Members.My),
                new Image("8860", Members.My),
                new Image("8861", Members.Dvorakovi | Members.My | Members.Ondrous | Members.Rumburk),
                new Image("8862", Members.Dvorakovi | Members.My),
                new Image("8866", Members.My),
                new Image("8869", Members.Ondrous | Members.Dvorakovi | Members.Rumburk),
                new Image("8872", Members.My),
                new Image("8873", Members.Flechtnerovi | Members.My),
                new Image("8874", Members.Flechtnerovi),
                new Image("8876", Members.My | Members.Rumburk | Members.Flechtnerovi | Members.Dvorakovi | Members.Babicky),
                new Image("8877", Members.My),
                new Image("8878", Members.My),
                new Image("8880", Members.All),
                new Image("8882", Members.My),
                new Image("8883", Members.GymplAll | Members.Krumlovaci),
                new Image("8885", Members.GymplAll),
                new Image("8886", Members.All),
                new Image("8889", Members.My),
                new Image("8893", Members.My | Members.MichalAMaja | Members.Druzicky),
                new Image("8894", Members.My | Members.MichalAMaja | Members.Druzicky),
                new Image("8899", Members.My),
                new Image("8908", Members.Rumburk | Members.Ondrous),
                new Image("8910", Members.Babicky | Members.Matty),
                new Image("8922", Members.Klarka | Members.My),
                new Image("8924", Members.Charlie | Members.Druzicky | Members.Flechtnerovi | Members.My),
                new Image("8926", Members.Flechtnerovi | Members.My | Members.Druzicky),
                new Image("8927", Members.Flechtnerovi | Members.Druzicky | Members.My),
                new Image("8930", Members.Flechtnerovi | Members.Druzicky | Members.My),
                new Image("8931", Members.Flechtnerovi | Members.Druzicky | Members.Charlie | Members.My),
                new Image("8932", Members.MewsAll | Members.Anicka | Members.Martinove | Members.GymplAll),
                new Image("8934", Members.Charlie | Members.My),
                new Image("8935", Members.Druzicky | Members.My | Members.Klarka | Members.Flechtnerovi),
                new Image("8936", Members.Flechtnerovi | Members.My | Members.Ondrous),
                new Image("8939", Members.Flechtnerovi | Members.My),
                new Image("8940", Members.Flechtnerovi | Members.My | Members.Rumburk),
                new Image("8942", Members.MichalAMaja | Members.My),
                new Image("8944", Members.Buresovi | Members.Ondrous | Members.My),
                new Image("8945", Members.My),
                new Image("8948", Members.MichalAMaja | Members.Druzicky | Members.Ondrous),
                new Image("8949", Members.MichalAMaja | Members.Martinove | Members.My),
                new Image("8950", Members.Kebrlovi | Members.Martinove | Members.MewsAll | Members.Klarka),
                new Image("8956", Members.MichalAMaja | Members.Buresovi | Members.My | Members.Rumburk),
                new Image("8957", Members.MichalAMaja),
                new Image("8958", Members.My),
                new Image("8959", Members.Klarka | Members.My | Members.MichalAMaja),
                new Image("8964", Members.All),
                new Image("8966", Members.All),
                new Image("8969", Members.My | Members.KTisku),
                new Image("8974", Members.My),
                new Image("8975", Members.MisaL | Members.MichalAMaja | Members.My),
                new Image("8977", Members.My),
                new Image("8981", Members.My),
                new Image("8981", Members.JanaF),
                new Image("8987", Members.LuckaK | Members.Matty | Members.Klarka | Members.My),
                new Image("8988", Members.LuckaK | Members.Matty | Members.Klarka | Members.My),
                new Image("8989", Members.LuckaK | Members.Matty | Members.Klarka | Members.My),
                new Image("8992", Members.All),
                new Image("8993", Members.My),
                new Image("8994", Members.Flechtnerovi),
                new Image("8996", Members.Krumlovaci | Members.My),
                new Image("8996", Members.Buresovi | Members.My | Members.Ondrous),
                new Image("9000", Members.Anicka | Members.My),
                new Image("9001", Members.JanaF | Members.My),
                new Image("9003", Members.Flechtnerovi | Members.My),
                new Image("9005", Members.Flechtnerovi),
                new Image("9009", Members.Babicky | Members.Kropackovi | Members.My),
                new Image("9011", Members.Kropackovi | Members.My),
                new Image("9015", Members.Rumburk | Members.My),
                new Image("9017", Members.Anicka | Members.Druzicky | Members.Buresovi),
                new Image("9019", Members.Druzicky | Members.My),
                new Image("9020", Members.Druzicky | Members.Ondrous),
                new Image("9021", Members.MichalAMaja),
                new Image("9022", Members.Buresovi | Members.My | Members.MichalAMaja),
                new Image("9023", Members.MichalAMaja | Members.Buresovi | Members.Druzicky | Members.My),
                new Image("9024", Members.Buresovi | Members.Druzicky | Members.Ondrous | Members.My),
                new Image("9025", Members.Druzicky | Members.My),
                new Image("9026", Members.My | Members.Ondrous | Members.Anicka),
                new Image("9027", Members.My | Members.Ondrous | Members.Anicka | Members.Rumburk),
                new Image("9028", Members.My | Members.Anicka),
                new Image("9031", Members.PavlaARobert | Members.My),
                new Image("9032", Members.Druzicky | Members.My | Members.KTisku),
                new Image("9034", Members.Klarka | Members.Matty | Members.LuckaK | Members.My | Members.Kropackovi),
                new Image("9036", Members.Krizovi | Members.My),
                new Image("9040", Members.MewsAll | Members.My),
                new Image("9042", Members.Charlie | Members.My),
                new Image("9043", Members.Charlie | Members.My),
                new Image("9047", Members.Martinove | Members.My),
                new Image("9050", Members.Krumlovaci),
                new Image("9056", Members.Krumlovaci | Members.My),
                new Image("9058", Members.Krumlovaci | Members.My),
                new Image("9061", Members.MisaL | Members.My),
                new Image("9065", Members.MisaL | Members.My),
                new Image("9067", Members.MisaL | Members.My | Members.Lena),
                new Image("9068", Members.Kebrlovi | Members.My | Members.Lena),
                new Image("9073", Members.GymplAll),
                new Image("9077", Members.My),
                new Image("9078", Members.My | Members.KTisku),
                new Image("9079", Members.My | Members.KTisku),
                new Image("9083", Members.My),
                new Image("9085", Members.My),
                new Image("9086", Members.All),
                new Image("9089", Members.All),
                new Image("9090", Members.My | Members.Flechtnerovi),
                new Image("9092", Members.My),
                new Image("9093", Members.All),
                new Image("9094", Members.My),
                new Image("9096", Members.My),
                new Image("9110", Members.All),
                new Image("9111", Members.All),
                new Image("9112", Members.All),
                new Image("9113", Members.All),
                new Image("9117", Members.My | Members.Krumlovaci),
                new Image("9118", Members.My | Members.Krumlovaci),
                new Image("9119", Members.My | Members.Krumlovaci),
                new Image("9120", Members.My | Members.Krumlovaci),
                new Image("9121", Members.My | Members.Krumlovaci),
                new Image("9122", Members.My | Members.Krumlovaci | Members.Anicka),
                new Image("9123", Members.My | Members.Krumlovaci),
                new Image("9125", Members.My | Members.Stefkovi),
                new Image("9127", Members.My | Members.Matty | Members.LuckaK),
                new Image("9130", Members.My | Members.Anicka),
                new Image("9132", Members.My),
                new Image("9134", Members.My | Members.VeseleKridlo | Members.Babicky | Members.Ondrous | Members.Flechtnerovi | Members.Krizovi | Members.Buresovi | Members.Kropackovi | Members.Klarka),
                new Image("9136", Members.My | Members.VeseleKridlo | Members.Babicky | Members.Ondrous | Members.Flechtnerovi | Members.Krizovi | Members.Buresovi | Members.Kropackovi | Members.Klarka),
                new Image("9137", Members.My | Members.VeseleKridlo | Members.Babicky | Members.Ondrous | Members.Flechtnerovi | Members.Krizovi | Members.Buresovi | Members.Kropackovi | Members.Klarka),
                new Image("9139", Members.My | Members.VeseleKridlo | Members.Babicky | Members.Ondrous | Members.Flechtnerovi),
                new Image("9140", Members.My | Members.VeseleKridlo | Members.Babicky | Members.Ondrous | Members.Flechtnerovi),
                new Image("9143", Members.My | Members.Klarka | Members.Babicky | Members.Krizovi | Members.VeseleKridlo | Members.LuckaK),
                new Image("9145", Members.My | Members.Klarka | Members.Babicky | Members.Krizovi | Members.VeseleKridlo | Members.LuckaK),
                new Image("9148", Members.My | Members.Flechtnerovi | Members.Ondrous | Members.VeseleKridlo),
                new Image("9149", Members.My | Members.Druzicky | Members.Charlie | Members.Ondrous | Members.Krizovi | Members.MichalAMaja | Members.Klarka),
                new Image("9150", Members.My | Members.Druzicky | Members.Charlie | Members.Ondrous | Members.Krizovi | Members.MichalAMaja | Members.Klarka),
                new Image("9153", Members.My | Members.Druzicky | Members.KTisku),
                new Image("9157", Members.My | Members.MisaL | Members.Anicka | Members.Lena | Members.KTisku),
                new Image("9158", Members.My | Members.MisaL | Members.Lena),
                new Image("9162", Members.My | Members.MisaL),
                new Image("9163", Members.My | Members.Flechtnerovi | Members.VeseleKridlo | Members.Ondrous | Members.KTisku),
                new Image("9165", Members.My | Members.Flechtnerovi | Members.VeseleKridlo | Members.Ondrous | Members.KTisku),
                new Image("9166", Members.My | Members.Flechtnerovi | Members.VeseleKridlo | Members.Ondrous | Members.KTisku),
                new Image("9168", Members.My | Members.GymplAll),
                new Image("9169", Members.My | Members.GymplAll),
                new Image("9171", Members.My | Members.GymplAll | Members.MichalAMaja),
                new Image("9174", Members.My | Members.Mews | Members.Martinove | Members.Martinove),
                new Image("9175", Members.My | Members.Mews),
                new Image("9177", Members.My),
                new Image("9178", Members.My),
                new Image("9180", Members.My | Members.KTisku),
                new Image("9181", Members.My),
                new Image("9182", Members.My),
                new Image("9185", Members.My),
                new Image("9186", Members.My),
                new Image("9188", Members.My),
                new Image("9190", Members.My),
                new Image("9192", Members.My),
                new Image("9195", Members.My),
                new Image("9196", Members.My),
                new Image("9198", Members.My),
                new Image("9199", Members.My | Members.Babicky | Members.Kropackovi | Members.Matty | Members.LuckaK),
                new Image("9201", Members.My),
                new Image("9203", Members.My),
                new Image("9204", Members.My),
                new Image("9206", Members.My),
                new Image("9208", Members.My),
                new Image("9212", Members.My),
                new Image("9213", Members.My),
                new Image("9216", Members.My),
                new Image("9218", Members.My | Members.Druzicky),
                new Image("9220", Members.My),
                new Image("9227", Members.All),
                new Image("9223", Members.My),
                new Image("9224", Members.My),
                new Image("9235", Members.My),
                new Image("9244", Members.My),
                new Image("9246", Members.My),
                new Image("9248", Members.My),
                new Image("9250", Members.All),
                new Image("9252", Members.My | Members.MichalAMaja),
                new Image("9263", Members.Babicky | Members.My),
                new Image("9265", Members.My | Members.Krumlovaci),
                new Image("9267", Members.My | Members.Krumlovaci | Members.Ondrous | Members.Klarka | Members.Krizovi),
                new Image("9268", Members.My | Members.LuckaK | Members.Krumlovaci),
                new Image("9271", Members.All),
                new Image("9273", Members.My),
                new Image("9274", Members.My),
                new Image("9275", Members.Ondrous),
                new Image("9276", Members.My | Members.Krumlovaci),
                new Image("9280", Members.My),
                new Image("9282", Members.My),
                new Image("9286", Members.My),
                new Image("9291", Members.My),
                new Image("9292", Members.My),
                new Image("9297", Members.My),
                new Image("9299", Members.My),
                new Image("9312", Members.My | Members.MichalAMaja | Members.Buresovi),
                new Image("9314", Members.My | Members.Babicky | Members.Flechtnerovi | Members.Kropackovi | Members.Ondrous),
                new Image("9315", Members.My | Members.Babicky | Members.Ondrous),
                new Image("9318", Members.VeseleKridlo),
                new Image("9321", Members.My),
                new Image("9323", Members.My | Members.Babicky),
                new Image("9326", Members.My),
                new Image("9327", Members.My),
                new Image("9329", Members.My),
                new Image("9330", Members.All),
                new Image("9331", Members.My),
                new Image("9333", Members.My),
                new Image("9334", Members.My),
                new Image("9335", Members.All),
                new Image("9336", Members.My),
                new Image("9340", Members.My),
                new Image("9342", Members.My),
                new Image("9346", Members.My),
                new Image("9347", Members.My | Members.VeseleKridlo | Members.Matty),
                new Image("9350", Members.My | Members.Druzicky),
                new Image("9352", Members.All),
                new Image("9358", Members.All),
                new Image("9364", Members.My),
                new Image("9367", Members.My),
                new Image("9370", Members.My),
                new Image("9373", Members.My | Members.Krizovi),
                new Image("9374", Members.My | Members.Krizovi | Members.Klarka | Members.Babicky | Members.Kropackovi),
                new Image("9375", Members.My | Members.Matty | Members.MichalAMaja | Members.Flechtnerovi),
                new Image("9376", Members.My | Members.Krizovi | Members.Klarka),
                new Image("9381", Members.My | Members.KTisku),
                new Image("9385", Members.All),
                new Image("9386", Members.All),
                new Image("9387", Members.My),
                new Image("9389", Members.My),
                new Image("9394", Members.My | Members.Buresovi | Members.Kropackovi),
                new Image("9395", Members.Martinove),
                new Image("9404", Members.My | Members.PavlaARobert | Members.Buresovi | Members.MichalAMaja | Members.Klarka),
                new Image("9406", Members.My | Members.MisaL | Members.Buresovi | Members.MichalAMaja | Members.Krizovi),
                new Image("9408", Members.All),
                new Image("9412", Members.My | Members.Klarka | Members.Kropackovi),
                new Image("9414", Members.My | Members.Flechtnerovi),
                new Image("9415", Members.My | Members.Flechtnerovi),
                new Image("9416", Members.My | Members.Flechtnerovi),
                new Image("9417", Members.My | Members.Flechtnerovi | Members.KTisku),
                new Image("9419", Members.My | Members.Krizovi | Members.Kropackovi),
                new Image("9429", Members.My | Members.MichalAMaja),
                new Image("9434", Members.My | Members.VeseleKridlo | Members.Ondrous),
                new Image("9434", Members.My | Members.Krumlovaci | Members.Druzicky | Members.MichalAMaja),
                new Image("9439", Members.My | Members.MichalAMaja),
                new Image("9442", Members.My | Members.Klarka),
                new Image("9444", Members.My | Members.MichalAMaja | Members.Mews | Members.Matty),
                new Image("9445", Members.My),
                new Image("9447", Members.My),
                new Image("9454", Members.My),
                new Image("9455", Members.My),
                new Image("9456", Members.My),
                new Image("9463", Members.My | Members.Mews | Members.Kebrlovi),
                new Image("9473", Members.My | Members.Druzicky | Members.Kebrlovi | Members.MisaL | Members.Klarka),
                new Image("9482", Members.GymplAll),
                new Image("9483", Members.My | Members.Kebrlovi | Members.MichalAMaja),
                new Image("9487", Members.My),
                new Image("9488", Members.My),
                new Image("9489", Members.My | Members.Krumlovaci),
                new Image("9491", Members.GymAll),
                new Image("9492", Members.GymAll),
                new Image("9493", Members.GymAll),
                new Image("9494", Members.GymAll),
                new Image("9502", Members.My | Members.Krumlovaci),
                new Image("9504", Members.Krumlovaci),
                new Image("9511", Members.My | Members.Krumlovaci),
                new Image("9522", Members.My),
                new Image("9539", Members.My),
                new Image("9545", Members.My),
                new Image("9558", Members.My),
                new Image("9579", Members.My | Members.Druzicky | Members.Flechtnerovi),
                new Image("9583", Members.All),
                new Image("9584", Members.My),
                new Image("9588", Members.My),
                new Image("9597", Members.My),
                new Image("9601", Members.My | Members.Anicka),
                new Image("9603", Members.Krumlovaci),
                new Image("9608", Members.Krumlovaci),
                new Image("9610", Members.My | Members.Krumlovaci),
                new Image("9611", Members.My | Members.Krumlovaci),
                new Image("9615", Members.My | Members.Mews),
                new Image("9616", Members.My | Members.Krumlovaci),
                new Image("9621", Members.Krumlovaci),
                new Image("9624", Members.Krumlovaci),
                new Image("9625", Members.Krumlovaci),
                new Image("9627", Members.My | Members.Krumlovaci | Members.Druzicky),
                new Image("9631", Members.My | Members.Krumlovaci),
                new Image("9632", Members.My | Members.Krumlovaci),
                new Image("9639", Members.Krumlovaci),
                new Image("9641", Members.Krumlovaci)
            ),
            new PhotoCollection("Photos\\RBK", "IMG_", "JPG",
                new Image("1779", Members.Buresovi | Members.Druzicky),
                new Image("1780", Members.Verejne),
                new Image("1781", Members.Rumburk)
            )
        };
    }
}
