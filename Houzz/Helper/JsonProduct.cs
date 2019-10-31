using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Houzz.Helper
{
    public class ResponsePoduct
    {
            public Data data { get; set; }
            public Abtest abtest { get; set; }
            public Config1 config { get; set; }
            public Permission permission { get; set; }
            public Clientinfo clientInfo { get; set; }
            public string csrfToken { get; set; }
            public string currentVisitorId { get; set; }
            public string consentedVisitorIdToken { get; set; }
            public string currentLocale { get; set; }
            public string siteId { get; set; }
            public string rid { get; set; }
            public long rts { get; set; }
            public Pagedescriptor1 pageDescriptor { get; set; }
            public string env { get; set; }
            public string version { get; set; }
            public bool isHttps { get; set; }
            public Geo geo { get; set; }
            public string geoInfoStr { get; set; }
            public Geoinfo1 geoInfo { get; set; }
            public Site site { get; set; }
            public bool isUserSignedIn { get; set; }
            public string hvid { get; set; }
            public bool shouldHydrate { get; set; }
            public bool consentCheckingEnabled { get; set; }
            public bool isCbr { get; set; }
            public string referer { get; set; }
            public string logcmd { get; set; }
            public string jdv { get; set; }
        }

        public class Data
        {
            public Pagecontentdata pageContentData { get; set; }
            public string pageName { get; set; }
            public string intlPolyfill { get; set; }
            public string es6Polyfill { get; set; }
            public Stores stores { get; set; }
        }

        public class Pagecontentdata
        {
            public string spaceId { get; set; }
        }

        public class Stores
        {
            public object[] order { get; set; }
            public Data1 data { get; set; }
        }

        public class Data1
        {
            public Pagestore PageStore { get; set; }
            public Currentuserstore CurrentUserStore { get; set; }
            public Consentsstore ConsentsStore { get; set; }
            public Viewphotopagestore ViewPhotoPageStore { get; set; }
            public Productdatastore ProductDataStore { get; set; }
            public Productvariationsstore ProductVariationsStore { get; set; }
            public Productreviewsstore ProductReviewsStore { get; set; }
            public Viewmasterstore ViewMasterStore { get; set; }
            public Spacestore SpaceStore { get; set; }
            public Viewproductrecommendationstore ViewProductRecommendationStore { get; set; }
            public Viewproductbreadcrumbstore ViewProductBreadcrumbStore { get; set; }
            public Multisellerstore MultiSellerStore { get; set; }
            public Collectionsstore CollectionsStore { get; set; }
            public Topiclinksstore TopicLinksStore { get; set; }
            public Productinphotosstore ProductInPhotosStore { get; set; }
            public Productnotificationstore ProductNotificationStore { get; set; }
            public Spaceshorttitlesstore SpaceShortTitlesStore { get; set; }
            public Viewspacebuzzliststore ViewSpaceBuzzListStore { get; set; }
            public Spacequestionstore SpaceQuestionStore { get; set; }
            public Questionstore QuestionStore { get; set; }
            public Productreviewreminderdatastore ProductReviewReminderDataStore { get; set; }
            public Imagestore ImageStore { get; set; }
            public Userstore UserStore { get; set; }
            public Professionalstore ProfessionalStore { get; set; }
            public Productinfostore ProductInfoStore { get; set; }
            public Vendorlistingsstore VendorListingsStore { get; set; }
            public Headerstore HeaderStore { get; set; }
            public Headerbannerstore HeaderBannerStore { get; set; }
            public Footerstore FooterStore { get; set; }
            public Areasstore AreasStore { get; set; }
            public Cartstore CartStore { get; set; }
            public C2lightboxstore C2LightboxStore { get; set; }
            public Spacelabelsstore SpaceLabelsStore { get; set; }
            public Questionanswermapstore QuestionAnswerMapStore { get; set; }
            public Answerstore AnswerStore { get; set; }
            public Metadatastore MetaDataStore { get; set; }
            public Admintoolsstore AdminToolsStore { get; set; }
            
    }

        public class Pagestore
        {
            public Data2 data { get; set; }
        }

        public class Data2
        {
            public string commandName { get; set; }
            public Pagedescriptor pageDescriptor { get; set; }
            public string commandNameAlias { get; set; }
            public bool shouldTrackVisitor { get; set; }
            public string csrfToken { get; set; }
            public bool isMobileSplashEnabled { get; set; }
            public string pageNamespace { get; set; }
            public Onlinemarketingpagetags onlineMarketingPageTags { get; set; }
            public string metaTitle { get; set; }
            public string pageTitle { get; set; }
            public string metaDescription { get; set; }
            public string pageDescriptionFull { get; set; }
            public string canonicalUrl { get; set; }
            public string internalUrlPath { get; set; }
            public string shareUrl { get; set; }
            public string appUrl { get; set; }
            public Htmltag[] htmlTags { get; set; }
            public int robotsValue { get; set; }
            public object[] hrefLangHtmlTags { get; set; }
            public string mobileSplashTitle { get; set; }
            public Siteswitchurls siteSwitchUrls { get; set; }
            public string[] pageAdditionalStyleSheets { get; set; }
            public string[] pageHeaderScripts { get; set; }
            public string[] pageFooterScripts { get; set; }
            public string requestId { get; set; }
            public string pageName { get; set; }
        }

        public class Pagedescriptor
        {
            public string pageCommand { get; set; }
            public string pageClass { get; set; }
            public string contentDescriptor { get; set; }
        }

        public class Onlinemarketingpagetags
        {
            public string page_type { get; set; }
            public string product_topic { get; set; }
            public string product_price { get; set; }
        }

        public class Siteswitchurls
        {
            public string _101 { get; set; }
            public string _102 { get; set; }
            public string _103 { get; set; }
            public string _104 { get; set; }
            public string _105 { get; set; }
            public string _106 { get; set; }
            public string _107 { get; set; }
            public string _108 { get; set; }
            public string _109 { get; set; }
            public string _110 { get; set; }
            public string _113 { get; set; }
            public string _114 { get; set; }
            public string _115 { get; set; }
            public string _116 { get; set; }
            public string _117 { get; set; }
        }

        public class Htmltag
        {
            public string tagName { get; set; }
            public Attributes attributes { get; set; }
            public string contents { get; set; }
        }

        public class Attributes
        {
            public string rel { get; set; }
            public string href { get; set; }
            public string type { get; set; }
            public string sizes { get; set; }
            public string property { get; set; }
            public string content { get; set; }
        }

        public class Currentuserstore
        {
            public Data3 data { get; set; }
        }

        public class Data3
        {
            public bool loggedIn { get; set; }
            public Abtestseed abTestSeed { get; set; }
            public Geoinfo geoInfo { get; set; }
            public Token token { get; set; }
            public Preferences preferences { get; set; }
            public Sessionpreferences sessionPreferences { get; set; }
            public Visitorproperties visitorProperties { get; set; }
            public Userproperties userProperties { get; set; }
            public Observedvisitorproperties observedVisitorProperties { get; set; }
            public Preferredgeosite preferredGeoSite { get; set; }
        }

        public class Abtestseed
        {
            public string userIdHash { get; set; }
            public string ipHash { get; set; }
            public string visitorIdHash { get; set; }
            public string idfaHash { get; set; }
            public string urlHash { get; set; }
            public string objectIdHash { get; set; }
            public string objectId { get; set; }
        }

        public class Geoinfo
        {
            public string country { get; set; }
            public string region { get; set; }
            public string postalCode { get; set; }
            public string city { get; set; }
            public string addr { get; set; }
        }

        public class Token
        {
            public int userId { get; set; }
            public string visitorId { get; set; }
            public string userName { get; set; }
        }

        public class Preferences
        {
        }

        public class Sessionpreferences
        {
        }

        public class Visitorproperties
        {
            public string dGenFil { get; set; }
            public string dsGenFil { get; set; }
            public string pdGenFil { get; set; }
            public string pdsGenFil { get; set; }
            public string allFilterHasClosed { get; set; }
            public string vanityFinderComplete { get; set; }
            public string postVanityFinderTipShown { get; set; }
            public string postSignupHouseId { get; set; }
            public string closeableBanner { get; set; }
            public string cookieBanner { get; set; }
            public string PagesSeen { get; set; }
            public string mp { get; set; }
            public string preselect_info_popup_has_shown { get; set; }
            public string optOutSites { get; set; }
            public string cobrand { get; set; }
            public string extension_upsell_displayed { get; set; }
            public string pro_perception_banner_dismissed { get; set; }
        }

        public class Userproperties
        {
        }

        public class Observedvisitorproperties
        {
        }

        public class Preferredgeosite
        {
            public string ccTLD { get; set; }
            public string domain { get; set; }
            public string locale { get; set; }
            public string countryCode { get; set; }
            public string countryNativeName { get; set; }
            public string timeZone { get; set; }
            public string siteId { get; set; }
            public string localeId { get; set; }
            public string seoLang { get; set; }
        }

        public class Consentsstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data4 data { get; set; }
        }

        public class Data4
        {
            public bool isPerformingRequest { get; set; }
            public bool visitorBannerEnabled { get; set; }
            public string vct { get; set; }
            public int saf { get; set; }
            public object[] mc { get; set; }
        }

        public class Viewphotopagestore
        {
            public Data5 data { get; set; }
        }

        public class Data5
        {
            public int id { get; set; }
        }

    public class Productdatastore
    {
        public string name { get; set; }
        public object[] prereqs { get; set; }
        public JObject data { get; set; }
    }


    //public class Data6
    //    {
    //        public _19348270 _19348270 { get; set; }
    //        public bool hasAllData { get; set; }
    //        public int currentSpaceId { get; set; }
    //    }

        public class ProductID
    {
            public string title { get; set; }
            public string description { get; set; }
            public Productspec productSpec { get; set; }
            public int preferredVendorListingId { get; set; }
            public Productbadges productBadges { get; set; }
            public object[] productDocuments { get; set; }
            public int productId { get; set; }
            public string[] imageIds { get; set; }
            public int siteId { get; set; }
            public Selectedvendorlisting selectedVendorListing { get; set; }
        }

    public class Productspec
    {
        public JObject productSpecItems { get; set; }
        public string[] keyList { get; set; }
    }


    public class Productspecitems
    {
        public One one { get; set; }
        public _2 _2 { get; set; }
        public _3 _3 { get; set; }
        public _4 _4 { get; set; }
        public _5 _5 { get; set; }
        public _6 _6 { get; set; }
        public _7 _7 { get; set; }
        public _8 _8 { get; set; }
        public _9 _9 { get; set; }
        public _10 _10 { get; set; }
        public _11_ _11 { get; set; }
    }
    public class Specs
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class One
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class _2
    {
        public string name { get; set; }
        public string value { get; set; }
        public string url { get; set; }
        public bool isColorLink { get; set; }
    }

    public class _3
    {
        public string name { get; set; }
        public string value { get; set; }
    }
    public class _4
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class _5
    {
        public string name { get; set; }
        public string value { get; set; }
    }
    public class _6
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class _7
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class _8
    {
        public string name { get; set; }
        public string value { get; set; }
        public string url { get; set; }
    }

    public class _9
    {
        public string name { get; set; }
        public string value { get; set; }
        public string url { get; set; }
    }

    public class _10
    {
        public string name { get; set; }
        public string value { get; set; }
        public string url { get; set; }
        public bool isColorLink { get; set; }
    }
    public class _11_
    {
        public string name { get; set; }
        public string value { get; set; }
    }


    public class Productbadges
        {
            public bool isBestSeller { get; set; }
            public bool isExclusive { get; set; }
        }

        public class Selectedvendorlisting
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price price { get; set; }
            public int quantity { get; set; }
            public bool isBuyable { get; set; }
            public bool isAvailable { get; set; }
            public bool isMPListing { get; set; }
            public bool isActiveMPListing { get; set; }
            public bool isPending { get; set; }
            public bool isParent { get; set; }
            public bool isBulkItem { get; set; }
            public bool showPriceMarkdown { get; set; }
            public bool isDirectVendor { get; set; }
            public bool isFreeShipping { get; set; }
            public bool prop65Disclosure { get; set; }
            public int leadTime { get; set; }
            public int leadTimeMax { get; set; }
            public int shipCostCurbside { get; set; }
            public int shipCostInside { get; set; }
            public string leadTimeString { get; set; }
            public string shippingCharge { get; set; }
            public string dimensions { get; set; }
            public string weight { get; set; }
            public bool hasActivePromoCampaign { get; set; }
            public bool isTradePrice { get; set; }
            public bool isTradeExclusive { get; set; }
            public string deliveryTimeString { get; set; }
            public Vendorlistingprices vendorListingPrices { get; set; }
            public bool showPhone { get; set; }
            public string preSalePhoneHourMessage { get; set; }
            public int productId { get; set; }
            public bool isDiscontinued { get; set; }
            public string marginColor { get; set; }
            public string marginNumber { get; set; }
            public bool isEligibleForFreeShipping { get; set; }
            public string freeShippingMinimum { get; set; }
            public bool hasValidTradePrice { get; set; }
            public bool useShippingCalculator { get; set; }
            public bool isReturnable { get; set; }
            public bool shouldHideTradeExclusive { get; set; }
            public string browseVendorProductsUrl { get; set; }
        }

        public class Price
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Vendorlistingprices
        {
            public Price1 price { get; set; }
            public Finalprice finalPrice { get; set; }
            public Baseprice basePrice { get; set; }
            public Msrp msrp { get; set; }
            public string multiPricingAdmin { get; set; }
            public string basePriceType { get; set; }
        }

        public class Price1
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Baseprice
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Msrp
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Productvariationsstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public JObject data { get; set; }
        }

        //public class Data7
        //{
        //    public _193482701 _19348270 { get; set; }
        //}

        public class ProductOptions
    {
            public JObject variationProducts { get; set; }
            public Currentvariations currentVariations { get; set; }
            public Variationsmap variationsMap { get; set; }
        }

        //public class Variationproducts
        //{
        //    public _19348267 _19348267 { get; set; }
        //    public _193482702 _19348270 { get; set; }
        //    public _19348272 _19348272 { get; set; }
        //    public _19348275 _19348275 { get; set; }
        //}

        public class DetailOptions
        {
            public int spaceId { get; set; }
            public string imageExternalId { get; set; }
            public int quantity { get; set; }
            public bool isAvailable { get; set; }
            public Price2 price { get; set; }
            public string url { get; set; }
        }

        public class Price2
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193482702
        {
            public int spaceId { get; set; }
            public string imageExternalId { get; set; }
            public int quantity { get; set; }
            public bool isAvailable { get; set; }
            public Price3 price { get; set; }
            public string url { get; set; }
        }

        public class Price3
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _19348272
        {
            public int spaceId { get; set; }
            public string imageExternalId { get; set; }
            public int quantity { get; set; }
            public bool isAvailable { get; set; }
            public Price4 price { get; set; }
            public string url { get; set; }
        }

        public class Price4
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _19348275
        {
            public int spaceId { get; set; }
            public string imageExternalId { get; set; }
            public int quantity { get; set; }
            public bool isAvailable { get; set; }
            public Price5 price { get; set; }
            public string url { get; set; }
        }

        public class Price5
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Currentvariations
        {
            public string c { get; set; }
        }

        public class Variationsmap
        {
            public C c { get; set; }
        }

        public class C
        {
            public Bronze Bronze { get; set; }
            public Chrome Chrome { get; set; }
            public Gold Gold { get; set; }
            public NickelMatte NickelMatte { get; set; }
        }

        public class Bronze
        {
            public int spaceId { get; set; }
            public bool isExactMatch { get; set; }
        }

        public class Chrome
        {
            public int spaceId { get; set; }
            public bool isExactMatch { get; set; }
        }

        public class Gold
        {
            public int spaceId { get; set; }
            public bool isExactMatch { get; set; }
        }

        public class NickelMatte
        {
            public int spaceId { get; set; }
            public bool isExactMatch { get; set; }
        }

        public class Productreviewsstore
        {
            public object[] prereqs { get; set; }
            public Data8 data { get; set; }
        }

        public class Data8
        {
            public Status status { get; set; }
            public int subjectId { get; set; }
            public bool isAdmin { get; set; }
            public bool isExternalReviewsEnabled { get; set; }
            public int approvedReviewCount { get; set; }
            public int displayReviewCount { get; set; }
            public int rawAverageRate { get; set; }
            public float averageRateDisplay { get; set; }
            public int[] productReviewIds { get; set; }
            public Productreviews productReviews { get; set; }
            public Countperrating countPerRating { get; set; }
            public bool hasFetched { get; set; }
        }

        public class Status
        {
            public int errorCode { get; set; }
            public Serverversion serverVersion { get; set; }
        }

        public class Serverversion
        {
            public int baseVersion { get; set; }
            public int serviceVersion { get; set; }
        }

        public class Productreviews
        {
            public _84690 _84690 { get; set; }
            public _156884 _156884 { get; set; }
            public _170362 _170362 { get; set; }
            public _182951 _182951 { get; set; }
            public _206046 _206046 { get; set; }
            public _254245 _254245 { get; set; }
            public _290738 _290738 { get; set; }
            public _306858 _306858 { get; set; }
            public _403316 _403316 { get; set; }
            public _410536 _410536 { get; set; }
            public _428756 _428756 { get; set; }
            public _502456 _502456 { get; set; }
            public _590154 _590154 { get; set; }
        }

        public class _84690
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _156884
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _170362
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _182951
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _206046
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _254245
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _290738
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _306858
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _403316
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _410536
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _428756
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _502456
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class _590154
        {
            public int productReviewId { get; set; }
            public int rating { get; set; }
            public string title { get; set; }
            public string comment { get; set; }
            public int numberOfLikes { get; set; }
            public int numberOfDislikes { get; set; }
            public int houseId { get; set; }
            public int userId { get; set; }
            public int status { get; set; }
            public int flags { get; set; }
            public int created { get; set; }
            public int modified { get; set; }
            public object[] imageExternalIds { get; set; }
        }

        public class Countperrating
        {
            public int _1 { get; set; }
            public int _2 { get; set; }
            public int _3 { get; set; }
            public int _4 { get; set; }
            public int _5 { get; set; }
        }

        public class Viewmasterstore
        {
            public Data9 data { get; set; }
        }

        public class Data9
        {
        }

        public class Spacestore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data10 data { get; set; }
        }

        public class Data10
        {
            public _4159134 _4159134 { get; set; }
            public _6017053 _6017053 { get; set; }
            public _11379561 _11379561 { get; set; }
            public _11383626 _11383626 { get; set; }
            public _19250979 _19250979 { get; set; }
            public _19348167 _19348167 { get; set; }
            public _19348169 _19348169 { get; set; }
            public _19348171 _19348171 { get; set; }
            public _19348174 _19348174 { get; set; }
            public _19348185 _19348185 { get; set; }
            public _193482671 _19348267 { get; set; }
            public _193482703 _19348270 { get; set; }
            public _19348271 _19348271 { get; set; }
            public _19348285 _19348285 { get; set; }
            public _19348286 _19348286 { get; set; }
            public _19348292 _19348292 { get; set; }
            public _22409631 _22409631 { get; set; }
            public _22409632 _22409632 { get; set; }
            public _28109345 _28109345 { get; set; }
            public _31344799 _31344799 { get; set; }
            public _36672632 _36672632 { get; set; }
            public _44887982 _44887982 { get; set; }
            public _47292010 _47292010 { get; set; }
            public _50305188 _50305188 { get; set; }
            public _50360563 _50360563 { get; set; }
            public _50360572 _50360572 { get; set; }
            public _50360577 _50360577 { get; set; }
            public _51859951 _51859951 { get; set; }
            public _51859957 _51859957 { get; set; }
            public _51859969 _51859969 { get; set; }
            public _52575663 _52575663 { get; set; }
            public _52821602 _52821602 { get; set; }
            public _52860326 _52860326 { get; set; }
            public _53191366 _53191366 { get; set; }
            public _53678422 _53678422 { get; set; }
            public _54086515 _54086515 { get; set; }
            public _58325481 _58325481 { get; set; }
            public _60497669 _60497669 { get; set; }
            public _61331293 _61331293 { get; set; }
            public _68234411 _68234411 { get; set; }
            public _72876919 _72876919 { get; set; }
            public _87183589 _87183589 { get; set; }
            public _87742465 _87742465 { get; set; }
            public _91003478 _91003478 { get; set; }
            public _91072576 _91072576 { get; set; }
            public _91856335 _91856335 { get; set; }
            public _95541975 _95541975 { get; set; }
            public _95791828 _95791828 { get; set; }
            public _95791829 _95791829 { get; set; }
            public _95791831 _95791831 { get; set; }
            public _95791832 _95791832 { get; set; }
            public _96319351 _96319351 { get; set; }
            public _97061228 _97061228 { get; set; }
            public _97086130 _97086130 { get; set; }
            public _97347759 _97347759 { get; set; }
            public _102015792 _102015792 { get; set; }
            public _102087775 _102087775 { get; set; }
            public _102324867 _102324867 { get; set; }
            public _106610652 _106610652 { get; set; }
            public _109128814 _109128814 { get; set; }
            public _112007460 _112007460 { get; set; }
            public _115131308 _115131308 { get; set; }
            public _127155263 _127155263 { get; set; }
        }

        public class _4159134
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _6017053
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _11379561
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _11383626
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19250979
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348167
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348169
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348171
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348174
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348185
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _193482671
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _193482703
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public Metroarea metroArea { get; set; }
            public string recentBuzz { get; set; }
            public int recentBuzzUserId { get; set; }
            public string recentBuzzCreated { get; set; }
            public int buzzCount { get; set; }
            public string buzzCountString { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool isBookmarkletUpload { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public bool showBeforeTag { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public int questionCount { get; set; }
            public string questionCountString { get; set; }
            public string[] imageIds { get; set; }
        }

        public class Metroarea
        {
            public int id { get; set; }
        }

        public class _19348271
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348285
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348286
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _19348292
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _22409631
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _22409632
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _28109345
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _31344799
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _36672632
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _44887982
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _47292010
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _50305188
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _50360563
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _50360572
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _50360577
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _51859951
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _51859957
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _51859969
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _52575663
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _52821602
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _52860326
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _53191366
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _53678422
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _54086515
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _58325481
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _60497669
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _61331293
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _68234411
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _72876919
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _87183589
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _87742465
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _91003478
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _91072576
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _91856335
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _95541975
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _95791828
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _95791829
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _95791831
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _95791832
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _96319351
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _97061228
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _97086130
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _97347759
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _102015792
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _102087775
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _102324867
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _106610652
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _109128814
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _112007460
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _115131308
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _127155263
        {
            public int categoryId { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string[] imageIds { get; set; }
        }

        public class Viewproductrecommendationstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data11 data { get; set; }
        }

        public class Data11
        {
            public int[] _1 { get; set; }
            public int[] _2 { get; set; }
            public int[] _3 { get; set; }
            public int[] _4 { get; set; }
            public int[] _6 { get; set; }
            public Sponsoredproducts sponsoredProducts { get; set; }
        }

        public class Sponsoredproducts
        {
            public object[] ads { get; set; }
            public object[] trackingPixels { get; set; }
        }

        public class Viewproductbreadcrumbstore
        {
            public Data12 data { get; set; }
        }

        public class Data12
        {
            public Breadcrumbs breadcrumbs { get; set; }
        }

        public class Breadcrumbs
        {
            public string filterName { get; set; }
            public string header { get; set; }
            public Option[] options { get; set; }
            public bool collapsed { get; set; }
            public string expandOptionsLabel { get; set; }
            public int defaultFilterType { get; set; }
        }

        public class Option
        {
            public string label { get; set; }
            public string url { get; set; }
            public string objId { get; set; }
            public string compId { get; set; }
        }

        public class Multisellerstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data13 data { get; set; }
        }

        public class Data13
        {
            public object[] _19348270 { get; set; }
        }

        public class Collectionsstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data14 data { get; set; }
        }

        public class Data14
        {
        }

        public class Topiclinksstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data15 data { get; set; }
        }

        public class Data15
        {
            public _0 _0 { get; set; }
            public _60170531 _6017053 { get; set; }
            public _193482921 _19348292 { get; set; }
            public _224096321 _22409632 { get; set; }
            public _525756631 _52575663 { get; set; }
            public _877424651 _87742465 { get; set; }
            public _1066106521 _106610652 { get; set; }
        }

        public class _0
        {
            public string url { get; set; }
        }

        public class _60170531
        {
            public string title { get; set; }
            public string url { get; set; }
        }

        public class _193482921
        {
            public string title { get; set; }
            public string url { get; set; }
        }

        public class _224096321
        {
            public string title { get; set; }
            public string url { get; set; }
        }

        public class _525756631
        {
            public string title { get; set; }
            public string url { get; set; }
        }

        public class _877424651
        {
            public string title { get; set; }
            public string url { get; set; }
        }

        public class _1066106521
        {
            public string title { get; set; }
            public string url { get; set; }
        }

        public class Productinphotosstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data16 data { get; set; }
        }

        public class Data16
        {
            public object[] spaceIds { get; set; }
        }

        public class Productnotificationstore
        {
            public object[] prereqs { get; set; }
            public Data17 data { get; set; }
        }

        public class Data17
        {
            public Status1 status { get; set; }
        }

        public class Status1
        {
            public int errorCode { get; set; }
            public Serverversion1 serverVersion { get; set; }
        }

        public class Serverversion1
        {
            public int baseVersion { get; set; }
            public int serviceVersion { get; set; }
        }

        public class Spaceshorttitlesstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data18 data { get; set; }
        }

        public class Data18
        {
        }

        public class Viewspacebuzzliststore
        {
            public Data19 data { get; set; }
        }

        public class Data19
        {
            public object[] featuredGallerybuzzes { get; set; }
            public Usergallerybuzze[] userGallerybuzzes { get; set; }
        }

        public class Usergallerybuzze
        {
            public int galleryId { get; set; }
            public int buzzUserId { get; set; }
            public string galleryTitle { get; set; }
            public string buzzComments { get; set; }
            public string buzzCreated { get; set; }
        }

        public class Spacequestionstore
        {
            public Data20 data { get; set; }
        }

        public class Data20
        {
            public Spacequestions spaceQuestions { get; set; }
            public bool quotaReached { get; set; }
        }

        public class Spacequestions
        {
            public int[] _19348270 { get; set; }
        }

        public class Questionstore
        {
            public Data21 data { get; set; }
        }

        public class Data21
        {
            public _4605854 _4605854 { get; set; }
            public _4792626 _4792626 { get; set; }
            public _5252975 _5252975 { get; set; }
        }

        public class _4605854
        {
            public int id { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public string userId { get; set; }
            public string title { get; set; }
            public int typeId { get; set; }
            public int topicId { get; set; }
            public string body { get; set; }
            public int spaceId { get; set; }
            public int proxySpaceId { get; set; }
            public int galleryId { get; set; }
            public string thumbImageId { get; set; }
            public bool isolated { get; set; }
            public int numberOfAnswers { get; set; }
            public int numberOfLikes { get; set; }
            public int lastAnsweredByUserId { get; set; }
            public bool allowToVote { get; set; }
            public int totalVotes { get; set; }
            public Attachments attachments { get; set; }
            public int status { get; set; }
            public object[] tagIds { get; set; }
            public object[] lastAnsweredByUserIds { get; set; }
            public string lastAnsweredDate { get; set; }
            public string htmlBody { get; set; }
            public string urlSlug { get; set; }
            public string topicTitle { get; set; }
        }

        public class Attachments
        {
        }

        public class _4792626
        {
            public int id { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public string userId { get; set; }
            public string title { get; set; }
            public int typeId { get; set; }
            public int topicId { get; set; }
            public string body { get; set; }
            public int spaceId { get; set; }
            public int proxySpaceId { get; set; }
            public int galleryId { get; set; }
            public string thumbImageId { get; set; }
            public bool isolated { get; set; }
            public int numberOfAnswers { get; set; }
            public int numberOfLikes { get; set; }
            public int lastAnsweredByUserId { get; set; }
            public bool allowToVote { get; set; }
            public int totalVotes { get; set; }
            public Attachments1 attachments { get; set; }
            public int status { get; set; }
            public object[] tagIds { get; set; }
            public object[] lastAnsweredByUserIds { get; set; }
            public string lastAnsweredDate { get; set; }
            public string htmlBody { get; set; }
            public string urlSlug { get; set; }
            public string topicTitle { get; set; }
        }

        public class Attachments1
        {
        }

        public class _5252975
        {
            public int id { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public string userId { get; set; }
            public string title { get; set; }
            public int typeId { get; set; }
            public int topicId { get; set; }
            public string body { get; set; }
            public int spaceId { get; set; }
            public int proxySpaceId { get; set; }
            public int galleryId { get; set; }
            public string thumbImageId { get; set; }
            public bool isolated { get; set; }
            public int numberOfAnswers { get; set; }
            public int numberOfLikes { get; set; }
            public int lastAnsweredByUserId { get; set; }
            public bool allowToVote { get; set; }
            public int totalVotes { get; set; }
            public Attachments2 attachments { get; set; }
            public int status { get; set; }
            public object[] tagIds { get; set; }
            public object[] lastAnsweredByUserIds { get; set; }
            public string lastAnsweredDate { get; set; }
            public string htmlBody { get; set; }
            public string urlSlug { get; set; }
            public string topicTitle { get; set; }
        }

        public class Attachments2
        {
        }

        public class Productreviewreminderdatastore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data22 data { get; set; }
        }

        public class Data22
        {
        }

        public class Imagestore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data23 data { get; set; }
        }

        public class Data23
        {
            public Bfc1a93404590073 bfc1a93404590073 { get; set; }
            public _3671Edfa047cee4b _3671edfa047cee4b { get; set; }
            public _22F38e26035341ef _22f38e26035341ef { get; set; }
            public _09F30da10771ccf6 _09f30da10771ccf6 { get; set; }
            public _75A3764c082f9dbe _75a3764c082f9dbe { get; set; }
            public _87516Ee40458ff0f _87516ee40458ff0f { get; set; }
            public B461df8404590047 b461df8404590047 { get; set; }
            public Ada1398a04590091 ada1398a04590091 { get; set; }
            public _3B911ca0096fa7c7 _3b911ca0096fa7c7 { get; set; }
            public Efb1d3c80459027e efb1d3c80459027e { get; set; }
            public _9D21063407053139 _9d21063407053139 { get; set; }
            public _47C1923006e0693c _47c1923006e0693c { get; set; }
            public A94140bb09695153 a94140bb09695153 { get; set; }
            public _95418Adc06fe87ab _95418adc06fe87ab { get; set; }
            public Ac9162230ab00dac ac9162230ab00dac { get; set; }
            public _4191D087096faa10 _4191d087096faa10 { get; set; }
            public _56A14e1e0b116441 _56a14e1e0b116441 { get; set; }
            public Ea61394f0473a304 ea61394f0473a304 { get; set; }
            public _1Ac1e01e0a9587e3 _1ac1e01e0a9587e3 { get; set; }
            public _19F1a9560473a7d9 _19f1a9560473a7d9 { get; set; }
            public _7Ab1f5190956916c _7ab1f5190956916c { get; set; }
            public _5481F01407e43487 _5481f01407e43487 { get; set; }
            public _95E1594b0963423f _95e1594b0963423f { get; set; }
            public _1Ce1be5604b9746e _1ce1be5604b9746e { get; set; }
            public D1d151710ad86e08 d1d151710ad86e08 { get; set; }
            public _11C1c674096fa7f9 _11c1c674096fa7f9 { get; set; }
            public _9D312021066b0c06 _9d312021066b0c06 { get; set; }
            public _83611186024Cae3f _83611186024cae3f { get; set; }
            public Fb11d5bb07100fbb fb11d5bb07100fbb { get; set; }
            public _38D1671a01a938fa _38d1671a01a938fa { get; set; }
            public _95D116810807f2c0 _95d116810807f2c0 { get; set; }
            public _9141017E09c150ca _9141017e09c150ca { get; set; }
            public Ae11ec0a0980b18d ae11ec0a0980b18d { get; set; }
            public Ed01e59706e0693f ed01e59706e0693f { get; set; }
            public Ba518cdd07309f0e ba518cdd07309f0e { get; set; }
            public Bad1a0a50458fc68 bad1a0a50458fc68 { get; set; }
            public D9a1f0710459001b d9a1f0710459001b { get; set; }
            public _1661E2ea0a737ee5 _1661e2ea0a737ee5 { get; set; }
            public D981bc8d044e6b38 d981bc8d044e6b38 { get; set; }
            public _8Df17e3e08c702ce _8df17e3e08c702ce { get; set; }
            public _73E15b2104b97463 _73e15b2104b97463 { get; set; }
            public _02C16ed808de7746 _02c16ed808de7746 { get; set; }
            public B501cf46055a66be b501cf46055a66be { get; set; }
            public _4De13d6207053140 _4de13d6207053140 { get; set; }
            public Da91854109efcc34 da91854109efcc34 { get; set; }
            public _80A1e96f05afd86b _80a1e96f05afd86b { get; set; }
            public _66511562034F24ec _66511562034f24ec { get; set; }
            public C9318bbe045933ce c9318bbe045933ce { get; set; }
            public _95116Ac00a3bfdc4 _95116ac00a3bfdc4 { get; set; }
            public Ad1132c708fc5e1b ad1132c708fc5e1b { get; set; }
            public _0E01ea90096fa82b _0e01ea90096fa82b { get; set; }
            public _6Ff10bec0473a29b _6ff10bec0473a29b { get; set; }
            public F111ec0c0720efc8 f111ec0c0720efc8 { get; set; }
            public _66811595072Abe4b _66811595072abe4b { get; set; }
            public Ea810d6c052ee6ee ea810d6c052ee6ee { get; set; }
            public _61715B4e0357e919 _61715b4e0357e919 { get; set; }
            public Cd710548070abc0a cd710548070abc0a { get; set; }
            public Dfe1a5f909bacb2d dfe1a5f909bacb2d { get; set; }
            public _889170D9090addc3 _889170d9090addc3 { get; set; }
            public Be411b1807053136 be411b1807053136 { get; set; }
            public F911e99403d962a3 f911e99403d962a3 { get; set; }
            public Ac31415409a85368 ac31415409a85368 { get; set; }
            public _9561B524070fb1b2 _9561b524070fb1b2 { get; set; }
            public _239107E805d50322 _239107e805d50322 { get; set; }
            public _6691E18706df6937 _6691e18706df6937 { get; set; }
            public _03914C690458fdb2 _03914c690458fdb2 { get; set; }
            public _12816Ecb04590295 _12816ecb04590295 { get; set; }
            public Cea1f22807744232 cea1f22807744232 { get; set; }
            public _32A11c1c09a85367 _32a11c1c09a85367 { get; set; }
        }

        public class Bfc1a93404590073
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _3671Edfa047cee4b
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _22F38e26035341ef
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _09F30da10771ccf6
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _75A3764c082f9dbe
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _87516Ee40458ff0f
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class B461df8404590047
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ada1398a04590091
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _3B911ca0096fa7c7
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Efb1d3c80459027e
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _9D21063407053139
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _47C1923006e0693c
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class A94140bb09695153
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _95418Adc06fe87ab
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ac9162230ab00dac
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _4191D087096faa10
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _56A14e1e0b116441
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ea61394f0473a304
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _1Ac1e01e0a9587e3
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _19F1a9560473a7d9
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _7Ab1f5190956916c
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _5481F01407e43487
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _95E1594b0963423f
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _1Ce1be5604b9746e
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class D1d151710ad86e08
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _11C1c674096fa7f9
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _9D312021066b0c06
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _83611186024Cae3f
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Fb11d5bb07100fbb
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _38D1671a01a938fa
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _95D116810807f2c0
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _9141017E09c150ca
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ae11ec0a0980b18d
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ed01e59706e0693f
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ba518cdd07309f0e
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Bad1a0a50458fc68
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class D9a1f0710459001b
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _1661E2ea0a737ee5
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class D981bc8d044e6b38
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _8Df17e3e08c702ce
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _73E15b2104b97463
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _02C16ed808de7746
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class B501cf46055a66be
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _4De13d6207053140
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Da91854109efcc34
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _80A1e96f05afd86b
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _66511562034F24ec
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class C9318bbe045933ce
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _95116Ac00a3bfdc4
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ad1132c708fc5e1b
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _0E01ea90096fa82b
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _6Ff10bec0473a29b
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class F111ec0c0720efc8
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _66811595072Abe4b
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ea810d6c052ee6ee
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _61715B4e0357e919
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Cd710548070abc0a
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Dfe1a5f909bacb2d
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _889170D9090addc3
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Be411b1807053136
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class F911e99403d962a3
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Ac31415409a85368
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _9561B524070fb1b2
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _239107E805d50322
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _6691E18706df6937
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _03914C690458fdb2
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _12816Ecb04590295
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Cea1f22807744232
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class _32A11c1c09a85367
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
            public int status { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int whiteBg { get; set; }
            public int hires { get; set; }
            public int sourceType { get; set; }
            public int uploaderId { get; set; }
            public int originalType { get; set; }
            public int originalWidth { get; set; }
            public int originalHeight { get; set; }
        }

        public class Userstore
        {
            public Data24 data { get; set; }
        }

        public class Data24
        {
            public _617623 _617623 { get; set; }
            public _945398 _945398 { get; set; }
            public _1254381 _1254381 { get; set; }
            public _1611250 _1611250 { get; set; }
            public _2360458 _2360458 { get; set; }
            public _6433541 _6433541 { get; set; }
            public _16245589 _16245589 { get; set; }
            public _16393641 _16393641 { get; set; }
            public _16655190 _16655190 { get; set; }
            public _17036727 _17036727 { get; set; }
            public _18230508 _18230508 { get; set; }
            public _21242569 _21242569 { get; set; }
            public _29172983 _29172983 { get; set; }
            public _29524762 _29524762 { get; set; }
            public _38936652 _38936652 { get; set; }
            public _39261359 _39261359 { get; set; }
            public _39620674 _39620674 { get; set; }
            public _40502245 _40502245 { get; set; }
            public _41421745 _41421745 { get; set; }
            public _42594069 _42594069 { get; set; }
            public _43030357 _43030357 { get; set; }
        }

        public class _617623
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles
        {
        }

        public class _945398
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles1 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles1
        {
        }

        public class _1254381
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles2 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles2
        {
        }

        public class _1611250
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Tradeuser tradeUser { get; set; }
            public Roles3 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Tradeuser
        {
            public int type { get; set; }
            public int status { get; set; }
            public int proType { get; set; }
        }

        public class Roles3
        {
        }

        public class _2360458
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles4 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles4
        {
        }

        public class _6433541
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles5 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles5
        {
        }

        public class _16245589
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles6 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles6
        {
        }

        public class _16393641
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles7 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles7
        {
        }

        public class _16655190
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles8 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles8
        {
        }

        public class _17036727
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles9 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles9
        {
        }

        public class _18230508
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles10 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles10
        {
        }

        public class _21242569
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles11 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles11
        {
        }

        public class _29172983
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles12 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles12
        {
        }

        public class _29524762
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles13 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles13
        {
        }

        public class _38936652
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles14 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles14
        {
        }

        public class _39261359
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles15 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles15
        {
        }

        public class _39620674
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles16 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles16
        {
        }

        public class _40502245
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles17 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles17
        {
        }

        public class _41421745
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles18 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles18
        {
        }

        public class _42594069
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles19 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles19
        {
        }

        public class _43030357
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public int proId { get; set; }
            public int status { get; set; }
            public int adminLevel { get; set; }
            public string displayName { get; set; }
            public bool isProfessional { get; set; }
            public string profileImageId { get; set; }
            public bool hasRealProfileImage { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isProxyUser { get; set; }
            public bool isTradePro { get; set; }
            public bool isVendor { get; set; }
            public bool isTradePromotionEnabled { get; set; }
            public Roles20 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles20
        {
        }

        public class Professionalstore
        {
            public Data25 data { get; set; }
        }

        public class Data25
        {
            public _166551901 _16655190 { get; set; }
        }

        public class _166551901
        {
            public int userId { get; set; }
            public int professionalId { get; set; }
            public int proType { get; set; }
            public int reviewRating { get; set; }
            public int numReviews { get; set; }
            public int profileCompleteness { get; set; }
            public string location { get; set; }
            public string zip { get; set; }
            public bool isProfessionalProfileCompleted { get; set; }
            public bool isDirectVendor { get; set; }
            public bool isMarketplaceVendor { get; set; }
            public bool isTopSeller { get; set; }
            public bool isSponsoredPPCVendor { get; set; }
            public bool isVerifiedManufacturer { get; set; }
            public int parentProId { get; set; }
            public Attributes1 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes1
        {
        }

        public class Productinfostore
        {
            public Data26 data { get; set; }
        }

        public class Data26
        {
            public _41591341 _4159134 { get; set; }
            public _60170532 _6017053 { get; set; }
            public _113795611 _11379561 { get; set; }
            public _113836261 _11383626 { get; set; }
            public _192509791 _19250979 { get; set; }
            public _193481671 _19348167 { get; set; }
            public _193481691 _19348169 { get; set; }
            public _193481711 _19348171 { get; set; }
            public _193481741 _19348174 { get; set; }
            public _193481851 _19348185 { get; set; }
            public _193482672 _19348267 { get; set; }
            public _193482704 _19348270 { get; set; }
            public _193482711 _19348271 { get; set; }
            public _193482851 _19348285 { get; set; }
            public _193482861 _19348286 { get; set; }
            public _193482922 _19348292 { get; set; }
            public _224096311 _22409631 { get; set; }
            public _224096322 _22409632 { get; set; }
            public _281093451 _28109345 { get; set; }
            public _313447991 _31344799 { get; set; }
            public _366726321 _36672632 { get; set; }
            public _448879821 _44887982 { get; set; }
            public _472920101 _47292010 { get; set; }
            public _503051881 _50305188 { get; set; }
            public _503605631 _50360563 { get; set; }
            public _503605721 _50360572 { get; set; }
            public _503605771 _50360577 { get; set; }
            public _518599511 _51859951 { get; set; }
            public _518599571 _51859957 { get; set; }
            public _518599691 _51859969 { get; set; }
            public _525756632 _52575663 { get; set; }
            public _528216021 _52821602 { get; set; }
            public _528603261 _52860326 { get; set; }
            public _531913661 _53191366 { get; set; }
            public _536784221 _53678422 { get; set; }
            public _540865151 _54086515 { get; set; }
            public _583254811 _58325481 { get; set; }
            public _604976691 _60497669 { get; set; }
            public _613312931 _61331293 { get; set; }
            public _682344111 _68234411 { get; set; }
            public _728769191 _72876919 { get; set; }
            public _871835891 _87183589 { get; set; }
            public _877424652 _87742465 { get; set; }
            public _910034781 _91003478 { get; set; }
            public _910725761 _91072576 { get; set; }
            public _918563351 _91856335 { get; set; }
            public _955419751 _95541975 { get; set; }
            public _957918281 _95791828 { get; set; }
            public _957918291 _95791829 { get; set; }
            public _957918311 _95791831 { get; set; }
            public _957918321 _95791832 { get; set; }
            public _963193511 _96319351 { get; set; }
            public _970612281 _97061228 { get; set; }
            public _970861301 _97086130 { get; set; }
            public _973477591 _97347759 { get; set; }
            public _1020157921 _102015792 { get; set; }
            public _1020877751 _102087775 { get; set; }
            public _1023248671 _102324867 { get; set; }
            public _1066106522 _106610652 { get; set; }
            public _1091288141 _109128814 { get; set; }
            public _1120074601 _112007460 { get; set; }
            public _1151313081 _115131308 { get; set; }
            public _1271552631 _127155263 { get; set; }
        }

        public class _41591341
        {
            public Baseprice1 basePrice { get; set; }
            public Finalprice1 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice1
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice1
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _60170532
        {
            public Baseprice2 basePrice { get; set; }
            public Finalprice2 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice2
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice2
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _113795611
        {
            public Baseprice3 basePrice { get; set; }
            public Finalprice3 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice3
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice3
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _113836261
        {
            public Baseprice4 basePrice { get; set; }
            public Finalprice4 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice4
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice4
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _192509791
        {
            public Baseprice5 basePrice { get; set; }
            public Finalprice5 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice5
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice5
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193481671
        {
            public Baseprice6 basePrice { get; set; }
            public Finalprice6 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice6
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice6
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193481691
        {
            public Baseprice7 basePrice { get; set; }
            public Finalprice7 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice7
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice7
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193481711
        {
            public Baseprice8 basePrice { get; set; }
            public Finalprice8 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice8
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice8
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193481741
        {
            public Baseprice9 basePrice { get; set; }
            public Finalprice9 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice9
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice9
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193481851
        {
            public Baseprice10 basePrice { get; set; }
            public Finalprice10 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice10
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice10
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193482672
        {
            public Baseprice11 basePrice { get; set; }
            public Finalprice11 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice11
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice11
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193482704
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice12 basePrice { get; set; }
            public Finalprice12 finalPrice { get; set; }
            public bool preferredOverride { get; set; }
            public bool isParent { get; set; }
            public bool hasVendorListing { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isAvailable { get; set; }
            public int activeListingCount { get; set; }
            public bool isVerified { get; set; }
            public bool isExclusive { get; set; }
            public int manufacturerId { get; set; }
            public string manufacturer { get; set; }
            public string dimensions { get; set; }
            public string weight { get; set; }
            public Productattributes productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice12
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice12
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Productattributes
        {
            public W w { get; set; }
            public D d { get; set; }
            public H h { get; set; }
            public C1 c { get; set; }
            public S s { get; set; }
            public Wt wt { get; set; }
            public M m { get; set; }
            public Ds ds { get; set; }
        }

        public class W
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C1
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt
        {
            public string name { get; set; }
        }

        public class M
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _193482711
        {
            public Baseprice13 basePrice { get; set; }
            public Finalprice13 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice13
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice13
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193482851
        {
            public Baseprice14 basePrice { get; set; }
            public Finalprice14 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice14
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice14
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193482861
        {
            public Baseprice15 basePrice { get; set; }
            public Finalprice15 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice15
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice15
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _193482922
        {
            public Baseprice16 basePrice { get; set; }
            public Finalprice16 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice16
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice16
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _224096311
        {
            public Baseprice17 basePrice { get; set; }
            public Finalprice17 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice17
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice17
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _224096322
        {
            public Baseprice18 basePrice { get; set; }
            public Finalprice18 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice18
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice18
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _281093451
        {
            public Baseprice19 basePrice { get; set; }
            public Finalprice19 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice19
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice19
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _313447991
        {
            public Baseprice20 basePrice { get; set; }
            public Finalprice20 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice20
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice20
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _366726321
        {
            public Baseprice21 basePrice { get; set; }
            public Finalprice21 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice21
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice21
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _448879821
        {
            public Baseprice22 basePrice { get; set; }
            public Finalprice22 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice22
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice22
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _472920101
        {
            public Baseprice23 basePrice { get; set; }
            public Finalprice23 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice23
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice23
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _503051881
        {
            public Baseprice24 basePrice { get; set; }
            public Finalprice24 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice24
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice24
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _503605631
        {
            public Baseprice25 basePrice { get; set; }
            public Finalprice25 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice25
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice25
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _503605721
        {
            public Baseprice26 basePrice { get; set; }
            public Finalprice26 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice26
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice26
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _503605771
        {
            public Baseprice27 basePrice { get; set; }
            public Finalprice27 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice27
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice27
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _518599511
        {
            public Baseprice28 basePrice { get; set; }
            public Finalprice28 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice28
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice28
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _518599571
        {
            public Baseprice29 basePrice { get; set; }
            public Finalprice29 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice29
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice29
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _518599691
        {
            public Baseprice30 basePrice { get; set; }
            public Finalprice30 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice30
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice30
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _525756632
        {
            public Baseprice31 basePrice { get; set; }
            public Finalprice31 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice31
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice31
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _528216021
        {
            public Baseprice32 basePrice { get; set; }
            public Finalprice32 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice32
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice32
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _528603261
        {
            public Baseprice33 basePrice { get; set; }
            public Finalprice33 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice33
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice33
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _531913661
        {
            public Baseprice34 basePrice { get; set; }
            public Finalprice34 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice34
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice34
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _536784221
        {
            public Baseprice35 basePrice { get; set; }
            public Finalprice35 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice35
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice35
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _540865151
        {
            public Baseprice36 basePrice { get; set; }
            public Finalprice36 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice36
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice36
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _583254811
        {
            public Baseprice37 basePrice { get; set; }
            public Finalprice37 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice37
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice37
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _604976691
        {
            public Baseprice38 basePrice { get; set; }
            public Finalprice38 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice38
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice38
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _613312931
        {
            public Baseprice39 basePrice { get; set; }
            public Finalprice39 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice39
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice39
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _682344111
        {
            public Baseprice40 basePrice { get; set; }
            public Finalprice40 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice40
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice40
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _728769191
        {
            public Baseprice41 basePrice { get; set; }
            public Finalprice41 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice41
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice41
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _871835891
        {
            public Baseprice42 basePrice { get; set; }
            public Finalprice42 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice42
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice42
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _877424652
        {
            public Baseprice43 basePrice { get; set; }
            public Finalprice43 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice43
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice43
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _910034781
        {
            public Baseprice44 basePrice { get; set; }
            public Finalprice44 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice44
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice44
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _910725761
        {
            public Baseprice45 basePrice { get; set; }
            public Finalprice45 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice45
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice45
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _918563351
        {
            public Baseprice46 basePrice { get; set; }
            public Finalprice46 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice46
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice46
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _955419751
        {
            public Baseprice47 basePrice { get; set; }
            public Finalprice47 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice47
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice47
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _957918281
        {
            public Baseprice48 basePrice { get; set; }
            public Finalprice48 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice48
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice48
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _957918291
        {
            public Baseprice49 basePrice { get; set; }
            public Finalprice49 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice49
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice49
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _957918311
        {
            public Baseprice50 basePrice { get; set; }
            public Finalprice50 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice50
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice50
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _957918321
        {
            public Baseprice51 basePrice { get; set; }
            public Finalprice51 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice51
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice51
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _963193511
        {
            public Baseprice52 basePrice { get; set; }
            public Finalprice52 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice52
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice52
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _970612281
        {
            public Baseprice53 basePrice { get; set; }
            public Finalprice53 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice53
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice53
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _970861301
        {
            public Baseprice54 basePrice { get; set; }
            public Finalprice54 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice54
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice54
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _973477591
        {
            public Baseprice55 basePrice { get; set; }
            public Finalprice55 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice55
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice55
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1020157921
        {
            public Baseprice56 basePrice { get; set; }
            public Finalprice56 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice56
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice56
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1020877751
        {
            public Baseprice57 basePrice { get; set; }
            public Finalprice57 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice57
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice57
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1023248671
        {
            public Baseprice58 basePrice { get; set; }
            public Finalprice58 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice58
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice58
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1066106522
        {
            public Baseprice59 basePrice { get; set; }
            public Finalprice59 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice59
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice59
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1091288141
        {
            public Baseprice60 basePrice { get; set; }
            public Finalprice60 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice60
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice60
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1120074601
        {
            public Baseprice61 basePrice { get; set; }
            public Finalprice61 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice61
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice61
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1151313081
        {
            public Baseprice62 basePrice { get; set; }
            public Finalprice62 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice62
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice62
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1271552631
        {
            public Baseprice63 basePrice { get; set; }
            public Finalprice63 finalPrice { get; set; }
            public bool hasMarketplaceListings { get; set; }
            public bool isTradeExclusive { get; set; }
        }

        public class Baseprice63
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice63
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Vendorlistingsstore
        {
            public Data27 data { get; set; }
        }

        public class Data27
        {
            public _193482705 _19348270 { get; set; }
        }

        public class _193482705
        {
            public _8707302 _8707302 { get; set; }
        }

        public class _8707302
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price6 price { get; set; }
            public int quantity { get; set; }
            public bool isBuyable { get; set; }
            public bool isAvailable { get; set; }
            public bool isMPListing { get; set; }
            public bool isActiveMPListing { get; set; }
            public bool isPending { get; set; }
            public bool isParent { get; set; }
            public bool isBulkItem { get; set; }
            public bool showPriceMarkdown { get; set; }
            public bool isDirectVendor { get; set; }
            public bool isFreeShipping { get; set; }
            public bool prop65Disclosure { get; set; }
            public int leadTime { get; set; }
            public int leadTimeMax { get; set; }
            public int shipCostCurbside { get; set; }
            public int shipCostInside { get; set; }
            public string shippingCharge { get; set; }
            public string dimensions { get; set; }
            public string weight { get; set; }
            public bool hasActivePromoCampaign { get; set; }
            public bool isTradePrice { get; set; }
            public bool isTradeExclusive { get; set; }
            public string moreOptionsString { get; set; }
            public bool isDiscontinued { get; set; }
            public string marginColor { get; set; }
            public string marginNumber { get; set; }
            public bool isEligibleForFreeShipping { get; set; }
            public string freeShippingMinimum { get; set; }
            public bool hasValidTradePrice { get; set; }
            public bool useShippingCalculator { get; set; }
            public bool isReturnable { get; set; }
            public bool shouldHideTradeExclusive { get; set; }
            public string browseVendorProductsUrl { get; set; }
        }

        public class Price6
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Headerstore
        {
            public Data28 data { get; set; }
        }

        public class Data28
        {
            public bool isProfessionalsDirectoryOnJukwaa { get; set; }
            public bool isSalesPageEnabled { get; set; }
            public string secondaryMenuHtml { get; set; }
            public Headerpromoconfig headerPromoConfig { get; set; }
            public Promosale[] promoSales { get; set; }
        }

        public class Headerpromoconfig
        {
            public string objectId { get; set; }
            public string link { get; set; }
            public bool isExternal { get; set; }
            public string text { get; set; }
            public string shortText { get; set; }
            public int saleLandingPageId { get; set; }
        }

        public class Promosale
        {
            public string headerSpaceImageUrl { get; set; }
            public string saleLabel { get; set; }
            public string tagLabel { get; set; }
            public int galleryId { get; set; }
        }

        public class Headerbannerstore
        {
            public Data29 data { get; set; }
        }

        public class Data29
        {
        }

        public class Footerstore
        {
            public Data30 data { get; set; }
        }

        public class Data30
        {
            public Footerinfo footerInfo { get; set; }
            public bool shouldShowCookieBanner { get; set; }
        }

        public class Footerinfo
        {
            public Currentcctld currentCcTld { get; set; }
            public Cctld[] ccTlds { get; set; }
            public Linkgroups linkGroups { get; set; }
        }

        public class Currentcctld
        {
            public string ccTLD { get; set; }
            public string domain { get; set; }
            public string locale { get; set; }
            public string countryCode { get; set; }
            public string countryNativeName { get; set; }
            public string timeZone { get; set; }
            public string siteId { get; set; }
            public string localeId { get; set; }
            public string seoLang { get; set; }
        }

        public class Linkgroups
        {
            public Company[] company { get; set; }
            public Explore[] explore { get; set; }
            public Connect[] connect { get; set; }
        }

        public class Company
        {
            public string id { get; set; }
            public string url { get; set; }
            public string[] ids { get; set; }
            public string[] urls { get; set; }
        }

        public class Explore
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class Connect
        {
            public string id { get; set; }
            public string url { get; set; }
            public string icon { get; set; }
        }

        public class Cctld
        {
            public string ccTLD { get; set; }
            public string domain { get; set; }
            public string locale { get; set; }
            public string countryCode { get; set; }
            public string countryNativeName { get; set; }
            public string timeZone { get; set; }
            public string siteId { get; set; }
            public string localeId { get; set; }
            public string seoLang { get; set; }
        }

        public class Areasstore
        {
            public Data31 data { get; set; }
        }

        public class Data31
        {
            public string[] orderedCountryCodes { get; set; }
            public Countrymap countryMap { get; set; }
            public Orderedmetroareas orderedMetroAreas { get; set; }
            public Metromap metroMap { get; set; }
        }

        public class Countrymap
        {
            public US US { get; set; }
            public AU AU { get; set; }
            public CA CA { get; set; }
            public DK DK { get; set; }
            public FR FR { get; set; }
            public DE DE { get; set; }
            public IN IN { get; set; }
            public IE IE { get; set; }
            public IT IT { get; set; }
            public JP JP { get; set; }
            public NZ NZ { get; set; }
            public RU RU { get; set; }
            public SG SG { get; set; }
            public ES ES { get; set; }
            public SE SE { get; set; }
            public GB GB { get; set; }
            public More more { get; set; }
        }

        public class US
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class AU
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class CA
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class DK
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class FR
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class DE
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class IN
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class IE
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class IT
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class JP
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class NZ
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class RU
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class SG
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class ES
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class SE
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class GB
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
            public string slug { get; set; }
        }

        public class More
        {
            public string id { get; set; }
            public string name { get; set; }
            public string whole_name { get; set; }
        }

        public class Orderedmetroareas
        {
            public int[] US { get; set; }
            public int[] GB { get; set; }
            public int[] more { get; set; }
            public int[] CA { get; set; }
            public int[] AU { get; set; }
            public int[] IE { get; set; }
            public int[] NZ { get; set; }
            public int[] DE { get; set; }
            public int[] DK { get; set; }
            public int[] ES { get; set; }
            public int[] FR { get; set; }
            public int[] IN { get; set; }
            public int[] IT { get; set; }
            public int[] JP { get; set; }
            public int[] RU { get; set; }
            public int[] SE { get; set; }
            public int[] SG { get; set; }
        }

        public class Metromap
        {
            public _1 _1 { get; set; }
            public _21 _2 { get; set; }
            public _12 _12 { get; set; }
            public _20 _20 { get; set; }
            public _211 _21 { get; set; }
            public _22 _22 { get; set; }
            public _23 _23 { get; set; }
            public _24 _24 { get; set; }
            public _25 _25 { get; set; }
            public _26 _26 { get; set; }
            public _28 _28 { get; set; }
            public _29 _29 { get; set; }
            public _30 _30 { get; set; }
            public _33 _33 { get; set; }
            public _34 _34 { get; set; }
            public _35 _35 { get; set; }
            public _36 _36 { get; set; }
            public _37 _37 { get; set; }
            public _38 _38 { get; set; }
            public _39 _39 { get; set; }
            public _40 _40 { get; set; }
            public _41 _41 { get; set; }
            public _42 _42 { get; set; }
            public _43 _43 { get; set; }
            public _44 _44 { get; set; }
            public _45 _45 { get; set; }
            public _46 _46 { get; set; }
            public _47 _47 { get; set; }
            public _48 _48 { get; set; }
            public _49 _49 { get; set; }
            public _50 _50 { get; set; }
            public _51 _51 { get; set; }
            public _52 _52 { get; set; }
            public _53 _53 { get; set; }
            public _54 _54 { get; set; }
            public _55 _55 { get; set; }
            public _56 _56 { get; set; }
            public _57 _57 { get; set; }
            public _58 _58 { get; set; }
            public _59 _59 { get; set; }
            public _60 _60 { get; set; }
            public _61 _61 { get; set; }
            public _62 _62 { get; set; }
            public _63 _63 { get; set; }
            public _64 _64 { get; set; }
            public _65 _65 { get; set; }
            public _66 _66 { get; set; }
            public _67 _67 { get; set; }
            public _68 _68 { get; set; }
            public _69 _69 { get; set; }
            public _70 _70 { get; set; }
            public _71 _71 { get; set; }
            public _72 _72 { get; set; }
            public _73 _73 { get; set; }
            public _74 _74 { get; set; }
            public _75 _75 { get; set; }
            public _76 _76 { get; set; }
            public _77 _77 { get; set; }
            public _78 _78 { get; set; }
            public _79 _79 { get; set; }
            public _80 _80 { get; set; }
            public _81 _81 { get; set; }
            public _82 _82 { get; set; }
            public _83 _83 { get; set; }
            public _84 _84 { get; set; }
            public _85 _85 { get; set; }
            public _86 _86 { get; set; }
            public _87 _87 { get; set; }
            public _88 _88 { get; set; }
            public _89 _89 { get; set; }
            public _90 _90 { get; set; }
            public _91 _91 { get; set; }
            public _92 _92 { get; set; }
            public _93 _93 { get; set; }
            public _94 _94 { get; set; }
            public _95 _95 { get; set; }
            public _96 _96 { get; set; }
            public _97 _97 { get; set; }
            public _98 _98 { get; set; }
            public _99 _99 { get; set; }
            public _100 _100 { get; set; }
            public _103 _103 { get; set; }
            public _104 _104 { get; set; }
            public _105 _105 { get; set; }
            public _106 _106 { get; set; }
            public _107 _107 { get; set; }
            public _108 _108 { get; set; }
            public _109 _109 { get; set; }
            public _110 _110 { get; set; }
            public _111 _111 { get; set; }
            public _112 _112 { get; set; }
            public _113 _113 { get; set; }
            public _114 _114 { get; set; }
            public _115 _115 { get; set; }
            public _124 _124 { get; set; }
            public _126 _126 { get; set; }
            public _128 _128 { get; set; }
            public _129 _129 { get; set; }
            public _130 _130 { get; set; }
            public _131 _131 { get; set; }
            public _132 _132 { get; set; }
            public _133 _133 { get; set; }
            public _134 _134 { get; set; }
            public _135 _135 { get; set; }
            public _136 _136 { get; set; }
            public _137 _137 { get; set; }
            public _138 _138 { get; set; }
            public _139 _139 { get; set; }
            public _140 _140 { get; set; }
            public _142 _142 { get; set; }
            public _143 _143 { get; set; }
            public _144 _144 { get; set; }
            public _145 _145 { get; set; }
            public _146 _146 { get; set; }
            public _147 _147 { get; set; }
            public _149 _149 { get; set; }
            public _150 _150 { get; set; }
            public _151 _151 { get; set; }
            public _152 _152 { get; set; }
            public _153 _153 { get; set; }
            public _154 _154 { get; set; }
            public _155 _155 { get; set; }
            public _156 _156 { get; set; }
            public _157 _157 { get; set; }
            public _158 _158 { get; set; }
            public _159 _159 { get; set; }
            public _160 _160 { get; set; }
            public _161 _161 { get; set; }
            public _162 _162 { get; set; }
            public _163 _163 { get; set; }
            public _164 _164 { get; set; }
            public _165 _165 { get; set; }
            public _166 _166 { get; set; }
            public _167 _167 { get; set; }
            public _168 _168 { get; set; }
            public _169 _169 { get; set; }
            public _170 _170 { get; set; }
            public _171 _171 { get; set; }
            public _172 _172 { get; set; }
            public _173 _173 { get; set; }
            public _174 _174 { get; set; }
            public _175 _175 { get; set; }
            public _176 _176 { get; set; }
            public _177 _177 { get; set; }
            public _178 _178 { get; set; }
            public _179 _179 { get; set; }
            public _180 _180 { get; set; }
            public _181 _181 { get; set; }
            public _182 _182 { get; set; }
            public _183 _183 { get; set; }
            public _184 _184 { get; set; }
            public _185 _185 { get; set; }
            public _186 _186 { get; set; }
            public _187 _187 { get; set; }
            public _188 _188 { get; set; }
            public _189 _189 { get; set; }
            public _190 _190 { get; set; }
            public _191 _191 { get; set; }
            public _192 _192 { get; set; }
            public _193 _193 { get; set; }
            public _194 _194 { get; set; }
            public _195 _195 { get; set; }
            public _196 _196 { get; set; }
            public _197 _197 { get; set; }
            public _199 _199 { get; set; }
            public _200 _200 { get; set; }
            public _201 _201 { get; set; }
            public _202 _202 { get; set; }
            public _203 _203 { get; set; }
            public _204 _204 { get; set; }
            public _205 _205 { get; set; }
            public _206 _206 { get; set; }
            public _207 _207 { get; set; }
            public _208 _208 { get; set; }
            public _209 _209 { get; set; }
            public _210 _210 { get; set; }
            public _2111 _211 { get; set; }
            public _212 _212 { get; set; }
            public _213 _213 { get; set; }
            public _214 _214 { get; set; }
            public _215 _215 { get; set; }
            public _216 _216 { get; set; }
            public _217 _217 { get; set; }
            public _218 _218 { get; set; }
            public _219 _219 { get; set; }
            public _220 _220 { get; set; }
            public _222 _222 { get; set; }
            public _223 _223 { get; set; }
            public _224 _224 { get; set; }
            public _225 _225 { get; set; }
            public _226 _226 { get; set; }
            public _228 _228 { get; set; }
            public _229 _229 { get; set; }
            public _230 _230 { get; set; }
            public _231 _231 { get; set; }
            public _232 _232 { get; set; }
            public _242 _242 { get; set; }
            public _243 _243 { get; set; }
            public _244 _244 { get; set; }
            public _245 _245 { get; set; }
            public _246 _246 { get; set; }
            public _247 _247 { get; set; }
            public _248 _248 { get; set; }
            public _249 _249 { get; set; }
            public _250 _250 { get; set; }
            public _251 _251 { get; set; }
            public _252 _252 { get; set; }
            public _253 _253 { get; set; }
        }

        public class _1
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _21
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _12
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _20
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _211
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _22
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _23
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _24
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _25
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _26
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _28
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _29
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _30
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _33
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _34
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _35
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _36
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _37
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _38
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _39
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _40
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _41
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _42
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _43
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _44
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _45
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _46
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _47
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _48
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _49
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _50
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _51
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _52
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _53
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _54
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _55
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _56
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _57
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _58
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _59
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _60
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _61
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _62
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _63
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _64
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _65
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _66
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _67
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _68
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _69
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _70
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _71
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _72
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _73
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _74
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _75
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _76
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _77
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _78
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _79
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _80
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _81
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _82
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _83
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _84
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _85
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _86
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _87
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _88
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _89
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _90
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _91
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _92
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _93
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _94
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _95
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _96
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _97
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _98
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _99
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _100
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _103
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _104
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _105
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _106
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _107
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _108
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _109
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _110
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _111
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _112
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _113
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _114
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _115
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _124
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _126
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _128
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _129
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _130
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _131
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _132
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _133
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _134
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _135
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _136
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _137
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _138
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _139
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _140
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _142
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _143
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _144
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _145
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _146
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _147
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _149
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _150
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _151
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _152
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _153
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _154
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _155
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _156
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _157
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _158
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _159
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _160
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _161
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _162
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _163
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _164
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _165
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _166
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _167
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _168
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _169
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _170
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _171
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _172
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _173
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _174
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _175
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _176
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _177
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _178
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _179
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _180
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _181
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _182
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _183
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _184
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _185
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _186
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _187
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _188
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _189
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _190
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _191
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _192
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _193
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _194
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _195
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _196
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _197
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _199
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _200
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _201
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _202
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _203
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _204
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _205
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _206
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _207
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _208
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _209
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _210
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _2111
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _212
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _213
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _214
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _215
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _216
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _217
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _218
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _219
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _220
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _222
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _223
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _224
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _225
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _226
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _228
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _229
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _230
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _231
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _232
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _242
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _243
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _244
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _245
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _246
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _247
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _248
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _249
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _250
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _251
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _252
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class _253
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class Cartstore
        {
            public object[] prereqs { get; set; }
            public Data32 data { get; set; }
        }

        public class Data32
        {
            public int TotalItemsCount { get; set; }
        }

        public class C2lightboxstore
        {
            public Data33 data { get; set; }
        }

        public class Data33
        {
            public Spaces spaces { get; set; }
            public Images images { get; set; }
            public Users users { get; set; }
            public Productinfo productInfo { get; set; }
            public Listingsinfo listingsInfo { get; set; }
            public bool lbResourcesCaptured { get; set; }
            public Config config { get; set; }
        }

        public class Spaces
        {
            public _193482706 _19348270 { get; set; }
        }

        public class _193482706
        {
            public string id { get; set; }
            public string u { get; set; }
            public string type { get; set; }
            public bool ift { get; set; }
            public string ft { get; set; }
            public string ow { get; set; }
            public int cau { get; set; }
            public string au { get; set; }
            public string price { get; set; }
            public string cuid { get; set; }
            public string amtRaw { get; set; }
            public string amt { get; set; }
            public string l { get; set; }
            public string tl { get; set; }
            public string t { get; set; }
            public string c { get; set; }
            public string cat { get; set; }
            public string s { get; set; }
            public string bc { get; set; }
            public string bcf { get; set; }
            public bool bmu { get; set; }
            public string pid { get; set; }
            public bool prod { get; set; }
            public bool f { get; set; }
            public string[] iids { get; set; }
            public int srct { get; set; }
            public int pm { get; set; }
            public Brlnk brlnk { get; set; }
        }

        public class Brlnk
        {
            public string cat { get; set; }
            public string s { get; set; }
            public Crumb[] crumbs { get; set; }
        }

        public class Crumb
        {
            public string label { get; set; }
            public string url { get; set; }
            public bool highlight { get; set; }
        }

        public class Images
        {
            public Bfc1a934045900731 bfc1a93404590073 { get; set; }
        }

        public class Bfc1a934045900731
        {
            public string w { get; set; }
            public string h { get; set; }
            public string ts { get; set; }
            public int bg { get; set; }
        }

        public class Users
        {
            public _12543811 _1254381 { get; set; }
            public _163936411 _16393641 { get; set; }
            public _166551902 _16655190 { get; set; }
            public _392613591 _39261359 { get; set; }
            public _430303571 _43030357 { get; set; }
        }

        public class _12543811
        {
            public string n { get; set; }
            public string d { get; set; }
            public string iid { get; set; }
        }

        public class _163936411
        {
            public string n { get; set; }
            public string d { get; set; }
            public string iid { get; set; }
        }

        public class _166551902
        {
            public string n { get; set; }
            public string d { get; set; }
            public string iid { get; set; }
            public string pt { get; set; }
            public string p { get; set; }
            public string nr { get; set; }
            public string r { get; set; }
            public string loc { get; set; }
            public bool prx { get; set; }
            public string mpv { get; set; }
            public int sbp { get; set; }
        }

        public class _392613591
        {
            public string n { get; set; }
            public string d { get; set; }
            public string iid { get; set; }
        }

        public class _430303571
        {
            public string n { get; set; }
            public string d { get; set; }
            public string iid { get; set; }
        }

        public class Productinfo
        {
            public _193482707 _19348270 { get; set; }
        }

        public class _193482707
        {
            public string plid { get; set; }
            public string pvid { get; set; }
            public string p { get; set; }
            public string currency { get; set; }
            public string msrp { get; set; }
            public string msrpstr { get; set; }
            public string bp { get; set; }
            public string bpt { get; set; }
            public string rp { get; set; }
            public string rpn { get; set; }
            public string tm { get; set; }
            public bool pover { get; set; }
            public bool parent { get; set; }
            public bool vl { get; set; }
            public bool mp { get; set; }
            public string activeMpListingCount { get; set; }
            public bool av { get; set; }
            public bool puv { get; set; }
            public bool excl { get; set; }
            public bool bstslr { get; set; }
            public string manuId { get; set; }
            public string manu { get; set; }
            public string manuName { get; set; }
            public float w { get; set; }
            public float d { get; set; }
            public float h { get; set; }
            public string c { get; set; }
            public string dimensions { get; set; }
            public string weight { get; set; }
            public string swlabel { get; set; }
            public string swvalue { get; set; }
        }

        public class Listingsinfo
        {
        }

        public class Config
        {
            public bool isVisitor { get; set; }
            public Gtmidhash gtmIdHash { get; set; }
            public string gtmTestBucket { get; set; }
            public bool isTradePro { get; set; }
            public string tosUrl { get; set; }
            public string privacyUrl { get; set; }
            public Countryfilter[] countryFilter { get; set; }
            public bool fbLoginEnabled { get; set; }
            public int fbSource { get; set; }
            public bool preloadEditorResources { get; set; }
            public bool enableColorPicker { get; set; }
            public string[] socialListConfig { get; set; }
            public Socialshareplatforms socialSharePlatforms { get; set; }
            public bool isCheckoutEnabled { get; set; }
            public bool useNotifyMeText { get; set; }
            public int notifyMeSourceLink { get; set; }
            public bool enableTagBoundingBox { get; set; }
            public string preSalesPhoneNumber { get; set; }
            public bool wideProductColumnEnabled { get; set; }
            public bool isViewSpace { get; set; }
            public bool enableProductCollections { get; set; }
            public bool uploadEditHintsEnabled { get; set; }
            public bool sketchForWebEnabled { get; set; }
            public bool TRACK_IMPRESSIONS { get; set; }
            public bool enablePhotoLocationFields { get; set; }
            public Moduleresourcetag[] moduleResourceTags { get; set; }
            public object[] spaceIdToVendorListingIdOverride { get; set; }
            public bool secureImages { get; set; }
            public bool freeShippingLabelTreatment { get; set; }
            public bool replaceSaleBadgeWithLabel { get; set; }
            public bool emailShareAfterSignup { get; set; }
            public bool useDropdownVariations { get; set; }
            public bool isTradePromoEnabled { get; set; }
            public bool isTradePromoNoteEnabled { get; set; }
            public bool enableTagsRedesign { get; set; }
            public bool isMainProdBtnQuantityInline { get; set; }
            public bool isProductDocumentUIEnabled { get; set; }
            public bool enableNewVmCardTitle { get; set; }
            public bool showWasTooltip { get; set; }
            public string priceRedesign { get; set; }
            public bool tradePriceRedesign { get; set; }
            public bool enableVMHoverEffect { get; set; }
            public bool showSimpleVersionLightbox { get; set; }
            public bool enableVisualMatchRightRail { get; set; }
            public bool enableSaveBtnHeartIcon { get; set; }
            public bool isStrikethroughTreatment { get; set; }
        }

        public class Gtmidhash
        {
            public string hashed_user { get; set; }
            public string hashed_visitor { get; set; }
        }

        public class Socialshareplatforms
        {
            public int facebook { get; set; }
            public int googlePlus { get; set; }
            public int twitter { get; set; }
            public int vkontakte { get; set; }
            public int odnoklassniki { get; set; }
            public int line { get; set; }
            public int linkedIn { get; set; }
        }

        public class Countryfilter
        {
            public int siteId { get; set; }
            public string country { get; set; }
            public string countryDisplayName { get; set; }
            public int locale { get; set; }
            public bool current { get; set; }
        }

        public class Moduleresourcetag
        {
            public string tagName { get; set; }
            public object contents { get; set; }
            public Attributes2 attributes { get; set; }
        }

        public class Attributes2
        {
            public string rel { get; set; }
            public string type { get; set; }
            public string href { get; set; }
            public string language { get; set; }
            public string src { get; set; }
        }

        public class Spacelabelsstore
        {
            public Data34 data { get; set; }
        }

        public class Data34
        {
            public _193482708 _19348270 { get; set; }
        }

        public class _193482708
        {
            public _27 _2 { get; set; }
        }

        public class _27
        {
            public string sectionTitle { get; set; }
            public Label[] labels { get; set; }
        }

        public class Label
        {
            public string text { get; set; }
            public string url { get; set; }
        }

        public class Questionanswermapstore
        {
            public Data35 data { get; set; }
        }

        public class Data35
        {
            public int[] _4605854 { get; set; }
            public int[] _4792626 { get; set; }
            public int[] _5252975 { get; set; }
        }

    public class Answerstore
    {
        public JObject data { get; set; }
    }

    //public class Data36
    //{
    //    public _20502942 _20502942 { get; set; }
    //    public _20962029 _20962029 { get; set; }
    //    public _20992881 _20992881 { get; set; }
    //    public _22061441 _22061441 { get; set; }
    //}

    public class AnswerClass
    {
        public int id { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
        public int userId { get; set; }
        public int questionId { get; set; }
        public string body { get; set; }
        public int numberOfLikes { get; set; }
        public bool isolated { get; set; }
        public bool isThanked { get; set; }
        public string htmlBody { get; set; }
    }

    //public class _20962029
    //{
    //    public int id { get; set; }
    //    public string created { get; set; }
    //    public string modified { get; set; }
    //    public int userId { get; set; }
    //    public int questionId { get; set; }
    //    public string body { get; set; }
    //    public int numberOfLikes { get; set; }
    //    public bool isolated { get; set; }
    //    public bool isThanked { get; set; }
    //    public string htmlBody { get; set; }
    //}

    //public class _20992881
    //{
    //    public int id { get; set; }
    //    public string created { get; set; }
    //    public string modified { get; set; }
    //    public int userId { get; set; }
    //    public int questionId { get; set; }
    //    public string body { get; set; }
    //    public int numberOfLikes { get; set; }
    //    public bool isolated { get; set; }
    //    public bool isThanked { get; set; }
    //    public string htmlBody { get; set; }
    //}

    //public class _22061441
    //{
    //    public int id { get; set; }
    //    public string created { get; set; }
    //    public string modified { get; set; }
    //    public int userId { get; set; }
    //    public int questionId { get; set; }
    //    public string body { get; set; }
    //    public int numberOfLikes { get; set; }
    //    public bool isolated { get; set; }
    //    public bool isThanked { get; set; }
    //    public string htmlBody { get; set; }
    //}

    public class Metadatastore
        {
            public Data37 data { get; set; }
        }

        public class Data37
        {
            public int robotsValue { get; set; }
            public string canonicalUrl { get; set; }
            public Htmlmetatag[] htmlMetaTags { get; set; }
        }

        public class Htmlmetatag
        {
            public string tagName { get; set; }
            public Attributes3 attributes { get; set; }
            public string contents { get; set; }
        }

        public class Attributes3
        {
            public string rel { get; set; }
            public string href { get; set; }
            public string type { get; set; }
            public string sizes { get; set; }
            public string property { get; set; }
            public string content { get; set; }
        }

        public class Admintoolsstore
        {
            public object[] prereqs { get; set; }
            public Data38 data { get; set; }
        }

        public class Data38
        {
        }

        public class Abtest
        {
            public string browser_extension_upsell_content_test { get; set; }
            public string save_to_ideabook_single_selection { get; set; }
            public string add_to_ideabook_pro_wizard_search_within { get; set; }
            public string new_link_styles { get; set; }
            public string save_icon_test { get; set; }
            public string marketplace_strikethrough_price_v2_test { get; set; }
            public string vp_single_row { get; set; }
            public string product_zoom { get; set; }
            public string product_large_image_display { get; set; }
            public string vp_deferred_v2 { get; set; }
            public string view_product_review_photos { get; set; }
            public string product_videos { get; set; }
            public string r3_entry_points { get; set; }
            public string post_save_toast { get; set; }
            public string pcol_vs { get; set; }
            public string gtm_bucket { get; set; }
            public string highlight_color { get; set; }
            public string seo_view_product_enhanced_ld_json_test { get; set; }
            public string fullstory_integration { get; set; }
            public string visitor_tracker_inline_signup { get; set; }
            public string trade_showroom_test { get; set; }
            public string default_url_hint_nqrwns { get; set; }
            public string web_notifications { get; set; }
            public string footer_show_phone { get; set; }
            public string cs_presale_hours { get; set; }
            public string tm_fake_test_1 { get; set; }
            public string tm_jp_space_question { get; set; }
            public string tm_wording_test { get; set; }
            public string tm_jp_space_question2 { get; set; }
            public string tm_ContactUsButtonText_test1 { get; set; }
            public string tm_firstABtestforINTL { get; set; }
            public string tm_ContactMe_button_proProfileheader { get; set; }
            public string tm_SavePhotoButton_translation_visibleWhenNotSignedIn { get; set; }
        }

        public class Config1
        {
            public bool systemprofessionalsSearchLocationEnabled { get; set; }
            public bool GALLERY_ITEMS_ENABLED { get; set; }
            public bool PRO_CENTER_IN_TOP_RIGHT_MENU { get; set; }
            public UniversalGallery universalgallery { get; set; }
            public bool TRADE_ALLOW_NON_DISCOUNT_CREDIT { get; set; }
            public bool NEW_RETURN_POLICY_FREE_SHIPPING { get; set; }
            public float BrowsefeaturePROMOTION_MODULE_DISCOUNT_THRESHOLD { get; set; }
            public bool CHECKOUT_ENABLED { get; set; }
            public string systemsimgHost { get; set; }
            public string systemfimgHost { get; set; }
            public UniversalSave universalsave { get; set; }
            public bool browserextensionenable_upsell { get; set; }
            public BrowserExtensionExtension_Metadata browserextensionextension_metadata { get; set; }
            public int browserextensionextension_upsell_expiration_in_seconds { get; set; }
            public bool EXPAND_PRODUCT_DETAILS { get; set; }
            public string productpreSalesPhoneNumber { get; set; }
            public string productthirdPartySellerPhoneNumber { get; set; }
            public bool sitespeedconfigsENABLE_LAZY_LOADING { get; set; }
            public bool productproductReviews { get; set; }
            public BRIGHTCOVE_CONFIG_BY_SITE BRIGHTCOVE_CONFIG_BY_SITE { get; set; }
            public string PHOTO_COUNT { get; set; }
            public bool authenticationenableShareByEmailAutoRegister { get; set; }
            public ProPerception properception { get; set; }
            public bool productisSpfEnabled { get; set; }
            public bool sitespeedconfigsENABLE_IMAGE_LOAD_ON_FIRST_SCROLL { get; set; }
            public bool AB_IMPORT_ENABLED { get; set; }
            public string VERSION { get; set; }
            public bool REBRAND_ENABLED { get; set; }
            public string[] systemexternalizedAssets { get; set; }
            public string[] systemcoreStores { get; set; }
            public bool sitespeedENABLE_DEFERRED_ASYNC_RESOURCES { get; set; }
            public LoggerClientsideloggerconfig loggerclientSideLoggerConfig { get; set; }
            public string systemhostName { get; set; }
            public string systemgardenWebHostname { get; set; }
            public string systemc2ResBaseUrl { get; set; }
            public string SECURE_URL { get; set; }
            public string BASE_URL { get; set; }
            public string STATIC_URL { get; set; }
            public string STATIC_CDN_URL { get; set; }
            public string RESOURCE_STATIC_CDN_URL { get; set; }
            public bool AS_HZCDN_ENABLED { get; set; }
            public bool CDN_SERVE_JS_ENABLED { get; set; }
            public bool RESOURCE_CACHE_ENABLED { get; set; }
            public bool JS_MIN { get; set; }
            public bool JS_CACHE_CONTROL_PRIVATE_ENABLED { get; set; }
            public int JS_CACHE_BUSTING_VALUE { get; set; }
            public bool CHECKOUT_SIGNIN_ENABLED { get; set; }
            public SitespeedSpf sitespeedspf { get; set; }
            public bool sitespeedconfigsSPF_FETCH_ON_MOUSEDOWN { get; set; }
            public SitespeedConfigsSPF_DISABLED_PAGES sitespeedconfigsSPF_DISABLED_PAGES { get; set; }
            public string GA_TRACKING_ID { get; set; }
            public string GTM_ACCOUNT_ID { get; set; }
            public bool GA_ANONYMIZE_IP_ENABLED { get; set; }
            public string BUTTON_APP_ID { get; set; }
            public bool BUTTON_JS_ENABLED { get; set; }
            public SystemVisitortracker systemvisitorTracker { get; set; }
            public bool authenticationenable_visitor_tracker_inline_signup { get; set; }
            public string UPLOADFILE_PIC { get; set; }
            public string IMAGES_SEO_URL { get; set; }
            public SitespeedClientsidesitespeedconfig sitespeedclientSideSiteSpeedConfig { get; set; }
            public bool ENABLE_REFERRER_CAPTURE { get; set; }
            public bool globalfeatureJUKWAA_LIGHTBOX_ENABLED { get; set; }
            public bool tradeprogrampricing { get; set; }
            public bool tradeprogramtrade_only { get; set; }
            public bool tradeprogramquote { get; set; }
            public bool tradeprogramshowroom { get; set; }
            public bool tradeprogramtax_setting { get; set; }
            public bool tradeprogramdashboard { get; set; }
            public bool tradeprogramcredit { get; set; }
            public bool tradeprogramreferral { get; set; }
            public string FB_API_VERSION { get; set; }
            public string externalAppsfb1appid { get; set; }
            public string FB_API_JS_LIB_URL { get; set; }
            public string FB_API_DEFAULT_SCOPE { get; set; }
            public string externalAppsgoogle2client_id { get; set; }
            public bool consentsVISITOR_BANNER_SNOOZE_ENABLED { get; set; }
            public int consentsVISITOR_BANNER_SNOOZE_TIME { get; set; }
            public bool NEW_HEADER_ENABLED_12_2016 { get; set; }
            public bool BROWSE_PHOTOS_URL_MIGRATION { get; set; }
            public bool SEARCH_WITHIN_TOPIC_FROM_SERVICE_ENABLED { get; set; }
            public bool WEB_NOTIFICATIONS_ENABLED { get; set; }
            public bool WEB_NOTIFICATIONS_PAGE_ENABLED { get; set; }
            public bool SKETCH_FOR_WEB_ENABLED { get; set; }
            public USER_REFERRAL_ENABLED USER_REFERRAL_ENABLED { get; set; }
            public bool REFERRAL_PROGRAM_ENTRY_ENABLED { get; set; }
            public bool VISUAL_CHAT_REP_WEB_ENABLED { get; set; }
            public int[] signoutSiteIdOrder { get; set; }
            public string productpostSalesPhoneNumber { get; set; }
            public string productcustomerSupportHours { get; set; }
            public string productcustomerSupportHoursSaturday { get; set; }
            public bool FOOTER_SHOW_PHONE { get; set; }
            public bool COOKIE_BANNER_ENABLED { get; set; }
            public string[] BrowsefeatureSUPPORTED_COUNTRY_FLAGS { get; set; }
            public string[] BrowsefeatureEUROPEAN_COUNTRY_CODES { get; set; }
            public string[] BrowsefeatureCOUNTRY_NAME_WHITE_LIST { get; set; }
        }

        public class UniversalGallery
        {
            public bool enable_reordering { get; set; }
            public bool enable_organizing { get; set; }
            public int post_save_toast_lasting_ms { get; set; }
            public int page_size { get; set; }
            public int lazyload_index { get; set; }
            public int lazyload_index_mobile { get; set; }
            public bool enable_folder { get; set; }
            public bool enable_editorial_view { get; set; }
        }

        public class UniversalSave
        {
            public int extension_upsell_expiration_in_seconds { get; set; }
        }

        public class BrowserExtensionExtension_Metadata
        {
            public Chrome1 chrome { get; set; }
            public Firefox firefox { get; set; }
            public Edge edge { get; set; }
            public Safari safari { get; set; }
        }

        public class Chrome1
        {
            public string name { get; set; }
            public string id { get; set; }
            public string link { get; set; }
            public bool hasHouzzBg { get; set; }
            public bool enableUpsell { get; set; }
        }

        public class Firefox
        {
            public string name { get; set; }
            public string id { get; set; }
            public string link { get; set; }
            public bool hasHouzzBg { get; set; }
            public bool enableUpsell { get; set; }
        }

        public class Edge
        {
            public string name { get; set; }
            public string id { get; set; }
            public string link { get; set; }
            public bool hasHouzzBg { get; set; }
            public bool enableUpsell { get; set; }
        }

        public class Safari
        {
            public string name { get; set; }
            public string id { get; set; }
            public string link { get; set; }
            public bool hasHouzzBg { get; set; }
            public bool enableUpsell { get; set; }
        }

        public class BRIGHTCOVE_CONFIG_BY_SITE
        {
            public _101 _101 { get; set; }
        }

        public class _101
        {
            public string account_id { get; set; }
            public string regular_video_player_id { get; set; }
            public string embed_video_player_id { get; set; }
            public string proplus_video_player_id { get; set; }
            public string view_product_player_id { get; set; }
        }

        public class ProPerception
        {
            public int lightbox_banner_dismissal_expire_in_second { get; set; }
        }

        public class LoggerClientsideloggerconfig
        {
            public string BASE_EVENT_LOG_LIGHTWEIGHT_LINK { get; set; }
            public string BASE_URL { get; set; }
        }

        public class SitespeedSpf
        {
            public bool ENABLE_PREFETCH { get; set; }
            public bool ENABLE_AJAX_CACHING { get; set; }
            public int CACHE_EXPIRY_TIME_IN_SECONDS { get; set; }
            public string[] SUPPORTED_PAGES { get; set; }
            public BASE_SPF_CONFIG BASE_SPF_CONFIG { get; set; }
        }

        public class BASE_SPF_CONFIG
        {
            public RequestHeaders requestheaders { get; set; }
            public int requesttimeout { get; set; }
            public int cachemax { get; set; }
            public int navigatelimit { get; set; }
            public bool experimentalremovehistory { get; set; }
        }

        public class RequestHeaders
        {
            public string XRequestedWith { get; set; }
            public bool xhzrequest { get; set; }
            public bool xhzspfrequest { get; set; }
        }

        public class SitespeedConfigsSPF_DISABLED_PAGES
        {
            public int professionalsDirectoryLanding { get; set; }
            public int browseProfessionalsDirectory { get; set; }
            public int professionals { get; set; }
        }

        public class SystemVisitortracker
        {
            public bool enabled { get; set; }
            public int expireTime { get; set; }
            public int numViews { get; set; }
        }

        public class SitespeedClientsidesitespeedconfig
        {
            public bool ENABLE_SITESPEED_LOGGING { get; set; }
        }

        public class USER_REFERRAL_ENABLED
        {
            public string REFERRAL_BONUS { get; set; }
            public string REFERRAL_LIMIT { get; set; }
        }

        public class Permission
        {
            public bool EDIT_ANSWER { get; set; }
            public bool DELETE_ANSWER { get; set; }
            public bool VIEW_FULL_QUESTION_INFO { get; set; }
            public bool CONTENT_AUDIT { get; set; }
            public bool VIEW_PRODUCT_REVIEWS { get; set; }
            public bool VIEW_SEARCH_ADMIN { get; set; }
            public bool JOIN_VISUAL_CHAT_ROOM { get; set; }
            public bool CLAIM_VISUAL_CHAT_CALLS { get; set; }
        }

        public class Clientinfo
        {
            public string ua { get; set; }
            public Browser browser { get; set; }
            public Engine engine { get; set; }
            public Os os { get; set; }
            public Device device { get; set; }
            public Cpu cpu { get; set; }
            public bool isTablet { get; set; }
            public bool isMobile { get; set; }
            public bool isEmbedded { get; set; }
            public bool isIE { get; set; }
            public bool isIE9 { get; set; }
            public bool isSafari { get; set; }
            public bool isKindle { get; set; }
            public bool isIOS { get; set; }
            public bool isAndroid { get; set; }
            public bool isWinMo { get; set; }
            public string ip { get; set; }
        }

        public class Browser
        {
        }

        public class Engine
        {
        }

        public class Os
        {
        }

        public class Device
        {
        }

        public class Cpu
        {
        }

        public class Pagedescriptor1
        {
            public string pageCommand { get; set; }
            public string pageClass { get; set; }
            public string contentDescriptor { get; set; }
            public string rid { get; set; }
            public string url { get; set; }
            public string cname { get; set; }
            public string p { get; set; }
        }

        public class Geo
        {
            public string ccTLD { get; set; }
            public string domain { get; set; }
            public string locale { get; set; }
            public string countryCode { get; set; }
            public string countryNativeName { get; set; }
            public string timeZone { get; set; }
            public string siteId { get; set; }
            public string localeId { get; set; }
            public string seoLang { get; set; }
        }

        public class Geoinfo1
        {
            public string country { get; set; }
            public string region { get; set; }
            public string postalCode { get; set; }
            public string city { get; set; }
            public string addr { get; set; }
        }

        public class Site
        {
            public string site { get; set; }
            public string siteId { get; set; }
        }

    

}
