// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Milestone_iOS
{
	[Register ("SignUpViewController")]
	partial class SignUpViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField emailText { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField passwordText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (emailText != null) {
				emailText.Dispose ();
				emailText = null;
			}

			if (passwordText != null) {
				passwordText.Dispose ();
				passwordText = null;
			}
		}
	}
}
