using System;
using System.Drawing;
using System.Windows.Forms;

namespace honyaku
{
    /// <summary>
    /// 簡易キャプチャーフォーム
    /// </summary>
    public partial class QuickCaptureForm : Form
    {
        /// <summary>
        /// 指定した範囲をキャプチャしたイメージ
        /// </summary>
        public Bitmap ResultImage = null;

        /// <summary>
        /// マウスダウン座標、マウスアップ座標
        /// </summary>
        private Point MouseDownPoint;

        /// <summary>
        /// マウスダウンフラグ
        /// </summary>
        private bool MouseDownFlag;

        /// <summary>
        /// 枠線のペンを定義
        /// </summary>
        private Pen RedPen = new Pen(Color.Red, 3f);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public QuickCaptureForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームのマウスダウンイベント
        /// </summary>
        private void QuickCaptureForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) this.Close();
            this.MouseDownPoint = Cursor.Position;
            this.MouseDownFlag = true;
        }

        /// <summary>
        /// フォームのマウスアップイベント
        /// </summary>
        private void QuickCaptureForm_MouseUp(object sender, MouseEventArgs e)
        {
            // 描画を消去
            this.Refresh();

            Point mousePoint = Cursor.Position;
            Size pictureSize = new Size(
                Math.Abs(this.MouseDownPoint.X - mousePoint.X),
                Math.Abs(this.MouseDownPoint.Y - mousePoint.Y)
            );

            if (this.MouseDownFlag && pictureSize.Width > 0 && pictureSize.Height > 0)
            {
                this.Hide();
                this.ResultImage = new Bitmap(pictureSize.Width, pictureSize.Height);
                Graphics g = Graphics.FromImage(this.ResultImage);
                g.CopyFromScreen(new Point(
                    this.MouseDownPoint.X - mousePoint.X > 0 ? mousePoint.X : this.MouseDownPoint.X,
                    this.MouseDownPoint.Y - mousePoint.Y > 0 ? mousePoint.Y : this.MouseDownPoint.Y
                ), new Point(0, 0), this.ResultImage.Size);
                g.Dispose();
            }
            
            this.Close();
        }

        /// <summary>
        /// フォームのマウス移動イベント
        /// </summary>
        private void QuickCaptureForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.MouseDownFlag)
            {
                // 描画を消去
                this.Refresh();

                Point mousePoint = Cursor.Position;
                Graphics g = CreateGraphics();
                g.DrawLine(RedPen, this.MouseDownPoint.X, this.MouseDownPoint.Y, mousePoint.X, this.MouseDownPoint.Y);
			    g.DrawLine(RedPen, this.MouseDownPoint.X, this.MouseDownPoint.Y, this.MouseDownPoint.X, mousePoint.Y);
		        g.DrawLine(RedPen, mousePoint.X, this.MouseDownPoint.Y, mousePoint.X, mousePoint.Y);
			    g.DrawLine(RedPen, this.MouseDownPoint.X, mousePoint.Y, mousePoint.X, mousePoint.Y);
                g.Dispose();
            }
        }
    }
}
