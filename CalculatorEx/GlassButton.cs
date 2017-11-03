using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CalculatorEx
{
    public partial class GlassButton : UserControl
  {
    private int ctransp, mRadius;
    private float borderwidth;
    private bool uptransp;
    private Color mGlassColor, mBorderColor;
    private Color mTextColor;
    private Brush glassbrush1, glassbrush2;
    private Brush textbrush;
    private Pen borderpen;
    private string mText;
    public string CmdLine;
    StringFormat format = new StringFormat()
    {
      Alignment = StringAlignment.Center,
      LineAlignment = StringAlignment.Center
    };

    public Color GlassColor
    {
      get { return mGlassColor; }
      set
      {
        mGlassColor = value;
        glassbrush1 = new SolidBrush(Color.FromArgb(ctransp, mGlassColor));
        glassbrush2 = new SolidBrush(Color.FromArgb(ctransp + 40, mGlassColor));
        this.Invalidate();
      }
    }
    public Color BorderColor
    {
      get { return mBorderColor; }
      set
      {
        mBorderColor = value;
        borderpen = new Pen(mBorderColor, borderwidth);
        this.Invalidate();
      }
    }
    public Color TextColor
    {
      get { return mTextColor; }
      set
      {
        mTextColor = value;
        textbrush = new SolidBrush(mTextColor);
        this.Invalidate();
      }
    }
    public String TextButton
    {
      get { return mText; }
      set
      {
        mText = value;
        this.Invalidate();
      }
    }
    public int Radius
    {
      get { return mRadius; }
      set
      {
        mRadius = value;
        this.Invalidate();
      }
    }

    public GlassButton()
    {
      InitializeComponent();
      this.BackColor = Color.Transparent;
      mGlassColor = Color.Black;
      mBorderColor = Color.DarkGray;
      borderwidth = 2.0f;
      mRadius = 10;
      mTextColor = Color.White;
      ctransp = 160; uptransp = true;
      fade_effect.Interval = 10;
      glassbrush1 = new SolidBrush(Color.FromArgb(ctransp, mGlassColor));
      glassbrush2 = new SolidBrush(Color.FromArgb(ctransp + 40, mGlassColor));
      textbrush = new SolidBrush(mTextColor);
      borderpen = new Pen(mBorderColor, borderwidth);
      mText = "GlassButton";
    }

    private void GlassButton_Paint(object sender, PaintEventArgs e)
    {
      int w = this.ClientSize.Width;
      int h = this.ClientSize.Height;
      int a = h / 2;
      Rectangle rect = new Rectangle(1, 1, w - 1, h - 1);
      GraphicsPath roundrect = RoundRect(rect, mRadius);
      Rectangle rect1 = new Rectangle(0, 0, w, a);
      Rectangle rect2 = new Rectangle(0, a, w, h - a);
      Graphics g = e.Graphics;
      g.SmoothingMode = SmoothingMode.AntiAlias;
      g.InterpolationMode = InterpolationMode.HighQualityBilinear;
      g.PixelOffsetMode = PixelOffsetMode.HighQuality;
      g.SetClip(roundrect);
      g.FillRectangle(Brushes.White, rect);
      g.FillRectangle(glassbrush1, rect1);
      g.FillRectangle(glassbrush2, rect2);
      g.DrawString(mText, this.Font, textbrush, w / 2.0f, h / 2.0f, format);
      g.DrawPath(borderpen, roundrect);
      g.ResetClip();
      
    }

    private GraphicsPath RoundRect(Rectangle rect, int radius)
    {
      GraphicsPath gp = new GraphicsPath();
      int x1 = rect.X; int y1 = rect.Y;
      int x2 = rect.X + rect.Width;
      int y2 = rect.Y + rect.Height;
      int d = 2 * radius;
      gp.AddLine(x1 + radius, y1, x2 - radius, y1);
      gp.AddArc(x2 - d, y1, d, d, 270, 90);
      gp.AddLine(x2, y1 + radius, x2, y2 - radius);
      gp.AddArc(x2 - d, y2 - d, d, d, 0, 90);
      gp.AddLine(x2 - radius, y2, x1 + radius, y2);
      gp.AddArc(x1, y2 - d, d, d, 90, 90);
      gp.AddLine(x1, y2 - radius, x1, y1 + radius);
      gp.AddArc(x1, y1, d, d, 180, 90);
      return gp;
    }

    private void fade_effect_Tick(object sender, EventArgs e)
    {
      if (uptransp) ctransp += 2;
      else ctransp -= 2;
      glassbrush1 = new SolidBrush(Color.FromArgb(ctransp, mGlassColor));
      glassbrush2 = new SolidBrush(Color.FromArgb(ctransp + 40, mGlassColor));
      this.Invalidate();
      if ((ctransp >= 160) || (ctransp <= 100)) fade_effect.Stop();
    }

    public void Press()
    {    
      glassbrush1 = new SolidBrush(Color.FromArgb(200, mGlassColor));
      glassbrush2 = new SolidBrush(Color.FromArgb(240, mGlassColor));
      this.Invalidate();
      for (int i = 0; i < 15000; i++) Application.DoEvents();
      ctransp = 160;
      glassbrush1 = new SolidBrush(Color.FromArgb(ctransp, mGlassColor));
      glassbrush2 = new SolidBrush(Color.FromArgb(ctransp + 40, mGlassColor));
      this.Invalidate();
    }

    private void GlassButton_MouseEnter(object sender, EventArgs e)
    {
      uptransp = false; ctransp = 160;
      fade_effect.Start();
    }

    private void GlassButton_MouseLeave(object sender, EventArgs e)
    {
      uptransp = true; ctransp = 100;
      fade_effect.Start();
    }

    private void GlassButton_MouseDown(object sender, MouseEventArgs e)
    {
      fade_effect.Stop(); ctransp = 100;
      glassbrush1 = new SolidBrush(Color.FromArgb(200, mGlassColor));
      glassbrush2 = new SolidBrush(Color.FromArgb(240, mGlassColor));
      this.Invalidate();
    }

    private void GlassButton_MouseUp(object sender, MouseEventArgs e)
    {
      glassbrush1 = new SolidBrush(Color.FromArgb(ctransp, mGlassColor));
      glassbrush2 = new SolidBrush(Color.FromArgb(ctransp + 40, mGlassColor));
      this.Invalidate();
    }

    public override string ToString()
    {
      return (TextButton + "," + GlassColor.Name + "," + TextColor.Name + "," + CmdLine); 
    }
    
  }//end GlassButton
}
