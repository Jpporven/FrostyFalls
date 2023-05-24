using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

// Placing the Purchaser class in the CompleteProject namespace allows it to interact with ScoreManager, 
namespace FrostyFallsAlpha
{
    // Deriving the Purchaser class from IStoreListener enables it to receive messages from Unity Purchasing.
    public class purchaser : MonoBehaviour, IStoreListener
    {
        public buyandequip buy;
        private static IStoreController m_StoreController;          // The Unity Purchasing system.
        private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.

        // Product identifiers for all products capable of being purchased: 
        // "convenience" general identifiers for use with Purchasing, and their store-specific identifier 
        // counterparts for use with and outside of Unity Purchasing. Define store-specific identifiers 
        // also on each platform's publisher dashboard (iTunes Connect, Google Play Developer Console, etc.)

        // General product identifiers for the consumable, non-consumable, and subscription products.
        // Use these handles in the code to reference which product to purchase. Also use these values 
        // when defining the Product Identifiers on the store. Except, for illustration purposes, the 
        // kProductIDSubscription - it has custom Apple and Google identifiers. We declare their store-
        // specific mapping to Unity Purchasing's AddProduct, below.
        public static string kProductIDCostume1 = "costume1";
        public static string kProductIDCostume2 = "costume2";
        public static string kProductIDCostume3 = "costume3";
        public static string kProductIDCostume4 = "costume4";
        public static string kProductIDCostume5 = "costume5";
        public static string kProductIDCostume6 = "costume6";
        public static string kProductIDCostume7 = "costume7";
        public static string kProductIDCostume8 = "costume8";
        public static string kProductIDCostume9 = "costume9";
        public static string kProductIDCostume10 = "costume10";
        public static string kProductIDCostume11 = "costume11";
        public static string kProductIDCostume12 = "costume12";

        public static string kProductIDnoADS = "noADS";

        string item1Price;
        string item2Price;
        string item3Price;
        string item4Price;
        string item5Price;
        string item6Price;
        string item7Price;
        string item8Price;
        string item9Price;
        string item10Price;
        string item11Price;
        string item12Price;
        string noAdsPrice;


        // Apple App Store-specific product identifier for the subscription product.
        private static string kProductNameAppleSubscription = "com.unity3d.subscription.new";

        // Google Play Store-specific product identifier subscription product.
        private static string kProductNameGooglePlaySubscription = "com.unity3d.subscription.original";

        void Start()
        {
            // If we haven't set up the Unity Purchasing reference
            if (m_StoreController == null)
            {
                // Begin to configure our connection to Purchasing
                InitializePurchasing();
            }
        }


