// Decompiled with JetBrains decompiler
// Type: -.I1iIil1Il1II
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
  public sealed class I1iIil1Il1II : Window, IComponentConnector
  {
    public BackgroundWorker \u0002 = new BackgroundWorker();
    private \u000E\u200A\u2000 \u0003;
    internal Label \u0005;
    internal Button \u0008;
    internal Button \u0006;
    internal Image \u000E;
    internal PasswordBox \u000F;
    internal PasswordBox \u0002\u2000;
    internal Button \u0003\u2000;
    private bool \u0005\u2000;

    public I1iIil1Il1II()
    {
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      this.\u0002.DoWork += new DoWorkEventHandler(this.\u0002);
      this.InitializeComponent();
    }

    private void \u0002(object _param1, RoutedEventArgs _param2)
    {
      Application.Current.Shutdown();
      Environment.Exit(0);
    }

    private void \u0003(object _param1, RoutedEventArgs _param2) => this.WindowState = WindowState.Minimized;

    private void \u0002(object _param1, MouseButtonEventArgs _param2)
    {
      if (_param2.ChangedButton != MouseButton.Left || _param2.ButtonState != MouseButtonState.Pressed)
        return;
      this.DragMove();
    }

    private void \u0002(object _param1, CancelEventArgs _param2) => Environment.Exit(0);

    private void \u0005(object _param1, RoutedEventArgs _param2) => this.Title = \u000E\u2002\u2001.\u0002(\u000E\u2002\u2001.\u0003.Next(10, 32));

    private void \u0008(object _param1, RoutedEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_Ub*j`lH$:", objArray);
    }

    private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_HZ3>`lH$:", objArray);
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this.\u0005\u2000)
        return;
      this.\u0005\u2000 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745270183), UriKind.Relative));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.glgln79jp5gzgye68gp5tkfqqwtzv7qd\u2003\u2004\u2000\u2001\u0002(
      int _param1,
      object _param2)
    {
      switch (_param1)
      {
        case 1:
          ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0002);
          ((Window) _param2).Closing += new CancelEventHandler(this.\u0002);
          ((FrameworkElement) _param2).Loaded += new RoutedEventHandler(this.\u0005);
          break;
        case 2:
          this.\u0005 = (Label) _param2;
          break;
        case 3:
          this.\u0008 = (Button) _param2;
          this.\u0008.Click += new RoutedEventHandler(this.\u0002);
          break;
        case 4:
          this.\u0006 = (Button) _param2;
          this.\u0006.Click += new RoutedEventHandler(this.\u0003);
          break;
        case 5:
          this.\u000E = (Image) _param2;
          break;
        case 6:
          this.\u000F = (PasswordBox) _param2;
          break;
        case 7:
          this.\u0002\u2000 = (PasswordBox) _param2;
          break;
        case 8:
          this.\u0003\u2000 = (Button) _param2;
          this.\u0003\u2000.Click += new RoutedEventHandler(this.\u0008);
          break;
        default:
          this.\u0005\u2000 = true;
          break;
      }
    }

    private sealed class \u0002
    {
      public string \u0002;
      public I1iIil1Il1II \u0003;
      public \u000E\u2002\u2001.\u000F\u2000 \u0005;

      internal void \u0002() => this.\u0002 = this.\u0003.\u000F.Password;

      internal void \u0003()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745267448), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        \u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745267476));
        this.\u0003.Close();
      }

      internal void \u0005()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745267560), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.Close();
      }

      internal void \u0008()
      {
        \u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745267635));
        \u0005\u2002\u2001.\u0002<string>(\u0008\u2004\u2001.\u0002(-1745267476), this.\u0005.\u0003);
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745267591), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
        Environment.Exit(0);
      }

      internal void \u0006()
      {
        \u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745267476));
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745267560), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.Close();
      }

      internal void \u000E()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745269800), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0003\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745269882);
        this.\u0003.\u0003.\u0002(false);
      }

      internal void \u000F()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745269845), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0003\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745269882);
        this.\u0003.\u0003.\u0002(false);
      }

      internal void \u0002\u2000()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745269985), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0003\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745269882);
        this.\u0003.\u0003.\u0002(false);
      }
    }
  }
}
