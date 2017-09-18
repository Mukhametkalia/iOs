using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace ${Namespace}
{
	public partial class ${Name}Controller : AppKit.NSViewController
	{
		#region Constructors

		// Called when created from unmanaged code
		public ${Name}Controller (IntPtr handle) : base (handle)
		{
			Initialize ();
		}

		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public ${Name}Controller (NSCoder coder) : base (coder)
		{
			Initialize ();
		}

		// Call to load from the XIB/NIB file
		public ${Name}Controller () : base ("${Name}", NSBundle.MainBundle)
		{
			Initialize ();
		}

		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion

		//strongly typed view accessor
		public new ${Name} View {
			get {
				return (${Name}) base.View;
			}
		}
	}
}