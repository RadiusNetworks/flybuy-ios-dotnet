using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace FlyBuy
{
	[Static]
	partial interface Constants
	{
		// extern double FlyBuyPickupVersionNumber;
		[Field ("FlyBuyPickupVersionNumber", "__Internal")]
		double FlyBuyPickupVersionNumber { get; }

		// extern const unsigned char[] FlyBuyPickupVersionString;
		[Field ("FlyBuyPickupVersionString", "__Internal")]
        NSString FlyBuyPickupVersionString { get; }
	}

	// @interface FlyBuyPickupManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyPickupManager
	{
		// @property (readonly, nonatomic, strong, class) FlyBuyPickupManager * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FlyBuyPickupManager Shared { get; }

		// -(void)configure;
		[Export ("configure")]
		void Configure ();
	}
}
