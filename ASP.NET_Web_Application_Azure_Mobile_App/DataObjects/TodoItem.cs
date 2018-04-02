using Microsoft.Azure.Mobile.Server;

namespace ASP.NET_Web_Application_Azure_Mobile_App.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}