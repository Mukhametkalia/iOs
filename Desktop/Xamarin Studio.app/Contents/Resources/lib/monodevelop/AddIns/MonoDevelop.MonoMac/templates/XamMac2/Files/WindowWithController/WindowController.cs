using System;

using Foundation;
using AppKit;

namespace ${Namespace}
{
	public partial class ${Name}Controller : NSWindowController
	{
		public ${Name}Controller (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public ${Name}Controller (NSCoder coder) : base (coder)
		{
		}

		public ${Name}Controller () : base ("${Name}")
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
		}

		public new ${Name} Window {
			get { return (${Name}) base.Window; }
		}
	}
}