using System.Drawing;

namespace honyaku
{
    /// <summary>
    /// ウィンドウの配置場所
    /// </summary>
    public struct Place
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public Point Location { get; set; }

        /// <summary>
        /// サイズ
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="location">位置</param>
        /// <param name="size">サイズ</param>
        public Place(string name, Point location, Size size)
        {
            this.Name = name;
            this.Location = location;
            this.Size = size;
        }
    }
}
