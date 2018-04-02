using Foundation;
using System.CodeDom.Compiler;

namespace SceneKit_Game_watchOS.WatchOSExtension
{
    [Register("InterfaceController")]
    partial class InterfaceController
    {
        [Outlet]
        WatchKit.WKInterfaceSCNScene scnInterface { get; set; }

        void ReleaseDesignerOutlets()
        {
        }
    }
}
