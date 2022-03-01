// Decompiled with JetBrains decompiler
// Type: -.ii1i1i1IIlll
// Assembly: SUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C75052F-567C-4717-00F4-FF7442A55C0D
// Assembly location: C:\Users\karol\OneDrive\Desktop\Pastenapse\zK8AAg5yJoW_dump.exe

using CefSharp;
using CefSharp.Wpf;
using CefSharp.Wpf.Internals;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace \u002D
{
  public sealed class ii1i1i1IIlll : ChromiumWebBrowser
  {
    public bool \u0002;

    public ii1i1i1IIlll()
    {
      this.Address = \u0008\u2004\u2001.\u0002(-1745267316) + Environment.CurrentDirectory.Replace('\\', '/') + \u0008\u2004\u2001.\u0002(-1745267269);
      this.LoadingStateChanged += new EventHandler<LoadingStateChangedEventArgs>(this.\u0002);
    }

    public event \u002D.ii1i1i1IIlll.\u0003 l1lilliIililI;

    public void \u0002(\u002D.ii1i1i1IIlll.\u0003 _param1);

    public void \u0003(\u002D.ii1i1i1IIlll.\u0003 _param1);

    public event \u002D.ii1i1i1IIlll.\u0005 ii1i1i1IIlll;

    public void \u0002(\u002D.ii1i1i1IIlll.\u0005 _param1);

    public void \u0003(\u002D.ii1i1i1IIlll.\u0005 _param1);

    public event \u002D.ii1i1i1IIlll.\u0005 I1iIil1Il1II;

    public void \u0005(\u002D.ii1i1i1IIlll.\u0005 _param1);

    public void \u0008(\u002D.ii1i1i1IIlll.\u0005 _param1);

    public void \u0005(\u002D.ii1i1i1IIlll.\u0003 _param1);

    public event \u002D.ii1i1i1IIlll.\u0003 l11iIIlIi1iI1;

    public void \u0008(\u002D.ii1i1i1IIlll.\u0003 _param1);

    protected virtual void OnMouseLeave(MouseEventArgs _param1)
    {
      _param1.Handled = true;
      IBrowser browser = this.GetBrowser();
      CefEventFlags modifiers = WpfExtensions.GetModifiers(_param1);
      Point position = _param1.GetPosition((IInputElement) this);
      if (_param1.LeftButton == MouseButtonState.Pressed)
        WebBrowserExtensions.SendMouseClickEvent(browser.GetHost(), (int) position.X, (int) position.Y, (MouseButtonType) 0, true, 1, modifiers);
      WebBrowserExtensions.SendMouseMoveEvent(browser.GetHost(), (int) position.X, (int) position.Y, true, modifiers);
      base.OnMouseLeave(_param1);
    }

    public void \u0002(string _param1)
    {
      if (!this.\u0002)
        return;
      WebBrowserExtensions.ExecuteScriptAsync((IWebBrowser) this, \u0008\u2004\u2001.\u0002(-1745267294), new object[1]
      {
        (object) _param1
      });
    }

    public void \u0003(string _param1)
    {
      if (!this.\u0002)
        return;
      WebBrowserExtensions.ExecuteScriptAsync((IWebBrowser) this, \u0008\u2004\u2001.\u0002(-1745267375), new object[1]
      {
        (object) _param1
      });
    }

    public void \u0002()
    {
      if (!this.\u0002)
        return;
      WebBrowserExtensions.EvaluateScriptAsync((IWebBrowser) this, \u0008\u2004\u2001.\u0002(-1745267377), new TimeSpan?());
    }

    private object \u0002(string _param1)
    {
      Task<JavascriptResponse> scriptAsync = WebBrowserExtensions.EvaluateScriptAsync((IWebBrowser) this, _param1, new TimeSpan?());
      scriptAsync.Wait();
      JavascriptResponse result = scriptAsync.Result;
      return !result.Success ? (object) result.Message : result.Result ?? (object) string.Empty;
    }

    public string \u0002() => !this.\u0002 ? string.Empty : (string) this.\u0002(\u0008\u2004\u2001.\u0002(-1745267343));

    private void \u0002(object _param1, LoadingStateChangedEventArgs _param2)
    {
      if (_param2.IsLoading)
        return;
      this.JavascriptObjectRepository.Register(\u0008\u2004\u2001.\u0002(-1745267358), (object) new \u002D.ii1i1i1IIlll.\u0002(this), true, (BindingOptions) null);
      this.\u0002 = true;
      \u002D.ii1i1i1IIlll.\u0003 obj = this.\u0003;
      if (obj == null)
        return;
      obj();
    }

    public sealed class \u0002
    {
      private readonly \u002D.ii1i1i1IIlll \u0002;

      public \u0002(\u002D.ii1i1i1IIlll _param1) => this.\u0002 = _param1;

      public void \u0002(string _param1)
      {
        \u002D.ii1i1i1IIlll.\u0005 obj = this.\u0002.\u0005;
        if (obj == null)
          return;
        obj(_param1);
      }

      public void \u0003(string _param1)
      {
        \u002D.ii1i1i1IIlll.\u0005 obj = this.\u0002.\u0008;
        if (obj == null)
          return;
        obj(_param1);
      }

      public void \u0002()
      {
        \u002D.ii1i1i1IIlll.\u0003 obj = this.\u0002.\u0006;
        if (obj == null)
          return;
        obj();
      }
    }

    public delegate void \u0003();

    public delegate void \u0005(string _param1);
  }
}
