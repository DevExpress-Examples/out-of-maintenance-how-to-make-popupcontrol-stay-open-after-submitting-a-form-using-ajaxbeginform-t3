<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewBag.Title</title>
    <script src="@Url.Content("~/Scripts/jquery-1.10.2.min.js")"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.min.js")"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")"></script>
    <script src="@Url.Content("~/Scripts/jquery.unobtrusive-ajax.min.js")"></script>
    @Html.DevExpress().GetStyleSheets(
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors})
    @Html.DevExpress().GetScripts(
    New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
    New Script With {.ExtensionSuite = ExtensionSuite.Editors})
</head>

<body>
    @RenderBody()
</body>
</html>
