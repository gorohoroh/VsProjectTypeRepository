@Imports VB_ASP.NET_Web_Application_SPA.Areas.HelpPage.ModelDescriptions
@ModelType KeyValuePairModelDescription
Pair of @Html.DisplayFor(Function(m) Model.KeyModelDescription.ModelType, "ModelDescriptionLink", New With { .modelDescription = Model.KeyModelDescription }) [key]
and @Html.DisplayFor(Function(m) Model.ValueModelDescription.ModelType, "ModelDescriptionLink", New With { .modelDescription = Model.ValueModelDescription }) [value]