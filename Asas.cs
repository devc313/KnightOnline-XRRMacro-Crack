// Decompiled with JetBrains decompiler
// Type: XRRMacro.Asas
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
  public class Asas : Form
  {
    private globalKeyboardHook klavye = new globalKeyboardHook();
    private bool skillon;
    private bool isepressed;
    private bool makroacik;
    private bool rron;
    private bool minoron;
    private bool cureal;
    private bool bicakat = false;
    private static int rrms = 100;
    private static int minorms = 5;
    private static int vsms = 375;
    private static int vsmode = 1;
    private static InputSimulator sim = new InputSimulator();
    private static Coordinate coordinate;
    private static Coordinate coordinate2;
    private static int asasindex = 0;
    private static VirtualKeyCode[] asaskombo1 = new VirtualKeyCode[139]
    {
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6
    };
    private static VirtualKeyCode[] asaskombo2 = new VirtualKeyCode[118]
    {
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6
    };
    private static VirtualKeyCode[] asaskombo4 = new VirtualKeyCode[128]
    {
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F1,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_7,
      VirtualKeyCode.VK_6,
      VirtualKeyCode.F2,
      VirtualKeyCode.VK_3,
      VirtualKeyCode.VK_4,
      VirtualKeyCode.VK_5,
      VirtualKeyCode.VK_6
    };
    private 
    #nullable disable
    IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private RadioButton radioButton5;
    private RadioButton radioButton4;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private GroupBox groupBox2;
    private Label label3;
    private NumericUpDown numericUpDown3;
    private Label label2;
    private NumericUpDown numericUpDown2;
    private CheckBox checkBox3;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private Label label1;
    private NumericUpDown numericUpDown1;
    private Button button1;
    private Label label4;
    private RadioButton radioButton6;
    private CheckBox checkBox4;
    private GroupBox groupBox3;
    private CheckBox checkBox5;

    public Asas()
    {
      this.InitializeComponent();
      this.TuslariDinle();
    }

    private void checkBox3_CheckedChanged(
    #nullable enable
    object sender, EventArgs e) => this.skillon = this.checkBox3.Checked;

    private void checkBox1_CheckedChanged(object sender, EventArgs e) => this.rron = this.checkBox1.Checked;

    private void checkBox2_CheckedChanged(object sender, EventArgs e) => this.minoron = this.checkBox2.Checked;

    private void button1_Click(object sender, EventArgs e)
    {
      this.makroacik = !this.makroacik;
      if (this.makroacik)
        this.label4.Text = "Açık";
      else
        this.label4.Text = "Kapalı";
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e) => Asas.vsms = Convert.ToInt32(this.numericUpDown1.Value);

    private void numericUpDown2_ValueChanged(object sender, EventArgs e) => Asas.rrms = Convert.ToInt32(this.numericUpDown2.Value);

    private void numericUpDown3_ValueChanged(object sender, EventArgs e) => Asas.minorms = Convert.ToInt32(this.numericUpDown3.Value);

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radioButton1.Checked)
        return;
      Asas.vsmode = 1;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radioButton2.Checked)
        return;
      Asas.vsmode = 2;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radioButton3.Checked)
        return;
      Asas.vsmode = 3;
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radioButton4.Checked)
        return;
      Asas.vsmode = 4;
    }

    private void radioButton5_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radioButton5.Checked)
        return;
      Asas.vsmode = 5;
    }

    private void radioButton6_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.radioButton6.Checked)
        return;
      Asas.vsmode = 6;
    }

    private void RRCombo()
    {
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_R);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_R);
        Thread.Sleep(Asas.rrms);
      }
    }

    private void MinorCombo()
    {
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_8);
        Thread.Sleep(Asas.minorms);
        Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_8);
        Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_9);
        Thread.Sleep(Asas.minorms);
        Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_9);
        Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_0);
        Thread.Sleep(Asas.minorms);
        Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_0);
      }
    }

    private void TuslariDinle()
    {
      this.klavye.HookedKeys.Add(Keys.E);
      this.klavye.HookedKeys.Add(Keys.Capital);
      this.klavye.HookedKeys.Add(Keys.Space);
      this.klavye.HookedKeys.Add(Keys.F);
      this.klavye.HookedKeys.Add(Keys.X);
      this.klavye.KeyDown += new KeyEventHandler(this.TusBasmaAni);
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e) => this.cureal = this.checkBox4.Checked;

    private void checkBox5_CheckedChanged(object sender, EventArgs e) => this.bicakat = this.checkBox5.Checked;

    private void Asas_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

    private void TusBasmaAni(object? sender, KeyEventArgs e)
    {
      if (this.makroacik && e.KeyCode == Keys.Capital)
      {
        this.isepressed = false;
        if (this.skillon)
        {
          switch (Asas.vsmode)
          {
            case 1:
              Task.Run(new Action(this.VsKombo1));
              break;
            case 2:
              Task.Run(new Action(this.VsKombo2));
              break;
            case 3:
              Task.Run(new Action(this.VsKombo3));
              break;
            case 4:
              Task.Run(new Action(this.VsKombo4));
              break;
            case 5:
              Task.Run(new Action(this.VsKombo5));
              break;
            case 6:
              Task.Run(new Action(this.VsKombo6));
              break;
          }
        }
        else
        {
          if (this.rron)
            Task.Run(new Action(this.RRCombo));
          if (this.minoron)
            Task.Run(new Action(this.MinorCombo));
        }
      }
      if (e.KeyCode == Keys.E)
      {
        this.isepressed = true;
        Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      }
      if (e.KeyCode == Keys.Space && this.cureal)
      {
        Asas.sim.Keyboard.KeyDown(VirtualKeyCode.F3);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(VirtualKeyCode.F3);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_1);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_1);
        Thread.Sleep(40);
      }
      if (e.KeyCode != Keys.F || !this.bicakat)
        return;
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.F3);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.F3);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_3);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_3);
      Thread.Sleep(40);
    }

    public void VsKombo6()
    {
      Asas.asasindex = 0;
      if (this.minoron)
        Task.Run(new Action(this.MinorCombo));
      if (this.rron)
        Task.Run(new Action(this.RRCombo));
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(Asas.asaskombo1[Asas.asasindex]);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(Asas.asaskombo1[Asas.asasindex]);
        Thread.Sleep(Asas.vsms);
        if (Asas.asaskombo1[Asas.asasindex + 1] == VirtualKeyCode.F1 || Asas.asaskombo1[Asas.asasindex + 1] == VirtualKeyCode.F2)
        {
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyDown(Asas.asaskombo1[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyUp(Asas.asaskombo1[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          ++Asas.asasindex;
        }
        else
          Thread.Sleep(Asas.vsms / 4 * 3);
        ++Asas.asasindex;
      }
    }

    public void VsKombo1()
    {
      Asas.asasindex = 0;
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.F1);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.F1);
      Thread.Sleep(510);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_2);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_2);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(20);
      if (this.minoron)
        Task.Run(new Action(this.MinorCombo));
      if (this.rron)
        Task.Run(new Action(this.RRCombo));
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(Asas.asaskombo1[Asas.asasindex]);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(Asas.asaskombo1[Asas.asasindex]);
        Thread.Sleep(Asas.vsms);
        if (Asas.asaskombo1[Asas.asasindex + 1] == VirtualKeyCode.F1 || Asas.asaskombo1[Asas.asasindex + 1] == VirtualKeyCode.F2)
        {
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyDown(Asas.asaskombo1[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyUp(Asas.asaskombo1[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          ++Asas.asasindex;
        }
        else
          Thread.Sleep(Asas.vsms / 4 * 3);
        ++Asas.asasindex;
      }
    }

    public void VsKombo2()
    {
      Asas.asasindex = 0;
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_7);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_7);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.F1);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.F1);
      Thread.Sleep(510);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_2);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_2);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(20);
      if (this.minoron)
        Task.Run(new Action(this.MinorCombo));
      if (this.rron)
        Task.Run(new Action(this.RRCombo));
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(Asas.asaskombo2[Asas.asasindex]);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(Asas.asaskombo2[Asas.asasindex]);
        Thread.Sleep(Asas.vsms);
        if (Asas.asaskombo2[Asas.asasindex + 1] == VirtualKeyCode.F1 || Asas.asaskombo2[Asas.asasindex + 1] == VirtualKeyCode.F2)
        {
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyDown(Asas.asaskombo2[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyUp(Asas.asaskombo2[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          ++Asas.asasindex;
        }
        else
          Thread.Sleep(Asas.vsms / 4 * 3);
        ++Asas.asasindex;
      }
    }

    public void VsKombo3()
    {
      Asas.asasindex = 0;
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_6);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_6);
      Thread.Sleep(1000);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_7);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_7);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_0);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_0);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.F1);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.F1);
      Thread.Sleep(590);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(20);
      if (this.minoron)
        Task.Run(new Action(this.MinorCombo));
      if (this.rron)
        Task.Run(new Action(this.RRCombo));
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(Asas.asaskombo2[Asas.asasindex]);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(Asas.asaskombo2[Asas.asasindex]);
        Thread.Sleep(Asas.vsms);
        if (Asas.asaskombo2[Asas.asasindex + 1] == VirtualKeyCode.F1 || Asas.asaskombo2[Asas.asasindex + 1] == VirtualKeyCode.F2)
        {
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyDown(Asas.asaskombo2[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyUp(Asas.asaskombo2[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          ++Asas.asasindex;
        }
        else
          Thread.Sleep(Asas.vsms / 4 * 3);
        ++Asas.asasindex;
      }
    }

    public void VsKombo4()
    {
      Asas.asasindex = 0;
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_8);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_8);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_6);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_6);
      Thread.Sleep(1000);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_7);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_7);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_0);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_0);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.F1);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.F1);
      Thread.Sleep(510);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_2);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_2);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(20);
      if (this.minoron)
        Task.Run(new Action(this.MinorCombo));
      if (this.rron)
        Task.Run(new Action(this.RRCombo));
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(Asas.asaskombo4[Asas.asasindex]);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(Asas.asaskombo4[Asas.asasindex]);
        Thread.Sleep(Asas.vsms);
        if (Asas.asaskombo4[Asas.asasindex + 1] == VirtualKeyCode.F1 || Asas.asaskombo4[Asas.asasindex + 1] == VirtualKeyCode.F2)
        {
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyDown(Asas.asaskombo4[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyUp(Asas.asaskombo4[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          ++Asas.asasindex;
        }
        else
          Thread.Sleep(Asas.vsms / 4 * 3);
        ++Asas.asasindex;
      }
    }

    public void VsKombo5()
    {
      Asas.asasindex = 0;
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_6);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_6);
      Thread.Sleep(1000);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_0);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.VK_0);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.F1);
      Thread.Sleep(40);
      Asas.sim.Keyboard.KeyUp(VirtualKeyCode.F1);
      Thread.Sleep(520);
      Asas.sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
      Thread.Sleep(20);
      if (this.minoron)
        Task.Run(new Action(this.MinorCombo));
      if (this.rron)
        Task.Run(new Action(this.RRCombo));
      while (!this.isepressed)
      {
        Asas.sim.Keyboard.KeyDown(Asas.asaskombo1[Asas.asasindex]);
        Thread.Sleep(40);
        Asas.sim.Keyboard.KeyUp(Asas.asaskombo1[Asas.asasindex]);
        Thread.Sleep(Asas.vsms);
        if (Asas.asaskombo1[Asas.asasindex + 1] == VirtualKeyCode.F1 || Asas.asaskombo1[Asas.asasindex + 1] == VirtualKeyCode.F2)
        {
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyDown(Asas.asaskombo1[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          Asas.sim.Keyboard.KeyUp(Asas.asaskombo1[Asas.asasindex + 1]);
          Thread.Sleep(Asas.vsms / 4);
          ++Asas.asasindex;
        }
        else
          Thread.Sleep(Asas.vsms / 4 * 3);
        ++Asas.asasindex;
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
      this.groupBox1 = new GroupBox();
      this.radioButton6 = new RadioButton();
      this.radioButton5 = new RadioButton();
      this.radioButton4 = new RadioButton();
      this.radioButton3 = new RadioButton();
      this.radioButton2 = new RadioButton();
      this.radioButton1 = new RadioButton();
      this.groupBox2 = new GroupBox();
      this.label3 = new Label();
      this.numericUpDown3 = new NumericUpDown();
      this.label2 = new Label();
      this.numericUpDown2 = new NumericUpDown();
      this.checkBox3 = new CheckBox();
      this.checkBox2 = new CheckBox();
      this.checkBox1 = new CheckBox();
      this.label1 = new Label();
      this.numericUpDown1 = new NumericUpDown();
      this.button1 = new Button();
      this.label4 = new Label();
      this.checkBox4 = new CheckBox();
      this.groupBox3 = new GroupBox();
      this.checkBox5 = new CheckBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.numericUpDown3).BeginInit();
      ((ISupportInitialize) this.numericUpDown2).BeginInit();
      ((ISupportInitialize) this.numericUpDown1).BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.radioButton6);
      this.groupBox1.Controls.Add((Control) this.radioButton5);
      this.groupBox1.Controls.Add((Control) this.radioButton4);
      this.groupBox1.Controls.Add((Control) this.radioButton3);
      this.groupBox1.Controls.Add((Control) this.radioButton2);
      this.groupBox1.Controls.Add((Control) this.radioButton1);
      this.groupBox1.Location = new Point(588, 27);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(219, 262);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Vs Modu Seç";
      this.radioButton6.AutoSize = true;
      this.radioButton6.Location = new Point(16, 221);
      this.radioButton6.Name = "radioButton6";
      this.radioButton6.Size = new Size(84, 19);
      this.radioButton6.TabIndex = 5;
      this.radioButton6.TabStop = true;
      this.radioButton6.Text = "Düz 17 Skill";
      this.radioButton6.UseVisualStyleBackColor = true;
      this.radioButton6.CheckedChanged += new EventHandler(this.radioButton6_CheckedChanged);
      this.radioButton5.AutoSize = true;
      this.radioButton5.Location = new Point(16, 181);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new Size(147, 19);
      this.radioButton5.TabIndex = 4;
      this.radioButton5.TabStop = true;
      this.radioButton5.Text = "Yüzde 5 Yüzde 10 Spike";
      this.radioButton5.UseVisualStyleBackColor = true;
      this.radioButton5.CheckedChanged += new EventHandler(this.radioButton5_CheckedChanged);
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new Point(16, 143);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new Size(182, 19);
      this.radioButton4.TabIndex = 3;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "Pierce Yüzde 5 Spike Yüzde 10";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new EventHandler(this.radioButton4_CheckedChanged);
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new Point(16, 107);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new Size(144, 19);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "Yüzde 5 Spike Yüzde10";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new EventHandler(this.radioButton3_CheckedChanged);
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new Point(16, 69);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(103, 19);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Spike Yüzde 10";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new EventHandler(this.radioButton2_CheckedChanged);
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new Point(16, 32);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(103, 19);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Yüzde 10 Spike";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.numericUpDown3);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.numericUpDown2);
      this.groupBox2.Controls.Add((Control) this.checkBox3);
      this.groupBox2.Controls.Add((Control) this.checkBox2);
      this.groupBox2.Controls.Add((Control) this.checkBox1);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Controls.Add((Control) this.numericUpDown1);
      this.groupBox2.Location = new Point(268, 27);
      this.groupBox2.Margin = new Padding(3, 2, 3, 2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new Padding(3, 2, 3, 2);
      this.groupBox2.Size = new Size(271, 162);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Vs ayarları";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(89, 105);
      this.label3.Name = "label3";
      this.label3.Size = new Size(58, 15);
      this.label3.TabIndex = 8;
      this.label3.Text = "Minör Ms";
      this.numericUpDown3.Location = new Point(160, 105);
      this.numericUpDown3.Margin = new Padding(3, 2, 3, 2);
      this.numericUpDown3.Maximum = new Decimal(new int[4]
      {
        5000,
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
      this.numericUpDown3.Size = new Size(88, 23);
      this.numericUpDown3.TabIndex = 7;
      this.numericUpDown3.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown3.ValueChanged += new EventHandler(this.numericUpDown3_ValueChanged);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(89, 69);
      this.label2.Name = "label2";
      this.label2.Size = new Size(40, 15);
      this.label2.TabIndex = 6;
      this.label2.Text = "RR Ms";
      this.numericUpDown2.Location = new Point(160, 69);
      this.numericUpDown2.Margin = new Padding(3, 2, 3, 2);
      this.numericUpDown2.Maximum = new Decimal(new int[4]
      {
        5000,
        0,
        0,
        0
      });
      this.numericUpDown2.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new Size(88, 23);
      this.numericUpDown2.TabIndex = 5;
      this.numericUpDown2.Value = new Decimal(new int[4]
      {
        100,
        0,
        0,
        0
      });
      this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new Point(5, 32);
      this.checkBox3.Margin = new Padding(3, 2, 3, 2);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(72, 19);
      this.checkBox3.TabIndex = 4;
      this.checkBox3.Text = "Vs Mode";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new EventHandler(this.checkBox3_CheckedChanged);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(5, 106);
      this.checkBox2.Margin = new Padding(3, 2, 3, 2);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(58, 19);
      this.checkBox2.TabIndex = 3;
      this.checkBox2.Text = "Minör";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(5, 68);
      this.checkBox1.Margin = new Padding(3, 2, 3, 2);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(40, 19);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "RR";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(90, 32);
      this.label1.Name = "label1";
      this.label1.Size = new Size(39, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "VS Ms";
      this.numericUpDown1.Location = new Point(160, 32);
      this.numericUpDown1.Margin = new Padding(3, 2, 3, 2);
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
      this.numericUpDown1.Size = new Size(88, 23);
      this.numericUpDown1.TabIndex = 0;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        375,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
      this.button1.Location = new Point(63, 52);
      this.button1.Margin = new Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new Size(82, 22);
      this.button1.TabIndex = 2;
      this.button1.Text = "MakroAç";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(106, 105);
      this.label4.Name = "label4";
      this.label4.Size = new Size(39, 15);
      this.label4.TabIndex = 3;
      this.label4.Text = "Kapalı";
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new Point(22, 22);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new Size(102, 19);
      this.checkBox4.TabIndex = 9;
      this.checkBox4.Text = "Cure al(Space)";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.CheckedChanged += new EventHandler(this.checkBox4_CheckedChanged);
      this.groupBox3.Controls.Add((Control) this.checkBox5);
      this.groupBox3.Controls.Add((Control) this.checkBox4);
      this.groupBox3.Location = new Point(273, 209);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(266, 100);
      this.groupBox3.TabIndex = 10;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Pk Ayarları";
      this.checkBox5.AutoSize = true;
      this.checkBox5.Location = new Point(22, 47);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new Size(84, 19);
      this.checkBox5.TabIndex = 10;
      this.checkBox5.Text = "Bıçak at(F) ";
      this.checkBox5.UseVisualStyleBackColor = true;
      this.checkBox5.CheckedChanged += new EventHandler(this.checkBox5_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(831, 334);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (Asas);
      this.Text = nameof (Asas);
      this.FormClosing += new FormClosingEventHandler(this.Asas_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((ISupportInitialize) this.numericUpDown3).EndInit();
      ((ISupportInitialize) this.numericUpDown2).EndInit();
      ((ISupportInitialize) this.numericUpDown1).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