        public void InitializePurchasing()
        {


            // If we have already connected to Purchasing ...
            if (IsInitialized())
            {
                // ... we are done here.
                return;
            }

            // Create a builder, first passing in a suite of Unity provided stores.
            var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

            // Add a product to sell / restore by way of its identifier, associating the general identifier
            // with its store-specific identifiers.
            builder.AddProduct(kProductIDCostume1, ProductType.NonConsumable);
            // Continue adding the non-consumable product.
            builder.AddProduct(kProductIDCostume2, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume3, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume4, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume5, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume6, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume7, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume8, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume9, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume10, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume11, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume12, ProductType.NonConsumable);

            builder.AddProduct(kProductIDCostume12, ProductType.NonConsumable);

            builder.AddProduct(kProductIDnoADS, ProductType.NonConsumable);



            // And finish adding the subscription product. Notice this uses store-specific IDs, illustrating
            // if the Product ID was configured differently between Apple and Google stores. Also note that
            // one uses the general kProductIDSubscription handle inside the game - the store-specific IDs 
            // must only be referenced here. 

            // Kick off the remainder of the set-up with an asynchrounous call, passing the configuration 
            // and this class' instance. Expect a response either in OnInitialized or OnInitializeFailed.
            UnityPurchasing.Initialize(this, builder);

            item1Price = m_StoreController.products.WithID(kProductIDCostume1).metadata.isoCurrencyCode + " 1.99 "
              + m_StoreController.products.WithID(kProductIDCostume1).metadata.localizedPrice.ToString();
            item2Price = m_StoreController.products.WithID(kProductIDCostume2).metadata.isoCurrencyCode + " 1.99 "
              + m_StoreController.products.WithID(kProductIDCostume2).metadata.localizedPrice.ToString();
            item3Price = m_StoreController.products.WithID(kProductIDCostume3).metadata.isoCurrencyCode + " 1.99 "
              + m_StoreController.products.WithID(kProductIDCostume3).metadata.localizedPrice.ToString();
            item4Price = m_StoreController.products.WithID(kProductIDCostume4).metadata.isoCurrencyCode + " 1.99 "
              + m_StoreController.products.WithID(kProductIDCostume4).metadata.localizedPrice.ToString();
            item5Price = m_StoreController.products.WithID(kProductIDCostume5).metadata.isoCurrencyCode + " 1.99 "
              + m_StoreController.products.WithID(kProductIDCostume5).metadata.localizedPrice.ToString();
            item6Price = m_StoreController.products.WithID(kProductIDCostume6).metadata.isoCurrencyCode + " 1.99 "
              + m_StoreController.products.WithID(kProductIDCostume6).metadata.localizedPrice.ToString();
            item7Price = m_StoreController.products.WithID(kProductIDCostume7).metadata.isoCurrencyCode + " 1.99 "
              + m_StoreController.products.WithID(kProductIDCostume7).metadata.localizedPrice.ToString();
            item8Price = m_StoreController.products.WithID(kProductIDCostume8).metadata.isoCurrencyCode + " 2.99 "
              + m_StoreController.products.WithID(kProductIDCostume8).metadata.localizedPrice.ToString();
            item9Price = m_StoreController.products.WithID(kProductIDCostume9).metadata.isoCurrencyCode + " 2.99 "
              + m_StoreController.products.WithID(kProductIDCostume9).metadata.localizedPrice.ToString();
            item10Price = m_StoreController.products.WithID(kProductIDCostume10).metadata.isoCurrencyCode + " 2.99 "
              + m_StoreController.products.WithID(kProductIDCostume10).metadata.localizedPrice.ToString();
            item11Price = m_StoreController.products.WithID(kProductIDCostume11).metadata.isoCurrencyCode + " 4.99 "
              + m_StoreController.products.WithID(kProductIDCostume11).metadata.localizedPrice.ToString();
            item12Price = m_StoreController.products.WithID(kProductIDCostume12).metadata.isoCurrencyCode + " 4.99 "
              + m_StoreController.products.WithID(kProductIDCostume12).metadata.localizedPrice.ToString();

            noAdsPrice = m_StoreController.products.WithID(kProductIDnoADS).metadata.isoCurrencyCode + " 4.99 "
              + m_StoreController.products.WithID(kProductIDnoADS).metadata.localizedPrice.ToString();

        }


        private bool IsInitialized()
        {
            // Only say we are initialized if both the Purchasing references are set.
            return m_StoreController != null && m_StoreExtensionProvider != null;
        }


        public void BuyCostume1()
        {
            // Buy the consumable product using its general identifier. Expect a response either 
            // through ProcessPurchase or OnPurchaseFailed asynchronously.


            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume1);
        }


