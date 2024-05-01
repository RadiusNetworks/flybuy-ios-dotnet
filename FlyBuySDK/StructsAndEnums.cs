using ObjCRuntime;

namespace FlyBuy
{
	[Native]
	public enum CustomerManagerErrorType : long
	{
		LoadingApiUrl = 0,
		LoadingCustomer = 1,
		MissingCustomerConsent = 2,
		CoreIsNotConfigured = 3
	}

	[Native]
	public enum FlyBuyAPIErrorType : long
	{
		InvalidResponse = 0,
		ResponseError = 1
	}

	[Native]
	public enum FlybuyLinkType : long
	{
		DineIn = 0,
		Redemption = 1,
		Other = 2
	}

	[Native]
	public enum LocationAuthStatus : long
	{
		NotDetermined = 0,
		Restricted = 1,
		Denied = 2,
		AuthorizedAlways = 3,
		AuthorizedWhenInUse = 4
	}

	[Native]
	public enum LogLevel : long
	{
		Verbose = 0,
		Debug = 1,
		Info = 2,
		Warning = 3,
		Error = 4,
		None = 5
	}

	[Native]
	public enum OrdersManagerErrorType : long
	{
		LoadingCustomer = 0,
		LoadingApiUrl = 1,
		AlreadyFetching = 2,
		InvalidCustomerState = 3,
		InvalidOrderState = 4,
		CoreIsNotConfigured = 5
	}

	[Native]
	public enum SitesManagerErrorType : long
	{
		SitesManagerErrorTypeCoreIsNotConfigured = 0
	}

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
