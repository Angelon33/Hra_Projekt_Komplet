   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjektWPF
ProjektWPF  5   	   N JFamFamFam.Flags.Wpf, Version=1.2.1.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:FamFamFam.Flags.Wpf;assembly=FamFamFam.Flags.WpfFamFamFam.Flags.Wpf 5   	       ProjektWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjektWPF     5   	   \ XWPFLocalizeExtension, Version=3.10.0.0, Culture=neutral, PublicKeyToken=c726e0262981a1eb2lex(http://wpflocalizeextension.codeplex.com  5   
   JFlags>clr-namespace:FamFamFam.Flags.Wpf;assembly=FamFamFam.Flags.Wpf  5   	   4  .WPFLocalizeExtension.Engine.LocalizeDictionary    DesignCulture$  en-US��5      =  7WPFLocalizeExtension.Providers.ResxLocalizationProvider   DefaultAssembly$ 
ProjektWPF��5	         DefaultDictionary$ 
Lokalizace��5
       � Title$ Projekt��5   	   $	��450��6   $	��800��6&   $	��920��62   $	��450��6A    � 	Resources 5      =  7FamFamFam.Flags.Wpf.CountryIdToFlagImageSourceConverter '  #CountryIdToFlagImageSourceConverter'   !ProjektWPF.LangToCountryConverter  LangToCountryConverter#   ProjektWPF.CombiningConverter  CombiningConverter   
Converter1   
Converter2  MyBrush �� Color��%�   &	        &	      &	 &     7  7   &	 C       5   
   64     5   
   6'     5   
   8   8  6s   �� 5   
   $	 Red��6*   5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $
��Left=�6   $��
153,79,0,0q�6/   $
��Wrap=�6C   $	��Top=�6�   	 J� RenderTransformOrigin$	 0.204,1.157&�6�   $	��359��6�   ��6W   �� *Hra.AktualniMistnost.Popis+6�   �� 5    
   $
��Left=�6   $��
153,48,0,0q�6/   $
��Wrap=�6C   $	��Top=�6�   $	 0.204,1.157&�6�   $	��359��6�   ��6W   �� *Hra.AktualniMistnost.Jmeno+6�   �� 5!   
   $
��Left=�66   $��	10,43,0,0q�6Q   $	��Top=�6d   ��6   2  ,WPFLocalizeExtension.Extensions.LocExtension  

   Key$
 NameOftheRoom��6d   �� 5#   
   $
��Left=�66   $��	10,74,0,0q�6Q   $	��Top=�6d   ��6     $
 DescOftheRoom��6d   �� 5$   
   $
��Left=�6   $��
30,122,0,0q�6+   $	��Top=�6?   $	��230��6W   �� 5%   
   -   5        $��OkolniMistnosti��5%      $��30,153,670,90q�6R   ��6*   �� *OkolniMistnost+ �� View 5&      �� 5'       �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Nazev��66   .P�5(      ��  �� DisplayMemberBinding 6%   �� *Jmeno+��6L     *
HeaderLang+5*      5-      �� 5.   
   -   5        $��PredmetMistnost��5.      $��311,153,391,90q�6�   ��6*   �� *PredmetMistnosti+ 5/      �� 50       . $ Predmet��66   .P�51      ��  6%   �� *NazevPredmetu+��6T     *HeaderItems+53      56      �� 57   
   -   5        $��
Inventář��57      $��631,153,86,90q�6x   ��6#   �� *
Inventar+ 58      �� 59       . $ Inventar��66   .P�5:      ��  6%   �� *NazevPredmetu+��6T     *HeaderInventory+5<      5?      �� 5@   
   -   5         ��Name$ langSelection_comboBox��5@      $��	0,12,10,0q�63   $��Right=�5C   N   $	��283��6j   $��25��6v   $	��Top=�6�   ��5A      ��    Instance �� Source# Z  �� Path$ MergedAvailableCultures� �� SelectedItem 5B      �� # Z $ Culture���5D      �� 5E       �� DataType$ flags:CountryData��6   .R�5F      ��  �� Orientation$ 
Horizontal=�6!   .+�5G      ��  �� BitmapScalingMode$ HighQuality=�6y   ��6    �� $
 LCID� �� Mode$ OneWay=� �� 	Converter# [ 6y   �� 5H      $��5,0,0,0q�6$   $��Center=�65   �� 5I      $�(��6"    �� 5J      �6"   �� $
 LCID�$ OneWay=�# [  �� 5K      $�) ��6"   5L      �� 5M      $��5,0,0,0q�6E   $��Center=�6V   ��6$   �� $ 
NativeName�6V   5N      5O      5Q      5S      5U      