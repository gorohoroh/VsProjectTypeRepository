using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Azure_Cloud_Service_ASP.NET_Web_Role.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}