
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
  public sealed class l1IllliilI1li : Window, IComponentConnector
  {
    public BackgroundWorker \u0002 = new BackgroundWorker();
    private bool \u0003;
    private \u000E\u200A\u2000 \u0005;
    internal Label \u0008;
    internal Button \u0006;
    internal Button \u000E;
    internal Image \u000F;
    internal TextBox \u0002\u2000;
    internal PasswordBox \u0003\u2000;
    internal Button \u0005\u2000;
    private bool \u0008\u2000;

    public l1IllliilI1li()
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

    private void \u0002(object _param1, CancelEventArgs _param2)
    {
      if (this.\u0003)
        return;
      Environment.Exit(0);
    }

    private void \u0005(object _param1, RoutedEventArgs _param2) => this.WindowState = WindowState.Minimized;

    private void \u0002(object _param1, MouseButtonEventArgs _param2)
    {
      if (_param2.ChangedButton != MouseButton.Left || _param2.ButtonState != MouseButtonState.Pressed)
        return;
      this.DragMove();
    }

    private void \u0003(object _param1, MouseButtonEventArgs _param2)
    {
      this.\u0003 = true;
      new l11ii11Il1iI1().Show();
      this.Close();
    }

    private void \u0005(object _param1, MouseButtonEventArgs _param2)
    {
      this.\u0003 = true;
      new li1lll1i1IIl().Show();
      this.Close();
    }

    private void \u0008(object _param1, RoutedEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_FZl+`lH';", objArray);
    }

    private void \u0002(string _param1, string _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        (object) _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_G@\\X`lH';", objArray);
    }

    private bool \u0002(string _param1, string _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        (object) _param1,
        (object) _param2
      };
      return (bool) \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_PY&``lH$:", objArray);
    }

    private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_@VgF`lH$:", objArray);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this.\u0008\u2000)
        return;
      this.\u0008\u2000 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745282159), UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.usu6cpszt4u24pbkrg7fjv56dgfcgsy3\u2003\u2004\u2000\u2001\u0002(
      int _param1,
      object _param2)
    {
      switch (_param1)
      {
        case 1:
          ((Window) _param2).Closing += new CancelEventHandler(this.\u0002);
          ((FrameworkElement) _param2).Loaded += new RoutedEventHandler(this.\u0002);
          ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0002);
          break;
        case 2:
          this.\u0008 = (Label) _param2;
          break;
        case 3:
          this.\u0006 = (Button) _param2;
          this.\u0006.Click += new RoutedEventHandler(this.\u0003);
          break;
        case 4:
          this.\u000E = (Button) _param2;
          this.\u000E.Click += new RoutedEventHandler(this.\u0005);
          break;
        case 5:
          this.\u000F = (Image) _param2;
          break;
        case 6:
          this.\u0002\u2000 = (TextBox) _param2;
          break;
        case 7:
          this.\u0003\u2000 = (PasswordBox) _param2;
          break;
        case 8:
          ((UIElement) _param2).MouseLeftButtonDown += new MouseButtonEventHandler(this.\u0005);
          break;
        case 9:
          ((UIElement) _param2).MouseLeftButtonDown += new MouseButtonEventHandler(this.\u0003);
          break;
        case 10:
          this.\u0005\u2000 = (Button) _param2;
          this.\u0005\u2000.Click += new RoutedEventHandler(this.\u0008);
          break;
        default:
          this.\u0008\u2000 = true;
          break;
      }
    }

    private void \u0002()
    {
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263491), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
      this.\u0005.\u0002(false);
    }

    private void \u0003()
    {
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745282121), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
      this.\u0005.\u0002(false);
    }

    private void \u0005()
    {
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745282239), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
      this.\u0005.\u0002(false);
    }

    private void \u0008()
    {
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745282121), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
      this.\u0005.\u0002(false);
    }

    private void \u0006()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262465), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
    }

    [Serializable]
    private sealed class \u0002
    {
      public static readonly l1IllliilI1li.\u0002 \u0002 = new l1IllliilI1li.\u0002();
      public static Action \u0003;
      public static Action \u0005;
      public static Action \u0008;

      internal void \u0002()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263210), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      }

      internal void \u0003()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263259), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      }

      internal void \u0005()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262097), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        Environment.Exit(0);
      }
    }

    private sealed class \u0003
    {
      public string \u0002;
      public l1IllliilI1li \u0003;
      public string \u0005;

      internal void \u0002()
      {
        this.\u0002 = this.\u0003.\u0002\u2000.Text;
        this.\u0005 = this.\u0003.\u0003\u2000.Password;
      }

      internal void \u0003()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263369), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
        this.\u0003.\u0005.\u0002(false);
      }

      internal void \u0005()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263448), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
        this.\u0003.\u0005.\u0002(false);
      }

      internal void \u0008()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263491), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
        this.\u0003.\u0005.\u0002(false);
      }

      internal void \u0006()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262217), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0003.\u0005\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745263428);
        this.\u0003.\u0005.\u0002(false);
      }
    }
  }
}
