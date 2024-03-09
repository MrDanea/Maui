namespace Maui.Models
{
    internal class SettingModel
    {
    }
}

namespace System
{
    partial class SettingInfo : Document
    {
        public SettingInfo() { }
        public SettingInfo(string NamePlayer1, string NamePlayer2, string LineColor, string LineWidth, string SizeBoard, string ThemeBoard, string ColorPlayer1, string ColorPlayer2)
        {
            this.NamePlayer1 = NamePlayer1;
            this.NamePlayer2 = NamePlayer2;
            this.LineColor = LineColor;
            this.LineWidth = LineWidth;
            this.SizeBoard = SizeBoard;
            this.ThemeBoard = ThemeBoard;
            this.ColorPlayer1 = ColorPlayer1;
            this.ColorPlayer2 = ColorPlayer2;
        }
        public string NamePlayer1 { get => GetString(nameof(NamePlayer1)); set => Push(nameof(NamePlayer1), value); }
        public string NamePlayer2 { get => GetString(nameof(NamePlayer2)); set => Push(nameof(NamePlayer2), value); }
        public string LineColor { get => GetString(nameof(LineColor)); set => Push(nameof(LineColor), value); }
        public string LineWidth { get => GetString(nameof(LineWidth)); set => Push(nameof(LineWidth), value); }
        public string SizeBoard { get => GetString(nameof(SizeBoard)); set => Push(nameof(SizeBoard), value); }
        public string ThemeBoard { get => GetString(nameof(ThemeBoard)); set => Push(nameof(ThemeBoard), value); }
        public string ColorPlayer1 { get => GetString(nameof(ColorPlayer1)); set => Push(nameof(ColorPlayer1), value); }
        public string ColorPlayer2 { get => GetString(nameof(ColorPlayer2)); set => Push(nameof(ColorPlayer2), value); }
        public Document? Childs
        {
            get => GetDocument(nameof(Childs));
            set => Push(nameof(Childs), value);
        }
        public void AddChild(Document context)
        {
            SelectContext(nameof(Childs), doc =>
            {
                doc.Add(context.ObjectId, context);
            });
        }

    }

    partial class DB
    {
        static BsonData.Collection? _setting;
        static public BsonData.Collection Setting
        {
            get
            {
                _setting = Main.GetCollection(nameof(Setting));
                _setting.Insert(new SettingInfo("c", "c", "c", "c", "c", "c", "c", "c"));
                return _setting;
            }
        }

    }
}