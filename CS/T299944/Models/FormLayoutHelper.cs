using DevExpress.Web;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace T299944.Models
{
    public class FormLayoutHelper
    {
        static Action<MVCxFormLayoutItem> formLayoutItemSettingsMethod;
        public static Action<MVCxFormLayoutItem> FormLayoutItemSettingsMethod
        {
            get
            {
                if (formLayoutItemSettingsMethod == null)
                    formLayoutItemSettingsMethod = CreateFormLayoutItemSettingsMethod();
                return formLayoutItemSettingsMethod;
            }
        }
        static Action<MVCxFormLayoutItem> CreateFormLayoutItemSettingsMethod()
        {
            return itemSettings =>
            {
                dynamic editorSettings = itemSettings.NestedExtensionSettings;
                editorSettings.Properties.ValidationSettings.Display = Display.Dynamic;
                editorSettings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
                editorSettings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom;
                editorSettings.ShowModelErrors = true;
                editorSettings.Width = Unit.Pixel(200);
            };
        }
    }
}