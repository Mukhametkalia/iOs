using System;

using AppKit;
using SpriteKit;
using Foundation;
using CoreGraphics;

namespace ${Namespace}
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		public override void DidFinishLaunching (NSNotification notification)
		{
			var scene = new GameScene (new CGSize (1024, 768));

			// Set the scale mode to scale to fit the window
			scene.ScaleMode = SKSceneScaleMode.AspectFill;

			MyGameView.PresentScene (scene);

			MyGameView.ShowsFPS = true;
			MyGameView.ShowsNodeCount = true;
		}

		public override bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
		{
			return true;
		}
	}
}
