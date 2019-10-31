using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houzz.Helper
{
    public class InterfaceFilter
    {


        public Data data { get; set; }
        public Abtest abtest { get; set; }
        public Config config { get; set; }
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
            public Topicsstore TopicsStore { get; set; }
            public Browseresultsetstore BrowseResultSetStore { get; set; }
            public Productvariationsstore ProductVariationsStore { get; set; }
            public Browseproductreviewsstore BrowseProductReviewsStore { get; set; }
            public Secondaryquerystore SecondaryQueryStore { get; set; }
            public Spaceshorttitlesstore SpaceShortTitlesStore { get; set; }
            public Productadsstore ProductAdsStore { get; set; }
            public Queryrewritesuggestionstore QueryRewriteSuggestionStore { get; set; }
            public Relatedsearchstore RelatedSearchStore { get; set; }
            public Newarrivalsstore NewArrivalsStore { get; set; }
            public Recentlyviewedproductsstore RecentlyViewedProductsStore { get; set; }
            public Footerstore FooterStore { get; set; }
            public Areasstore AreasStore { get; set; }
            public Cartstore CartStore { get; set; }
            public Headerstore HeaderStore { get; set; }
            public Headerbannerstore HeaderBannerStore { get; set; }
            public Navigationstore NavigationStore { get; set; }
            public Spacestore SpaceStore { get; set; }
            public Imagestore ImageStore { get; set; }
            public Userstore UserStore { get; set; }
            public Professionalstore ProfessionalStore { get; set; }
            public Productinfostore ProductInfoStore { get; set; }
            public Vendorlistingsstore VendorListingsStore { get; set; }
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
            public bool shouldTrackVisitor { get; set; }
            public Queryrewriteinfo queryRewriteInfo { get; set; }
            public string query { get; set; }
            public int topicId { get; set; }
            public int pageType { get; set; }
            public int pageNamespace { get; set; }
            public string commandNameAlias { get; set; }
            public bool isPotentialRoomLandingPage { get; set; }
            public string internalUrlPath { get; set; }
            public string csrfToken { get; set; }
            public bool isMobileSplashEnabled { get; set; }
            public string metaTitle { get; set; }
            public string pageTitle { get; set; }
            public string metaDescription { get; set; }
            public string pageDescriptionFull { get; set; }
            public string pageDescriptionHeader { get; set; }
            public string pageDescriptionFooter { get; set; }
            public string canonicalUrl { get; set; }
            public string shareUrl { get; set; }
            public string appUrl { get; set; }
            public Htmltag[] htmlTags { get; set; }
            public int robotsValue { get; set; }
            public Hreflanghtmltag[] hrefLangHtmlTags { get; set; }
            public string mobileSplashTitle { get; set; }
            public string urlDescriptorJsonString { get; set; }
            public string paginationFirstPageUrl { get; set; }
            public string paginationUrlTemplate { get; set; }
            public Seoflags seoFlags { get; set; }
            public Siteswitchurls siteSwitchUrls { get; set; }
            public Onlinemarketingpagetags onlineMarketingPageTags { get; set; }
            public string requestId { get; set; }
            public string pageName { get; set; }
        }

        public class Pagedescriptor
        {
            public string pageClass { get; set; }
            public string pageCommand { get; set; }
            public string contentDescriptor { get; set; }
        }

        public class Queryrewriteinfo
        {
            public int queryRewriteType { get; set; }
            public object[] secondaryQueries { get; set; }
        }

        public class Seoflags
        {
            public bool suppressPhotoDescription { get; set; }
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

        public class Onlinemarketingpagetags
        {
            public string page_type { get; set; }
            public string product_topic { get; set; }
            public string product_price { get; set; }
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
        }

        public class Hreflanghtmltag
        {
            public string tagName { get; set; }
            public Attributes1 attributes { get; set; }
            public string contents { get; set; }
        }

        public class Attributes1
        {
            public string rel { get; set; }
            public string href { get; set; }
            public string hreflang { get; set; }
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
            public string dma { get; set; }
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

        public class Topicsstore
        {
            public Data5 data { get; set; }
        }

        public class Data5
        {
            public _483 _483 { get; set; }
        }

        public class _483
        {
            public int topicId { get; set; }
            public string name { get; set; }
            public string topicNamespace { get; set; }
            public int type { get; set; }
            public int localeId { get; set; }
        }

        public class Browseresultsetstore
        {
            public Data6 data { get; set; }
        }

        public class Data6
        {
            public int totalCount { get; set; }
            public int selectedListStyle { get; set; }
            public int[] spaceIds { get; set; }
            public Pagination pagination { get; set; }
            public Selectedsortorder selectedSortOrder { get; set; }
            public Sortorder[] sortOrders { get; set; }
            public Injectableitems injectableItems { get; set; }
        }

        public class Pagination
        {
            public int currentPage { get; set; }
            public int rangeStart { get; set; }
            public int rangeEnd { get; set; }
            public int pageSize { get; set; }
            public int previousPageStart { get; set; }
            public int nextPageStart { get; set; }
            public int maxFromItem { get; set; }
            public int totalCount { get; set; }
            public int totalPages { get; set; }
        }

        public class Selectedsortorder
        {
            public string url { get; set; }
            public string label { get; set; }
            public int value { get; set; }
        }

        public class Injectableitems
        {
        }

        public class Sortorder
        {
            public string url { get; set; }
            public string label { get; set; }
            public int value { get; set; }
        }

        public class Productvariationsstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data7 data { get; set; }
        }

        public class Data7
        {
        }

        public class Browseproductreviewsstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data8 data { get; set; }
        }

        public class Data8
        {
            public _10518400 _10518400 { get; set; }
            public _12428837 _12428837 { get; set; }
            public _23215609 _23215609 { get; set; }
            public _35713516 _35713516 { get; set; }
            public _40269699 _40269699 { get; set; }
            public _40658740 _40658740 { get; set; }
            public _40659182 _40659182 { get; set; }
            public _52645103 _52645103 { get; set; }
            public _58181916 _58181916 { get; set; }
            public _123217207 _123217207 { get; set; }
        }

        public class _10518400
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

        public class _12428837
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

        public class _23215609
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

        public class _35713516
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

        public class _40269699
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

        public class _40658740
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

        public class _40659182
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

        public class _52645103
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

        public class _58181916
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

        public class _123217207
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

        public class Secondaryquerystore
        {
            public object[] prereqs { get; set; }
            public Data9 data { get; set; }
        }

        public class Data9
        {
            public object[] queries { get; set; }
        }

        public class Spaceshorttitlesstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data10 data { get; set; }
        }

        public class Data10
        {
        }

        public class Productadsstore
        {
            public Data11 data { get; set; }
        }

        public class Data11
        {
            public Sponsoredproducts sponsoredProducts { get; set; }
        }

        public class Sponsoredproducts
        {
            public Ad[] ads { get; set; }
            public string[] trackingPixels { get; set; }
        }

        public class Ad
        {
            public int campaignId { get; set; }
            public string vendorName { get; set; }
            public Product product { get; set; }
            public Listingprice listingPrice { get; set; }
            public Clicktrackurl clickTrackUrl { get; set; }
        }

        public class Product
        {
            public int id { get; set; }
            public string title { get; set; }
            public Image[] images { get; set; }
        }

        public class Image
        {
            public string externalId { get; set; }
            public string contentModified { get; set; }
        }

        public class Listingprice
        {
            public float currentPrice { get; set; }
            public string currency { get; set; }
            public float currentPriceTrade { get; set; }
        }

        public class Clicktrackurl
        {
            public string path { get; set; }
            public string method { get; set; }
            public string protocol { get; set; }
            public string domain { get; set; }
        }

        public class Queryrewritesuggestionstore
        {
            public Data12 data { get; set; }
        }

        public class Data12
        {
            public object[] suggestion { get; set; }
        }

        public class Relatedsearchstore
        {
            public Data13 data { get; set; }
        }

        public class Data13
        {
        }

        public class Newarrivalsstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data14 data { get; set; }
        }

        public class Data14
        {
            public Product1[] products { get; set; }
        }

        public class Product1
        {
            public int id { get; set; }
            public string title { get; set; }
            public string seoText { get; set; }
            public Image1[] images { get; set; }
            public bool isTradeExclusive { get; set; }
            public bool isBuyable { get; set; }
            public string currency { get; set; }
            public float basePrice { get; set; }
            public float currentPrice { get; set; }
            public float basePriceTrade { get; set; }
            public float previousPriceTrade { get; set; }
            public float currentPriceTrade { get; set; }
        }

        public class Image1
        {
            public int imageId { get; set; }
            public string externalId { get; set; }
            public string contentModified { get; set; }
        }

        public class Recentlyviewedproductsstore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data15 data { get; set; }
        }

        public class Data15
        {
        }

        public class Footerstore
        {
            public Data16 data { get; set; }
        }

        public class Data16
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
            public Business[] business { get; set; }
            public Help[] help { get; set; }
            public Connect[] connect { get; set; }
        }

        public class Company
        {
            public string id { get; set; }
            public string url { get; set; }
            public string[] ids { get; set; }
            public string[] urls { get; set; }
        }

        public class Business
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class Help
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
            public Data17 data { get; set; }
        }

        public class Data17
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
            public _2 _2 { get; set; }
            public _12 _12 { get; set; }
            public _20 _20 { get; set; }
            public _21 _21 { get; set; }
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
            public _211 _211 { get; set; }
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

        public class _2
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

        public class _21
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

        public class _211
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
            public Data18 data { get; set; }
        }

        public class Data18
        {
            public int TotalItemsCount { get; set; }
        }

        public class Headerstore
        {
            public Data19 data { get; set; }
        }

        public class Data19
        {
            public string secondaryMenuHtml { get; set; }
            public Headerpromoconfig headerPromoConfig { get; set; }
            public Promosale[] promoSales { get; set; }
            public bool isProfessionalsDirectoryOnJukwaa { get; set; }
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
            public Data20 data { get; set; }
        }

        public class Data20
        {
        }

        public class Navigationstore
        {
            public Data21 data { get; set; }
        }

        public class Data21
        {
            public Status status { get; set; }
            public Filter[] filters { get; set; }
            public Breadcrumbs breadcrumbs { get; set; }
            public Secondaryfilter[] secondaryFilters { get; set; }
            public Topic[] topics { get; set; }
            public Popularfilters popularFilters { get; set; }
            public Intrinsicfilter[] intrinsicFilters { get; set; }
            public Extrinsicfilter[] extrinsicFilters { get; set; }
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

        public class Popularfilters
        {
            public string filterName { get; set; }
            public string header { get; set; }
            public Option1[] options { get; set; }
            public bool collapsed { get; set; }
            public string expandOptionsLabel { get; set; }
            public int defaultFilterType { get; set; }
        }

        public class Option1
        {
            public string label { get; set; }
            public string url { get; set; }
            public bool selected { get; set; }
        }

        public class Filter
        {
            public string filterName { get; set; }
            public string header { get; set; }
            public Option2[] options { get; set; }
            public bool collapsed { get; set; }
            public string expandOptionsLabel { get; set; }
            public int defaultFilterType { get; set; }
            public string scopeId { get; set; }
            public int visibleOptionsCount { get; set; }
            public bool multipleChoice { get; set; }
            public string attributeId { get; set; }
        }

        public class Option2
        {
            public string label { get; set; }
            public string url { get; set; }
            public bool selected { get; set; }
            public int depth { get; set; }
            public int thumbSpaceId { get; set; }
            public string objId { get; set; }
            public int count { get; set; }
            public bool noFollow { get; set; }
            public string urlTemplate { get; set; }
        }

        public class Secondaryfilter
        {
            public string filterName { get; set; }
            public string header { get; set; }
            public Option3[] options { get; set; }
            public string scopeId { get; set; }
            public bool collapsed { get; set; }
            public int visibleOptionsCount { get; set; }
            public string expandOptionsLabel { get; set; }
            public int defaultFilterType { get; set; }
            public bool multipleChoice { get; set; }
            public string attributeId { get; set; }
        }

        public class Option3
        {
            public string label { get; set; }
            public string url { get; set; }
            public string objId { get; set; }
            public int count { get; set; }
            public bool noFollow { get; set; }
            public bool selected { get; set; }
        }

        public class Topic
        {
            public int topicId { get; set; }
            public string name { get; set; }
            public string topicNamespace { get; set; }
            public int type { get; set; }
            public int localeId { get; set; }
        }

        public class Intrinsicfilter
        {
            public string filterName { get; set; }
            public string header { get; set; }
            public Option4[] options { get; set; }
            public string scopeId { get; set; }
            public bool collapsed { get; set; }
            public int defaultFilterType { get; set; }
            public int visibleOptionsCount { get; set; }
            public string expandOptionsLabel { get; set; }
            public bool multipleChoice { get; set; }
            public string attributeId { get; set; }
        }

        public class Option4
        {
            public string label { get; set; }
            public string url { get; set; }
            public bool selected { get; set; }
            public string objId { get; set; }
            public bool noFollow { get; set; }
            public string urlTemplate { get; set; }
            public int count { get; set; }
        }

        public class Extrinsicfilter
        {
            public string filterName { get; set; }
            public string header { get; set; }
            public Option5[] options { get; set; }
            public string scopeId { get; set; }
            public bool collapsed { get; set; }
            public int visibleOptionsCount { get; set; }
            public string expandOptionsLabel { get; set; }
            public int defaultFilterType { get; set; }
            public bool multipleChoice { get; set; }
            public string attributeId { get; set; }
        }

        public class Option5
        {
            public string label { get; set; }
            public string url { get; set; }
            public bool selected { get; set; }
            public string objId { get; set; }
            public int count { get; set; }
            public bool noFollow { get; set; }
        }

        public class Spacestore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data22 data { get; set; }
        }

        public class Data22
        {
            public _105184001 _10518400 { get; set; }
            public _10518403 _10518403 { get; set; }
            public _11645725 _11645725 { get; set; }
            public _124288371 _12428837 { get; set; }
            public _15468502 _15468502 { get; set; }
            public _16804698 _16804698 { get; set; }
            public _232156091 _23215609 { get; set; }
            public _23215633 _23215633 { get; set; }
            public _34288473 _34288473 { get; set; }
            public _34660121 _34660121 { get; set; }
            public _357135161 _35713516 { get; set; }
            public _402696991 _40269699 { get; set; }
            public _406587401 _40658740 { get; set; }
            public _406591821 _40659182 { get; set; }
            public _526451031 _52645103 { get; set; }
            public _54367690 _54367690 { get; set; }
            public _55200581 _55200581 { get; set; }
            public _581819161 _58181916 { get; set; }
            public _61789548 _61789548 { get; set; }
            public _61902165 _61902165 { get; set; }
            public _72241009 _72241009 { get; set; }
            public _77277174 _77277174 { get; set; }
            public _78761938 _78761938 { get; set; }
            public _86686605 _86686605 { get; set; }
            public _90531953 _90531953 { get; set; }
            public _96765466 _96765466 { get; set; }
            public _96772012 _96772012 { get; set; }
            public _96773211 _96773211 { get; set; }
            public _96773467 _96773467 { get; set; }
            public _98525752 _98525752 { get; set; }
            public _108671322 _108671322 { get; set; }
            public _109428893 _109428893 { get; set; }
            public _111423207 _111423207 { get; set; }
            public _111423317 _111423317 { get; set; }
            public _114868520 _114868520 { get; set; }
            public _117286369 _117286369 { get; set; }
            public _118173447 _118173447 { get; set; }
            public _120958952 _120958952 { get; set; }
            public _1232172071 _123217207 { get; set; }
            public _123271021 _123271021 { get; set; }
            public _123940593 _123940593 { get; set; }
            public _124534474 _124534474 { get; set; }
        }

        public class _105184001
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _10518403
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _11645725
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _124288371
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _15468502
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _16804698
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _232156091
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _23215633
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _34288473
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _34660121
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _357135161
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _402696991
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _406587401
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _406591821
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _526451031
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _54367690
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _55200581
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _581819161
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _61789548
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _61902165
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _72241009
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _77277174
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _78761938
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _86686605
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _90531953
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _96765466
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _96772012
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _96773211
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _96773467
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _98525752
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _108671322
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _109428893
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _111423207
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _111423317
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _114868520
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _117286369
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _118173447
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _120958952
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _1232172071
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _123271021
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _123940593
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class _124534474
        {
            public int id { get; set; }
            public int type { get; set; }
            public int ownerId { get; set; }
            public int authorId { get; set; }
            public int projectId { get; set; }
            public int categoryId { get; set; }
            public string created { get; set; }
            public string modified { get; set; }
            public int status { get; set; }
            public string url { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public int style { get; set; }
            public bool isProduct { get; set; }
            public bool isFeatured { get; set; }
            public bool isFile { get; set; }
            public bool canChangeSpaceAuthor { get; set; }
            public int sourceType { get; set; }
            public int permissionMask { get; set; }
            public string[] imageIds { get; set; }
        }

        public class Imagestore
        {
            public string name { get; set; }
            public object[] prereqs { get; set; }
            public Data23 data { get; set; }
        }

        public class Data23
        {
            public _605180B0036d0c48 _605180b0036d0c48 { get; set; }
            public C4518cd909efa02b c4518cd909efa02b { get; set; }
            public _8351Fbf50970e984 _8351fbf50970e984 { get; set; }
            public _22319D7c07433eb0 _22319d7c07433eb0 { get; set; }
            public Ec01f84006731ccf ec01f84006731ccf { get; set; }
            public _7B21823d08f3962d _7b21823d08f3962d { get; set; }
            public Ac41664e0b32c284 ac41664e0b32c284 { get; set; }
            public _2Cc114900970e97f _2cc114900970e97f { get; set; }
            public Edc19dba03ad188a edc19dba03ad188a { get; set; }
            public _8B817bf3061314b1 _8b817bf3061314b1 { get; set; }
            public _9F139bae0dcc40b9 _9f139bae0dcc40b9 { get; set; }
            public C043482c0eeb7d56 c043482c0eeb7d56 { get; set; }
            public _27A355190ff364d9 _27a355190ff364d9 { get; set; }
            public _7323Bd2901c9a091 _7323bd2901c9a091 { get; set; }
            public _1E330d0402e174a2 _1e330d0402e174a2 { get; set; }
            public _58636Eaf03273af4 _58636eaf03273af4 { get; set; }
            public _1Ea3c09d0344827a _1ea3c09d0344827a { get; set; }
            public F943d8f20366d474 f943d8f20366d474 { get; set; }
            public Dd23b2fc03b5e8c1 dd23b2fc03b5e8c1 { get; set; }
            public C183356a046223eb c183356a046223eb { get; set; }
            public _4253361C049dba59 _4253361c049dba59 { get; set; }
            public D6538535058997b8 d6538535058997b8 { get; set; }
            public C8d351cb05b3106f c8d351cb05b3106f { get; set; }
            public _17532B6c06e5f35b _17532b6c06e5f35b { get; set; }
            public _2471112C03355154 _2471112c03355154 { get; set; }
            public _56811Eb703355170 _56811eb703355170 { get; set; }
            public C921dc1d08d17db3 c921dc1d08d17db3 { get; set; }
            public _830162Ad0b048cf4 _830162ad0b048cf4 { get; set; }
            public _7A1175760970e955 _7a1175760970e955 { get; set; }
            public _8C719a010a31a2a4 _8c719a010a31a2a4 { get; set; }
            public _406179D405524356 _406179d405524356 { get; set; }
            public C2e1101d059da460 c2e1101d059da460 { get; set; }
            public C1e1ded90602d581 c1e1ded90602d581 { get; set; }
            public _6B41257c060add5c _6b41257c060add5c { get; set; }
            public _29614A8e060addfa _29614a8e060addfa { get; set; }
            public _3B014a2208012dba _3b014a2208012dba { get; set; }
            public _1981159707449B7d _1981159707449b7d { get; set; }
            public Cf61daad09ef9a23 cf61daad09ef9a23 { get; set; }
            public _0E614d6b0ace51d6 _0e614d6b0ace51d6 { get; set; }
            public Cc51e90e0b32c4ed cc51e90e0b32c4ed { get; set; }
            public _7F71837e095c9752 _7f71837e095c9752 { get; set; }
            public _4Ef1909003ea6bde _4ef1909003ea6bde { get; set; }
            public _1071086208B6edff _1071086208b6edff { get; set; }
            public _5E31b6dd096fcdbd _5e31b6dd096fcdbd { get; set; }
            public _93B1575b096e3f05 _93b1575b096e3f05 { get; set; }
            public _4351Eae3096fd741 _4351eae3096fd741 { get; set; }
            public F8319674096e405c f8319674096e405c { get; set; }
            public _01D1fc3d08daac59 _01d1fc3d08daac59 { get; set; }
            public B651d78f0a45940c b651d78f0a45940c { get; set; }
            public Bc71db710b4748e6 bc71db710b4748e6 { get; set; }
            public _11616Fa7099b4dc7 _11616fa7099b4dc7 { get; set; }
            public _38619C6f0aaab2a0 _38619c6f0aaab2a0 { get; set; }
            public Afb1d04b0ad777e6 afb1d04b0ad777e6 { get; set; }
            public _76A145570ae77b26 _76a145570ae77b26 { get; set; }
            public F081d4b4099b4dd1 f081d4b4099b4dd1 { get; set; }
            public _0Af180b80b4620af _0af180b80b4620af { get; set; }
            public _06A19f490b47ca93 _06a19f490b47ca93 { get; set; }
            public Eee126f00b55e549 eee126f00b55e549 { get; set; }
            public E5216fbc0b60ec87 e5216fbc0b60ec87 { get; set; }
            public _11F1398e0df915ce _11f1398e0df915ce { get; set; }
            public F33101240f1b2161 f33101240f1b2161 { get; set; }
            public Ee01a86e0f9ff83e ee01a86e0f9ff83e { get; set; }
            public B401ea540fd654ac b401ea540fd654ac { get; set; }
            public _431160C101185bda _431160c101185bda { get; set; }
            public E4b1caff01191478 e4b1caff01191478 { get; set; }
            public Ac91cb7601364d23 ac91cb7601364d23 { get; set; }
            public D63136d801eda30a d63136d801eda30a { get; set; }
            public Ec11e47202177354 ec11e47202177354 { get; set; }
            public B331150802e18640 b331150802e18640 { get; set; }
            public _12417Eb502e1af71 _12417eb502e1af71 { get; set; }
            public _26C190d1030cefe6 _26c190d1030cefe6 { get; set; }
            public _44219932031F8f91 _44219932031f8f91 { get; set; }
            public _1Aa16e9403694f84 _1aa16e9403694f84 { get; set; }
            public Dff1a400036bc8c8 dff1a400036bc8c8 { get; set; }
            public _4Be17b95038f3957 _4be17b95038f3957 { get; set; }
            public Ec11e14803903da0 ec11e14803903da0 { get; set; }
            public _76C1988203a186f6 _76c1988203a186f6 { get; set; }
            public _9C51568a03aa21e8 _9c51568a03aa21e8 { get; set; }
            public Fda19e8e0404689d fda19e8e0404689d { get; set; }
            public Bbd1f1af0bc50bb0 bbd1f1af0bc50bb0 { get; set; }
            public E1e1b55f04927007 e1e1b55f04927007 { get; set; }
            public _72D1a9300970e951 _72d1a9300970e951 { get; set; }
            public _7D6176940579d373 _7d6176940579d373 { get; set; }
            public _2281548F0543b29b _2281548f0543b29b { get; set; }
            public _6F41fd240581b14a _6f41fd240581b14a { get; set; }
            public _1De11974061bfdf5 _1de11974061bfdf5 { get; set; }
            public _01415Fed0583236d _01415fed0583236d { get; set; }
            public _4E21795d058b22e3 _4e21795d058b22e3 { get; set; }
            public Fa71b7e7058dddfe fa71b7e7058dddfe { get; set; }
            public _1111A502096fc5cd _1111a502096fc5cd { get; set; }
            public Ade1ad6e05dcc9ae ade1ad6e05dcc9ae { get; set; }
            public _1961314B0602d572 _1961314b0602d572 { get; set; }
            public _8Fc17a080549f6ce _8fc17a080549f6ce { get; set; }
            public F3c12f0a064f7e96 f3c12f0a064f7e96 { get; set; }
            public Eb41ac360922f87a eb41ac360922f87a { get; set; }
            public _5241Abba06e83eef _5241abba06e83eef { get; set; }
            public _6E61ec73070d1a38 _6e61ec73070d1a38 { get; set; }
            public _7591592B0789548f _7591592b0789548f { get; set; }
            public _62A1172d07c5bc69 _62a1172d07c5bc69 { get; set; }
            public C531ab32081fa898 c531ab32081fa898 { get; set; }
            public Eac1be960845fb58 eac1be960845fb58 { get; set; }
            public _58018D2708543322 _58018d2708543322 { get; set; }
            public _3601E2ce0859e730 _3601e2ce0859e730 { get; set; }
            public C1c1e53609145a04 c1c1e53609145a04 { get; set; }
            public Cc313599096fcdba cc313599096fcdba { get; set; }
            public _7061A695096fd73a _7061a695096fd73a { get; set; }
            public _9Ed1e3ba096e4056 _9ed1e3ba096e4056 { get; set; }
            public _19F1494d0a2ae240 _19f1494d0a2ae240 { get; set; }
            public _6C6152950a4d6150 _6c6152950a4d6150 { get; set; }
            public _1321D85b0a74e95a _1321d85b0a74e95a { get; set; }
            public _5F715b0d0abab7c6 _5f715b0d0abab7c6 { get; set; }
            public _04C1fe090ababec4 _04c1fe090ababec4 { get; set; }
            public _4091A4fb0afcba38 _4091a4fb0afcba38 { get; set; }
            public _90017F560b048cde _90017f560b048cde { get; set; }
            public Da31722c0b0efd9a da31722c0b0efd9a { get; set; }
            public _9C11de4d0b579842 _9c11de4d0b579842 { get; set; }
            public _89030F850f6c8117 _89030f850f6c8117 { get; set; }
            public _34236A7f0fc66cf6 _34236a7f0fc66cf6 { get; set; }
            public _40E355ca0fd0f26d _40e355ca0fd0f26d { get; set; }
            public _1Bb3dea200a157e1 _1bb3dea200a157e1 { get; set; }
            public _0Af3b95901102512 _0af3b95901102512 { get; set; }
            public _43A3c42901efda18 _43a3c42901efda18 { get; set; }
            public C9232bb6021770ba c9232bb6021770ba { get; set; }
            public _4383473D023c90f7 _4383473d023c90f7 { get; set; }
            public _99C3136502a222bc _99c3136502a222bc { get; set; }
            public Bd83d83e0300baa2 bd83d83e0300baa2 { get; set; }
            public _29A3afe303863696 _29a3afe303863696 { get; set; }
            public _9A439ae60392001b _9a439ae60392001b { get; set; }
            public _1703414F03a0a05a _1703414f03a0a05a { get; set; }
            public _1F93d1d6046cbfa9 _1f93d1d6046cbfa9 { get; set; }
            public _44B3ec4305423a9e _44b3ec4305423a9e { get; set; }
            public B763e87405af40dc b763e87405af40dc { get; set; }
            public _81430Dcc061fccb5 _81430dcc061fccb5 { get; set; }
            public _33B3aa7e062fa049 _33b3aa7e062fa049 { get; set; }
            public Eba3d4950630ed8f eba3d4950630ed8f { get; set; }
            public _5Aa3c93106b27ba0 _5aa3c93106b27ba0 { get; set; }
            public _7273761806F594a5 _7273761806f594a5 { get; set; }
            public _6F2344db0756c746 _6f2344db0756c746 { get; set; }
            public _02D38948078f8d92 _02d38948078f8d92 { get; set; }
            public F853e80807d7e770 f853e80807d7e770 { get; set; }
            public _8E23e4a107f79310 _8e23e4a107f79310 { get; set; }
            public Db03eaf0080ccf93 db03eaf0080ccf93 { get; set; }
            public Ba53501608542a62 ba53501608542a62 { get; set; }
            public Ee33119a087d091d ee33119a087d091d { get; set; }
            public _78B3a8b308989a1e _78b3a8b308989a1e { get; set; }
            public D9c34bc408b47c21 d9c34bc408b47c21 { get; set; }
            public _4B3345c4090aec45 _4b3345c4090aec45 { get; set; }
            public _2B83f8a30989eebe _2b83f8a30989eebe { get; set; }
            public Fb23de720a4e452a fb23de720a4e452a { get; set; }
        }

        public class _605180B0036d0c48
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

        public class C4518cd909efa02b
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

        public class _8351Fbf50970e984
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

        public class _22319D7c07433eb0
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

        public class Ec01f84006731ccf
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

        public class _7B21823d08f3962d
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

        public class Ac41664e0b32c284
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

        public class _2Cc114900970e97f
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

        public class Edc19dba03ad188a
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

        public class _8B817bf3061314b1
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

        public class _9F139bae0dcc40b9
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

        public class C043482c0eeb7d56
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

        public class _27A355190ff364d9
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

        public class _7323Bd2901c9a091
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

        public class _1E330d0402e174a2
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

        public class _58636Eaf03273af4
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

        public class _1Ea3c09d0344827a
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

        public class F943d8f20366d474
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

        public class Dd23b2fc03b5e8c1
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

        public class C183356a046223eb
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

        public class _4253361C049dba59
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

        public class D6538535058997b8
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

        public class C8d351cb05b3106f
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

        public class _17532B6c06e5f35b
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

        public class _2471112C03355154
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

        public class _56811Eb703355170
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

        public class C921dc1d08d17db3
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

        public class _830162Ad0b048cf4
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

        public class _7A1175760970e955
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

        public class _8C719a010a31a2a4
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

        public class _406179D405524356
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

        public class C2e1101d059da460
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

        public class C1e1ded90602d581
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

        public class _6B41257c060add5c
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

        public class _29614A8e060addfa
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

        public class _3B014a2208012dba
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

        public class _1981159707449B7d
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

        public class Cf61daad09ef9a23
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

        public class _0E614d6b0ace51d6
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

        public class Cc51e90e0b32c4ed
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

        public class _7F71837e095c9752
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

        public class _4Ef1909003ea6bde
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

        public class _1071086208B6edff
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

        public class _5E31b6dd096fcdbd
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

        public class _93B1575b096e3f05
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

        public class _4351Eae3096fd741
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

        public class F8319674096e405c
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

        public class _01D1fc3d08daac59
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

        public class B651d78f0a45940c
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

        public class Bc71db710b4748e6
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

        public class _11616Fa7099b4dc7
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

        public class _38619C6f0aaab2a0
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

        public class Afb1d04b0ad777e6
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

        public class _76A145570ae77b26
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

        public class F081d4b4099b4dd1
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

        public class _0Af180b80b4620af
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

        public class _06A19f490b47ca93
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

        public class Eee126f00b55e549
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

        public class E5216fbc0b60ec87
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

        public class _11F1398e0df915ce
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

        public class F33101240f1b2161
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

        public class Ee01a86e0f9ff83e
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

        public class B401ea540fd654ac
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

        public class _431160C101185bda
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

        public class E4b1caff01191478
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

        public class Ac91cb7601364d23
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

        public class D63136d801eda30a
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

        public class Ec11e47202177354
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

        public class B331150802e18640
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

        public class _12417Eb502e1af71
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

        public class _26C190d1030cefe6
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

        public class _44219932031F8f91
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

        public class _1Aa16e9403694f84
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

        public class Dff1a400036bc8c8
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

        public class _4Be17b95038f3957
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

        public class Ec11e14803903da0
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

        public class _76C1988203a186f6
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

        public class _9C51568a03aa21e8
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

        public class Fda19e8e0404689d
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

        public class Bbd1f1af0bc50bb0
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

        public class E1e1b55f04927007
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

        public class _72D1a9300970e951
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

        public class _7D6176940579d373
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

        public class _2281548F0543b29b
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

        public class _6F41fd240581b14a
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

        public class _1De11974061bfdf5
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

        public class _01415Fed0583236d
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

        public class _4E21795d058b22e3
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

        public class Fa71b7e7058dddfe
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

        public class _1111A502096fc5cd
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

        public class Ade1ad6e05dcc9ae
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

        public class _1961314B0602d572
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

        public class _8Fc17a080549f6ce
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

        public class F3c12f0a064f7e96
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

        public class Eb41ac360922f87a
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

        public class _5241Abba06e83eef
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

        public class _6E61ec73070d1a38
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

        public class _7591592B0789548f
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

        public class _62A1172d07c5bc69
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

        public class C531ab32081fa898
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

        public class Eac1be960845fb58
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

        public class _58018D2708543322
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

        public class _3601E2ce0859e730
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

        public class C1c1e53609145a04
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

        public class Cc313599096fcdba
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

        public class _7061A695096fd73a
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

        public class _9Ed1e3ba096e4056
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

        public class _19F1494d0a2ae240
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

        public class _6C6152950a4d6150
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

        public class _1321D85b0a74e95a
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

        public class _5F715b0d0abab7c6
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

        public class _04C1fe090ababec4
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

        public class _4091A4fb0afcba38
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

        public class _90017F560b048cde
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

        public class Da31722c0b0efd9a
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

        public class _9C11de4d0b579842
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

        public class _89030F850f6c8117
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

        public class _34236A7f0fc66cf6
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

        public class _40E355ca0fd0f26d
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

        public class _1Bb3dea200a157e1
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

        public class _0Af3b95901102512
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

        public class _43A3c42901efda18
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

        public class C9232bb6021770ba
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

        public class _4383473D023c90f7
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

        public class _99C3136502a222bc
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

        public class Bd83d83e0300baa2
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

        public class _29A3afe303863696
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

        public class _9A439ae60392001b
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

        public class _1703414F03a0a05a
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

        public class _1F93d1d6046cbfa9
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

        public class _44B3ec4305423a9e
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

        public class B763e87405af40dc
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

        public class _81430Dcc061fccb5
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

        public class _33B3aa7e062fa049
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

        public class Eba3d4950630ed8f
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

        public class _5Aa3c93106b27ba0
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

        public class _7273761806F594a5
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

        public class _6F2344db0756c746
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

        public class _02D38948078f8d92
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

        public class F853e80807d7e770
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

        public class _8E23e4a107f79310
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

        public class Db03eaf0080ccf93
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

        public class Ba53501608542a62
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

        public class Ee33119a087d091d
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

        public class _78B3a8b308989a1e
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

        public class D9c34bc408b47c21
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

        public class _4B3345c4090aec45
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

        public class _2B83f8a30989eebe
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

        public class Fb23de720a4e452a
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
            public _252450 _252450 { get; set; }
            public _562394 _562394 { get; set; }
            public _563652 _563652 { get; set; }
            public _563698 _563698 { get; set; }
            public _639901 _639901 { get; set; }
            public _945398 _945398 { get; set; }
            public _1336705 _1336705 { get; set; }
            public _1400218 _1400218 { get; set; }
            public _1853179 _1853179 { get; set; }
            public _1913883 _1913883 { get; set; }
            public _2165488 _2165488 { get; set; }
            public _3867117 _3867117 { get; set; }
            public _7962728 _7962728 { get; set; }
            public _9088331 _9088331 { get; set; }
            public _9239856 _9239856 { get; set; }
            public _9588375 _9588375 { get; set; }
            public _9765101 _9765101 { get; set; }
            public _12847683 _12847683 { get; set; }
            public _12890535 _12890535 { get; set; }
            public _13473984 _13473984 { get; set; }
            public _13917330 _13917330 { get; set; }
            public _13919635 _13919635 { get; set; }
            public _14444688 _14444688 { get; set; }
            public _14834252 _14834252 { get; set; }
            public _14949931 _14949931 { get; set; }
            public _15135136 _15135136 { get; set; }
            public _15207674 _15207674 { get; set; }
            public _16701586 _16701586 { get; set; }
            public _18241188 _18241188 { get; set; }
            public _18409608 _18409608 { get; set; }
            public _18433748 _18433748 { get; set; }
            public _19202694 _19202694 { get; set; }
            public _20172696 _20172696 { get; set; }
            public _24243213 _24243213 { get; set; }
            public _25602936 _25602936 { get; set; }
            public _26315222 _26315222 { get; set; }
            public _26372019 _26372019 { get; set; }
            public _27349219 _27349219 { get; set; }
            public _28296519 _28296519 { get; set; }
            public _28329790 _28329790 { get; set; }
            public _29046746 _29046746 { get; set; }
            public _29595624 _29595624 { get; set; }
            public _31157566 _31157566 { get; set; }
            public _32072102 _32072102 { get; set; }
            public _35319508 _35319508 { get; set; }
            public _35906469 _35906469 { get; set; }
            public _36265941 _36265941 { get; set; }
            public _37497342 _37497342 { get; set; }
            public _40892931 _40892931 { get; set; }
            public _47606081 _47606081 { get; set; }
            public _52422827 _52422827 { get; set; }
        }

        public class _252450
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

        public class _562394
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
            public Vendorinfo vendorInfo { get; set; }
        }

        public class Roles1
        {
        }

        public class Vendorinfo
        {
        }

        public class _563652
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
            public Vendorinfo1 vendorInfo { get; set; }
        }

        public class Roles2
        {
        }

        public class Vendorinfo1
        {
        }

        public class _563698
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
            public Roles3 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles3
        {
        }

        public class _639901
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
            public Vendorinfo2 vendorInfo { get; set; }
        }

        public class Roles4
        {
        }

        public class Vendorinfo2
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
            public Roles5 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles5
        {
        }

        public class _1336705
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
            public Vendorinfo3 vendorInfo { get; set; }
        }

        public class Roles6
        {
        }

        public class Vendorinfo3
        {
        }

        public class _1400218
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

        public class _1853179
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
            public Vendorinfo4 vendorInfo { get; set; }
        }

        public class Roles8
        {
        }

        public class Vendorinfo4
        {
        }

        public class _1913883
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
            public Vendorinfo5 vendorInfo { get; set; }
        }

        public class Roles9
        {
        }

        public class Vendorinfo5
        {
        }

        public class _2165488
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
            public Vendorinfo6 vendorInfo { get; set; }
        }

        public class Roles10
        {
        }

        public class Vendorinfo6
        {
        }

        public class _3867117
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
            public Vendorinfo7 vendorInfo { get; set; }
        }

        public class Roles11
        {
        }

        public class Vendorinfo7
        {
        }

        public class _7962728
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
            public Vendorinfo8 vendorInfo { get; set; }
        }

        public class Roles12
        {
        }

        public class Vendorinfo8
        {
        }

        public class _9088331
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
            public Vendorinfo9 vendorInfo { get; set; }
        }

        public class Roles13
        {
        }

        public class Vendorinfo9
        {
            public string warehouseCountry { get; set; }
        }

        public class _9239856
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
            public Vendorinfo10 vendorInfo { get; set; }
        }

        public class Roles14
        {
        }

        public class Vendorinfo10
        {
        }

        public class _9588375
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

        public class _9765101
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
            public Vendorinfo11 vendorInfo { get; set; }
        }

        public class Roles16
        {
        }

        public class Vendorinfo11
        {
        }

        public class _12847683
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
            public Vendorinfo12 vendorInfo { get; set; }
        }

        public class Roles17
        {
        }

        public class Vendorinfo12
        {
        }

        public class _12890535
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
            public Vendorinfo13 vendorInfo { get; set; }
        }

        public class Roles18
        {
        }

        public class Vendorinfo13
        {
        }

        public class _13473984
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

        public class _13917330
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
            public Vendorinfo14 vendorInfo { get; set; }
        }

        public class Roles20
        {
        }

        public class Vendorinfo14
        {
            public string warehouseCountry { get; set; }
        }

        public class _13919635
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
            public Roles21 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles21
        {
        }

        public class _14444688
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
            public Roles22 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo15 vendorInfo { get; set; }
        }

        public class Roles22
        {
        }

        public class Vendorinfo15
        {
            public string warehouseCountry { get; set; }
        }

        public class _14834252
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
            public Roles23 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo16 vendorInfo { get; set; }
        }

        public class Roles23
        {
        }

        public class Vendorinfo16
        {
        }

        public class _14949931
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
            public Roles24 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo17 vendorInfo { get; set; }
        }

        public class Roles24
        {
        }

        public class Vendorinfo17
        {
        }

        public class _15135136
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
            public Roles25 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles25
        {
        }

        public class _15207674
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
            public Roles26 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo18 vendorInfo { get; set; }
        }

        public class Roles26
        {
        }

        public class Vendorinfo18
        {
        }

        public class _16701586
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
            public Roles27 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo19 vendorInfo { get; set; }
        }

        public class Roles27
        {
        }

        public class Vendorinfo19
        {
        }

        public class _18241188
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
            public Roles28 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Tradeuser
        {
            public int type { get; set; }
            public int status { get; set; }
            public int proType { get; set; }
        }

        public class Roles28
        {
        }

        public class _18409608
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
            public Roles29 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo20 vendorInfo { get; set; }
        }

        public class Roles29
        {
        }

        public class Vendorinfo20
        {
        }

        public class _18433748
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
            public Roles30 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo21 vendorInfo { get; set; }
        }

        public class Roles30
        {
        }

        public class Vendorinfo21
        {
            public string warehouseCountry { get; set; }
        }

        public class _19202694
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
            public Roles31 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo22 vendorInfo { get; set; }
        }

        public class Roles31
        {
        }

        public class Vendorinfo22
        {
        }

        public class _20172696
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
            public Roles32 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo23 vendorInfo { get; set; }
        }

        public class Roles32
        {
        }

        public class Vendorinfo23
        {
        }

        public class _24243213
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
            public Roles33 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo24 vendorInfo { get; set; }
        }

        public class Roles33
        {
        }

        public class Vendorinfo24
        {
        }

        public class _25602936
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
            public Roles34 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles34
        {
        }

        public class _26315222
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
            public Roles35 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles35
        {
        }

        public class _26372019
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
            public Roles36 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles36
        {
        }

        public class _27349219
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
            public Roles37 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo25 vendorInfo { get; set; }
        }

        public class Roles37
        {
        }

        public class Vendorinfo25
        {
            public string warehouseCountry { get; set; }
        }

        public class _28296519
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
            public Roles38 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo26 vendorInfo { get; set; }
        }

        public class Roles38
        {
        }

        public class Vendorinfo26
        {
            public string warehouseCountry { get; set; }
        }

        public class _28329790
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
            public Roles39 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo27 vendorInfo { get; set; }
        }

        public class Roles39
        {
        }

        public class Vendorinfo27
        {
        }

        public class _29046746
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
            public Roles40 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo28 vendorInfo { get; set; }
        }

        public class Roles40
        {
        }

        public class Vendorinfo28
        {
            public string warehouseCountry { get; set; }
        }

        public class _29595624
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
            public Roles41 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo29 vendorInfo { get; set; }
        }

        public class Roles41
        {
        }

        public class Vendorinfo29
        {
            public string warehouseCountry { get; set; }
        }

        public class _31157566
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
            public Roles42 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles42
        {
        }

        public class _32072102
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
            public Roles43 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo30 vendorInfo { get; set; }
        }

        public class Roles43
        {
        }

        public class Vendorinfo30
        {
            public string warehouseCountry { get; set; }
        }

        public class _35319508
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
            public Roles44 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo31 vendorInfo { get; set; }
        }

        public class Roles44
        {
        }

        public class Vendorinfo31
        {
        }

        public class _35906469
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
            public Roles45 roles { get; set; }
            public string contactName { get; set; }
        }

        public class Roles45
        {
        }

        public class _36265941
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
            public Roles46 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo32 vendorInfo { get; set; }
        }

        public class Roles46
        {
        }

        public class Vendorinfo32
        {
            public string warehouseCountry { get; set; }
        }

        public class _37497342
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
            public Roles47 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo33 vendorInfo { get; set; }
        }

        public class Roles47
        {
        }

        public class Vendorinfo33
        {
        }

        public class _40892931
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
            public Roles48 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo34 vendorInfo { get; set; }
        }

        public class Roles48
        {
        }

        public class Vendorinfo34
        {
        }

        public class _47606081
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
            public Roles49 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo35 vendorInfo { get; set; }
        }

        public class Roles49
        {
        }

        public class Vendorinfo35
        {
        }

        public class _52422827
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
            public Roles50 roles { get; set; }
            public string contactName { get; set; }
            public Vendorinfo36 vendorInfo { get; set; }
        }

        public class Roles50
        {
        }

        public class Vendorinfo36
        {
            public string warehouseCountry { get; set; }
        }

        public class Professionalstore
        {
            public Data25 data { get; set; }
        }

        public class Data25
        {
            public _2524501 _252450 { get; set; }
            public _5623941 _562394 { get; set; }
            public _5636521 _563652 { get; set; }
            public _5636981 _563698 { get; set; }
            public _6399011 _639901 { get; set; }
            public _13367051 _1336705 { get; set; }
            public _14002181 _1400218 { get; set; }
            public _18531791 _1853179 { get; set; }
            public _19138831 _1913883 { get; set; }
            public _21654881 _2165488 { get; set; }
            public _38671171 _3867117 { get; set; }
            public _79627281 _7962728 { get; set; }
            public _90883311 _9088331 { get; set; }
            public _92398561 _9239856 { get; set; }
            public _95883751 _9588375 { get; set; }
            public _97651011 _9765101 { get; set; }
            public _128476831 _12847683 { get; set; }
            public _128905351 _12890535 { get; set; }
            public _134739841 _13473984 { get; set; }
            public _139173301 _13917330 { get; set; }
            public _139196351 _13919635 { get; set; }
            public _144446881 _14444688 { get; set; }
            public _148342521 _14834252 { get; set; }
            public _149499311 _14949931 { get; set; }
            public _151351361 _15135136 { get; set; }
            public _152076741 _15207674 { get; set; }
            public _167015861 _16701586 { get; set; }
            public _182411881 _18241188 { get; set; }
            public _184096081 _18409608 { get; set; }
            public _184337481 _18433748 { get; set; }
            public _192026941 _19202694 { get; set; }
            public _201726961 _20172696 { get; set; }
            public _242432131 _24243213 { get; set; }
            public _256029361 _25602936 { get; set; }
            public _263152221 _26315222 { get; set; }
            public _263720191 _26372019 { get; set; }
            public _273492191 _27349219 { get; set; }
            public _282965191 _28296519 { get; set; }
            public _283297901 _28329790 { get; set; }
            public _290467461 _29046746 { get; set; }
            public _295956241 _29595624 { get; set; }
            public _311575661 _31157566 { get; set; }
            public _320721021 _32072102 { get; set; }
            public _353195081 _35319508 { get; set; }
            public _359064691 _35906469 { get; set; }
            public _362659411 _36265941 { get; set; }
            public _374973421 _37497342 { get; set; }
            public _408929311 _40892931 { get; set; }
            public _476060811 _47606081 { get; set; }
            public _524228271 _52422827 { get; set; }
        }

        public class _2524501
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
            public Attributes2 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes2
        {
            public string pt { get; set; }
        }

        public class _5623941
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
            public Attributes3 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes3
        {
            public string pt { get; set; }
        }

        public class _5636521
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
            public Attributes4 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes4
        {
            public string pt { get; set; }
        }

        public class _5636981
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
            public Attributes5 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes5
        {
            public string pt { get; set; }
        }

        public class _6399011
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
            public Attributes6 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes6
        {
            public string rci { get; set; }
            public string si { get; set; }
            public string mid { get; set; }
            public string fss { get; set; }
            public string fse { get; set; }
            public string sstmin { get; set; }
            public string sstmax { get; set; }
            public string estmin { get; set; }
            public string estmax { get; set; }
        }

        public class _13367051
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
            public Attributes7 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes7
        {
        }

        public class _14002181
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
            public Attributes8 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes8
        {
            public string pt { get; set; }
        }

        public class _18531791
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
            public Attributes9 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes9
        {
        }

        public class _19138831
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
            public Attributes10 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes10
        {
        }

        public class _21654881
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
            public Attributes11 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes11
        {
        }

        public class _38671171
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
            public Attributes12 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes12
        {
            public string pt { get; set; }
        }

        public class _79627281
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
            public Attributes13 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes13
        {
        }

        public class _90883311
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
            public Attributes14 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes14
        {
            public string pt { get; set; }
        }

        public class _92398561
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
            public Attributes15 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes15
        {
        }

        public class _95883751
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
            public Attributes16 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes16
        {
            public string pt { get; set; }
        }

        public class _97651011
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
            public Attributes17 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes17
        {
        }

        public class _128476831
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
            public Attributes18 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes18
        {
        }

        public class _128905351
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
            public Attributes19 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes19
        {
            public string pt { get; set; }
        }

        public class _134739841
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
            public Attributes20 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes20
        {
        }

        public class _139173301
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
            public Attributes21 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes21
        {
        }

        public class _139196351
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
            public Attributes22 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes22
        {
            public string pt { get; set; }
        }

        public class _144446881
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
            public Attributes23 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes23
        {
            public string pt { get; set; }
        }

        public class _148342521
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
            public Attributes24 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes24
        {
        }

        public class _149499311
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
            public Attributes25 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes25
        {
        }

        public class _151351361
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
            public Attributes26 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes26
        {
        }

        public class _152076741
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
            public Attributes27 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes27
        {
        }

        public class _167015861
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
            public Attributes28 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes28
        {
        }

        public class _182411881
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
            public Attributes29 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes29
        {
            public string itp { get; set; }
        }

        public class _184096081
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
            public Attributes30 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes30
        {
        }

        public class _184337481
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
            public Attributes31 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes31
        {
            public string pt { get; set; }
        }

        public class _192026941
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
            public Attributes32 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes32
        {
        }

        public class _201726961
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
            public Attributes33 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes33
        {
        }

        public class _242432131
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
            public Attributes34 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes34
        {
        }

        public class _256029361
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
            public Attributes35 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes35
        {
        }

        public class _263152221
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
            public Attributes36 attributes { get; set; }
            public object[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes36
        {
            public string pt { get; set; }
        }

        public class _263720191
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
            public Attributes37 attributes { get; set; }
            public object[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes37
        {
            public string pt { get; set; }
        }

        public class _273492191
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
            public Attributes38 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes38
        {
        }

        public class _282965191
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
            public Attributes39 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes39
        {
            public string pt { get; set; }
        }

        public class _283297901
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
            public Attributes40 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes40
        {
        }

        public class _290467461
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
            public Attributes41 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes41
        {
            public string pt { get; set; }
        }

        public class _295956241
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
            public Attributes42 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes42
        {
        }

        public class _311575661
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
            public Attributes43 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes43
        {
            public string cmtp { get; set; }
            public string pt { get; set; }
        }

        public class _320721021
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
            public Attributes44 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes44
        {
            public string pt { get; set; }
        }

        public class _353195081
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
            public Attributes45 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes45
        {
            public string cmtp { get; set; }
        }

        public class _359064691
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
            public Attributes46 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes46
        {
            public string cmtp { get; set; }
            public string pt { get; set; }
        }

        public class _362659411
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
            public Attributes47 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes47
        {
        }

        public class _374973421
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
            public Attributes48 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes48
        {
        }

        public class _408929311
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
            public Attributes49 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes49
        {
            public string cmtp { get; set; }
            public string pt { get; set; }
        }

        public class _476060811
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
            public Attributes50 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes50
        {
            public string cmtp { get; set; }
        }

        public class _524228271
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
            public Attributes51 attributes { get; set; }
            public int[] firstSpaceIds { get; set; }
            public string proTypeDisplayName { get; set; }
            public string formattedPhone { get; set; }
            public string address { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public int spaceCount { get; set; }
        }

        public class Attributes51
        {
            public string cmtp { get; set; }
        }

        public class Productinfostore
        {
            public Data26 data { get; set; }
        }

        public class Data26
        {
            public _105184002 _10518400 { get; set; }
            public _105184031 _10518403 { get; set; }
            public _116457251 _11645725 { get; set; }
            public _124288372 _12428837 { get; set; }
            public _154685021 _15468502 { get; set; }
            public _168046981 _16804698 { get; set; }
            public _232156092 _23215609 { get; set; }
            public _232156331 _23215633 { get; set; }
            public _342884731 _34288473 { get; set; }
            public _346601211 _34660121 { get; set; }
            public _357135162 _35713516 { get; set; }
            public _402696992 _40269699 { get; set; }
            public _406587402 _40658740 { get; set; }
            public _406591822 _40659182 { get; set; }
            public _526451032 _52645103 { get; set; }
            public _543676901 _54367690 { get; set; }
            public _552005811 _55200581 { get; set; }
            public _581819162 _58181916 { get; set; }
            public _617895481 _61789548 { get; set; }
            public _619021651 _61902165 { get; set; }
            public _722410091 _72241009 { get; set; }
            public _772771741 _77277174 { get; set; }
            public _787619381 _78761938 { get; set; }
            public _866866051 _86686605 { get; set; }
            public _905319531 _90531953 { get; set; }
            public _967654661 _96765466 { get; set; }
            public _967720121 _96772012 { get; set; }
            public _967732111 _96773211 { get; set; }
            public _967734671 _96773467 { get; set; }
            public _985257521 _98525752 { get; set; }
            public _1086713221 _108671322 { get; set; }
            public _1094288931 _109428893 { get; set; }
            public _1114232071 _111423207 { get; set; }
            public _1114233171 _111423317 { get; set; }
            public _1148685201 _114868520 { get; set; }
            public _1172863691 _117286369 { get; set; }
            public _1181734471 _118173447 { get; set; }
            public _1209589521 _120958952 { get; set; }
            public _1232172072 _123217207 { get; set; }
            public _1232710211 _123271021 { get; set; }
            public _1239405931 _123940593 { get; set; }
            public _1245344741 _124534474 { get; set; }
        }

        public class _105184002
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice basePrice { get; set; }
            public Finalprice finalPrice { get; set; }
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

        public class Baseprice
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Finalprice
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Productattributes
        {
            public W w { get; set; }
            public D d { get; set; }
            public H h { get; set; }
            public C c { get; set; }
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
        }

        public class H
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C
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

        public class _105184031
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice1 basePrice { get; set; }
            public Finalprice1 finalPrice { get; set; }
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
            public Productattributes1 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes1
        {
            public W1 w { get; set; }
            public D1 d { get; set; }
            public H1 h { get; set; }
            public C1 c { get; set; }
            public S1 s { get; set; }
            public Wt1 wt { get; set; }
            public M1 m { get; set; }
            public Ds1 ds { get; set; }
        }

        public class W1
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D1
        {
            public string name { get; set; }
        }

        public class H1
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C1
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S1
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt1
        {
            public string name { get; set; }
        }

        public class M1
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds1
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _116457251
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice2 basePrice { get; set; }
            public Finalprice2 finalPrice { get; set; }
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
            public Productattributes2 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes2
        {
            public W2 w { get; set; }
            public D2 d { get; set; }
            public H2 h { get; set; }
            public C2 c { get; set; }
            public S2 s { get; set; }
            public Wt2 wt { get; set; }
            public M2 m { get; set; }
            public Ds2 ds { get; set; }
        }

        public class W2
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D2
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H2
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C2
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S2
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt2
        {
            public string name { get; set; }
        }

        public class M2
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds2
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _124288372
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice3 basePrice { get; set; }
            public Finalprice3 finalPrice { get; set; }
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
            public Productattributes3 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes3
        {
            public W3 w { get; set; }
            public D3 d { get; set; }
            public H3 h { get; set; }
            public C3 c { get; set; }
            public S3 s { get; set; }
            public Wt3 wt { get; set; }
            public M3 m { get; set; }
            public Ds3 ds { get; set; }
        }

        public class W3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds3
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _154685021
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice4 basePrice { get; set; }
            public Finalprice4 finalPrice { get; set; }
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
            public Productattributes4 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes4
        {
            public W4 w { get; set; }
            public D4 d { get; set; }
            public H4 h { get; set; }
            public C4 c { get; set; }
            public S4 s { get; set; }
            public Wt4 wt { get; set; }
            public M4 m { get; set; }
            public Ds4 ds { get; set; }
        }

        public class W4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds4
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _168046981
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice5 basePrice { get; set; }
            public Finalprice5 finalPrice { get; set; }
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
            public Productattributes5 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes5
        {
            public W5 w { get; set; }
            public D5 d { get; set; }
            public H5 h { get; set; }
            public C5 c { get; set; }
            public S5 s { get; set; }
            public Wt5 wt { get; set; }
            public M5 m { get; set; }
            public Ds5 ds { get; set; }
        }

        public class W5
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D5
        {
            public string name { get; set; }
        }

        public class H5
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C5
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S5
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt5
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M5
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds5
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _232156092
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice6 basePrice { get; set; }
            public Finalprice6 finalPrice { get; set; }
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
            public Productattributes6 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes6
        {
            public W6 w { get; set; }
            public D6 d { get; set; }
            public H6 h { get; set; }
            public C6 c { get; set; }
            public S6 s { get; set; }
            public Wt6 wt { get; set; }
            public M6 m { get; set; }
            public Ds6 ds { get; set; }
        }

        public class W6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds6
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _232156331
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice7 basePrice { get; set; }
            public Finalprice7 finalPrice { get; set; }
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
            public Productattributes7 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes7
        {
            public W7 w { get; set; }
            public D7 d { get; set; }
            public H7 h { get; set; }
            public C7 c { get; set; }
            public S7 s { get; set; }
            public Wt7 wt { get; set; }
            public M7 m { get; set; }
            public Ds7 ds { get; set; }
        }

        public class W7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds7
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _342884731
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice8 basePrice { get; set; }
            public Finalprice8 finalPrice { get; set; }
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
            public Productattributes8 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes8
        {
            public W8 w { get; set; }
            public D8 d { get; set; }
            public H8 h { get; set; }
            public C8 c { get; set; }
            public S8 s { get; set; }
            public Wt8 wt { get; set; }
            public M8 m { get; set; }
            public Ds8 ds { get; set; }
        }

        public class W8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds8
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _346601211
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice9 basePrice { get; set; }
            public Finalprice9 finalPrice { get; set; }
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
            public Productattributes9 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes9
        {
            public W9 w { get; set; }
            public D9 d { get; set; }
            public H9 h { get; set; }
            public C9 c { get; set; }
            public S9 s { get; set; }
            public Wt9 wt { get; set; }
            public M9 m { get; set; }
            public Ds9 ds { get; set; }
        }

        public class W9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds9
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _357135162
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice10 basePrice { get; set; }
            public Finalprice10 finalPrice { get; set; }
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
            public Productattributes10 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes10
        {
            public W10 w { get; set; }
            public D10 d { get; set; }
            public H10 h { get; set; }
            public C10 c { get; set; }
            public S10 s { get; set; }
            public Wt10 wt { get; set; }
            public M10 m { get; set; }
            public Ds10 ds { get; set; }
        }

        public class W10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds10
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _402696992
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice11 basePrice { get; set; }
            public Finalprice11 finalPrice { get; set; }
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
            public Productattributes11 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes11
        {
            public W11 w { get; set; }
            public D11 d { get; set; }
            public H11 h { get; set; }
            public C11 c { get; set; }
            public S11 s { get; set; }
            public Wt11 wt { get; set; }
            public M11 m { get; set; }
            public Ds11 ds { get; set; }
        }

        public class W11
        {
            public string name { get; set; }
        }

        public class D11
        {
            public string name { get; set; }
        }

        public class H11
        {
            public string name { get; set; }
        }

        public class C11
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S11
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt11
        {
            public string name { get; set; }
        }

        public class M11
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds11
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _406587402
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
            public Productattributes12 productAttributes { get; set; }
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

        public class Productattributes12
        {
            public W12 w { get; set; }
            public D12 d { get; set; }
            public H12 h { get; set; }
            public C12 c { get; set; }
            public S12 s { get; set; }
            public Wt12 wt { get; set; }
            public M12 m { get; set; }
            public Ds12 ds { get; set; }
        }

        public class W12
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D12
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H12
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C12
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S12
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt12
        {
            public string name { get; set; }
        }

        public class M12
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds12
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _406591822
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice13 basePrice { get; set; }
            public Finalprice13 finalPrice { get; set; }
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
            public Productattributes13 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes13
        {
            public W13 w { get; set; }
            public D13 d { get; set; }
            public H13 h { get; set; }
            public C13 c { get; set; }
            public S13 s { get; set; }
            public Wt13 wt { get; set; }
            public M13 m { get; set; }
            public Ds13 ds { get; set; }
        }

        public class W13
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D13
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H13
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C13
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S13
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt13
        {
            public string name { get; set; }
        }

        public class M13
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds13
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _526451032
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice14 basePrice { get; set; }
            public Finalprice14 finalPrice { get; set; }
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
            public Productattributes14 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes14
        {
            public W14 w { get; set; }
            public D14 d { get; set; }
            public H14 h { get; set; }
            public C14 c { get; set; }
            public S14 s { get; set; }
            public Wt14 wt { get; set; }
            public M14 m { get; set; }
            public Ds14 ds { get; set; }
        }

        public class W14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds14
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _543676901
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice15 basePrice { get; set; }
            public Finalprice15 finalPrice { get; set; }
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
            public Productattributes15 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes15
        {
            public W15 w { get; set; }
            public D15 d { get; set; }
            public H15 h { get; set; }
            public C15 c { get; set; }
            public S15 s { get; set; }
            public Wt15 wt { get; set; }
            public M15 m { get; set; }
            public Ds15 ds { get; set; }
        }

        public class W15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds15
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _552005811
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice16 basePrice { get; set; }
            public Finalprice16 finalPrice { get; set; }
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
            public Productattributes16 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes16
        {
            public W16 w { get; set; }
            public D16 d { get; set; }
            public H16 h { get; set; }
            public C16 c { get; set; }
            public S16 s { get; set; }
            public Wt16 wt { get; set; }
            public M16 m { get; set; }
            public Ds16 ds { get; set; }
        }

        public class W16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds16
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _581819162
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice17 basePrice { get; set; }
            public Finalprice17 finalPrice { get; set; }
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
            public Productattributes17 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes17
        {
            public W17 w { get; set; }
            public D17 d { get; set; }
            public H17 h { get; set; }
            public C17 c { get; set; }
            public S17 s { get; set; }
            public Wt17 wt { get; set; }
            public M17 m { get; set; }
            public Ds17 ds { get; set; }
        }

        public class W17
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D17
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H17
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C17
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S17
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt17
        {
            public string name { get; set; }
        }

        public class M17
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds17
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _617895481
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice18 basePrice { get; set; }
            public Finalprice18 finalPrice { get; set; }
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
            public Productattributes18 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes18
        {
            public W18 w { get; set; }
            public D18 d { get; set; }
            public H18 h { get; set; }
            public C18 c { get; set; }
            public S18 s { get; set; }
            public Wt18 wt { get; set; }
            public M18 m { get; set; }
            public Ds18 ds { get; set; }
        }

        public class W18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds18
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _619021651
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice19 basePrice { get; set; }
            public Finalprice19 finalPrice { get; set; }
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
            public Productattributes19 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes19
        {
            public W19 w { get; set; }
            public D19 d { get; set; }
            public H19 h { get; set; }
            public C19 c { get; set; }
            public S19 s { get; set; }
            public Wt19 wt { get; set; }
            public M19 m { get; set; }
            public Ds19 ds { get; set; }
        }

        public class W19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds19
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _722410091
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice20 basePrice { get; set; }
            public Finalprice20 finalPrice { get; set; }
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
            public Productattributes20 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes20
        {
            public W20 w { get; set; }
            public D20 d { get; set; }
            public H20 h { get; set; }
            public C20 c { get; set; }
            public S20 s { get; set; }
            public Wt20 wt { get; set; }
            public M20 m { get; set; }
            public Ds20 ds { get; set; }
        }

        public class W20
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D20
        {
            public string name { get; set; }
        }

        public class H20
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C20
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S20
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt20
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M20
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds20
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _772771741
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice21 basePrice { get; set; }
            public Finalprice21 finalPrice { get; set; }
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
            public Productattributes21 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes21
        {
            public W21 w { get; set; }
            public D21 d { get; set; }
            public H21 h { get; set; }
            public C21 c { get; set; }
            public S21 s { get; set; }
            public Wt21 wt { get; set; }
            public M21 m { get; set; }
            public Ds21 ds { get; set; }
        }

        public class W21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds21
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _787619381
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice22 basePrice { get; set; }
            public Finalprice22 finalPrice { get; set; }
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
            public Productattributes22 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes22
        {
            public W22 w { get; set; }
            public D22 d { get; set; }
            public H22 h { get; set; }
            public C22 c { get; set; }
            public S22 s { get; set; }
            public Wt22 wt { get; set; }
            public M22 m { get; set; }
            public Ds22 ds { get; set; }
        }

        public class W22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds22
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _866866051
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice23 basePrice { get; set; }
            public Finalprice23 finalPrice { get; set; }
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
            public Productattributes23 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes23
        {
            public W23 w { get; set; }
            public D23 d { get; set; }
            public H23 h { get; set; }
            public C23 c { get; set; }
            public S23 s { get; set; }
            public Wt23 wt { get; set; }
            public M23 m { get; set; }
            public Ds23 ds { get; set; }
        }

        public class W23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds23
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _905319531
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice24 basePrice { get; set; }
            public Finalprice24 finalPrice { get; set; }
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
            public Productattributes24 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes24
        {
            public W24 w { get; set; }
            public D24 d { get; set; }
            public H24 h { get; set; }
            public C24 c { get; set; }
            public S24 s { get; set; }
            public Wt24 wt { get; set; }
            public M24 m { get; set; }
            public Ds24 ds { get; set; }
        }

        public class W24
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D24
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H24
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C24
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S24
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt24
        {
            public string name { get; set; }
        }

        public class M24
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds24
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _967654661
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice25 basePrice { get; set; }
            public Finalprice25 finalPrice { get; set; }
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
            public Productattributes25 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes25
        {
            public W25 w { get; set; }
            public D25 d { get; set; }
            public H25 h { get; set; }
            public C25 c { get; set; }
            public S25 s { get; set; }
            public Wt25 wt { get; set; }
            public M25 m { get; set; }
            public Ds25 ds { get; set; }
        }

        public class W25
        {
            public string name { get; set; }
        }

        public class D25
        {
            public string name { get; set; }
        }

        public class H25
        {
            public string name { get; set; }
        }

        public class C25
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S25
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt25
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M25
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds25
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _967720121
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice26 basePrice { get; set; }
            public Finalprice26 finalPrice { get; set; }
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
            public Productattributes26 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes26
        {
            public W26 w { get; set; }
            public D26 d { get; set; }
            public H26 h { get; set; }
            public C26 c { get; set; }
            public S26 s { get; set; }
            public Wt26 wt { get; set; }
            public M26 m { get; set; }
            public Ds26 ds { get; set; }
        }

        public class W26
        {
            public string name { get; set; }
        }

        public class D26
        {
            public string name { get; set; }
        }

        public class H26
        {
            public string name { get; set; }
        }

        public class C26
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S26
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt26
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M26
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds26
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _967732111
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice27 basePrice { get; set; }
            public Finalprice27 finalPrice { get; set; }
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
            public Productattributes27 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes27
        {
            public W27 w { get; set; }
            public D27 d { get; set; }
            public H27 h { get; set; }
            public C27 c { get; set; }
            public S27 s { get; set; }
            public Wt27 wt { get; set; }
            public M27 m { get; set; }
            public Ds27 ds { get; set; }
        }

        public class W27
        {
            public string name { get; set; }
        }

        public class D27
        {
            public string name { get; set; }
        }

        public class H27
        {
            public string name { get; set; }
        }

        public class C27
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S27
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt27
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M27
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds27
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _967734671
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice28 basePrice { get; set; }
            public Finalprice28 finalPrice { get; set; }
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
            public Productattributes28 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes28
        {
            public W28 w { get; set; }
            public D28 d { get; set; }
            public H28 h { get; set; }
            public C28 c { get; set; }
            public S28 s { get; set; }
            public Wt28 wt { get; set; }
            public M28 m { get; set; }
            public Ds28 ds { get; set; }
        }

        public class W28
        {
            public string name { get; set; }
        }

        public class D28
        {
            public string name { get; set; }
        }

        public class H28
        {
            public string name { get; set; }
        }

        public class C28
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S28
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt28
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M28
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds28
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _985257521
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice29 basePrice { get; set; }
            public Finalprice29 finalPrice { get; set; }
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
            public Productattributes29 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes29
        {
            public W29 w { get; set; }
            public D29 d { get; set; }
            public H29 h { get; set; }
            public C29 c { get; set; }
            public S29 s { get; set; }
            public Wt29 wt { get; set; }
            public M29 m { get; set; }
            public Ds29 ds { get; set; }
        }

        public class W29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds29
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1086713221
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice30 basePrice { get; set; }
            public Finalprice30 finalPrice { get; set; }
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
            public Productattributes30 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes30
        {
            public W30 w { get; set; }
            public D30 d { get; set; }
            public H30 h { get; set; }
            public C30 c { get; set; }
            public S30 s { get; set; }
            public Wt30 wt { get; set; }
            public M30 m { get; set; }
            public Ds30 ds { get; set; }
        }

        public class W30
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D30
        {
            public string name { get; set; }
        }

        public class H30
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C30
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S30
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt30
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M30
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds30
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1094288931
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice31 basePrice { get; set; }
            public Finalprice31 finalPrice { get; set; }
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
            public Productattributes31 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes31
        {
            public W31 w { get; set; }
            public D31 d { get; set; }
            public H31 h { get; set; }
            public C31 c { get; set; }
            public S31 s { get; set; }
            public Wt31 wt { get; set; }
            public M31 m { get; set; }
            public Ds31 ds { get; set; }
        }

        public class W31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds31
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1114232071
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice32 basePrice { get; set; }
            public Finalprice32 finalPrice { get; set; }
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
            public Productattributes32 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes32
        {
            public W32 w { get; set; }
            public D32 d { get; set; }
            public H32 h { get; set; }
            public C32 c { get; set; }
            public S32 s { get; set; }
            public Wt32 wt { get; set; }
            public M32 m { get; set; }
            public Ds32 ds { get; set; }
        }

        public class W32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds32
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1114233171
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice33 basePrice { get; set; }
            public Finalprice33 finalPrice { get; set; }
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
            public Productattributes33 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes33
        {
            public W33 w { get; set; }
            public D33 d { get; set; }
            public H33 h { get; set; }
            public C33 c { get; set; }
            public S33 s { get; set; }
            public Wt33 wt { get; set; }
            public M33 m { get; set; }
            public Ds33 ds { get; set; }
        }

        public class W33
        {
            public string name { get; set; }
        }

        public class D33
        {
            public string name { get; set; }
        }

        public class H33
        {
            public string name { get; set; }
        }

        public class C33
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S33
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt33
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M33
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds33
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1148685201
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice34 basePrice { get; set; }
            public Finalprice34 finalPrice { get; set; }
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
            public Productattributes34 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes34
        {
            public W34 w { get; set; }
            public D34 d { get; set; }
            public H34 h { get; set; }
            public C34 c { get; set; }
            public S34 s { get; set; }
            public Wt34 wt { get; set; }
            public M34 m { get; set; }
            public Ds34 ds { get; set; }
        }

        public class W34
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D34
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H34
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C34
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S34
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt34
        {
            public string name { get; set; }
        }

        public class M34
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds34
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1172863691
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice35 basePrice { get; set; }
            public Finalprice35 finalPrice { get; set; }
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
            public Productattributes35 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes35
        {
            public W35 w { get; set; }
            public D35 d { get; set; }
            public H35 h { get; set; }
            public C35 c { get; set; }
            public S35 s { get; set; }
            public Wt35 wt { get; set; }
            public M35 m { get; set; }
            public Ds35 ds { get; set; }
        }

        public class W35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds35
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1181734471
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice36 basePrice { get; set; }
            public Finalprice36 finalPrice { get; set; }
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
            public Productattributes36 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes36
        {
            public W36 w { get; set; }
            public D36 d { get; set; }
            public H36 h { get; set; }
            public C36 c { get; set; }
            public S36 s { get; set; }
            public Wt36 wt { get; set; }
            public M36 m { get; set; }
            public Ds36 ds { get; set; }
        }

        public class W36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds36
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1209589521
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice37 basePrice { get; set; }
            public Finalprice37 finalPrice { get; set; }
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
            public Productattributes37 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes37
        {
            public W37 w { get; set; }
            public D37 d { get; set; }
            public H37 h { get; set; }
            public C37 c { get; set; }
            public S37 s { get; set; }
            public Wt37 wt { get; set; }
            public M37 m { get; set; }
            public Ds37 ds { get; set; }
        }

        public class W37
        {
            public string name { get; set; }
        }

        public class D37
        {
            public string name { get; set; }
        }

        public class H37
        {
            public string name { get; set; }
        }

        public class C37
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S37
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt37
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M37
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds37
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1232172072
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice38 basePrice { get; set; }
            public Finalprice38 finalPrice { get; set; }
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
            public Productattributes38 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes38
        {
            public W38 w { get; set; }
            public D38 d { get; set; }
            public H38 h { get; set; }
            public C38 c { get; set; }
            public S38 s { get; set; }
            public Wt38 wt { get; set; }
            public M38 m { get; set; }
            public Ds38 ds { get; set; }
        }

        public class W38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds38
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1232710211
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice39 basePrice { get; set; }
            public Finalprice39 finalPrice { get; set; }
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
            public Productattributes39 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
            public bool isTradeExclusive { get; set; }
            public string verifiedMPN { get; set; }
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

        public class Productattributes39
        {
            public W39 w { get; set; }
            public D39 d { get; set; }
            public H39 h { get; set; }
            public C39 c { get; set; }
            public S39 s { get; set; }
            public Wt39 wt { get; set; }
            public M39 m { get; set; }
            public Ds39 ds { get; set; }
        }

        public class W39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds39
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1239405931
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice40 basePrice { get; set; }
            public Finalprice40 finalPrice { get; set; }
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
            public Productattributes40 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes40
        {
            public W40 w { get; set; }
            public D40 d { get; set; }
            public H40 h { get; set; }
            public C40 c { get; set; }
            public S40 s { get; set; }
            public Wt40 wt { get; set; }
            public M40 m { get; set; }
            public Ds40 ds { get; set; }
        }

        public class W40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class H40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds40
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class _1245344741
        {
            public int preferredListingId { get; set; }
            public int preferredVendorId { get; set; }
            public Baseprice41 basePrice { get; set; }
            public Finalprice41 finalPrice { get; set; }
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
            public Productattributes41 productAttributes { get; set; }
            public int reviewScore { get; set; }
            public int numReviews { get; set; }
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

        public class Productattributes41
        {
            public W41 w { get; set; }
            public D41 d { get; set; }
            public H41 h { get; set; }
            public C41 c { get; set; }
            public S41 s { get; set; }
            public Wt41 wt { get; set; }
            public M41 m { get; set; }
            public Ds41 ds { get; set; }
        }

        public class W41
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class D41
        {
            public string name { get; set; }
        }

        public class H41
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class C41
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class S41
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Wt41
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class M41
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Ds41
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Vendorlistingsstore
        {
            public Data27 data { get; set; }
        }

        public class Data27
        {
            public _105184003 _10518400 { get; set; }
            public _105184032 _10518403 { get; set; }
            public _116457252 _11645725 { get; set; }
            public _124288373 _12428837 { get; set; }
            public _154685022 _15468502 { get; set; }
            public _168046982 _16804698 { get; set; }
            public _232156093 _23215609 { get; set; }
            public _232156332 _23215633 { get; set; }
            public _342884732 _34288473 { get; set; }
            public _346601212 _34660121 { get; set; }
            public _357135163 _35713516 { get; set; }
            public _402696993 _40269699 { get; set; }
            public _406587403 _40658740 { get; set; }
            public _406591823 _40659182 { get; set; }
            public _526451033 _52645103 { get; set; }
            public _543676902 _54367690 { get; set; }
            public _552005812 _55200581 { get; set; }
            public _581819163 _58181916 { get; set; }
            public _617895482 _61789548 { get; set; }
            public _619021652 _61902165 { get; set; }
            public _722410092 _72241009 { get; set; }
            public _772771742 _77277174 { get; set; }
            public _787619382 _78761938 { get; set; }
            public _866866052 _86686605 { get; set; }
            public _905319532 _90531953 { get; set; }
            public _967654662 _96765466 { get; set; }
            public _967720122 _96772012 { get; set; }
            public _967732112 _96773211 { get; set; }
            public _967734672 _96773467 { get; set; }
            public _985257522 _98525752 { get; set; }
            public _1086713222 _108671322 { get; set; }
            public _1094288932 _109428893 { get; set; }
            public _1114232072 _111423207 { get; set; }
            public _1114233172 _111423317 { get; set; }
            public _1148685202 _114868520 { get; set; }
            public _1172863692 _117286369 { get; set; }
            public _1181734472 _118173447 { get; set; }
            public _1209589522 _120958952 { get; set; }
            public _1232172073 _123217207 { get; set; }
            public _1232710212 _123271021 { get; set; }
            public _1239405932 _123940593 { get; set; }
            public _1245344742 _124534474 { get; set; }
        }

        public class _105184003
        {
            public _3047608 _3047608 { get; set; }
        }

        public class _3047608
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
            public string shippingCharge { get; set; }
            public string dimensions { get; set; }
            public string weight { get; set; }
            public bool hasActivePromoCampaign { get; set; }
            public bool isTradePrice { get; set; }
            public bool isTradeExclusive { get; set; }
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

        public class _105184032
        {
            public _3047611 _3047611 { get; set; }
        }

        public class _3047611
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price1 price { get; set; }
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

        public class Price1
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _116457252
        {
            public _3698951 _3698951 { get; set; }
        }

        public class _3698951
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price2 price { get; set; }
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

        public class Price2
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _124288373
        {
            public _4175151 _4175151 { get; set; }
        }

        public class _4175151
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price3 price { get; set; }
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

        public class Price3
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _154685022
        {
            public _68114973 _68114973 { get; set; }
        }

        public class _68114973
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price4 price { get; set; }
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

        public class Price4
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _168046982
        {
            public _1742885 _1742885 { get; set; }
        }

        public class _1742885
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price5 price { get; set; }
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

        public class Price5
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _232156093
        {
            public _11754148 _11754148 { get; set; }
        }

        public class _11754148
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

        public class _232156332
        {
            public _11754169 _11754169 { get; set; }
        }

        public class _11754169
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price7 price { get; set; }
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

        public class Price7
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _342884732
        {
            public _19987138 _19987138 { get; set; }
        }

        public class _19987138
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price8 price { get; set; }
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

        public class Price8
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _346601212
        {
            public _2538402 _2538402 { get; set; }
        }

        public class _2538402
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price9 price { get; set; }
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

        public class Price9
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _357135163
        {
            public _21325963 _21325963 { get; set; }
        }

        public class _21325963
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price10 price { get; set; }
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

        public class Price10
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _402696993
        {
            public _26659359 _26659359 { get; set; }
        }

        public class _26659359
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price11 price { get; set; }
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

        public class Price11
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _406587403
        {
            public _27055742 _27055742 { get; set; }
        }

        public class _27055742
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price12 price { get; set; }
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

        public class Price12
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _406591823
        {
            public _27056092 _27056092 { get; set; }
        }

        public class _27056092
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price13 price { get; set; }
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
            public string promoLabel { get; set; }
            public string promoOriginalPriceString { get; set; }
            public string promoDiscountDescription { get; set; }
            public string promoSavedAmountString { get; set; }
            public string promoBrowsePageLink { get; set; }
            public bool hasActivePromoCampaign { get; set; }
            public bool isTradePrice { get; set; }
            public bool isTradeExclusive { get; set; }
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

        public class Price13
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _526451033
        {
            public _37813228 _37813228 { get; set; }
        }

        public class _37813228
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price14 price { get; set; }
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
            public string promoLabel { get; set; }
            public string promoOriginalPriceString { get; set; }
            public string promoDiscountDescription { get; set; }
            public string promoSavedAmountString { get; set; }
            public string promoBrowsePageLink { get; set; }
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

        public class Price14
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _543676902
        {
            public _90159826 _90159826 { get; set; }
        }

        public class _90159826
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price15 price { get; set; }
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

        public class Price15
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _552005812
        {
            public _40708989 _40708989 { get; set; }
        }

        public class _40708989
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price16 price { get; set; }
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

        public class Price16
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _581819163
        {
            public _12936458 _12936458 { get; set; }
        }

        public class _12936458
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price17 price { get; set; }
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
            public string promoLabel { get; set; }
            public string promoOriginalPriceString { get; set; }
            public string promoDiscountDescription { get; set; }
            public string promoSavedAmountString { get; set; }
            public string promoBrowsePageLink { get; set; }
            public bool hasActivePromoCampaign { get; set; }
            public bool isTradePrice { get; set; }
            public bool isTradeExclusive { get; set; }
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

        public class Price17
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _617895482
        {
            public _1743345 _1743345 { get; set; }
        }

        public class _1743345
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price18 price { get; set; }
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

        public class Price18
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _619021652
        {
            public _46592387 _46592387 { get; set; }
        }

        public class _46592387
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price19 price { get; set; }
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
            public string promoLabel { get; set; }
            public string promoOriginalPriceString { get; set; }
            public string promoDiscountDescription { get; set; }
            public string promoSavedAmountString { get; set; }
            public string promoBrowsePageLink { get; set; }
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

        public class Price19
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _722410092
        {
            public _82207282 _82207282 { get; set; }
        }

        public class _82207282
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price20 price { get; set; }
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

        public class Price20
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _772771742
        {
            public _60245380 _60245380 { get; set; }
        }

        public class _60245380
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price21 price { get; set; }
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

        public class Price21
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _787619382
        {
            public _35518227 _35518227 { get; set; }
        }

        public class _35518227
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price22 price { get; set; }
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

        public class Price22
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _866866052
        {
            public _67308706 _67308706 { get; set; }
        }

        public class _67308706
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price23 price { get; set; }
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
            public string promoLabel { get; set; }
            public string promoOriginalPriceString { get; set; }
            public string promoDiscountDescription { get; set; }
            public string promoSavedAmountString { get; set; }
            public string promoBrowsePageLink { get; set; }
            public bool hasActivePromoCampaign { get; set; }
            public bool isTradePrice { get; set; }
            public bool isTradeExclusive { get; set; }
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

        public class Price23
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _905319532
        {
            public _72389544 _72389544 { get; set; }
        }

        public class _72389544
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price24 price { get; set; }
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

        public class Price24
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _967654662
        {
            public _70803508 _70803508 { get; set; }
        }

        public class _70803508
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price25 price { get; set; }
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

        public class Price25
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _967720122
        {
            public _74426811 _74426811 { get; set; }
        }

        public class _74426811
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price26 price { get; set; }
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

        public class Price26
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _967732112
        {
            public _74427856 _74427856 { get; set; }
        }

        public class _74427856
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price27 price { get; set; }
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

        public class Price27
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _967734672
        {
            public _82539011 _82539011 { get; set; }
        }

        public class _82539011
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price28 price { get; set; }
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

        public class Price28
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _985257522
        {
            public _1742645 _1742645 { get; set; }
        }

        public class _1742645
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price29 price { get; set; }
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

        public class Price29
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1086713222
        {
            public _80622826 _80622826 { get; set; }
        }

        public class _80622826
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price30 price { get; set; }
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

        public class Price30
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1094288932
        {
            public _83019292 _83019292 { get; set; }
        }

        public class _83019292
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price31 price { get; set; }
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

        public class Price31
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1114232072
        {
            public _59350854 _59350854 { get; set; }
        }

        public class _59350854
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price32 price { get; set; }
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

        public class Price32
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1114233172
        {
            public _76815579 _76815579 { get; set; }
        }

        public class _76815579
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price33 price { get; set; }
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

        public class Price33
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1148685202
        {
            public _23543110 _23543110 { get; set; }
        }

        public class _23543110
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price34 price { get; set; }
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

        public class Price34
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1172863692
        {
            public _88044073 _88044073 { get; set; }
        }

        public class _88044073
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price35 price { get; set; }
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

        public class Price35
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1181734472
        {
            public _88702022 _88702022 { get; set; }
        }

        public class _88702022
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price36 price { get; set; }
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

        public class Price36
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1209589522
        {
            public _76815598 _76815598 { get; set; }
        }

        public class _76815598
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price37 price { get; set; }
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

        public class Price37
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1232172073
        {
            public _1743344 _1743344 { get; set; }
        }

        public class _1743344
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price38 price { get; set; }
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

        public class Price38
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1232710212
        {
            public _91972650 _91972650 { get; set; }
        }

        public class _91972650
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price39 price { get; set; }
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

        public class Price39
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1239405932
        {
            public _92344627 _92344627 { get; set; }
        }

        public class _92344627
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price40 price { get; set; }
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

        public class Price40
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class _1245344742
        {
            public _85819804 _85819804 { get; set; }
        }

        public class _85819804
        {
            public int listingId { get; set; }
            public int vendorId { get; set; }
            public string productCode { get; set; }
            public Price41 price { get; set; }
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

        public class Price41
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Metadatastore
        {
            public Data28 data { get; set; }
        }

        public class Data28
        {
            public int robotsValue { get; set; }
            public string canonicalUrl { get; set; }
            public Hreflanghtmltag1[] hrefLangHtmlTags { get; set; }
            public Htmlmetatag[] htmlMetaTags { get; set; }
        }

        public class Hreflanghtmltag1
        {
            public string tagName { get; set; }
            public Attributes52 attributes { get; set; }
            public string contents { get; set; }
        }

        public class Attributes52
        {
            public string rel { get; set; }
            public string href { get; set; }
            public string hreflang { get; set; }
        }

        public class Htmlmetatag
        {
            public string tagName { get; set; }
            public Attributes53 attributes { get; set; }
            public string contents { get; set; }
        }

        public class Attributes53
        {
            public string rel { get; set; }
            public string href { get; set; }
            public string type { get; set; }
            public string sizes { get; set; }
        }

        public class Admintoolsstore
        {
            public object[] prereqs { get; set; }
            public Data29 data { get; set; }
        }

        public class Data29
        {
        }

        public class Abtest
        {
            public string gtm_bucket { get; set; }
            public string browser_extension_upsell_content_test { get; set; }
            public string post_save_toast { get; set; }
            public string vanity_finder { get; set; }
            public string vanity_finder_mweb { get; set; }
            public string boost_room_photo { get; set; }
            public string browse_products_color_variations { get; set; }
            public string browse_products_color_swatch { get; set; }
            public string browse_vanities_landing { get; set; }
            public string browse_vanities_landing_web { get; set; }
            public string browse_vanities_landing_mweb_v2 { get; set; }
            public string browse_vanities_landing_web_v2 { get; set; }
            public string browse_rug_landing_web { get; set; }
            public string browse_rug_landing_mweb { get; set; }
            public string browse_secondary_queries { get; set; }
            public string r3_entry_points { get; set; }
            public string browse_products_gql { get; set; }
            public string browse_facet_relax_secondary_queries { get; set; }
            public string browse_new_arrivals_ui_test { get; set; }
            public string pro_name_search { get; set; }
            public string photo_search_sort_by { get; set; }
            public string save_to_ideabook_single_selection { get; set; }
            public string add_to_ideabook_pro_wizard_search_within { get; set; }
            public string save_icon_test { get; set; }
            public string product_sale_badge { get; set; }
            public string product_badge_unify { get; set; }
            public string new_link_styles { get; set; }
            public string marketplace_strikethrough_price_v2_test { get; set; }
            public string seo_browse_photos_ldjson_test { get; set; }
            public string sem_inline_signup { get; set; }
            public string fullstory_integration { get; set; }
            public string visitor_tracker_inline_signup { get; set; }
            public string trade_showroom_test { get; set; }
            public string jukwaa_lb { get; set; }
            public string visitor_consents_banner_v2 { get; set; }
            public string sale_dropdown_disabled { get; set; }
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

        public class Config
        {
            public string systemsimgHost { get; set; }
            public string systemfimgHost { get; set; }
            public bool sitespeedconfigsENABLE_LAZY_LOADING { get; set; }
            public bool sitespeedconfigsENABLE_IMAGE_LOAD_ON_FIRST_SCROLL { get; set; }
            public bool REBRAND_ENABLED { get; set; }
            public bool systemprofessionalsSearchLocationEnabled { get; set; }
            public bool PRO_CENTER_IN_TOP_RIGHT_MENU { get; set; }
            public float BrowsefeaturePROMOTION_MODULE_DISCOUNT_THRESHOLD { get; set; }
            public bool CHECKOUT_ENABLED { get; set; }
            public UniversalSave universalsave { get; set; }
            public bool browserextensionenable_upsell { get; set; }
            public BrowserExtensionExtension_Metadata browserextensionextension_metadata { get; set; }
            public int browserextensionextension_upsell_expiration_in_seconds { get; set; }
            public bool RELATED_PRODUCTS_HIDE { get; set; }
            public bool UNIFIED_SEARCH_PROD { get; set; }
            public bool BROWSE_PRODUCT_M_VIEW_HIGHLIGHT_ENABLED { get; set; }
            public bool browseenable_facet_count { get; set; }
            public bool browseenable_pro_name_seach_card { get; set; }
            public bool browseenable_sort_for_photo_seach { get; set; }
            public ProPerception properception { get; set; }
            public SearchSolr_Param_Override searchsolr_param_override { get; set; }
            public bool PRODUCT_SEARCH_RELATED_SEARCH_ENABLED { get; set; }
            public BrowseLAZY_LOAD_CONFIG browseLAZY_LOAD_CONFIG { get; set; }
            public bool AB_IMPORT_ENABLED { get; set; }
            public string VERSION { get; set; }
            public float PROMOTION_MODULE_DISCOUNT_THRESHOLD { get; set; }
            public bool authenticationenableShareByEmailAutoRegister { get; set; }
            public bool GALLERY_ITEMS_ENABLED { get; set; }
            public UniversalGallery universalgallery { get; set; }
            public bool productisSpfEnabled { get; set; }
            public bool TRADE_ALLOW_NON_DISCOUNT_CREDIT { get; set; }
            public bool NEW_RETURN_POLICY_FREE_SHIPPING { get; set; }
            public int[] BrowsefeatureVANITY_FINDER_TOPIC_IDS { get; set; }
            public int[] BrowsefeatureRUG_FINDER_TOPIC_IDS { get; set; }
            public bool browsePREFETCH_LARGE_SCREEN_ENABLED { get; set; }
            public int PRODUCT_SHIPPED_TO_CANADA_COUNT { get; set; }
            public bool authenticationenable_sem_inline_signup { get; set; }
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
            public string UPLOADFILE_PIC { get; set; }
            public string IMAGES_SEO_URL { get; set; }
            public SitespeedSpf sitespeedspf { get; set; }
            public bool sitespeedconfigsSPF_FETCH_ON_MOUSEDOWN { get; set; }
            public SitespeedConfigsSPF_DISABLED_PAGES sitespeedconfigsSPF_DISABLED_PAGES { get; set; }
            public string GA_TRACKING_ID { get; set; }
            public string GTM_ACCOUNT_ID { get; set; }
            public bool GA_ANONYMIZE_IP_ENABLED { get; set; }
            public bool FULLSTORY_ENABLED { get; set; }
            public string BUTTON_APP_ID { get; set; }
            public bool BUTTON_JS_ENABLED { get; set; }
            public SystemVisitortracker systemvisitorTracker { get; set; }
            public bool authenticationenable_visitor_tracker_inline_signup { get; set; }
            public SitespeedClientsidesitespeedconfig sitespeedclientSideSiteSpeedConfig { get; set; }
            public bool sitespeedconfigsenablingClientPerfLoggingRetry { get; set; }
            public bool ENABLE_REFERRER_CAPTURE { get; set; }
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

        public class UniversalSave
        {
            public int extension_upsell_expiration_in_seconds { get; set; }
        }

        public class BrowserExtensionExtension_Metadata
        {
            public Chrome chrome { get; set; }
            public Firefox firefox { get; set; }
            public Edge edge { get; set; }
            public Safari safari { get; set; }
        }

        public class Chrome
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

        public class ProPerception
        {
            public int lightbox_banner_dismissal_expire_in_second { get; set; }
        }

        public class SearchSolr_Param_Override
        {
            public bool dev { get; set; }
            public bool staging { get; set; }
            public bool production { get; set; }
        }

        public class BrowseLAZY_LOAD_CONFIG
        {
            public Mobile mobile { get; set; }
            public Desktop desktop { get; set; }
        }

        public class Mobile
        {
            public Photos photos { get; set; }
            public Products products { get; set; }
        }

        public class Photos
        {
            public Default _default { get; set; }
        }

        public class Default
        {
            public int lazyLoadIndex { get; set; }
        }

        public class Products
        {
            public Default1 _default { get; set; }
        }

        public class Default1
        {
            public int lazyLoadIndex { get; set; }
        }

        public class Desktop
        {
            public Photos1 photos { get; set; }
            public Products1 products { get; set; }
        }

        public class Photos1
        {
            public Xl xl { get; set; }
            public L l { get; set; }
            public M42 m { get; set; }
            public S42 s { get; set; }
        }

        public class Xl
        {
            public int lazyLoadIndex { get; set; }
        }

        public class L
        {
            public int lazyLoadIndex { get; set; }
        }

        public class M42
        {
            public int lazyLoadIndex { get; set; }
        }

        public class S42
        {
            public int lazyLoadIndex { get; set; }
        }

        public class Products1
        {
            public M43 m { get; set; }
            public S43 s { get; set; }
        }

        public class M43
        {
            public int lazyLoadIndex { get; set; }
        }

        public class S43
        {
            public int lazyLoadIndex { get; set; }
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
            public bool VIEW_SEARCH_ADMIN { get; set; }
            public bool SUBMIT_OWN_IDEABOOK_TO_EDITOR { get; set; }
            public bool SUBMIT_ANY_IDEABOOK_TO_EDITOR { get; set; }
            public bool VIEW_BROWSE_PRODUCT_MARGIN { get; set; }
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
            public string name { get; set; }
            public string version { get; set; }
            public string major { get; set; }
        }

        public class Engine
        {
            public string name { get; set; }
            public string version { get; set; }
        }

        public class Os
        {
            public string name { get; set; }
            public string version { get; set; }
        }

        public class Device
        {
        }

        public class Cpu
        {
            public string architecture { get; set; }
        }

        public class Pagedescriptor1
        {
            public string pageClass { get; set; }
            public string pageCommand { get; set; }
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
            public string dma { get; set; }
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
}
