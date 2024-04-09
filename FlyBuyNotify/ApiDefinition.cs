using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;

namespace FlyBuy
{
	[Static]
	partial interface Constants
	{
		// extern double FlyBuyNotifyVersionNumber;
		[Field ("FlyBuyNotifyVersionNumber", "__Internal")]
		double FlyBuyNotifyVersionNumber { get; }

		// extern const unsigned char[] FlyBuyNotifyVersionString;
		[Field ("FlyBuyNotifyVersionString", "__Internal")]
        NSString FlyBuyNotifyVersionString { get; }
	}

	// @interface FlyBuyNotifyManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyNotifyManager
	{
		// @property (readonly, nonatomic, strong, class) FlyBuyNotifyManager * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		FlyBuyNotifyManager Shared { get; }

		// -(void)configureWithBgTaskIdentifier:(NSString * _Nullable)bgTaskIdentifier bgSyncCallback:(void (^ _Nullable)(NSError * _Nullable))bgSyncCallback;
		[Export ("configureWithBgTaskIdentifier:bgSyncCallback:")]
		void ConfigureWithBgTaskIdentifier ([NullAllowed] string bgTaskIdentifier, [NullAllowed] Action<NSError> bgSyncCallback);

		// -(void)createForSitesInRegion:(CLCircularRegion * _Nonnull)region notification:(NotificationInfo * _Nonnull)notification callback:(void (^ _Nonnull)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for using Notify has been deprecated.")));
		[Export ("createForSitesInRegion:notification:callback:")]
		void CreateForSitesInRegion (CLCircularRegion region, NotificationInfo notification, Action<NSArray<FlyBuySite>, NSError> callback);

		// -(void)createForSites:(NSArray<FlyBuySite *> * _Nonnull)sites notification:(NotificationInfo * _Nonnull)notification callback:(void (^ _Nonnull)(NSError * _Nullable))callback __attribute__((deprecated("This method for using Notify has been deprecated.")));
		[Export ("createForSites:notification:callback:")]
		void CreateForSites (FlyBuySite[] sites, NotificationInfo notification, Action<NSError> callback);

		// -(void)clearWithCallback:(void (^ _Nonnull)(NSError * _Nullable))callback __attribute__((deprecated("This method for using Notify has been deprecated.")));
		[Export ("clearWithCallback:")]
		void ClearWithCallback (Action<NSError> callback);

		// -(BOOL)isFlyBuyNotifyUserInfo:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result(""))) __attribute__((deprecated("This method for using Notify has been deprecated.")));
		[Export ("isFlyBuyNotifyUserInfo:")]
		bool IsFlyBuyNotifyUserInfo (NSDictionary userInfo);
	}

	// @interface NotificationInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC12FlyBuyNotify16NotificationInfo")]
	[DisableDefaultCtor]
	interface NotificationInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull content;
		[Export ("content")]
		string Content { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable data;
		[NullAllowed, Export ("data", ArgumentSemantic.Copy)]
		NSDictionary Data { get; }
	}

	// @interface FlyBuyNotifyError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyNotifyError
	{
		// @property (readonly, nonatomic) enum NotifyErrorType type;
		[Export ("type")]
		NotifyErrorType Type { get; }

		// -(instancetype _Nonnull)init:(enum NotifyErrorType)typeIn __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
        IntPtr Constructor (NotifyErrorType typeIn);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}
}
