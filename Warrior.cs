// Decompiled with JetBrains decompiler
// Type: XRRMacro.Attack
// Assembly: XRRMacro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B754BDB-ED1F-4356-8C42-E5D2A7DF9C93
// Assembly location: C:\Users\Admin\Desktop\net7.0-windows\net7.0-windows\XRRMacro.dll

using HootKeys;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;


#nullable enable
namespace XRRMacro
{
  public class Attack : Form
  {
    private globalKeyboardHook klavye = new globalKeyboardHook();
    private bool skillon;
    private bool rron;
    private bool macroon;
    private bool isepressed;
    private bool koordinatal;
    private bool echokoordinatal;
    private bool kalkanon;
    private bool echoon = false;
    private static int rrms;
    private static int skillms;
    private static int kalkanms = 1;
    private static InputSimulator sim = new InputSimulator();
    private static Coordinate coordinate;
    private static Coordinate echocoordinate;
    private 
    #nullable disable
    IContainer components = (IContainer) null;
    private Label label3;
    private Button button3;
    private Label label2;
    private Label label1;
    private NumericUpDown numericUpDown4;
    private NumericUpDown numericUpDown3;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private GroupBox groupBox1;
    private GroupBox Kalkan;
    private Button button2;
    private Label label9;
    private Button button1;
    private Label label8;
    private NumericUpDown numericUpDown1;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label10;
    private GroupBox groupBox2;
    private Button button4;
    private Label label11;
    private Label label12;
    private Button button5;
    private Label label13;
    private Label label14;
    private Label label16;
    private Label label15;

    public Attack()
    {
      this.InitializeComponent();
      this.TuslariDinle();
    }

    private void numericUpDown4_ValueChanged_1(
    #nullable enable
    object sender, EventArgs e) => Attack.rrms = Convert.ToInt32(this.numericUpDown4.Value);

    private void button3_Click(object sender, EventArgs e)
    {
      this.macroon = !this.macroon;
      if (this.macroon)
      {
        this.label3.Text = "On";
        this.groupBox1.BackColor = Color.Turquoise;
      }
      else
      {
        this.label3.Text = "Off";
        this.groupBox1.BackColor = Color.LightGray;
      }
    }

    private void numericUpDown4_ValueChanged(object sender, EventArgs e) => Attack.rrms = Convert.ToInt32(this.numericUpDown4.Value);

    private void checkBox2_CheckedChanged(object sender, EventArgs e) => this.rron = this.checkBox2.Checked;

    private void numericUpDown1_ValueChanged(object sender, EventArgs e) => Attack.kalkanms = Convert.ToInt32(this.numericUpDown1.Value);

    private void Attack_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

