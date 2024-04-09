using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace FlyBuy
{
	[Static]
	partial interface Constants
	{
		// extern double FlyBuyVersionNumber;
		[Field ("FlyBuyVersionNumber", "__Internal")]
		double FlyBuyVersionNumber { get; }

		// extern const unsigned char[] FlyBuyVersionString;
		[Field ("FlyBuyVersionString", "__Internal")]
        NSString FlyBuyVersionString { get; }
	}

	// @interface AppConfig : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy9AppConfig")]
	[DisableDefaultCtor]
	interface AppConfig
	{
	}

	// @interface AppUpgrade : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy10AppUpgrade")]
	interface AppUpgrade
	{
	}

	// @interface FlyBuyBeaconList : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyBeaconList
	{
	}

	// @interface FlyBuyConfigOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyConfigOptions
	{
		// +(FlyBuyConfigOptionsBuilder * _Nonnull)BuilderWithToken:(NSString * _Nonnull)token __attribute__((warn_unused_result("")));
		[Static]
		[Export ("BuilderWithToken:")]
		FlyBuyConfigOptionsBuilder BuilderWithToken (string token);
	}

	// @interface FlyBuyConfigOptionsBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyConfigOptionsBuilder
	{
		// -(instancetype _Nonnull)initWithToken:(NSString * _Nonnull)token __attribute__((objc_designated_initializer));
		[Export ("initWithToken:")]
		[DesignatedInitializer]
		IntPtr Constructor (string token);

		// -(FlyBuyConfigOptions * _Nonnull)build __attribute__((warn_unused_result("")));
		[Export ("build")]
		FlyBuyConfigOptions Build { get; }

		// -(FlyBuyConfigOptionsBuilder * _Nonnull)setLogLevel:(enum LogLevel)logLevel __attribute__((warn_unused_result("")));
		[Export ("setLogLevel:")]
		FlyBuyConfigOptionsBuilder SetLogLevel (LogLevel logLevel);

		// -(FlyBuyConfigOptionsBuilder * _Nonnull)setDeferredLocationTracking:(BOOL)enabled __attribute__((warn_unused_result("")));
		[Export ("setDeferredLocationTracking:")]
		FlyBuyConfigOptionsBuilder SetDeferredLocationTracking (bool enabled);

		// -(FlyBuyConfigOptionsBuilder * _Nonnull)setOptions:(NSDictionary<NSString *,id> * _Nonnull)opts __attribute__((warn_unused_result("")));
		[Export ("setOptions:")]
		FlyBuyConfigOptionsBuilder SetOptions (NSDictionary<NSString, NSObject> opts);
	}

	// @interface FlyBuyCore : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCore
	{
		// @property (readonly, nonatomic, strong, class) FlyBuyOrdersManager * _Nonnull orders;
		[Static]
		[Export ("orders", ArgumentSemantic.Strong)]
		FlyBuyOrdersManager Orders { get; }

		// @property (readonly, nonatomic, strong, class) FlyBuyCustomerManager * _Nonnull customer;
		[Static]
		[Export ("customer", ArgumentSemantic.Strong)]
		FlyBuyCustomerManager Customer { get; }

		// @property (readonly, nonatomic, strong, class) FlyBuySitesManager * _Nonnull sites;
		[Static]
		[Export ("sites", ArgumentSemantic.Strong)]
		FlyBuySitesManager Sites { get; }

		// @property (readonly, nonatomic, strong, class) FlyBuyLogger * _Nonnull logger;
		[Static]
		[Export ("logger", ArgumentSemantic.Strong)]
		FlyBuyLogger Logger { get; }

		// +(void)setAppInstanceIDUpdatedListenerWithCallback:(void (^ _Nullable)(NSUUID * _Nonnull))callback;
		[Static]
		[Export ("setAppInstanceIDUpdatedListenerWithCallback:")]
		void SetAppInstanceIDUpdatedListenerWithCallback ([NullAllowed] Action<NSUuid> callback);

		// +(void)configure:(NSDictionary<NSString *,id> * _Nonnull)opts __attribute__((deprecated("This method for configuring Flybuy Core has been deprecated. Use FlyBuy.Core.configure(withOptions configOptions: ConfigOptions) instead.")));
		[Static]
		[Export ("configure:")]
		void Configure (NSDictionary<NSString, NSObject> opts);

		// +(void)configureWithOptions:(FlyBuyConfigOptions * _Nonnull)configOptions;
		[Static]
		[Export ("configureWithOptions:")]
		void ConfigureWithOptions (FlyBuyConfigOptions configOptions);

		// +(void)handleRemoteNotification:(NSDictionary * _Nonnull)data;
		[Static]
		[Export ("handleRemoteNotification:")]
		void HandleRemoteNotification (NSDictionary data);

		// +(void)updatePushToken:(NSString * _Nonnull)newPushToken;
		[Static]
		[Export ("updatePushToken:")]
		void UpdatePushToken (string newPushToken);

		// +(void)updateAPNPushToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export ("updateAPNPushToken:")]
		void UpdateAPNPushToken (NSData deviceToken);
	}

	// @interface FlyBuyCustomer : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomer
	{
		// @property (readonly, nonatomic) NSInteger id;
		[Export ("id")]
		nint Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull token;
		[Export ("token")]
		string Token { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable emailAddress;
		[NullAllowed, Export ("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, nonatomic, strong) FlyBuyCustomerInfo * _Nonnull info;
		[Export ("info", ArgumentSemantic.Strong)]
		FlyBuyCustomerInfo Info { get; }

		// @property (readonly, nonatomic) BOOL registered;
		[Export ("registered")]
		bool Registered { get; }
	}

	// @interface FlyBuyCustomerConsent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomerConsent
	{
		// @property (readonly, nonatomic) BOOL termsOfService;
		[Export ("termsOfService")]
		bool TermsOfService { get; }

		// @property (readonly, nonatomic) BOOL ageVerification;
		[Export ("ageVerification")]
		bool AgeVerification { get; }

		// -(instancetype _Nonnull)initWithTermsOfService:(BOOL)termsOfService ageVerification:(BOOL)ageVerification __attribute__((objc_designated_initializer));
		[Export ("initWithTermsOfService:ageVerification:")]
		[DesignatedInitializer]
		IntPtr Constructor (bool termsOfService, bool ageVerification);
	}

	// @interface FlyBuyCustomerInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomerInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable carType;
		[NullAllowed, Export ("carType")]
		string CarType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable carColor;
		[NullAllowed, Export ("carColor")]
		string CarColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable licensePlate;
		[NullAllowed, Export ("licensePlate")]
		string LicensePlate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name carType:(NSString * _Nullable)carType carColor:(NSString * _Nullable)carColor licensePlate:(NSString * _Nullable)licensePlate phone:(NSString * _Nullable)phone __attribute__((objc_designated_initializer));
		[Export ("initWithName:carType:carColor:licensePlate:phone:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name, [NullAllowed] string carType, [NullAllowed] string carColor, [NullAllowed] string licensePlate, [NullAllowed] string phone);
	}

	// @interface FlyBuyCustomerManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyCustomerManager
	{
		// @property (readonly, nonatomic, strong) FlyBuyCustomer * _Nullable current;
		[NullAllowed, Export ("current", ArgumentSemantic.Strong)]
		FlyBuyCustomer Current { get; }

		// -(void)create:(FlyBuyCustomerInfo * _Nonnull)customerInfo termsOfService:(BOOL)termsOfService ageVerification:(BOOL)ageVerification callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("create:termsOfService:ageVerification:callback:")]
		void Create (FlyBuyCustomerInfo customerInfo, bool termsOfService, bool ageVerification, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)create:(FlyBuyCustomerInfo * _Nonnull)customerInfo email:(NSString * _Nonnull)email password:(NSString * _Nonnull)password customerConsent:(FlyBuyCustomerConsent * _Nonnull)customerConsent callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("create:email:password:customerConsent:callback:")]
		void Create (FlyBuyCustomerInfo customerInfo, string email, string password, FlyBuyCustomerConsent customerConsent, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)update:(FlyBuyCustomerInfo * _Nonnull)customerInfo callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("update:callback:")]
		void Update (FlyBuyCustomerInfo customerInfo, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)loginWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("loginWithEmailAddress:password:callback:")]
		void LoginWithEmailAddress (string emailAddress, string password, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)loginWithTokenWithToken:(NSString * _Nonnull)token callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("loginWithTokenWithToken:callback:")]
		void LoginWithTokenWithToken (string token, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)signUpWithEmailAddress:(NSString * _Nonnull)emailAddress password:(NSString * _Nonnull)password callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("signUpWithEmailAddress:password:callback:")]
		void SignUpWithEmailAddress (string emailAddress, string password, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)requestNewPasswordWithEmailAddress:(NSString * _Nonnull)emailAddress callback:(void (^ _Nullable)(NSError * _Nullable))callback;
		[Export ("requestNewPasswordWithEmailAddress:callback:")]
		void RequestNewPasswordWithEmailAddress (string emailAddress, [NullAllowed] Action<NSError> callback);

		// -(void)setNewPasswordWithResetPasswordToken:(NSString * _Nonnull)resetPasswordToken password:(NSString * _Nonnull)password confirmation:(NSString * _Nonnull)confirmation callback:(void (^ _Nullable)(FlyBuyCustomer * _Nullable, NSError * _Nullable))callback;
		[Export ("setNewPasswordWithResetPasswordToken:password:confirmation:callback:")]
		void SetNewPasswordWithResetPasswordToken (string resetPasswordToken, string password, string confirmation, [NullAllowed] Action<FlyBuyCustomer, NSError> callback);

		// -(void)logout;
		[Export ("logout")]
		void Logout ();
	}

	// @interface FlyBuyCustomerManagerError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyCustomerManagerError
	{
		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Please use 'description' instead.") NSString * errorDescription __attribute__((deprecated("Please use 'description' instead.")));
		[Export ("errorDescription")]
		string ErrorDescription { get; }

		// @property (readonly, nonatomic) enum CustomerManagerErrorType type;
		[Export ("type")]
		CustomerManagerErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface ETAConfig : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy9ETAConfig")]
	[DisableDefaultCtor]
	interface ETAConfig
	{
	}

	// @interface FlyBuyAPIError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyAPIError
	{
		// @property (readonly, nonatomic) enum FlyBuyAPIErrorType type;
		[Export ("type")]
		FlyBuyAPIErrorType Type { get; }

		// @property (readonly, nonatomic) NSInteger statusCodeInt;
		[Export ("statusCodeInt")]
		nint StatusCodeInt { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface FlyBuyGeofence : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyGeofence
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull latitude;
		[Export ("latitude")]
		string Latitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull longitude;
		[Export ("longitude")]
		string Longitude { get; }

		// @property (readonly, nonatomic) double radiusMeters;
		[Export ("radiusMeters")]
		double RadiusMeters { get; }
	}

	// @interface FlybuyLink : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlybuyLink
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export ("url")]
		string Url { get; }

		// @property (readonly, nonatomic) enum FlybuyLinkType type;
		[Export ("type")]
		FlybuyLinkType Type { get; }

		// @property (readonly, nonatomic, strong) FlyBuyOrderOptionsBuilder * _Nullable orderOptions;
		[NullAllowed, Export ("orderOptions", ArgumentSemantic.Strong)]
		FlyBuyOrderOptionsBuilder OrderOptions { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull params;
		[Export ("params", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Params { get; }
	}

	// @interface FlyBuyLinks : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyLinks
	{
		// +(FlybuyLink * _Nonnull)parseWithUrl:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Static]
		[Export ("parseWithUrl:")]
		FlybuyLink ParseWithUrl (NSUrl url);
	}

	// @interface FlyBuyLogger : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyLogger
	{
	}

	// @interface NotifyConfig : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy12NotifyConfig")]
	[DisableDefaultCtor]
	interface NotifyConfig
	{
	}

	// @interface FlyBuyOrder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrder : INativeObject
    {
		// @property (readonly, nonatomic) NSInteger id;
		[Export ("id")]
		nint Id { get; }

		// @property (readonly, nonatomic) NSInteger siteID;
		[Export ("siteID")]
		nint SiteID { get; }

		// @property (copy, nonatomic) NSString * _Nonnull state;
		[Export ("state")]
		string State { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull customerState;
		[Export ("customerState")]
		string CustomerState { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable partnerIdentifier;
		[NullAllowed, Export ("partnerIdentifier")]
		string PartnerIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable redemptionCode;
		[NullAllowed, Export ("redemptionCode")]
		string RedemptionCode { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable redeemedAt;
		[NullAllowed, Export ("redeemedAt", ArgumentSemantic.Copy)]
		NSDate RedeemedAt { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; }

		// @property (readonly, nonatomic, strong) FlyBuyPickupWindow * _Nullable pickupWindow;
		[NullAllowed, Export ("pickupWindow", ArgumentSemantic.Strong)]
		FlyBuyPickupWindow PickupWindow { get; }

		// @property (copy, nonatomic) NSString * _Nullable pickupType;
		[NullAllowed, Export ("pickupType")]
		string PickupType { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable etaAt;
		[NullAllowed, Export ("etaAt", ArgumentSemantic.Copy)]
		NSDate EtaAt { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable completedAt;
		[NullAllowed, Export ("completedAt", ArgumentSemantic.Copy)]
		NSDate CompletedAt { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Copy)]
		NSDate CreatedAt { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable updatedAt;
		[NullAllowed, Export ("updatedAt", ArgumentSemantic.Copy)]
		NSDate UpdatedAt { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customerRating;
		[NullAllowed, Export ("customerRating")]
		string CustomerRating { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customerComment;
		[NullAllowed, Export ("customerComment")]
		string CustomerComment { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteName;
		[NullAllowed, Export ("siteName")]
		string SiteName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sitePhone;
		[NullAllowed, Export ("sitePhone")]
		string SitePhone { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteStreetAddress;
		[NullAllowed, Export ("siteStreetAddress")]
		string SiteStreetAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteFullAddress;
		[NullAllowed, Export ("siteFullAddress")]
		string SiteFullAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteLocality;
		[NullAllowed, Export ("siteLocality")]
		string SiteLocality { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteRegion;
		[NullAllowed, Export ("siteRegion")]
		string SiteRegion { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteCountry;
		[NullAllowed, Export ("siteCountry")]
		string SiteCountry { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sitePostalCode;
		[NullAllowed, Export ("sitePostalCode")]
		string SitePostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteLongitude;
		[NullAllowed, Export ("siteLongitude")]
		string SiteLongitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteLatitude;
		[NullAllowed, Export ("siteLatitude")]
		string SiteLatitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteInstructions;
		[NullAllowed, Export ("siteInstructions")]
		string SiteInstructions { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteDescription;
		[NullAllowed, Export ("siteDescription")]
		string SiteDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable siteCoverPhotoURL;
		[NullAllowed, Export ("siteCoverPhotoURL")]
		string SiteCoverPhotoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sitePartnerIdentifier;
		[NullAllowed, Export ("sitePartnerIdentifier")]
		string SitePartnerIdentifier { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use order.sitePickupConfig.projectAccentColor instead") NSString * projectAccentColor __attribute__((deprecated("Use order.sitePickupConfig.projectAccentColor instead")));
		[Export ("projectAccentColor")]
		string ProjectAccentColor { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use order.sitePickupConfig.projectAccentTextColor instead") NSString * projectAccentTextColor __attribute__((deprecated("Use order.sitePickupConfig.projectAccentTextColor instead")));
		[Export ("projectAccentTextColor")]
		string ProjectAccentTextColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectLogoURL;
		[NullAllowed, Export ("projectLogoURL")]
		string ProjectLogoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerName;
		[NullAllowed, Export ("customerName")]
		string CustomerName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerCarType;
		[NullAllowed, Export ("customerCarType")]
		string CustomerCarType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerCarColor;
		[NullAllowed, Export ("customerCarColor")]
		string CustomerCarColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerLicensePlate;
		[NullAllowed, Export ("customerLicensePlate")]
		string CustomerLicensePlate { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowAlwaysShowVehicleInfoFields __attribute__((deprecated("Use showVehicleInfoFields for the pickup type in sitePickupConfig.availablePickupTypes")));
		[Export ("projectMobileFlowAlwaysShowVehicleInfoFields")]
		bool ProjectMobileFlowAlwaysShowVehicleInfoFields { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowCustomerNameEditingEnabled __attribute__((deprecated("Use order.sitePickupConfig.customerNameEditingEnabled instead")));
		[Export ("projectMobileFlowCustomerNameEditingEnabled")]
		bool ProjectMobileFlowCustomerNameEditingEnabled { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowPickupTypeSelectionEnabled __attribute__((deprecated("Use order.sitePickupConfig.pickupTypeSelectionEnabled instead")));
		[Export ("projectMobileFlowPickupTypeSelectionEnabled")]
		bool ProjectMobileFlowPickupTypeSelectionEnabled { get; }

		// @property (readonly, nonatomic) BOOL projectMobileFlowRequireVehicleInfoIfVisible __attribute__((deprecated("Use requiredVehicleInfo for the pickup type in sitePickupConfig.availablePickupTypes")));
		[Export ("projectMobileFlowRequireVehicleInfoIfVisible")]
		bool ProjectMobileFlowRequireVehicleInfoIfVisible { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use pickupTypeLocalizedString for the pickup type in sitePickupConfig.availablePickupTypes") NSString * curbsideLocalizedString __attribute__((deprecated("Use pickupTypeLocalizedString for the pickup type in sitePickupConfig.availablePickupTypes")));
		[Export ("curbsideLocalizedString")]
		string CurbsideLocalizedString { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use pickupTypeLocalizedString for the pickup type in sitePickupConfig.availablePickupTypes") NSString * pickupLocalizedString __attribute__((deprecated("Use pickupTypeLocalizedString for the pickup type in sitePickupConfig.availablePickupTypes")));
		[Export ("pickupLocalizedString")]
		string PickupLocalizedString { get; }

		// @property (copy, nonatomic) NSString * _Nullable pushToken;
		[NullAllowed, Export ("pushToken")]
		string PushToken { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable spotIdentifer;
		[NullAllowed, Export ("spotIdentifer")]
		string SpotIdentifer { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable spotIdentifierInputType;
		[NullAllowed, Export ("spotIdentifierInputType")]
		string SpotIdentifierInputType { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable partnerIdentifierForCustomer;
		[NullAllowed, Export ("partnerIdentifierForCustomer")]
		string PartnerIdentifierForCustomer { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable partnerIdentifierForCrew;
		[NullAllowed, Export ("partnerIdentifierForCrew")]
		string PartnerIdentifierForCrew { get; }

		// @property (readonly, nonatomic) BOOL wrongSiteDetectionEnabled;
		[Export ("wrongSiteDetectionEnabled")]
		bool WrongSiteDetectionEnabled { get; }

		// @property (readonly, nonatomic) BOOL distanceFilteringDisabled;
		[Export ("distanceFilteringDisabled")]
		bool DistanceFilteringDisabled { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable wrongSiteSearchRadius;
		[NullAllowed, Export ("wrongSiteSearchRadius", ArgumentSemantic.Strong)]
		NSNumber WrongSiteSearchRadius { get; }

		// -(CLLocation * _Nullable)siteLocation __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("siteLocation")]
		CLLocation SiteLocation { get; }

		// -(NSNumber * _Nullable)siteDistanceFrom:(CLLocation * _Nonnull)location __attribute__((warn_unused_result("")));
		[Export ("siteDistanceFrom:")]
		[return: NullAllowed]
		NSNumber SiteDistanceFrom (CLLocation location);

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable customerID;
		[NullAllowed, Export ("customerID", ArgumentSemantic.Strong)]
		NSNumber CustomerID { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable sitePrearrivalSeconds;
		[NullAllowed, Export ("sitePrearrivalSeconds", ArgumentSemantic.Strong)]
		NSNumber SitePrearrivalSeconds { get; }
	}

	// @interface FlyBuyOrderEvent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrderEvent
	{
	}

	// @interface FlyBuyOrderOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrderOptions
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull customerName;
		[Export ("customerName")]
		string CustomerName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerPhone;
		[NullAllowed, Export ("customerPhone")]
		string CustomerPhone { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerCarColor;
		[NullAllowed, Export ("customerCarColor")]
		string CustomerCarColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerCarType;
		[NullAllowed, Export ("customerCarType")]
		string CustomerCarType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerCarLicensePlate;
		[NullAllowed, Export ("customerCarLicensePlate")]
		string CustomerCarLicensePlate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull partnerIdentifier;
		[Export ("partnerIdentifier")]
		string PartnerIdentifier { get; }

		// @property (readonly, nonatomic, strong) FlyBuyPickupWindow * _Nullable pickupWindow;
		[NullAllowed, Export ("pickupWindow", ArgumentSemantic.Strong)]
		FlyBuyPickupWindow PickupWindow { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export ("state")]
		string State { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable pickupType;
		[NullAllowed, Export ("pickupType")]
		string PickupType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable spotIdentifier;
		[NullAllowed, Export ("spotIdentifier")]
		string SpotIdentifier { get; }
	}

	// @interface FlyBuyOrderOptionsBuilder : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrderOptionsBuilder
	{
	}

	// @interface FlyBuyOrdersManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuyOrdersManager
	{
		// @property (readonly, copy, nonatomic) NSArray<FlyBuyOrder *> * _Nonnull all;
		[Export ("all", ArgumentSemantic.Copy)]
		FlyBuyOrder[] All { get; }

		// @property (readonly, copy, nonatomic) NSArray<FlyBuyOrder *> * _Nonnull open;
		[Export ("open", ArgumentSemantic.Copy)]
		FlyBuyOrder[] Open { get; }

		// @property (readonly, copy, nonatomic) NSArray<FlyBuyOrder *> * _Nonnull closed;
		[Export ("closed", ArgumentSemantic.Copy)]
		FlyBuyOrder[] Closed { get; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull orderStates;
		[Export ("orderStates", ArgumentSemantic.Copy)]
		string[] OrderStates { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull customerStates;
		[Export ("customerStates", ArgumentSemantic.Copy)]
		string[] CustomerStates { get; set; }

		// -(void)fetchWithCallback:(void (^ _Nullable)(NSArray<FlyBuyOrder *> * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithCallback:")]
		void FetchWithCallback ([NullAllowed] Action<NSArray<FlyBuyOrder>, NSError> callback);

		// -(void)fetchWithRedemptionCode:(NSString * _Nonnull)redemptionCode callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchWithRedemptionCode:callback:")]
		void FetchWithRedemptionCode (string redemptionCode, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)claimWithRedemptionCode:(NSString * _Nonnull)redemptionCode orderOptions:(FlyBuyOrderOptions * _Nonnull)orderOptions callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("claimWithRedemptionCode:orderOptions:callback:")]
		void ClaimWithRedemptionCode (string redemptionCode, FlyBuyOrderOptions orderOptions, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)claimWithRedemptionCode:(NSString * _Nonnull)redemptionCode customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for claiming an order has been deprecated. Use claim(withRedemptionCode, orderOptions) instead.")));
		[Export ("claimWithRedemptionCode:customerInfo:pickupType:callback:")]
		void ClaimWithRedemptionCode (string redemptionCode, FlyBuyCustomerInfo customerInfo, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSitePartnerIdentifier:(NSString * _Nonnull)sitePartnerIdentifier orderPartnerIdentifier:(NSString * _Nonnull)orderPartnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow state:(NSString * _Nullable)state pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSitePartnerIdentifier:orderPartnerIdentifier:customerInfo:pickupWindow:state:pickupType:callback:")]
		void CreateWithSitePartnerIdentifier (string sitePartnerIdentifier, string orderPartnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, [NullAllowed] string state, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSitePartnerIdentifier:(NSString * _Nonnull)sitePartnerIdentifier orderPartnerIdentifier:(NSString * _Nonnull)orderPartnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow state:(NSString * _Nonnull)state callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSitePartnerIdentifier:orderPartnerIdentifier:customerInfo:pickupWindow:state:callback:")]
		void CreateWithSitePartnerIdentifier (string sitePartnerIdentifier, string orderPartnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, string state, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSitePartnerIdentifier:(NSString * _Nonnull)sitePartnerIdentifier orderPartnerIdentifier:(NSString * _Nonnull)orderPartnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSitePartnerIdentifier:orderPartnerIdentifier:customerInfo:pickupWindow:callback:")]
		void CreateWithSitePartnerIdentifier (string sitePartnerIdentifier, string orderPartnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSitePartnerIdentifier:(NSString * _Nonnull)sitePartnerIdentifier orderPartnerIdentifier:(NSString * _Nonnull)orderPartnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		//[Export ("createWithSitePartnerIdentifier:orderPartnerIdentifier:customerInfo:pickupWindow:pickupType:callback:")]
		//void CreateWithSitePartnerIdentifier (string sitePartnerIdentifier, string orderPartnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSitePartnerIdentifier:(NSString * _Nonnull)sitePartnerIdentifier orderPartnerIdentifier:(NSString * _Nonnull)orderPartnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo state:(NSString * _Nullable)state pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSitePartnerIdentifier:orderPartnerIdentifier:customerInfo:state:pickupType:callback:")]
		void CreateWithSitePartnerIdentifier (string sitePartnerIdentifier, string orderPartnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] string state, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow state:(NSString * _Nonnull)state callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:state:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, string state, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow state:(NSString * _Nonnull)state pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:state:pickupType:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, string state, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo pickupWindow:(FlyBuyPickupWindow * _Nullable)pickupWindow pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		//[Export ("createWithSiteID:partnerIdentifier:customerInfo:pickupWindow:pickupType:callback:")]
		//void CreateWithSiteID (nint siteID, string partnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] FlyBuyPickupWindow pickupWindow, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID partnerIdentifier:(NSString * _Nonnull)partnerIdentifier customerInfo:(FlyBuyCustomerInfo * _Nonnull)customerInfo state:(NSString * _Nullable)state pickupType:(NSString * _Nullable)pickupType callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for creating an order has been deprecated. Use create(siteID, orderOptions) instead.")));
		[Export ("createWithSiteID:partnerIdentifier:customerInfo:state:pickupType:callback:")]
		void CreateWithSiteID (nint siteID, string partnerIdentifier, FlyBuyCustomerInfo customerInfo, [NullAllowed] string state, [NullAllowed] string pickupType, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSiteID:(NSInteger)siteID orderOptions:(FlyBuyOrderOptions * _Nonnull)orderOptions callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("createWithSiteID:orderOptions:callback:")]
		void CreateWithSiteID (nint siteID, FlyBuyOrderOptions orderOptions, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)createWithSitePartnerIdentifier:(NSString * _Nonnull)sitePartnerIdentifier orderOptions:(FlyBuyOrderOptions * _Nonnull)orderOptions callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("createWithSitePartnerIdentifier:orderOptions:callback:")]
		void CreateWithSitePartnerIdentifier (string sitePartnerIdentifier, FlyBuyOrderOptions orderOptions, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)updateCustomerStateWithOrderID:(NSInteger)orderID customerState:(NSString * _Nonnull)customerState callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("updateCustomerStateWithOrderID:customerState:callback:")]
		void UpdateCustomerStateWithOrderID (nint orderID, string customerState, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)updateCustomerStateWithOrderID:(NSInteger)orderID customerState:(NSString * _Nonnull)customerState spotIdentifier:(NSString * _Nullable)spotIdentifier callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("updateCustomerStateWithOrderID:customerState:spotIdentifier:callback:")]
		void UpdateCustomerStateWithOrderID (nint orderID, string customerState, [NullAllowed] string spotIdentifier, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)updateOrderStateWithOrderID:(NSInteger)orderID state:(NSString * _Nonnull)state callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("updateOrderStateWithOrderID:state:callback:")]
		void UpdateOrderStateWithOrderID (nint orderID, string state, [NullAllowed] Action<FlyBuyOrder, NSError> callback);

		// -(void)rateOrderWithOrderID:(NSInteger)orderID rating:(NSInteger)rating comments:(NSString * _Nullable)comments callback:(void (^ _Nullable)(FlyBuyOrder * _Nullable, NSError * _Nullable))callback;
		[Export ("rateOrderWithOrderID:rating:comments:callback:")]
		void RateOrderWithOrderID (nint orderID, nint rating, [NullAllowed] string comments, [NullAllowed] Action<FlyBuyOrder, NSError> callback);
	}

	// @interface FlyBuyOrdersManagerError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyOrdersManagerError
	{
		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Please use 'description' instead.") NSString * errorDescription __attribute__((deprecated("Please use 'description' instead.")));
		[Export ("errorDescription")]
		string ErrorDescription { get; }

		// @property (readonly, nonatomic) enum OrdersManagerErrorType type;
		[Export ("type")]
		OrdersManagerErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface FlyBuyPagination : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyPagination
	{
		// @property (readonly, nonatomic) NSInteger currentPage;
		[Export ("currentPage")]
		nint CurrentPage { get; }

		// @property (readonly, nonatomic) NSInteger totalPages;
		[Export ("totalPages")]
		nint TotalPages { get; }
	}

	// @interface PickupConfig : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy12PickupConfig")]
	[DisableDefaultCtor]
	interface PickupConfig
	{
		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; set; }

		// @property (readonly, nonatomic) NSInteger id;
		[Export ("id")]
		nint Id { get; }

		// @property (readonly, nonatomic) BOOL customerNameEditingEnabled;
		[Export ("customerNameEditingEnabled")]
		bool CustomerNameEditingEnabled { get; }

		// @property (readonly, nonatomic) BOOL pickupTypeSelectionEnabled;
		[Export ("pickupTypeSelectionEnabled")]
		bool PickupTypeSelectionEnabled { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable askToAskImageURL;
		[NullAllowed, Export ("askToAskImageURL")]
		string AskToAskImageURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull accentColor;
		[Export ("accentColor")]
		string AccentColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull accentTextColor;
		[Export ("accentTextColor")]
		string AccentTextColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable termsOfServiceURL;
		[NullAllowed, Export ("termsOfServiceURL")]
		string TermsOfServiceURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable privacyPolicyURL;
		[NullAllowed, Export ("privacyPolicyURL")]
		string PrivacyPolicyURL { get; }

		// @property (readonly, copy, nonatomic) NSArray<PickupTypeConfig *> * _Nonnull availablePickupTypes;
		[Export ("availablePickupTypes", ArgumentSemantic.Copy)]
		PickupTypeConfig[] AvailablePickupTypes { get; }
	}

	// @interface PickupTypeConfig : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy16PickupTypeConfig")]
	interface PickupTypeConfig
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull pickupType;
		[Export ("pickupType")]
		string PickupType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull pickupTypeLocalizedString;
		[Export ("pickupTypeLocalizedString")]
		string PickupTypeLocalizedString { get; }

		// @property (readonly, nonatomic) BOOL showVehicleInfoFields;
		[Export ("showVehicleInfoFields")]
		bool ShowVehicleInfoFields { get; }

		// @property (readonly, nonatomic) BOOL requireVehicleInfo;
		[Export ("requireVehicleInfo")]
		bool RequireVehicleInfo { get; }
	}

	// @interface FlyBuyPickupWindow : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuyPickupWindow
	{
		// @property (readonly, copy, nonatomic) NSDate * _Nonnull start;
		[Export ("start", ArgumentSemantic.Copy)]
		NSDate Start { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull end;
		[Export ("end", ArgumentSemantic.Copy)]
		NSDate End { get; }

		// -(instancetype _Nonnull)initWithStart:(NSDate * _Nonnull)start end:(NSDate * _Nonnull)end __attribute__((objc_designated_initializer));
		[Export ("initWithStart:end:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDate start, NSDate end);

		// -(instancetype _Nonnull)init:(NSDate * _Nonnull)date;
		[Export ("init:")]
		IntPtr Constructor (NSDate date);

		// -(NSString * _Nonnull)formattedStringWithLocale:(NSLocale * _Nonnull)locale __attribute__((warn_unused_result("")));
		[Export ("formattedStringWithLocale:")]
		string FormattedStringWithLocale (NSLocale locale);
	}

	// @interface FlyBuySite : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuySite : INativeObject
    {
		// @property (readonly, nonatomic) NSInteger id;
		[Export ("id")]
		nint Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable partnerIdentifier;
		[NullAllowed, Export ("partnerIdentifier")]
		string PartnerIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable streetAddress;
		[NullAllowed, Export ("streetAddress")]
		string StreetAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fullAddress;
		[NullAllowed, Export ("fullAddress")]
		string FullAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable locality;
		[NullAllowed, Export ("locality")]
		string Locality { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable region;
		[NullAllowed, Export ("region")]
		string Region { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable longitude;
		[NullAllowed, Export ("longitude")]
		string Longitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable latitude;
		[NullAllowed, Export ("latitude")]
		string Latitude { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable instructions;
		[NullAllowed, Export ("instructions")]
		string Instructions { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable descriptionText;
		[NullAllowed, Export ("descriptionText")]
		string DescriptionText { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable coverPhotoURL;
		[NullAllowed, Export ("coverPhotoURL")]
		string CoverPhotoURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectAccentColor;
		[NullAllowed, Export ("projectAccentColor")]
		string ProjectAccentColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectAccentTextColor;
		[NullAllowed, Export ("projectAccentTextColor")]
		string ProjectAccentTextColor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable projectLogoURL;
		[NullAllowed, Export ("projectLogoURL")]
		string ProjectLogoURL { get; }

		// @property (readonly, nonatomic, strong) FlyBuyGeofence * _Nullable geofence;
		[NullAllowed, Export ("geofence", ArgumentSemantic.Strong)]
		FlyBuyGeofence Geofence { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nonnull wrongSiteArrivalRadius;
		[Export ("wrongSiteArrivalRadius", ArgumentSemantic.Strong)]
		NSNumber WrongSiteArrivalRadius { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable operationalStatus;
		[NullAllowed, Export ("operationalStatus")]
		string OperationalStatus { get; }

		// -(CLLocation * _Nullable)location __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("location")]
		CLLocation Location { get; }

		// -(NSNumber * _Nullable)distanceFrom:(CLLocation * _Nonnull)loc __attribute__((warn_unused_result("")));
		[Export ("distanceFrom:")]
		[return: NullAllowed]
		NSNumber DistanceFrom (CLLocation loc);
	}

	// @interface FlyBuySitesManager : NSObject
	[BaseType (typeof(NSObject))]
	interface FlyBuySitesManager
	{
		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("This method for fetching sites has been deprecated. Use FlyBuy.Core.sites.fetchByPartnerIdentifier instead.") NSArray<FlyBuySite *> * all __attribute__((deprecated("This method for fetching sites has been deprecated. Use FlyBuy.Core.sites.fetchByPartnerIdentifier instead.")));
		[Export ("all", ArgumentSemantic.Copy)]
		FlyBuySite[] All { get; }

		// -(void)fetchByPartnerIdentifierWithPartnerIdentifier:(NSString * _Nonnull)partnerIdentifier operationalStatus:(NSString * _Nonnull)operationalStatus callback:(void (^ _Nullable)(FlyBuySite * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchByPartnerIdentifierWithPartnerIdentifier:operationalStatus:callback:")]
		void FetchByPartnerIdentifierWithPartnerIdentifier (string partnerIdentifier, string operationalStatus, [NullAllowed] Action<FlyBuySite, NSError> callback);

		// -(void)fetchByPartnerIdentifierWithPartnerIdentifier:(NSString * _Nonnull)partnerIdentifier callback:(void (^ _Nullable)(FlyBuySite * _Nullable, NSError * _Nullable))callback;
		[Export ("fetchByPartnerIdentifierWithPartnerIdentifier:callback:")]
		void FetchByPartnerIdentifierWithPartnerIdentifier (string partnerIdentifier, [NullAllowed] Action<FlyBuySite, NSError> callback);

		// -(void)fetchWithQuery:(NSString * _Nullable)query page:(NSInteger)page callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, FlyBuyPagination * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for fetching sites has been deprecated. Use FlyBuy.Core.sites.fetchByPartnerIdentifier instead.")));
		[Export ("fetchWithQuery:page:callback:")]
		void FetchWithQuery ([NullAllowed] string query, nint page, [NullAllowed] Action<NSArray<FlyBuySite>, FlyBuyPagination, NSError> callback);

		// -(void)fetchWithQuery:(NSString * _Nullable)query page:(NSInteger)page operationalStatus:(NSString * _Nonnull)operationalStatus callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, FlyBuyPagination * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for fetching sites has been deprecated. Use FlyBuy.Core.sites.fetchByPartnerIdentifier instead.")));
		[Export ("fetchWithQuery:page:operationalStatus:callback:")]
		void FetchWithQuery ([NullAllowed] string query, nint page, string operationalStatus, [NullAllowed] Action<NSArray<FlyBuySite>, FlyBuyPagination, NSError> callback);

		// -(void)fetchWithRegion:(CLCircularRegion * _Nonnull)region page:(NSInteger)page callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for fetching sites has been deprecated and will be removed in a future SDK release.")));
		[Export ("fetchWithRegion:page:callback:")]
		void FetchWithRegion (CLCircularRegion region, nint page, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);

		// -(void)fetchWithRegion:(CLCircularRegion * _Nonnull)region page:(NSInteger)page operationalStatus:(NSString * _Nonnull)operationalStatus callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for fetching sites has been deprecated and will be removed in a future SDK release.")));
		[Export ("fetchWithRegion:page:operationalStatus:callback:")]
		void FetchWithRegion (CLCircularRegion region, nint page, string operationalStatus, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);

		// -(void)fetchWithRegion:(CLCircularRegion * _Nonnull)region page:(NSInteger)page per:(NSInteger)per callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for fetching sites has been deprecated and will be removed in a future SDK release.")));
		[Export ("fetchWithRegion:page:per:callback:")]
		void FetchWithRegion (CLCircularRegion region, nint page, nint per, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);

		// -(void)fetchWithRegion:(CLCircularRegion * _Nonnull)region page:(NSInteger)page per:(NSInteger)per operationalStatus:(NSString * _Nonnull)operationalStatus callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for fetching sites has been deprecated and will be removed in a future SDK release.")));
		[Export ("fetchWithRegion:page:per:operationalStatus:callback:")]
		void FetchWithRegion (CLCircularRegion region, nint page, nint per, string operationalStatus, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);

		// -(void)fetchAllWithQuery:(NSString * _Nullable)query callback:(void (^ _Nullable)(NSArray<FlyBuySite *> * _Nullable, NSError * _Nullable))callback __attribute__((deprecated("This method for fetching sites has been deprecated. Use FlyBuyCore.sites.fetchByPartnerIdentifier instead.")));
		[Export ("fetchAllWithQuery:callback:")]
		void FetchAllWithQuery ([NullAllowed] string query, [NullAllowed] Action<NSArray<FlyBuySite>, NSError> callback);
	}

	// @interface FlyBuySitesManagerError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FlyBuySitesManagerError
	{
		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Please use 'description' instead.") NSString * errorDescription __attribute__((deprecated("Please use 'description' instead.")));
		[Export ("errorDescription")]
		string ErrorDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface WrongSiteArrivalConfig : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6FlyBuy22WrongSiteArrivalConfig")]
	[DisableDefaultCtor]
	interface WrongSiteArrivalConfig
	{
	}
}