        public void BuyCostume2()
        {
            // Buy the non-consumable product using its general identifier. Expect a response either 
            // through ProcessPurchase or OnPurchaseFailed asynchronously.


            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume2);
        }


        public void BuyCostume3()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume3);
        }

        public void BuyCostume4()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume4);
        }

        public void BuyCostume5()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume5);
        }

        public void BuyCostume6()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume6);
        }

        public void BuyCostume7()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume7);
        }

        public void BuyCostume8()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume8);
        }

        public void BuyCostume9()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume9);
        }

        public void BuyCostume10()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume10);
        }

        public void BuyCostume11()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume11);
        }

        public void BuyCostume12()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDCostume12);
        }


        public void BuyNoAds()
        {
            AudioLibrary.PurchasedSource.Play();

            BuyProductID(kProductIDnoADS);
        }


        void BuyProductID(string productId)
        {
            // If Purchasing has been initialized ...
            if (IsInitialized())
            {
                // ... look up the Product reference with the general product identifier and the Purchasing 
                // system's products collection.
                Product product = m_StoreController.products.WithID(productId);

                // If the look up found a product for this device's store and that product is ready to be sold ... 
                if (product != null && product.availableToPurchase)
                {
                    Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                    // ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed 
                    // asynchronously.
                    m_StoreController.InitiatePurchase(product);
                }
                // Otherwise ...
                else
                {
                    // ... report the product look-up failure situation  
                    Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
                }
            }
            // Otherwise ...
            else
            {
                // ... report the fact Purchasing has not succeeded initializing yet. Consider waiting longer or 
                // retrying initiailization.
                Debug.Log("BuyProductID FAIL. Not initialized.");
            }
        }


        // Restore purchases previously made by this customer. Some platforms automatically restore purchases, like Google. 
        // Apple currently requires explicit purchase restoration for IAP, conditionally displaying a password prompt.
        public void RestorePurchases()
        {
            // If Purchasing has not yet been set up ...
            if (!IsInitialized())
            {
                // ... report the situation and stop restoring. Consider either waiting longer, or retrying initialization.
                Debug.Log("RestorePurchases FAIL. Not initialized.");
                return;
            }

            // If we are running on an Apple device ... 
            if (Application.platform == RuntimePlatform.IPhonePlayer ||
                Application.platform == RuntimePlatform.OSXPlayer)
            {
                // ... begin restoring purchases
                Debug.Log("RestorePurchases started ...");

                // Fetch the Apple store-specific subsystem.
                var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
                // Begin the asynchronous process of restoring purchases. Expect a confirmation response in 
                // the Action<bool> below, and ProcessPurchase if there are previously purchased products to restore.
                apple.RestoreTransactions((result) => {
                    // The first phase of restoration. If no more responses are received on ProcessPurchase then 
                    // no purchases are available to be restored.
                    Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
                });
            }
            // Otherwise ...
            else
            {
                // We are not running on an Apple device. No work is necessary to restore purchases.
                Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
            }
        }


        //  
        // --- IStoreListener
        //

        public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
        {
            // Purchasing has succeeded initializing. Collect our Purchasing references.
            Debug.Log("OnInitialized: PASS");

            // Overall Purchasing system, configured with products for this application.
            m_StoreController = controller;
            // Store specific subsystem, for accessing device-specific store features.
            m_StoreExtensionProvider = extensions;

            RestorePurchases();
        }


        public void OnInitializeFailed(InitializationFailureReason error)
        {
            // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
            Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
        }


        public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
        {
            // A consumable product has been purchased by this user.
            if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume1, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // The consumable item has been successfully purchased, add 100 coins to the player's in-game score.

                buy.costume1Purchased = 1;

            }
            // Or ... a non-consumable product has been purchased by this user.
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume2, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

                buy.costume2Purchased = 1;

            }
            // Or ... a subscription product has been purchased by this user.
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume3, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume3Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume4, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume4Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume5, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume5Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume6, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume6Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume7, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume7Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume8, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume8Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume9, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume9Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume10, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume10Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume11, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume11Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDCostume12, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                buy.costume12Purchased = 1;

            }
            else if (String.Equals(args.purchasedProduct.definition.id, kProductIDnoADS, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
                // TODO: The subscription item has been successfully purchased, grant this to the player.

                AdSensor.adsOn = false;

                NoAdsButton.NoAds();


            }
            // Or ... an unknown product has been purchased by this user. Fill in additional products here....
            else
            {


                Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
            }

            // Return a flag indicating whether this product has completely been received, or if the application needs 
            // to be reminded of this purchase at next app launch. Use PurchaseProcessingResult.Pending when still 
            // saving purchased products to the cloud, and when that save is delayed. 
            return PurchaseProcessingResult.Complete;
        }


        public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
        {
            // A product purchase attempt did not succeed. Check failureReason for more detail. Consider sharing 
            // this reason with the user to guide their troubleshooting actions.
            Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
        }

    }


}