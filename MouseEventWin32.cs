// Decompiled with JetBrains decompiler
// Type: XRRMacro.MouseEventWin32
// Assembly: XRRMacro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B754BDB-ED1F-4356-8C42-E5D2A7DF9C93
// Assembly location: C:\Users\Admin\Desktop\net7.0-windows\net7.0-windows\XRRMacro.dll

using System.Runtime.InteropServices;
using System.Threading;

namespace XRRMacro
{
  public class MouseEventWin32
  {
    public const int MOUSEEVENTF_LEFTDOWN = 2;
    public const int MOUSEEVENTF_LEFTUP = 4;
    public const int MOUSEEVENTF_RIGHTDOWN = 8;
    public const int MOUSEEVENTF_RIGHTUP = 16;

    [DllImport("user32.dll")]
    private static extern bool SetCursorPos(int x, int y);

    [DllImport("user32.dll")]
    public static extern void mouse_event(
      int dwFlags,
      int dx,
      int dy,
      int cButtons,
      int dwExtraInfo);

    public static void SolMouseClick(int xpos, int ypos)
    {
      MouseEventWin32.SetCursorPos(xpos, ypos);
      MouseEventWin32.mouse_event(2, xpos, ypos, 0, 0);
      Thread.Sleep(40);
      MouseEventWin32.mouse_event(4, xpos, ypos, 0, 0);
    }

    public static void SolMouseBasiliClick(int xpos, int ypos, int xpos2, int ypos2, int ms)
    {
      MouseEventWin32.SetCursorPos(xpos, ypos);
      MouseEventWin32.mouse_event(4, xpos, ypos, 0, 0);
      Thread.Sleep(ms);
      MouseEventWin32.mouse_event(2, xpos, ypos, 0, 0);
      Thread.Sleep(ms);
      MouseEventWin32.SetCursorPos(xpos2, ypos2);
      Thread.Sleep(ms);
      MouseEventWin32.mouse_event(4, xpos2, ypos2, 0, 0);
    }

    public static void SagMouseClick(int xpos, int ypos, int ms)
    {
      MouseEventWin32.mouse_event(4, xpos, ypos, 0, 0);
      Thread.Sleep(30);
      MouseEventWin32.SetCursorPos(xpos, ypos);
      Thread.Sleep(ms);
      MouseEventWin32.mouse_event(8, xpos, ypos, 0, 0);
      Thread.Sleep(ms);
      MouseEventWin32.mouse_event(16, xpos, ypos, 0, 0);
    }

    public static void SagMouseDrag(int xpos, int ypos, int postox, int postoy)
    {
      MouseEventWin32.SetCursorPos(xpos, ypos);
      MouseEventWin32.mouse_event(8, xpos, ypos, 0, 0);
    }
  }
}
