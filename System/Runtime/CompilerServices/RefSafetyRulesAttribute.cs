// Decompiled with JetBrains decompiler
// Type: System.Runtime.CompilerServices.RefSafetyRulesAttribute
// Assembly: XRRMacro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B754BDB-ED1F-4356-8C42-E5D2A7DF9C93
// Assembly location: C:\Users\Admin\Desktop\net7.0-windows\net7.0-windows\XRRMacro.dll


using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
  [CompilerGenerated]
  [AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
  internal sealed class RefSafetyRulesAttribute : Attribute
  {
    public readonly int Version;

    public RefSafetyRulesAttribute([In] int obj0) => this.Version = obj0;
  }
}
