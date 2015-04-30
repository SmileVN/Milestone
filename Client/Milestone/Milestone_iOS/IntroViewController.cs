
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Milestone_iOS
{
	public partial class IntroViewController : UIViewController
	{
		public IntroViewController () : base ("IntroViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			int i;
			for (i = 0; i < 5; i++) 
			{
				UILabel label = new UILabel ();
				RectangleF rec = new RectangleF ();
				rec.X = this.scrollVIew.Frame.Width * i + 50;
				rec.Y = 0;
				rec.Size = this.scrollVIew.Frame.Size;

				label.Frame = rec;
				label.Text = i.ToString ();

				this.scrollVIew.AddSubview (label);
			}

			this.pageControl.Pages = i;
			this.scrollVIew.ContentSize = new SizeF (this.scrollVIew.Frame.Width * i, this.scrollVIew.Frame.Height);
			this.scrollVIew.Scrolled += (object sender, EventArgs e) => this.pageControl.CurrentPage = (int)System.Math.Floor (this.scrollVIew.ContentOffset.X / this.scrollVIew.Frame.Size.Width);
		}

		partial void Login_OnTouchDown (MonoTouch.Foundation.NSObject sender)
		{
			this.NavigationController.PushViewController(new SignUpViewController(), true);
		}
	}
}

