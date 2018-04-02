using System;
using System.Reflection;

namespace Azure_Cloud_Service_ASP.NET_Web_Role.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}