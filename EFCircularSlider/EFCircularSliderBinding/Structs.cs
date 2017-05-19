using System;
using ObjCRuntime;

namespace EFCircularSliderBinding
{
	[Native]
	public enum EFHandleType : long
	{
		SemiTransparentWhiteCircle,
		SemiTransparentBlackCircle,
		DoubleCircleWithOpenCenter,
		DoubleCircleWithClosedCenter,
		BigCircle
	}
}
