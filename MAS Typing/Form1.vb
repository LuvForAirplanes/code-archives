Imports MAS_Typing.My
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace MAS_Typing
	<DesignerGenerated>
	Public Class Form1
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("PrintDocument21")>
		Private _PrintDocument21 As PrintDocument

		<AccessedThroughProperty("RichTextBox90")>
		Private _RichTextBox90 As RichTextBox

		<AccessedThroughProperty("PrintDocument22")>
		Private _PrintDocument22 As PrintDocument

		<AccessedThroughProperty("PrintDocument45")>
		Private _PrintDocument45 As PrintDocument

		<AccessedThroughProperty("PrintDocument38")>
		Private _PrintDocument38 As PrintDocument

		<AccessedThroughProperty("PrintDocument44")>
		Private _PrintDocument44 As PrintDocument

		<AccessedThroughProperty("PrintDocument39")>
		Private _PrintDocument39 As PrintDocument

		<AccessedThroughProperty("PrintDocument6")>
		Private _PrintDocument6 As PrintDocument

		<AccessedThroughProperty("PrintDocument40")>
		Private _PrintDocument40 As PrintDocument

		<AccessedThroughProperty("PrintDocument9")>
		Private _PrintDocument9 As PrintDocument

		<AccessedThroughProperty("PrintDocument33")>
		Private _PrintDocument33 As PrintDocument

		<AccessedThroughProperty("PrintDocument10")>
		Private _PrintDocument10 As PrintDocument

		<AccessedThroughProperty("PrintDocument5")>
		Private _PrintDocument5 As PrintDocument

		<AccessedThroughProperty("PrintDocument11")>
		Private _PrintDocument11 As PrintDocument

		<AccessedThroughProperty("PrintDocument4")>
		Private _PrintDocument4 As PrintDocument

		<AccessedThroughProperty("ListBox1")>
		Private _ListBox1 As ListBox

		<AccessedThroughProperty("PrintDocument3")>
		Private _PrintDocument3 As PrintDocument

		<AccessedThroughProperty("PrintDocument1")>
		Private _PrintDocument1 As PrintDocument

		<AccessedThroughProperty("PrintDocument12")>
		Private _PrintDocument12 As PrintDocument

		<AccessedThroughProperty("PrintDocument2")>
		Private _PrintDocument2 As PrintDocument

		<AccessedThroughProperty("PrintDocument16")>
		Private _PrintDocument16 As PrintDocument

		<AccessedThroughProperty("PrintDocument30")>
		Private _PrintDocument30 As PrintDocument

		<AccessedThroughProperty("PrintDocument17")>
		Private _PrintDocument17 As PrintDocument

		<AccessedThroughProperty("PrintDocument31")>
		Private _PrintDocument31 As PrintDocument

		<AccessedThroughProperty("PrintDocument26")>
		Private _PrintDocument26 As PrintDocument

		<AccessedThroughProperty("PrintDocument32")>
		Private _PrintDocument32 As PrintDocument

		<AccessedThroughProperty("PrintDocument25")>
		Private _PrintDocument25 As PrintDocument

		<AccessedThroughProperty("PrintDocument18")>
		Private _PrintDocument18 As PrintDocument

		<AccessedThroughProperty("PrintDocument24")>
		Private _PrintDocument24 As PrintDocument

		<AccessedThroughProperty("PrintDocument19")>
		Private _PrintDocument19 As PrintDocument

		<AccessedThroughProperty("PrintDocument53")>
		Private _PrintDocument53 As PrintDocument

		<AccessedThroughProperty("PrintDocument23")>
		Private _PrintDocument23 As PrintDocument

		<AccessedThroughProperty("PrintDocument75")>
		Private _PrintDocument75 As PrintDocument

		<AccessedThroughProperty("PrintDocument54")>
		Private _PrintDocument54 As PrintDocument

		<AccessedThroughProperty("PrintDocument79")>
		Private _PrintDocument79 As PrintDocument

		<AccessedThroughProperty("PrintDocument74")>
		Private _PrintDocument74 As PrintDocument

		<AccessedThroughProperty("PrintDocument80")>
		Private _PrintDocument80 As PrintDocument

		<AccessedThroughProperty("PrintDocument73")>
		Private _PrintDocument73 As PrintDocument

		<AccessedThroughProperty("PrintDocument64")>
		Private _PrintDocument64 As PrintDocument

		<AccessedThroughProperty("PrintDocument72")>
		Private _PrintDocument72 As PrintDocument

		<AccessedThroughProperty("PrintDocument70")>
		Private _PrintDocument70 As PrintDocument

		<AccessedThroughProperty("PrintDocument81")>
		Private _PrintDocument81 As PrintDocument

		<AccessedThroughProperty("PrintDocument71")>
		Private _PrintDocument71 As PrintDocument

		<AccessedThroughProperty("PrintDocument82")>
		Private _PrintDocument82 As PrintDocument

		<AccessedThroughProperty("PrintDocument87")>
		Private _PrintDocument87 As PrintDocument

		<AccessedThroughProperty("PrintDocument76")>
		Private _PrintDocument76 As PrintDocument

		<AccessedThroughProperty("PrintDocument88")>
		Private _PrintDocument88 As PrintDocument

		<AccessedThroughProperty("PrintDocument86")>
		Private _PrintDocument86 As PrintDocument

		<AccessedThroughProperty("PrintDocument89")>
		Private _PrintDocument89 As PrintDocument

		<AccessedThroughProperty("PrintDocument85")>
		Private _PrintDocument85 As PrintDocument

		<AccessedThroughProperty("PrintDocument77")>
		Private _PrintDocument77 As PrintDocument

		<AccessedThroughProperty("PrintDocument84")>
		Private _PrintDocument84 As PrintDocument

		<AccessedThroughProperty("PrintDocument78")>
		Private _PrintDocument78 As PrintDocument

		<AccessedThroughProperty("PrintDocument63")>
		Private _PrintDocument63 As PrintDocument

		<AccessedThroughProperty("PrintDocument83")>
		Private _PrintDocument83 As PrintDocument

		<AccessedThroughProperty("PrintDocument48")>
		Private _PrintDocument48 As PrintDocument

		<AccessedThroughProperty("PrintDocument69")>
		Private _PrintDocument69 As PrintDocument

		<AccessedThroughProperty("PrintDocument49")>
		Private _PrintDocument49 As PrintDocument

		<AccessedThroughProperty("PrintDocument43")>
		Private _PrintDocument43 As PrintDocument

		<AccessedThroughProperty("PrintDocument50")>
		Private _PrintDocument50 As PrintDocument

		<AccessedThroughProperty("PrintDocument42")>
		Private _PrintDocument42 As PrintDocument

		<AccessedThroughProperty("PrintDocument34")>
		Private _PrintDocument34 As PrintDocument

		<AccessedThroughProperty("PrintDocument41")>
		Private _PrintDocument41 As PrintDocument

		<AccessedThroughProperty("PrintDocument35")>
		Private _PrintDocument35 As PrintDocument

		<AccessedThroughProperty("PrintDocument55")>
		Private _PrintDocument55 As PrintDocument

		<AccessedThroughProperty("PrintDocument36")>
		Private _PrintDocument36 As PrintDocument

		<AccessedThroughProperty("PrintDocument56")>
		Private _PrintDocument56 As PrintDocument

		<AccessedThroughProperty("PrintDocument66")>
		Private _PrintDocument66 As PrintDocument

		<AccessedThroughProperty("PrintDocument57")>
		Private _PrintDocument57 As PrintDocument

		<AccessedThroughProperty("PrintDocument67")>
		Private _PrintDocument67 As PrintDocument

		<AccessedThroughProperty("PrintDocument65")>
		Private _PrintDocument65 As PrintDocument

		<AccessedThroughProperty("PrintDocument68")>
		Private _PrintDocument68 As PrintDocument

		<AccessedThroughProperty("PrintDocument62")>
		Private _PrintDocument62 As PrintDocument

		<AccessedThroughProperty("PrintDocument58")>
		Private _PrintDocument58 As PrintDocument

		<AccessedThroughProperty("PrintDocument61")>
		Private _PrintDocument61 As PrintDocument

		<AccessedThroughProperty("PrintDocument59")>
		Private _PrintDocument59 As PrintDocument

		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		<AccessedThroughProperty("PrintDocument60")>
		Private _PrintDocument60 As PrintDocument

		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		<AccessedThroughProperty("ComboBox3")>
		Private _ComboBox3 As ComboBox

		<AccessedThroughProperty("RichTextBox89")>
		Private _RichTextBox89 As RichTextBox

		<AccessedThroughProperty("RichTextBox88")>
		Private _RichTextBox88 As RichTextBox

		<AccessedThroughProperty("RichTextBox87")>
		Private _RichTextBox87 As RichTextBox

		<AccessedThroughProperty("RichTextBox86")>
		Private _RichTextBox86 As RichTextBox

		<AccessedThroughProperty("RichTextBox85")>
		Private _RichTextBox85 As RichTextBox

		<AccessedThroughProperty("RichTextBox84")>
		Private _RichTextBox84 As RichTextBox

		<AccessedThroughProperty("RichTextBox83")>
		Private _RichTextBox83 As RichTextBox

		<AccessedThroughProperty("RichTextBox82")>
		Private _RichTextBox82 As RichTextBox

		<AccessedThroughProperty("RichTextBox81")>
		Private _RichTextBox81 As RichTextBox

		<AccessedThroughProperty("RichTextBox80")>
		Private _RichTextBox80 As RichTextBox

		<AccessedThroughProperty("RichTextBox79")>
		Private _RichTextBox79 As RichTextBox

		<AccessedThroughProperty("RichTextBox78")>
		Private _RichTextBox78 As RichTextBox

		<AccessedThroughProperty("RichTextBox77")>
		Private _RichTextBox77 As RichTextBox

		<AccessedThroughProperty("RichTextBox76")>
		Private _RichTextBox76 As RichTextBox

		<AccessedThroughProperty("RichTextBox75")>
		Private _RichTextBox75 As RichTextBox

		<AccessedThroughProperty("RichTextBox74")>
		Private _RichTextBox74 As RichTextBox

		<AccessedThroughProperty("RichTextBox73")>
		Private _RichTextBox73 As RichTextBox

		<AccessedThroughProperty("RichTextBox72")>
		Private _RichTextBox72 As RichTextBox

		<AccessedThroughProperty("RichTextBox71")>
		Private _RichTextBox71 As RichTextBox

		<AccessedThroughProperty("RichTextBox70")>
		Private _RichTextBox70 As RichTextBox

		<AccessedThroughProperty("RichTextBox69")>
		Private _RichTextBox69 As RichTextBox

		<AccessedThroughProperty("RichTextBox68")>
		Private _RichTextBox68 As RichTextBox

		<AccessedThroughProperty("RichTextBox67")>
		Private _RichTextBox67 As RichTextBox

		<AccessedThroughProperty("RichTextBox66")>
		Private _RichTextBox66 As RichTextBox

		<AccessedThroughProperty("RichTextBox65")>
		Private _RichTextBox65 As RichTextBox

		<AccessedThroughProperty("RichTextBox64")>
		Private _RichTextBox64 As RichTextBox

		<AccessedThroughProperty("RichTextBox63")>
		Private _RichTextBox63 As RichTextBox

		<AccessedThroughProperty("RichTextBox62")>
		Private _RichTextBox62 As RichTextBox

		<AccessedThroughProperty("RichTextBox61")>
		Private _RichTextBox61 As RichTextBox

		<AccessedThroughProperty("RichTextBox60")>
		Private _RichTextBox60 As RichTextBox

		<AccessedThroughProperty("RichTextBox59")>
		Private _RichTextBox59 As RichTextBox

		<AccessedThroughProperty("RichTextBox58")>
		Private _RichTextBox58 As RichTextBox

		<AccessedThroughProperty("RichTextBox57")>
		Private _RichTextBox57 As RichTextBox

		<AccessedThroughProperty("RichTextBox56")>
		Private _RichTextBox56 As RichTextBox

		<AccessedThroughProperty("RichTextBox55")>
		Private _RichTextBox55 As RichTextBox

		<AccessedThroughProperty("RichTextBox54")>
		Private _RichTextBox54 As RichTextBox

		<AccessedThroughProperty("RichTextBox53")>
		Private _RichTextBox53 As RichTextBox

		<AccessedThroughProperty("RichTextBox52")>
		Private _RichTextBox52 As RichTextBox

		<AccessedThroughProperty("RichTextBox51")>
		Private _RichTextBox51 As RichTextBox

		<AccessedThroughProperty("RichTextBox50")>
		Private _RichTextBox50 As RichTextBox

		<AccessedThroughProperty("RichTextBox49")>
		Private _RichTextBox49 As RichTextBox

		<AccessedThroughProperty("RichTextBox48")>
		Private _RichTextBox48 As RichTextBox

		<AccessedThroughProperty("RichTextBox47")>
		Private _RichTextBox47 As RichTextBox

		<AccessedThroughProperty("RichTextBox46")>
		Private _RichTextBox46 As RichTextBox

		<AccessedThroughProperty("RichTextBox45")>
		Private _RichTextBox45 As RichTextBox

		<AccessedThroughProperty("RichTextBox44")>
		Private _RichTextBox44 As RichTextBox

		<AccessedThroughProperty("RichTextBox43")>
		Private _RichTextBox43 As RichTextBox

		<AccessedThroughProperty("RichTextBox42")>
		Private _RichTextBox42 As RichTextBox

		<AccessedThroughProperty("RichTextBox41")>
		Private _RichTextBox41 As RichTextBox

		<AccessedThroughProperty("RichTextBox40")>
		Private _RichTextBox40 As RichTextBox

		<AccessedThroughProperty("PrintDocument90")>
		Private _PrintDocument90 As PrintDocument

		<AccessedThroughProperty("RichTextBox39")>
		Private _RichTextBox39 As RichTextBox

		<AccessedThroughProperty("RichTextBox38")>
		Private _RichTextBox38 As RichTextBox

		<AccessedThroughProperty("RichTextBox37")>
		Private _RichTextBox37 As RichTextBox

		<AccessedThroughProperty("RichTextBox36")>
		Private _RichTextBox36 As RichTextBox

		<AccessedThroughProperty("RichTextBox35")>
		Private _RichTextBox35 As RichTextBox

		<AccessedThroughProperty("RichTextBox34")>
		Private _RichTextBox34 As RichTextBox

		<AccessedThroughProperty("RichTextBox33")>
		Private _RichTextBox33 As RichTextBox

		<AccessedThroughProperty("RichTextBox32")>
		Private _RichTextBox32 As RichTextBox

		<AccessedThroughProperty("RichTextBox31")>
		Private _RichTextBox31 As RichTextBox

		<AccessedThroughProperty("RichTextBox30")>
		Private _RichTextBox30 As RichTextBox

		<AccessedThroughProperty("RichTextBox29")>
		Private _RichTextBox29 As RichTextBox

		<AccessedThroughProperty("RichTextBox28")>
		Private _RichTextBox28 As RichTextBox

		<AccessedThroughProperty("RichTextBox27")>
		Private _RichTextBox27 As RichTextBox

		<AccessedThroughProperty("RichTextBox26")>
		Private _RichTextBox26 As RichTextBox

		<AccessedThroughProperty("RichTextBox25")>
		Private _RichTextBox25 As RichTextBox

		<AccessedThroughProperty("RichTextBox24")>
		Private _RichTextBox24 As RichTextBox

		<AccessedThroughProperty("RichTextBox23")>
		Private _RichTextBox23 As RichTextBox

		<AccessedThroughProperty("RichTextBox22")>
		Private _RichTextBox22 As RichTextBox

		<AccessedThroughProperty("RichTextBox21")>
		Private _RichTextBox21 As RichTextBox

		<AccessedThroughProperty("RichTextBox20")>
		Private _RichTextBox20 As RichTextBox

		<AccessedThroughProperty("RichTextBox19")>
		Private _RichTextBox19 As RichTextBox

		<AccessedThroughProperty("RichTextBox18")>
		Private _RichTextBox18 As RichTextBox

		<AccessedThroughProperty("RichTextBox17")>
		Private _RichTextBox17 As RichTextBox

		<AccessedThroughProperty("RichTextBox16")>
		Private _RichTextBox16 As RichTextBox

		<AccessedThroughProperty("RichTextBox15")>
		Private _RichTextBox15 As RichTextBox

		<AccessedThroughProperty("RichTextBox14")>
		Private _RichTextBox14 As RichTextBox

		<AccessedThroughProperty("RichTextBox13")>
		Private _RichTextBox13 As RichTextBox

		<AccessedThroughProperty("RichTextBox12")>
		Private _RichTextBox12 As RichTextBox

		<AccessedThroughProperty("RichTextBox11")>
		Private _RichTextBox11 As RichTextBox

		<AccessedThroughProperty("RichTextBox10")>
		Private _RichTextBox10 As RichTextBox

		<AccessedThroughProperty("RichTextBox9")>
		Private _RichTextBox9 As RichTextBox

		<AccessedThroughProperty("RichTextBox8")>
		Private _RichTextBox8 As RichTextBox

		<AccessedThroughProperty("RichTextBox7")>
		Private _RichTextBox7 As RichTextBox

		<AccessedThroughProperty("RichTextBox6")>
		Private _RichTextBox6 As RichTextBox

		<AccessedThroughProperty("RichTextBox5")>
		Private _RichTextBox5 As RichTextBox

		<AccessedThroughProperty("RichTextBox4")>
		Private _RichTextBox4 As RichTextBox

		<AccessedThroughProperty("RichTextBox3")>
		Private _RichTextBox3 As RichTextBox

		<AccessedThroughProperty("RichTextBox2")>
		Private _RichTextBox2 As RichTextBox

		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("PrintDocument20")>
		Private _PrintDocument20 As PrintDocument

		<AccessedThroughProperty("PrintDocument27")>
		Private _PrintDocument27 As PrintDocument

		<AccessedThroughProperty("PrintDocument15")>
		Private _PrintDocument15 As PrintDocument

		<AccessedThroughProperty("PrintDocument7")>
		Private _PrintDocument7 As PrintDocument

		<AccessedThroughProperty("PrintDocument14")>
		Private _PrintDocument14 As PrintDocument

		<AccessedThroughProperty("PrintDocument8")>
		Private _PrintDocument8 As PrintDocument

		<AccessedThroughProperty("PrintDocument28")>
		Private _PrintDocument28 As PrintDocument

		<AccessedThroughProperty("PrintDocument13")>
		Private _PrintDocument13 As PrintDocument

		<AccessedThroughProperty("PrintDocument29")>
		Private _PrintDocument29 As PrintDocument

		<AccessedThroughProperty("PrintDocument47")>
		Private _PrintDocument47 As PrintDocument

		<AccessedThroughProperty("PrintDocument37")>
		Private _PrintDocument37 As PrintDocument

		<AccessedThroughProperty("PrintDocument51")>
		Private _PrintDocument51 As PrintDocument

		<AccessedThroughProperty("PrintDocument46")>
		Private _PrintDocument46 As PrintDocument

		<AccessedThroughProperty("PrintDocument52")>
		Private _PrintDocument52 As PrintDocument

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Me._Button1 = value
			End Set
		End Property

		Friend Overridable Property ComboBox1 As ComboBox
			Get
				Return Me._ComboBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox1 = value
			End Set
		End Property

		Friend Overridable Property ComboBox2 As ComboBox
			Get
				Return Me._ComboBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox2 = value
			End Set
		End Property

		Friend Overridable Property ComboBox3 As ComboBox
			Get
				Return Me._ComboBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox3 = value
			End Set
		End Property

		Friend Overridable Property GroupBox1 As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property ListBox1 As ListBox
			Get
				Return Me._ListBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ListBox)
				Me._ListBox1 = value
			End Set
		End Property

		Friend Overridable Property PictureBox2 As PictureBox
			Get
				Return Me._PictureBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		Friend Overridable Property PictureBox3 As PictureBox
			Get
				Return Me._PictureBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument1 As PrintDocument
			Get
				Return Me._PrintDocument1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument1 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument10 As PrintDocument
			Get
				Return Me._PrintDocument10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument10 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument11 As PrintDocument
			Get
				Return Me._PrintDocument11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument11 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument12 As PrintDocument
			Get
				Return Me._PrintDocument12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument12 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument13 As PrintDocument
			Get
				Return Me._PrintDocument13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument13 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument14 As PrintDocument
			Get
				Return Me._PrintDocument14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument14 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument15 As PrintDocument
			Get
				Return Me._PrintDocument15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument15 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument16 As PrintDocument
			Get
				Return Me._PrintDocument16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument16 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument17 As PrintDocument
			Get
				Return Me._PrintDocument17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument17 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument18 As PrintDocument
			Get
				Return Me._PrintDocument18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument18 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument19 As PrintDocument
			Get
				Return Me._PrintDocument19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument19 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument2 As PrintDocument
			Get
				Return Me._PrintDocument2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument2 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument20 As PrintDocument
			Get
				Return Me._PrintDocument20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument20 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument21 As PrintDocument
			Get
				Return Me._PrintDocument21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument21 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument22 As PrintDocument
			Get
				Return Me._PrintDocument22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument22 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument23 As PrintDocument
			Get
				Return Me._PrintDocument23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument23 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument24 As PrintDocument
			Get
				Return Me._PrintDocument24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument24 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument25 As PrintDocument
			Get
				Return Me._PrintDocument25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument25 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument26 As PrintDocument
			Get
				Return Me._PrintDocument26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument26 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument27 As PrintDocument
			Get
				Return Me._PrintDocument27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument27 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument28 As PrintDocument
			Get
				Return Me._PrintDocument28
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument28 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument29 As PrintDocument
			Get
				Return Me._PrintDocument29
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument29 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument3 As PrintDocument
			Get
				Return Me._PrintDocument3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument3 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument30 As PrintDocument
			Get
				Return Me._PrintDocument30
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument30 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument31 As PrintDocument
			Get
				Return Me._PrintDocument31
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument31 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument32 As PrintDocument
			Get
				Return Me._PrintDocument32
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument32 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument33 As PrintDocument
			Get
				Return Me._PrintDocument33
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument33 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument34 As PrintDocument
			Get
				Return Me._PrintDocument34
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument34 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument35 As PrintDocument
			Get
				Return Me._PrintDocument35
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument35 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument36 As PrintDocument
			Get
				Return Me._PrintDocument36
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument36 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument37 As PrintDocument
			Get
				Return Me._PrintDocument37
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument37 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument38 As PrintDocument
			Get
				Return Me._PrintDocument38
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument38 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument39 As PrintDocument
			Get
				Return Me._PrintDocument39
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument39 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument4 As PrintDocument
			Get
				Return Me._PrintDocument4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument4 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument40 As PrintDocument
			Get
				Return Me._PrintDocument40
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument40 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument41 As PrintDocument
			Get
				Return Me._PrintDocument41
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument41 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument42 As PrintDocument
			Get
				Return Me._PrintDocument42
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument42 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument43 As PrintDocument
			Get
				Return Me._PrintDocument43
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument43 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument44 As PrintDocument
			Get
				Return Me._PrintDocument44
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument44 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument45 As PrintDocument
			Get
				Return Me._PrintDocument45
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument45 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument46 As PrintDocument
			Get
				Return Me._PrintDocument46
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument46 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument47 As PrintDocument
			Get
				Return Me._PrintDocument47
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument47 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument48 As PrintDocument
			Get
				Return Me._PrintDocument48
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument48 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument49 As PrintDocument
			Get
				Return Me._PrintDocument49
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument49 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument5 As PrintDocument
			Get
				Return Me._PrintDocument5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument5 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument50 As PrintDocument
			Get
				Return Me._PrintDocument50
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument50 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument51 As PrintDocument
			Get
				Return Me._PrintDocument51
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument51 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument52 As PrintDocument
			Get
				Return Me._PrintDocument52
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument52 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument53 As PrintDocument
			Get
				Return Me._PrintDocument53
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument53 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument54 As PrintDocument
			Get
				Return Me._PrintDocument54
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument54 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument55 As PrintDocument
			Get
				Return Me._PrintDocument55
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument55 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument56 As PrintDocument
			Get
				Return Me._PrintDocument56
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument56 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument57 As PrintDocument
			Get
				Return Me._PrintDocument57
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument57 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument58 As PrintDocument
			Get
				Return Me._PrintDocument58
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument58 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument59 As PrintDocument
			Get
				Return Me._PrintDocument59
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument59 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument6 As PrintDocument
			Get
				Return Me._PrintDocument6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument6 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument60 As PrintDocument
			Get
				Return Me._PrintDocument60
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument60 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument61 As PrintDocument
			Get
				Return Me._PrintDocument61
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument61 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument62 As PrintDocument
			Get
				Return Me._PrintDocument62
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument62 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument63 As PrintDocument
			Get
				Return Me._PrintDocument63
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument63 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument64 As PrintDocument
			Get
				Return Me._PrintDocument64
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument64 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument65 As PrintDocument
			Get
				Return Me._PrintDocument65
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument65 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument66 As PrintDocument
			Get
				Return Me._PrintDocument66
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument66 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument67 As PrintDocument
			Get
				Return Me._PrintDocument67
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument67 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument68 As PrintDocument
			Get
				Return Me._PrintDocument68
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument68 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument69 As PrintDocument
			Get
				Return Me._PrintDocument69
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument69 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument7 As PrintDocument
			Get
				Return Me._PrintDocument7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument7 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument70 As PrintDocument
			Get
				Return Me._PrintDocument70
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument70 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument71 As PrintDocument
			Get
				Return Me._PrintDocument71
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument71 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument72 As PrintDocument
			Get
				Return Me._PrintDocument72
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument72 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument73 As PrintDocument
			Get
				Return Me._PrintDocument73
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument73 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument74 As PrintDocument
			Get
				Return Me._PrintDocument74
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument74 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument75 As PrintDocument
			Get
				Return Me._PrintDocument75
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument75 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument76 As PrintDocument
			Get
				Return Me._PrintDocument76
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument76 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument77 As PrintDocument
			Get
				Return Me._PrintDocument77
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument77 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument78 As PrintDocument
			Get
				Return Me._PrintDocument78
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument78 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument79 As PrintDocument
			Get
				Return Me._PrintDocument79
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument79 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument8 As PrintDocument
			Get
				Return Me._PrintDocument8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument8 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument80 As PrintDocument
			Get
				Return Me._PrintDocument80
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument80 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument81 As PrintDocument
			Get
				Return Me._PrintDocument81
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument81 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument82 As PrintDocument
			Get
				Return Me._PrintDocument82
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument82 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument83 As PrintDocument
			Get
				Return Me._PrintDocument83
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument83 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument84 As PrintDocument
			Get
				Return Me._PrintDocument84
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument84 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument85 As PrintDocument
			Get
				Return Me._PrintDocument85
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument85 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument86 As PrintDocument
			Get
				Return Me._PrintDocument86
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument86 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument87 As PrintDocument
			Get
				Return Me._PrintDocument87
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument87 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument88 As PrintDocument
			Get
				Return Me._PrintDocument88
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument88 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument89 As PrintDocument
			Get
				Return Me._PrintDocument89
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument89 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument9 As PrintDocument
			Get
				Return Me._PrintDocument9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument9 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument90 As PrintDocument
			Get
				Return Me._PrintDocument90
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Me._PrintDocument90 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox1 As RichTextBox
			Get
				Return Me._RichTextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox10 As RichTextBox
			Get
				Return Me._RichTextBox10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox10 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox11 As RichTextBox
			Get
				Return Me._RichTextBox11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox11 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox12 As RichTextBox
			Get
				Return Me._RichTextBox12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox12 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox13 As RichTextBox
			Get
				Return Me._RichTextBox13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox13 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox14 As RichTextBox
			Get
				Return Me._RichTextBox14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox14 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox15 As RichTextBox
			Get
				Return Me._RichTextBox15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox15 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox16 As RichTextBox
			Get
				Return Me._RichTextBox16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox16 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox17 As RichTextBox
			Get
				Return Me._RichTextBox17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox17 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox18 As RichTextBox
			Get
				Return Me._RichTextBox18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox18 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox19 As RichTextBox
			Get
				Return Me._RichTextBox19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox19 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox2 As RichTextBox
			Get
				Return Me._RichTextBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox2 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox20 As RichTextBox
			Get
				Return Me._RichTextBox20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox20 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox21 As RichTextBox
			Get
				Return Me._RichTextBox21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox21 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox22 As RichTextBox
			Get
				Return Me._RichTextBox22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox22 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox23 As RichTextBox
			Get
				Return Me._RichTextBox23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox23 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox24 As RichTextBox
			Get
				Return Me._RichTextBox24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox24 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox25 As RichTextBox
			Get
				Return Me._RichTextBox25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox25 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox26 As RichTextBox
			Get
				Return Me._RichTextBox26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox26 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox27 As RichTextBox
			Get
				Return Me._RichTextBox27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox27 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox28 As RichTextBox
			Get
				Return Me._RichTextBox28
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox28 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox29 As RichTextBox
			Get
				Return Me._RichTextBox29
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox29 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox3 As RichTextBox
			Get
				Return Me._RichTextBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox3 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox30 As RichTextBox
			Get
				Return Me._RichTextBox30
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox30 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox31 As RichTextBox
			Get
				Return Me._RichTextBox31
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox31 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox32 As RichTextBox
			Get
				Return Me._RichTextBox32
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox32 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox33 As RichTextBox
			Get
				Return Me._RichTextBox33
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox33 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox34 As RichTextBox
			Get
				Return Me._RichTextBox34
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox34 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox35 As RichTextBox
			Get
				Return Me._RichTextBox35
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox35 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox36 As RichTextBox
			Get
				Return Me._RichTextBox36
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox36 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox37 As RichTextBox
			Get
				Return Me._RichTextBox37
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox37 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox38 As RichTextBox
			Get
				Return Me._RichTextBox38
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox38 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox39 As RichTextBox
			Get
				Return Me._RichTextBox39
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox39 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox4 As RichTextBox
			Get
				Return Me._RichTextBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox4 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox40 As RichTextBox
			Get
				Return Me._RichTextBox40
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox40 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox41 As RichTextBox
			Get
				Return Me._RichTextBox41
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox41 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox42 As RichTextBox
			Get
				Return Me._RichTextBox42
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox42 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox43 As RichTextBox
			Get
				Return Me._RichTextBox43
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox43 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox44 As RichTextBox
			Get
				Return Me._RichTextBox44
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox44 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox45 As RichTextBox
			Get
				Return Me._RichTextBox45
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox45 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox46 As RichTextBox
			Get
				Return Me._RichTextBox46
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox46 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox47 As RichTextBox
			Get
				Return Me._RichTextBox47
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox47 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox48 As RichTextBox
			Get
				Return Me._RichTextBox48
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox48 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox49 As RichTextBox
			Get
				Return Me._RichTextBox49
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox49 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox5 As RichTextBox
			Get
				Return Me._RichTextBox5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox5 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox50 As RichTextBox
			Get
				Return Me._RichTextBox50
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox50 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox51 As RichTextBox
			Get
				Return Me._RichTextBox51
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox51 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox52 As RichTextBox
			Get
				Return Me._RichTextBox52
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox52 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox53 As RichTextBox
			Get
				Return Me._RichTextBox53
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox53 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox54 As RichTextBox
			Get
				Return Me._RichTextBox54
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox54 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox55 As RichTextBox
			Get
				Return Me._RichTextBox55
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox55 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox56 As RichTextBox
			Get
				Return Me._RichTextBox56
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox56 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox57 As RichTextBox
			Get
				Return Me._RichTextBox57
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox57 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox58 As RichTextBox
			Get
				Return Me._RichTextBox58
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox58 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox59 As RichTextBox
			Get
				Return Me._RichTextBox59
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox59 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox6 As RichTextBox
			Get
				Return Me._RichTextBox6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox6 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox60 As RichTextBox
			Get
				Return Me._RichTextBox60
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox60 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox61 As RichTextBox
			Get
				Return Me._RichTextBox61
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox61 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox62 As RichTextBox
			Get
				Return Me._RichTextBox62
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox62 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox63 As RichTextBox
			Get
				Return Me._RichTextBox63
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox63 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox64 As RichTextBox
			Get
				Return Me._RichTextBox64
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox64 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox65 As RichTextBox
			Get
				Return Me._RichTextBox65
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox65 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox66 As RichTextBox
			Get
				Return Me._RichTextBox66
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox66 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox67 As RichTextBox
			Get
				Return Me._RichTextBox67
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox67 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox68 As RichTextBox
			Get
				Return Me._RichTextBox68
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox68 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox69 As RichTextBox
			Get
				Return Me._RichTextBox69
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox69 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox7 As RichTextBox
			Get
				Return Me._RichTextBox7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox7 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox70 As RichTextBox
			Get
				Return Me._RichTextBox70
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox70 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox71 As RichTextBox
			Get
				Return Me._RichTextBox71
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox71 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox72 As RichTextBox
			Get
				Return Me._RichTextBox72
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox72 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox73 As RichTextBox
			Get
				Return Me._RichTextBox73
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox73 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox74 As RichTextBox
			Get
				Return Me._RichTextBox74
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox74 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox75 As RichTextBox
			Get
				Return Me._RichTextBox75
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox75 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox76 As RichTextBox
			Get
				Return Me._RichTextBox76
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox76 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox77 As RichTextBox
			Get
				Return Me._RichTextBox77
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox77 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox78 As RichTextBox
			Get
				Return Me._RichTextBox78
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox78 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox79 As RichTextBox
			Get
				Return Me._RichTextBox79
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox79 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox8 As RichTextBox
			Get
				Return Me._RichTextBox8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox8 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox80 As RichTextBox
			Get
				Return Me._RichTextBox80
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox80 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox81 As RichTextBox
			Get
				Return Me._RichTextBox81
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox81 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox82 As RichTextBox
			Get
				Return Me._RichTextBox82
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox82 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox83 As RichTextBox
			Get
				Return Me._RichTextBox83
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox83 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox84 As RichTextBox
			Get
				Return Me._RichTextBox84
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox84 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox85 As RichTextBox
			Get
				Return Me._RichTextBox85
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox85 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox86 As RichTextBox
			Get
				Return Me._RichTextBox86
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox86 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox87 As RichTextBox
			Get
				Return Me._RichTextBox87
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox87 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox88 As RichTextBox
			Get
				Return Me._RichTextBox88
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox88 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox89 As RichTextBox
			Get
				Return Me._RichTextBox89
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox89 = value
			End Set
		End Property

		Friend Overridable Property RichTextBox9 As RichTextBox
			Get
				Return Me._RichTextBox9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox9 = value
			End Set
		End Property

		Public Overridable Property RichTextBox90 As RichTextBox
			Get
				Return Me._RichTextBox90
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox90 = value
			End Set
		End Property

		Friend Overridable Property TabControl1 As TabControl
			Get
				Return Me._TabControl1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		Friend Overridable Property TabPage1 As TabPage
			Get
				Return Me._TabPage1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabPage)
				Me._TabPage1 = value
			End Set
		End Property

		Friend Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim form1 As MAS_Typing.Form1 = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf form1.TextBox1_TextChanged)
				If (Me._TextBox1 IsNot Nothing) Then
					RemoveHandler Me._TextBox1.TextChanged,  eventHandler
				End If
				Me._TextBox1 = value
				If (Me._TextBox1 IsNot Nothing) Then
					AddHandler Me._TextBox1.TextChanged,  eventHandler
				End If
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim form11 As Form1 = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf form11.Form1_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].fonts = Me.ComboBox2.Text
			MySettings.[Default].Save()
			If (Operators.CompareString(Me.ComboBox2.Text, "13", False) = 0) Then
				Dim font As System.Drawing.Font = New System.Drawing.Font("Calibri", 13!)
				Me.RichTextBox1.Font = font
				Me.RichTextBox2.Font = font
				Me.RichTextBox3.Font = font
				Me.RichTextBox4.Font = font
				Me.RichTextBox5.Font = font
				Me.RichTextBox6.Font = font
				Me.RichTextBox7.Font = font
				Me.RichTextBox8.Font = font
				Me.RichTextBox9.Font = font
				Me.RichTextBox10.Font = font
				Me.RichTextBox11.Font = font
				Me.RichTextBox12.Font = font
				Me.RichTextBox13.Font = font
				Me.RichTextBox14.Font = font
				Me.RichTextBox15.Font = font
				Me.RichTextBox16.Font = font
				Me.RichTextBox17.Font = font
				Me.RichTextBox18.Font = font
				Me.RichTextBox19.Font = font
				Me.RichTextBox20.Font = font
				Me.RichTextBox21.Font = font
				Me.RichTextBox22.Font = font
				Me.RichTextBox23.Font = font
				Me.RichTextBox24.Font = font
				Me.RichTextBox25.Font = font
				Me.RichTextBox26.Font = font
				Me.RichTextBox27.Font = font
				Me.RichTextBox28.Font = font
				Me.RichTextBox29.Font = font
				Me.RichTextBox30.Font = font
				Me.RichTextBox31.Font = font
				Me.RichTextBox32.Font = font
				Me.RichTextBox33.Font = font
				Me.RichTextBox34.Font = font
				Me.RichTextBox35.Font = font
				Me.RichTextBox36.Font = font
				Me.RichTextBox37.Font = font
				Me.RichTextBox38.Font = font
				Me.RichTextBox39.Font = font
				Me.RichTextBox40.Font = font
				Me.RichTextBox41.Font = font
				Me.RichTextBox42.Font = font
				Me.RichTextBox43.Font = font
				Me.RichTextBox44.Font = font
				Me.RichTextBox45.Font = font
				Me.RichTextBox46.Font = font
				Me.RichTextBox47.Font = font
				Me.RichTextBox48.Font = font
				Me.RichTextBox49.Font = font
				Me.RichTextBox51.Font = font
				Me.RichTextBox52.Font = font
				Me.RichTextBox53.Font = font
				Me.RichTextBox54.Font = font
				Me.RichTextBox55.Font = font
				Me.RichTextBox56.Font = font
				Me.RichTextBox57.Font = font
				Me.RichTextBox58.Font = font
				Me.RichTextBox59.Font = font
				Me.RichTextBox60.Font = font
				Me.RichTextBox61.Font = font
				Me.RichTextBox62.Font = font
				Me.RichTextBox63.Font = font
				Me.RichTextBox64.Font = font
				Me.RichTextBox65.Font = font
				Me.RichTextBox66.Font = font
				Me.RichTextBox67.Font = font
				Me.RichTextBox68.Font = font
				Me.RichTextBox69.Font = font
				Me.RichTextBox70.Font = font
				Me.RichTextBox71.Font = font
				Me.RichTextBox72.Font = font
				Me.RichTextBox73.Font = font
				Me.RichTextBox74.Font = font
				Me.RichTextBox75.Font = font
				Me.RichTextBox76.Font = font
				Me.RichTextBox77.Font = font
				Me.RichTextBox78.Font = font
				Me.RichTextBox79.Font = font
				Me.RichTextBox80.Font = font
				Me.RichTextBox81.Font = font
				Me.RichTextBox82.Font = font
				Me.RichTextBox83.Font = font
				Me.RichTextBox84.Font = font
				Me.RichTextBox85.Font = font
				Me.RichTextBox86.Font = font
				Me.RichTextBox87.Font = font
				Me.RichTextBox88.Font = font
				Me.RichTextBox89.Font = font
				Me.RichTextBox90.Font = font
			ElseIf (Operators.CompareString(Me.ComboBox2.Text, "14", False) = 0) Then
				Dim font1 As System.Drawing.Font = New System.Drawing.Font("Calibri", 14!)
				Me.RichTextBox1.Font = font1
				Me.RichTextBox2.Font = font1
				Me.RichTextBox3.Font = font1
				Me.RichTextBox4.Font = font1
				Me.RichTextBox5.Font = font1
				Me.RichTextBox6.Font = font1
				Me.RichTextBox7.Font = font1
				Me.RichTextBox8.Font = font1
				Me.RichTextBox9.Font = font1
				Me.RichTextBox10.Font = font1
				Me.RichTextBox11.Font = font1
				Me.RichTextBox12.Font = font1
				Me.RichTextBox13.Font = font1
				Me.RichTextBox14.Font = font1
				Me.RichTextBox15.Font = font1
				Me.RichTextBox16.Font = font1
				Me.RichTextBox17.Font = font1
				Me.RichTextBox18.Font = font1
				Me.RichTextBox19.Font = font1
				Me.RichTextBox20.Font = font1
				Me.RichTextBox21.Font = font1
				Me.RichTextBox22.Font = font1
				Me.RichTextBox23.Font = font1
				Me.RichTextBox24.Font = font1
				Me.RichTextBox25.Font = font1
				Me.RichTextBox26.Font = font1
				Me.RichTextBox27.Font = font1
				Me.RichTextBox28.Font = font1
				Me.RichTextBox29.Font = font1
				Me.RichTextBox30.Font = font1
				Me.RichTextBox31.Font = font1
				Me.RichTextBox32.Font = font1
				Me.RichTextBox33.Font = font1
				Me.RichTextBox34.Font = font1
				Me.RichTextBox35.Font = font1
				Me.RichTextBox36.Font = font1
				Me.RichTextBox37.Font = font1
				Me.RichTextBox38.Font = font1
				Me.RichTextBox39.Font = font1
				Me.RichTextBox40.Font = font1
				Me.RichTextBox41.Font = font1
				Me.RichTextBox42.Font = font1
				Me.RichTextBox43.Font = font1
				Me.RichTextBox44.Font = font1
				Me.RichTextBox45.Font = font1
				Me.RichTextBox46.Font = font1
				Me.RichTextBox47.Font = font1
				Me.RichTextBox48.Font = font1
				Me.RichTextBox49.Font = font1
				Me.RichTextBox51.Font = font1
				Me.RichTextBox52.Font = font1
				Me.RichTextBox53.Font = font1
				Me.RichTextBox54.Font = font1
				Me.RichTextBox55.Font = font1
				Me.RichTextBox56.Font = font1
				Me.RichTextBox57.Font = font1
				Me.RichTextBox58.Font = font1
				Me.RichTextBox59.Font = font1
				Me.RichTextBox60.Font = font1
				Me.RichTextBox61.Font = font1
				Me.RichTextBox62.Font = font1
				Me.RichTextBox63.Font = font1
				Me.RichTextBox64.Font = font1
				Me.RichTextBox65.Font = font1
				Me.RichTextBox66.Font = font1
				Me.RichTextBox67.Font = font1
				Me.RichTextBox68.Font = font1
				Me.RichTextBox69.Font = font1
				Me.RichTextBox70.Font = font1
				Me.RichTextBox71.Font = font1
				Me.RichTextBox72.Font = font1
				Me.RichTextBox73.Font = font1
				Me.RichTextBox74.Font = font1
				Me.RichTextBox75.Font = font1
				Me.RichTextBox76.Font = font1
				Me.RichTextBox77.Font = font1
				Me.RichTextBox78.Font = font1
				Me.RichTextBox79.Font = font1
				Me.RichTextBox80.Font = font1
				Me.RichTextBox81.Font = font1
				Me.RichTextBox82.Font = font1
				Me.RichTextBox83.Font = font1
				Me.RichTextBox84.Font = font1
				Me.RichTextBox85.Font = font1
				Me.RichTextBox86.Font = font1
				Me.RichTextBox87.Font = font1
				Me.RichTextBox88.Font = font1
				Me.RichTextBox89.Font = font1
				Me.RichTextBox90.Font = font1
			ElseIf (Operators.CompareString(Me.ComboBox2.Text, "15", False) = 0) Then
				Dim font2 As System.Drawing.Font = New System.Drawing.Font("Calibri", 15!)
				Me.RichTextBox1.Font = font2
				Me.RichTextBox2.Font = font2
				Me.RichTextBox3.Font = font2
				Me.RichTextBox4.Font = font2
				Me.RichTextBox5.Font = font2
				Me.RichTextBox6.Font = font2
				Me.RichTextBox7.Font = font2
				Me.RichTextBox8.Font = font2
				Me.RichTextBox9.Font = font2
				Me.RichTextBox10.Font = font2
				Me.RichTextBox11.Font = font2
				Me.RichTextBox12.Font = font2
				Me.RichTextBox13.Font = font2
				Me.RichTextBox14.Font = font2
				Me.RichTextBox15.Font = font2
				Me.RichTextBox16.Font = font2
				Me.RichTextBox17.Font = font2
				Me.RichTextBox18.Font = font2
				Me.RichTextBox19.Font = font2
				Me.RichTextBox20.Font = font2
				Me.RichTextBox21.Font = font2
				Me.RichTextBox22.Font = font2
				Me.RichTextBox23.Font = font2
				Me.RichTextBox24.Font = font2
				Me.RichTextBox25.Font = font2
				Me.RichTextBox26.Font = font2
				Me.RichTextBox27.Font = font2
				Me.RichTextBox28.Font = font2
				Me.RichTextBox29.Font = font2
				Me.RichTextBox30.Font = font2
				Me.RichTextBox31.Font = font2
				Me.RichTextBox32.Font = font2
				Me.RichTextBox33.Font = font2
				Me.RichTextBox34.Font = font2
				Me.RichTextBox35.Font = font2
				Me.RichTextBox36.Font = font2
				Me.RichTextBox37.Font = font2
				Me.RichTextBox38.Font = font2
				Me.RichTextBox39.Font = font2
				Me.RichTextBox40.Font = font2
				Me.RichTextBox41.Font = font2
				Me.RichTextBox42.Font = font2
				Me.RichTextBox43.Font = font2
				Me.RichTextBox44.Font = font2
				Me.RichTextBox45.Font = font2
				Me.RichTextBox46.Font = font2
				Me.RichTextBox47.Font = font2
				Me.RichTextBox48.Font = font2
				Me.RichTextBox49.Font = font2
				Me.RichTextBox51.Font = font2
				Me.RichTextBox52.Font = font2
				Me.RichTextBox53.Font = font2
				Me.RichTextBox54.Font = font2
				Me.RichTextBox55.Font = font2
				Me.RichTextBox56.Font = font2
				Me.RichTextBox57.Font = font2
				Me.RichTextBox58.Font = font2
				Me.RichTextBox59.Font = font2
				Me.RichTextBox60.Font = font2
				Me.RichTextBox61.Font = font2
				Me.RichTextBox62.Font = font2
				Me.RichTextBox63.Font = font2
				Me.RichTextBox64.Font = font2
				Me.RichTextBox65.Font = font2
				Me.RichTextBox66.Font = font2
				Me.RichTextBox67.Font = font2
				Me.RichTextBox68.Font = font2
				Me.RichTextBox69.Font = font2
				Me.RichTextBox70.Font = font2
				Me.RichTextBox71.Font = font2
				Me.RichTextBox72.Font = font2
				Me.RichTextBox73.Font = font2
				Me.RichTextBox74.Font = font2
				Me.RichTextBox75.Font = font2
				Me.RichTextBox76.Font = font2
				Me.RichTextBox77.Font = font2
				Me.RichTextBox78.Font = font2
				Me.RichTextBox79.Font = font2
				Me.RichTextBox80.Font = font2
				Me.RichTextBox81.Font = font2
				Me.RichTextBox82.Font = font2
				Me.RichTextBox83.Font = font2
				Me.RichTextBox84.Font = font2
				Me.RichTextBox85.Font = font2
				Me.RichTextBox86.Font = font2
				Me.RichTextBox87.Font = font2
				Me.RichTextBox88.Font = font2
				Me.RichTextBox89.Font = font2
				Me.RichTextBox90.Font = font2
			ElseIf (Operators.CompareString(Me.ComboBox2.Text, "16", False) = 0) Then
				Dim font3 As System.Drawing.Font = New System.Drawing.Font("Calibri", 16!)
				Me.RichTextBox1.Font = font3
				Me.RichTextBox2.Font = font3
				Me.RichTextBox3.Font = font3
				Me.RichTextBox4.Font = font3
				Me.RichTextBox5.Font = font3
				Me.RichTextBox6.Font = font3
				Me.RichTextBox7.Font = font3
				Me.RichTextBox8.Font = font3
				Me.RichTextBox9.Font = font3
				Me.RichTextBox10.Font = font3
				Me.RichTextBox11.Font = font3
				Me.RichTextBox12.Font = font3
				Me.RichTextBox13.Font = font3
				Me.RichTextBox14.Font = font3
				Me.RichTextBox15.Font = font3
				Me.RichTextBox16.Font = font3
				Me.RichTextBox17.Font = font3
				Me.RichTextBox18.Font = font3
				Me.RichTextBox19.Font = font3
				Me.RichTextBox20.Font = font3
				Me.RichTextBox21.Font = font3
				Me.RichTextBox22.Font = font3
				Me.RichTextBox23.Font = font3
				Me.RichTextBox24.Font = font3
				Me.RichTextBox25.Font = font3
				Me.RichTextBox26.Font = font3
				Me.RichTextBox27.Font = font3
				Me.RichTextBox28.Font = font3
				Me.RichTextBox29.Font = font3
				Me.RichTextBox30.Font = font3
				Me.RichTextBox31.Font = font3
				Me.RichTextBox32.Font = font3
				Me.RichTextBox33.Font = font3
				Me.RichTextBox34.Font = font3
				Me.RichTextBox35.Font = font3
				Me.RichTextBox36.Font = font3
				Me.RichTextBox37.Font = font3
				Me.RichTextBox38.Font = font3
				Me.RichTextBox39.Font = font3
				Me.RichTextBox40.Font = font3
				Me.RichTextBox41.Font = font3
				Me.RichTextBox42.Font = font3
				Me.RichTextBox43.Font = font3
				Me.RichTextBox44.Font = font3
				Me.RichTextBox45.Font = font3
				Me.RichTextBox46.Font = font3
				Me.RichTextBox47.Font = font3
				Me.RichTextBox48.Font = font3
				Me.RichTextBox49.Font = font3
				Me.RichTextBox51.Font = font3
				Me.RichTextBox52.Font = font3
				Me.RichTextBox53.Font = font3
				Me.RichTextBox54.Font = font3
				Me.RichTextBox55.Font = font3
				Me.RichTextBox56.Font = font3
				Me.RichTextBox57.Font = font3
				Me.RichTextBox58.Font = font3
				Me.RichTextBox59.Font = font3
				Me.RichTextBox60.Font = font3
				Me.RichTextBox61.Font = font3
				Me.RichTextBox62.Font = font3
				Me.RichTextBox63.Font = font3
				Me.RichTextBox64.Font = font3
				Me.RichTextBox65.Font = font3
				Me.RichTextBox66.Font = font3
				Me.RichTextBox67.Font = font3
				Me.RichTextBox68.Font = font3
				Me.RichTextBox69.Font = font3
				Me.RichTextBox70.Font = font3
				Me.RichTextBox71.Font = font3
				Me.RichTextBox72.Font = font3
				Me.RichTextBox73.Font = font3
				Me.RichTextBox74.Font = font3
				Me.RichTextBox75.Font = font3
				Me.RichTextBox76.Font = font3
				Me.RichTextBox77.Font = font3
				Me.RichTextBox78.Font = font3
				Me.RichTextBox79.Font = font3
				Me.RichTextBox80.Font = font3
				Me.RichTextBox81.Font = font3
				Me.RichTextBox82.Font = font3
				Me.RichTextBox83.Font = font3
				Me.RichTextBox84.Font = font3
				Me.RichTextBox85.Font = font3
				Me.RichTextBox86.Font = font3
				Me.RichTextBox87.Font = font3
				Me.RichTextBox88.Font = font3
				Me.RichTextBox89.Font = font3
				Me.RichTextBox90.Font = font3
			ElseIf (Operators.CompareString(Me.ComboBox2.Text, "17", False) = 0) Then
				Dim font4 As System.Drawing.Font = New System.Drawing.Font("Calibri", 17!)
				Me.RichTextBox1.Font = font4
				Me.RichTextBox2.Font = font4
				Me.RichTextBox3.Font = font4
				Me.RichTextBox4.Font = font4
				Me.RichTextBox5.Font = font4
				Me.RichTextBox6.Font = font4
				Me.RichTextBox7.Font = font4
				Me.RichTextBox8.Font = font4
				Me.RichTextBox9.Font = font4
				Me.RichTextBox10.Font = font4
				Me.RichTextBox11.Font = font4
				Me.RichTextBox12.Font = font4
				Me.RichTextBox13.Font = font4
				Me.RichTextBox14.Font = font4
				Me.RichTextBox15.Font = font4
				Me.RichTextBox16.Font = font4
				Me.RichTextBox17.Font = font4
				Me.RichTextBox18.Font = font4
				Me.RichTextBox19.Font = font4
				Me.RichTextBox20.Font = font4
				Me.RichTextBox21.Font = font4
				Me.RichTextBox22.Font = font4
				Me.RichTextBox23.Font = font4
				Me.RichTextBox24.Font = font4
				Me.RichTextBox25.Font = font4
				Me.RichTextBox26.Font = font4
				Me.RichTextBox27.Font = font4
				Me.RichTextBox28.Font = font4
				Me.RichTextBox29.Font = font4
				Me.RichTextBox30.Font = font4
				Me.RichTextBox31.Font = font4
				Me.RichTextBox32.Font = font4
				Me.RichTextBox33.Font = font4
				Me.RichTextBox34.Font = font4
				Me.RichTextBox35.Font = font4
				Me.RichTextBox36.Font = font4
				Me.RichTextBox37.Font = font4
				Me.RichTextBox38.Font = font4
				Me.RichTextBox39.Font = font4
				Me.RichTextBox40.Font = font4
				Me.RichTextBox41.Font = font4
				Me.RichTextBox42.Font = font4
				Me.RichTextBox43.Font = font4
				Me.RichTextBox44.Font = font4
				Me.RichTextBox45.Font = font4
				Me.RichTextBox46.Font = font4
				Me.RichTextBox47.Font = font4
				Me.RichTextBox48.Font = font4
				Me.RichTextBox49.Font = font4
				Me.RichTextBox51.Font = font4
				Me.RichTextBox52.Font = font4
				Me.RichTextBox53.Font = font4
				Me.RichTextBox54.Font = font4
				Me.RichTextBox55.Font = font4
				Me.RichTextBox56.Font = font4
				Me.RichTextBox57.Font = font4
				Me.RichTextBox58.Font = font4
				Me.RichTextBox59.Font = font4
				Me.RichTextBox60.Font = font4
				Me.RichTextBox61.Font = font4
				Me.RichTextBox62.Font = font4
				Me.RichTextBox63.Font = font4
				Me.RichTextBox64.Font = font4
				Me.RichTextBox65.Font = font4
				Me.RichTextBox66.Font = font4
				Me.RichTextBox67.Font = font4
				Me.RichTextBox68.Font = font4
				Me.RichTextBox69.Font = font4
				Me.RichTextBox70.Font = font4
				Me.RichTextBox71.Font = font4
				Me.RichTextBox72.Font = font4
				Me.RichTextBox73.Font = font4
				Me.RichTextBox74.Font = font4
				Me.RichTextBox75.Font = font4
				Me.RichTextBox76.Font = font4
				Me.RichTextBox77.Font = font4
				Me.RichTextBox78.Font = font4
				Me.RichTextBox79.Font = font4
				Me.RichTextBox80.Font = font4
				Me.RichTextBox81.Font = font4
				Me.RichTextBox82.Font = font4
				Me.RichTextBox83.Font = font4
				Me.RichTextBox84.Font = font4
				Me.RichTextBox85.Font = font4
				Me.RichTextBox86.Font = font4
				Me.RichTextBox87.Font = font4
				Me.RichTextBox88.Font = font4
				Me.RichTextBox89.Font = font4
				Me.RichTextBox90.Font = font4
			End If
		End Sub

		Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].fontc = Me.ComboBox3.Text
			MySettings.[Default].fontc = Me.ComboBox3.Text
			If (Operators.CompareString(Me.ComboBox3.Text, "Black", False) = 0) Then
				Me.PictureBox2.BringToFront()
				Me.RichTextBox1.ForeColor = Color.Black
				Me.RichTextBox2.ForeColor = Color.Black
				Me.RichTextBox3.ForeColor = Color.Black
				Me.RichTextBox4.ForeColor = Color.Black
				Me.RichTextBox5.ForeColor = Color.Black
				Me.RichTextBox6.ForeColor = Color.Black
				Me.RichTextBox7.ForeColor = Color.Black
				Me.RichTextBox8.ForeColor = Color.Black
				Me.RichTextBox9.ForeColor = Color.Black
				Me.RichTextBox10.ForeColor = Color.Black
				Me.RichTextBox11.ForeColor = Color.Black
				Me.RichTextBox12.ForeColor = Color.Black
				Me.RichTextBox13.ForeColor = Color.Black
				Me.RichTextBox14.ForeColor = Color.Black
				Me.RichTextBox15.ForeColor = Color.Black
				Me.RichTextBox16.ForeColor = Color.Black
				Me.RichTextBox17.ForeColor = Color.Black
				Me.RichTextBox18.ForeColor = Color.Black
				Me.RichTextBox19.ForeColor = Color.Black
				Me.RichTextBox20.ForeColor = Color.Black
				Me.RichTextBox21.ForeColor = Color.Black
				Me.RichTextBox22.ForeColor = Color.Black
				Me.RichTextBox23.ForeColor = Color.Black
				Me.RichTextBox24.ForeColor = Color.Black
				Me.RichTextBox25.ForeColor = Color.Black
				Me.RichTextBox26.ForeColor = Color.Black
				Me.RichTextBox27.ForeColor = Color.Black
				Me.RichTextBox28.ForeColor = Color.Black
				Me.RichTextBox29.ForeColor = Color.Black
				Me.RichTextBox30.ForeColor = Color.Black
				Me.RichTextBox31.ForeColor = Color.Black
				Me.RichTextBox32.ForeColor = Color.Black
				Me.RichTextBox33.ForeColor = Color.Black
				Me.RichTextBox34.ForeColor = Color.Black
				Me.RichTextBox35.ForeColor = Color.Black
				Me.RichTextBox36.ForeColor = Color.Black
				Me.RichTextBox37.ForeColor = Color.Black
				Me.RichTextBox38.ForeColor = Color.Black
				Me.RichTextBox39.ForeColor = Color.Black
				Me.RichTextBox40.ForeColor = Color.Black
				Me.RichTextBox41.ForeColor = Color.Black
				Me.RichTextBox42.ForeColor = Color.Black
				Me.RichTextBox43.ForeColor = Color.Black
				Me.RichTextBox44.ForeColor = Color.Black
				Me.RichTextBox45.ForeColor = Color.Black
				Me.RichTextBox46.ForeColor = Color.Black
				Me.RichTextBox47.ForeColor = Color.Black
				Me.RichTextBox48.ForeColor = Color.Black
				Me.RichTextBox49.ForeColor = Color.Black
				Me.RichTextBox50.ForeColor = Color.Black
				Me.RichTextBox51.ForeColor = Color.Black
				Me.RichTextBox52.ForeColor = Color.Black
				Me.RichTextBox53.ForeColor = Color.Black
				Me.RichTextBox54.ForeColor = Color.Black
				Me.RichTextBox55.ForeColor = Color.Black
				Me.RichTextBox56.ForeColor = Color.Black
				Me.RichTextBox57.ForeColor = Color.Black
				Me.RichTextBox58.ForeColor = Color.Black
				Me.RichTextBox59.ForeColor = Color.Black
				Me.RichTextBox60.ForeColor = Color.Black
				Me.RichTextBox61.ForeColor = Color.Black
				Me.RichTextBox62.ForeColor = Color.Black
				Me.RichTextBox63.ForeColor = Color.Black
				Me.RichTextBox64.ForeColor = Color.Black
				Me.RichTextBox65.ForeColor = Color.Black
				Me.RichTextBox66.ForeColor = Color.Black
				Me.RichTextBox67.ForeColor = Color.Black
				Me.RichTextBox68.ForeColor = Color.Black
				Me.RichTextBox69.ForeColor = Color.Black
				Me.RichTextBox70.ForeColor = Color.Black
				Me.RichTextBox71.ForeColor = Color.Black
				Me.RichTextBox72.ForeColor = Color.Black
				Me.RichTextBox73.ForeColor = Color.Black
				Me.RichTextBox74.ForeColor = Color.Black
				Me.RichTextBox75.ForeColor = Color.Black
				Me.RichTextBox76.ForeColor = Color.Black
				Me.RichTextBox77.ForeColor = Color.Black
				Me.RichTextBox78.ForeColor = Color.Black
				Me.RichTextBox79.ForeColor = Color.Black
				Me.RichTextBox80.ForeColor = Color.Black
				Me.RichTextBox81.ForeColor = Color.Black
				Me.RichTextBox82.ForeColor = Color.Black
				Me.RichTextBox83.ForeColor = Color.Black
				Me.RichTextBox84.ForeColor = Color.Black
			ElseIf (Operators.CompareString(Me.ComboBox3.Text, "Red", False) = 0) Then
				Me.PictureBox3.BringToFront()
				Me.RichTextBox1.ForeColor = Color.Red
				Me.RichTextBox2.ForeColor = Color.Red
				Me.RichTextBox3.ForeColor = Color.Red
				Me.RichTextBox4.ForeColor = Color.Red
				Me.RichTextBox5.ForeColor = Color.Red
				Me.RichTextBox6.ForeColor = Color.Red
				Me.RichTextBox7.ForeColor = Color.Red
				Me.RichTextBox8.ForeColor = Color.Red
				Me.RichTextBox9.ForeColor = Color.Red
				Me.RichTextBox10.ForeColor = Color.Red
				Me.RichTextBox11.ForeColor = Color.Red
				Me.RichTextBox12.ForeColor = Color.Red
				Me.RichTextBox13.ForeColor = Color.Red
				Me.RichTextBox14.ForeColor = Color.Red
				Me.RichTextBox15.ForeColor = Color.Red
				Me.RichTextBox16.ForeColor = Color.Red
				Me.RichTextBox17.ForeColor = Color.Red
				Me.RichTextBox18.ForeColor = Color.Red
				Me.RichTextBox19.ForeColor = Color.Red
				Me.RichTextBox20.ForeColor = Color.Red
				Me.RichTextBox21.ForeColor = Color.Red
				Me.RichTextBox22.ForeColor = Color.Red
				Me.RichTextBox23.ForeColor = Color.Red
				Me.RichTextBox24.ForeColor = Color.Red
				Me.RichTextBox25.ForeColor = Color.Red
				Me.RichTextBox26.ForeColor = Color.Red
				Me.RichTextBox27.ForeColor = Color.Red
				Me.RichTextBox28.ForeColor = Color.Red
				Me.RichTextBox29.ForeColor = Color.Red
				Me.RichTextBox30.ForeColor = Color.Red
				Me.RichTextBox31.ForeColor = Color.Red
				Me.RichTextBox32.ForeColor = Color.Red
				Me.RichTextBox33.ForeColor = Color.Red
				Me.RichTextBox34.ForeColor = Color.Red
				Me.RichTextBox35.ForeColor = Color.Red
				Me.RichTextBox36.ForeColor = Color.Red
				Me.RichTextBox37.ForeColor = Color.Red
				Me.RichTextBox38.ForeColor = Color.Red
				Me.RichTextBox39.ForeColor = Color.Red
				Me.RichTextBox40.ForeColor = Color.Red
				Me.RichTextBox41.ForeColor = Color.Red
				Me.RichTextBox42.ForeColor = Color.Red
				Me.RichTextBox43.ForeColor = Color.Red
				Me.RichTextBox44.ForeColor = Color.Red
				Me.RichTextBox45.ForeColor = Color.Red
				Me.RichTextBox46.ForeColor = Color.Red
				Me.RichTextBox47.ForeColor = Color.Red
				Me.RichTextBox48.ForeColor = Color.Red
				Me.RichTextBox49.ForeColor = Color.Red
				Me.RichTextBox50.ForeColor = Color.Red
				Me.RichTextBox51.ForeColor = Color.Red
				Me.RichTextBox52.ForeColor = Color.Red
				Me.RichTextBox53.ForeColor = Color.Red
				Me.RichTextBox54.ForeColor = Color.Red
				Me.RichTextBox55.ForeColor = Color.Red
				Me.RichTextBox56.ForeColor = Color.Red
				Me.RichTextBox57.ForeColor = Color.Red
				Me.RichTextBox58.ForeColor = Color.Red
				Me.RichTextBox59.ForeColor = Color.Red
				Me.RichTextBox60.ForeColor = Color.Red
				Me.RichTextBox61.ForeColor = Color.Red
				Me.RichTextBox62.ForeColor = Color.Red
				Me.RichTextBox63.ForeColor = Color.Red
				Me.RichTextBox64.ForeColor = Color.Red
				Me.RichTextBox65.ForeColor = Color.Red
				Me.RichTextBox66.ForeColor = Color.Red
				Me.RichTextBox67.ForeColor = Color.Red
				Me.RichTextBox68.ForeColor = Color.Red
				Me.RichTextBox69.ForeColor = Color.Red
				Me.RichTextBox70.ForeColor = Color.Red
				Me.RichTextBox71.ForeColor = Color.Red
				Me.RichTextBox72.ForeColor = Color.Red
				Me.RichTextBox73.ForeColor = Color.Red
				Me.RichTextBox74.ForeColor = Color.Red
				Me.RichTextBox75.ForeColor = Color.Red
				Me.RichTextBox76.ForeColor = Color.Red
				Me.RichTextBox77.ForeColor = Color.Red
				Me.RichTextBox78.ForeColor = Color.Red
				Me.RichTextBox79.ForeColor = Color.Red
				Me.RichTextBox80.ForeColor = Color.Red
				Me.RichTextBox81.ForeColor = Color.Red
				Me.RichTextBox82.ForeColor = Color.Red
				Me.RichTextBox83.ForeColor = Color.Red
				Me.RichTextBox84.ForeColor = Color.Red
				Me.RichTextBox85.ForeColor = Color.Red
				Me.RichTextBox86.ForeColor = Color.Red
				Me.RichTextBox87.ForeColor = Color.Red
				Me.RichTextBox88.ForeColor = Color.Red
				Me.RichTextBox89.ForeColor = Color.Red
				Me.RichTextBox90.ForeColor = Color.Red
			End If
		End Sub

		<DebuggerNonUserCode>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Try
				If (disposing AndAlso Me.components IsNot Nothing) Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.ListBox1.SelectedItem = "Lesson 1"
			Me.RichTextBox1.BringToFront()
			Me.RichTextBox1.Text = MySettings.[Default].l1
			Me.RichTextBox2.Text = MySettings.[Default].l2
			Me.RichTextBox3.Text = MySettings.[Default].l3
			Me.RichTextBox4.Text = MySettings.[Default].l4
			Me.RichTextBox5.Text = MySettings.[Default].l5
			Me.RichTextBox6.Text = MySettings.[Default].l6
			Me.RichTextBox7.Text = MySettings.[Default].l7
			Me.RichTextBox8.Text = MySettings.[Default].l8
			Me.RichTextBox9.Text = MySettings.[Default].l9
			Me.RichTextBox10.Text = MySettings.[Default].l10
			Me.RichTextBox11.Text = MySettings.[Default].l11
			Me.RichTextBox12.Text = MySettings.[Default].l12
			Me.RichTextBox13.Text = MySettings.[Default].l13
			Me.RichTextBox14.Text = MySettings.[Default].l14
			Me.RichTextBox15.Text = MySettings.[Default].l15
			Me.RichTextBox16.Text = MySettings.[Default].l16
			Me.RichTextBox17.Text = MySettings.[Default].l17
			Me.RichTextBox18.Text = MySettings.[Default].l18
			Me.RichTextBox19.Text = MySettings.[Default].l19
			Me.RichTextBox20.Text = MySettings.[Default].l20
			Me.RichTextBox21.Text = MySettings.[Default].l21
			Me.RichTextBox22.Text = MySettings.[Default].l22
			Me.RichTextBox23.Text = MySettings.[Default].l23
			Me.RichTextBox24.Text = MySettings.[Default].l24
			Me.RichTextBox25.Text = MySettings.[Default].l25
			Me.RichTextBox26.Text = MySettings.[Default].l26
			Me.RichTextBox27.Text = MySettings.[Default].l27
			Me.RichTextBox28.Text = MySettings.[Default].l28
			Me.RichTextBox29.Text = MySettings.[Default].l29
			Me.RichTextBox30.Text = MySettings.[Default].l30
			Me.RichTextBox31.Text = MySettings.[Default].l31
			Me.RichTextBox32.Text = MySettings.[Default].l32
			Me.RichTextBox33.Text = MySettings.[Default].l33
			Me.RichTextBox34.Text = MySettings.[Default].l34
			Me.RichTextBox35.Text = MySettings.[Default].l35
			Me.RichTextBox36.Text = MySettings.[Default].l36
			Me.RichTextBox37.Text = MySettings.[Default].l37
			Me.RichTextBox38.Text = MySettings.[Default].l38
			Me.RichTextBox39.Text = MySettings.[Default].l39
			Me.RichTextBox40.Text = MySettings.[Default].l40
			Me.RichTextBox41.Text = MySettings.[Default].l41
			Me.RichTextBox42.Text = MySettings.[Default].l42
			Me.RichTextBox43.Text = MySettings.[Default].l43
			Me.RichTextBox44.Text = MySettings.[Default].l44
			Me.RichTextBox45.Text = MySettings.[Default].l45
			Me.RichTextBox46.Text = MySettings.[Default].l46
			Me.RichTextBox47.Text = MySettings.[Default].l47
			Me.RichTextBox48.Text = MySettings.[Default].l48
			Me.RichTextBox49.Text = MySettings.[Default].l49
			Me.RichTextBox50.Text = MySettings.[Default].l50
			Me.RichTextBox51.Text = MySettings.[Default].l51
			Me.RichTextBox52.Text = MySettings.[Default].l52
			Me.RichTextBox53.Text = MySettings.[Default].l53
			Me.RichTextBox54.Text = MySettings.[Default].l54
			Me.RichTextBox55.Text = MySettings.[Default].l55
			Me.RichTextBox56.Text = MySettings.[Default].l56
			Me.RichTextBox57.Text = MySettings.[Default].l57
			Me.RichTextBox58.Text = MySettings.[Default].l58
			Me.RichTextBox59.Text = MySettings.[Default].l59
			Me.RichTextBox60.Text = MySettings.[Default].l60
			Me.RichTextBox61.Text = MySettings.[Default].l61
			Me.RichTextBox62.Text = MySettings.[Default].l62
			Me.RichTextBox63.Text = MySettings.[Default].l63
			Me.RichTextBox64.Text = MySettings.[Default].l64
			Me.RichTextBox65.Text = MySettings.[Default].l65
			Me.RichTextBox66.Text = MySettings.[Default].l67
			Me.RichTextBox68.Text = MySettings.[Default].l68
			Me.RichTextBox69.Text = MySettings.[Default].l69
			Me.RichTextBox70.Text = MySettings.[Default].l70
			Me.RichTextBox71.Text = MySettings.[Default].l71
			Me.RichTextBox72.Text = MySettings.[Default].l72
			Me.RichTextBox73.Text = MySettings.[Default].l73
			Me.RichTextBox74.Text = MySettings.[Default].l74
			Me.RichTextBox75.Text = MySettings.[Default].l75
			Me.RichTextBox76.Text = MySettings.[Default].l76
			Me.RichTextBox77.Text = MySettings.[Default].l77
			Me.RichTextBox78.Text = MySettings.[Default].l78
			Me.RichTextBox79.Text = MySettings.[Default].l79
			Me.RichTextBox80.Text = MySettings.[Default].l80
			Me.RichTextBox81.Text = MySettings.[Default].l81
			Me.RichTextBox82.Text = MySettings.[Default].l82
			Me.RichTextBox83.Text = MySettings.[Default].l83
			Me.RichTextBox84.Text = MySettings.[Default].l84
			Me.RichTextBox85.Text = MySettings.[Default].l85
			Me.RichTextBox86.Text = MySettings.[Default].l86
			Me.RichTextBox87.Text = MySettings.[Default].l87
			Me.RichTextBox88.Text = MySettings.[Default].l88
			Me.RichTextBox89.Text = MySettings.[Default].l89
			Me.RichTextBox90.Text = MySettings.[Default].l90
			If (Operators.CompareString(MySettings.[Default].fonts, "13", False) = 0) Then
				Dim font As System.Drawing.Font = New System.Drawing.Font("Calibri", 13!)
				Me.RichTextBox1.Font = font
				Me.RichTextBox2.Font = font
				Me.RichTextBox3.Font = font
				Me.RichTextBox4.Font = font
				Me.RichTextBox5.Font = font
				Me.RichTextBox6.Font = font
				Me.RichTextBox7.Font = font
				Me.RichTextBox8.Font = font
				Me.RichTextBox9.Font = font
				Me.RichTextBox10.Font = font
				Me.RichTextBox11.Font = font
				Me.RichTextBox12.Font = font
				Me.RichTextBox13.Font = font
				Me.RichTextBox14.Font = font
				Me.RichTextBox15.Font = font
				Me.RichTextBox16.Font = font
				Me.RichTextBox17.Font = font
				Me.RichTextBox18.Font = font
				Me.RichTextBox19.Font = font
				Me.RichTextBox20.Font = font
				Me.RichTextBox21.Font = font
				Me.RichTextBox22.Font = font
				Me.RichTextBox23.Font = font
				Me.RichTextBox24.Font = font
				Me.RichTextBox25.Font = font
				Me.RichTextBox26.Font = font
				Me.RichTextBox27.Font = font
				Me.RichTextBox28.Font = font
				Me.RichTextBox29.Font = font
				Me.RichTextBox30.Font = font
				Me.RichTextBox31.Font = font
				Me.RichTextBox32.Font = font
				Me.RichTextBox33.Font = font
				Me.RichTextBox34.Font = font
				Me.RichTextBox35.Font = font
				Me.RichTextBox36.Font = font
				Me.RichTextBox37.Font = font
				Me.RichTextBox38.Font = font
				Me.RichTextBox39.Font = font
				Me.RichTextBox40.Font = font
				Me.RichTextBox41.Font = font
				Me.RichTextBox42.Font = font
				Me.RichTextBox43.Font = font
				Me.RichTextBox44.Font = font
				Me.RichTextBox45.Font = font
				Me.RichTextBox46.Font = font
				Me.RichTextBox47.Font = font
				Me.RichTextBox48.Font = font
				Me.RichTextBox49.Font = font
				Me.RichTextBox51.Font = font
				Me.RichTextBox52.Font = font
				Me.RichTextBox53.Font = font
				Me.RichTextBox54.Font = font
				Me.RichTextBox55.Font = font
				Me.RichTextBox56.Font = font
				Me.RichTextBox57.Font = font
				Me.RichTextBox58.Font = font
				Me.RichTextBox59.Font = font
				Me.RichTextBox60.Font = font
				Me.RichTextBox61.Font = font
				Me.RichTextBox62.Font = font
				Me.RichTextBox63.Font = font
				Me.RichTextBox64.Font = font
				Me.RichTextBox65.Font = font
				Me.RichTextBox66.Font = font
				Me.RichTextBox67.Font = font
				Me.RichTextBox68.Font = font
				Me.RichTextBox69.Font = font
				Me.RichTextBox70.Font = font
				Me.RichTextBox71.Font = font
				Me.RichTextBox72.Font = font
				Me.RichTextBox73.Font = font
				Me.RichTextBox74.Font = font
				Me.RichTextBox75.Font = font
				Me.RichTextBox76.Font = font
				Me.RichTextBox77.Font = font
				Me.RichTextBox78.Font = font
				Me.RichTextBox79.Font = font
				Me.RichTextBox80.Font = font
				Me.RichTextBox81.Font = font
				Me.RichTextBox82.Font = font
				Me.RichTextBox83.Font = font
				Me.RichTextBox84.Font = font
				Me.RichTextBox85.Font = font
				Me.RichTextBox86.Font = font
				Me.RichTextBox87.Font = font
				Me.RichTextBox88.Font = font
				Me.RichTextBox89.Font = font
				Me.RichTextBox90.Font = font
			ElseIf (Operators.CompareString(MySettings.[Default].fonts, "14", False) = 0) Then
				Dim font1 As System.Drawing.Font = New System.Drawing.Font("Calibri", 14!)
				Me.RichTextBox1.Font = font1
				Me.RichTextBox2.Font = font1
				Me.RichTextBox3.Font = font1
				Me.RichTextBox4.Font = font1
				Me.RichTextBox5.Font = font1
				Me.RichTextBox6.Font = font1
				Me.RichTextBox7.Font = font1
				Me.RichTextBox8.Font = font1
				Me.RichTextBox9.Font = font1
				Me.RichTextBox10.Font = font1
				Me.RichTextBox11.Font = font1
				Me.RichTextBox12.Font = font1
				Me.RichTextBox13.Font = font1
				Me.RichTextBox14.Font = font1
				Me.RichTextBox15.Font = font1
				Me.RichTextBox16.Font = font1
				Me.RichTextBox17.Font = font1
				Me.RichTextBox18.Font = font1
				Me.RichTextBox19.Font = font1
				Me.RichTextBox20.Font = font1
				Me.RichTextBox21.Font = font1
				Me.RichTextBox22.Font = font1
				Me.RichTextBox23.Font = font1
				Me.RichTextBox24.Font = font1
				Me.RichTextBox25.Font = font1
				Me.RichTextBox26.Font = font1
				Me.RichTextBox27.Font = font1
				Me.RichTextBox28.Font = font1
				Me.RichTextBox29.Font = font1
				Me.RichTextBox30.Font = font1
				Me.RichTextBox31.Font = font1
				Me.RichTextBox32.Font = font1
				Me.RichTextBox33.Font = font1
				Me.RichTextBox34.Font = font1
				Me.RichTextBox35.Font = font1
				Me.RichTextBox36.Font = font1
				Me.RichTextBox37.Font = font1
				Me.RichTextBox38.Font = font1
				Me.RichTextBox39.Font = font1
				Me.RichTextBox40.Font = font1
				Me.RichTextBox41.Font = font1
				Me.RichTextBox42.Font = font1
				Me.RichTextBox43.Font = font1
				Me.RichTextBox44.Font = font1
				Me.RichTextBox45.Font = font1
				Me.RichTextBox46.Font = font1
				Me.RichTextBox47.Font = font1
				Me.RichTextBox48.Font = font1
				Me.RichTextBox49.Font = font1
				Me.RichTextBox51.Font = font1
				Me.RichTextBox52.Font = font1
				Me.RichTextBox53.Font = font1
				Me.RichTextBox54.Font = font1
				Me.RichTextBox55.Font = font1
				Me.RichTextBox56.Font = font1
				Me.RichTextBox57.Font = font1
				Me.RichTextBox58.Font = font1
				Me.RichTextBox59.Font = font1
				Me.RichTextBox60.Font = font1
				Me.RichTextBox61.Font = font1
				Me.RichTextBox62.Font = font1
				Me.RichTextBox63.Font = font1
				Me.RichTextBox64.Font = font1
				Me.RichTextBox65.Font = font1
				Me.RichTextBox66.Font = font1
				Me.RichTextBox67.Font = font1
				Me.RichTextBox68.Font = font1
				Me.RichTextBox69.Font = font1
				Me.RichTextBox70.Font = font1
				Me.RichTextBox71.Font = font1
				Me.RichTextBox72.Font = font1
				Me.RichTextBox73.Font = font1
				Me.RichTextBox74.Font = font1
				Me.RichTextBox75.Font = font1
				Me.RichTextBox76.Font = font1
				Me.RichTextBox77.Font = font1
				Me.RichTextBox78.Font = font1
				Me.RichTextBox79.Font = font1
				Me.RichTextBox80.Font = font1
				Me.RichTextBox81.Font = font1
				Me.RichTextBox82.Font = font1
				Me.RichTextBox83.Font = font1
				Me.RichTextBox84.Font = font1
				Me.RichTextBox85.Font = font1
				Me.RichTextBox86.Font = font1
				Me.RichTextBox87.Font = font1
				Me.RichTextBox88.Font = font1
				Me.RichTextBox89.Font = font1
				Me.RichTextBox90.Font = font1
			ElseIf (Operators.CompareString(MySettings.[Default].fonts, "15", False) = 0) Then
				Dim font2 As System.Drawing.Font = New System.Drawing.Font("Calibri", 15!)
				Me.RichTextBox1.Font = font2
				Me.RichTextBox2.Font = font2
				Me.RichTextBox3.Font = font2
				Me.RichTextBox4.Font = font2
				Me.RichTextBox5.Font = font2
				Me.RichTextBox6.Font = font2
				Me.RichTextBox7.Font = font2
				Me.RichTextBox8.Font = font2
				Me.RichTextBox9.Font = font2
				Me.RichTextBox10.Font = font2
				Me.RichTextBox11.Font = font2
				Me.RichTextBox12.Font = font2
				Me.RichTextBox13.Font = font2
				Me.RichTextBox14.Font = font2
				Me.RichTextBox15.Font = font2
				Me.RichTextBox16.Font = font2
				Me.RichTextBox17.Font = font2
				Me.RichTextBox18.Font = font2
				Me.RichTextBox19.Font = font2
				Me.RichTextBox20.Font = font2
				Me.RichTextBox21.Font = font2
				Me.RichTextBox22.Font = font2
				Me.RichTextBox23.Font = font2
				Me.RichTextBox24.Font = font2
				Me.RichTextBox25.Font = font2
				Me.RichTextBox26.Font = font2
				Me.RichTextBox27.Font = font2
				Me.RichTextBox28.Font = font2
				Me.RichTextBox29.Font = font2
				Me.RichTextBox30.Font = font2
				Me.RichTextBox31.Font = font2
				Me.RichTextBox32.Font = font2
				Me.RichTextBox33.Font = font2
				Me.RichTextBox34.Font = font2
				Me.RichTextBox35.Font = font2
				Me.RichTextBox36.Font = font2
				Me.RichTextBox37.Font = font2
				Me.RichTextBox38.Font = font2
				Me.RichTextBox39.Font = font2
				Me.RichTextBox40.Font = font2
				Me.RichTextBox41.Font = font2
				Me.RichTextBox42.Font = font2
				Me.RichTextBox43.Font = font2
				Me.RichTextBox44.Font = font2
				Me.RichTextBox45.Font = font2
				Me.RichTextBox46.Font = font2
				Me.RichTextBox47.Font = font2
				Me.RichTextBox48.Font = font2
				Me.RichTextBox49.Font = font2
				Me.RichTextBox51.Font = font2
				Me.RichTextBox52.Font = font2
				Me.RichTextBox53.Font = font2
				Me.RichTextBox54.Font = font2
				Me.RichTextBox55.Font = font2
				Me.RichTextBox56.Font = font2
				Me.RichTextBox57.Font = font2
				Me.RichTextBox58.Font = font2
				Me.RichTextBox59.Font = font2
				Me.RichTextBox60.Font = font2
				Me.RichTextBox61.Font = font2
				Me.RichTextBox62.Font = font2
				Me.RichTextBox63.Font = font2
				Me.RichTextBox64.Font = font2
				Me.RichTextBox65.Font = font2
				Me.RichTextBox66.Font = font2
				Me.RichTextBox67.Font = font2
				Me.RichTextBox68.Font = font2
				Me.RichTextBox69.Font = font2
				Me.RichTextBox70.Font = font2
				Me.RichTextBox71.Font = font2
				Me.RichTextBox72.Font = font2
				Me.RichTextBox73.Font = font2
				Me.RichTextBox74.Font = font2
				Me.RichTextBox75.Font = font2
				Me.RichTextBox76.Font = font2
				Me.RichTextBox77.Font = font2
				Me.RichTextBox78.Font = font2
				Me.RichTextBox79.Font = font2
				Me.RichTextBox80.Font = font2
				Me.RichTextBox81.Font = font2
				Me.RichTextBox82.Font = font2
				Me.RichTextBox83.Font = font2
				Me.RichTextBox84.Font = font2
				Me.RichTextBox85.Font = font2
				Me.RichTextBox86.Font = font2
				Me.RichTextBox87.Font = font2
				Me.RichTextBox88.Font = font2
				Me.RichTextBox89.Font = font2
				Me.RichTextBox90.Font = font2
			ElseIf (Operators.CompareString(MySettings.[Default].fonts, "16", False) = 0) Then
				Dim font3 As System.Drawing.Font = New System.Drawing.Font("Calibri", 16!)
				Me.RichTextBox1.Font = font3
				Me.RichTextBox2.Font = font3
				Me.RichTextBox3.Font = font3
				Me.RichTextBox4.Font = font3
				Me.RichTextBox5.Font = font3
				Me.RichTextBox6.Font = font3
				Me.RichTextBox7.Font = font3
				Me.RichTextBox8.Font = font3
				Me.RichTextBox9.Font = font3
				Me.RichTextBox10.Font = font3
				Me.RichTextBox11.Font = font3
				Me.RichTextBox12.Font = font3
				Me.RichTextBox13.Font = font3
				Me.RichTextBox14.Font = font3
				Me.RichTextBox15.Font = font3
				Me.RichTextBox16.Font = font3
				Me.RichTextBox17.Font = font3
				Me.RichTextBox18.Font = font3
				Me.RichTextBox19.Font = font3
				Me.RichTextBox20.Font = font3
				Me.RichTextBox21.Font = font3
				Me.RichTextBox22.Font = font3
				Me.RichTextBox23.Font = font3
				Me.RichTextBox24.Font = font3
				Me.RichTextBox25.Font = font3
				Me.RichTextBox26.Font = font3
				Me.RichTextBox27.Font = font3
				Me.RichTextBox28.Font = font3
				Me.RichTextBox29.Font = font3
				Me.RichTextBox30.Font = font3
				Me.RichTextBox31.Font = font3
				Me.RichTextBox32.Font = font3
				Me.RichTextBox33.Font = font3
				Me.RichTextBox34.Font = font3
				Me.RichTextBox35.Font = font3
				Me.RichTextBox36.Font = font3
				Me.RichTextBox37.Font = font3
				Me.RichTextBox38.Font = font3
				Me.RichTextBox39.Font = font3
				Me.RichTextBox40.Font = font3
				Me.RichTextBox41.Font = font3
				Me.RichTextBox42.Font = font3
				Me.RichTextBox43.Font = font3
				Me.RichTextBox44.Font = font3
				Me.RichTextBox45.Font = font3
				Me.RichTextBox46.Font = font3
				Me.RichTextBox47.Font = font3
				Me.RichTextBox48.Font = font3
				Me.RichTextBox49.Font = font3
				Me.RichTextBox51.Font = font3
				Me.RichTextBox52.Font = font3
				Me.RichTextBox53.Font = font3
				Me.RichTextBox54.Font = font3
				Me.RichTextBox55.Font = font3
				Me.RichTextBox56.Font = font3
				Me.RichTextBox57.Font = font3
				Me.RichTextBox58.Font = font3
				Me.RichTextBox59.Font = font3
				Me.RichTextBox60.Font = font3
				Me.RichTextBox61.Font = font3
				Me.RichTextBox62.Font = font3
				Me.RichTextBox63.Font = font3
				Me.RichTextBox64.Font = font3
				Me.RichTextBox65.Font = font3
				Me.RichTextBox66.Font = font3
				Me.RichTextBox67.Font = font3
				Me.RichTextBox68.Font = font3
				Me.RichTextBox69.Font = font3
				Me.RichTextBox70.Font = font3
				Me.RichTextBox71.Font = font3
				Me.RichTextBox72.Font = font3
				Me.RichTextBox73.Font = font3
				Me.RichTextBox74.Font = font3
				Me.RichTextBox75.Font = font3
				Me.RichTextBox76.Font = font3
				Me.RichTextBox77.Font = font3
				Me.RichTextBox78.Font = font3
				Me.RichTextBox79.Font = font3
				Me.RichTextBox80.Font = font3
				Me.RichTextBox81.Font = font3
				Me.RichTextBox82.Font = font3
				Me.RichTextBox83.Font = font3
				Me.RichTextBox84.Font = font3
				Me.RichTextBox85.Font = font3
				Me.RichTextBox86.Font = font3
				Me.RichTextBox87.Font = font3
				Me.RichTextBox88.Font = font3
				Me.RichTextBox89.Font = font3
				Me.RichTextBox90.Font = font3
			ElseIf (Operators.CompareString(MySettings.[Default].fonts, "17", False) = 0) Then
				Dim font4 As System.Drawing.Font = New System.Drawing.Font("Calibri", 17!)
				Me.RichTextBox1.Font = font4
				Me.RichTextBox2.Font = font4
				Me.RichTextBox3.Font = font4
				Me.RichTextBox4.Font = font4
				Me.RichTextBox5.Font = font4
				Me.RichTextBox6.Font = font4
				Me.RichTextBox7.Font = font4
				Me.RichTextBox8.Font = font4
				Me.RichTextBox9.Font = font4
				Me.RichTextBox10.Font = font4
				Me.RichTextBox11.Font = font4
				Me.RichTextBox12.Font = font4
				Me.RichTextBox13.Font = font4
				Me.RichTextBox14.Font = font4
				Me.RichTextBox15.Font = font4
				Me.RichTextBox16.Font = font4
				Me.RichTextBox17.Font = font4
				Me.RichTextBox18.Font = font4
				Me.RichTextBox19.Font = font4
				Me.RichTextBox20.Font = font4
				Me.RichTextBox21.Font = font4
				Me.RichTextBox22.Font = font4
				Me.RichTextBox23.Font = font4
				Me.RichTextBox24.Font = font4
				Me.RichTextBox25.Font = font4
				Me.RichTextBox26.Font = font4
				Me.RichTextBox27.Font = font4
				Me.RichTextBox28.Font = font4
				Me.RichTextBox29.Font = font4
				Me.RichTextBox30.Font = font4
				Me.RichTextBox31.Font = font4
				Me.RichTextBox32.Font = font4
				Me.RichTextBox33.Font = font4
				Me.RichTextBox34.Font = font4
				Me.RichTextBox35.Font = font4
				Me.RichTextBox36.Font = font4
				Me.RichTextBox37.Font = font4
				Me.RichTextBox38.Font = font4
				Me.RichTextBox39.Font = font4
				Me.RichTextBox40.Font = font4
				Me.RichTextBox41.Font = font4
				Me.RichTextBox42.Font = font4
				Me.RichTextBox43.Font = font4
				Me.RichTextBox44.Font = font4
				Me.RichTextBox45.Font = font4
				Me.RichTextBox46.Font = font4
				Me.RichTextBox47.Font = font4
				Me.RichTextBox48.Font = font4
				Me.RichTextBox49.Font = font4
				Me.RichTextBox51.Font = font4
				Me.RichTextBox52.Font = font4
				Me.RichTextBox53.Font = font4
				Me.RichTextBox54.Font = font4
				Me.RichTextBox55.Font = font4
				Me.RichTextBox56.Font = font4
				Me.RichTextBox57.Font = font4
				Me.RichTextBox58.Font = font4
				Me.RichTextBox59.Font = font4
				Me.RichTextBox60.Font = font4
				Me.RichTextBox61.Font = font4
				Me.RichTextBox62.Font = font4
				Me.RichTextBox63.Font = font4
				Me.RichTextBox64.Font = font4
				Me.RichTextBox65.Font = font4
				Me.RichTextBox66.Font = font4
				Me.RichTextBox67.Font = font4
				Me.RichTextBox68.Font = font4
				Me.RichTextBox69.Font = font4
				Me.RichTextBox70.Font = font4
				Me.RichTextBox71.Font = font4
				Me.RichTextBox72.Font = font4
				Me.RichTextBox73.Font = font4
				Me.RichTextBox74.Font = font4
				Me.RichTextBox75.Font = font4
				Me.RichTextBox76.Font = font4
				Me.RichTextBox77.Font = font4
				Me.RichTextBox78.Font = font4
				Me.RichTextBox79.Font = font4
				Me.RichTextBox80.Font = font4
				Me.RichTextBox81.Font = font4
				Me.RichTextBox82.Font = font4
				Me.RichTextBox83.Font = font4
				Me.RichTextBox84.Font = font4
				Me.RichTextBox85.Font = font4
				Me.RichTextBox86.Font = font4
				Me.RichTextBox87.Font = font4
				Me.RichTextBox88.Font = font4
				Me.RichTextBox89.Font = font4
				Me.RichTextBox90.Font = font4
			End If
			If (Operators.CompareString(MySettings.[Default].fontc, "Black", False) = 0) Then
				Me.PictureBox2.BringToFront()
				Me.RichTextBox1.ForeColor = Color.Black
				Me.RichTextBox2.ForeColor = Color.Black
				Me.RichTextBox3.ForeColor = Color.Black
				Me.RichTextBox4.ForeColor = Color.Black
				Me.RichTextBox5.ForeColor = Color.Black
				Me.RichTextBox6.ForeColor = Color.Black
				Me.RichTextBox7.ForeColor = Color.Black
				Me.RichTextBox8.ForeColor = Color.Black
				Me.RichTextBox9.ForeColor = Color.Black
				Me.RichTextBox10.ForeColor = Color.Black
				Me.RichTextBox11.ForeColor = Color.Black
				Me.RichTextBox12.ForeColor = Color.Black
				Me.RichTextBox13.ForeColor = Color.Black
				Me.RichTextBox14.ForeColor = Color.Black
				Me.RichTextBox15.ForeColor = Color.Black
				Me.RichTextBox16.ForeColor = Color.Black
				Me.RichTextBox17.ForeColor = Color.Black
				Me.RichTextBox18.ForeColor = Color.Black
				Me.RichTextBox19.ForeColor = Color.Black
				Me.RichTextBox20.ForeColor = Color.Black
				Me.RichTextBox21.ForeColor = Color.Black
				Me.RichTextBox22.ForeColor = Color.Black
				Me.RichTextBox23.ForeColor = Color.Black
				Me.RichTextBox24.ForeColor = Color.Black
				Me.RichTextBox25.ForeColor = Color.Black
				Me.RichTextBox26.ForeColor = Color.Black
				Me.RichTextBox27.ForeColor = Color.Black
				Me.RichTextBox28.ForeColor = Color.Black
				Me.RichTextBox29.ForeColor = Color.Black
				Me.RichTextBox30.ForeColor = Color.Black
				Me.RichTextBox31.ForeColor = Color.Black
				Me.RichTextBox32.ForeColor = Color.Black
				Me.RichTextBox33.ForeColor = Color.Black
				Me.RichTextBox34.ForeColor = Color.Black
				Me.RichTextBox35.ForeColor = Color.Black
				Me.RichTextBox36.ForeColor = Color.Black
				Me.RichTextBox37.ForeColor = Color.Black
				Me.RichTextBox38.ForeColor = Color.Black
				Me.RichTextBox39.ForeColor = Color.Black
				Me.RichTextBox40.ForeColor = Color.Black
				Me.RichTextBox41.ForeColor = Color.Black
				Me.RichTextBox42.ForeColor = Color.Black
				Me.RichTextBox43.ForeColor = Color.Black
				Me.RichTextBox44.ForeColor = Color.Black
				Me.RichTextBox45.ForeColor = Color.Black
				Me.RichTextBox46.ForeColor = Color.Black
				Me.RichTextBox47.ForeColor = Color.Black
				Me.RichTextBox48.ForeColor = Color.Black
				Me.RichTextBox49.ForeColor = Color.Black
				Me.RichTextBox50.ForeColor = Color.Black
				Me.RichTextBox51.ForeColor = Color.Black
				Me.RichTextBox52.ForeColor = Color.Black
				Me.RichTextBox53.ForeColor = Color.Black
				Me.RichTextBox54.ForeColor = Color.Black
				Me.RichTextBox55.ForeColor = Color.Black
				Me.RichTextBox56.ForeColor = Color.Black
				Me.RichTextBox57.ForeColor = Color.Black
				Me.RichTextBox58.ForeColor = Color.Black
				Me.RichTextBox59.ForeColor = Color.Black
				Me.RichTextBox60.ForeColor = Color.Black
				Me.RichTextBox61.ForeColor = Color.Black
				Me.RichTextBox62.ForeColor = Color.Black
				Me.RichTextBox63.ForeColor = Color.Black
				Me.RichTextBox64.ForeColor = Color.Black
				Me.RichTextBox65.ForeColor = Color.Black
				Me.RichTextBox66.ForeColor = Color.Black
				Me.RichTextBox67.ForeColor = Color.Black
				Me.RichTextBox68.ForeColor = Color.Black
				Me.RichTextBox69.ForeColor = Color.Black
				Me.RichTextBox70.ForeColor = Color.Black
				Me.RichTextBox71.ForeColor = Color.Black
				Me.RichTextBox72.ForeColor = Color.Black
				Me.RichTextBox73.ForeColor = Color.Black
				Me.RichTextBox74.ForeColor = Color.Black
				Me.RichTextBox75.ForeColor = Color.Black
				Me.RichTextBox76.ForeColor = Color.Black
				Me.RichTextBox77.ForeColor = Color.Black
				Me.RichTextBox78.ForeColor = Color.Black
				Me.RichTextBox79.ForeColor = Color.Black
				Me.RichTextBox80.ForeColor = Color.Black
				Me.RichTextBox81.ForeColor = Color.Black
				Me.RichTextBox82.ForeColor = Color.Black
				Me.RichTextBox83.ForeColor = Color.Black
				Me.RichTextBox84.ForeColor = Color.Black
			ElseIf (Operators.CompareString(MySettings.[Default].fontc, "Red", False) = 0) Then
				Me.PictureBox3.BringToFront()
				Me.RichTextBox1.ForeColor = Color.Red
				Me.RichTextBox2.ForeColor = Color.Red
				Me.RichTextBox3.ForeColor = Color.Red
				Me.RichTextBox4.ForeColor = Color.Red
				Me.RichTextBox5.ForeColor = Color.Red
				Me.RichTextBox6.ForeColor = Color.Red
				Me.RichTextBox7.ForeColor = Color.Red
				Me.RichTextBox8.ForeColor = Color.Red
				Me.RichTextBox9.ForeColor = Color.Red
				Me.RichTextBox10.ForeColor = Color.Red
				Me.RichTextBox11.ForeColor = Color.Red
				Me.RichTextBox12.ForeColor = Color.Red
				Me.RichTextBox13.ForeColor = Color.Red
				Me.RichTextBox14.ForeColor = Color.Red
				Me.RichTextBox15.ForeColor = Color.Red
				Me.RichTextBox16.ForeColor = Color.Red
				Me.RichTextBox17.ForeColor = Color.Red
				Me.RichTextBox18.ForeColor = Color.Red
				Me.RichTextBox19.ForeColor = Color.Red
				Me.RichTextBox20.ForeColor = Color.Red
				Me.RichTextBox21.ForeColor = Color.Red
				Me.RichTextBox22.ForeColor = Color.Red
				Me.RichTextBox23.ForeColor = Color.Red
				Me.RichTextBox24.ForeColor = Color.Red
				Me.RichTextBox25.ForeColor = Color.Red
				Me.RichTextBox26.ForeColor = Color.Red
				Me.RichTextBox27.ForeColor = Color.Red
				Me.RichTextBox28.ForeColor = Color.Red
				Me.RichTextBox29.ForeColor = Color.Red
				Me.RichTextBox30.ForeColor = Color.Red
				Me.RichTextBox31.ForeColor = Color.Red
				Me.RichTextBox32.ForeColor = Color.Red
				Me.RichTextBox33.ForeColor = Color.Red
				Me.RichTextBox34.ForeColor = Color.Red
				Me.RichTextBox35.ForeColor = Color.Red
				Me.RichTextBox36.ForeColor = Color.Red
				Me.RichTextBox37.ForeColor = Color.Red
				Me.RichTextBox38.ForeColor = Color.Red
				Me.RichTextBox39.ForeColor = Color.Red
				Me.RichTextBox40.ForeColor = Color.Red
				Me.RichTextBox41.ForeColor = Color.Red
				Me.RichTextBox42.ForeColor = Color.Red
				Me.RichTextBox43.ForeColor = Color.Red
				Me.RichTextBox44.ForeColor = Color.Red
				Me.RichTextBox45.ForeColor = Color.Red
				Me.RichTextBox46.ForeColor = Color.Red
				Me.RichTextBox47.ForeColor = Color.Red
				Me.RichTextBox48.ForeColor = Color.Red
				Me.RichTextBox49.ForeColor = Color.Red
				Me.RichTextBox50.ForeColor = Color.Red
				Me.RichTextBox51.ForeColor = Color.Red
				Me.RichTextBox52.ForeColor = Color.Red
				Me.RichTextBox53.ForeColor = Color.Red
				Me.RichTextBox54.ForeColor = Color.Red
				Me.RichTextBox55.ForeColor = Color.Red
				Me.RichTextBox56.ForeColor = Color.Red
				Me.RichTextBox57.ForeColor = Color.Red
				Me.RichTextBox58.ForeColor = Color.Red
				Me.RichTextBox59.ForeColor = Color.Red
				Me.RichTextBox60.ForeColor = Color.Red
				Me.RichTextBox61.ForeColor = Color.Red
				Me.RichTextBox62.ForeColor = Color.Red
				Me.RichTextBox63.ForeColor = Color.Red
				Me.RichTextBox64.ForeColor = Color.Red
				Me.RichTextBox65.ForeColor = Color.Red
				Me.RichTextBox66.ForeColor = Color.Red
				Me.RichTextBox67.ForeColor = Color.Red
				Me.RichTextBox68.ForeColor = Color.Red
				Me.RichTextBox69.ForeColor = Color.Red
				Me.RichTextBox70.ForeColor = Color.Red
				Me.RichTextBox71.ForeColor = Color.Red
				Me.RichTextBox72.ForeColor = Color.Red
				Me.RichTextBox73.ForeColor = Color.Red
				Me.RichTextBox74.ForeColor = Color.Red
				Me.RichTextBox75.ForeColor = Color.Red
				Me.RichTextBox76.ForeColor = Color.Red
				Me.RichTextBox77.ForeColor = Color.Red
				Me.RichTextBox78.ForeColor = Color.Red
				Me.RichTextBox79.ForeColor = Color.Red
				Me.RichTextBox80.ForeColor = Color.Red
				Me.RichTextBox81.ForeColor = Color.Red
				Me.RichTextBox82.ForeColor = Color.Red
				Me.RichTextBox83.ForeColor = Color.Red
				Me.RichTextBox84.ForeColor = Color.Red
				Me.RichTextBox85.ForeColor = Color.Red
				Me.RichTextBox86.ForeColor = Color.Red
				Me.RichTextBox87.ForeColor = Color.Red
				Me.RichTextBox88.ForeColor = Color.Red
				Me.RichTextBox89.ForeColor = Color.Red
				Me.RichTextBox90.ForeColor = Color.Red
			End If
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.PrintDocument21 = New PrintDocument()
			Me.RichTextBox90 = New System.Windows.Forms.RichTextBox()
			Me.PrintDocument22 = New PrintDocument()
			Me.PrintDocument45 = New PrintDocument()
			Me.PrintDocument38 = New PrintDocument()
			Me.PrintDocument44 = New PrintDocument()
			Me.PrintDocument39 = New PrintDocument()
			Me.PrintDocument6 = New PrintDocument()
			Me.PrintDocument40 = New PrintDocument()
			Me.PrintDocument9 = New PrintDocument()
			Me.PrintDocument33 = New PrintDocument()
			Me.PrintDocument10 = New PrintDocument()
			Me.PrintDocument5 = New PrintDocument()
			Me.PrintDocument11 = New PrintDocument()
			Me.PrintDocument4 = New PrintDocument()
			Me.ListBox1 = New System.Windows.Forms.ListBox()
			Me.PrintDocument3 = New PrintDocument()
			Me.PrintDocument1 = New PrintDocument()
			Me.PrintDocument12 = New PrintDocument()
			Me.PrintDocument2 = New PrintDocument()
			Me.PrintDocument16 = New PrintDocument()
			Me.PrintDocument30 = New PrintDocument()
			Me.PrintDocument17 = New PrintDocument()
			Me.PrintDocument31 = New PrintDocument()
			Me.PrintDocument26 = New PrintDocument()
			Me.PrintDocument32 = New PrintDocument()
			Me.PrintDocument25 = New PrintDocument()
			Me.PrintDocument18 = New PrintDocument()
			Me.PrintDocument24 = New PrintDocument()
			Me.PrintDocument19 = New PrintDocument()
			Me.PrintDocument53 = New PrintDocument()
			Me.PrintDocument23 = New PrintDocument()
			Me.PrintDocument75 = New PrintDocument()
			Me.PrintDocument54 = New PrintDocument()
			Me.PrintDocument79 = New PrintDocument()
			Me.PrintDocument74 = New PrintDocument()
			Me.PrintDocument80 = New PrintDocument()
			Me.PrintDocument73 = New PrintDocument()
			Me.PrintDocument64 = New PrintDocument()
			Me.PrintDocument72 = New PrintDocument()
			Me.PrintDocument70 = New PrintDocument()
			Me.PrintDocument81 = New PrintDocument()
			Me.PrintDocument71 = New PrintDocument()
			Me.PrintDocument82 = New PrintDocument()
			Me.PrintDocument87 = New PrintDocument()
			Me.PrintDocument76 = New PrintDocument()
			Me.PrintDocument88 = New PrintDocument()
			Me.PrintDocument86 = New PrintDocument()
			Me.PrintDocument89 = New PrintDocument()
			Me.PrintDocument85 = New PrintDocument()
			Me.PrintDocument77 = New PrintDocument()
			Me.PrintDocument84 = New PrintDocument()
			Me.PrintDocument78 = New PrintDocument()
			Me.PrintDocument63 = New PrintDocument()
			Me.PrintDocument83 = New PrintDocument()
			Me.PrintDocument48 = New PrintDocument()
			Me.PrintDocument69 = New PrintDocument()
			Me.PrintDocument49 = New PrintDocument()
			Me.PrintDocument43 = New PrintDocument()
			Me.PrintDocument50 = New PrintDocument()
			Me.PrintDocument42 = New PrintDocument()
			Me.PrintDocument34 = New PrintDocument()
			Me.PrintDocument41 = New PrintDocument()
			Me.PrintDocument35 = New PrintDocument()
			Me.PrintDocument55 = New PrintDocument()
			Me.PrintDocument36 = New PrintDocument()
			Me.PrintDocument56 = New PrintDocument()
			Me.PrintDocument66 = New PrintDocument()
			Me.PrintDocument57 = New PrintDocument()
			Me.PrintDocument67 = New PrintDocument()
			Me.PrintDocument65 = New PrintDocument()
			Me.PrintDocument68 = New PrintDocument()
			Me.PrintDocument62 = New PrintDocument()
			Me.PrintDocument58 = New PrintDocument()
			Me.PrintDocument61 = New PrintDocument()
			Me.PrintDocument59 = New PrintDocument()
			Me.ComboBox1 = New System.Windows.Forms.ComboBox()
			Me.PrintDocument60 = New PrintDocument()
			Me.TabControl1 = New System.Windows.Forms.TabControl()
			Me.TabPage1 = New System.Windows.Forms.TabPage()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.GroupBox1 = New System.Windows.Forms.GroupBox()
			Me.PictureBox2 = New System.Windows.Forms.PictureBox()
			Me.ComboBox2 = New System.Windows.Forms.ComboBox()
			Me.PictureBox3 = New System.Windows.Forms.PictureBox()
			Me.ComboBox3 = New System.Windows.Forms.ComboBox()
			Me.RichTextBox89 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox88 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox87 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox86 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox85 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox84 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox83 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox82 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox81 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox80 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox79 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox78 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox77 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox76 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox75 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox74 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox73 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox72 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox71 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox70 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox69 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox68 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox67 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox66 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox65 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox64 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox63 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox62 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox61 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox60 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox59 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox58 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox57 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox56 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox55 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox54 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox53 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox52 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox51 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox50 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox49 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox48 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox47 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox46 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox45 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox44 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox43 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox42 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox41 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox40 = New System.Windows.Forms.RichTextBox()
			Me.PrintDocument90 = New PrintDocument()
			Me.RichTextBox39 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox38 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox37 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox36 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox35 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox34 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox33 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox32 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox31 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox30 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox29 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox28 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox27 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox26 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox25 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox24 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox23 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox22 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox21 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox20 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox19 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox18 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox17 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox16 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox15 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox14 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox13 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox12 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox11 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox10 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox9 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox8 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
			Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.PrintDocument20 = New PrintDocument()
			Me.PrintDocument27 = New PrintDocument()
			Me.PrintDocument15 = New PrintDocument()
			Me.PrintDocument7 = New PrintDocument()
			Me.PrintDocument14 = New PrintDocument()
			Me.PrintDocument8 = New PrintDocument()
			Me.PrintDocument28 = New PrintDocument()
			Me.PrintDocument13 = New PrintDocument()
			Me.PrintDocument29 = New PrintDocument()
			Me.PrintDocument47 = New PrintDocument()
			Me.PrintDocument37 = New PrintDocument()
			Me.PrintDocument51 = New PrintDocument()
			Me.PrintDocument46 = New PrintDocument()
			Me.PrintDocument52 = New PrintDocument()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox3, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PrintDocument21.DocumentName = "MAS Typing Lesson"
			Me.RichTextBox90.AcceptsTab = True
			Me.RichTextBox90.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox90 As System.Windows.Forms.RichTextBox = Me.RichTextBox90
			Dim point As System.Drawing.Point = New System.Drawing.Point(5, 94)
			richTextBox90.Location = point
			Me.RichTextBox90.Name = "RichTextBox90"
			Dim richTextBox As System.Windows.Forms.RichTextBox = Me.RichTextBox90
			Dim size As System.Drawing.Size = New System.Drawing.Size(1224, 630)
			richTextBox.Size = size
			Me.RichTextBox90.TabIndex = 367
			Me.RichTextBox90.Text = ""
			Me.PrintDocument22.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument45.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument38.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument44.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument39.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument6.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument40.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument9.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument33.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument10.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument5.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument11.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument4.DocumentName = "MAS Typing Lesson"
			Me.ListBox1.FormattingEnabled = True
			Dim items As System.Windows.Forms.ListBox.ObjectCollection = Me.ListBox1.Items
			Dim objArray() As Object = { "Lesson 1", "Lesson 2", "Lesson 3", "Lesson 4", "Lesson 5", "Lesson 6", "Lesson 7", "Lesson 8", "Lesson 9", "Lesson 10", "Lesson 11", "Lesson 12", "Lesson 13", "Lesson 14", "Lesson 15", "Lesson 16", "Lesson 17", "Lesson 18", "Lesson 19", "Lesson 20", "Lesson 21", "Lesson 22", "Lesson 23", "Lesson 24", "Lesson 25", "Lesson 26", "Lesson 27", "Lesson 28", "Lesson 29", "Lesson 30", "Lesson 31", "Lesson 32", "Lesson 33", "Lesson 34", "Lesson 35", "Lesson 36", "Lesson 37", "Lesson 38", "Lesson 39", "Lesson 40", "Lesson 41", "Lesson 42", "Lesson 43", "Lesson 44", "Lesson 45", "Lesson 46", "Lesson 47", "Lesson 48", "Lesson 49", "Lesson 50", "Lesson 51", "Lesson 52", "Lesson 53", "Lesson 54", "Lesson 55", "Lesson 56", "Lesson 57", "Lesson 58", "Lesson 59", "Lesson 60", "Lesson 61", "Lesson 62", "Lesson 63", "Lesson 64", "Lesson 65", "Lesson 66", "Lesson 67", "Lesson 68", "Lesson 69", "Lesson 70", "Lesson 71", "Lesson 72", "Lesson 73", "Lesson 74", "Lesson 75", "Lesson 76", "Lesson 77", "Lesson 78", "Lesson 79", "Lesson 80", "Lesson 81", "Lesson 82", "Lesson 83", "Lesson 84", "Lesson 85", "Lesson 86", "Lesson 87", "Lesson 88", "Lesson 89", "Lesson 90", "Run" }
			items.AddRange(objArray)
			Dim listBox1 As System.Windows.Forms.ListBox = Me.ListBox1
			point = New System.Drawing.Point(1235, 5)
			listBox1.Location = point
			Me.ListBox1.Name = "ListBox1"
			Dim listBox As System.Windows.Forms.ListBox = Me.ListBox1
			size = New System.Drawing.Size(120, 719)
			listBox.Size = size
			Me.ListBox1.TabIndex = 368
			Me.PrintDocument3.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument1.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument12.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument2.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument16.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument30.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument17.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument31.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument26.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument32.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument25.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument18.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument24.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument19.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument53.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument23.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument75.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument54.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument79.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument74.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument80.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument73.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument64.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument72.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument70.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument81.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument71.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument82.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument87.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument76.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument88.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument86.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument89.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument85.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument77.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument84.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument78.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument63.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument83.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument48.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument69.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument49.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument43.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument50.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument42.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument34.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument41.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument35.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument55.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument36.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument56.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument66.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument57.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument67.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument65.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument68.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument62.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument58.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument61.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument59.DocumentName = "MAS Typing Lesson"
			Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.ComboBox1.FormattingEnabled = True
			Dim objectCollections As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox1.Items
			objArray = New Object() { "Calibri" }
			objectCollections.AddRange(objArray)
			Dim comboBox1 As System.Windows.Forms.ComboBox = Me.ComboBox1
			point = New System.Drawing.Point(6, 12)
			comboBox1.Location = point
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBox1
			size = New System.Drawing.Size(121, 24)
			comboBox.Size = size
			Me.ComboBox1.TabIndex = 0
			Me.ComboBox1.Text = "Calibri"
			Me.PrintDocument60.DocumentName = "MAS Typing Lesson"
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Dim tabControl1 As System.Windows.Forms.TabControl = Me.TabControl1
			point = New System.Drawing.Point(4, 2)
			tabControl1.Location = point
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Dim tabControl As System.Windows.Forms.TabControl = Me.TabControl1
			size = New System.Drawing.Size(1225, 90)
			tabControl.Size = size
			Me.TabControl1.TabIndex = 369
			Me.TabPage1.Controls.Add(Me.Button1)
			Me.TabPage1.Controls.Add(Me.GroupBox1)
			Dim tabPage1 As System.Windows.Forms.TabPage = Me.TabPage1
			point = New System.Drawing.Point(4, 22)
			tabPage1.Location = point
			Me.TabPage1.Name = "TabPage1"
			Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
			Dim tabPage As System.Windows.Forms.TabPage = Me.TabPage1
			size = New System.Drawing.Size(1217, 64)
			tabPage.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "Home"
			Me.TabPage1.UseVisualStyleBackColor = True
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(219, 6)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(73, 55)
			button.Size = size
			Me.Button1.TabIndex = 278
			Me.Button1.Text = "Print"
			Me.Button1.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.ComboBox1)
			Me.GroupBox1.Controls.Add(Me.PictureBox2)
			Me.GroupBox1.Controls.Add(Me.ComboBox2)
			Me.GroupBox1.Controls.Add(Me.PictureBox3)
			Me.GroupBox1.Controls.Add(Me.ComboBox3)
			Dim groupBox1 As System.Windows.Forms.GroupBox = Me.GroupBox1
			point = New System.Drawing.Point(3, -1)
			groupBox1.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
			size = New System.Drawing.Size(210, 65)
			groupBox.Size = size
			Me.GroupBox1.TabIndex = 11
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Text"
			Me.PictureBox2.Image = DirectCast(componentResourceManager.GetObject("PictureBox2.Image"), Image)
			Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox2
			point = New System.Drawing.Point(66, 41)
			pictureBox2.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox2
			size = New System.Drawing.Size(42, 18)
			pictureBox.Size = size
			Me.PictureBox2.TabIndex = 8
			Me.PictureBox2.TabStop = False
			Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.ComboBox2.FormattingEnabled = True
			Dim items1 As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox2.Items
			objArray = New Object() { "13", "14", "15", "16", "17" }
			items1.AddRange(objArray)
			Dim comboBox2 As System.Windows.Forms.ComboBox = Me.ComboBox2
			point = New System.Drawing.Point(133, 12)
			comboBox2.Location = point
			Me.ComboBox2.Name = "ComboBox2"
			Dim comboBox21 As System.Windows.Forms.ComboBox = Me.ComboBox2
			size = New System.Drawing.Size(66, 24)
			comboBox21.Size = size
			Me.ComboBox2.TabIndex = 1
			Me.ComboBox2.Text = "15"
			Me.PictureBox3.Image = DirectCast(componentResourceManager.GetObject("PictureBox3.Image"), Image)
			Dim pictureBox3 As System.Windows.Forms.PictureBox = Me.PictureBox3
			point = New System.Drawing.Point(66, 42)
			pictureBox3.Location = point
			Me.PictureBox3.Name = "PictureBox3"
			Dim pictureBox31 As System.Windows.Forms.PictureBox = Me.PictureBox3
			size = New System.Drawing.Size(42, 18)
			pictureBox31.Size = size
			Me.PictureBox3.TabIndex = 9
			Me.PictureBox3.TabStop = False
			Me.ComboBox3.FormattingEnabled = True
			Dim objectCollections1 As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox3.Items
			objArray = New Object() { "Black", "Red" }
			objectCollections1.AddRange(objArray)
			Dim comboBox3 As System.Windows.Forms.ComboBox = Me.ComboBox3
			point = New System.Drawing.Point(61, 41)
			comboBox3.Location = point
			Me.ComboBox3.Name = "ComboBox3"
			Dim comboBox31 As System.Windows.Forms.ComboBox = Me.ComboBox3
			size = New System.Drawing.Size(66, 21)
			comboBox31.Size = size
			Me.ComboBox3.TabIndex = 6
			Me.RichTextBox89.AcceptsTab = True
			Me.RichTextBox89.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox89 As System.Windows.Forms.RichTextBox = Me.RichTextBox89
			point = New System.Drawing.Point(5, 95)
			richTextBox89.Location = point
			Me.RichTextBox89.Name = "RichTextBox89"
			Dim richTextBox891 As System.Windows.Forms.RichTextBox = Me.RichTextBox89
			size = New System.Drawing.Size(1224, 630)
			richTextBox891.Size = size
			Me.RichTextBox89.TabIndex = 366
			Me.RichTextBox89.Text = ""
			Me.RichTextBox88.AcceptsTab = True
			Me.RichTextBox88.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox88 As System.Windows.Forms.RichTextBox = Me.RichTextBox88
			point = New System.Drawing.Point(5, 95)
			richTextBox88.Location = point
			Me.RichTextBox88.Name = "RichTextBox88"
			Dim richTextBox881 As System.Windows.Forms.RichTextBox = Me.RichTextBox88
			size = New System.Drawing.Size(1224, 630)
			richTextBox881.Size = size
			Me.RichTextBox88.TabIndex = 365
			Me.RichTextBox88.Text = ""
			Me.RichTextBox87.AcceptsTab = True
			Me.RichTextBox87.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox87 As System.Windows.Forms.RichTextBox = Me.RichTextBox87
			point = New System.Drawing.Point(5, 95)
			richTextBox87.Location = point
			Me.RichTextBox87.Name = "RichTextBox87"
			Dim richTextBox871 As System.Windows.Forms.RichTextBox = Me.RichTextBox87
			size = New System.Drawing.Size(1224, 630)
			richTextBox871.Size = size
			Me.RichTextBox87.TabIndex = 364
			Me.RichTextBox87.Text = ""
			Me.RichTextBox86.AcceptsTab = True
			Me.RichTextBox86.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox86 As System.Windows.Forms.RichTextBox = Me.RichTextBox86
			point = New System.Drawing.Point(5, 95)
			richTextBox86.Location = point
			Me.RichTextBox86.Name = "RichTextBox86"
			Dim richTextBox861 As System.Windows.Forms.RichTextBox = Me.RichTextBox86
			size = New System.Drawing.Size(1224, 630)
			richTextBox861.Size = size
			Me.RichTextBox86.TabIndex = 363
			Me.RichTextBox86.Text = ""
			Me.RichTextBox85.AcceptsTab = True
			Me.RichTextBox85.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox85 As System.Windows.Forms.RichTextBox = Me.RichTextBox85
			point = New System.Drawing.Point(5, 95)
			richTextBox85.Location = point
			Me.RichTextBox85.Name = "RichTextBox85"
			Dim richTextBox851 As System.Windows.Forms.RichTextBox = Me.RichTextBox85
			size = New System.Drawing.Size(1224, 630)
			richTextBox851.Size = size
			Me.RichTextBox85.TabIndex = 362
			Me.RichTextBox85.Text = ""
			Me.RichTextBox84.AcceptsTab = True
			Me.RichTextBox84.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox84 As System.Windows.Forms.RichTextBox = Me.RichTextBox84
			point = New System.Drawing.Point(5, 95)
			richTextBox84.Location = point
			Me.RichTextBox84.Name = "RichTextBox84"
			Dim richTextBox841 As System.Windows.Forms.RichTextBox = Me.RichTextBox84
			size = New System.Drawing.Size(1224, 630)
			richTextBox841.Size = size
			Me.RichTextBox84.TabIndex = 361
			Me.RichTextBox84.Text = ""
			Me.RichTextBox83.AcceptsTab = True
			Me.RichTextBox83.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox83 As System.Windows.Forms.RichTextBox = Me.RichTextBox83
			point = New System.Drawing.Point(5, 95)
			richTextBox83.Location = point
			Me.RichTextBox83.Name = "RichTextBox83"
			Dim richTextBox831 As System.Windows.Forms.RichTextBox = Me.RichTextBox83
			size = New System.Drawing.Size(1224, 630)
			richTextBox831.Size = size
			Me.RichTextBox83.TabIndex = 360
			Me.RichTextBox83.Text = ""
			Me.RichTextBox82.AcceptsTab = True
			Me.RichTextBox82.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox82 As System.Windows.Forms.RichTextBox = Me.RichTextBox82
			point = New System.Drawing.Point(5, 95)
			richTextBox82.Location = point
			Me.RichTextBox82.Name = "RichTextBox82"
			Dim richTextBox821 As System.Windows.Forms.RichTextBox = Me.RichTextBox82
			size = New System.Drawing.Size(1224, 630)
			richTextBox821.Size = size
			Me.RichTextBox82.TabIndex = 359
			Me.RichTextBox82.Text = ""
			Me.RichTextBox81.AcceptsTab = True
			Me.RichTextBox81.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox81 As System.Windows.Forms.RichTextBox = Me.RichTextBox81
			point = New System.Drawing.Point(5, 95)
			richTextBox81.Location = point
			Me.RichTextBox81.Name = "RichTextBox81"
			Dim richTextBox811 As System.Windows.Forms.RichTextBox = Me.RichTextBox81
			size = New System.Drawing.Size(1224, 630)
			richTextBox811.Size = size
			Me.RichTextBox81.TabIndex = 358
			Me.RichTextBox81.Text = ""
			Me.RichTextBox80.AcceptsTab = True
			Me.RichTextBox80.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox80 As System.Windows.Forms.RichTextBox = Me.RichTextBox80
			point = New System.Drawing.Point(5, 95)
			richTextBox80.Location = point
			Me.RichTextBox80.Name = "RichTextBox80"
			Dim richTextBox801 As System.Windows.Forms.RichTextBox = Me.RichTextBox80
			size = New System.Drawing.Size(1224, 630)
			richTextBox801.Size = size
			Me.RichTextBox80.TabIndex = 357
			Me.RichTextBox80.Text = ""
			Me.RichTextBox79.AcceptsTab = True
			Me.RichTextBox79.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox79 As System.Windows.Forms.RichTextBox = Me.RichTextBox79
			point = New System.Drawing.Point(5, 95)
			richTextBox79.Location = point
			Me.RichTextBox79.Name = "RichTextBox79"
			Dim richTextBox791 As System.Windows.Forms.RichTextBox = Me.RichTextBox79
			size = New System.Drawing.Size(1224, 630)
			richTextBox791.Size = size
			Me.RichTextBox79.TabIndex = 356
			Me.RichTextBox79.Text = ""
			Me.RichTextBox78.AcceptsTab = True
			Me.RichTextBox78.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox78 As System.Windows.Forms.RichTextBox = Me.RichTextBox78
			point = New System.Drawing.Point(5, 95)
			richTextBox78.Location = point
			Me.RichTextBox78.Name = "RichTextBox78"
			Dim richTextBox781 As System.Windows.Forms.RichTextBox = Me.RichTextBox78
			size = New System.Drawing.Size(1224, 630)
			richTextBox781.Size = size
			Me.RichTextBox78.TabIndex = 355
			Me.RichTextBox78.Text = ""
			Me.RichTextBox77.AcceptsTab = True
			Me.RichTextBox77.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox77 As System.Windows.Forms.RichTextBox = Me.RichTextBox77
			point = New System.Drawing.Point(5, 95)
			richTextBox77.Location = point
			Me.RichTextBox77.Name = "RichTextBox77"
			Dim richTextBox771 As System.Windows.Forms.RichTextBox = Me.RichTextBox77
			size = New System.Drawing.Size(1224, 630)
			richTextBox771.Size = size
			Me.RichTextBox77.TabIndex = 354
			Me.RichTextBox77.Text = ""
			Me.RichTextBox76.AcceptsTab = True
			Me.RichTextBox76.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox76 As System.Windows.Forms.RichTextBox = Me.RichTextBox76
			point = New System.Drawing.Point(5, 95)
			richTextBox76.Location = point
			Me.RichTextBox76.Name = "RichTextBox76"
			Dim richTextBox761 As System.Windows.Forms.RichTextBox = Me.RichTextBox76
			size = New System.Drawing.Size(1224, 630)
			richTextBox761.Size = size
			Me.RichTextBox76.TabIndex = 353
			Me.RichTextBox76.Text = ""
			Me.RichTextBox75.AcceptsTab = True
			Me.RichTextBox75.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox75 As System.Windows.Forms.RichTextBox = Me.RichTextBox75
			point = New System.Drawing.Point(5, 95)
			richTextBox75.Location = point
			Me.RichTextBox75.Name = "RichTextBox75"
			Dim richTextBox751 As System.Windows.Forms.RichTextBox = Me.RichTextBox75
			size = New System.Drawing.Size(1224, 630)
			richTextBox751.Size = size
			Me.RichTextBox75.TabIndex = 352
			Me.RichTextBox75.Text = ""
			Me.RichTextBox74.AcceptsTab = True
			Me.RichTextBox74.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox74 As System.Windows.Forms.RichTextBox = Me.RichTextBox74
			point = New System.Drawing.Point(5, 95)
			richTextBox74.Location = point
			Me.RichTextBox74.Name = "RichTextBox74"
			Dim richTextBox741 As System.Windows.Forms.RichTextBox = Me.RichTextBox74
			size = New System.Drawing.Size(1224, 630)
			richTextBox741.Size = size
			Me.RichTextBox74.TabIndex = 351
			Me.RichTextBox74.Text = ""
			Me.RichTextBox73.AcceptsTab = True
			Me.RichTextBox73.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox73 As System.Windows.Forms.RichTextBox = Me.RichTextBox73
			point = New System.Drawing.Point(5, 95)
			richTextBox73.Location = point
			Me.RichTextBox73.Name = "RichTextBox73"
			Dim richTextBox731 As System.Windows.Forms.RichTextBox = Me.RichTextBox73
			size = New System.Drawing.Size(1224, 630)
			richTextBox731.Size = size
			Me.RichTextBox73.TabIndex = 350
			Me.RichTextBox73.Text = ""
			Me.RichTextBox72.AcceptsTab = True
			Me.RichTextBox72.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox72 As System.Windows.Forms.RichTextBox = Me.RichTextBox72
			point = New System.Drawing.Point(5, 95)
			richTextBox72.Location = point
			Me.RichTextBox72.Name = "RichTextBox72"
			Dim richTextBox721 As System.Windows.Forms.RichTextBox = Me.RichTextBox72
			size = New System.Drawing.Size(1224, 630)
			richTextBox721.Size = size
			Me.RichTextBox72.TabIndex = 349
			Me.RichTextBox72.Text = ""
			Me.RichTextBox71.AcceptsTab = True
			Me.RichTextBox71.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox71 As System.Windows.Forms.RichTextBox = Me.RichTextBox71
			point = New System.Drawing.Point(5, 95)
			richTextBox71.Location = point
			Me.RichTextBox71.Name = "RichTextBox71"
			Dim richTextBox711 As System.Windows.Forms.RichTextBox = Me.RichTextBox71
			size = New System.Drawing.Size(1224, 630)
			richTextBox711.Size = size
			Me.RichTextBox71.TabIndex = 348
			Me.RichTextBox71.Text = ""
			Me.RichTextBox70.AcceptsTab = True
			Me.RichTextBox70.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox70 As System.Windows.Forms.RichTextBox = Me.RichTextBox70
			point = New System.Drawing.Point(5, 95)
			richTextBox70.Location = point
			Me.RichTextBox70.Name = "RichTextBox70"
			Dim richTextBox701 As System.Windows.Forms.RichTextBox = Me.RichTextBox70
			size = New System.Drawing.Size(1224, 630)
			richTextBox701.Size = size
			Me.RichTextBox70.TabIndex = 347
			Me.RichTextBox70.Text = ""
			Me.RichTextBox69.AcceptsTab = True
			Me.RichTextBox69.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox69 As System.Windows.Forms.RichTextBox = Me.RichTextBox69
			point = New System.Drawing.Point(5, 95)
			richTextBox69.Location = point
			Me.RichTextBox69.Name = "RichTextBox69"
			Dim richTextBox691 As System.Windows.Forms.RichTextBox = Me.RichTextBox69
			size = New System.Drawing.Size(1224, 630)
			richTextBox691.Size = size
			Me.RichTextBox69.TabIndex = 346
			Me.RichTextBox69.Text = ""
			Me.RichTextBox68.AcceptsTab = True
			Me.RichTextBox68.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox68 As System.Windows.Forms.RichTextBox = Me.RichTextBox68
			point = New System.Drawing.Point(5, 95)
			richTextBox68.Location = point
			Me.RichTextBox68.Name = "RichTextBox68"
			Dim richTextBox681 As System.Windows.Forms.RichTextBox = Me.RichTextBox68
			size = New System.Drawing.Size(1224, 630)
			richTextBox681.Size = size
			Me.RichTextBox68.TabIndex = 345
			Me.RichTextBox68.Text = ""
			Me.RichTextBox67.AcceptsTab = True
			Me.RichTextBox67.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox67 As System.Windows.Forms.RichTextBox = Me.RichTextBox67
			point = New System.Drawing.Point(5, 95)
			richTextBox67.Location = point
			Me.RichTextBox67.Name = "RichTextBox67"
			Dim richTextBox671 As System.Windows.Forms.RichTextBox = Me.RichTextBox67
			size = New System.Drawing.Size(1224, 630)
			richTextBox671.Size = size
			Me.RichTextBox67.TabIndex = 344
			Me.RichTextBox67.Text = ""
			Me.RichTextBox66.AcceptsTab = True
			Me.RichTextBox66.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox66 As System.Windows.Forms.RichTextBox = Me.RichTextBox66
			point = New System.Drawing.Point(5, 95)
			richTextBox66.Location = point
			Me.RichTextBox66.Name = "RichTextBox66"
			Dim richTextBox661 As System.Windows.Forms.RichTextBox = Me.RichTextBox66
			size = New System.Drawing.Size(1224, 630)
			richTextBox661.Size = size
			Me.RichTextBox66.TabIndex = 343
			Me.RichTextBox66.Text = ""
			Me.RichTextBox65.AcceptsTab = True
			Me.RichTextBox65.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox65 As System.Windows.Forms.RichTextBox = Me.RichTextBox65
			point = New System.Drawing.Point(5, 95)
			richTextBox65.Location = point
			Me.RichTextBox65.Name = "RichTextBox65"
			Dim richTextBox651 As System.Windows.Forms.RichTextBox = Me.RichTextBox65
			size = New System.Drawing.Size(1224, 630)
			richTextBox651.Size = size
			Me.RichTextBox65.TabIndex = 342
			Me.RichTextBox65.Text = ""
			Me.RichTextBox64.AcceptsTab = True
			Me.RichTextBox64.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox64 As System.Windows.Forms.RichTextBox = Me.RichTextBox64
			point = New System.Drawing.Point(5, 95)
			richTextBox64.Location = point
			Me.RichTextBox64.Name = "RichTextBox64"
			Dim richTextBox641 As System.Windows.Forms.RichTextBox = Me.RichTextBox64
			size = New System.Drawing.Size(1224, 630)
			richTextBox641.Size = size
			Me.RichTextBox64.TabIndex = 341
			Me.RichTextBox64.Text = ""
			Me.RichTextBox63.AcceptsTab = True
			Me.RichTextBox63.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox63 As System.Windows.Forms.RichTextBox = Me.RichTextBox63
			point = New System.Drawing.Point(5, 95)
			richTextBox63.Location = point
			Me.RichTextBox63.Name = "RichTextBox63"
			Dim richTextBox631 As System.Windows.Forms.RichTextBox = Me.RichTextBox63
			size = New System.Drawing.Size(1224, 630)
			richTextBox631.Size = size
			Me.RichTextBox63.TabIndex = 340
			Me.RichTextBox63.Text = ""
			Me.RichTextBox62.AcceptsTab = True
			Me.RichTextBox62.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox62 As System.Windows.Forms.RichTextBox = Me.RichTextBox62
			point = New System.Drawing.Point(5, 95)
			richTextBox62.Location = point
			Me.RichTextBox62.Name = "RichTextBox62"
			Dim richTextBox621 As System.Windows.Forms.RichTextBox = Me.RichTextBox62
			size = New System.Drawing.Size(1224, 630)
			richTextBox621.Size = size
			Me.RichTextBox62.TabIndex = 339
			Me.RichTextBox62.Text = ""
			Me.RichTextBox61.AcceptsTab = True
			Me.RichTextBox61.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox61 As System.Windows.Forms.RichTextBox = Me.RichTextBox61
			point = New System.Drawing.Point(5, 95)
			richTextBox61.Location = point
			Me.RichTextBox61.Name = "RichTextBox61"
			Dim richTextBox611 As System.Windows.Forms.RichTextBox = Me.RichTextBox61
			size = New System.Drawing.Size(1224, 630)
			richTextBox611.Size = size
			Me.RichTextBox61.TabIndex = 338
			Me.RichTextBox61.Text = ""
			Me.RichTextBox60.AcceptsTab = True
			Me.RichTextBox60.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox60 As System.Windows.Forms.RichTextBox = Me.RichTextBox60
			point = New System.Drawing.Point(5, 95)
			richTextBox60.Location = point
			Me.RichTextBox60.Name = "RichTextBox60"
			Dim richTextBox601 As System.Windows.Forms.RichTextBox = Me.RichTextBox60
			size = New System.Drawing.Size(1224, 630)
			richTextBox601.Size = size
			Me.RichTextBox60.TabIndex = 337
			Me.RichTextBox60.Text = ""
			Me.RichTextBox59.AcceptsTab = True
			Me.RichTextBox59.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox59 As System.Windows.Forms.RichTextBox = Me.RichTextBox59
			point = New System.Drawing.Point(5, 95)
			richTextBox59.Location = point
			Me.RichTextBox59.Name = "RichTextBox59"
			Dim richTextBox591 As System.Windows.Forms.RichTextBox = Me.RichTextBox59
			size = New System.Drawing.Size(1224, 630)
			richTextBox591.Size = size
			Me.RichTextBox59.TabIndex = 336
			Me.RichTextBox59.Text = ""
			Me.RichTextBox58.AcceptsTab = True
			Me.RichTextBox58.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox58 As System.Windows.Forms.RichTextBox = Me.RichTextBox58
			point = New System.Drawing.Point(5, 95)
			richTextBox58.Location = point
			Me.RichTextBox58.Name = "RichTextBox58"
			Dim richTextBox581 As System.Windows.Forms.RichTextBox = Me.RichTextBox58
			size = New System.Drawing.Size(1224, 630)
			richTextBox581.Size = size
			Me.RichTextBox58.TabIndex = 335
			Me.RichTextBox58.Text = ""
			Me.RichTextBox57.AcceptsTab = True
			Me.RichTextBox57.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox57 As System.Windows.Forms.RichTextBox = Me.RichTextBox57
			point = New System.Drawing.Point(5, 95)
			richTextBox57.Location = point
			Me.RichTextBox57.Name = "RichTextBox57"
			Dim richTextBox571 As System.Windows.Forms.RichTextBox = Me.RichTextBox57
			size = New System.Drawing.Size(1224, 630)
			richTextBox571.Size = size
			Me.RichTextBox57.TabIndex = 334
			Me.RichTextBox57.Text = ""
			Me.RichTextBox56.AcceptsTab = True
			Me.RichTextBox56.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox56 As System.Windows.Forms.RichTextBox = Me.RichTextBox56
			point = New System.Drawing.Point(5, 95)
			richTextBox56.Location = point
			Me.RichTextBox56.Name = "RichTextBox56"
			Dim richTextBox561 As System.Windows.Forms.RichTextBox = Me.RichTextBox56
			size = New System.Drawing.Size(1224, 630)
			richTextBox561.Size = size
			Me.RichTextBox56.TabIndex = 333
			Me.RichTextBox56.Text = ""
			Me.RichTextBox55.AcceptsTab = True
			Me.RichTextBox55.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox55 As System.Windows.Forms.RichTextBox = Me.RichTextBox55
			point = New System.Drawing.Point(5, 95)
			richTextBox55.Location = point
			Me.RichTextBox55.Name = "RichTextBox55"
			Dim richTextBox551 As System.Windows.Forms.RichTextBox = Me.RichTextBox55
			size = New System.Drawing.Size(1224, 630)
			richTextBox551.Size = size
			Me.RichTextBox55.TabIndex = 332
			Me.RichTextBox55.Text = ""
			Me.RichTextBox54.AcceptsTab = True
			Me.RichTextBox54.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox54 As System.Windows.Forms.RichTextBox = Me.RichTextBox54
			point = New System.Drawing.Point(5, 95)
			richTextBox54.Location = point
			Me.RichTextBox54.Name = "RichTextBox54"
			Dim richTextBox541 As System.Windows.Forms.RichTextBox = Me.RichTextBox54
			size = New System.Drawing.Size(1224, 630)
			richTextBox541.Size = size
			Me.RichTextBox54.TabIndex = 331
			Me.RichTextBox54.Text = ""
			Me.RichTextBox53.AcceptsTab = True
			Me.RichTextBox53.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox53 As System.Windows.Forms.RichTextBox = Me.RichTextBox53
			point = New System.Drawing.Point(5, 95)
			richTextBox53.Location = point
			Me.RichTextBox53.Name = "RichTextBox53"
			Dim richTextBox531 As System.Windows.Forms.RichTextBox = Me.RichTextBox53
			size = New System.Drawing.Size(1224, 630)
			richTextBox531.Size = size
			Me.RichTextBox53.TabIndex = 330
			Me.RichTextBox53.Text = ""
			Me.RichTextBox52.AcceptsTab = True
			Me.RichTextBox52.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox52 As System.Windows.Forms.RichTextBox = Me.RichTextBox52
			point = New System.Drawing.Point(5, 95)
			richTextBox52.Location = point
			Me.RichTextBox52.Name = "RichTextBox52"
			Dim richTextBox521 As System.Windows.Forms.RichTextBox = Me.RichTextBox52
			size = New System.Drawing.Size(1224, 630)
			richTextBox521.Size = size
			Me.RichTextBox52.TabIndex = 329
			Me.RichTextBox52.Text = ""
			Me.RichTextBox51.AcceptsTab = True
			Me.RichTextBox51.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox51 As System.Windows.Forms.RichTextBox = Me.RichTextBox51
			point = New System.Drawing.Point(5, 95)
			richTextBox51.Location = point
			Me.RichTextBox51.Name = "RichTextBox51"
			Dim richTextBox511 As System.Windows.Forms.RichTextBox = Me.RichTextBox51
			size = New System.Drawing.Size(1224, 630)
			richTextBox511.Size = size
			Me.RichTextBox51.TabIndex = 328
			Me.RichTextBox51.Text = ""
			Me.RichTextBox50.AcceptsTab = True
			Me.RichTextBox50.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox50 As System.Windows.Forms.RichTextBox = Me.RichTextBox50
			point = New System.Drawing.Point(5, 95)
			richTextBox50.Location = point
			Me.RichTextBox50.Name = "RichTextBox50"
			Dim richTextBox501 As System.Windows.Forms.RichTextBox = Me.RichTextBox50
			size = New System.Drawing.Size(1224, 630)
			richTextBox501.Size = size
			Me.RichTextBox50.TabIndex = 327
			Me.RichTextBox50.Text = ""
			Me.RichTextBox49.AcceptsTab = True
			Me.RichTextBox49.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox49 As System.Windows.Forms.RichTextBox = Me.RichTextBox49
			point = New System.Drawing.Point(5, 95)
			richTextBox49.Location = point
			Me.RichTextBox49.Name = "RichTextBox49"
			Dim richTextBox491 As System.Windows.Forms.RichTextBox = Me.RichTextBox49
			size = New System.Drawing.Size(1224, 630)
			richTextBox491.Size = size
			Me.RichTextBox49.TabIndex = 326
			Me.RichTextBox49.Text = ""
			Me.RichTextBox48.AcceptsTab = True
			Me.RichTextBox48.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox48 As System.Windows.Forms.RichTextBox = Me.RichTextBox48
			point = New System.Drawing.Point(5, 95)
			richTextBox48.Location = point
			Me.RichTextBox48.Name = "RichTextBox48"
			Dim richTextBox481 As System.Windows.Forms.RichTextBox = Me.RichTextBox48
			size = New System.Drawing.Size(1224, 630)
			richTextBox481.Size = size
			Me.RichTextBox48.TabIndex = 325
			Me.RichTextBox48.Text = ""
			Me.RichTextBox47.AcceptsTab = True
			Me.RichTextBox47.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox47 As System.Windows.Forms.RichTextBox = Me.RichTextBox47
			point = New System.Drawing.Point(5, 95)
			richTextBox47.Location = point
			Me.RichTextBox47.Name = "RichTextBox47"
			Dim richTextBox471 As System.Windows.Forms.RichTextBox = Me.RichTextBox47
			size = New System.Drawing.Size(1224, 630)
			richTextBox471.Size = size
			Me.RichTextBox47.TabIndex = 324
			Me.RichTextBox47.Text = ""
			Me.RichTextBox46.AcceptsTab = True
			Me.RichTextBox46.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox46 As System.Windows.Forms.RichTextBox = Me.RichTextBox46
			point = New System.Drawing.Point(5, 95)
			richTextBox46.Location = point
			Me.RichTextBox46.Name = "RichTextBox46"
			Dim richTextBox461 As System.Windows.Forms.RichTextBox = Me.RichTextBox46
			size = New System.Drawing.Size(1224, 630)
			richTextBox461.Size = size
			Me.RichTextBox46.TabIndex = 323
			Me.RichTextBox46.Text = ""
			Me.RichTextBox45.AcceptsTab = True
			Me.RichTextBox45.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox45 As System.Windows.Forms.RichTextBox = Me.RichTextBox45
			point = New System.Drawing.Point(5, 95)
			richTextBox45.Location = point
			Me.RichTextBox45.Name = "RichTextBox45"
			Dim richTextBox451 As System.Windows.Forms.RichTextBox = Me.RichTextBox45
			size = New System.Drawing.Size(1224, 630)
			richTextBox451.Size = size
			Me.RichTextBox45.TabIndex = 322
			Me.RichTextBox45.Text = ""
			Me.RichTextBox44.AcceptsTab = True
			Me.RichTextBox44.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox44 As System.Windows.Forms.RichTextBox = Me.RichTextBox44
			point = New System.Drawing.Point(5, 95)
			richTextBox44.Location = point
			Me.RichTextBox44.Name = "RichTextBox44"
			Dim richTextBox441 As System.Windows.Forms.RichTextBox = Me.RichTextBox44
			size = New System.Drawing.Size(1224, 630)
			richTextBox441.Size = size
			Me.RichTextBox44.TabIndex = 321
			Me.RichTextBox44.Text = ""
			Me.RichTextBox43.AcceptsTab = True
			Me.RichTextBox43.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox43 As System.Windows.Forms.RichTextBox = Me.RichTextBox43
			point = New System.Drawing.Point(5, 95)
			richTextBox43.Location = point
			Me.RichTextBox43.Name = "RichTextBox43"
			Dim richTextBox431 As System.Windows.Forms.RichTextBox = Me.RichTextBox43
			size = New System.Drawing.Size(1224, 630)
			richTextBox431.Size = size
			Me.RichTextBox43.TabIndex = 320
			Me.RichTextBox43.Text = ""
			Me.RichTextBox42.AcceptsTab = True
			Me.RichTextBox42.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox42 As System.Windows.Forms.RichTextBox = Me.RichTextBox42
			point = New System.Drawing.Point(5, 95)
			richTextBox42.Location = point
			Me.RichTextBox42.Name = "RichTextBox42"
			Dim richTextBox421 As System.Windows.Forms.RichTextBox = Me.RichTextBox42
			size = New System.Drawing.Size(1224, 630)
			richTextBox421.Size = size
			Me.RichTextBox42.TabIndex = 319
			Me.RichTextBox42.Text = ""
			Me.RichTextBox41.AcceptsTab = True
			Me.RichTextBox41.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox41 As System.Windows.Forms.RichTextBox = Me.RichTextBox41
			point = New System.Drawing.Point(5, 95)
			richTextBox41.Location = point
			Me.RichTextBox41.Name = "RichTextBox41"
			Dim richTextBox411 As System.Windows.Forms.RichTextBox = Me.RichTextBox41
			size = New System.Drawing.Size(1224, 630)
			richTextBox411.Size = size
			Me.RichTextBox41.TabIndex = 318
			Me.RichTextBox41.Text = ""
			Me.RichTextBox40.AcceptsTab = True
			Me.RichTextBox40.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox40 As System.Windows.Forms.RichTextBox = Me.RichTextBox40
			point = New System.Drawing.Point(5, 95)
			richTextBox40.Location = point
			Me.RichTextBox40.Name = "RichTextBox40"
			Dim richTextBox401 As System.Windows.Forms.RichTextBox = Me.RichTextBox40
			size = New System.Drawing.Size(1224, 630)
			richTextBox401.Size = size
			Me.RichTextBox40.TabIndex = 317
			Me.RichTextBox40.Text = ""
			Me.PrintDocument90.DocumentName = "MAS Typing Lesson"
			Me.RichTextBox39.AcceptsTab = True
			Me.RichTextBox39.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox39 As System.Windows.Forms.RichTextBox = Me.RichTextBox39
			point = New System.Drawing.Point(5, 95)
			richTextBox39.Location = point
			Me.RichTextBox39.Name = "RichTextBox39"
			Dim richTextBox391 As System.Windows.Forms.RichTextBox = Me.RichTextBox39
			size = New System.Drawing.Size(1224, 630)
			richTextBox391.Size = size
			Me.RichTextBox39.TabIndex = 316
			Me.RichTextBox39.Text = ""
			Me.RichTextBox38.AcceptsTab = True
			Me.RichTextBox38.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox38 As System.Windows.Forms.RichTextBox = Me.RichTextBox38
			point = New System.Drawing.Point(5, 95)
			richTextBox38.Location = point
			Me.RichTextBox38.Name = "RichTextBox38"
			Dim richTextBox381 As System.Windows.Forms.RichTextBox = Me.RichTextBox38
			size = New System.Drawing.Size(1224, 630)
			richTextBox381.Size = size
			Me.RichTextBox38.TabIndex = 315
			Me.RichTextBox38.Text = ""
			Me.RichTextBox37.AcceptsTab = True
			Me.RichTextBox37.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox37 As System.Windows.Forms.RichTextBox = Me.RichTextBox37
			point = New System.Drawing.Point(5, 95)
			richTextBox37.Location = point
			Me.RichTextBox37.Name = "RichTextBox37"
			Dim richTextBox371 As System.Windows.Forms.RichTextBox = Me.RichTextBox37
			size = New System.Drawing.Size(1224, 630)
			richTextBox371.Size = size
			Me.RichTextBox37.TabIndex = 314
			Me.RichTextBox37.Text = ""
			Me.RichTextBox36.AcceptsTab = True
			Me.RichTextBox36.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox36 As System.Windows.Forms.RichTextBox = Me.RichTextBox36
			point = New System.Drawing.Point(5, 95)
			richTextBox36.Location = point
			Me.RichTextBox36.Name = "RichTextBox36"
			Dim richTextBox361 As System.Windows.Forms.RichTextBox = Me.RichTextBox36
			size = New System.Drawing.Size(1224, 630)
			richTextBox361.Size = size
			Me.RichTextBox36.TabIndex = 313
			Me.RichTextBox36.Text = ""
			Me.RichTextBox35.AcceptsTab = True
			Me.RichTextBox35.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox35 As System.Windows.Forms.RichTextBox = Me.RichTextBox35
			point = New System.Drawing.Point(5, 95)
			richTextBox35.Location = point
			Me.RichTextBox35.Name = "RichTextBox35"
			Dim richTextBox351 As System.Windows.Forms.RichTextBox = Me.RichTextBox35
			size = New System.Drawing.Size(1224, 630)
			richTextBox351.Size = size
			Me.RichTextBox35.TabIndex = 312
			Me.RichTextBox35.Text = ""
			Me.RichTextBox34.AcceptsTab = True
			Me.RichTextBox34.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox34 As System.Windows.Forms.RichTextBox = Me.RichTextBox34
			point = New System.Drawing.Point(5, 95)
			richTextBox34.Location = point
			Me.RichTextBox34.Name = "RichTextBox34"
			Dim richTextBox341 As System.Windows.Forms.RichTextBox = Me.RichTextBox34
			size = New System.Drawing.Size(1224, 630)
			richTextBox341.Size = size
			Me.RichTextBox34.TabIndex = 311
			Me.RichTextBox34.Text = ""
			Me.RichTextBox33.AcceptsTab = True
			Me.RichTextBox33.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox33 As System.Windows.Forms.RichTextBox = Me.RichTextBox33
			point = New System.Drawing.Point(5, 95)
			richTextBox33.Location = point
			Me.RichTextBox33.Name = "RichTextBox33"
			Dim richTextBox331 As System.Windows.Forms.RichTextBox = Me.RichTextBox33
			size = New System.Drawing.Size(1224, 630)
			richTextBox331.Size = size
			Me.RichTextBox33.TabIndex = 310
			Me.RichTextBox33.Text = ""
			Me.RichTextBox32.AcceptsTab = True
			Me.RichTextBox32.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox32 As System.Windows.Forms.RichTextBox = Me.RichTextBox32
			point = New System.Drawing.Point(5, 95)
			richTextBox32.Location = point
			Me.RichTextBox32.Name = "RichTextBox32"
			Dim richTextBox321 As System.Windows.Forms.RichTextBox = Me.RichTextBox32
			size = New System.Drawing.Size(1224, 630)
			richTextBox321.Size = size
			Me.RichTextBox32.TabIndex = 309
			Me.RichTextBox32.Text = ""
			Me.RichTextBox31.AcceptsTab = True
			Me.RichTextBox31.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox31 As System.Windows.Forms.RichTextBox = Me.RichTextBox31
			point = New System.Drawing.Point(5, 95)
			richTextBox31.Location = point
			Me.RichTextBox31.Name = "RichTextBox31"
			Dim richTextBox311 As System.Windows.Forms.RichTextBox = Me.RichTextBox31
			size = New System.Drawing.Size(1224, 630)
			richTextBox311.Size = size
			Me.RichTextBox31.TabIndex = 308
			Me.RichTextBox31.Text = ""
			Me.RichTextBox30.AcceptsTab = True
			Me.RichTextBox30.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox30 As System.Windows.Forms.RichTextBox = Me.RichTextBox30
			point = New System.Drawing.Point(5, 95)
			richTextBox30.Location = point
			Me.RichTextBox30.Name = "RichTextBox30"
			Dim richTextBox301 As System.Windows.Forms.RichTextBox = Me.RichTextBox30
			size = New System.Drawing.Size(1224, 630)
			richTextBox301.Size = size
			Me.RichTextBox30.TabIndex = 307
			Me.RichTextBox30.Text = ""
			Me.RichTextBox29.AcceptsTab = True
			Me.RichTextBox29.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox29 As System.Windows.Forms.RichTextBox = Me.RichTextBox29
			point = New System.Drawing.Point(5, 95)
			richTextBox29.Location = point
			Me.RichTextBox29.Name = "RichTextBox29"
			Dim richTextBox291 As System.Windows.Forms.RichTextBox = Me.RichTextBox29
			size = New System.Drawing.Size(1224, 630)
			richTextBox291.Size = size
			Me.RichTextBox29.TabIndex = 306
			Me.RichTextBox29.Text = ""
			Me.RichTextBox28.AcceptsTab = True
			Me.RichTextBox28.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox28 As System.Windows.Forms.RichTextBox = Me.RichTextBox28
			point = New System.Drawing.Point(5, 95)
			richTextBox28.Location = point
			Me.RichTextBox28.Name = "RichTextBox28"
			Dim richTextBox281 As System.Windows.Forms.RichTextBox = Me.RichTextBox28
			size = New System.Drawing.Size(1224, 630)
			richTextBox281.Size = size
			Me.RichTextBox28.TabIndex = 305
			Me.RichTextBox28.Text = ""
			Me.RichTextBox27.AcceptsTab = True
			Me.RichTextBox27.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox27 As System.Windows.Forms.RichTextBox = Me.RichTextBox27
			point = New System.Drawing.Point(5, 95)
			richTextBox27.Location = point
			Me.RichTextBox27.Name = "RichTextBox27"
			Dim richTextBox271 As System.Windows.Forms.RichTextBox = Me.RichTextBox27
			size = New System.Drawing.Size(1224, 630)
			richTextBox271.Size = size
			Me.RichTextBox27.TabIndex = 304
			Me.RichTextBox27.Text = ""
			Me.RichTextBox26.AcceptsTab = True
			Me.RichTextBox26.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox26 As System.Windows.Forms.RichTextBox = Me.RichTextBox26
			point = New System.Drawing.Point(5, 95)
			richTextBox26.Location = point
			Me.RichTextBox26.Name = "RichTextBox26"
			Dim richTextBox261 As System.Windows.Forms.RichTextBox = Me.RichTextBox26
			size = New System.Drawing.Size(1224, 630)
			richTextBox261.Size = size
			Me.RichTextBox26.TabIndex = 303
			Me.RichTextBox26.Text = ""
			Me.RichTextBox25.AcceptsTab = True
			Me.RichTextBox25.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox25 As System.Windows.Forms.RichTextBox = Me.RichTextBox25
			point = New System.Drawing.Point(5, 95)
			richTextBox25.Location = point
			Me.RichTextBox25.Name = "RichTextBox25"
			Dim richTextBox251 As System.Windows.Forms.RichTextBox = Me.RichTextBox25
			size = New System.Drawing.Size(1224, 630)
			richTextBox251.Size = size
			Me.RichTextBox25.TabIndex = 302
			Me.RichTextBox25.Text = ""
			Me.RichTextBox24.AcceptsTab = True
			Me.RichTextBox24.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox24 As System.Windows.Forms.RichTextBox = Me.RichTextBox24
			point = New System.Drawing.Point(5, 95)
			richTextBox24.Location = point
			Me.RichTextBox24.Name = "RichTextBox24"
			Dim richTextBox241 As System.Windows.Forms.RichTextBox = Me.RichTextBox24
			size = New System.Drawing.Size(1224, 630)
			richTextBox241.Size = size
			Me.RichTextBox24.TabIndex = 301
			Me.RichTextBox24.Text = ""
			Me.RichTextBox23.AcceptsTab = True
			Me.RichTextBox23.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox23 As System.Windows.Forms.RichTextBox = Me.RichTextBox23
			point = New System.Drawing.Point(5, 95)
			richTextBox23.Location = point
			Me.RichTextBox23.Name = "RichTextBox23"
			Dim richTextBox231 As System.Windows.Forms.RichTextBox = Me.RichTextBox23
			size = New System.Drawing.Size(1224, 630)
			richTextBox231.Size = size
			Me.RichTextBox23.TabIndex = 300
			Me.RichTextBox23.Text = ""
			Me.RichTextBox22.AcceptsTab = True
			Me.RichTextBox22.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox22 As System.Windows.Forms.RichTextBox = Me.RichTextBox22
			point = New System.Drawing.Point(5, 95)
			richTextBox22.Location = point
			Me.RichTextBox22.Name = "RichTextBox22"
			Dim richTextBox221 As System.Windows.Forms.RichTextBox = Me.RichTextBox22
			size = New System.Drawing.Size(1224, 630)
			richTextBox221.Size = size
			Me.RichTextBox22.TabIndex = 299
			Me.RichTextBox22.Text = ""
			Me.RichTextBox21.AcceptsTab = True
			Me.RichTextBox21.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox21 As System.Windows.Forms.RichTextBox = Me.RichTextBox21
			point = New System.Drawing.Point(5, 95)
			richTextBox21.Location = point
			Me.RichTextBox21.Name = "RichTextBox21"
			Dim richTextBox211 As System.Windows.Forms.RichTextBox = Me.RichTextBox21
			size = New System.Drawing.Size(1224, 630)
			richTextBox211.Size = size
			Me.RichTextBox21.TabIndex = 298
			Me.RichTextBox21.Text = ""
			Me.RichTextBox20.AcceptsTab = True
			Me.RichTextBox20.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox20 As System.Windows.Forms.RichTextBox = Me.RichTextBox20
			point = New System.Drawing.Point(5, 95)
			richTextBox20.Location = point
			Me.RichTextBox20.Name = "RichTextBox20"
			Dim richTextBox201 As System.Windows.Forms.RichTextBox = Me.RichTextBox20
			size = New System.Drawing.Size(1224, 630)
			richTextBox201.Size = size
			Me.RichTextBox20.TabIndex = 297
			Me.RichTextBox20.Text = ""
			Me.RichTextBox19.AcceptsTab = True
			Me.RichTextBox19.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox19 As System.Windows.Forms.RichTextBox = Me.RichTextBox19
			point = New System.Drawing.Point(5, 95)
			richTextBox19.Location = point
			Me.RichTextBox19.Name = "RichTextBox19"
			Dim richTextBox191 As System.Windows.Forms.RichTextBox = Me.RichTextBox19
			size = New System.Drawing.Size(1224, 630)
			richTextBox191.Size = size
			Me.RichTextBox19.TabIndex = 296
			Me.RichTextBox19.Text = ""
			Me.RichTextBox18.AcceptsTab = True
			Me.RichTextBox18.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox18 As System.Windows.Forms.RichTextBox = Me.RichTextBox18
			point = New System.Drawing.Point(5, 95)
			richTextBox18.Location = point
			Me.RichTextBox18.Name = "RichTextBox18"
			Dim richTextBox181 As System.Windows.Forms.RichTextBox = Me.RichTextBox18
			size = New System.Drawing.Size(1224, 630)
			richTextBox181.Size = size
			Me.RichTextBox18.TabIndex = 295
			Me.RichTextBox18.Text = ""
			Me.RichTextBox17.AcceptsTab = True
			Me.RichTextBox17.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox17 As System.Windows.Forms.RichTextBox = Me.RichTextBox17
			point = New System.Drawing.Point(5, 95)
			richTextBox17.Location = point
			Me.RichTextBox17.Name = "RichTextBox17"
			Dim richTextBox171 As System.Windows.Forms.RichTextBox = Me.RichTextBox17
			size = New System.Drawing.Size(1224, 630)
			richTextBox171.Size = size
			Me.RichTextBox17.TabIndex = 294
			Me.RichTextBox17.Text = ""
			Me.RichTextBox16.AcceptsTab = True
			Me.RichTextBox16.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox16 As System.Windows.Forms.RichTextBox = Me.RichTextBox16
			point = New System.Drawing.Point(5, 95)
			richTextBox16.Location = point
			Me.RichTextBox16.Name = "RichTextBox16"
			Dim richTextBox161 As System.Windows.Forms.RichTextBox = Me.RichTextBox16
			size = New System.Drawing.Size(1224, 630)
			richTextBox161.Size = size
			Me.RichTextBox16.TabIndex = 293
			Me.RichTextBox16.Text = ""
			Me.RichTextBox15.AcceptsTab = True
			Me.RichTextBox15.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox15 As System.Windows.Forms.RichTextBox = Me.RichTextBox15
			point = New System.Drawing.Point(5, 95)
			richTextBox15.Location = point
			Me.RichTextBox15.Name = "RichTextBox15"
			Dim richTextBox151 As System.Windows.Forms.RichTextBox = Me.RichTextBox15
			size = New System.Drawing.Size(1224, 630)
			richTextBox151.Size = size
			Me.RichTextBox15.TabIndex = 292
			Me.RichTextBox15.Text = ""
			Me.RichTextBox14.AcceptsTab = True
			Me.RichTextBox14.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox14 As System.Windows.Forms.RichTextBox = Me.RichTextBox14
			point = New System.Drawing.Point(5, 95)
			richTextBox14.Location = point
			Me.RichTextBox14.Name = "RichTextBox14"
			Dim richTextBox141 As System.Windows.Forms.RichTextBox = Me.RichTextBox14
			size = New System.Drawing.Size(1224, 630)
			richTextBox141.Size = size
			Me.RichTextBox14.TabIndex = 291
			Me.RichTextBox14.Text = ""
			Me.RichTextBox13.AcceptsTab = True
			Me.RichTextBox13.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox13 As System.Windows.Forms.RichTextBox = Me.RichTextBox13
			point = New System.Drawing.Point(5, 95)
			richTextBox13.Location = point
			Me.RichTextBox13.Name = "RichTextBox13"
			Dim richTextBox131 As System.Windows.Forms.RichTextBox = Me.RichTextBox13
			size = New System.Drawing.Size(1224, 630)
			richTextBox131.Size = size
			Me.RichTextBox13.TabIndex = 290
			Me.RichTextBox13.Text = ""
			Me.RichTextBox12.AcceptsTab = True
			Me.RichTextBox12.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox12 As System.Windows.Forms.RichTextBox = Me.RichTextBox12
			point = New System.Drawing.Point(5, 95)
			richTextBox12.Location = point
			Me.RichTextBox12.Name = "RichTextBox12"
			Dim richTextBox121 As System.Windows.Forms.RichTextBox = Me.RichTextBox12
			size = New System.Drawing.Size(1224, 630)
			richTextBox121.Size = size
			Me.RichTextBox12.TabIndex = 289
			Me.RichTextBox12.Text = ""
			Me.RichTextBox11.AcceptsTab = True
			Me.RichTextBox11.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox11 As System.Windows.Forms.RichTextBox = Me.RichTextBox11
			point = New System.Drawing.Point(5, 95)
			richTextBox11.Location = point
			Me.RichTextBox11.Name = "RichTextBox11"
			Dim richTextBox111 As System.Windows.Forms.RichTextBox = Me.RichTextBox11
			size = New System.Drawing.Size(1224, 630)
			richTextBox111.Size = size
			Me.RichTextBox11.TabIndex = 288
			Me.RichTextBox11.Text = ""
			Me.RichTextBox10.AcceptsTab = True
			Me.RichTextBox10.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox10 As System.Windows.Forms.RichTextBox = Me.RichTextBox10
			point = New System.Drawing.Point(5, 95)
			richTextBox10.Location = point
			Me.RichTextBox10.Name = "RichTextBox10"
			Dim richTextBox101 As System.Windows.Forms.RichTextBox = Me.RichTextBox10
			size = New System.Drawing.Size(1224, 630)
			richTextBox101.Size = size
			Me.RichTextBox10.TabIndex = 287
			Me.RichTextBox10.Text = ""
			Me.RichTextBox9.AcceptsTab = True
			Me.RichTextBox9.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox9 As System.Windows.Forms.RichTextBox = Me.RichTextBox9
			point = New System.Drawing.Point(5, 95)
			richTextBox9.Location = point
			Me.RichTextBox9.Name = "RichTextBox9"
			Dim richTextBox91 As System.Windows.Forms.RichTextBox = Me.RichTextBox9
			size = New System.Drawing.Size(1224, 630)
			richTextBox91.Size = size
			Me.RichTextBox9.TabIndex = 286
			Me.RichTextBox9.Text = ""
			Me.RichTextBox8.AcceptsTab = True
			Me.RichTextBox8.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox8 As System.Windows.Forms.RichTextBox = Me.RichTextBox8
			point = New System.Drawing.Point(5, 95)
			richTextBox8.Location = point
			Me.RichTextBox8.Name = "RichTextBox8"
			Dim richTextBox1 As System.Windows.Forms.RichTextBox = Me.RichTextBox8
			size = New System.Drawing.Size(1224, 630)
			richTextBox1.Size = size
			Me.RichTextBox8.TabIndex = 285
			Me.RichTextBox8.Text = ""
			Me.RichTextBox7.AcceptsTab = True
			Me.RichTextBox7.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox7 As System.Windows.Forms.RichTextBox = Me.RichTextBox7
			point = New System.Drawing.Point(5, 95)
			richTextBox7.Location = point
			Me.RichTextBox7.Name = "RichTextBox7"
			Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.RichTextBox7
			size = New System.Drawing.Size(1224, 630)
			richTextBox2.Size = size
			Me.RichTextBox7.TabIndex = 284
			Me.RichTextBox7.Text = ""
			Me.RichTextBox6.AcceptsTab = True
			Me.RichTextBox6.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox6 As System.Windows.Forms.RichTextBox = Me.RichTextBox6
			point = New System.Drawing.Point(5, 95)
			richTextBox6.Location = point
			Me.RichTextBox6.Name = "RichTextBox6"
			Dim richTextBox3 As System.Windows.Forms.RichTextBox = Me.RichTextBox6
			size = New System.Drawing.Size(1224, 630)
			richTextBox3.Size = size
			Me.RichTextBox6.TabIndex = 283
			Me.RichTextBox6.Text = ""
			Me.RichTextBox5.AcceptsTab = True
			Me.RichTextBox5.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox5 As System.Windows.Forms.RichTextBox = Me.RichTextBox5
			point = New System.Drawing.Point(5, 95)
			richTextBox5.Location = point
			Me.RichTextBox5.Name = "RichTextBox5"
			Dim richTextBox4 As System.Windows.Forms.RichTextBox = Me.RichTextBox5
			size = New System.Drawing.Size(1224, 630)
			richTextBox4.Size = size
			Me.RichTextBox5.TabIndex = 282
			Me.RichTextBox5.Text = ""
			Me.RichTextBox4.AcceptsTab = True
			Me.RichTextBox4.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox410 As System.Windows.Forms.RichTextBox = Me.RichTextBox4
			point = New System.Drawing.Point(5, 95)
			richTextBox410.Location = point
			Me.RichTextBox4.Name = "RichTextBox4"
			Dim richTextBox412 As System.Windows.Forms.RichTextBox = Me.RichTextBox4
			size = New System.Drawing.Size(1224, 630)
			richTextBox412.Size = size
			Me.RichTextBox4.TabIndex = 281
			Me.RichTextBox4.Text = ""
			Me.RichTextBox3.AcceptsTab = True
			Me.RichTextBox3.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox310 As System.Windows.Forms.RichTextBox = Me.RichTextBox3
			point = New System.Drawing.Point(5, 95)
			richTextBox310.Location = point
			Me.RichTextBox3.Name = "RichTextBox3"
			Dim richTextBox312 As System.Windows.Forms.RichTextBox = Me.RichTextBox3
			size = New System.Drawing.Size(1224, 630)
			richTextBox312.Size = size
			Me.RichTextBox3.TabIndex = 280
			Me.RichTextBox3.Text = ""
			Me.RichTextBox2.AcceptsTab = True
			Me.RichTextBox2.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox210 As System.Windows.Forms.RichTextBox = Me.RichTextBox2
			point = New System.Drawing.Point(5, 95)
			richTextBox210.Location = point
			Me.RichTextBox2.Name = "RichTextBox2"
			Dim richTextBox212 As System.Windows.Forms.RichTextBox = Me.RichTextBox2
			size = New System.Drawing.Size(1224, 630)
			richTextBox212.Size = size
			Me.RichTextBox2.TabIndex = 279
			Me.RichTextBox2.Text = ""
			Me.RichTextBox1.AcceptsTab = True
			Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 15!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim richTextBox110 As System.Windows.Forms.RichTextBox = Me.RichTextBox1
			point = New System.Drawing.Point(5, 95)
			richTextBox110.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox112 As System.Windows.Forms.RichTextBox = Me.RichTextBox1
			size = New System.Drawing.Size(1224, 630)
			richTextBox112.Size = size
			Me.RichTextBox1.TabIndex = 278
			Me.RichTextBox1.Text = ""
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			point = New System.Drawing.Point(4, 95)
			textBox1.Location = point
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			size = New System.Drawing.Size(1225, 629)
			textBox.Size = size
			Me.TextBox1.TabIndex = 370
			Me.PrintDocument20.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument27.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument15.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument7.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument14.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument8.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument28.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument13.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument29.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument47.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument37.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument51.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument46.DocumentName = "MAS Typing Lesson"
			Me.PrintDocument52.DocumentName = "MAS Typing Lesson"
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			size = New System.Drawing.Size(1359, 733)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.RichTextBox90)
			Me.Controls.Add(Me.ListBox1)
			Me.Controls.Add(Me.TabControl1)
			Me.Controls.Add(Me.RichTextBox89)
			Me.Controls.Add(Me.RichTextBox88)
			Me.Controls.Add(Me.RichTextBox87)
			Me.Controls.Add(Me.RichTextBox86)
			Me.Controls.Add(Me.RichTextBox85)
			Me.Controls.Add(Me.RichTextBox84)
			Me.Controls.Add(Me.RichTextBox83)
			Me.Controls.Add(Me.RichTextBox82)
			Me.Controls.Add(Me.RichTextBox81)
			Me.Controls.Add(Me.RichTextBox80)
			Me.Controls.Add(Me.RichTextBox79)
			Me.Controls.Add(Me.RichTextBox78)
			Me.Controls.Add(Me.RichTextBox77)
			Me.Controls.Add(Me.RichTextBox76)
			Me.Controls.Add(Me.RichTextBox75)
			Me.Controls.Add(Me.RichTextBox74)
			Me.Controls.Add(Me.RichTextBox73)
			Me.Controls.Add(Me.RichTextBox72)
			Me.Controls.Add(Me.RichTextBox71)
			Me.Controls.Add(Me.RichTextBox70)
			Me.Controls.Add(Me.RichTextBox69)
			Me.Controls.Add(Me.RichTextBox68)
			Me.Controls.Add(Me.RichTextBox67)
			Me.Controls.Add(Me.RichTextBox66)
			Me.Controls.Add(Me.RichTextBox65)
			Me.Controls.Add(Me.RichTextBox64)
			Me.Controls.Add(Me.RichTextBox63)
			Me.Controls.Add(Me.RichTextBox62)
			Me.Controls.Add(Me.RichTextBox61)
			Me.Controls.Add(Me.RichTextBox60)
			Me.Controls.Add(Me.RichTextBox59)
			Me.Controls.Add(Me.RichTextBox58)
			Me.Controls.Add(Me.RichTextBox57)
			Me.Controls.Add(Me.RichTextBox56)
			Me.Controls.Add(Me.RichTextBox55)
			Me.Controls.Add(Me.RichTextBox54)
			Me.Controls.Add(Me.RichTextBox53)
			Me.Controls.Add(Me.RichTextBox52)
			Me.Controls.Add(Me.RichTextBox51)
			Me.Controls.Add(Me.RichTextBox50)
			Me.Controls.Add(Me.RichTextBox49)
			Me.Controls.Add(Me.RichTextBox48)
			Me.Controls.Add(Me.RichTextBox47)
			Me.Controls.Add(Me.RichTextBox46)
			Me.Controls.Add(Me.RichTextBox45)
			Me.Controls.Add(Me.RichTextBox44)
			Me.Controls.Add(Me.RichTextBox43)
			Me.Controls.Add(Me.RichTextBox42)
			Me.Controls.Add(Me.RichTextBox41)
			Me.Controls.Add(Me.RichTextBox40)
			Me.Controls.Add(Me.RichTextBox39)
			Me.Controls.Add(Me.RichTextBox38)
			Me.Controls.Add(Me.RichTextBox37)
			Me.Controls.Add(Me.RichTextBox36)
			Me.Controls.Add(Me.RichTextBox35)
			Me.Controls.Add(Me.RichTextBox34)
			Me.Controls.Add(Me.RichTextBox33)
			Me.Controls.Add(Me.RichTextBox32)
			Me.Controls.Add(Me.RichTextBox31)
			Me.Controls.Add(Me.RichTextBox30)
			Me.Controls.Add(Me.RichTextBox29)
			Me.Controls.Add(Me.RichTextBox28)
			Me.Controls.Add(Me.RichTextBox27)
			Me.Controls.Add(Me.RichTextBox26)
			Me.Controls.Add(Me.RichTextBox25)
			Me.Controls.Add(Me.RichTextBox24)
			Me.Controls.Add(Me.RichTextBox23)
			Me.Controls.Add(Me.RichTextBox22)
			Me.Controls.Add(Me.RichTextBox21)
			Me.Controls.Add(Me.RichTextBox20)
			Me.Controls.Add(Me.RichTextBox19)
			Me.Controls.Add(Me.RichTextBox18)
			Me.Controls.Add(Me.RichTextBox17)
			Me.Controls.Add(Me.RichTextBox16)
			Me.Controls.Add(Me.RichTextBox15)
			Me.Controls.Add(Me.RichTextBox14)
			Me.Controls.Add(Me.RichTextBox13)
			Me.Controls.Add(Me.RichTextBox12)
			Me.Controls.Add(Me.RichTextBox11)
			Me.Controls.Add(Me.RichTextBox10)
			Me.Controls.Add(Me.RichTextBox9)
			Me.Controls.Add(Me.RichTextBox8)
			Me.Controls.Add(Me.RichTextBox7)
			Me.Controls.Add(Me.RichTextBox6)
			Me.Controls.Add(Me.RichTextBox5)
			Me.Controls.Add(Me.RichTextBox4)
			Me.Controls.Add(Me.RichTextBox3)
			Me.Controls.Add(Me.RichTextBox2)
			Me.Controls.Add(Me.RichTextBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "Form1"
			Me.Text = "MAS Typing"
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			DirectCast(Me.PictureBox2, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox3, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Operators.CompareString(Me.ListBox1.Text, "Lesson 1", False) = 0) Then
				Me.RichTextBox1.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 2", False) = 0) Then
				Me.RichTextBox2.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 3", False) = 0) Then
				Me.RichTextBox3.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 4", False) = 0) Then
				Me.RichTextBox4.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 5", False) = 0) Then
				Me.RichTextBox5.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 6", False) = 0) Then
				Me.RichTextBox6.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 7", False) = 0) Then
				Me.RichTextBox7.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 8", False) = 0) Then
				Me.RichTextBox8.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 9", False) = 0) Then
				Me.RichTextBox9.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 10", False) = 0) Then
				Me.RichTextBox10.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 11", False) = 0) Then
				Me.RichTextBox11.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 12", False) = 0) Then
				Me.RichTextBox12.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 13", False) = 0) Then
				Me.RichTextBox13.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 14", False) = 0) Then
				Me.RichTextBox14.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 15", False) = 0) Then
				Me.RichTextBox15.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 16", False) = 0) Then
				Me.RichTextBox16.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 17", False) = 0) Then
				Me.RichTextBox17.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 18", False) = 0) Then
				Me.RichTextBox18.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 19", False) = 0) Then
				Me.RichTextBox19.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 20", False) = 0) Then
				Me.RichTextBox20.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 21", False) = 0) Then
				Me.RichTextBox21.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 22", False) = 0) Then
				Me.RichTextBox22.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 23", False) = 0) Then
				Me.RichTextBox23.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 24", False) = 0) Then
				Me.RichTextBox24.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 25", False) = 0) Then
				Me.RichTextBox25.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 26", False) = 0) Then
				Me.RichTextBox26.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 27", False) = 0) Then
				Me.RichTextBox27.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 28", False) = 0) Then
				Me.RichTextBox28.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 29", False) = 0) Then
				Me.RichTextBox29.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 30", False) = 0) Then
				Me.RichTextBox30.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 31", False) = 0) Then
				Me.RichTextBox31.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 32", False) = 0) Then
				Me.RichTextBox32.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 33", False) = 0) Then
				Me.RichTextBox33.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 34", False) = 0) Then
				Me.RichTextBox34.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 35", False) = 0) Then
				Me.RichTextBox35.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 36", False) = 0) Then
				Me.RichTextBox36.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 37", False) = 0) Then
				Me.RichTextBox37.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 38", False) = 0) Then
				Me.RichTextBox38.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 39", False) = 0) Then
				Me.RichTextBox39.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 40", False) = 0) Then
				Me.RichTextBox40.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 41", False) = 0) Then
				Me.RichTextBox41.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 42", False) = 0) Then
				Me.RichTextBox42.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 43", False) = 0) Then
				Me.RichTextBox43.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 44", False) = 0) Then
				Me.RichTextBox44.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 45", False) = 0) Then
				Me.RichTextBox45.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 46", False) = 0) Then
				Me.RichTextBox46.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 47", False) = 0) Then
				Me.RichTextBox47.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 48", False) = 0) Then
				Me.RichTextBox48.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 49", False) = 0) Then
				Me.RichTextBox49.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 50", False) = 0) Then
				Me.RichTextBox50.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 51", False) = 0) Then
				Me.RichTextBox51.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 52", False) = 0) Then
				Me.RichTextBox52.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 53", False) = 0) Then
				Me.RichTextBox53.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 54", False) = 0) Then
				Me.RichTextBox54.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 55", False) = 0) Then
				Me.RichTextBox55.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 56", False) = 0) Then
				Me.RichTextBox56.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 57", False) = 0) Then
				Me.RichTextBox57.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 58", False) = 0) Then
				Me.RichTextBox58.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 59", False) = 0) Then
				Me.RichTextBox59.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 60", False) = 0) Then
				Me.RichTextBox60.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 61", False) = 0) Then
				Me.RichTextBox61.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 62", False) = 0) Then
				Me.RichTextBox62.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 63", False) = 0) Then
				Me.RichTextBox63.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 64", False) = 0) Then
				Me.RichTextBox64.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 65", False) = 0) Then
				Me.RichTextBox65.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 66", False) = 0) Then
				Me.RichTextBox66.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 67", False) = 0) Then
				Me.RichTextBox67.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 68", False) = 0) Then
				Me.RichTextBox68.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 69", False) = 0) Then
				Me.RichTextBox69.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 70", False) = 0) Then
				Me.RichTextBox70.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 71", False) = 0) Then
				Me.RichTextBox71.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 72", False) = 0) Then
				Me.RichTextBox72.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 73", False) = 0) Then
				Me.RichTextBox73.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 74", False) = 0) Then
				Me.RichTextBox74.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 75", False) = 0) Then
				Me.RichTextBox75.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 76", False) = 0) Then
				Me.RichTextBox76.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 77", False) = 0) Then
				Me.RichTextBox77.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 78", False) = 0) Then
				Me.RichTextBox78.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 79", False) = 0) Then
				Me.RichTextBox79.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 80", False) = 0) Then
				Me.RichTextBox80.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 81", False) = 0) Then
				Me.RichTextBox81.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 82", False) = 0) Then
				Me.RichTextBox82.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 83", False) = 0) Then
				Me.RichTextBox83.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 84", False) = 0) Then
				Me.RichTextBox84.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 85", False) = 0) Then
				Me.RichTextBox85.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 86", False) = 0) Then
				Me.RichTextBox86.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 87", False) = 0) Then
				Me.RichTextBox87.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 88", False) = 0) Then
				Me.RichTextBox88.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 89", False) = 0) Then
				Me.RichTextBox89.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 90", False) = 0) Then
				Me.RichTextBox90.BringToFront()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Run", False) = 0) Then
				Me.TextBox1.BringToFront()
			End If
		End Sub

		Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Operators.CompareString(Me.ListBox1.Text, "Lesson 1", False) = 0) Then
				Me.PrintDocument1.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 2", False) = 0) Then
				Me.PrintDocument2.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 3", False) = 0) Then
				Me.PrintDocument3.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 4", False) = 0) Then
				Me.PrintDocument4.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 5", False) = 0) Then
				Me.PrintDocument5.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 6", False) = 0) Then
				Me.PrintDocument6.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 7", False) = 0) Then
				Me.PrintDocument7.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 8", False) = 0) Then
				Me.PrintDocument8.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 9", False) = 0) Then
				Me.PrintDocument9.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 10", False) = 0) Then
				Me.PrintDocument10.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 11", False) = 0) Then
				Me.PrintDocument11.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 12", False) = 0) Then
				Me.PrintDocument12.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 13", False) = 0) Then
				Me.PrintDocument13.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 14", False) = 0) Then
				Me.PrintDocument14.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 15", False) = 0) Then
				Me.PrintDocument15.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 16", False) = 0) Then
				Me.PrintDocument16.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 17", False) = 0) Then
				Me.PrintDocument17.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 18", False) = 0) Then
				Me.PrintDocument18.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 19", False) = 0) Then
				Me.PrintDocument19.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 20", False) = 0) Then
				Me.PrintDocument20.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 21", False) = 0) Then
				Me.PrintDocument21.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 22", False) = 0) Then
				Me.PrintDocument22.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 23", False) = 0) Then
				Me.PrintDocument23.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 24", False) = 0) Then
				Me.PrintDocument24.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 25", False) = 0) Then
				Me.PrintDocument25.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 26", False) = 0) Then
				Me.PrintDocument26.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 27", False) = 0) Then
				Me.PrintDocument27.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 28", False) = 0) Then
				Me.PrintDocument28.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 29", False) = 0) Then
				Me.PrintDocument29.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 30", False) = 0) Then
				Me.PrintDocument30.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 31", False) = 0) Then
				Me.PrintDocument31.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 32", False) = 0) Then
				Me.PrintDocument32.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 33", False) = 0) Then
				Me.PrintDocument33.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 34", False) = 0) Then
				Me.PrintDocument34.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 35", False) = 0) Then
				Me.PrintDocument35.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 36", False) = 0) Then
				Me.PrintDocument36.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 37", False) = 0) Then
				Me.PrintDocument37.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 38", False) = 0) Then
				Me.PrintDocument38.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 39", False) = 0) Then
				Me.PrintDocument39.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 40", False) = 0) Then
				Me.PrintDocument40.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 41", False) = 0) Then
				Me.PrintDocument41.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 42", False) = 0) Then
				Me.PrintDocument42.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 43", False) = 0) Then
				Me.PrintDocument43.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 44", False) = 0) Then
				Me.PrintDocument44.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 45", False) = 0) Then
				Me.PrintDocument45.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 46", False) = 0) Then
				Me.PrintDocument46.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 47", False) = 0) Then
				Me.PrintDocument47.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 48", False) = 0) Then
				Me.PrintDocument47.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 49", False) = 0) Then
				Me.PrintDocument48.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 50", False) = 0) Then
				Me.PrintDocument49.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 51", False) = 0) Then
				Me.PrintDocument51.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 52", False) = 0) Then
				Me.PrintDocument52.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 53", False) = 0) Then
				Me.PrintDocument53.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 54", False) = 0) Then
				Me.PrintDocument54.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 55", False) = 0) Then
				Me.PrintDocument55.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 56", False) = 0) Then
				Me.PrintDocument56.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 57", False) = 0) Then
				Me.PrintDocument57.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 58", False) = 0) Then
				Me.PrintDocument58.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 59", False) = 0) Then
				Me.PrintDocument59.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 60", False) = 0) Then
				Me.PrintDocument60.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 61", False) = 0) Then
				Me.PrintDocument61.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 62", False) = 0) Then
				Me.PrintDocument62.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 63", False) = 0) Then
				Me.PrintDocument63.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 64", False) = 0) Then
				Me.PrintDocument64.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 65", False) = 0) Then
				Me.PrintDocument65.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 66", False) = 0) Then
				Me.PrintDocument66.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 67", False) = 0) Then
				Me.PrintDocument67.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 68", False) = 0) Then
				Me.PrintDocument68.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 69", False) = 0) Then
				Me.PrintDocument69.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 70", False) = 0) Then
				Me.PrintDocument70.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 71", False) = 0) Then
				Me.PrintDocument71.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 72", False) = 0) Then
				Me.PrintDocument72.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 73", False) = 0) Then
				Me.PrintDocument73.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 74", False) = 0) Then
				Me.PrintDocument74.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 75", False) = 0) Then
				Me.PrintDocument75.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 76", False) = 0) Then
				Me.PrintDocument76.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 77", False) = 0) Then
				Me.PrintDocument77.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 78", False) = 0) Then
				Me.PrintDocument78.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 79", False) = 0) Then
				Me.PrintDocument79.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 80", False) = 0) Then
				Me.PrintDocument80.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 81", False) = 0) Then
				Me.PrintDocument81.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 82", False) = 0) Then
				Me.PrintDocument82.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 83", False) = 0) Then
				Me.PrintDocument83.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 84", False) = 0) Then
				Me.PrintDocument84.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 85", False) = 0) Then
				Me.PrintDocument85.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 86", False) = 0) Then
				Me.PrintDocument86.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 87", False) = 0) Then
				Me.PrintDocument87.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 88", False) = 0) Then
				Me.PrintDocument88.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 89", False) = 0) Then
				Me.PrintDocument89.Print()
			ElseIf (Operators.CompareString(Me.ListBox1.Text, "Lesson 90", False) = 0) Then
				Me.PrintDocument90.Print()
			End If
		End Sub

		Private Sub PrintDocumen73t_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox73.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox1.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument10_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox10.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument11_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox11.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument12_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox12.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument13_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox13.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument14_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox14.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument15_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox15.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument16_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox16.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument17_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox17.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument18_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox18.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument19_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox19.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument2_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox2.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument20_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox20.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument21_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox21.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument22_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox22.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument23_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox23.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument24_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox24.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument25_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox25.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument26_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox26.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument27_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox27.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument28_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox28.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument29_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox29.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument3_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox3.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument30_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox1.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument31_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox31.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument32_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox32.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument33_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox33.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument34_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox34.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument35_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox35.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument36_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox36.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument37_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox37.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument38_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox38.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument39_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox39.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument4_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox4.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument40_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox40.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument41_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox41.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument42_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox42.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument43_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox43.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument44_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox44.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument45_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox45.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument46_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox46.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument47_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox47.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument48_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox48.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument49_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox49.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument5_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox5.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument50_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox50.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument51_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox51.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument52_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox52.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument53_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox53.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument54_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox54.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument55_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox55.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument56_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox56.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument57_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox57.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument58_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox58.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument59_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox59.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument6_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox6.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument60_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox60.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument61_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox61.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument62_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox62.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument63_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox63.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument64_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox64.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument65_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox65.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument66_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox66.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument67_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox67.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument68_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox68.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument69_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox69.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument7_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox7.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument70_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox70.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument71_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox71.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument72_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox72.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument74_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox74.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument75_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox75.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument76_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox76.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument77_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox77.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument78_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox78.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument79_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox79.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument8_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox8.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument80_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox80.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument81_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox81.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument82_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox82.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument83_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox83.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument84_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox84.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument85_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox85.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument86_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox86.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument87_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox87.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument88_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox88.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument89_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox89.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument9_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox9.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Private Sub PrintDocument90_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawString(Me.RichTextBox90.Text, New System.Drawing.Font("Calibri", Me.RichTextBox1.Font.Size, FontStyle.Regular), Brushes.Black, 25!, 25!)
		End Sub

		Public Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.RichTextBox1.SaveFile(String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\Testdoc.rtf"), RichTextBoxStreamType.RichNoOleObjs)
		End Sub

		Private Sub RichTextBox10_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l10 = Me.RichTextBox10.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox11_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l11 = Me.RichTextBox11.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox12_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l12 = Me.RichTextBox12.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox13_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l13 = Me.RichTextBox13.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox14_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l14 = Me.RichTextBox14.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox15_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l15 = Me.RichTextBox15.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox16_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l16 = Me.RichTextBox17.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox17_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l7 = Me.RichTextBox17.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox18_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l18 = Me.RichTextBox18.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox19_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l19 = Me.RichTextBox19.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l2 = Me.RichTextBox2.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox20_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l20 = Me.RichTextBox20.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox21_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l21 = Me.RichTextBox21.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox22_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l22 = Me.RichTextBox22.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox23_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l23 = Me.RichTextBox23.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox24_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l24 = Me.RichTextBox24.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox25_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l25 = Me.RichTextBox25.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox26_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l26 = Me.RichTextBox26.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox27_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l27 = Me.RichTextBox27.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox28_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l28 = Me.RichTextBox28.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox29_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l29 = Me.RichTextBox29.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l3 = Me.RichTextBox3.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox30_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l30 = Me.RichTextBox30.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox31_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l31 = Me.RichTextBox31.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox32_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l32 = Me.RichTextBox32.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox33_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l33 = Me.RichTextBox33.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox34_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l34 = Me.RichTextBox34.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox35_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l35 = Me.RichTextBox35.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox36_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l36 = Me.RichTextBox36.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox37_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l37 = Me.RichTextBox37.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox38_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l38 = Me.RichTextBox38.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox39_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l39 = Me.RichTextBox39.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l4 = Me.RichTextBox4.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox40_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l40 = Me.RichTextBox40.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox41_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l41 = Me.RichTextBox41.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox42_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l42 = Me.RichTextBox42.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox43_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l43 = Me.RichTextBox43.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox44_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l44 = Me.RichTextBox44.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox45_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l45 = Me.RichTextBox45.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox46_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l46 = Me.RichTextBox46.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox47_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l47 = Me.RichTextBox47.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox48_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l48 = Me.RichTextBox48.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox49_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l49 = Me.RichTextBox49.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox5_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l5 = Me.RichTextBox5.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox50_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l50 = Me.RichTextBox50.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox51_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l51 = Me.RichTextBox51.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox52_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l52 = Me.RichTextBox52.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox53_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l53 = Me.RichTextBox53.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox54_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l54 = Me.RichTextBox54.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox55_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l55 = Me.RichTextBox56.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox56_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l56 = Me.RichTextBox56.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox57_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l57 = Me.RichTextBox57.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox58_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l58 = Me.RichTextBox58.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox59_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l59 = Me.RichTextBox59.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox6_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l6 = Me.RichTextBox6.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox60_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l60 = Me.RichTextBox60.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox61_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l61 = Me.RichTextBox61.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox62_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l62 = Me.RichTextBox62.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox63_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l63 = Me.RichTextBox63.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox64_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l64 = Me.RichTextBox64.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox65_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l65 = Me.RichTextBox65.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox66_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l66 = Me.RichTextBox66.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox67_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l67 = Me.RichTextBox67.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox68_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l68 = Me.RichTextBox68.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox69_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l69 = Me.RichTextBox69.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox7_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l7 = Me.RichTextBox7.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox70_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l70 = Me.RichTextBox70.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox71_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l71 = Me.RichTextBox71.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox72_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l72 = Me.RichTextBox72.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox73_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l73 = Me.RichTextBox73.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox74_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l74 = Me.RichTextBox74.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox75_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l75 = Me.RichTextBox75.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox76_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l76 = Me.RichTextBox76.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox77_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l77 = Me.RichTextBox77.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox78_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l78 = Me.RichTextBox78.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox79_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l79 = Me.RichTextBox79.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox8_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l8 = Me.RichTextBox8.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox80_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l80 = Me.RichTextBox80.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox81_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l81 = Me.RichTextBox81.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox82_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l82 = Me.RichTextBox82.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox83_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l83 = Me.RichTextBox83.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox84_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l84 = Me.RichTextBox84.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox85_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l85 = Me.RichTextBox85.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox86_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l86 = Me.RichTextBox86.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox87_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l87 = Me.RichTextBox87.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox88_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l88 = Me.RichTextBox88.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox89_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l89 = Me.RichTextBox89.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox9_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l9 = Me.RichTextBox9.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub RichTextBox90_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			MySettings.[Default].l90 = Me.RichTextBox90.Text
			MySettings.[Default].Save()
		End Sub

		Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Operators.CompareString(Me.TextBox1.Text, "My.MySettings.Default.ToString = """, False) = 0) Then
				Me.RichTextBox1.Text = ""
				Me.RichTextBox2.Text = ""
				Me.RichTextBox3.Text = ""
				Me.RichTextBox4.Text = ""
				Me.RichTextBox5.Text = ""
				Me.RichTextBox6.Text = ""
				Me.RichTextBox7.Text = ""
				Me.RichTextBox8.Text = ""
				Me.RichTextBox9.Text = ""
				Me.RichTextBox10.Text = ""
				Me.RichTextBox11.Text = ""
				Me.RichTextBox12.Text = ""
				Me.RichTextBox13.Text = ""
				Me.RichTextBox14.Text = ""
				Me.RichTextBox15.Text = ""
				Me.RichTextBox16.Text = ""
				Me.RichTextBox17.Text = ""
				Me.RichTextBox18.Text = ""
				Me.RichTextBox19.Text = ""
				Me.RichTextBox20.Text = ""
				Me.RichTextBox21.Text = ""
				Me.RichTextBox22.Text = ""
				Me.RichTextBox23.Text = ""
				Me.RichTextBox24.Text = ""
				Me.RichTextBox25.Text = ""
				Me.RichTextBox26.Text = ""
				Me.RichTextBox27.Text = ""
				Me.RichTextBox28.Text = ""
				Me.RichTextBox29.Text = ""
				Me.RichTextBox30.Text = ""
				Me.RichTextBox31.Text = ""
				Me.RichTextBox32.Text = ""
				Me.RichTextBox33.Text = ""
				Me.RichTextBox34.Text = ""
				Me.RichTextBox35.Text = ""
				Me.RichTextBox36.Text = ""
				Me.RichTextBox37.Text = ""
				Me.RichTextBox38.Text = ""
				Me.RichTextBox39.Text = ""
				Me.RichTextBox40.Text = ""
				Me.RichTextBox41.Text = ""
				Me.RichTextBox42.Text = ""
				Me.RichTextBox43.Text = ""
				Me.RichTextBox44.Text = ""
				Me.RichTextBox45.Text = ""
				Me.RichTextBox46.Text = ""
				Me.RichTextBox47.Text = ""
				Me.RichTextBox48.Text = ""
				Me.RichTextBox49.Text = ""
				Me.RichTextBox50.Text = ""
				Me.RichTextBox51.Text = ""
				Me.RichTextBox52.Text = ""
				Me.RichTextBox53.Text = ""
				Me.RichTextBox54.Text = ""
				Me.RichTextBox55.Text = ""
				Me.RichTextBox56.Text = ""
				Me.RichTextBox57.Text = ""
				Me.RichTextBox58.Text = ""
				Me.RichTextBox59.Text = ""
				Me.RichTextBox60.Text = ""
				Me.RichTextBox61.Text = ""
				Me.RichTextBox62.Text = ""
				Me.RichTextBox63.Text = ""
				Me.RichTextBox64.Text = ""
				Me.RichTextBox65.Text = ""
				Me.RichTextBox66.Text = ""
				Me.RichTextBox67.Text = ""
				Me.RichTextBox68.Text = ""
				Me.RichTextBox69.Text = ""
				Me.RichTextBox70.Text = ""
				Me.RichTextBox71.Text = ""
				Me.RichTextBox72.Text = ""
				Me.RichTextBox73.Text = ""
				Me.RichTextBox74.Text = ""
				Me.RichTextBox75.Text = ""
				Me.RichTextBox76.Text = ""
				Me.RichTextBox77.Text = ""
				Me.RichTextBox78.Text = ""
				Me.RichTextBox79.Text = ""
				Me.RichTextBox80.Text = ""
				Me.RichTextBox81.Text = ""
				Me.RichTextBox82.Text = ""
				Me.RichTextBox83.Text = ""
				Me.RichTextBox84.Text = ""
				Me.RichTextBox85.Text = ""
				Me.RichTextBox86.Text = ""
				Me.RichTextBox87.Text = ""
				Me.RichTextBox88.Text = ""
				Me.RichTextBox89.Text = ""
				Me.RichTextBox90.Text = ""
			End If
		End Sub
	End Class
End Namespace