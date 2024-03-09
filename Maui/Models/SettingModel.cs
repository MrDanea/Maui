namespace Maui.Models
{
    internal class SettingModel
    {
        // Your SettingModel implementation
    }
}

namespace set
{
    public class setting : Document
    {
        static public setting createone(/*string numerical_order,*/string nameplayer1, string nameplayer2, string linecolor, string linewidth, string sizeboard, string themeboard, string colorplayer1, string colorplayer2)
        {
            var info = new setting
            {
            //no = numerical_order,
            name1 = nameplayer1,
            name2 = nameplayer2,
            lc = linecolor,
            lw = linewidth,
            szb = sizeboard,
            tb = themeboard,
            clp1 = colorplayer1,
            clp2 = colorplayer2,
            };
            return info;
        }
    }
}

namespace System
        {
    public partial class Document
            {
        //public string? no { get => ObjectId; set => ObjectId = (string?)value; }
        public string? name1 { get => GetString(nameof(name1)); set => Push(nameof(name1), value); }
        public string? name2 { get => GetString(nameof(name2)); set => Push(nameof(name2), value); }
        public string? lc { get => GetString(nameof(lc)); set => Push(nameof(lc), value); }
        public string? lw { get => GetString(nameof(lw)); set => Push(nameof(lw), value); }
        public string? szb { get => GetString(nameof(szb)); set => Push(nameof(szb), value); }
        public string? tb { get => GetString(nameof(tb)); set => Push(nameof(tb), value); }
        public string? clp1 { get => GetString(nameof(clp1)); set => Push(nameof(clp1), value); }
        public string? clp2 { get => GetString(nameof(clp2)); set => Push(nameof(clp2), value); }
    }

    public partial class DB
    {
        static public BsonData.Collection Settings => Main.GetCollection(nameof(Settings));
        //static BsonData.Collection? _setting;
        //public static BsonData.Collection? settings
        //{
        //    get
        //    {
        //        if (_setting == null)
        //        {
        //            _setting = Main?.GetCollection(nameof(settings));
        //            if (_setting?.Find("1") == null)
        //            {
        //                var test = set.setting.createone("ahfgsdg", "adgsdag", "dgsdg", "dgggdg", "hfdfgc", "fgjfg", "cfgj", "cfgj");
        //                _setting?.Insert(test);
        //            }
        //        }
        //        return _setting;
        //    }
        //}
    }
}