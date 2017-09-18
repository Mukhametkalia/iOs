using System;

using CoreGraphics;
using Foundation;
using SpriteKit;
using AppKit;

namespace ${Namespace}
{
	public class GameScene : SKScene
	{
		public GameScene (CGSize size) : base (size)
		{
			/* Setup your scene here */

			BackgroundColor = NSColor.FromRgba (0.15f, 0.15f, 0.3f, 1.0f);

			var myLabel = SKLabelNode.FromFont ("Chalkduster");

			myLabel.Text = "Hello, World!";
			myLabel.FontSize = 65;
			myLabel.Position = new CGPoint (this.Frame.GetMidX (), this.Frame.GetMidY ());

			AddChild (myLabel);
		}

		public override void MouseDown (NSEvent theEvent)
		{
			// Called when a mouse click occurs

			var location = theEvent.LocationInNode (this);

			var sprite = SKSpriteNode.FromImageNamed (NSBundle.MainBundle.PathForResource ("Spaceship", "png"));

			sprite.Position = location;
			sprite.XScale = 0.5f;
			sprite.YScale = 0.5f;

			var action = SKAction.RotateByAngle (NMath.PI, 1.0);

			sprite.RunAction (SKAction.RepeatActionForever (action));

			AddChild (sprite);
		}

		public override void Update (double currentTime)
		{
			// Called before each frame is rendered
		}
	}
}
