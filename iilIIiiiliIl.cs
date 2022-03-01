// Decompiled with JetBrains decompiler
// Type: -.iilIIiiiliIl
// Assembly: SUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C75052F-567C-4717-00F4-FF7442A55C0D
// Assembly location: C:\Users\karol\OneDrive\Desktop\Pastenapse\zK8AAg5yJoW_dump.exe

using \u002D;
using CefSharp;
using CefSharp.Wpf;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace \u002D
{
  public sealed class iilIIiiiliIl : Window, IComponentConnector
  {
    public \u0002\u2004\u2001 \u0002;
    private iilIIiiiliIl.\u0008\u2000 \u0003;
    private \u0005\u2003\u2000 \u0005;
    private \u0005\u2003\u2000 \u0008;
    private static \u0005\u2003\u2000 \u0006;
    public bool \u000E;
    public bool \u000F;
    private bool \u0002\u2000;
    public bool \u0003\u2000;
    private bool \u0005\u2000;
    private static \u0006\u2002\u2001.\u0002 \u0008\u2000;
    private readonly string \u0006\u2000;
    private readonly string \u000E\u2000;
    public static FileSystemWatcher \u000F\u2000;
    public static BackgroundWorker \u0002\u2001 = new BackgroundWorker();
    public static BackgroundWorker \u0003\u2001 = new BackgroundWorker();
    private int \u0005\u2001;
    private \u0003\u2003\u2001.\u0003\u2000 \u0008\u2001;
    internal Grid \u0006\u2001;
    internal Label \u000E\u2001;
    internal Button \u000F\u2001;
    internal Button \u0002\u2002;
    internal Button \u0003\u2002;
    internal Button \u0005\u2002;
    internal Image \u0008\u2002;
    internal Grid \u0006\u2002;
    internal TabControl \u000E\u2002;
    internal \u002D.ii1i1i1IIlll \u000F\u2002;
    internal ListBox \u0002\u2003;
    internal MenuItem \u0003\u2003;
    internal MenuItem \u0005\u2003;
    internal Grid \u0008\u2003;
    internal Button \u0006\u2003;
    internal Button \u000E\u2003;
    internal Button \u000F\u2003;
    internal Button \u0002\u2004;
    internal Button \u0003\u2004;
    internal Button \u0005\u2004;
    internal Button \u0008\u2004;
    internal Button \u0006\u2004;
    private bool \u000E\u2004;

    public iilIIiiiliIl()
    {
      iilIIiiiliIl.\u0002 obj1 = new iilIIiiiliIl.\u0002();
      obj1.\u0008 = this;
      Cef.EnableHighDPISupport();
      CefSettings cefSettings = new CefSettings();
      ((CefSettingsBase) cefSettings).SetOffScreenRenderingBestPerformanceArgs();
      Cef.Initialize((CefSettingsBase) cefSettings);
      this.InitializeComponent();
      iilIIiiiliIl.\u0002\u2001.DoWork += new DoWorkEventHandler(this.\u0003);
      iilIIiiiliIl.\u0003\u2001.DoWork += new DoWorkEventHandler(this.\u0002);
      this.\u000E\u2002.Loaded += new RoutedEventHandler(this.\u0005\u2001);
      obj1.\u0002 = (StreamReader) null;
      try
      {
        this.\u0002 = new \u0002\u2004\u2001(\u0008\u2004\u2001.\u0002(-1745261673));
        this.\u0002.\u0005\u2003\u2008\u200A\u2002\u2008\u2008\u2008\u2009\u2002\u2009\u2002\u2009\u200A\u2005\u2000\u2002\u2009\u2006\u2002\u2006\u2005\u200A\u2009(new \u000F\u2003\u2001(this.\u0002));
        this.\u0002.\u0005\u2008\u2009\u2002\u2003\u2005\u200A​\u2003\u2001​\u2009\u2006\u2005​(new \u000F\u2003\u2001(obj1.\u0002));
        this.\u0002.Start();
      }
      catch (Exception ex)
      {
        if (!\u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745282896)))
        {
          int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745282911), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
          \u0005\u2002\u2001.\u0002<bool>(\u0008\u2004\u2001.\u0002(-1745282896), true);
        }
      }
      if (\u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745281196)))
      {
        \u0003\u2003\u2001.\u0006 obj2 = \u0005\u2002\u2001.\u0003<\u0003\u2003\u2001.\u0006>(\u0008\u2004\u2001.\u0002(-1745281196));
        try
        {
          if (Process.GetProcessById(obj2.\u0002).StartTime == obj2.\u0003)
          {
            int num = obj2.\u0002;
            iilIIiiiliIl.\u0006.\u0002(num);
          }
          \u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745281196));
        }
        catch (Exception ex)
        {
          \u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745281196));
        }
      }
      obj1.\u0005 = \u0008\u2003\u2001.\u0008.\u0005;
      \u0006\u2002\u2001.\u0002((Window) this, obj1.\u0005.\u0002);
      \u0006\u2002\u2001.\u0002(this.\u0008\u2002, obj1.\u0005.\u000E);
      \u0006\u2002\u2001.\u0002(this.\u0006\u2001, obj1.\u0005.\u000F);
      \u0006\u2002\u2001.\u0002(this.\u000E\u2001, obj1.\u0005.\u0002\u2000, \u0008\u2003\u2001.\u0002);
      \u0006\u2002\u2001.\u0002(this.\u0002\u2003, obj1.\u0005.\u0003\u2000);
      \u0006\u2002\u2001.\u0002(this.\u0005\u2002, obj1.\u0005.\u0005\u2000);
      \u0006\u2002\u2001.\u0002(this.\u000F\u2001, obj1.\u0005.\u0008\u2000);
      \u0006\u2002\u2001.\u0002(this.\u0006\u2003, obj1.\u0005.\u0006\u2000);
      \u0006\u2002\u2001.\u0002(this.\u000E\u2003, obj1.\u0005.\u000E\u2000);
      \u0006\u2002\u2001.\u0002(this.\u000F\u2003, obj1.\u0005.\u000F\u2000);
      \u0006\u2002\u2001.\u0002(this.\u0002\u2004, obj1.\u0005.\u0002\u2001);
      \u0006\u2002\u2001.\u0002(this.\u0003\u2004, obj1.\u0005.\u0003\u2001);
      \u0006\u2002\u2001.\u0002(this.\u0005\u2004, obj1.\u0005.\u0005\u2001);
      \u0006\u2002\u2001.\u0002(this.\u0008\u2004, obj1.\u0005.\u0008\u2001);
      \u0006\u2002\u2001.\u0002(this.\u0006\u2004, obj1.\u0005.\u0006\u2001);
      iilIIiiiliIl.\u0008\u2000 = obj1.\u0005.\u0008;
      this.\u0006\u2000 = Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName;
      new Thread(new ThreadStart(obj1.\u0002)).Start();
      new Thread(new ThreadStart(obj1.\u0003)).Start();
      new Thread(new ThreadStart(this.\u0008)).Start();
      this.\u0002(new iilIIiiiliIl.\u0008\u2000(obj1.\u0002));
      this.\u000E\u2000 = Path.Combine(this.\u0006\u2000, \u0008\u2004\u2001.\u0002(-1745281213));
      foreach (string file in Directory.GetFiles(this.\u000E\u2000))
        this.\u0002\u2003.Items.Add((object) Path.GetFileName(file));
      iilIIiiiliIl.\u000F\u2000 = new FileSystemWatcher(this.\u000E\u2000)
      {
        NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.LastAccess
      };
      iilIIiiiliIl.\u000F\u2000.Changed += new FileSystemEventHandler(this.\u0002);
      iilIIiiiliIl.\u000F\u2000.Created += new FileSystemEventHandler(this.\u0002);
      iilIIiiiliIl.\u000F\u2000.Deleted += new FileSystemEventHandler(this.\u0002);
      iilIIiiiliIl.\u000F\u2000.Renamed += new RenamedEventHandler(this.\u0002);
      iilIIiiiliIl.\u000F\u2000.EnableRaisingEvents = true;
      if (!obj1.\u0005.\u0003.\u0002)
        return;
      \u000F\u2002\u2001.\u0002(24892, this);
    }

    public void \u0002(iilIIiiiliIl.\u0008\u2000 _param1)
    {
      iilIIiiiliIl.\u0008\u2000 obj = this.\u0003;
      iilIIiiiliIl.\u0008\u2000 comparand;
      do
      {
        comparand = obj;
        obj = Interlocked.CompareExchange<iilIIiiiliIl.\u0008\u2000>(ref this.\u0003, comparand + _param1, comparand);
      }
      while (obj != comparand);
    }

    public void \u0003(iilIIiiiliIl.\u0008\u2000 _param1)
    {
      iilIIiiiliIl.\u0008\u2000 obj = this.\u0003;
      iilIIiiiliIl.\u0008\u2000 comparand;
      do
      {
        comparand = obj;
        obj = Interlocked.CompareExchange<iilIIiiiliIl.\u0008\u2000>(ref this.\u0003, comparand - _param1, comparand);
      }
      while (obj != comparand);
    }

    public void \u0002(string _param1, int _param2)
    {
      iilIIiiiliIl.\u0005 obj = new iilIIiiiliIl.\u0005();
      obj.\u0002 = this;
      obj.\u0003 = _param1;
      obj.\u0005 = _param2;
      this.Dispatcher.Invoke(new Action(obj.\u0002));
      if (obj.\u0005 == 0)
        return;
      new Thread(new ThreadStart(obj.\u0003)).Start();
    }

    public string \u0002(string _param1)
    {
      object[] objArray = new object[2]
      {
        (object) this,
        (object) _param1
      };
      return (string) \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_PD[t`lH$:", objArray);
    }

    public bool \u0002()
    {
      object[] objArray = new object[1]{ (object) this };
      return (bool) \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_Ad@.`lH$:", objArray);
    }

    public static void \u0002(string _param0, string _param1, int _param2)
    {
      object[] objArray = new object[3]
      {
        (object) _param0,
        (object) _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_X1@>`lH';", objArray);
    }

    public void \u0002(string _param1)
    {
      object[] objArray = new object[2]
      {
        (object) this,
        (object) _param1
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_Q/+$`lH$:", objArray);
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
    }

    private void l1lilliIililI() => this.Dispatcher.Invoke(new Action(this.\u0006));

    private void I1iIil1Il1II(string _param1)
    {
      iilIIiiiliIl.\u0008 obj = new iilIIiiiliIl.\u0008();
      obj.\u0002 = this;
      obj.\u0003 = (\u0002\u2002\u2001) null;
      this.Dispatcher.Invoke(new Action(obj.\u0002));
      if (obj.\u0003 == null || !obj.\u0003.\u0002)
        return;
      if (obj.\u0003.\u0005 != _param1)
        this.Dispatcher.Invoke(new Action(obj.\u0003));
      else
        this.Dispatcher.Invoke(new Action(obj.\u0005));
    }

    private void l11iIIlIi1iI1(string _param1)
    {
      iilIIiiiliIl.\u0006 obj = new iilIIiiiliIl.\u0006();
      obj.\u0002 = this;
      obj.\u0005 = _param1;
      obj.\u0003 = (\u0002\u2002\u2001) null;
      this.Dispatcher.Invoke(new Action(obj.\u0002));
      if (obj.\u0003 == null)
        return;
      if (obj.\u0003.\u0002)
      {
        try
        {
          File.WriteAllText(obj.\u0003.\u0006, obj.\u0005);
          obj.\u0003.\u0005 = obj.\u0005;
          obj.\u0003.\u0008 = obj.\u0005;
          this.Dispatcher.Invoke(new Action(obj.\u0003));
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745267460), \u0008\u2004\u2001.\u0002(-1745281184), MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
      }
      else
        this.Dispatcher.Invoke(new Action(obj.\u0005));
    }

    private void ii1i1i1IIlll() => this.Dispatcher.Invoke(new Action(this.\u000E));

    private void \u0002() => this.Dispatcher.Invoke(new Action(this.\u000F));

    private \u0002\u2002\u2001 \u0002(
      bool _param1,
      string _param2,
      string _param3,
      string _param4)
    {
      iilIIiiiliIl.\u000F obj1 = new iilIIiiiliIl.\u000F();
      obj1.\u0002 = _param1;
      obj1.\u0003 = this;
      obj1.\u0008 = _param3;
      bool flag = true;
      if (_param2 == null)
      {
        flag = false;
        ++this.\u0005\u2001;
        _param2 = string.Format(\u0008\u2004\u2001.\u0002(-1745282519), (object) this.\u0005\u2001);
      }
      iilIIiiiliIl.\u000F obj2 = obj1;
      \u0002\u2002\u2001 obj3 = new \u0002\u2002\u2001(flag);
      obj3.Header = (object) _param2;
      obj3.\u0003 = _param2;
      obj3.Style = this.FindResource((object) \u0008\u2004\u2001.\u0002(-1745281225)) as Style;
      obj3.\u0006 = _param4;
      obj2.\u0006 = obj3;
      if (obj1.\u0008 != null)
        obj1.\u0006.\u0005 = obj1.\u0008;
      obj1.\u0005 = this.\u000E\u2002.Items.Count;
      obj1.\u0006.Loaded += new RoutedEventHandler(obj1.\u0002);
      this.\u000E\u2002.Items.Add((object) obj1.\u0006);
      return obj1.\u0006;
    }

    private void \u0003(object _param1, RoutedEventArgs _param2) => this.\u0002(true, (string) null, (string) null, (string) null);

    private void \u0002(object _param1, SelectionChangedEventArgs _param2)
    {
      if (_param2.AddedItems.Count == 0 || !(_param2.AddedItems[0] is \u0002\u2002\u2001 addedItem))
        return;
      if (_param2.RemovedItems.Count != 0 && _param2.RemovedItems[0] is \u0002\u2002\u2001 removedItem)
        removedItem.\u0008 = this.\u000F\u2002.\u0002();
      this.\u000F\u2002.\u0003(addedItem.\u0008);
    }

    public void \u0003()
    {
      if (iilIIiiiliIl.\u0002\u2001.IsBusy || this.\u0003\u2000)
        return;
      iilIIiiiliIl.\u0002\u2001.RunWorkerAsync();
    }

    public void \u0006\u2001(string _param1) => this.\u000F\u2002.\u0003(_param1);

    private void \u0005(object _param1, RoutedEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_AF?1`lH$:", objArray);
    }

    private void \u0002(object _param1, CancelEventArgs _param2)
    {
      this.\u0005\u2000 = true;
      this.\u0002();
      Environment.Exit(0);
    }

    private void \u0008(object _param1, RoutedEventArgs _param2)
    {
      if (this.\u000E)
        return;
      new IiIIIiIi11lI(this).Show();
    }

    private void \u0006(object _param1, RoutedEventArgs _param2) => SystemCommands.MinimizeWindow((Window) this);

    private void \u000E(object _param1, RoutedEventArgs _param2) => SystemCommands.MaximizeWindow((Window) this);

    private void \u000F(object _param1, RoutedEventArgs _param2) => SystemCommands.RestoreWindow((Window) this);

    private void \u0002(object _param1, EventArgs _param2)
    {
      switch (this.WindowState)
      {
        case WindowState.Normal:
          this.BorderThickness = new Thickness(0.0);
          this.\u0002\u2002.Visibility = Visibility.Visible;
          this.\u0003\u2002.Visibility = Visibility.Collapsed;
          break;
        case WindowState.Maximized:
          this.BorderThickness = new Thickness(8.0);
          this.\u0002\u2002.Visibility = Visibility.Collapsed;
          this.\u0003\u2002.Visibility = Visibility.Visible;
          break;
      }
    }

    private void \u0002\u2000(object _param1, RoutedEventArgs _param2)
    {
      if (\u0008\u2003\u2001.\u000E.\u0005\u2000 && !string.IsNullOrWhiteSpace(this.\u000F\u2002.\u0002()) && MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745281243), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No) != MessageBoxResult.Yes)
        return;
      this.\u000F\u2002.\u0003(string.Empty);
    }

    private void \u0003(object _param1, MouseButtonEventArgs _param2)
    {
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745281392), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
    }

    private void \u0003\u2000(object _param1, RoutedEventArgs _param2)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Filter = \u0008\u2004\u2001.\u0002(-1745282533);
      openFileDialog1.Title = \u0008\u2004\u2001.\u0002(-1745281434);
      openFileDialog1.FileName = string.Empty;
      OpenFileDialog openFileDialog2 = openFileDialog1;
      bool? nullable = openFileDialog2.ShowDialog();
      if (!(nullable.GetValueOrDefault() & nullable.HasValue))
        return;
      try
      {
        this.\u0002(true, Path.GetFileName(openFileDialog2.FileName), File.ReadAllText(openFileDialog2.FileName), openFileDialog2.FileName);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745267460), \u0008\u2004\u2001.\u0002(-1745281534), MessageBoxButton.OK);
      }
    }

    private void \u0005\u2000(object _param1, RoutedEventArgs _param2)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Filter = \u0008\u2004\u2001.\u0002(-1745282533);
      openFileDialog1.Title = \u0008\u2004\u2001.\u0002(-1745281592);
      openFileDialog1.FileName = string.Empty;
      OpenFileDialog openFileDialog2 = openFileDialog1;
      bool? nullable = openFileDialog2.ShowDialog();
      if (!(nullable.GetValueOrDefault() & nullable.HasValue))
        return;
      try
      {
        this.\u0002(File.ReadAllText(openFileDialog2.FileName));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745281534), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      }
    }

    private void \u0008\u2000(object _param1, RoutedEventArgs _param2)
    {
      iilIIiiiliIl.\u0002\u2000 obj1 = new iilIIiiiliIl.\u0002\u2000();
      obj1.\u0002 = this;
      iilIIiiiliIl.\u0002\u2000 obj2 = obj1;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = \u0008\u2004\u2001.\u0002(-1745282533);
      saveFileDialog.FileName = string.Empty;
      obj2.\u0003 = saveFileDialog;
      obj1.\u0003.FileOk += new CancelEventHandler(obj1.\u0002);
      obj1.\u0003.ShowDialog();
    }

    private void \u0006\u2000(object _param1, RoutedEventArgs _param2)
    {
      if (iilIIiiiliIl.\u0002\u2001.IsBusy || this.\u0008.\u0002() != 0)
        return;
      iilIIiiiliIl.\u0002\u2001.RunWorkerAsync();
    }

    private void \u000E\u2000(object _param1, RoutedEventArgs _param2)
    {
      if (this.\u000F || this.\u0002\u2000)
        return;
      this.\u000F = true;
      this.\u0002\u2000 = true;
      this.\u0006\u2004.Content = (object) \u0008\u2003\u2001.\u0008.\u0005.\u0006\u2001.\u000E;
      iilIIiiiliIl.\u0003\u2001.RunWorkerAsync();
    }

    private void \u000F\u2000(object _param1, RoutedEventArgs _param2) => this.\u0002(this.\u000F\u2002.\u0002());

    private void \u0002\u2001(object _param1, RoutedEventArgs _param2)
    {
      if (this.\u0002\u2003.SelectedIndex == -1)
        return;
      try
      {
        this.\u0002(File.ReadAllText(Path.Combine(this.\u000E\u2000, this.\u0002\u2003.Items[this.\u0002\u2003.SelectedIndex].ToString())));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745281534), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      }
    }

    private void \u0003\u2001(object _param1, RoutedEventArgs _param2)
    {
      if (this.\u0002\u2003.SelectedIndex == -1)
        return;
      try
      {
        this.\u000F\u2002.\u0003(File.ReadAllText(Path.Combine(this.\u000E\u2000, this.\u0002\u2003.Items[this.\u0002\u2003.SelectedIndex].ToString())));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745281534), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      }
    }

    private void \u0002(object _param1, FileSystemEventArgs _param2) => this.Dispatcher.Invoke(new Action(this.\u0002\u2000));

    private void \u0002(object _param1, RenamedEventArgs _param2) => this.Dispatcher.Invoke(new Action(this.\u0003\u2000));

    private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_XmT>`lH';", objArray);
    }

    public void \u0005()
    {
      object[] objArray = new object[1]{ (object) this };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_Vb.)`lH';", objArray);
    }

    private void \u0003(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_RVP?`lH$:", objArray);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this.\u000E\u2004)
        return;
      this.\u000E\u2004 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745281992), UriKind.Relative));
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal Delegate \u0002(Type _param1, string _param2) => Delegate.CreateDelegate(_param1, (object) this, _param2);

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.beube9huqgaz9rkx3629hdruwcm9zgsa\u2003\u2004\u2000\u2001\u0002(
      int _param1,
      object _param2)
    {
      switch (_param1)
      {
        case 1:
          ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0002);
          ((FrameworkElement) _param2).Loaded += new RoutedEventHandler(this.\u0002);
          ((Window) _param2).Closing += new CancelEventHandler(this.\u0002);
          ((Window) _param2).StateChanged += new EventHandler(this.\u0002);
          break;
        case 2:
          this.\u0006\u2001 = (Grid) _param2;
          break;
        case 3:
          this.\u000E\u2001 = (Label) _param2;
          break;
        case 4:
          this.\u000F\u2001 = (Button) _param2;
          this.\u000F\u2001.Click += new RoutedEventHandler(this.\u0005);
          break;
        case 5:
          this.\u0002\u2002 = (Button) _param2;
          this.\u0002\u2002.Click += new RoutedEventHandler(this.\u000E);
          break;
        case 6:
          this.\u0003\u2002 = (Button) _param2;
          this.\u0003\u2002.Click += new RoutedEventHandler(this.\u000F);
          break;
        case 7:
          this.\u0005\u2002 = (Button) _param2;
          this.\u0005\u2002.Click += new RoutedEventHandler(this.\u0006);
          break;
        case 8:
          this.\u0008\u2002 = (Image) _param2;
          this.\u0008\u2002.MouseLeftButtonDown += new MouseButtonEventHandler(this.\u0003);
          break;
        case 9:
          this.\u0006\u2002 = (Grid) _param2;
          break;
        case 10:
          this.\u000E\u2002 = (TabControl) _param2;
          this.\u000E\u2002.SelectionChanged += new SelectionChangedEventHandler(this.\u0002);
          break;
        case 11:
          this.\u000F\u2002 = (\u002D.ii1i1i1IIlll) _param2;
          break;
        case 12:
          this.\u0002\u2003 = (ListBox) _param2;
          break;
        case 13:
          this.\u0003\u2003 = (MenuItem) _param2;
          this.\u0003\u2003.Click += new RoutedEventHandler(this.\u0002\u2001);
          break;
        case 14:
          this.\u0005\u2003 = (MenuItem) _param2;
          this.\u0005\u2003.Click += new RoutedEventHandler(this.\u0003\u2001);
          break;
        case 15:
          this.\u0008\u2003 = (Grid) _param2;
          break;
        case 16:
          this.\u0006\u2003 = (Button) _param2;
          this.\u0006\u2003.Click += new RoutedEventHandler(this.\u000F\u2000);
          break;
        case 17:
          this.\u000E\u2003 = (Button) _param2;
          this.\u000E\u2003.Click += new RoutedEventHandler(this.\u0002\u2000);
          break;
        case 18:
          this.\u000F\u2003 = (Button) _param2;
          this.\u000F\u2003.Click += new RoutedEventHandler(this.\u0003\u2000);
          break;
        case 19:
          this.\u0002\u2004 = (Button) _param2;
          this.\u0002\u2004.Click += new RoutedEventHandler(this.\u0005\u2000);
          break;
        case 20:
          this.\u0003\u2004 = (Button) _param2;
          this.\u0003\u2004.Click += new RoutedEventHandler(this.\u0008\u2000);
          break;
        case 21:
          this.\u0005\u2004 = (Button) _param2;
          this.\u0005\u2004.Click += new RoutedEventHandler(this.\u0008);
          break;
        case 22:
          this.\u0008\u2004 = (Button) _param2;
          this.\u0008\u2004.Click += new RoutedEventHandler(this.\u0006\u2000);
          break;
        case 23:
          this.\u0006\u2004 = (Button) _param2;
          this.\u0006\u2004.Click += new RoutedEventHandler(this.\u000E\u2000);
          break;
        default:
          this.\u000E\u2004 = true;
          break;
      }
    }

    private void \u0005\u2001(object _param1, RoutedEventArgs _param2) => this.\u000E\u2002.\u0003<Button>(\u0008\u2004\u2001.\u0002(-1745284131)).Click += new RoutedEventHandler(this.\u0003);

    private void \u0002(\u000E\u2003\u2001 _param1)
    {
      if (!\u0008\u2003\u2001.\u000E.\u0003 || \u0008\u2003\u2001.\u000E.\u0005)
        return;
      this.\u0005.\u0002(Convert.ToInt32(_param1.\u0003​\u2007\u2008\u200A\u2001\u2007\u200A​\u2000​\u2005\u2005\u2002\u2009\u2001\u2007\u2004()));
      iilIIiiiliIl.\u0002\u2001.RunWorkerAsync();
    }

    private void \u0008()
    {
      while (true)
      {
        do
        {
          Thread.Sleep(60000);
        }
        while (this.\u0005\u2000);
        this.\u0002();
      }
    }

    private void \u0006()
    {
      if (\u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745284160)))
      {
        try
        {
          \u0003\u2003\u2001.\u0003\u2000 obj1 = \u0005\u2002\u2001.\u0003<\u0003\u2003\u2001.\u0003\u2000>(\u0008\u2004\u2001.\u0002(-1745284160));
          int num1 = 0;
          for (int index = 0; index < obj1.\u0002.Count; ++index)
          {
            \u0003\u2003\u2001.\u0002\u2000 obj2 = obj1.\u0002[index];
            int num2 = obj1.\u0003 == index ? 1 : 0;
            string str = obj2.\u0002 ? obj2.\u0006 : (string) null;
            \u0002\u2002\u2001 obj3 = num2 != 0 ? this.\u0002(true, str, obj2.\u0008, obj2.\u000E) : this.\u0002(false, str, (string) null, obj2.\u000E);
            obj3.\u0008 = obj2.\u0008;
            obj3.\u0002 = obj2.\u0002;
            obj3.\u0003 = obj2.\u0003;
            obj3.\u0005 = obj2.\u0005;
            if (obj2.\u0002)
              ++num1;
          }
          this.\u0005\u2001 = obj1.\u0002.Count - num1;
        }
        catch (Exception ex)
        {
          \u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745284160));
          this.\u0002(true, (string) null, string.Empty, (string) null);
        }
      }
      else
        this.\u0002(true, (string) null, string.Empty, (string) null);
      if (string.IsNullOrWhiteSpace(\u0008\u2003\u2001.\u000E.\u0006\u2000))
      {
        \u0008\u2003\u2001.\u000E.\u0006\u2000 = \u0008\u2004\u2001.\u0002(-1745259772);
        \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0008>(\u0008\u2004\u2001.\u0002(-1745259754), new \u0003\u2003\u2001.\u0008()
        {
          \u0002 = 10U,
          \u0003 = JsonConvert.SerializeObject((object) \u0008\u2003\u2001.\u000E)
        });
      }
      this.\u000F\u2002.\u0002((char.ToLower(\u0008\u2003\u2001.\u000E.\u0006\u2000[0]).ToString() + \u0008\u2003\u2001.\u000E.\u0006\u2000.Substring(1)).Replace('-', '_'));
    }

    private void \u000E() => this.\u0003\u2000((object) null, (RoutedEventArgs) null);

    private void \u000F()
    {
      if (this.\u000E\u2002.SelectedIndex == -1)
        return;
      \u0003\u2003\u2001.\u0003\u2000 obj1 = new \u0003\u2003\u2001.\u0003\u2000()
      {
        \u0002 = new List<\u0003\u2003\u2001.\u0002\u2000>()
      };
      foreach (object obj2 in (IEnumerable) this.\u000E\u2002.Items)
      {
        if (obj2 is \u0002\u2002\u2001 obj3 && obj3.Header is string header)
          obj1.\u0002.Add(new \u0003\u2003\u2001.\u0002\u2000()
          {
            \u0008 = obj3.\u0008,
            \u0006 = header,
            \u0002 = obj3.\u0002,
            \u000E = obj3.\u0006,
            \u0003 = obj3.\u0003,
            \u0005 = obj3.\u0005
          });
      }
      obj1.\u0003 = this.\u000E\u2002.SelectedIndex;
      obj1.\u0002[this.\u000E\u2002.SelectedIndex].\u0008 = this.\u000F\u2002.\u0002();
      if (this.\u0008\u2001 == null)
      {
        this.\u0008\u2001 = obj1;
        \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0003\u2000>(\u0008\u2004\u2001.\u0002(-1745284160), obj1);
      }
      else
      {
        if (this.\u0008\u2001.\u0003 != obj1.\u0003 || this.\u0008\u2001.\u0002.Count != obj1.\u0002.Count)
        {
          \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0003\u2000>(\u0008\u2004\u2001.\u0002(-1745284160), obj1);
        }
        else
        {
          for (int index = 0; index < obj1.\u0002.Count; ++index)
          {
            if (!obj1.\u0002[index].\u0002(this.\u0008\u2001.\u0002[index]))
            {
              \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0003\u2000>(\u0008\u2004\u2001.\u0002(-1745284160), obj1);
              break;
            }
          }
        }
        this.\u0008\u2001 = obj1;
      }
    }

    private void \u0002\u2000()
    {
      this.\u0002\u2003.Items.Clear();
      foreach (string file in Directory.GetFiles(this.\u000E\u2000))
        this.\u0002\u2003.Items.Add((object) Path.GetFileName(file));
    }

    private void \u0003\u2000()
    {
      this.\u0002\u2003.Items.Clear();
      foreach (string file in Directory.GetFiles(this.\u000E\u2000))
        this.\u0002\u2003.Items.Add((object) Path.GetFileName(file));
    }

    private void \u0005\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261427), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0008\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261559), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0006\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u000E\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u000F\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0002\u2001()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0003\u2001()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263685), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0005\u2001()
    {
      this.\u0002(iilIIiiiliIl.\u0008\u2000.\u000E, 3000);
      iilIIiiiliIl.\u0008\u2000 obj = this.\u0003;
      if (obj == null)
        return;
      obj((object) this, \u0008\u2004\u2001.\u0002(-1745282718));
    }

    private void \u0008\u2001()
    {
      this.\u0002(iilIIiiiliIl.\u0008\u2000.\u0003\u2000, 3000);
      iilIIiiiliIl.\u0008\u2000 obj = this.\u0003;
      if (obj == null)
        return;
      obj((object) this, \u0008\u2004\u2001.\u0002(-1745282805));
    }

    private sealed class \u0002
    {
      public StreamReader \u0002;
      public StreamReader \u0003;
      public \u0006\u2002\u2001.\u0003\u2001 \u0005;
      public iilIIiiiliIl \u0008;

      internal void \u0002(\u000E\u2003\u2001 _param1)
      {
        if ((long) _param1.\u0003​\u2007\u2008\u200A\u2001\u2007\u200A​\u2000​\u2005\u2005\u2002\u2009\u2001\u2007\u2004() != (long) this.\u0008.\u0008.\u0002())
          return;
        this.\u0002?.Close();
      }

      internal void \u0002()
      {
        PipeSecurity pipeSecurity = new PipeSecurity();
        PipeAccessRule rule = new PipeAccessRule((IdentityReference) new SecurityIdentifier(WellKnownSidType.WorldSid, (SecurityIdentifier) null), PipeAccessRights.ReadWrite, AccessControlType.Allow);
        pipeSecurity.AddAccessRule(rule);
        NamedPipeServerStream pipeServerStream = new NamedPipeServerStream(\u0008\u2004\u2001.\u0002(-1745282246), PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, pipeSecurity);
        pipeServerStream.WaitForConnection();
        this.\u0002 = new StreamReader((Stream) pipeServerStream);
        while (true)
        {
          string str;
          do
          {
            try
            {
              str = this.\u0002.ReadLine();
            }
            catch (Exception ex)
            {
              str = \u0008\u2004\u2001.\u0002(-1745282261);
            }
            if (string.IsNullOrWhiteSpace(str))
              str = \u0008\u2004\u2001.\u0002(-1745282261);
            iilIIiiiliIl.\u0008\u2000 obj = this.\u0008.\u0003;
            if (obj != null)
              obj((object) this.\u0008, str);
          }
          while (str != \u0008\u2004\u2001.\u0002(-1745282337) && str != \u0008\u2004\u2001.\u0002(-1745282353) && str != \u0008\u2004\u2001.\u0002(-1745282261));
          this.\u0002.Close();
          pipeServerStream.Close();
          Thread.Sleep(3000);
          pipeServerStream = new NamedPipeServerStream(\u0008\u2004\u2001.\u0002(-1745282246), PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, pipeSecurity);
          pipeServerStream.WaitForConnection();
          this.\u0002 = new StreamReader((Stream) pipeServerStream);
        }
      }

      internal void \u0003()
      {
        PipeSecurity pipeSecurity = new PipeSecurity();
        PipeAccessRule rule = new PipeAccessRule((IdentityReference) new SecurityIdentifier(WellKnownSidType.WorldSid, (SecurityIdentifier) null), PipeAccessRights.ReadWrite, AccessControlType.Allow);
        pipeSecurity.AddAccessRule(rule);
        NamedPipeServerStream pipeServerStream = new NamedPipeServerStream(\u0008\u2004\u2001.\u0002(-1745282328), PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, pipeSecurity);
        pipeServerStream.WaitForConnection();
        this.\u0003 = new StreamReader((Stream) pipeServerStream);
        while (true)
        {
          string str1;
          string str2;
          do
          {
            string str3;
            try
            {
              str3 = this.\u0003.ReadLine();
            }
            catch (Exception ex)
            {
              str3 = \u0008\u2004\u2001.\u0002(-1745282261);
            }
            string str4;
            if (str3 == null)
              str4 = (string) null;
            else
              str4 = str3.Split('|')[0];
            string str5 = \u0008\u2004\u2001.\u0002(-1745282329);
            if (str4 == str5)
              this.\u0008.\u0008.\u0002(int.Parse(str3.Split('|')[1]));
            if (str3 == null)
              str1 = (string) null;
            else
              str1 = str3.Split('|')[0];
            str2 = \u0008\u2004\u2001.\u0002(-1745282329);
          }
          while (str1 != str2);
          this.\u0003.Close();
          pipeServerStream.Close();
          Thread.Sleep(3000);
          pipeServerStream = new NamedPipeServerStream(\u0008\u2004\u2001.\u0002(-1745282328), PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, pipeSecurity);
          pipeServerStream.WaitForConnection();
          this.\u0003 = new StreamReader((Stream) pipeServerStream);
        }
      }

      internal void \u0002(object _param1, string _param2)
      {
        iilIIiiiliIl.\u0003 obj = new iilIIiiiliIl.\u0003();
        obj.\u0003 = this;
        obj.\u0002 = _param2;
        this.\u0008.Dispatcher.Invoke(new Action(obj.\u0002));
        if (!(obj.\u0002 == \u0008\u2004\u2001.\u0002(-1745282337)))
          return;
        Process[] processesByName = Process.GetProcessesByName(\u0008\u2004\u2001.\u0002(-1745261783));
        int num = this.\u0008.\u0008.\u0002() == 0 ? processesByName[0].Id : this.\u0008.\u0008.\u0002();
        iilIIiiiliIl.\u0006.\u0002(num);
        this.\u0008.\u0008.\u0002(0);
        string str1 = \u0008\u2003\u2001.\u000E.\u0002 ? \u0008\u2004\u2001.\u0002(-1745256641) : \u0008\u2004\u2001.\u0002(-1745256701);
        string str2 = this.\u0005.\u0003.\u0002 ? \u0008\u2004\u2001.\u0002(-1745256641) : \u0008\u2004\u2001.\u0002(-1745256701);
        string str3 = \u0008\u2003\u2001.\u000E.\u0006 ? \u0008\u2004\u2001.\u0002(-1745256641) : \u0008\u2004\u2001.\u0002(-1745256701);
        string str4 = \u0008\u2003\u2001.\u000E.\u000E ? \u0008\u2004\u2001.\u0002(-1745256641) : \u0008\u2004\u2001.\u0002(-1745256701);
        this.\u0008.\u0002(\u0008\u2004\u2001.\u0002(-1745282427) + Path.Combine(this.\u0008.\u0006\u2000, \u0008\u2004\u2001.\u0002(-1745282390)) + \u0008\u2004\u2001.\u0002(-1745256829) + str1 + \u0008\u2004\u2001.\u0002(-1745256829) + str2 + \u0008\u2004\u2001.\u0002(-1745256829) + str3 + \u0008\u2004\u2001.\u0002(-1745256829) + str4);
      }
    }

    private sealed class \u0002\u2000
    {
      public iilIIiiiliIl \u0002;
      public SaveFileDialog \u0003;

      internal void \u0002(object _param1, CancelEventArgs _param2)
      {
        string contents = this.\u0002.\u000F\u2002.\u0002();
        File.WriteAllText(this.\u0003.FileName, contents);
        if (!(this.\u0002.\u000E\u2002.Items[this.\u0002.\u000E\u2002.SelectedIndex] is \u0002\u2002\u2001 obj1))
          return;
        bool flag = obj1.\u0002;
        obj1.\u0005 = contents;
        obj1.\u0002 = true;
        obj1.Header = (object) Path.GetFileName(this.\u0003.FileName);
        obj1.\u0006 = this.\u0003.FileName;
        if (flag)
          return;
        --this.\u0002.\u0005\u2001;
        int num = 1;
        foreach (object obj2 in (IEnumerable) this.\u0002.\u000E\u2002.Items)
        {
          if (obj2 is \u0002\u2002\u2001 obj3 && !obj3.\u0002)
          {
            obj3.Header = (object) string.Format(\u0008\u2004\u2001.\u0002(-1745282519), (object) num);
            ++num;
          }
        }
      }
    }

    private sealed class \u0003
    {
      public string \u0002;
      public iilIIiiiliIl.\u0002 \u0003;

      internal void \u0002()
      {
        string str = this.\u0002;
        if (!(str == \u0008\u2004\u2001.\u0002(-1745282470)))
        {
          if (!(str == \u0008\u2004\u2001.\u0002(-1745282483)))
          {
            if (!(str == \u0008\u2004\u2001.\u0002(-1745282261)))
            {
              if (!(str == \u0008\u2004\u2001.\u0002(-1745282337)) && !(str == \u0008\u2004\u2001.\u0002(-1745282353)))
                return;
              this.\u0003.\u0008.\u0002(iilIIiiiliIl.\u0008\u2000.\u0006, 3000);
            }
            else
            {
              this.\u0003.\u0008.\u0008.\u0002(0);
              this.\u0003.\u0008.\u0002(\u0008\u2004\u2001.\u0002(-1745282448), 3000);
            }
          }
          else
            this.\u0003.\u0008.\u0002(iilIIiiiliIl.\u0008\u2000.\u0008, 0);
        }
        else
          this.\u0003.\u0008.\u0002(iilIIiiiliIl.\u0008\u2000.\u0005, 0);
      }
    }

    private sealed class \u0003\u2000
    {
      public iilIIiiiliIl \u0002;
      public \u0003\u2003\u2001.\u000F \u0003;

      internal void \u0002()
      {
        this.\u0002.\u0002\u2000 = false;
        this.\u0002.\u0006\u2004.Content = (object) \u0008\u2003\u2001.\u0008.\u0005.\u0006\u2001.\u0006;
        new Illi1lIi11i1(this.\u0002, this.\u0003).Show();
      }
    }

    private sealed class \u0005
    {
      public iilIIiiiliIl \u0002;
      public string \u0003;
      public int \u0005;
      public Action \u0008;

      internal void \u0002() => this.\u0002.\u000E\u2001.Content = (object) (\u0006\u2002\u2001.\u0002(\u0008\u2003\u2001.\u0008.\u0005.\u0002\u2000, \u0008\u2003\u2001.\u0002) + this.\u0003);

      internal void \u0003()
      {
        Thread.Sleep(this.\u0005);
        this.\u0002.Dispatcher.Invoke(this.\u0008 ?? (this.\u0008 = new Action(this.\u0005)));
      }

      internal void \u0005() => this.\u0002.\u000E\u2001.Content = (object) \u0006\u2002\u2001.\u0002(\u0008\u2003\u2001.\u0008.\u0005.\u0002\u2000, \u0008\u2003\u2001.\u0002);
    }

    private sealed class \u0005\u2000
    {
      public iilIIiiiliIl \u0002;
      public \u0003\u2002\u2001.\u0002 \u0003;

      internal void \u0002() => this.\u0002.\u0002(iilIIiiiliIl.\u0008\u2000.\u0002, 0);

      internal void \u0003()
      {
        this.\u0002.Topmost = false;
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263768), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
        this.\u0002.Topmost = true;
      }

      internal void \u0005()
      {
        this.\u0002.\u0002(iilIIiiiliIl.\u0008\u2000.\u000E, 3000);
        iilIIiiiliIl.\u0008\u2000 obj = this.\u0002.\u0003;
        if (obj == null)
          return;
        obj((object) this.\u0002, \u0008\u2004\u2001.\u0002(-1745282718));
      }

      internal void \u0008()
      {
        this.\u0002.\u0002(iilIIiiiliIl.\u0008\u2000.\u0003\u2000, 3000);
        iilIIiiiliIl.\u0008\u2000 obj = this.\u0002.\u0003;
        if (obj == null)
          return;
        obj((object) this.\u0002, \u0008\u2004\u2001.\u0002(-1745282805));
      }

      internal void \u0006()
      {
        this.\u0002.\u0002(iilIIiiiliIl.\u0008\u2000.\u0003, 0);
        iilIIiiiliIl.\u0008\u2000 obj = this.\u0002.\u0003;
        if (obj == null)
          return;
        obj((object) this.\u0002, \u0008\u2004\u2001.\u0002(-1745282762));
      }

      internal void \u000E() => this.\u0002.\u0002(\u0008\u2004\u2001.\u0002(-1745282854), 3000);

      internal void \u000F() => this.\u0002.\u0002(string.Format(\u0008\u2004\u2001.\u0002(-1745282848), (object) (int) this.\u0003), 3000);
    }

    private sealed class \u0006
    {
      public iilIIiiiliIl \u0002;
      public \u0002\u2002\u2001 \u0003;
      public string \u0005;

      internal void \u0002()
      {
        if (this.\u0002.\u000E\u2002.SelectedIndex == -1 || !(this.\u0002.\u000E\u2002.Items[this.\u0002.\u000E\u2002.SelectedIndex] is \u0002\u2002\u2001 obj))
          return;
        this.\u0003 = obj;
      }

      internal void \u0003() => this.\u0003.Header = (object) this.\u0003.\u0003;

      internal void \u0005()
      {
        iilIIiiiliIl.\u000E obj1 = new iilIIiiiliIl.\u000E();
        obj1.\u0003 = this;
        iilIIiiiliIl.\u000E obj2 = obj1;
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = \u0008\u2004\u2001.\u0002(-1745282533);
        saveFileDialog.FileName = string.Empty;
        obj2.\u0002 = saveFileDialog;
        obj1.\u0002.FileOk += new CancelEventHandler(obj1.\u0002);
        obj1.\u0002.ShowDialog();
      }
    }

    private sealed class \u0008
    {
      public iilIIiiiliIl \u0002;
      public \u0002\u2002\u2001 \u0003;

      internal void \u0002()
      {
        if (this.\u0002.\u000E\u2002.SelectedIndex == -1 || !(this.\u0002.\u000E\u2002.Items[this.\u0002.\u000E\u2002.SelectedIndex] is \u0002\u2002\u2001 obj))
          return;
        this.\u0003 = obj;
      }

      internal void \u0003() => this.\u0003.Header = (object) (this.\u0003.\u0003 + \u0008\u2004\u2001.\u0002(-1745268153));

      internal void \u0005() => this.\u0003.Header = (object) this.\u0003.\u0003;
    }

    public delegate void \u0008\u2000(object _param1, string _param2);

    private sealed class \u000E
    {
      public SaveFileDialog \u0002;
      public iilIIiiiliIl.\u0006 \u0003;

      internal void \u0002(object _param1, CancelEventArgs _param2)
      {
        File.WriteAllText(this.\u0002.FileName, this.\u0003.\u0005);
        int num1 = this.\u0003.\u0003.\u0002 ? 1 : 0;
        this.\u0003.\u0003.\u0005 = this.\u0003.\u0005;
        this.\u0003.\u0003.\u0002 = true;
        this.\u0003.\u0003.Header = (object) Path.GetFileName(this.\u0002.FileName);
        this.\u0003.\u0003.\u0006 = this.\u0002.FileName;
        if (num1 != 0)
          return;
        --this.\u0003.\u0002.\u0005\u2001;
        int num2 = 1;
        foreach (object obj1 in (IEnumerable) this.\u0003.\u0002.\u000E\u2002.Items)
        {
          if (obj1 is \u0002\u2002\u2001 obj2 && !obj2.\u0002)
          {
            obj2.Header = (object) string.Format(\u0008\u2004\u2001.\u0002(-1745282519), (object) num2);
            ++num2;
          }
        }
      }
    }

    private sealed class \u000F
    {
      public bool \u0002;
      public iilIIiiiliIl \u0003;
      public int \u0005;
      public string \u0008;
      public \u0002\u2002\u2001 \u0006;
      public RoutedEventHandler \u000E;

      internal void \u0002(object _param1, RoutedEventArgs _param2)
      {
        if (this.\u0002)
          this.\u0003.\u000E\u2002.SelectedIndex = this.\u0005;
        if (this.\u0008 != null)
          this.\u0003.\u000F\u2002.\u0003(this.\u0008);
        this.\u0006.\u0003<Button>(\u0008\u2004\u2001.\u0002(-1745282598)).Click += this.\u000E ?? (this.\u000E = new RoutedEventHandler(this.\u0003));
      }

      internal void \u0003(object _param1, RoutedEventArgs _param2)
      {
        if (this.\u0003.\u000E\u2002.Items.Count == 1)
          return;
        if (\u0008\u2003\u2001.\u000E.\u0003\u2000)
        {
          if (this.\u0006.\u0002 && this.\u0006.\u0005 != this.\u0003.\u000F\u2002.\u0002())
          {
            if (MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745282612), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No) != MessageBoxResult.Yes)
              return;
          }
          else if (!this.\u0006.\u0002 && !string.IsNullOrWhiteSpace(this.\u0003.\u000F\u2002.\u0002()) && MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745282626), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No) != MessageBoxResult.Yes)
            return;
        }
        this.\u0003.\u000E\u2002.Items.Remove((object) this.\u0006);
        if (this.\u0006.\u0002)
          return;
        --this.\u0003.\u0005\u2001;
        int num = 1;
        foreach (object obj1 in (IEnumerable) this.\u0003.\u000E\u2002.Items)
        {
          if (obj1 is \u0002\u2002\u2001 obj2 && !obj2.\u0002)
          {
            obj2.Header = (object) string.Format(\u0008\u2004\u2001.\u0002(-1745282519), (object) num);
            ++num;
          }
        }
      }
    }
  }
}
