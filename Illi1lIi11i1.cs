// Decompiled with JetBrains decompiler
// Type: -.Illi1lIi11i1
// Assembly: SUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C75052F-567C-4717-00F4-FF7442A55C0D
// Assembly location: C:\Users\karol\OneDrive\Desktop\Pastenapse\zK8AAg5yJoW_dump.exe

using \u002D;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace \u002D
{
  public sealed class Illi1lIi11i1 : Window, IComponentConnector
  {
    private readonly iilIIiiiliIl \u0002;
    private readonly Dictionary<string, \u0003\u2003\u2001.\u000E> \u0003 = new Dictionary<string, \u0003\u2003\u2001.\u000E>();
    private \u0003\u2003\u2001.\u000E \u0005;
    private \u0003\u2003\u2001.\u000F \u0008;
    private bool \u0006;
    private BackgroundWorker \u000E = new BackgroundWorker();
    internal Grid \u000F;
    internal Label \u0002\u2000;
    internal Image \u0003\u2000;
    internal Button \u0005\u2000;
    internal ListBox \u0008\u2000;
    internal Image \u0006\u2000;
    internal TextBox \u000E\u2000;
    internal Button \u000F\u2000;
    internal Button \u0002\u2001;
    private bool \u0003\u2001;

    public Illi1lIi11i1(iilIIiiiliIl _param1, \u0003\u2003\u2001.\u000F _param2)
    {
      this.\u0002 = _param1;
      this.\u0008 = _param2;
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      this.\u000E.DoWork += new DoWorkEventHandler(this.\u0002);
      this.InitializeComponent();
    }

    private void \u0002(object _param1, MouseButtonEventArgs _param2)
    {
      if (_param2.ChangedButton != MouseButton.Left || _param2.ButtonState != MouseButtonState.Pressed)
        return;
      this.DragMove();
    }

    private void \u0002(object _param1, RoutedEventArgs _param2)
    {
      this.Title = \u000E\u2002\u2001.\u0002(\u000E\u2002\u2001.\u0003.Next(10, 32));
      this.Topmost = \u0008\u2003\u2001.\u000E.\u0008;
      \u0006\u2002\u2001.\u0008\u2001 obj1 = \u0008\u2003\u2001.\u0008.\u0008;
      \u0006\u2002\u2001.\u0002((Window) this, obj1.\u0002);
      \u0006\u2002\u2001.\u0002(this.\u0003\u2000, obj1.\u0003);
      \u0006\u2002\u2001.\u0002(this.\u000F, obj1.\u0005);
      \u0006\u2002\u2001.\u0002(this.\u0002\u2000, obj1.\u0008);
      \u0006\u2002\u2001.\u0002(this.\u0008\u2000, obj1.\u0006);
      \u0006\u2002\u2001.\u0002(this.\u000E\u2000, obj1.\u000E);
      \u0006\u2002\u2001.\u0002(this.\u0005\u2000, obj1.\u000F);
      \u0006\u2002\u2001.\u0002(this.\u000F\u2000, obj1.\u0002\u2000);
      \u0006\u2002\u2001.\u0002(this.\u0002\u2001, obj1.\u0003\u2000);
      foreach (\u0003\u2003\u2001.\u000E obj2 in this.\u0008.\u0002)
      {
        this.\u0003[obj2.\u0002] = obj2;
        this.\u0008\u2000.Items.Add((object) obj2.\u0002);
      }
    }

    private void \u0002(object _param1, SelectionChangedEventArgs _param2)
    {
      if (this.\u0008\u2000.SelectedIndex == -1)
        return;
      this.\u0005 = this.\u0003[this.\u0008\u2000.Items[this.\u0008\u2000.SelectedIndex].ToString()];
      this.\u000E\u2000.Text = this.\u0005.\u0003;
      this.\u0006\u2000.Source = (ImageSource) new BitmapImage(new Uri(this.\u0005.\u0005));
    }

    public bool \u0002() => this.Dispatcher.Invoke<bool>(new Func<bool>(this.\u0003));

    private void \u0003(object _param1, RoutedEventArgs _param2)
    {
      if (this.\u0006 || this.\u0005 == null)
        return;
      if (!this.\u0002.\u0002())
      {
        this.\u000F\u2000.Content = (object) \u0008\u2004\u2001.\u0002(-1745285683);
        new Thread(new ThreadStart(this.\u0002)).Start();
      }
      else
      {
        this.\u000F\u2000.Content = (object) \u0008\u2003\u2001.\u0008.\u0008.\u0002\u2000.\u000E;
        this.\u0006 = true;
        this.\u000E.RunWorkerAsync();
      }
    }

    private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      Illi1lIi11i1.\u0002 obj = new Illi1lIi11i1.\u0002();
      obj.\u0002 = this;
      try
      {
        using (WebClient webClient = new WebClient())
          obj.\u0003 = webClient.DownloadString(this.\u0005.\u0008);
      }
      catch (Exception ex)
      {
        if (!this.\u0002())
          return;
        this.Dispatcher.Invoke(new Action(obj.\u0002));
        return;
      }
      this.Dispatcher.Invoke(new Action(obj.\u0003));
    }

    private void \u0005(object _param1, RoutedEventArgs _param2) => this.Close();

    private void \u0008(object _param1, RoutedEventArgs _param2) => this.WindowState = WindowState.Minimized;

    private void \u0002(object _param1, CancelEventArgs _param2) => this.\u0002.\u000F = false;

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this.\u0003\u2001)
        return;
      this.\u0003\u2001 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745285647), UriKind.Relative));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    void IComponentConnector.whjjffmqxsdgjp4gn9k64hfz7nfx8vt6\u2003\u2004\u2000\u2001\u0002(
      int _param1,
      object _param2)
    {
      switch (_param1)
      {
        case 1:
          ((FrameworkElement) _param2).Loaded += new RoutedEventHandler(this.\u0002);
          ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0002);
          ((Window) _param2).Closing += new CancelEventHandler(this.\u0002);
          break;
        case 2:
          this.\u000F = (Grid) _param2;
          break;
        case 3:
          this.\u0002\u2000 = (Label) _param2;
          break;
        case 4:
          this.\u0003\u2000 = (Image) _param2;
          break;
        case 5:
          this.\u0005\u2000 = (Button) _param2;
          this.\u0005\u2000.Click += new RoutedEventHandler(this.\u0008);
          break;
        case 6:
          this.\u0008\u2000 = (ListBox) _param2;
          this.\u0008\u2000.SelectionChanged += new SelectionChangedEventHandler(this.\u0002);
          break;
        case 7:
          this.\u0006\u2000 = (Image) _param2;
          break;
        case 8:
          this.\u000E\u2000 = (TextBox) _param2;
          break;
        case 9:
          this.\u000F\u2000 = (Button) _param2;
          this.\u000F\u2000.Click += new RoutedEventHandler(this.\u0003);
          break;
        case 10:
          this.\u0002\u2001 = (Button) _param2;
          this.\u0002\u2001.Click += new RoutedEventHandler(this.\u0005);
          break;
        default:
          this.\u0003\u2001 = true;
          break;
      }
    }

    private bool \u0003() => Application.Current.Windows.Cast<Window>().Any<Window>(new Func<Window, bool>(this.\u0002));

    private bool \u0002(Window _param1) => _param1 == this;

    private void \u0002()
    {
      Thread.Sleep(1500);
      if (!this.\u0002())
        return;
      this.Dispatcher.Invoke(new Action(this.\u0003));
    }

    private void \u0003() => this.\u000F\u2000.Content = (object) \u0008\u2003\u2001.\u0008.\u0008.\u0002\u2000.\u0006;

    private sealed class \u0002
    {
      public Illi1lIi11i1 \u0002;
      public string \u0003;

      internal void \u0002()
      {
        this.\u0002.\u0006 = false;
        this.\u0002.\u000F\u2000.Content = (object) \u0008\u2003\u2001.\u0008.\u0008.\u0002\u2000.\u0006;
        this.\u0002.Topmost = false;
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745285536), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        this.\u0002.Topmost = \u0008\u2003\u2001.\u000E.\u0008;
      }

      internal void \u0003()
      {
        if (!this.\u0002.\u0002())
          return;
        this.\u0002.\u0006 = false;
        this.\u0002.\u000F\u2000.Content = (object) \u0008\u2003\u2001.\u0008.\u0008.\u0002\u2000.\u0006;
        this.\u0002.\u0002.\u0002(this.\u0003);
      }
    }
  }
}
