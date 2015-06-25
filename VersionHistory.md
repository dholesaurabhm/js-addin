### 3.7 Release ![http://js-addin.googlecode.com/svn/site/hot.gif](http://js-addin.googlecode.com/svn/site/hot.gif) ###
  1. Added setting not to show error on debugger keyword
  1. Added option to ignore code between **jsparser:off** and **jsparser:on** statements
  1. Added setting to hide error notification top bar
  1. Fix  [Issue 36](https://code.google.com/p/js-addin/issues/detail?id=36): using AJAX Toolkit ScriptManager causes false positives
  1. Settings UI improved

### [3.6 Release](Version_3_6.md) ###

### 3.5 Release ###
  1. Improved parser logic.
  1. Performance optimizations.
  1. Small UI improvements.
  1. Option to hide anonymous functions.
  1. Change location of JSParser menu in VS2008.
  1. Bug fixes.
  1. Remove buggy option Auto show\hide.
  1. Fixed old version info in 3.4 release leading to wrong version detection

### 3.3 Release ###
  1. Show errors in javascript.
  1. Show //TODO: comments in special task list.
> > ![http://js-addin.googlecode.com/svn/site/vs2010_errors_tasklist.png](http://js-addin.googlecode.com/svn/site/vs2010_errors_tasklist.png)


### 3.2 Release ###
  1. Configurable font and color for marks. Configuration is available in Settings dialog. [Screenshot](http://js-addin.googlecode.com/svn/site/SettingsUI.png)
> > ![http://js-addin.googlecode.com/svn/site/MarksFontStyle.png](http://js-addin.googlecode.com/svn/site/MarksFontStyle.png)
  1. Add parameters for function chains - for jQuery selectors it's very useful.
> > ![http://js-addin.googlecode.com/svn/site/DisplayParametersInFunctionChain.png](http://js-addin.googlecode.com/svn/site/DisplayParametersInFunctionChain.png)
  1. Fix Try-Catch block were not analyzed.
  1. Fix unexpected collapse of node when change signature of function.
  1. Other fixes (please check Issues page)
### Release 3.1 ###
  1. Option for automatically Expand\Collapse nodes in tree. [Screenshot](http://js-addin.googlecode.com/svn/site/screen_expandcollapseoption.png)
  1. Option for automatically Show\Hide addin tool window. [Screenshot](http://js-addin.googlecode.com/svn/site/screen_optionsdialog.png)
  1. Various bug fixes. (please check Issues page)

### 3.0 Release ###
  1. Find feature. (supports hotkey) [Screenshot](http://js-addin.googlecode.com/svn/site/screen_FindExample.png)
> > To configure hotkey please use Visual Studio hotkey manager.<br />
> > Navigate Tools/Options/Environment/Keyboard and do search for command
> > "**JavascriptParser.Find**" for VS2010 or "**JSparser.Connect.Find**" for VS2008. <br />
> > Then specify your hotkey. By default it should be Shift+Alt+J. [Screenshot](http://js-addin.googlecode.com/svn/site/screen_define_shortcut.png)
  1. Show line numbers in tree.
  1. Automatic track active function while working in text editor.
  1. Various bug fixes. (please check Issues page)

### 2.0 Release ###

  1. Support of `<script></script>` blocks in non-js files (**`*`.html**, **`*`.aspx**, etc) [Screenshot](http://js-addin.googlecode.com/svn/site/vs2010_html.png)
  1. Ignoring asp.net-specific tags (<%= %>) from source code to maintain valid javascript.
  1. Added marks. This marks are saved when restarted Visual Studio and allows to remember some points in the large scripts. [Screenshot](http://js-addin.googlecode.com/svn/site/vs2010_marks.png)
  1. Solution restructuring for future support native VS2010 add-in format.