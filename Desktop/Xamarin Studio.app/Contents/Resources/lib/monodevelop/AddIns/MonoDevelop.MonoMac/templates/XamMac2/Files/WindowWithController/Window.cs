using System;

using Foundation;
using AppKit;

namespace ${Namespace}
{
	public partial class ${Name} : NSWindow
	{
		public ${Name} (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public ${Name} (NSCoder coder) : base (coder)
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
		}
	}
}