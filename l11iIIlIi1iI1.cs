// Decompiled with JetBrains decompiler
// Type: -.l11iIIlIi1iI1
// Assembly: SUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C75052F-567C-4717-00F4-FF7442A55C0D
// Assembly location: C:\Users\karol\OneDrive\Desktop\Pastenapse\zK8AAg5yJoW_dump.exe

using \u002D;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace \u002D
{
  public sealed class l11iIIlIi1iI1 : Window, IComponentConnector
  {
    public static \u0006\u2002\u2001.\u0008\u2000 \u0002;
    public static BackgroundWorker \u0003 = new BackgroundWorker();
    internal Grid \u0005;
    internal Label \u0008;
    internal Image \u0006;
    internal Label \u000E;
    internal ProgressBar \u000F;
    private bool \u0002\u2000;

    public l11iIIlIi1iI1()
    {
      AppDomain.CurrentDomain.UnhandledException += l11iIIlIi1iI1.\u0002.\u0003 ?? (l11iIIlIi1iI1.\u0002.\u0003 = new UnhandledExceptionEventHandler(l11iIIlIi1iI1.\u0002.\u0002.\u0002));
      try
      {
        Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(\u0006\u2003\u2001.\u0003(\u0008\u2004\u2001.\u0002(-1745257271))));
        Process currentProcess = Process.GetCurrentProcess();
        foreach (Process process in processesByName)
        {
          if (process.Id != currentProcess.Id)
          {
            try
            {
              process.Kill();
            }
            catch (Exception ex)
            {
            }
          }
        }
        if (!File.Exists(\u0008\u2004\u2001.\u0002(-1745270155)))
          File.Copy(\u0008\u2004\u2001.\u0002(-1745257226), \u0008\u2004\u2001.\u0002(-1745270155), true);
        else if (\u0006\u2003\u2001.\u0003(\u0008\u2004\u2001.\u0002(-1745257226), true) != \u0006\u2003\u2001.\u0003(\u0008\u2004\u2001.\u0002(-1745270155), true))
          File.Copy(\u0008\u2004\u2001.\u0002(-1745257226), \u0008\u2004\u2001.\u0002(-1745270155), true);
        string sourceFileName = Path.Combine(\u0008\u2004\u2001.\u0002(-1745257324), Path.GetFileName(AppDomain.CurrentDomain.FriendlyName));
        string str = Path.Combine(\u0008\u2004\u2001.\u0002(-1745257324), \u0006\u2003\u2001.\u0003(\u0008\u2004\u2001.\u0002(-1745257330)));
        if (!File.Exists(str))
          File.Copy(sourceFileName, str, true);
        else if (\u0006\u2003\u2001.\u0003(sourceFileName, true) != \u0006\u2003\u2001.\u0003(str, true))
          File.Copy(sourceFileName, str, true);
        if (Path.GetFileName(AppDomain.CurrentDomain.FriendlyName) != \u0006\u2003\u2001.\u0003(\u0008\u2004\u2001.\u0002(-1745257330)))
        {
          Process.Start(new ProcessStartInfo(str)
          {
            UseShellExecute = false
          });
          Environment.Exit(0);
          return;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745257300) + ex.GetType().Name + \u0008\u2004\u2001.\u0002(-1745257050) + ex.Message + \u0008\u2004\u2001.\u0002(-1745264939), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        Environment.Exit(0);
        return;
      }
      \u0003\u2002\u2001.\u0002();
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      l11iIIlIi1iI1.\u0003.DoWork += new DoWorkEventHandler(this.\u0002);
      this.InitializeComponent();
    }

    public void \u0002(string _param1, int _param2) => this.Dispatcher.Invoke(new Action(new l11iIIlIi1iI1.\u0003()
    {
      \u0002 = this,
      \u0003 = _param1,
      \u0005 = _param2
    }.\u0002));

    private \u0006\u2002\u2001.\u0003 \u0002(\u0006\u2002\u2001.\u0003 _param1)
    {
      _param1.\u0002 = 2U;
      _param1.\u0005.\u0002\u2001 = new \u0006\u2002\u2001.\u0005()
      {
        \u0005 = new \u0006\u2002\u2001.\u0008(byte.MaxValue, (byte) 60, (byte) 60, (byte) 60),
        \u0008 = new \u0006\u2002\u2001.\u0008(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue),
        \u0003 = new \u0006\u2002\u2001.\u000E(\u0008\u2004\u2001.\u0002(-1745269212), 14f),
        \u0002 = new \u0006\u2002\u2001.\u0005\u2000(),
        \u0006 = \u0008\u2004\u2001.\u0002(-1745269640)
      };
      return _param1;
    }

    private void \u0002(object _param1, RoutedEventArgs _param2)
    {
      Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(AppDomain.CurrentDomain.FriendlyName));
      Process currentProcess = Process.GetCurrentProcess();
      foreach (Process process in processesByName)
      {
        if (process.Id != currentProcess.Id)
        {
          try
          {
            process.Kill();
          }
          catch (Exception ex)
          {
          }
        }
      }
      if (!File.Exists(\u0008\u2004\u2001.\u0002(-1745259644)))
        File.WriteAllText(\u0008\u2004\u2001.\u0002(-1745259644), JsonConvert.SerializeObject((object) \u0006\u2002\u2001.\u0002(), (Formatting) 1));
      try
      {
        \u0008\u2003\u2001.\u0008 = JsonConvert.DeserializeObject<\u0006\u2002\u2001.\u0003>(File.ReadAllText(\u0008\u2004\u2001.\u0002(-1745259644)));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745259603) + ex.Message, \u0008\u2004\u2001.\u0002(-1745259671), MessageBoxButton.OK, MessageBoxImage.Hand);
        \u0008\u2003\u2001.\u0008 = \u0006\u2002\u2001.\u0002();
      }
      if (\u0008\u2003\u2001.\u0008.\u0002 != 2U)
      {
        if (\u0008\u2003\u2001.\u0008.\u0002 == 1U)
          \u0008\u2003\u2001.\u0008 = this.\u0002(\u0008\u2003\u2001.\u0008);
        File.WriteAllText(\u0008\u2004\u2001.\u0002(-1745259644), JsonConvert.SerializeObject((object) \u0008\u2003\u2001.\u0008, (Formatting) 1));
      }
      if (!\u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745259754)))
      {
        \u0008\u2003\u2001.\u000E = new \u0003\u2003\u2001.\u0005()
        {
          \u0005 = false,
          \u0003 = false,
          \u0008\u2000 = true,
          \u0005\u2000 = true,
          \u0003\u2000 = true,
          \u0008 = true,
          \u0002\u2000 = true,
          \u0002 = false,
          \u000E = false,
          \u000F = false,
          \u0006 = false,
          \u0006\u2000 = \u0008\u2004\u2001.\u0002(-1745259772),
          \u000E\u2000 = 1.0
        };
        \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0008>(\u0008\u2004\u2001.\u0002(-1745259754), new \u0003\u2003\u2001.\u0008()
        {
          \u0002 = 10U,
          \u0003 = JsonConvert.SerializeObject((object) \u0008\u2003\u2001.\u000E)
        });
      }
      else
      {
        try
        {
          \u0003\u2003\u2001.\u0008 obj = \u0005\u2002\u2001.\u0003<\u0003\u2003\u2001.\u0008>(\u0008\u2004\u2001.\u0002(-1745259754));
          if (obj.\u0002 != 10U)
          {
            \u0008\u2003\u2001.\u000E = new \u0003\u2003\u2001.\u0005()
            {
              \u0005 = false,
              \u0003 = false,
              \u0008\u2000 = true,
              \u0005\u2000 = true,
              \u0003\u2000 = true,
              \u0008 = true,
              \u0002\u2000 = true,
              \u0002 = false,
              \u000E = false,
              \u0006 = false,
              \u000F = false,
              \u0006\u2000 = \u0008\u2004\u2001.\u0002(-1745259772),
              \u000E\u2000 = 1.0
            };
            \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0008>(\u0008\u2004\u2001.\u0002(-1745259754), new \u0003\u2003\u2001.\u0008()
            {
              \u0002 = 10U,
              \u0003 = JsonConvert.SerializeObject((object) \u0008\u2003\u2001.\u000E)
            });
          }
          else
            \u0008\u2003\u2001.\u000E = JsonConvert.DeserializeObject<\u0003\u2003\u2001.\u0005>(obj.\u0003);
        }
        catch (Exception ex)
        {
          \u0008\u2003\u2001.\u000E = new \u0003\u2003\u2001.\u0005()
          {
            \u0005 = false,
            \u0003 = false,
            \u0008\u2000 = true,
            \u0005\u2000 = true,
            \u0003\u2000 = true,
            \u0008 = true,
            \u0002\u2000 = true,
            \u0002 = false,
            \u000E = false,
            \u0006 = false,
            \u000F = false,
            \u0006\u2000 = \u0008\u2004\u2001.\u0002(-1745259772),
            \u000E\u2000 = 1.0
          };
          \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0008>(\u0008\u2004\u2001.\u0002(-1745259754), new \u0003\u2003\u2001.\u0008()
          {
            \u0002 = 10U,
            \u0003 = JsonConvert.SerializeObject((object) \u0008\u2003\u2001.\u000E)
          });
        }
      }
      \u0006\u2002\u2001.\u000F\u2000 obj1 = \u0008\u2003\u2001.\u0008.\u0003;
      \u0006\u2002\u2001.\u0002((Window) this, obj1.\u0002);
      \u0006\u2002\u2001.\u0002(this.\u0006, obj1.\u0005);
      \u0006\u2002\u2001.\u0002(this.\u0008, obj1.\u0006);
      \u0006\u2002\u2001.\u0002(this.\u000E, obj1.\u000E);
      \u0006\u2002\u2001.\u0002(this.\u0005, obj1.\u0008);
      l11iIIlIi1iI1.\u0002 = obj1.\u0003;
      this.Title = \u000E\u2002\u2001.\u0002(\u000E\u2002\u2001.\u0003.Next(10, 32));
      \u0008\u2003\u2001.\u0006 = SynchronizationContext.Current;
      l11iIIlIi1iI1.\u0003.RunWorkerAsync();
    }

    private void \u0002(string _param1)
    {
      object[] objArray = new object[2]
      {
        (object) this,
        (object) _param1
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_@uma`lH$:", objArray);
    }

    private void \u0002(string _param1, string _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        (object) _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_UN#1`lH';", objArray);
    }

    private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3]
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_O@17`lH';", objArray);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this.\u0002\u2000)
        return;
      this.\u0002\u2000 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745261911), UriKind.Relative));
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.t6zcg6hbpabegrpsuf8dh3bd9h4gf3sv\u2003\u2004\u2000\u2001\u0002(
      int _param1,
      object _param2)
    {
      switch (_param1)
      {
        case 1:
          ((FrameworkElement) _param2).Loaded += new RoutedEventHandler(this.\u0002);
          break;
        case 2:
          this.\u0005 = (Grid) _param2;
          break;
        case 3:
          this.\u0008 = (Label) _param2;
          break;
        case 4:
          this.\u0006 = (Image) _param2;
          break;
        case 5:
          this.\u000E = (Label) _param2;
          break;
        case 6:
          this.\u000F = (ProgressBar) _param2;
          break;
        default:
          this.\u0002\u2000 = true;
          break;
      }
    }

    private void \u0002()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0003()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262002), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0005()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262052), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
    }

    private void \u0008()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262097), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
    }

    private void \u0006()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262217), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
    }

    private void \u000E()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262372), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000F()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262365), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0002\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262465), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
    }

    private void \u0003\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262551), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0005\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745260665), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0008\u2000()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0006\u2000()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000E\u2000()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000F\u2000()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745260912), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      new IllliIiiilli().Show();
      this.Close();
    }

    private void \u0002\u2001()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261032), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      new IllliIiiilli().Show();
      this.Close();
    }

    private void \u0003\u2001()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0005\u2001()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261080), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      new I1iIil1Il1II().Show();
      this.Close();
    }

    private void \u0008\u2001()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261267), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0006\u2001()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000E\u2001()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261427), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u000F\u2001()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261479), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0002\u2002()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745261559), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0003\u2002()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0005\u2002()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0008\u2002()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0006\u2002()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263679), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u000E\u2002()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263685), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u000F\u2002()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263768), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      this.Topmost = true;
    }

    private void \u0002\u2003()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0003\u2003()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263897), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0005\u2003()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264187), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0008\u2003()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264369), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.Topmost = true;
    }

    private void \u0006\u2003()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000E\u2003()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264388), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000F\u2003()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264502), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.Topmost = true;
    }

    private void \u0002\u2004()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263897), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0003\u2004()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264187), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0005\u2004()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264574), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      Environment.Exit(0);
    }

    private void \u0008\u2004()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0006\u2004()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263897), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u000E\u2004()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264187), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u000F\u2004()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264369), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.Topmost = true;
    }

    private void \u0002\u2005()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0003\u2005()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264388), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0005\u2005()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264502), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.Topmost = true;
    }

    private void \u0008\u2005()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263897), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0006\u2005()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264187), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u000E\u2005()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263897), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u000F\u2005()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264187), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0002\u2006()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u0003\u2006()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745263897), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0005\u2006()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264187), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      this.Topmost = true;
    }

    private void \u0008\u2006()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264369), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.Topmost = true;
    }

    private void \u0006\u2006()
    {
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000E\u2006()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264388), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Asterisk);
      new l1IllliilI1li().Show();
      this.Close();
    }

    private void \u000F\u2006()
    {
      this.Topmost = false;
      int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264502), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
      this.Topmost = true;
    }

    private void \u0002\u2007()
    {
      this.Topmost = false;
      try
      {
        \u0008\u2002\u2001.\u0005 obj = \u0008\u2002\u2001.\u0002();
        if (obj.\u0002 && obj.\u0003.Length != 0)
          \u0005\u2002\u2001.\u0002<string>(\u0008\u2004\u2001.\u0002(-1745261894), \u0006\u2003\u2001.\u0002(obj.\u0003, false));
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745264635), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      }
      catch (Exception ex)
      {
      }
      this.Topmost = true;
    }

    private void \u0003\u2007()
    {
      try
      {
        new iilIIiiiliIl().Show();
        this.Close();
      }
      catch (Exception ex)
      {
        if (ex.Message.Contains(\u0008\u2004\u2001.\u0002(-1745262651)))
        {
          int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262611), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
          Process.Start(\u0008\u2004\u2001.\u0002(-1745262850));
          Environment.Exit(0);
        }
        int num1 = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745262925) + ex.GetType().Name + \u0008\u2004\u2001.\u0002(-1745257050) + ex.Message + \u0008\u2004\u2001.\u0002(-1745264939), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        Environment.Exit(0);
      }
    }

    [Serializable]
    private sealed class \u0002
    {
      public static readonly l11iIIlIi1iI1.\u0002 \u0002 = new l11iIIlIi1iI1.\u0002();
      public static UnhandledExceptionEventHandler \u0003;
      public static Func<string, int, bool> \u0005;
      public static Func<string, int, bool> \u0008;
      public static Action \u0006;

      internal void \u0002(object _param1, UnhandledExceptionEventArgs _param2)
      {
        Exception exceptionObject = (Exception) _param2.ExceptionObject;
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745256844) + exceptionObject.GetType().Name + \u0008\u2004\u2001.\u0002(-1745257050) + exceptionObject.Message + \u0008\u2004\u2001.\u0002(-1745264939), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Hand);
        Environment.Exit(0);
      }

      internal bool \u0002(string _param1, int _param2) => (uint) (_param2 % 2) > 0U;

      internal bool \u0003(string _param1, int _param2) => (uint) (_param2 % 2) > 0U;

      internal void \u0002()
      {
        int num = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745257121), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      }
    }

    private sealed class \u0003
    {
      public l11iIIlIi1iI1 \u0002;
      public string \u0003;
      public int \u0005;

      internal void \u0002()
      {
        this.\u0002.\u000E.Content = (object) this.\u0003;
        this.\u0002.\u000F.Value = (double) this.\u0005;
      }
    }
  }
}
