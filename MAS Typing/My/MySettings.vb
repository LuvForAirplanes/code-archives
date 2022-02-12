Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace MAS_Typing.My
	<CompilerGenerated>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
	Friend NotInheritable Class MySettings
		Inherits ApplicationSettingsBase
		Private Shared defaultInstance As MySettings

		Private Shared addedHandler As Boolean

		Private Shared addedHandlerLockObject As Object

		Public ReadOnly Shared Property [Default] As MySettings
			Get
				If (Not MySettings.addedHandler) Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					Dim flag As Boolean = False
					Try
						Monitor.Enter(obj, flag)
						If (Not MySettings.addedHandler) Then
							AddHandler MyProject.Application.Shutdown,  New ShutdownEventHandler(AddressOf MySettings.AutoSaveSettings)
							MySettings.addedHandler = True
						End If
					Finally
						If (flag) Then
							Monitor.[Exit](obj)
						End If
					End Try
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property fontc As String
			Get
				Return Conversions.ToString(Me("fontc"))
			End Get
			Set(ByVal value As String)
				Me("fontc") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property fonts As String
			Get
				Return Conversions.ToString(Me("fonts"))
			End Get
			Set(ByVal value As String)
				Me("fonts") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l1 As String
			Get
				Return Conversions.ToString(Me("l1"))
			End Get
			Set(ByVal value As String)
				Me("l1") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l10 As String
			Get
				Return Conversions.ToString(Me("l10"))
			End Get
			Set(ByVal value As String)
				Me("l10") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l11 As String
			Get
				Return Conversions.ToString(Me("l11"))
			End Get
			Set(ByVal value As String)
				Me("l11") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l12 As String
			Get
				Return Conversions.ToString(Me("l12"))
			End Get
			Set(ByVal value As String)
				Me("l12") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l13 As String
			Get
				Return Conversions.ToString(Me("l13"))
			End Get
			Set(ByVal value As String)
				Me("l13") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l14 As String
			Get
				Return Conversions.ToString(Me("l14"))
			End Get
			Set(ByVal value As String)
				Me("l14") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l15 As String
			Get
				Return Conversions.ToString(Me("l15"))
			End Get
			Set(ByVal value As String)
				Me("l15") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l16 As String
			Get
				Return Conversions.ToString(Me("l16"))
			End Get
			Set(ByVal value As String)
				Me("l16") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l17 As String
			Get
				Return Conversions.ToString(Me("l17"))
			End Get
			Set(ByVal value As String)
				Me("l17") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l18 As String
			Get
				Return Conversions.ToString(Me("l18"))
			End Get
			Set(ByVal value As String)
				Me("l18") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l19 As String
			Get
				Return Conversions.ToString(Me("l19"))
			End Get
			Set(ByVal value As String)
				Me("l19") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l2 As String
			Get
				Return Conversions.ToString(Me("l2"))
			End Get
			Set(ByVal value As String)
				Me("l2") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l20 As String
			Get
				Return Conversions.ToString(Me("l20"))
			End Get
			Set(ByVal value As String)
				Me("l20") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l21 As String
			Get
				Return Conversions.ToString(Me("l21"))
			End Get
			Set(ByVal value As String)
				Me("l21") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l22 As String
			Get
				Return Conversions.ToString(Me("l22"))
			End Get
			Set(ByVal value As String)
				Me("l22") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l23 As String
			Get
				Return Conversions.ToString(Me("l23"))
			End Get
			Set(ByVal value As String)
				Me("l23") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l24 As String
			Get
				Return Conversions.ToString(Me("l24"))
			End Get
			Set(ByVal value As String)
				Me("l24") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l25 As String
			Get
				Return Conversions.ToString(Me("l25"))
			End Get
			Set(ByVal value As String)
				Me("l25") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l26 As String
			Get
				Return Conversions.ToString(Me("l26"))
			End Get
			Set(ByVal value As String)
				Me("l26") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l27 As String
			Get
				Return Conversions.ToString(Me("l27"))
			End Get
			Set(ByVal value As String)
				Me("l27") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l28 As String
			Get
				Return Conversions.ToString(Me("l28"))
			End Get
			Set(ByVal value As String)
				Me("l28") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l29 As String
			Get
				Return Conversions.ToString(Me("l29"))
			End Get
			Set(ByVal value As String)
				Me("l29") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l3 As String
			Get
				Return Conversions.ToString(Me("l3"))
			End Get
			Set(ByVal value As String)
				Me("l3") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l30 As String
			Get
				Return Conversions.ToString(Me("l30"))
			End Get
			Set(ByVal value As String)
				Me("l30") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l31 As String
			Get
				Return Conversions.ToString(Me("l31"))
			End Get
			Set(ByVal value As String)
				Me("l31") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l32 As String
			Get
				Return Conversions.ToString(Me("l32"))
			End Get
			Set(ByVal value As String)
				Me("l32") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l33 As String
			Get
				Return Conversions.ToString(Me("l33"))
			End Get
			Set(ByVal value As String)
				Me("l33") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l34 As String
			Get
				Return Conversions.ToString(Me("l34"))
			End Get
			Set(ByVal value As String)
				Me("l34") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l35 As String
			Get
				Return Conversions.ToString(Me("l35"))
			End Get
			Set(ByVal value As String)
				Me("l35") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l36 As String
			Get
				Return Conversions.ToString(Me("l36"))
			End Get
			Set(ByVal value As String)
				Me("l36") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l37 As String
			Get
				Return Conversions.ToString(Me("l37"))
			End Get
			Set(ByVal value As String)
				Me("l37") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l38 As String
			Get
				Return Conversions.ToString(Me("l38"))
			End Get
			Set(ByVal value As String)
				Me("l38") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l39 As String
			Get
				Return Conversions.ToString(Me("l39"))
			End Get
			Set(ByVal value As String)
				Me("l39") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l4 As String
			Get
				Return Conversions.ToString(Me("l4"))
			End Get
			Set(ByVal value As String)
				Me("l4") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l40 As String
			Get
				Return Conversions.ToString(Me("l40"))
			End Get
			Set(ByVal value As String)
				Me("l40") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l41 As String
			Get
				Return Conversions.ToString(Me("l41"))
			End Get
			Set(ByVal value As String)
				Me("l41") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l42 As String
			Get
				Return Conversions.ToString(Me("l42"))
			End Get
			Set(ByVal value As String)
				Me("l42") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l43 As String
			Get
				Return Conversions.ToString(Me("l43"))
			End Get
			Set(ByVal value As String)
				Me("l43") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l44 As String
			Get
				Return Conversions.ToString(Me("l44"))
			End Get
			Set(ByVal value As String)
				Me("l44") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l45 As String
			Get
				Return Conversions.ToString(Me("l45"))
			End Get
			Set(ByVal value As String)
				Me("l45") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l46 As String
			Get
				Return Conversions.ToString(Me("l46"))
			End Get
			Set(ByVal value As String)
				Me("l46") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l47 As String
			Get
				Return Conversions.ToString(Me("l47"))
			End Get
			Set(ByVal value As String)
				Me("l47") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l48 As String
			Get
				Return Conversions.ToString(Me("l48"))
			End Get
			Set(ByVal value As String)
				Me("l48") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l49 As String
			Get
				Return Conversions.ToString(Me("l49"))
			End Get
			Set(ByVal value As String)
				Me("l49") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l5 As String
			Get
				Return Conversions.ToString(Me("l5"))
			End Get
			Set(ByVal value As String)
				Me("l5") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l50 As String
			Get
				Return Conversions.ToString(Me("l50"))
			End Get
			Set(ByVal value As String)
				Me("l50") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l51 As String
			Get
				Return Conversions.ToString(Me("l51"))
			End Get
			Set(ByVal value As String)
				Me("l51") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l52 As String
			Get
				Return Conversions.ToString(Me("l52"))
			End Get
			Set(ByVal value As String)
				Me("l52") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l53 As String
			Get
				Return Conversions.ToString(Me("l53"))
			End Get
			Set(ByVal value As String)
				Me("l53") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l54 As String
			Get
				Return Conversions.ToString(Me("l54"))
			End Get
			Set(ByVal value As String)
				Me("l54") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l55 As String
			Get
				Return Conversions.ToString(Me("l55"))
			End Get
			Set(ByVal value As String)
				Me("l55") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l56 As String
			Get
				Return Conversions.ToString(Me("l56"))
			End Get
			Set(ByVal value As String)
				Me("l56") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l57 As String
			Get
				Return Conversions.ToString(Me("l57"))
			End Get
			Set(ByVal value As String)
				Me("l57") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l58 As String
			Get
				Return Conversions.ToString(Me("l58"))
			End Get
			Set(ByVal value As String)
				Me("l58") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l59 As String
			Get
				Return Conversions.ToString(Me("l59"))
			End Get
			Set(ByVal value As String)
				Me("l59") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l6 As String
			Get
				Return Conversions.ToString(Me("l6"))
			End Get
			Set(ByVal value As String)
				Me("l6") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l60 As String
			Get
				Return Conversions.ToString(Me("l60"))
			End Get
			Set(ByVal value As String)
				Me("l60") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l61 As String
			Get
				Return Conversions.ToString(Me("l61"))
			End Get
			Set(ByVal value As String)
				Me("l61") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l62 As String
			Get
				Return Conversions.ToString(Me("l62"))
			End Get
			Set(ByVal value As String)
				Me("l62") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l63 As String
			Get
				Return Conversions.ToString(Me("l63"))
			End Get
			Set(ByVal value As String)
				Me("l63") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l64 As String
			Get
				Return Conversions.ToString(Me("l64"))
			End Get
			Set(ByVal value As String)
				Me("l64") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l65 As String
			Get
				Return Conversions.ToString(Me("l65"))
			End Get
			Set(ByVal value As String)
				Me("l65") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l66 As String
			Get
				Return Conversions.ToString(Me("l66"))
			End Get
			Set(ByVal value As String)
				Me("l66") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l67 As String
			Get
				Return Conversions.ToString(Me("l67"))
			End Get
			Set(ByVal value As String)
				Me("l67") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l68 As String
			Get
				Return Conversions.ToString(Me("l68"))
			End Get
			Set(ByVal value As String)
				Me("l68") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l69 As String
			Get
				Return Conversions.ToString(Me("l69"))
			End Get
			Set(ByVal value As String)
				Me("l69") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l7 As String
			Get
				Return Conversions.ToString(Me("l7"))
			End Get
			Set(ByVal value As String)
				Me("l7") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l70 As String
			Get
				Return Conversions.ToString(Me("l70"))
			End Get
			Set(ByVal value As String)
				Me("l70") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l71 As String
			Get
				Return Conversions.ToString(Me("l71"))
			End Get
			Set(ByVal value As String)
				Me("l71") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l72 As String
			Get
				Return Conversions.ToString(Me("l72"))
			End Get
			Set(ByVal value As String)
				Me("l72") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l73 As String
			Get
				Return Conversions.ToString(Me("l73"))
			End Get
			Set(ByVal value As String)
				Me("l73") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l74 As String
			Get
				Return Conversions.ToString(Me("l74"))
			End Get
			Set(ByVal value As String)
				Me("l74") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l75 As String
			Get
				Return Conversions.ToString(Me("l75"))
			End Get
			Set(ByVal value As String)
				Me("l75") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l76 As String
			Get
				Return Conversions.ToString(Me("l76"))
			End Get
			Set(ByVal value As String)
				Me("l76") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l77 As String
			Get
				Return Conversions.ToString(Me("l77"))
			End Get
			Set(ByVal value As String)
				Me("l77") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l78 As String
			Get
				Return Conversions.ToString(Me("l78"))
			End Get
			Set(ByVal value As String)
				Me("l78") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l79 As String
			Get
				Return Conversions.ToString(Me("l79"))
			End Get
			Set(ByVal value As String)
				Me("l79") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l8 As String
			Get
				Return Conversions.ToString(Me("l8"))
			End Get
			Set(ByVal value As String)
				Me("l8") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l80 As String
			Get
				Return Conversions.ToString(Me("l80"))
			End Get
			Set(ByVal value As String)
				Me("l80") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l81 As String
			Get
				Return Conversions.ToString(Me("l81"))
			End Get
			Set(ByVal value As String)
				Me("l81") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l82 As String
			Get
				Return Conversions.ToString(Me("l82"))
			End Get
			Set(ByVal value As String)
				Me("l82") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l83 As String
			Get
				Return Conversions.ToString(Me("l83"))
			End Get
			Set(ByVal value As String)
				Me("l83") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l84 As String
			Get
				Return Conversions.ToString(Me("l84"))
			End Get
			Set(ByVal value As String)
				Me("l84") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l85 As String
			Get
				Return Conversions.ToString(Me("l85"))
			End Get
			Set(ByVal value As String)
				Me("l85") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l86 As String
			Get
				Return Conversions.ToString(Me("l86"))
			End Get
			Set(ByVal value As String)
				Me("l86") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l87 As String
			Get
				Return Conversions.ToString(Me("l87"))
			End Get
			Set(ByVal value As String)
				Me("l87") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l88 As String
			Get
				Return Conversions.ToString(Me("l88"))
			End Get
			Set(ByVal value As String)
				Me("l88") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l89 As String
			Get
				Return Conversions.ToString(Me("l89"))
			End Get
			Set(ByVal value As String)
				Me("l89") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l9 As String
			Get
				Return Conversions.ToString(Me("l9"))
			End Get
			Set(ByVal value As String)
				Me("l9") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property l90 As String
			Get
				Return Conversions.ToString(Me("l90"))
			End Get
			Set(ByVal value As String)
				Me("l90") = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DefaultSettingValue("")>
		<UserScopedSetting>
		Public Property name As String
			Get
				Return Conversions.ToString(Me("name"))
			End Get
			Set(ByVal value As String)
				Me("name") = value
			End Set
		End Property

		Shared Sub New()
			MySettings.defaultInstance = DirectCast(SettingsBase.Synchronized(New MySettings()), MySettings)
			MySettings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(New Object())
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		<DebuggerNonUserCode>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
			If (MyProject.Application.SaveMySettingsOnExit) Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub
	End Class
End Namespace