    private void button1_Click(object sender, EventArgs e)
    {
      this.kalkanon = !this.kalkanon;
      if (this.kalkanon)
      {
        this.label9.Text = "On";
        this.Kalkan.BackColor = Color.Turquoise;
      }
      else
      {
        this.label9.Text = "Off";
        this.Kalkan.BackColor = Color.LightGray;
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.echokoordinatal = true;
      this.label12.Text = "Koordinat Alınıyor";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.echoon = !this.echoon;
      if (this.echoon)
      {
        this.label11.Text = "On";
        this.groupBox2.BackColor = Color.Turquoise;
      }
      else
      {
        this.label11.Text = "Off";
        this.groupBox2.BackColor = Color.LightGray;
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) => this.skillon = this.checkBox1.Checked;

    private void numericUpDown3_ValueChanged(object sender, EventArgs e) => Attack.skillms = Convert.ToInt32(this.numericUpDown3.Value);

    private void button2_Click(object sender, EventArgs e)
    {
      this.koordinatal = true;
      this.label10.Text = "Koordinat Alınıyor";
    }

    private void TuslariDinle()
    {
      this.klavye.HookedKeys.Add(Keys.Capital);
      this.klavye.HookedKeys.Add(Keys.Space);
      this.klavye.HookedKeys.Add(Keys.F);
      this.klavye.HookedKeys.Add(Keys.E);
      this.klavye.HookedKeys.Add(Keys.X);
      this.klavye.KeyDown += new KeyEventHandler(this.TusBasmaAni);
    }

    private void TusBasmaAni(object? sender, KeyEventArgs e)
    {
      if (this.macroon)
      {
        if (e.KeyCode == Keys.Capital)
        {
          this.isepressed = false;
          if (this.skillon)
            Task.Run(new Action(this.SkillCombo));
          if (this.rron)
            Task.Run(new Action(this.RRCombo));
        }
        else if (e.KeyCode == Keys.E)
          this.isepressed = true;
      }
      if (this.kalkanon && e.KeyCode == Keys.F)
        MouseEventWin32.SagMouseClick(Attack.coordinate.X, Attack.coordinate.Y, Attack.kalkanms);
      if (this.koordinatal && e.KeyCode == Keys.X)
      {
        MouseOperations.MousePoint cursorPosition = MouseOperations.GetCursorPosition();
        Attack.coordinate = new Coordinate(cursorPosition.X, cursorPosition.Y);
        this.label10.Text = "Koordinat Alındı";
        this.label5.Text = Attack.coordinate.X.ToString();
        this.label7.Text = Attack.coordinate.Y.ToString();
        this.koordinatal = false;
      }
      if (this.echokoordinatal && e.KeyCode == Keys.X)
      {
        MouseOperations.MousePoint cursorPosition = MouseOperations.GetCursorPosition();
        Attack.echocoordinate = new Coordinate(cursorPosition.X, cursorPosition.Y);
        this.label12.Text = "Koordinat Alındı";
        this.label15.Text = Attack.echocoordinate.X.ToString();
        this.label13.Text = Attack.echocoordinate.Y.ToString();
        this.echokoordinatal = false;
      }
      if (!this.echoon || e.KeyCode != Keys.Space)
        return;
      Attack.sim.Keyboard.KeyDown(VirtualKeyCode.F2);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyUp(VirtualKeyCode.F2);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyDown(VirtualKeyCode.VK_3);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyUp(VirtualKeyCode.VK_3);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyDown(VirtualKeyCode.VK_4);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyUp(VirtualKeyCode.VK_4);
      Thread.Sleep(100);
      MouseEventWin32.SolMouseClick(Attack.echocoordinate.X, Attack.echocoordinate.Y);
      Thread.Sleep(275);
      Attack.sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Attack.sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
      Thread.Sleep(275);
      MouseEventWin32.SolMouseClick(Attack.echocoordinate.X, Attack.echocoordinate.Y);
    }

    private void SkillCombo()
    {
      while (!this.isepressed)
      {
        Attack.sim.Keyboard.KeyDown(VirtualKeyCode.VK_1);
        Thread.Sleep(40);
        Attack.sim.Keyboard.KeyUp(VirtualKeyCode.VK_1);
        Thread.Sleep(Attack.skillms);
      }
    }

    private void RRCombo()
    {
      while (!this.isepressed)
      {
        Attack.sim.Keyboard.KeyDown(VirtualKeyCode.VK_R);
        Thread.Sleep(40);
        Attack.sim.Keyboard.KeyUp(VirtualKeyCode.VK_R);
        Thread.Sleep(Attack.rrms);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label3 = new Label();
      this.button3 = new Button();
      this.label2 = new Label();
      this.label1 = new Label();
      this.numericUpDown4 = new NumericUpDown();
      this.numericUpDown3 = new NumericUpDown();
      this.checkBox2 = new CheckBox();
      this.checkBox1 = new CheckBox();
      this.groupBox1 = new GroupBox();
      this.Kalkan = new GroupBox();
      this.label10 = new Label();
      this.button2 = new Button();
      this.label9 = new Label();
      this.button1 = new Button();
      this.label8 = new Label();
      this.numericUpDown1 = new NumericUpDown();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.groupBox2 = new GroupBox();
      this.label12 = new Label();
      this.label11 = new Label();
      this.button5 = new Button();
      this.label13 = new Label();
      this.button4 = new Button();
      this.label14 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      ((ISupportInitialize) this.numericUpDown4).BeginInit();
      ((ISupportInitialize) this.numericUpDown3).BeginInit();
      this.groupBox1.SuspendLayout();
      this.Kalkan.SuspendLayout();
      ((ISupportInitialize) this.numericUpDown1).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.label3.AutoSize = true;
      this.label3.Location = new Point(193, 40);
      this.label3.Name = "label3";
      this.label3.Size = new Size(24, 15);
      this.label3.TabIndex = 16;
      this.label3.Text = "Off";
      this.button3.Location = new Point(59, 36);
      this.button3.Name = "button3";
      this.button3.Size = new Size(111, 23);
      this.button3.TabIndex = 15;
      this.button3.Text = "Attack Off/On";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(84, 213);
      this.label2.Name = "label2";
      this.label2.Size = new Size(40, 15);
      this.label2.TabIndex = 14;
      this.label2.Text = "RR Ms";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(84, 170);
      this.label1.Name = "label1";
      this.label1.Size = new Size(47, 15);
      this.label1.TabIndex = 13;
      this.label1.Text = "Skill Ms";
      this.numericUpDown4.Location = new Point(158, 211);
      this.numericUpDown4.Maximum = new Decimal(new int[4]
      {
        10000,
        0,
        0,
        0
      });
      this.numericUpDown4.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new Size(59, 23);
      this.numericUpDown4.TabIndex = 12;
      this.numericUpDown4.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown4.ValueChanged += new EventHandler(this.numericUpDown4_ValueChanged);
      this.numericUpDown3.Location = new Point(158, 168);
      this.numericUpDown3.Maximum = new Decimal(new int[4]
      {
        10000,
        0,
        0,
        0
      });
      this.numericUpDown3.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new Size(59, 23);
      this.numericUpDown3.TabIndex = 11;
      this.numericUpDown3.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown3.ValueChanged += new EventHandler(this.numericUpDown3_ValueChanged);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point((int) sbyte.MaxValue, 116);
      this.checkBox2.Margin = new Padding(3, 2, 3, 2);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(76, 19);
      this.checkBox2.TabIndex = 10;
      this.checkBox2.Text = "R Combo";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point((int) sbyte.MaxValue, 93);
      this.checkBox1.Margin = new Padding(3, 2, 3, 2);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(90, 19);
      this.checkBox1.TabIndex = 9;
      this.checkBox1.Text = "Skill Combo";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.groupBox1.BackColor = Color.LightGray;
      this.groupBox1.Controls.Add((Control) this.button3);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.checkBox1);
      this.groupBox1.Controls.Add((Control) this.checkBox2);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.numericUpDown3);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.numericUpDown4);
      this.groupBox1.Location = new Point(568, 31);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(262, 291);
      this.groupBox1.TabIndex = 17;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = nameof (Attack);
      this.Kalkan.BackColor = Color.LightGray;
      this.Kalkan.Controls.Add((Control) this.label10);
      this.Kalkan.Controls.Add((Control) this.button2);
      this.Kalkan.Controls.Add((Control) this.label9);
      this.Kalkan.Controls.Add((Control) this.button1);
      this.Kalkan.Controls.Add((Control) this.label8);
      this.Kalkan.Controls.Add((Control) this.numericUpDown1);
      this.Kalkan.Controls.Add((Control) this.label7);
      this.Kalkan.Controls.Add((Control) this.label6);
      this.Kalkan.Controls.Add((Control) this.label5);
      this.Kalkan.Controls.Add((Control) this.label4);
      this.Kalkan.Location = new Point(287, 31);
      this.Kalkan.Name = "Kalkan";
      this.Kalkan.Size = new Size(266, 291);
      this.Kalkan.TabIndex = 18;
      this.Kalkan.TabStop = false;
      this.Kalkan.Text = "Kalkan";
      this.label10.AutoSize = true;
      this.label10.Location = new Point(20, 228);
      this.label10.Name = "label10";
      this.label10.Size = new Size(59, 15);
      this.label10.TabIndex = 9;
      this.label10.Text = "Koordinat";
      this.button2.Location = new Point(20, 170);
      this.button2.Name = "button2";
      this.button2.Size = new Size(93, 23);
      this.button2.TabIndex = 8;
      this.button2.Text = "Koordinat Al";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(192, 48);
      this.label9.Name = "label9";
      this.label9.Size = new Size(24, 15);
      this.label9.TabIndex = 7;
      this.label9.Text = "Off";
      this.button1.Location = new Point(65, 40);
      this.button1.Name = "button1";
      this.button1.Size = new Size(101, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Kalkan Off/On";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label8.AutoSize = true;
      this.label8.Location = new Point(143, 91);
      this.label8.Name = "label8";
      this.label8.Size = new Size(23, 15);
      this.label8.TabIndex = 5;
      this.label8.Text = "Ms";
      this.numericUpDown1.Location = new Point(189, 89);
      this.numericUpDown1.Maximum = new Decimal(new int[4]
      {
        5000,
        0,
        0,
        0
      });
      this.numericUpDown1.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new Size(69, 23);
      this.numericUpDown1.TabIndex = 4;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(172, 237);
      this.label7.Name = "label7";
      this.label7.Size = new Size(13, 15);
      this.label7.TabIndex = 3;
      this.label7.Text = "0";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(143, 237);
      this.label6.Name = "label6";
      this.label6.Size = new Size(20, 15);
      this.label6.TabIndex = 2;
      this.label6.Text = "Y :";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(172, 207);
      this.label5.Name = "label5";
      this.label5.Size = new Size(13, 15);
      this.label5.TabIndex = 1;
      this.label5.Text = "0";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(143, 207);
      this.label4.Name = "label4";
      this.label4.Size = new Size(23, 15);
      this.label4.TabIndex = 0;
      this.label4.Text = "X : ";
      this.groupBox2.BackColor = Color.LightGray;
      this.groupBox2.Controls.Add((Control) this.label12);
      this.groupBox2.Controls.Add((Control) this.label11);
      this.groupBox2.Controls.Add((Control) this.button5);
      this.groupBox2.Controls.Add((Control) this.label13);
      this.groupBox2.Controls.Add((Control) this.button4);
      this.groupBox2.Controls.Add((Control) this.label14);
      this.groupBox2.Controls.Add((Control) this.label16);
      this.groupBox2.Controls.Add((Control) this.label15);
      this.groupBox2.Location = new Point(12, 31);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(263, 291);
      this.groupBox2.TabIndex = 19;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Echo";
      this.label12.AutoSize = true;
      this.label12.Location = new Point(29, 228);
      this.label12.Name = "label12";
      this.label12.Size = new Size(62, 15);
      this.label12.TabIndex = 15;
      this.label12.Text = "Koordinat ";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(168, 44);
      this.label11.Name = "label11";
      this.label11.Size = new Size(24, 15);
      this.label11.TabIndex = 1;
      this.label11.Text = "Off";
      this.button5.Location = new Point(29, 170);
      this.button5.Name = "button5";
      this.button5.Size = new Size(93, 23);
      this.button5.TabIndex = 14;
      this.button5.Text = "Koordinat Al";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.label13.AutoSize = true;
      this.label13.Location = new Point(181, 237);
      this.label13.Name = "label13";
      this.label13.Size = new Size(13, 15);
      this.label13.TabIndex = 13;
      this.label13.Text = "0";
      this.button4.Location = new Point(75, 40);
      this.button4.Name = "button4";
      this.button4.Size = new Size(87, 23);
      this.button4.TabIndex = 0;
      this.button4.Text = "Echo On/Off";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.label14.AutoSize = true;
      this.label14.Location = new Point(152, 237);
      this.label14.Name = "label14";
      this.label14.Size = new Size(20, 15);
      this.label14.TabIndex = 12;
      this.label14.Text = "Y :";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(152, 207);
      this.label16.Name = "label16";
      this.label16.Size = new Size(23, 15);
      this.label16.TabIndex = 10;
      this.label16.Text = "X : ";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(181, 207);
      this.label15.Name = "label15";
      this.label15.Size = new Size(13, 15);
      this.label15.TabIndex = 11;
      this.label15.Text = "0";
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(842, 367);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.Kalkan);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (Attack);
      this.Text = "Warrior";
      this.FormClosed += new FormClosedEventHandler(this.Attack_FormClosed);
      ((ISupportInitialize) this.numericUpDown4).EndInit();
      ((ISupportInitialize) this.numericUpDown3).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.Kalkan.ResumeLayout(false);
      this.Kalkan.PerformLayout();
      ((ISupportInitialize) this.numericUpDown1).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
