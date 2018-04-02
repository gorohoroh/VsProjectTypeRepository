using System;

using CoreGraphics;
using SpriteKit;
using UIKit;

namespace SpriteKit_Game_watchOS.WatchOSExtension
{
    public class GameScene : SKScene
    {
        SKShapeNode spinnyNode;

        protected GameScene(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void SceneDidLoad()
        {
            // Setup your scene here

            // Get label node from scene and store it for use later
            var label = (SKLabelNode)GetChildNode("//helloLabel");

            label.Alpha = 0.0f;
            label.RunAction(SKAction.FadeInWithDuration(2.0));

            var w = (Size.Width + Size.Height) * 0.3f;

            spinnyNode = SKShapeNode.FromRect(new CGSize(w, w), w * 0.3f);
            spinnyNode.LineWidth = 8.0f;

            var spinnyNodeSequence = SKAction.Sequence(SKAction.WaitForDuration(0.5),
                            SKAction.FadeOutWithDuration(0.5),
                            SKAction.RemoveFromParent());
            spinnyNode.RunAction(spinnyNodeSequence);

            var mainSequence = SKAction.Sequence(SKAction.WaitForDuration(2.0), SKAction.Run(RotateSpinnyNode));
            RunAction(SKAction.RepeatActionForever(mainSequence));
        }

        void RotateSpinnyNode()
        {
            var n = (SKShapeNode)spinnyNode.Copy();
            n.Position = new CGPoint(0.0, 0.0);

            n.StrokeColor = UIColor.Green;
            n.RunAction(SKAction.RepeatActionForever(SKAction.RotateByAngle(NMath.PI / 2, 1)));

            AddChild(n);
        }

        public override void Update(double currentTime)
        {
            // Called before each frame is rendered
        }
    }
}
