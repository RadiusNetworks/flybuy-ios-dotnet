using ObjCRuntime;

namespace FlyBuy
{
	[Native]
	public enum NotifyErrorType : long
	{
		NoLocationPermission = 0,
		NotificationPermissionDenied = 1,
		ReachedTheMaxNumberOfSites = 2,
		NotifyModuleNotConfigured = 3,
		CoreIsNotConfigured = 4,
		NotifyModuleNotEnabled = 5,
		BeaconRangingNotAvailable = 6,
		NoBeaconInRange = 7,
		BeaconRangingDisabledInBackground = 8,
		FailedToAddNotificationRequest = 9
	}
}
