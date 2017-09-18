using System;

using Foundation;
using UIKit;

namespace ${Namespace}
{
	public partial class ${Name} : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("${Name}");
		public static readonly UINib Nib;

		static ${Name} ()
		{
			Nib = UINib.FromName ("${Name}", NSBundle.MainBundle);
		}

		protected ${Name} (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
	}
}