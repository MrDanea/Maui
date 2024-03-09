namespace Maui.Models
{
    internal class SettingModel
    {
        // Your SettingModel implementation
    }
}

namespace Set
{
    public class Setting : Document
    {
        public Setting(string Numerical_Order, string NamePlayer1, string NamePlayer2, string LineColor, string LineWidth, string SizeBoard, string ThemeBoard, string ColorPlayer1, string ColorPlayer2)
        {
            no = Numerical_Order;
            name1 = NamePlayer1;
            name2 = NamePlayer2;
            lc = LineColor;
            lw = LineWidth;
            szb = SizeBoard;
            tb = ThemeBoard;
            clp1 = ColorPlayer1;
            clp2 = ColorPlayer2;
        }
    }
}

namespace System
{
    public partial class Document
    {
        public string? no { get => ObjectId; set => ObjectId = (string?)value; }
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
        static BsonData.Collection? _setting;
        public static BsonData.Collection? Settings
        {
            get
            {
                if (_setting == null)
                {
                    _setting = Main?.GetCollection(nameof(Settings));
                    if (_setting?.Find("1") == null)
                    {
                        _setting?.Insert(new Set.Setting("1", "ahfgsdg", "adgsdag", "dgsdg", "dgggdg", "hfdfgc", "fgjfg", "cfgj", "cfgj"));
                    }
                }
                return _setting;
            }
        }
    }
}
