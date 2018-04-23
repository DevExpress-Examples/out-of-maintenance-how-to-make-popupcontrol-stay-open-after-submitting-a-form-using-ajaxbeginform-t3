Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.UI.WebControls
Imports T299944.Models

Namespace T299944.Controllers
	Public Class HomeController
		Inherits Controller
		'
		' GET: /Home/
		Public Function Index() As ActionResult
			Return View(New SimpleModel())
		End Function


		Public Function CheckUserName(ByVal Name As String) As JsonResult
			Dim isValid As Boolean = Not String.Equals(Name, "admin", StringComparison.OrdinalIgnoreCase)
			Return Json(isValid, JsonRequestBehavior.AllowGet)
		End Function
		<HttpPost> _
		Public Function PostForm(ByVal m As SimpleModel) As ActionResult
			'additional server side-validation
			If m.Name.StartsWith("X") Then
				ModelState.AddModelError("Name", "Name cannot start with X")
			End If
			If ModelState.IsValid Then
				Return PartialView("Success")
			Else
				Return PartialView("FormLayoutPartial", m)
			End If
		End Function

	End Class

End Namespace