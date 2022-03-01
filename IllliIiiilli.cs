// Decompiled with JetBrains decompiler
// Type: -.IllliIiiilli
// Assembly: SUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C75052F-567C-4717-00F4-FF7442A55C0D
// Assembly location: C:\Users\karol\OneDrive\Desktop\Pastenapse\zK8AAg5yJoW_dump.exe

using \u002D;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace \u002D
{
  public sealed class IllliIiiilli : Window, IComponentConnector
  {
    public BackgroundWorker \u0002 = new BackgroundWorker();
    internal Label \u0003;
    internal Button \u0005;
    internal Button \u0008;
    internal Image \u0006;
    internal TextBox \u000E;
    internal TextBox \u000F;
    internal Button \u0002\u2000;
    private bool \u0003\u2000;

    public IllliIiiilli()
    {
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      this.\u0002.DoWork += new DoWorkEventHandler(this.\u0002);
      this.InitializeComponent();
    }

    private void \u0002(object _param1, RoutedEventArgs _param2)
    {
      this.Title = \u000E\u2002\u2001.\u0002(\u000E\u2002\u2001.\u0003.Next(10, 32));
      \u000E\u2002\u2001.\u0002\u2001 obj = \u000E\u2002\u2001.\u0002();
      if (obj.\u0002 == \u000E\u2002\u2001.\u000E.OK)
      {
        this.\u000E.Text = obj.\u0003;
      }
      else
      {
        switch (obj.\u0002)
        {
          case \u000E\u2002\u2001.\u000E.INVALID_HWID:
            int num1 = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745283264), \u0008\u2004\u2001.\u0002(-1745283378), MessageBoxButton.OK, MessageBoxImage.Hand);
            Environment.Exit(0);
            break;
          case \u000E\u2002\u2001.\u000E.INVALID_REQUEST:
            int num2 = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745283344), \u0008\u2004\u2001.\u0002(-1745283378), MessageBoxButton.OK, MessageBoxImage.Hand);
            Environment.Exit(0);
            break;
          default:
            int num3 = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745283458) + Convert.ToInt32((object) obj.\u0002).ToString() + \u0008\u2004\u2001.\u0002(-1745283544), \u0008\u2004\u2001.\u0002(-1745283378), MessageBoxButton.OK, MessageBoxImage.Hand);
            Environment.Exit(0);
            break;
        }
      }
    }

    private void \u0002(object _param1, CancelEventArgs _param2) => Environment.Exit(0);

    private void \u0003(object _param1, RoutedEventArgs _param2)
    {
      Application.Current.Shutdown();
      Environment.Exit(0);
    }

    private void \u0005(object _param1, RoutedEventArgs _param2) => this.WindowState = WindowState.Minimized;

    private void \u0002(object _param1, MouseButtonEventArgs _param2)
    {
      if (_param2.ChangedButton != MouseButton.Left || _param2.ButtonState != MouseButtonState.Pressed)
        return;
      this.DragMove();
    }

    private void \u0003(object _param1, MouseButtonEventArgs _param2) => Process.Start(\u0008\u2004\u2001.\u0002(-1745283599));

    private void \u0008(object _param1, RoutedEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_B/<b`lH$:", objArray);
    }

    private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_Y2'e`lH';", objArray);
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this.\u0003\u2000)
        return;
      this.\u0003\u2000 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745283675), UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.\u0038cfasbabpr4dbf535hnma65yt3k3fj3p\u2003\u2004\u2000\u2001\u0002(
      int _param1,
      object _param2)
    {
      switch (_param1)
      {
        case 1:
          ((FrameworkElement) _param2).Loaded += new RoutedEventHandler(this.\u0002);
          ((Window) _param2).Closing += new CancelEventHandler(this.\u0002);
          ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0002);
          break;
        case 2:
          this.\u0003 = (Label) _param2;
          break;
        case 3:
          this.\u0005 = (Button) _param2;
          this.\u0005.Click += new RoutedEventHandler(this.\u0003);
          break;
        case 4:
          this.\u0008 = (Button) _param2;
          this.\u0008.Click += new RoutedEventHandler(this.\u0005);
          break;
        case 5:
          this.\u0006 = (Image) _param2;
          break;
        case 6:
          this.\u000E = (TextBox) _param2;
          break;
        case 7:
          this.\u000F = (TextBox) _param2;
          break;
        case 8:
          ((UIElement) _param2).MouseLeftButtonDown += new MouseButtonEventHandler(this.\u0003);
          break;
        case 9:
          this.\u0002\u2000 = (Button) _param2;
          this.\u0002\u2000.Click += new RoutedEventHandler(this.\u0008);
          break;
        default:
          this.\u0003\u2000 = true;
          break;
      }
    }

    [Serializable]
    private sealed class \u0002
    {
      public static readonly IllliIiiilli.\u0002 \u0002 = new IllliIiiilli.\u0002();
      public static Action \u0003;
      public static Action \u0005;

      internal void \u0002()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284623), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      }

      internal void \u0003()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284750), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      }
    }

    private sealed class \u0003
    {
      public string \u0002;
      public IllliIiiilli \u0003;
      public string \u0005;

      internal void \u0002()
      {
        this.\u0002 = this.\u0003.\u000E.Text;
        this.\u0005 = this.\u0003.\u000F.Text;
      }

      internal void \u0003()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284955), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0002\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745285114);
      }

      internal void \u0005()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745285069), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0002\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745285114);
      }

      internal void \u0008()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745283107), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0002\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745285114);
      }

      internal void \u0006()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745283187), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0002\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745285114);
      }
    }
  }
}
