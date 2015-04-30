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
	[Register ("IntroViewController")]
	partial class IntroViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView introView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton login { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView loginView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIPageControl pageControl { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIScrollView scrollVIew { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton signUp { get; set; }

		[Action ("Login_OnTouchDown:")]
		partial void Login_OnTouchDown (MonoTouch.Foundation.NSObject sender);

		[Action ("SignUp_OnTouchDown:")]
		partial void SignUp_OnTouchDown (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (introView != null) {
				introView.Dispose ();
				introView = null;
			}

			if (loginView != null) {
				loginView.Dispose ();
				loginView = null;
			}

			if (pageControl != null) {
				pageControl.Dispose ();
				pageControl = null;
			}

			if (scrollVIew != null) {
				scrollVIew.Dispose ();
				scrollVIew = null;
			}

			if (signUp != null) {
				signUp.Dispose ();
				signUp = null;
			}

			if (login != null) {
				login.Dispose ();
				login = null;
			}
		}
	}
}
