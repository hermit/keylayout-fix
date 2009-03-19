// TODO
// * 「候補のすべてをDvorakにする」ボタン
// * 「候補のすべてをQWERTYにする」ボタン
// * このエントリについて regedit.exe を起動
// * [OK] [Cancel] [Apply]

// * undo (セーブする前の状態に)
// * 自分用のentryを新規作成 (Dvorak + IME等)

// kbddv us usx jpn

// エントリのキー(ID、E0200411等)は、以下のように一つのIDに環境によって違うIMEが割り当てられているようである。

// * 確認されている日本語エントリ
//
// 00000411 "Layout File", "KBDJPN.DLL"
// 00000411 "Layout Text", "日本語"
// 00000411 "Layout Display Name", "@%SystemRoot%\system32\input.dll,-5061"
//
// E0010411 "Layout File", "Kbdjpn.dll"
// E0010411 "Layout Text", "日本語"
// E0010411 "Layout Display Name", "@%SystemRoot%\system32\input.dll,-5062"
// E0010411 "IME File", "imjp81.ime"
//
// e0200411 "Layout File", "kbdjpn.dll" 
// e0200411 "Layout Text", "Microsoft IME Standard 2002" 
// e0200411 "IME File", "IMJP8.IME" 

// [HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Keyboard Layouts\E0200411]
// "Ime File"="ATOK14W.IME"
// "Layout Text"="ATOK14"
// "Layout File"="kbd101.dll"

// [FakeIME_Reg]
// HKLM,"system\currentcontrolset\control\keyboard layouts\E0120411","layout file",,kbdjp.kbd
// HKLM,"system\currentcontrolset\control\keyboard layouts\E0120411","layout text",,"FakeIME40 Unicode Edition"
// HKLM,"system\currentcontrolset\control\keyboard layouts\E0120411","IME file",,"FAKEIMEU.IME"
// HKLM,"software\microsoft\fakeime\u"
//
// [FakeIME_Reg_NT]
// HKLM,"system\currentcontrolset\control\keyboard layouts\E0120411","layout file",,kbdjpn.dll
// HKLM,"system\currentcontrolset\control\keyboard layouts\E0120411","layout text",,"FakeIME40 Unicode Edition"
// HKLM,"system\currentcontrolset\control\keyboard layouts\E0120411","IME file",,"FAKEIMEU.IME"
// HKLM,"software\microsoft\fakeime\u"

#define USE_CLASS_ENTRY
#undef USE_ENTRIES_CLEAR // うまくいかない

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace KeyLayout_Fixer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      search();
    }

    private void comboBoxKeyName_TextUpdate(object sender, EventArgs e)
    {
      search();
    }

    private void comboBoxLayoutText_TextUpdate(object sender, EventArgs e)
    {
      search();
    }

    private void comboBoxLayoutFile_TextUpdate(object sender, EventArgs e)
    {
      search();
    }

    //

    const string registryPath = @"system\CurrentControlSet\Control\Keyboard Layouts";

    //
#if USE_CLASS_ENTRY
    private class Entry {
      private string _keyName;
      private RegistryKey _key;

      public Entry(string keyName) {
	_keyName = keyName.ToUpper();
	_key = Registry.LocalMachine.OpenSubKey(registryPath + @"\" + _keyName, true);
      }

      public string KeyName {
	get { return _keyName; }
      }
      public string LayoutText {
	get { return _key.GetValue("Layout Text").ToString(); }
      }
      public string LayoutFile {
	get { return _key.GetValue("Layout File").ToString().ToLower(); }
	set { _key.SetValue("Layout File", value); }
      }
    }

#  if USE_ENTRIES_CLEAR
    private List<Entry> entries = new List<Entry>();
#  else
    private List<Entry> entries;
#  endif
#endif
    //

    private void search()
    {
#if USE_BUTTON_APPLY
      buttonApply.Enabled = false;
#endif
#if USE_CLASS_ENTRY
#  if USE_ENTRIES_CLEAR
      if (entries != null) entries.Clear();
#  else
      entries = new List<Entry>();
#  endif
#else
      dgv.Rows.Clear();
#endif
      var rKey = Registry.LocalMachine.OpenSubKey(registryPath);
      foreach (var name in rKey.GetSubKeyNames())
	evalSubKey(rKey, name);
      entryBindingSource.DataSource = entries;
    }

    private void evalSubKey(RegistryKey rKey, string name) {
      if (! Regex.IsMatch(name, comboBoxKeyName.Text, RegexOptions.IgnoreCase))
	return;

      var entry = new Entry(name);

      if (! Regex.IsMatch(entry.LayoutText,comboBoxLayoutText.Text,
			  RegexOptions.IgnoreCase))
	return;

      if (! Regex.IsMatch(entry.LayoutFile,comboBoxLayoutFile.Text,
			  RegexOptions.IgnoreCase))
	return;

#if USE_CLASS_ENTRY
      entries.Add(entry);
#else
      dgv.Rows.Add(new[] {name.ToUpper(),
			  key.GetValue("Layout Text").ToString(),
			  key.GetValue("Layout File").ToString().ToLower()});
#endif
    }
  }
}
