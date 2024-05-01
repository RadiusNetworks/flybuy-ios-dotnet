# FlyBuy SDK for iOS on .Net

## Setup

The FlyBuy SDK is published on nuget.org at the following location: https://www.nuget.org/packages/Radiusnetworks.Flybuy.IOS

### Add FlyBuySDK to your .Net MAUI project for iOS

Select `Packages` in your VS project and go to `Manage NuGet Packages...`. Search for `Radiusnetworks.Flybuy.IOS` and click `Add Package`. The latest SDK will be added to your project and can be referenced with the following:
```csharp
using FlyBuy;
```

### Initialize SDK on Launch

The iOS SDK contains two modules:

 * pickup
 * notify

Flybuy needs to be setup and configured at application launch. However, it does not run in the background or use device resources until there is an active order.

The easiest way to configure Flybuy in your app is to call the `FlyBuyCore.Configure(...)` method from `FinishedLaunching()` to setup the API token. Also, any modules that are used need to be configured. The example below shows all modules, but make sure to only configure the modules needed.

```csharp
public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
{
    // Configure SDK
    var token = "102.token";
    var builder = FlyBuyConfigOptions.BuilderWithToken(token);
    builder.SetDeferredLocationTracking(true);
    FlyBuyCore.ConfigureWithOptions(builder.Build);

    // Configure Pickup Module
    FlyBuyPickupManager.Shared.Configure();
    // Configure if using Notify Module
    FlyBuyNotifyManager.Shared.Configure();
}
```

## Components

The following section provides some examples C# syntax for the customer and order components. Refer to the [native documentation](https://www.radiusnetworks.com/developers/flybuy/#/sdk-2.0/customer) for complete details on the SDK components.

Use the following to determine if a customer is associated with the app:
```csharp
Customer currentCustomer = FlyBuyCore.Customer.Current;
```

If no customer, then create the customer using:
```csharp
CustomerInfo customerInfo = new FlyBuyCustomerInfo(
        "Marty McFly",
        "DeLorean",
        "Silver",
        "OUTATIME",
        "555-555-5555"
);
FlyBuyCore.Customer.Create(customerInfo, true, true, createCustomerCallback);
```

Make sure to fetch the order after calling claim using:
```csharp
FlyBuyCore.Orders.ClaimWithRedemptionCode(redemptionCode, customerInfo, null, claimCallback);
FlyBuyCore.Orders.FetchWithCallback(fetchCallback);

```

To update an order use:
```csharp
FlyBuyCore.Orders.UpdateCustomerStateWithOrderID(currentOrder.Id, "completed", completeOrderCallback);
```

