using Foundation;
using System.CodeDom.Compiler;

namespace SpriteKit_Game_watchOS.WatchOSExtension
{
    [Register("InterfaceController")]
    partial class InterfaceController
    {
        [Outlet]
        WatchKit.WKInterfaceSKScene skInterface { get; set; }

        void ReleaseDesignerOutlets()
        {
        }
    }
}
