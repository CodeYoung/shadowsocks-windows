using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shadowsocks.View
{
    public partial class TextBoxEx : TextBox
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        private string _emptyTextTip;
        /// <summary>
        /// 文本框默认值
        /// </summary>
        [Browsable(true)]
        [DefaultValue("文本框默认值")]
        [Description("文本框默认值")]
        public string EmptyTextTip
        {
            get => _emptyTextTip;
            set { _emptyTextTip = value;
                this.Invalidate();
            }
        }

        private Color _emptyTextTipColor = Color.DarkGray;
        /// <summary>
        /// 文本框默认文字前景色
        /// </summary>
        [Browsable(true)]
        [DefaultValue(typeof(Color),"DarkGray")]
        [Description("文本框默认文字前景色")]
        public Color EmptyTextTipColor { get => _emptyTextTipColor; set { _emptyTextTipColor = value; this.Invalidate(); } }

        


        public TextBoxEx()
        {
            InitializeComponent();
        }

        public TextBoxEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void WmPaint(ref Message m)
        {
            using (Graphics graphics = Graphics.FromHwnd(base.Handle))
            {
                if (((this.Text.Length == 0) && !string.IsNullOrEmpty(this._emptyTextTip)) && !this.Focused)
                {
                    TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter;
                    if (this.RightToLeft == RightToLeft.Yes)
                    {
                        flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
                    }
                    TextRenderer.DrawText(graphics, this._emptyTextTip, this.Font, base.ClientRectangle, this._emptyTextTipColor, flags);
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 15)
            {
                this.WmPaint(ref m);
            }
        }
    }
}
