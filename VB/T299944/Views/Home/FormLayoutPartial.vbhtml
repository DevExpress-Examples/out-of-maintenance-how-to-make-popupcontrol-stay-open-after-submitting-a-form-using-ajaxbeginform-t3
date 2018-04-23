@Imports T299944.Models
@ModelType T299944.Models.SimpleModel
@Html.DevExpress().FormLayout(Sub(settings)
                                  settings.Name = "RegistrationFormLayout"
                                  settings.Width = 400
                                  settings.Items.Add(Function(model) model.Name, FormLayoutHelper.FormLayoutItemSettingsMethod).HelpText = "Cannot be admin, cannot contain spaces"
                                  settings.Items.Add(Function(model) model.Age, FormLayoutHelper.FormLayoutItemSettingsMethod).HelpText = "Must be between 18 and 100"
                                  settings.Items.Add(Function(model) model.Phone, FormLayoutHelper.FormLayoutItemSettingsMethod).HelpText = "E.g. +1 (789) 555-1234"
                                  settings.Items.Add(Function(model) model.Email, FormLayoutHelper.FormLayoutItemSettingsMethod).HelpText = "Must be a valid email"
                                  settings.Items.Add(Sub(itemSettings)
                                                         itemSettings.Caption = String.Empty
                                                         itemSettings.SetNestedContent(Sub()
                                                                                           ViewContext.Writer.Write("<div class='line'>")
                                                                                           Html.DevExpress().Button(Sub(btnSettings)
                                                                                                                        btnSettings.Name = "btnUpdate"
                                                                                                                        btnSettings.Text = "Send"
                                                                                                                        btnSettings.ControlStyle.CssClass = "button"
                                                                                                                        btnSettings.UseSubmitBehavior = True
                                                                                                                    End Sub).Render()
                                                                                           Html.DevExpress().Button(Sub(btnSettings)
                                                                                                                        btnSettings.Name = "btnClear"
                                                                                                                        btnSettings.Text = "Clear"
                                                                                                                        btnSettings.ControlStyle.CssClass = "button"
                                                                                                                        btnSettings.ClientSideEvents.Click = "function(s, e){ ASPxClientEdit.ClearEditorsInContainer(); }"
                                                                                                                    End Sub).Render()
                                                                                           ViewContext.Writer.Write("</div>")
                                                                                       End Sub)
                                                     End Sub)
                              End Sub).GetHtml()