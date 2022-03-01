// Decompiled with JetBrains decompiler
// Type: -.IiIIIiIi11lI
// Assembly: SUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C75052F-567C-4717-00F4-FF7442A55C0D
// Assembly location: C:\Users\karol\OneDrive\Desktop\Pastenapse\zK8AAg5yJoW_dump.exe

using \u002D;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace \u002D
{
  public sealed class IiIIIiIi11lI : Window, IComponentConnector
  {
    private readonly iilIIiiiliIl \u0002;
    private string \u0003;
    private bool \u0005;
    private bool \u0008;
    internal Image \u0006;
    internal CheckBox \u000E;
    internal CheckBox \u000F;
    internal CheckBox \u0002\u2000;
    internal CheckBox \u0003\u2000;
    internal CheckBox \u0005\u2000;
    internal CheckBox \u0008\u2000;
    internal CheckBox \u0006\u2000;
    internal CheckBox \u000E\u2000;
    internal Label \u000F\u2000;
    internal ComboBox \u0002\u2001;
    internal Button \u0003\u2001;
    private bool \u0005\u2001;

    public IiIIIiIi11lI(iilIIiiiliIl _param1)
    {
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      this.InitializeComponent();
      this.\u0002 = _param1;
      this.\u0002.\u000E = true;
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
      this.\u0005 = \u0008\u2003\u2001.\u000E.\u0008;
      this.\u0008 = \u0008\u2003\u2001.\u000E.\u0005;
      this.\u0003 = \u0008\u2003\u2001.\u000E.\u0006\u2000;
      this.\u000F.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0005);
      this.\u0002\u2000.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0003);
      this.\u0003\u2000.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0003\u2000);
      this.\u0005\u2000.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0005\u2000);
      this.\u000E.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0002);
      this.\u0008\u2000.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0006);
      this.\u0006\u2000.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0008);
      this.\u000E\u2000.IsChecked = new bool?(\u0008\u2003\u2001.\u000E.\u0008\u2000);
      foreach (object obj in (IEnumerable) this.\u0002\u2001.Items)
      {
        if (!(obj is ComboBoxItem comboBoxItem) || !(comboBoxItem.Content is string content))
          break;
        if (!(content != \u0008\u2003\u2001.\u000E.\u0006\u2000))
          this.\u0002\u2001.SelectedIndex = this.\u0002\u2001.Items.IndexOf(obj);
      }
    }

    private void \u0002(object _param1, SelectionChangedEventArgs _param2)
    {
      if (this.\u0002\u2001.SelectedIndex == -1 || !(this.\u0002\u2001.Items[this.\u0002\u2001.SelectedIndex] is ComboBoxItem comboBoxItem) || !(comboBoxItem.Content is string content))
        return;
      this.\u0003 = content;
      this.\u0002.\u000F\u2002.\u0002((char.ToLower(content[0]).ToString() + content.Substring(1)).Replace('-', '_'));
    }

    private void \u0003(object _param1, RoutedEventArgs _param2)
    {
      bool? isChecked1 = this.\u000F.IsChecked;
      bool flag1 = this.\u0008;
      if (isChecked1.GetValueOrDefault() == flag1 & isChecked1.HasValue)
        return;
      MessageBoxResult messageBoxResult = MessageBoxResult.Yes;
      bool? isChecked2 = this.\u000F.IsChecked;
      bool flag2 = true;
      if (isChecked2.GetValueOrDefault() == flag2 & isChecked2.HasValue)
        messageBoxResult = MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284111), \u0008\u2004\u2001.\u0002(-1745284301), MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No);
      if (messageBoxResult == MessageBoxResult.Yes)
        return;
      this.\u000F.IsChecked = new bool?(this.\u0008);
    }

    private void \u0005(object _param1, RoutedEventArgs _param2)
    {
      \u0008\u2003\u2001.\u000E = new \u0003\u2003\u2001.\u0005()
      {
        \u0003 = this.\u0002\u2000.IsChecked.Value,
        \u0005 = this.\u000F.IsChecked.Value,
        \u0008 = this.\u0006\u2000.IsChecked.Value,
        \u0002 = this.\u000E.IsChecked.Value,
        \u0006 = this.\u0008\u2000.IsChecked.Value,
        \u0003\u2000 = this.\u0003\u2000.IsChecked.Value,
        \u0005\u2000 = this.\u0005\u2000.IsChecked.Value,
        \u0008\u2000 = this.\u000E\u2000.IsChecked.Value,
        \u000E = false,
        \u000F = false,
        \u0006\u2000 = this.\u0003
      };
      \u0005\u2002\u2001.\u0002<\u0003\u2003\u2001.\u0008>(\u0008\u2004\u2001.\u0002(-1745259754), new \u0003\u2003\u2001.\u0008()
      {
        \u0002 = 10U,
        \u0003 = JsonConvert.SerializeObject((object) \u0008\u2003\u2001.\u000E)
      });
      int num1 = this.\u0008 ? 1 : 0;
      bool? isChecked1 = this.\u000F.IsChecked;
      int num2 = isChecked1.GetValueOrDefault() ? 1 : 0;
      bool? isChecked2;
      if (!(num1 == num2 & isChecked1.HasValue))
      {
        try
        {
          RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(\u0008\u2004\u2001.\u0002(-1745259391), true);
          string str1 = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName);
          if (registryKey == null)
            throw new Exception(\u0008\u2004\u2001.\u0002(-1745259432));
          isChecked2 = this.\u000F.IsChecked;
          if (isChecked2.GetValueOrDefault() & isChecked2.HasValue)
          {
            string str2 = ((IEnumerable<string>) ((string) registryKey.GetValue(string.Empty)).Split('"')).Where<string>(IiIIIiIi11lI.\u0002.\u0003 ?? (IiIIIiIi11lI.\u0002.\u0003 = new Func<string, int, bool>(IiIIIiIi11lI.\u0002.\u0002.\u0002))).ToArray<string>()[0];
            registryKey.SetValue(string.Empty, (object) (\u0008\u2004\u2001.\u0002(-1745270346) + str1 + \u0008\u2004\u2001.\u0002(-1745259455) + \u0008\u2003\u2001.\u0003 + \u0008\u2004\u2001.\u0002(-1745259399)));
            \u0005\u2002\u2001.\u0002<string>(\u0008\u2004\u2001.\u0002(-1745259404), str2);
          }
          else
          {
            if (!\u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745259404)))
            {
              int num3 = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284400), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
              this.\u0002.\u000E = false;
              this.Close();
              return;
            }
            registryKey.SetValue(string.Empty, (object) (\u0008\u2004\u2001.\u0002(-1745270346) + \u0005\u2002\u2001.\u0003<string>(\u0008\u2004\u2001.\u0002(-1745259404)) + \u0008\u2004\u2001.\u0002(-1745259399)));
            \u0005\u2002\u2001.\u0002(\u0008\u2004\u2001.\u0002(-1745259404));
          }
        }
        catch (Exception ex)
        {
          int num4 = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284462) + (this.\u000F.IsChecked.Value ? \u0008\u2004\u2001.\u0002(-1745284432) : \u0008\u2004\u2001.\u0002(-1745284477)) + \u0008\u2004\u2001.\u0002(-1745284436), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
          return;
        }
      }
      int num5 = this.\u0005 ? 1 : 0;
      isChecked2 = this.\u0006\u2000.IsChecked;
      int num6 = isChecked2.GetValueOrDefault() ? 1 : 0;
      if (!(num5 == num6 & isChecked2.HasValue))
      {
        iilIIiiiliIl iilIiiiiliIl = this.\u0002;
        isChecked2 = this.\u0006\u2000.IsChecked;
        int num7 = isChecked2.Value ? 1 : 0;
        iilIiiiiliIl.Topmost = num7 != 0;
      }
      if (this.\u0002.\u0002())
      {
        int num8 = (int) MessageBox.Show(\u0008\u2004\u2001.\u0002(-1745284490), \u0008\u2004\u2001.\u0002(-1745267460), MessageBoxButton.OK, MessageBoxImage.Exclamation);
      }
      this.\u0002.\u000E = false;
      this.Close();
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this.\u0005\u2001)
        return;
      this.\u0005\u2001 = true;
      Application.LoadComponent((object) this, new Uri(\u0008\u2004\u2001.\u0002(-1745284557), UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.\u0036q24gslmy8qcjanj4b29e7l3tcacw6h8\u2003\u2004\u2000\u2001\u0002(
      int _param1,
      object _param2)
    {
      switch (_param1)
      {
        case 1:
          ((UIElement) _param2).MouseDown += new MouseButtonEventHandler(this.\u0002);
          ((FrameworkElement) _param2).Loaded += new RoutedEventHandler(this.\u0002);
          break;
        case 2:
          this.\u0006 = (Image) _param2;
          break;
        case 3:
          this.\u000E = (CheckBox) _param2;
          break;
        case 4:
          this.\u000F = (CheckBox) _param2;
          this.\u000F.Click += new RoutedEventHandler(this.\u0003);
          break;
        case 5:
          this.\u0002\u2000 = (CheckBox) _param2;
          break;
        case 6:
          this.\u0003\u2000 = (CheckBox) _param2;
          break;
        case 7:
          this.\u0005\u2000 = (CheckBox) _param2;
          break;
        case 8:
          this.\u0008\u2000 = (CheckBox) _param2;
          break;
        case 9:
          this.\u0006\u2000 = (CheckBox) _param2;
          break;
        case 10:
          this.\u000E\u2000 = (CheckBox) _param2;
          break;
        case 11:
          this.\u000F\u2000 = (Label) _param2;
          break;
        case 12:
          this.\u0002\u2001 = (ComboBox) _param2;
          this.\u0002\u2001.SelectionChanged += new SelectionChangedEventHandler(this.\u0002);
          break;
        case 13:
          this.\u0003\u2001 = (Button) _param2;
          this.\u0003\u2001.Click += new RoutedEventHandler(this.\u0005);
          break;
        default:
          this.\u0005\u2001 = true;
          break;
      }
    }

    [Serializable]
    private sealed class \u0002
    {
      public static readonly IiIIIiIi11lI.\u0002 \u0002 = new IiIIIiIi11lI.\u0002();
      public static Func<string, int, bool> \u0003;

      internal bool \u0002(string _param1, int _param2) => (uint) (_param2 % 2) > 0U;
    }
  }
}
