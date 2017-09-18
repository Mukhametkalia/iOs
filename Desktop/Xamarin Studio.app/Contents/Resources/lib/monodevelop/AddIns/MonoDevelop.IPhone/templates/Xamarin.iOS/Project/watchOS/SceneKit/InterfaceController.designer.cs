using Foundation;
using System.CodeDom.Compiler;

namespace ${Namespace}
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceSCNScene scnInterface { get; set; }

		void ReleaseDesignerOutlets ()
		{
		}
	}
}
