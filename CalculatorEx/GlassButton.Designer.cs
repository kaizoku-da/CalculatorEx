namespace CalculatorEx
{
  partial class GlassButton
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.fade_effect = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // fade_effect
      // 
      this.fade_effect.Tick += new System.EventHandler(this.fade_effect_Tick);
      // 
      // GlassButton
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.DoubleBuffered = true;
      this.Name = "GlassButton";
      this.Size = new System.Drawing.Size(100, 30);
      this.MouseLeave += new System.EventHandler(this.GlassButton_MouseLeave);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.GlassButton_Paint);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlassButton_MouseDown);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GlassButton_MouseUp);
      this.MouseEnter += new System.EventHandler(this.GlassButton_MouseEnter);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer fade_effect;
  }
}
