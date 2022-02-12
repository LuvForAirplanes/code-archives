Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace MAS_Typing.My.Resources
	<CompilerGenerated>
	<DebuggerNonUserCode>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<HideModuleName>
	Friend Module Resources
		Private resourceMan As System.Resources.ResourceManager

		Private resourceCulture As CultureInfo

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return MAS_Typing.My.Resources.Resources.resourceCulture
			End Get
			Set(ByVal value As CultureInfo)
				MAS_Typing.My.Resources.Resources.resourceCulture = value
			End Set
		End Property

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As System.Resources.ResourceManager
			Get
				If (Object.ReferenceEquals(MAS_Typing.My.Resources.Resources.resourceMan, Nothing)) Then
					MAS_Typing.My.Resources.Resources.resourceMan = New System.Resources.ResourceManager("MAS_Typing.Resources", GetType(MAS_Typing.My.Resources.Resources).Assembly)
				End If
				Return MAS_Typing.My.Resources.Resources.resourceMan
			End Get
		End Property
	End Module
End Namespace