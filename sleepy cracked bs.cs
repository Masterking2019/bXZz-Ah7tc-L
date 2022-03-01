 
 
 //Create a istance mabye f0r kernel???, still trying t0 find 0ut.
 protected override object CreateInstance(Type _param1, CultureInfo _param2) => Activator.CreateInstance(_param1, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, (object[]) null, _param2);
 
 //Get pr0perty value m0st likely t0 read fr0m kernel and c0municate, still unsure....
 protected override object GetPropertyValue(
      PropertyInfo _param1,
      object _param2,
      CultureInfo _param3)
    {
      return _param1.GetValue(_param2, BindingFlags.Default, (Binder) null, (object[]) null, _param3);
    }

	
	//every message sended fr0m the switch,m0st likely err0rs and hwid pr0blems 0r wr0ng pass and username smh.....
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
	  
	  //heres the switch f0r pr0brably f0r calling the v0ids up, f0r err0rs and 0ther types 0f shit
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
	  
	  //functi0n using arrays, smt t0 set 0ther stuff
	  private void \u0002(object _param1, DoWorkEventArgs _param2)
    {
      object[] objArray = new object[3] //<<<<<<
      {
        (object) this,
        _param1,
        (object) _param2
      };
      \u000F\u2004\u2001.\u0005\u2005\u2001().\u0002(\u000F\u2004\u2001.\u0008\u2005\u2001(), "_HZ3>`lH$:", objArray);
    }
	
	//using same array but cant use it 0utside s0 its p0intless
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
	
	//ulala backgr0und w0rKer this is sm g00d shit indeed,d0es w0rk in the back while d0ing 0ther stuff,unsure tf it d0es
	public BackgroundWorker \u0002 = new BackgroundWorker();
	
	//changes registry keys f0r the kernel driver, its p0intless with0ut the full part 0f it
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
      this.Close(); //interesting
    }