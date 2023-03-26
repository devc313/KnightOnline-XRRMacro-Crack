// cracked by youtube.com/@ecvd

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


#nullable enable
namespace XRRMacro
{
  public class Form1 : Form
  {
    private 
    #nullable disable
    IContainer components = (IContainer) null;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private Button button1;
    private Button button2;
    private Label label4;
    private Button button4;
    private Button button3;

    public Form1() => this.InitializeComponent();

    private void button4_Click(
    #nullable enable
    object sender, EventArgs e)
    {
      new Attack().Show();
      this.Hide();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      new Asas().Show();
      this.Hide();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button4 = new Button();
      this.button3 = new Button();
      this.SuspendLayout();
      this.button4.Location = new Point(180, 124);
      this.button4.Name = "button4";
      this.button4.Size = new Size(75, 23);
      this.button4.TabIndex = 8;
      this.button4.Text = "warrior";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button3.Location = new Point(347, 124);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 9;
      this.button3.Text = "asas";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.AutoScaleDimensions = new SizeF(7f, 15f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(599, 275);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button4);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (Form1);
      this.Text = "XRRMacro crack";
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
    }
  }
}
