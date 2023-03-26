// Decompiled with JetBrains decompiler
// Type: HootKeys.globalKeyboardHook
// Assembly: XRRMacro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B754BDB-ED1F-4356-8C42-E5D2A7DF9C93
// Assembly location: C:\Users\Admin\Desktop\net7.0-windows\net7.0-windows\XRRMacro.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;


#nullable enable
namespace HootKeys
{
  internal class globalKeyboardHook
  {
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 256;
    private const int WM_KEYUP = 257;
    private const int WM_SYSKEYDOWN = 260;
    private const int WM_SYSKEYUP = 261;
    public List<Keys> HookedKeys = new List<Keys>();
    private IntPtr hhook = IntPtr.Zero;
    private static globalKeyboardHook.keyboardHookProc callbackDelegate;

  
    public event KeyEventHandler KeyDown;

 
    public event KeyEventHandler KeyUp;

    public globalKeyboardHook() => this.hook();

    ~globalKeyboardHook() => this.unhook();

    public void hook()
    {
      IntPtr hInstance = globalKeyboardHook.LoadLibrary("User32");
      globalKeyboardHook.callbackDelegate = new globalKeyboardHook.keyboardHookProc(this.hookProc);
      this.hhook = globalKeyboardHook.SetWindowsHookEx(13, globalKeyboardHook.callbackDelegate, hInstance, 0U);
      if (this.hhook == IntPtr.Zero)
        throw new Win32Exception();
    }

    public void unhook()
    {
      if (globalKeyboardHook.callbackDelegate == null)
        return;
      if (!globalKeyboardHook.UnhookWindowsHookEx(this.hhook))
        throw new Win32Exception();
      globalKeyboardHook.callbackDelegate = (globalKeyboardHook.keyboardHookProc) null;
    }

    public int hookProc(int code, int wParam, ref globalKeyboardHook.keyboardHookStruct lParam)
    {
      if (code >= 0)
      {
        Keys vkCode = (Keys) lParam.vkCode;
        if (this.HookedKeys.Contains(vkCode))
        {
          KeyEventArgs e = new KeyEventArgs(vkCode);
          if ((wParam == 256 || wParam == 260) && this.KeyDown != null)
            this.KeyDown((object) this, e);
          else if ((wParam == 257 || wParam == 261) && this.KeyUp != null)
            this.KeyUp((object) this, e);
          if (e.Handled)
            return 1;
        }
      }
      return globalKeyboardHook.CallNextHookEx(this.hhook, code, wParam, ref lParam);
    }

    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(
      int idHook,
      globalKeyboardHook.keyboardHookProc callback,
      IntPtr hInstance,
      uint threadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

    [DllImport("user32.dll")]
    private static extern int CallNextHookEx(
      IntPtr idHook,
      int nCode,
      int wParam,
      ref globalKeyboardHook.keyboardHookStruct lParam);

    [DllImport("kernel32.dll")]
    private static extern IntPtr LoadLibrary(string lpFileName);

    public delegate int keyboardHookProc(
      int code,
      int wParam,
      ref globalKeyboardHook.keyboardHookStruct lParam);

    public struct keyboardHookStruct
    {
      public int vkCode;
      public int scanCode;
      public int flags;
      public int time;
      public int dwExtraInfo;
    }
  }
}
