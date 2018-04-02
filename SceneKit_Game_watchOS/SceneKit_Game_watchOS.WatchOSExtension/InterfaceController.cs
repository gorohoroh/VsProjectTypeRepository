using System;

using SceneKit;
using UIKit;
using WatchKit;

namespace SceneKit_Game_watchOS.WatchOSExtension
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

            // create a new scene
            var scene = SCNScene.FromFile("art.scnassets/ship");

            // create and add a camera to the scene
            var cameraNode = SCNNode.Create();
            cameraNode.Camera = SCNCamera.Create();
            scene.RootNode.AddChildNode(cameraNode);

            // place the camera
            cameraNode.Position = new SCNVector3(0, 0, 15);

            // create and add a light to the scene
            var lightNode = SCNNode.Create();
            lightNode.Light = SCNLight.Create();
            lightNode.Light.LightType = SCNLightType.Omni;
            lightNode.Position = new SCNVector3(0, 10, 10);
            scene.RootNode.AddChildNode(lightNode);

            // create and add an ambient light to the scene
            var ambientLightNode = SCNNode.Create();
            ambientLightNode.Light = SCNLight.Create();
            ambientLightNode.Light.LightType = SCNLightType.Ambient;
            ambientLightNode.Light.Color = UIColor.DarkGray;
            scene.RootNode.AddChildNode(ambientLightNode);

            // retrieve the ship node
            var ship = scene.RootNode.FindChildNode("ship", true);

            // animate the 3d object
            ship.RunAction(SCNAction.RepeatActionForever(SCNAction.RotateBy(0, 2, 0, 1)));

            // set the scene to the view
            scnInterface.Scene = scene;

            // show statistics such as fps and timing information
            scnInterface.ShowsStatistics = true;
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
