@Code
    ViewBag.Title = "How to make PopupControl stay open after submitting a form using Ajax.BeginForm"
End Code


<style>
    .line {
        display: block;
        float: right;
    }

    .button {
        margin: 8px 4px 0px 0px;
    }
</style>
<script type="text/javascript">
    function OnClick(s, e) {
        PopupControl.Show();
    }
</script>
@Html.DevExpress().PopupControl(Sub(settings)
    settings.Name = "PopupControl"
    settings.AllowResize = true
    settings.ShowHeader = true
    settings.HeaderText = "Registration Form"
    settings.ShowOnPageLoad = false
    settings.Width = 400
    settings.AllowDragging = true
    settings.CloseAction = CloseAction.CloseButton
    settings.CloseOnEscape = false
    settings.Modal = false
    settings.SetContent(Sub()
       Using Ajax.BeginForm("PostForm", New AjaxOptions With { .UpdateTargetId = "editorsContainer", .HttpMethod = "POST", .InsertionMode = InsertionMode.Replace})

			ViewContext.Writer.Write("<div id='editorsContainer'>")
			Html.RenderPartial("FormLayoutPartial")
			ViewContext.Writer.Write("</div>")
 End Using
    End Sub)
End Sub).GetHtml()



@Html.DevExpress().Button(Sub(settings)

    settings.Name = "Button"
    settings.Text = "Display Form"
    settings.ClientSideEvents.Click = "OnClick"
End Sub).GetHtml()