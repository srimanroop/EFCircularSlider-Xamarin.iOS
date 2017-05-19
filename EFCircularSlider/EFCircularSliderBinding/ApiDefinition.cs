using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace EFCircularSliderBinding
{
	// @interface EFCircularSlider : UIControl
	[BaseType(typeof(UIControl))]
	interface EFCircularSlider
	{
		// @property (nonatomic) float minimumValue;
		[Export("minimumValue")]
		float MinimumValue { get; set; }

		// @property (nonatomic) float maximumValue;
		[Export("maximumValue")]
		float MaximumValue { get; set; }

		// @property (nonatomic) float currentValue;
		[Export("currentValue")]
		float CurrentValue { get; set; }

		// @property (nonatomic) int lineWidth;
		[Export("lineWidth")]
		int LineWidth { get; set; }

		// @property (nonatomic) int lineRadiusDisplacement;
		[Export("lineRadiusDisplacement")]
		int LineRadiusDisplacement { get; set; }

		// @property (nonatomic, strong) UIColor * filledColor;
		[Export("filledColor", ArgumentSemantic.Strong)]
		UIColor FilledColor { get; set; }

		// @property (nonatomic, strong) UIColor * unfilledColor;
		[Export("unfilledColor", ArgumentSemantic.Strong)]
		UIColor UnfilledColor { get; set; }

		// @property (nonatomic, strong) UIColor * handleColor;
		[Export("handleColor", ArgumentSemantic.Strong)]
		UIColor HandleColor { get; set; }

		// @property (nonatomic) EFHandleType handleType;
		[Export("handleType", ArgumentSemantic.Assign)]
		EFHandleType HandleType { get; set; }

		// @property (nonatomic, strong) UIFont * labelFont;
		[Export("labelFont", ArgumentSemantic.Strong)]
		UIFont LabelFont { get; set; }

		// @property (nonatomic, strong) UIColor * labelColor;
		[Export("labelColor", ArgumentSemantic.Strong)]
		UIColor LabelColor { get; set; }

		// @property (assign, nonatomic) NSInteger labelDisplacement;
		[Export("labelDisplacement")]
		nint LabelDisplacement { get; set; }

		// @property (nonatomic) BOOL snapToLabels;
		[Export("snapToLabels")]
		bool SnapToLabels { get; set; }

		// -(void)setInnerMarkingLabels:(NSArray *)labels;
		[Export("setInnerMarkingLabels:")]
		void SetInnerMarkingLabels(NSArray labels);
	}
}
