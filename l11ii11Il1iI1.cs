// Decompiled with JetBrains decompiler
// Type: -.l11ii11Il1iI1
// Assembly: SUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C75052F-567C-4717-00F4-FF7442A55C0D
// Assembly location: C:\Users\karol\OneDrive\Desktop\Pastenapse\zK8AAg5yJoW_dump.exe

using \u002D;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace \u002D
{
  public sealed class l11ii11Il1iI1 : Window, IComponentConnector
  {
    public BackgroundWorker \u0002 = new BackgroundWorker();
    private static readonly Regex \u0003 = new Regex(\u0008\u2004\u2001.\u0002(-1745286210), RegexOptions.Compiled);
    private static readonly Regex \u0005 = new Regex(\u0008\u2004\u2001.\u0002(-1745286237), RegexOptions.Compiled);
    private \u000E\u200A\u2000 \u0008;
    internal Label \u0006;
    internal Button \u000E;
    internal Button \u000F;
    internal Image \u0002\u2000;
    internal TextBox \u0003\u2000;
    internal PasswordBox \u0005\u2000;
    internal TextBox \u0008\u2000;
    internal TextBox \u0006\u2000;
    internal Button \u000E\u2000;
    private bool \u000F\u2000;

    public l11ii11Il1iI1()
    {
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      this.\u0002.DoWork += new DoWorkEventHandler(this.\u0002);
      this.InitializeComponent();
    }

    private void \u0002(object _param1, RoutedEventArgs _param2) => this.Title = \u000E\u2002\u2001.\u0002(\u000E\u2002\u2001.\u0003.Next(10, 32));

    private void \u0003(object _param1, RoutedEventArgs _param2)
    {
      Application.Current.Shutdown();
      Environment.Exit(0);
    }

    private void \u0002(object _param1, CancelEventArgs _param2) => Environment.Exit(0);

    private void \u0005(object _param1, RoutedEventArgs _param2) => this.WindowState = WindowState.Minimized;

    private void \u0002(object _param1, MouseButtonEventArgs _param2)
    {
      if (_param2.ChangedButton != MouseButton.Left || _param2.ButtonState != MouseButtonState.Pressed)
        return;
      this.DragMove();
    }

    private static bool \u0002(string _param0) => l11ii11Il1iI1.\u0003.IsMatch(_param0) && !l11ii11Il1iI1.\u0005.IsMatch(_param0) && _param0.Length >= 5;

    private void \u0008(object _param1, RoutedEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_F6N%`lH$:", objArray);
    }

    private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_B])s`lH$:", objArray);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this.\u000F\u2000)
        return;
      this.\u000F\u2000 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745286495), UriKind.Relative));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.tya7t64ag58dfe673eavfr7z859j2z7y\u2003\u2004\u2000\u2001\u0002(
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
          this.\u0006 = (Label) _param2;
          break;
        case 3:
          this.\u000E = (Button) _param2;
          this.\u000E.Click += new RoutedEventHandler(this.\u0003);
          break;
        case 4:
          this.\u000F = (Button) _param2;
          this.\u000F.Click += new RoutedEventHandler(this.\u0005);
          break;
        case 5:
          this.\u0002\u2000 = (Image) _param2;
          break;
        case 6:
          this.\u0003\u2000 = (TextBox) _param2;
          break;
        case 7:
          this.\u0005\u2000 = (PasswordBox) _param2;
          break;
        case 8:
          this.\u0008\u2000 = (TextBox) _param2;
          break;
        case 9:
          this.\u0006\u2000 = (TextBox) _param2;
          break;
        case 10:
          this.\u000E\u2000 = (Button) _param2;
          this.\u000E\u2000.Click += new RoutedEventHandler(this.\u0008);
          break;
        default:
          this.\u000F\u2000 = true;
          break;
      }
    }

    [Serializable]
    private sealed class \u0002
    {
      public static readonly l11ii11Il1iI1.\u0002 \u0002 = new l11ii11Il1iI1.\u0002();
      public static Action \u0003;

      internal void \u0002()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745283716), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      }
    }

    private sealed class \u0003
    {
      public string \u0002;
      public l11ii11Il1iI1 \u0003;
      public string \u0005;
      public string \u0008;
      public string \u0006;

      internal void \u0002()
      {
        this.\u0002 = this.\u0003.\u0003\u2000.Text;
        this.\u0005 = this.\u0003.\u0005\u2000.Password;
        this.\u0008 = this.\u0003.\u0008\u2000.Text;
        this.\u0006 = this.\u0003.\u0006\u2000.Text;
      }

      internal void \u0003()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745283894), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u000E\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745283933);
        this.\u0003.\u0008.\u0002(false);
      }

      internal void \u0005()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284014), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u000E\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745283933);
        this.\u0003.\u0008.\u0002(false);
      }

      internal void \u0008()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284079), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u000E\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745283933);
        this.\u0003.\u0008.\u0002(false);
      }

      internal void \u0006()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745285069), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u000E\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745283933);
        this.\u0003.\u0008.\u0002(false);
      }

      internal void \u000E()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745286202), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u000E\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745283933);
        this.\u0003.\u0008.\u0002(false);
      }
    }
  }
}
