Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace T299944.Models
	Public Class SimpleModel
		Private privateName As String
		<Display(Name := "Name:"), Required(ErrorMessage := "Name is required"), RegularExpression("(\S)+", ErrorMessage := "White space is not allowed"), Remote("CheckUserName", "Home", ErrorMessage := "Name cannot be 'admin'")> _
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property

		Private privateEmail As String
		<Display(Name := "Email:"), Required(ErrorMessage := "Email is required"), RegularExpression("\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage := "Email is invalid")> _
		Public Property Email() As String
			Get
				Return privateEmail
			End Get
			Set(ByVal value As String)
				privateEmail = value
			End Set
		End Property

		Private privatePhone As String
		<Display(Name := "Phone:"), Mask("+1 (999) 000-0000", IncludeLiterals := MaskIncludeLiteralsMode.DecimalSymbol, PromptChar := "_"c, ErrorMessage := "Phone number is invalid")> _
		Public Property Phone() As String
			Get
				Return privatePhone
			End Get
			Set(ByVal value As String)
				privatePhone = value
			End Set
		End Property

		Private privateAge? As Integer
		<Display(Name := "Age:"), Required(ErrorMessage := "Age is required"), Range(18, 100, ErrorMessage := "Must be between 18 and 100")> _
		Public Property Age() As Integer?
			Get
				Return privateAge
			End Get
			Set(ByVal value? As Integer)
				privateAge = value
			End Set
		End Property
	End Class

End Namespace