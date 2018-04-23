Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI.WebControls

Namespace T299944.Models
	Public Class FormLayoutHelper
		Private Shared formLayoutItemSettingsMethod_Renamed As Action(Of MVCxFormLayoutItem)
		Public Shared ReadOnly Property FormLayoutItemSettingsMethod() As Action(Of MVCxFormLayoutItem)
			Get
				If formLayoutItemSettingsMethod_Renamed Is Nothing Then
					formLayoutItemSettingsMethod_Renamed = CreateFormLayoutItemSettingsMethod()
				End If
				Return formLayoutItemSettingsMethod_Renamed
			End Get
		End Property
		Private Shared Function CreateFormLayoutItemSettingsMethod() As Action(Of MVCxFormLayoutItem)
			Return Function(itemSettings) AnonymousMethod1(itemSettings)
		End Function
		
		Private Shared Function AnonymousMethod1(ByVal itemSettings As Object) As Boolean

            Dim editorSettings As Object = itemSettings.NestedExtensionSettings
			editorSettings.Properties.ValidationSettings.Display = Display.Dynamic
			editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
			editorSettings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom
			editorSettings.ShowModelErrors = True
			editorSettings.Width = Unit.Pixel(200)
			Return True
		End Function
	End Class
End Namespace