using System;
using UIKit;
using EFCircularSliderBinding;
using Foundation;

namespace EFCircularSliderSample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			EFCircularSlider slider = new EFCircularSlider();
			slider.Frame = new CoreGraphics.CGRect(100, 150, 200, 200);
			slider.HandleColor = UIColor.Red;
			slider.HandleType = EFHandleType.DoubleCircleWithClosedCenter;
			string[]  labels = new string[] { "Jai", "Sri", "Ram" };
			slider.SetInnerMarkingLabels(NSArray.FromObjects(labels));
			slider.UnfilledColor = UIColor.LightGray;
			slider.FilledColor = UIColor.Orange;
			this.View.AddSubview(slider);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
