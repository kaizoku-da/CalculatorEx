namespace CalculatorEx
{
  partial class Form1
  {//
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lbResult = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.gb0 = new CalculatorEx.GlassButton();
      this.gbPct = new CalculatorEx.GlassButton();
      this.gbSgn = new CalculatorEx.GlassButton();
      this.gb9 = new CalculatorEx.GlassButton();
      this.gb8 = new CalculatorEx.GlassButton();
      this.gb7 = new CalculatorEx.GlassButton();
      this.gb6 = new CalculatorEx.GlassButton();
      this.gb5 = new CalculatorEx.GlassButton();
      this.gb4 = new CalculatorEx.GlassButton();
      this.gb3 = new CalculatorEx.GlassButton();
      this.gb2 = new CalculatorEx.GlassButton();
      this.gb1 = new CalculatorEx.GlassButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.gbEnter = new CalculatorEx.GlassButton();
      this.gbRoot = new CalculatorEx.GlassButton();
      this.gbPow = new CalculatorEx.GlassButton();
      this.gbDiv = new CalculatorEx.GlassButton();
      this.gbMult = new CalculatorEx.GlassButton();
      this.gbMinus = new CalculatorEx.GlassButton();
      this.gbPlus = new CalculatorEx.GlassButton();
      this.lbOper = new System.Windows.Forms.Label();
      this.gbBack = new CalculatorEx.GlassButton();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbResult
      // 
      this.lbResult.BackColor = System.Drawing.Color.LightBlue;
      this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbResult.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbResult.ForeColor = System.Drawing.Color.Navy;
      this.lbResult.Location = new System.Drawing.Point(12, 8);
      this.lbResult.Name = "lbResult";
      this.lbResult.Size = new System.Drawing.Size(225, 35);
      this.lbResult.TabIndex = 0;
      this.lbResult.Text = "0123456789";
      this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
      this.groupBox1.Controls.Add(this.gb0);
      this.groupBox1.Controls.Add(this.gbPct);
      this.groupBox1.Controls.Add(this.gbSgn);
      this.groupBox1.Controls.Add(this.gb9);
      this.groupBox1.Controls.Add(this.gb8);
      this.groupBox1.Controls.Add(this.gb7);
      this.groupBox1.Controls.Add(this.gb6);
      this.groupBox1.Controls.Add(this.gb5);
      this.groupBox1.Controls.Add(this.gb4);
      this.groupBox1.Controls.Add(this.gb3);
      this.groupBox1.Controls.Add(this.gb2);
      this.groupBox1.Controls.Add(this.gb1);
      this.groupBox1.Location = new System.Drawing.Point(12, 47);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(134, 181);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      // 
      // gb0
      // 
      this.gb0.BackColor = System.Drawing.Color.Transparent;
      this.gb0.BorderColor = System.Drawing.Color.DarkGray;
      this.gb0.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb0.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb0.Location = new System.Drawing.Point(10, 131);
      this.gb0.Margin = new System.Windows.Forms.Padding(1);
      this.gb0.Name = "gb0";
      this.gb0.Radius = 7;
      this.gb0.Size = new System.Drawing.Size(36, 36);
      this.gb0.TabIndex = 0;
      this.gb0.TextButton = "0";
      this.gb0.TextColor = System.Drawing.Color.White;
      this.gb0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gbPct
      // 
      this.gbPct.BackColor = System.Drawing.Color.Transparent;
      this.gbPct.BorderColor = System.Drawing.Color.DarkGray;
      this.gbPct.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbPct.GlassColor = System.Drawing.Color.DarkBlue;
      this.gbPct.Location = new System.Drawing.Point(48, 131);
      this.gbPct.Margin = new System.Windows.Forms.Padding(1);
      this.gbPct.Name = "gbPct";
      this.gbPct.Radius = 7;
      this.gbPct.Size = new System.Drawing.Size(36, 36);
      this.gbPct.TabIndex = 10;
      this.gbPct.TextButton = ".";
      this.gbPct.TextColor = System.Drawing.Color.White;
      this.gbPct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gbSgn
      // 
      this.gbSgn.BackColor = System.Drawing.Color.Transparent;
      this.gbSgn.BorderColor = System.Drawing.Color.DarkGray;
      this.gbSgn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbSgn.GlassColor = System.Drawing.Color.DarkBlue;
      this.gbSgn.Location = new System.Drawing.Point(86, 131);
      this.gbSgn.Margin = new System.Windows.Forms.Padding(1);
      this.gbSgn.Name = "gbSgn";
      this.gbSgn.Radius = 7;
      this.gbSgn.Size = new System.Drawing.Size(36, 36);
      this.gbSgn.TabIndex = 11;
      this.gbSgn.TextButton = "-";
      this.gbSgn.TextColor = System.Drawing.Color.White;
      this.gbSgn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb9
      // 
      this.gb9.BackColor = System.Drawing.Color.Transparent;
      this.gb9.BorderColor = System.Drawing.Color.DarkGray;
      this.gb9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb9.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb9.Location = new System.Drawing.Point(86, 93);
      this.gb9.Margin = new System.Windows.Forms.Padding(1);
      this.gb9.Name = "gb9";
      this.gb9.Radius = 7;
      this.gb9.Size = new System.Drawing.Size(36, 36);
      this.gb9.TabIndex = 9;
      this.gb9.TextButton = "9";
      this.gb9.TextColor = System.Drawing.Color.White;
      this.gb9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb8
      // 
      this.gb8.BackColor = System.Drawing.Color.Transparent;
      this.gb8.BorderColor = System.Drawing.Color.DarkGray;
      this.gb8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb8.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb8.Location = new System.Drawing.Point(48, 93);
      this.gb8.Margin = new System.Windows.Forms.Padding(1);
      this.gb8.Name = "gb8";
      this.gb8.Radius = 7;
      this.gb8.Size = new System.Drawing.Size(36, 36);
      this.gb8.TabIndex = 8;
      this.gb8.TextButton = "8";
      this.gb8.TextColor = System.Drawing.Color.White;
      this.gb8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb7
      // 
      this.gb7.BackColor = System.Drawing.Color.Transparent;
      this.gb7.BorderColor = System.Drawing.Color.DarkGray;
      this.gb7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb7.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb7.Location = new System.Drawing.Point(10, 93);
      this.gb7.Margin = new System.Windows.Forms.Padding(1);
      this.gb7.Name = "gb7";
      this.gb7.Radius = 7;
      this.gb7.Size = new System.Drawing.Size(36, 36);
      this.gb7.TabIndex = 7;
      this.gb7.TextButton = "7";
      this.gb7.TextColor = System.Drawing.Color.White;
      this.gb7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb6
      // 
      this.gb6.BackColor = System.Drawing.Color.Transparent;
      this.gb6.BorderColor = System.Drawing.Color.DarkGray;
      this.gb6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb6.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb6.Location = new System.Drawing.Point(86, 55);
      this.gb6.Margin = new System.Windows.Forms.Padding(1);
      this.gb6.Name = "gb6";
      this.gb6.Radius = 7;
      this.gb6.Size = new System.Drawing.Size(36, 36);
      this.gb6.TabIndex = 6;
      this.gb6.TextButton = "6";
      this.gb6.TextColor = System.Drawing.Color.White;
      this.gb6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb5
      // 
      this.gb5.BackColor = System.Drawing.Color.Transparent;
      this.gb5.BorderColor = System.Drawing.Color.DarkGray;
      this.gb5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb5.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb5.Location = new System.Drawing.Point(48, 55);
      this.gb5.Margin = new System.Windows.Forms.Padding(1);
      this.gb5.Name = "gb5";
      this.gb5.Radius = 7;
      this.gb5.Size = new System.Drawing.Size(36, 36);
      this.gb5.TabIndex = 5;
      this.gb5.TextButton = "5";
      this.gb5.TextColor = System.Drawing.Color.White;
      this.gb5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb4
      // 
      this.gb4.BackColor = System.Drawing.Color.Transparent;
      this.gb4.BorderColor = System.Drawing.Color.DarkGray;
      this.gb4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb4.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb4.Location = new System.Drawing.Point(10, 55);
      this.gb4.Margin = new System.Windows.Forms.Padding(1);
      this.gb4.Name = "gb4";
      this.gb4.Radius = 7;
      this.gb4.Size = new System.Drawing.Size(36, 36);
      this.gb4.TabIndex = 4;
      this.gb4.TextButton = "4";
      this.gb4.TextColor = System.Drawing.Color.White;
      this.gb4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb3
      // 
      this.gb3.BackColor = System.Drawing.Color.Transparent;
      this.gb3.BorderColor = System.Drawing.Color.DarkGray;
      this.gb3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb3.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb3.Location = new System.Drawing.Point(86, 17);
      this.gb3.Margin = new System.Windows.Forms.Padding(1);
      this.gb3.Name = "gb3";
      this.gb3.Radius = 7;
      this.gb3.Size = new System.Drawing.Size(36, 36);
      this.gb3.TabIndex = 3;
      this.gb3.TextButton = "3";
      this.gb3.TextColor = System.Drawing.Color.White;
      this.gb3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb2
      // 
      this.gb2.BackColor = System.Drawing.Color.Transparent;
      this.gb2.BorderColor = System.Drawing.Color.DarkGray;
      this.gb2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb2.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb2.Location = new System.Drawing.Point(48, 17);
      this.gb2.Margin = new System.Windows.Forms.Padding(1);
      this.gb2.Name = "gb2";
      this.gb2.Radius = 7;
      this.gb2.Size = new System.Drawing.Size(36, 36);
      this.gb2.TabIndex = 2;
      this.gb2.TextButton = "2";
      this.gb2.TextColor = System.Drawing.Color.White;
      this.gb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // gb1
      // 
      this.gb1.BackColor = System.Drawing.Color.Transparent;
      this.gb1.BorderColor = System.Drawing.Color.DarkGray;
      this.gb1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb1.GlassColor = System.Drawing.Color.DarkBlue;
      this.gb1.Location = new System.Drawing.Point(10, 17);
      this.gb1.Margin = new System.Windows.Forms.Padding(1);
      this.gb1.Name = "gb1";
      this.gb1.Radius = 7;
      this.gb1.Size = new System.Drawing.Size(36, 36);
      this.gb1.TabIndex = 1;
      this.gb1.TextButton = "1";
      this.gb1.TextColor = System.Drawing.Color.White;
      this.gb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbNumber_MouseClick);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.gbEnter);
      this.groupBox2.Controls.Add(this.gbRoot);
      this.groupBox2.Controls.Add(this.gbPow);
      this.groupBox2.Controls.Add(this.gbDiv);
      this.groupBox2.Controls.Add(this.gbMult);
      this.groupBox2.Controls.Add(this.gbMinus);
      this.groupBox2.Controls.Add(this.gbPlus);
      this.groupBox2.Location = new System.Drawing.Point(150, 47);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(87, 181);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      // 
      // gbEnter
      // 
      this.gbEnter.BackColor = System.Drawing.Color.Transparent;
      this.gbEnter.BorderColor = System.Drawing.Color.DarkGray;
      this.gbEnter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbEnter.GlassColor = System.Drawing.Color.Black;
      this.gbEnter.Location = new System.Drawing.Point(6, 131);
      this.gbEnter.Margin = new System.Windows.Forms.Padding(1);
      this.gbEnter.Name = "gbEnter";
      this.gbEnter.Radius = 7;
      this.gbEnter.Size = new System.Drawing.Size(74, 36);
      this.gbEnter.TabIndex = 6;
      this.gbEnter.TextButton = "Enter";
      this.gbEnter.TextColor = System.Drawing.Color.Orange;
      this.gbEnter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbOperation_MouseClick);
      // 
      // gbRoot
      // 
      this.gbRoot.BackColor = System.Drawing.Color.Transparent;
      this.gbRoot.BorderColor = System.Drawing.Color.DarkGray;
      this.gbRoot.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbRoot.GlassColor = System.Drawing.Color.DarkRed;
      this.gbRoot.Location = new System.Drawing.Point(44, 93);
      this.gbRoot.Margin = new System.Windows.Forms.Padding(1);
      this.gbRoot.Name = "gbRoot";
      this.gbRoot.Radius = 7;
      this.gbRoot.Size = new System.Drawing.Size(36, 36);
      this.gbRoot.TabIndex = 5;
      this.gbRoot.TextButton = "&";
      this.gbRoot.TextColor = System.Drawing.Color.White;
      this.gbRoot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbOperation_MouseClick);
      // 
      // gbPow
      // 
      this.gbPow.BackColor = System.Drawing.Color.Transparent;
      this.gbPow.BorderColor = System.Drawing.Color.DarkGray;
      this.gbPow.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbPow.GlassColor = System.Drawing.Color.DarkRed;
      this.gbPow.Location = new System.Drawing.Point(6, 93);
      this.gbPow.Margin = new System.Windows.Forms.Padding(1);
      this.gbPow.Name = "gbPow";
      this.gbPow.Radius = 7;
      this.gbPow.Size = new System.Drawing.Size(36, 36);
      this.gbPow.TabIndex = 4;
      this.gbPow.TextButton = "^";
      this.gbPow.TextColor = System.Drawing.Color.White;
      this.gbPow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbOperation_MouseClick);
      // 
      // gbDiv
      // 
      this.gbDiv.BackColor = System.Drawing.Color.Transparent;
      this.gbDiv.BorderColor = System.Drawing.Color.DarkGray;
      this.gbDiv.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbDiv.GlassColor = System.Drawing.Color.DarkRed;
      this.gbDiv.Location = new System.Drawing.Point(44, 55);
      this.gbDiv.Margin = new System.Windows.Forms.Padding(1);
      this.gbDiv.Name = "gbDiv";
      this.gbDiv.Radius = 7;
      this.gbDiv.Size = new System.Drawing.Size(36, 36);
      this.gbDiv.TabIndex = 3;
      this.gbDiv.TextButton = "/";
      this.gbDiv.TextColor = System.Drawing.Color.White;
      this.gbDiv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbOperation_MouseClick);
      // 
      // gbMult
      // 
      this.gbMult.BackColor = System.Drawing.Color.Transparent;
      this.gbMult.BorderColor = System.Drawing.Color.DarkGray;
      this.gbMult.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbMult.GlassColor = System.Drawing.Color.DarkRed;
      this.gbMult.Location = new System.Drawing.Point(6, 55);
      this.gbMult.Margin = new System.Windows.Forms.Padding(1);
      this.gbMult.Name = "gbMult";
      this.gbMult.Radius = 7;
      this.gbMult.Size = new System.Drawing.Size(36, 36);
      this.gbMult.TabIndex = 2;
      this.gbMult.TextButton = "x";
      this.gbMult.TextColor = System.Drawing.Color.White;
      this.gbMult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbOperation_MouseClick);
      // 
      // gbMinus
      // 
      this.gbMinus.BackColor = System.Drawing.Color.Transparent;
      this.gbMinus.BorderColor = System.Drawing.Color.DarkGray;
      this.gbMinus.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbMinus.GlassColor = System.Drawing.Color.DarkRed;
      this.gbMinus.Location = new System.Drawing.Point(44, 17);
      this.gbMinus.Margin = new System.Windows.Forms.Padding(1);
      this.gbMinus.Name = "gbMinus";
      this.gbMinus.Radius = 7;
      this.gbMinus.Size = new System.Drawing.Size(36, 36);
      this.gbMinus.TabIndex = 1;
      this.gbMinus.TextButton = "-";
      this.gbMinus.TextColor = System.Drawing.Color.White;
      this.gbMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbOperation_MouseClick);
      // 
      // gbPlus
      // 
      this.gbPlus.BackColor = System.Drawing.Color.Transparent;
      this.gbPlus.BorderColor = System.Drawing.Color.DarkGray;
      this.gbPlus.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbPlus.GlassColor = System.Drawing.Color.DarkRed;
      this.gbPlus.Location = new System.Drawing.Point(6, 17);
      this.gbPlus.Margin = new System.Windows.Forms.Padding(1);
      this.gbPlus.Name = "gbPlus";
      this.gbPlus.Radius = 7;
      this.gbPlus.Size = new System.Drawing.Size(36, 36);
      this.gbPlus.TabIndex = 0;
      this.gbPlus.TextButton = "+";
      this.gbPlus.TextColor = System.Drawing.Color.White;
      this.gbPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbOperation_MouseClick);
      // 
      // lbOper
      // 
      this.lbOper.BackColor = System.Drawing.Color.Gold;
      this.lbOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbOper.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbOper.Location = new System.Drawing.Point(245, 64);
      this.lbOper.Name = "lbOper";
      this.lbOper.Size = new System.Drawing.Size(36, 36);
      this.lbOper.TabIndex = 4;
      this.lbOper.Text = "+";
      this.lbOper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // gbBack
      // 
      this.gbBack.BackColor = System.Drawing.Color.Transparent;
      this.gbBack.BorderColor = System.Drawing.Color.DarkGray;
      this.gbBack.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbBack.GlassColor = System.Drawing.Color.Black;
      this.gbBack.Location = new System.Drawing.Point(241, 8);
      this.gbBack.Margin = new System.Windows.Forms.Padding(1);
      this.gbBack.Name = "gbBack";
      this.gbBack.Radius = 7;
      this.gbBack.Size = new System.Drawing.Size(40, 35);
      this.gbBack.TabIndex = 3;
      this.gbBack.TextButton = "Bk";
      this.gbBack.TextColor = System.Drawing.Color.White;
      this.gbBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gbBack_MouseClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(289, 238);
      this.Controls.Add(this.lbOper);
      this.Controls.Add(this.gbBack);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lbResult);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      //Changing title to "Calculatrice"
      this.Text = "Calculatrice en français";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lbResult;
    private System.Windows.Forms.GroupBox groupBox1;
    private CalculatorEx.GlassButton gb1;
    private CalculatorEx.GlassButton gb3;
    private CalculatorEx.GlassButton gb2;
    private CalculatorEx.GlassButton gb6;
    private CalculatorEx.GlassButton gb5;
    private CalculatorEx.GlassButton gb4;
    private CalculatorEx.GlassButton gb9;
    private CalculatorEx.GlassButton gb8;
    private CalculatorEx.GlassButton gb7;
    private CalculatorEx.GlassButton gb0;
    private CalculatorEx.GlassButton gbPct;
    private CalculatorEx.GlassButton gbSgn;
    private System.Windows.Forms.GroupBox groupBox2;
    private CalculatorEx.GlassButton gbPlus;
    private CalculatorEx.GlassButton gbMinus;
    private CalculatorEx.GlassButton gbMult;
    private CalculatorEx.GlassButton gbRoot;
    private CalculatorEx.GlassButton gbPow;
    private CalculatorEx.GlassButton gbDiv;
    private CalculatorEx.GlassButton gbEnter;
    private GlassButton gbBack;
    private System.Windows.Forms.Label lbOper;
  }
}

