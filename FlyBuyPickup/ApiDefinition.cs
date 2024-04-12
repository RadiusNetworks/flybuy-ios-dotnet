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

	// @interface FlyBuyPickup_Swift_341 (FlyBuyPickupManager) <CLLocationManagerDelegate>
	[BaseType (typeof(FlyBuyPickupManager))]
	interface FlyBuyPickupManager_FlyBuyPickup_Swift_341 : ICLLocationManagerDelegate
	{
		// -(void)locationManager:(CLLocationManager * _Nonnull)manager didChangeAuthorizationStatus:(CLAuthorizationStatus)status;
		[Export ("locationManager:didChangeAuthorizationStatus:")]
		void LocationManager (CLLocationManager manager, CLAuthorizationStatus status);

		// -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
		[Export ("locationManager:didUpdateLocations:")]
		void LocationManager (CLLocationManager manager, CLLocation[] locations);

		// -(void)locationManager:(CLLocationManager * _Nonnull)manager didRangeBeacons:(NSArray<CLBeacon *> * _Nonnull)beacons inRegion:(CLBeaconRegion * _Nonnull)region;
		[Export ("locationManager:didRangeBeacons:inRegion:")]
		void LocationManager (CLLocationManager manager, CLBeacon[] beacons, CLBeaconRegion region);
	}
}
