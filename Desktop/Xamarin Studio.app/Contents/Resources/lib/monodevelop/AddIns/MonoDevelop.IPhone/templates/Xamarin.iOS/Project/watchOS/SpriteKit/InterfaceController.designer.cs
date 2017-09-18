using Foundation;
using System.CodeDom.Compiler;

namespace ${Namespace}
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceSKScene skInterface { get; set; }

		void ReleaseDesignerOutlets ()
		{
		}
	}
}
