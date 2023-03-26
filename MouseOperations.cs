// Decompiled with JetBrains decompiler
// Type: XRRMacro.MouseOperations
// Assembly: XRRMacro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B754BDB-ED1F-4356-8C42-E5D2A7DF9C93
// Assembly location: C:\Users\Admin\Desktop\net7.0-windows\net7.0-windows\XRRMacro.dll

using System;
using System.Runtime.InteropServices;

namespace XRRMacro
{
  public class MouseOperations
  {
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetCursorPos(int x, int y);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetCursorPos(out MouseOperations.MousePoint lpMousePoint);

    [DllImport("user32.dll")]
    private static extern void mouse_event(
      int dwFlags,
      int dx,
      int dy,
      int dwData,
      int dwExtraInfo);

    public static void SetCursorPosition(int x, int y) => MouseOperations.SetCursorPos(x, y);

    public static void SetCursorPosition(MouseOperations.MousePoint point) => MouseOperations.SetCursorPos(point.X, point.Y);

    public static MouseOperations.MousePoint GetCursorPosition()
    {
      MouseOperations.MousePoint lpMousePoint;
      if (!MouseOperations.GetCursorPos(out lpMousePoint))
        lpMousePoint = new MouseOperations.MousePoint(0, 0);
      return lpMousePoint;
    }

    public static void MouseEvent(MouseOperations.MouseEventFlags value)
    {
      MouseOperations.MousePoint cursorPosition = MouseOperations.GetCursorPosition();
      MouseOperations.mouse_event((int) value, cursorPosition.X, cursorPosition.Y, 0, 0);
    }

    [Flags]
    public enum MouseEventFlags
    {
      LeftDown = 2,
      LeftUp = 4,
      MiddleDown = 32, // 0x00000020
      MiddleUp = 64, // 0x00000040
      Move = 1,
      Absolute = 32768, // 0x00008000
      RightDown = 8,
      RightUp = 16, // 0x00000010
    }

    public struct MousePoint
    {
      public int X;
      public int Y;

      public MousePoint(int x, int y)
      {
        this.X = x;
        this.Y = y;
      }
    }
  }
}
