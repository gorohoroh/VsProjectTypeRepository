using System;

using SpriteKit;
using WatchKit;

namespace SpriteKit_Game_watchOS.WatchOSExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        protected InterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void Awake(Foundation.NSObject context)
        {
            base.Awake(context);

            // Load the SKScene from 'GameScene.sks'
            var scene = SKNode.FromFile<GameScene>("GameScene");

            // Set the scale mode to scale to fit the window
            scene.ScaleMode = SKSceneScaleMode.AspectFill;

            // Present the scene
            skInterface.PresentScene(scene);

            // Use a value that will maintain consistent frame rate
            skInterface.PreferredFramesPerSecond = 30;
        }

        public override void WillActivate()
        {
            // This method is called when watch view controller is about to be visible to user
            base.WillActivate();
        }

        public override void DidDeactivate()
        {
            // This method is called when watch view controller is no longer visible
            base.DidDeactivate();
        }
    }
}
