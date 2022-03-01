
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Markup;

namespace XamlGeneratedNamespace
{
  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class GeneratedInternalTypeHelper : InternalTypeHelper
  {
    protected override object CreateInstance(Type _param1, CultureInfo _param2) => Activator.CreateInstance(_param1, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, (object[]) null, _param2);

    protected override object GetPropertyValue(
      PropertyInfo _param1,
      object _param2,
      CultureInfo _param3)
    {
      return _param1.GetValue(_param2, BindingFlags.Default, (Binder) null, (object[]) null, _param3);
    }

    protected override void SetPropertyValue(
      PropertyInfo _param1,
      object _param2,
      object _param3,
      CultureInfo _param4)
    {
      _param1.SetValue(_param2, _param3, BindingFlags.Default, (Binder) null, (object[]) null, _param4);
    }

    protected override Delegate CreateDelegate(
      Type _param1,
      object _param2,
      string _param3)
    {
      return (Delegate) _param2.GetType().InvokeMember(\u0008\u2004\u2001.\u0002(-1745287505), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, (Binder) null, _param2, new object[2]
      {
        (object) _param1,
        (object) _param3
      }, (CultureInfo) null);
    }

    protected override void AddEventHandler(EventInfo _param1, object _param2, Delegate _param3) => _param1.AddEventHandler(_param2, _param3);
  }
}
