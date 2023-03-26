// cracked by youtube.com/@ecvd

using System;
using System.Windows.Forms;

namespace XRRMacro
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      // ISSUE: reference to a compiler-generated method
      ApplicationConfiguration.Initialize();
      Application.Run((Form) new Form1());
    }
  }
}
