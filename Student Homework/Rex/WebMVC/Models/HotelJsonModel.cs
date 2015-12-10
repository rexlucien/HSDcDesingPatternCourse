namespace WebMVC.Controllers.Structural
{
    public class Rootobject
    {
        public Experiments experiments { get; set; }
        public Experimentspeek experimentsPeek { get; set; }
        public Starfilter starFilter { get; set; }
        public Unratedfilter unratedFilter { get; set; }
        public Pricefilter priceFilter { get; set; }
        public Taaphoteltypefilter taapHotelTypeFilter { get; set; }


        public Result1[] results { get; set; }  // Search Result



        public Traveler traveler { get; set; }
        public bool neighborhood2 { get; set; }
        public Neighborhoodfilter neighborHoodFilter { get; set; }
        public string multiCurrency { get; set; }

        //public Filtersortattributes filterSortAttributes { get; set; }
        public Searchcriteria searchCriteria { get; set; }

        public Userinteraction userInteraction { get; set; }
        public Amenities amenities { get; set; }
        public City city { get; set; }
        public Hotelname hotelName { get; set; }
        public Lodging lodging { get; set; }
        public Neighborhood neighborhood { get; set; }
        public Pagination pagination { get; set; }
        public Poi poi { get; set; }
        public Theme theme { get; set; }
        public Guided guided { get; set; }
        public Sort sort { get; set; }
        public SearchResults searchResults { get; set; }
        public Airattach airAttach { get; set; }
        public Hiddenfields hiddenFields { get; set; }
        public Brand brand { get; set; }
        public Error error { get; set; }
        public Matrix matrix { get; set; }
        public Alernativeregions alernativeRegions { get; set; }
        public Metadata metaData { get; set; }
        public Pagetitle pageTitle { get; set; }
        public Telesales telesales { get; set; }
        public Wizard wizard { get; set; }
        public Googlemap googleMap { get; set; }
        public Eds eds { get; set; }
        public Disclaimer disclaimer { get; set; }
        public string tealeaf { get; set; }
        public Ads ads { get; set; }
        public Travelad travelad { get; set; }
        public Doubleclick doubleClick { get; set; }
        public Intentmedia intentMedia { get; set; }
        public Universaldataobject universalDataObject { get; set; }
    }

    public class Experiments
    {
        public string HotelHSRPerfUrgencyServices { get; set; }
        public string LX_Hotel_XSell { get; set; }
        public string HotelHSRSuperDimmed { get; set; }
        public string HotelIS_StarRatingOutof { get; set; }
        public string HotelIS_StarRatingColors { get; set; }
        public string[] incomplete { get; set; }
    }

    public class Experimentspeek
    {
        public string HotelHSRFlexCards { get; set; }
        public string GROTripadvisorReviewsforExpediaHotels { get; set; }
        public string HSRClientSideFiltering { get; set; }
    }

    public class Starfilter
    {
        public Option[] options { get; set; }
    }

    public class Option
    {
        public string id { get; set; }
        public string value { get; set; }
        public bool selected { get; set; }
    }

    public class Unratedfilter
    {
        public object[] options { get; set; }
    }

    public class Pricefilter
    {
        public Option1[] options { get; set; }
    }

    public class Option1
    {
        public string id { get; set; }
        public string value { get; set; }
        public string max { get; set; }
        public bool selected { get; set; }
        public string min { get; set; }
    }

    public class Taaphoteltypefilter
    {
    }

    public class Traveler
    {
        public string tuid { get; set; }
        public bool isElitePlusMember { get; set; }
        public bool isLoggedIn { get; set; }
        public bool isRegistered { get; set; }
        public bool isRewardsMember { get; set; }
        public string firstName { get; set; }
        public bool isRewardsPlatinumUser { get; set; }
        public bool isRewardsGoldUser { get; set; }
        public bool isRewardsSilverUser { get; set; }
        public bool isDefaultUserTier { get; set; }
        public bool isTaapAgent { get; set; }
        public bool isBusinessTraveler { get; set; }
        public bool isLocalTraveler { get; set; }
        public bool isFamilyTraveler { get; set; }
    }

    public class Neighborhoodfilter
    {
        public Option2[] options { get; set; }
    }

    public class Option2
    {
        public string id { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Searchcriteria
    {
        public object[] starRating { get; set; }
        public object[] priceBuckets { get; set; }
        public object[] amenityIds { get; set; }
        public object[] taapHotelTypes { get; set; }
        public int[] structureTypes { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
    }

    public class Userinteraction
    {
        public string accountName { get; set; }
        public Omnitureproperties omnitureProperties { get; set; }
    }

    public class Omnitureproperties
    {
        public string eVar4 { get; set; }
        public string eVar5 { get; set; }
        public string eVar2 { get; set; }
        public string prop18 { get; set; }
        public string prop19 { get; set; }
        public string events { get; set; }
        public string eVar6 { get; set; }
        public string charSet { get; set; }
        public string prop17 { get; set; }
        public string eVar48 { get; set; }
        public string eVar47 { get; set; }
        public string prop12 { get; set; }
        public string prop13 { get; set; }
        public string prop10 { get; set; }
        public string prop11 { get; set; }
        public string userType { get; set; }
        public string activityId { get; set; }
        public string prop30 { get; set; }
        public string prop34 { get; set; }
        public string list1 { get; set; }
        public string campaign { get; set; }
        public string eVar1 { get; set; }
        public string pageName { get; set; }
        public string eVar34 { get; set; }
        public string prop2 { get; set; }
        public string prop29 { get; set; }
        public string eVar17 { get; set; }
        public string eVar54 { get; set; }
        public string prop20 { get; set; }
        public string eVar18 { get; set; }
        public string eVar56 { get; set; }
        public string destination { get; set; }
        public string eVar55 { get; set; }
        public string prop48 { get; set; }
        public string prop47 { get; set; }
        public string prop5 { get; set; }
        public string prop6 { get; set; }
        public string server { get; set; }
        public string prop4 { get; set; }
        public string channel { get; set; }
        public string eVar40 { get; set; }
    }

    public class Amenities
    {
        public Amenityoptionlist[] amenityOptionList { get; set; }
        public Accessibilityoptionlist[] accessibilityOptionList { get; set; }
        public Mealplanoptionlist[] mealplanOptionList { get; set; }
        public int[] initialOrder { get; set; }
        public bool isShowAccessibilities { get; set; }
        public bool isShowAmenities { get; set; }
        public bool isShowMealplans { get; set; }
        public int topAmenitiesCount { get; set; }
    }

    public class Amenityoptionlist
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sequenceId { get; set; }
        public bool selected { get; set; }
        public string checkboxValue { get; set; }
        public int count { get; set; }
    }

    public class Accessibilityoptionlist
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sequenceId { get; set; }
        public bool selected { get; set; }
        public string checkboxValue { get; set; }
        public int count { get; set; }
    }

    public class Mealplanoptionlist
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sequenceId { get; set; }
        public bool selected { get; set; }
        public string checkboxValue { get; set; }
        public int count { get; set; }
    }

    public class City
    {
    }

    public class Hotelname
    {
        public string essLocale { get; set; }
        public bool showFilter { get; set; }
    }

    public class Lodging
    {
        public int[] selectedLodgingType { get; set; }
        public bool showFilter { get; set; }
        public Structureoption[] structureOptions { get; set; }
    }

    public class Structureoption
    {
        public int id { get; set; }
        public int count { get; set; }
    }

    public class Neighborhood
    {
        public int selectedNeighborhoodId { get; set; }
        public bool showFilter { get; set; }
        public Neighborhoodlist[] neighborhoodList { get; set; }
        public object[] regionIds { get; set; }
        public Option3[] options { get; set; }
    }

    public class Neighborhoodlist
    {
        public string regionType { get; set; }
        public int regionID { get; set; }
        public int count { get; set; }
        public bool hasParent { get; set; }
        public int hotelCount { get; set; }
        public Majorcity majorCity { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public Latlong3 latLong { get; set; }
        public string description { get; set; }
        public bool isPackageable { get; set; }
        public string type { get; set; }
        public object[] airports { get; set; }
    }

    public class Majorcity
    {
        public Province province { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public Latlong2 latLong { get; set; }
        public string description { get; set; }
        public bool isPackageable { get; set; }
        public string type { get; set; }
        public object[] airports { get; set; }
    }

    public class Province
    {
        public Country country { get; set; }
        public string abbreviation { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public Latlong1 latLong { get; set; }
        public string description { get; set; }
        public bool isPackageable { get; set; }
        public string type { get; set; }
        public object[] airports { get; set; }
    }

    public class Country
    {
        public string twoLetterCountryCode { get; set; }
        public string threeLetterCountryCode { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public Latlong latLong { get; set; }
        public string description { get; set; }
        public bool isPackageable { get; set; }
        public string type { get; set; }
        public object[] airports { get; set; }
    }

    public class Latlong
    {
        public int latitude { get; set; }
        public int longitude { get; set; }
    }

    public class Latlong1
    {
        public int latitude { get; set; }
        public int longitude { get; set; }
    }

    public class Latlong2
    {
        public int latitude { get; set; }
        public int longitude { get; set; }
    }

    public class Latlong3
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Option3
    {
        public string id { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
    }

    public class Pagination
    {
        public int pageIndex { get; set; }
        public int pageCount { get; set; }
        public int pageNumber { get; set; }
        public int totalCount { get; set; }
        public int pageUpperCount { get; set; }
        public bool isFirstPage { get; set; }
        public bool isLastPage { get; set; }
    }

    public class Poi
    {
        public Option4[] options { get; set; }
    }

    public class Option4
    {
        public string id { get; set; }
        public string label { get; set; }
        public string value { get; set; }
        public bool selected { get; set; }
    }

    public class Theme
    {
        public string themeName { get; set; }
    }

    public class Guided
    {
    }

    public class Sort
    {
        public string selectedSortOrder { get; set; }
        public string[] sortOrderList { get; set; }
    }

    public class SearchResults
    {
        public bool showOpaqueBanners { get; set; }
        public string googleDestinationKeyword { get; set; }
        public string infositeQueryString { get; set; }
        public string dateFormat { get; set; }
        public string searchType { get; set; }
        public string continueButtonDescText { get; set; }
        public bool mandatoryFeeChangesRequired { get; set; }
        public string supplementalDescLocalizedText { get; set; }
        public bool showLocalizedHotelNames { get; set; }
        public bool isRetryRequest { get; set; }
        public int priceTypeDisplayed { get; set; }
        public string tealeafHTIMPDTL { get; set; }
        public int quickViewType { get; set; }
        public bool showMandatoryFeeEEM { get; set; }
        public bool splitMode { get; set; }
        public bool isDatelessSearch { get; set; }
        public int vacationRentalCount { get; set; }
        public bool isVacationRentalEligible { get; set; }
        public bool isShopWithPointsAndCanBurn { get; set; }
        public Thirdpartyinfo thirdPartyInfo { get; set; }
        public bool vacationRentalListings { get; set; }
        public int[] allHotelIds { get; set; }
        public float[][] allHotelCoords { get; set; }
        public int[] allHotelAvailability { get; set; }
        public string unitOfDistance { get; set; }
        public string shopWithPointsBranding { get; set; }
        public bool burn2x { get; set; }
    }

    public class Thirdpartyinfo
    {
        public string thirdPartyAvailabilityInfo { get; set; }
        public int expectedPropertyCount { get; set; }
        public bool returnTopListing { get; set; }
    }

    public class Airattach
    {
        public int hotmipExpiration { get; set; }
        public int hotmipSecondsLeft { get; set; }
        public bool overrideSavingMessage { get; set; }
    }

    public class Hiddenfields
    {
        public string inventoryType { get; set; }
    }

    public class Brand
    {
        public string brandName { get; set; }
        public string brandBaseName { get; set; }
        public string shortBrandName { get; set; }
        public string logoAltText { get; set; }
        public string interstitialLogoPath { get; set; }
        public string interstitialLogoPathFallback { get; set; }
        public string interstitialSecondaryImagePath { get; set; }
        public string opaqueTitle { get; set; }
        public string opaqueBranding { get; set; }
        public string opaqueBrandingImagePath43 { get; set; }
        public string opaqueBrandingImagePath11 { get; set; }
        public string opaqueIconImagePath { get; set; }
        public string vipHotelSearchThumbnail { get; set; }
        public string exclusiveAmenityTierImageSilver { get; set; }
        public string exclusiveAmenityTierImageGold { get; set; }
        public string exclusiveAmenityTierImagePlatinum { get; set; }
        public string googleMapClient { get; set; }
    }

    public class Error
    {
        public string errorMessage { get; set; }
        public bool isErrorMessage { get; set; }
        public string eventCode { get; set; }
    }

    public class Matrix
    {
        public Bracket[] brackets { get; set; }
    }

    public class Bracket
    {
        public bool mostPopular { get; set; }
        public int regionID { get; set; }
        public string id { get; set; }
        public string avgPrice { get; set; }
        public int count { get; set; }
    }

    public class Alernativeregions
    {
    }

    public class Metadata
    {
        public bool hasSearchResults { get; set; }
        public bool isRetryRequest { get; set; }
        public bool isDateless { get; set; }
        public bool isNonResponsiveFactory { get; set; }
        public string releaseVersion { get; set; }
        public bool isTablet { get; set; }
        public bool isMobile { get; set; }
        public bool isAdsEnabled { get; set; }
        public string searchType { get; set; }
        public string hashParam { get; set; }
        public int daysInFuture { get; set; }
        public int stayLength { get; set; }
        public bool isCoreDomainHopsTestEnabled { get; set; }
        public bool hasAtLeastOneTonightOnlyDeal { get; set; }
        public bool hasAtLeastOneMemberDeal { get; set; }
        public bool hasAtLeastOneTravelAd { get; set; }
    }

    public class Pagetitle
    {
        public string destination { get; set; }
        public bool hotelGroupSearch { get; set; }
        public bool isCitySearch { get; set; }
        public int hotelCount { get; set; }
        public int totalHotelCount { get; set; }
        public int availableCount { get; set; }
        public bool displayCount { get; set; }
        public bool isChangeHotel { get; set; }
        public bool isThemeSearch { get; set; }
    }

    public class Telesales
    {
        public bool isPhoneDisplay { get; set; }
        public bool isTooltipDisplay { get; set; }
        public string phoneNumber { get; set; }
        public string tooltipLink { get; set; }
    }

    public class Wizard
    {
        public string regionId { get; set; }
        public string parentRegionId { get; set; }
        public string searchString { get; set; }
        public string minDate { get; set; }
        public string maxDate { get; set; }
        public string dateRegEx { get; set; }
        public int maxStayLength { get; set; }
        public string dateFormat { get; set; }
        public string checkIn { get; set; }
        public string checkOut { get; set; }
        public int checkInYear { get; set; }
        public int checkInMonth { get; set; }
        public int checkInDay { get; set; }
        public int checkOutMonth { get; set; }
        public int checkOutDay { get; set; }
        public int checkOutYear { get; set; }
        public string checkInISO { get; set; }
        public string checkOutISO { get; set; }
        public bool isDatelessSearch { get; set; }
        public int maxRooms { get; set; }
        public int maxAdults { get; set; }
        public int maxChildren { get; set; }
        public int maxChildAge { get; set; }
        public int minChildAge { get; set; }
        public int totalAdults { get; set; }
        public int totalChildren { get; set; }
        public Room[] rooms { get; set; }
        public int selRoomIndex { get; set; }
        public object[] hotelIds { get; set; }
        public int totalCount { get; set; }
        public int countryRegionId { get; set; }
        public bool eventUrgencyExperiment { get; set; }
        public string useNewErrorMessages { get; set; }
        public string state { get; set; }
        public string shortName { get; set; }
        public string countryName { get; set; }
    }

    public class Room
    {
        public string adults { get; set; }
        public object[] childAges { get; set; }
    }

    public class Googlemap
    {
        public string staticUrl { get; set; }
        public string client { get; set; }
        public string language { get; set; }
        public bool enabled { get; set; }
    }

    public class Eds
    {
        public string dateFormat { get; set; }
        public string maxStayLength { get; set; }
        public string maxDate { get; set; }
    }

    public class Disclaimer
    {
        public bool isHaveEsrHotel { get; set; }
        public bool isSpecialRateNote { get; set; }
        public string supplementalDesc { get; set; }
        public int hotelCount { get; set; }
        public bool showOpaqueBanners { get; set; }
        public bool isPointOfSupplyCurrency { get; set; }
        public string pointOfSupplyCurrencyCode { get; set; }
    }

    public class Ads
    {
        public Adsensemodel adSenseModel { get; set; }
        public Adtargetingmodel adTargetingModel { get; set; }
        public string minifiedAdsUrl { get; set; }
        public string minifiedAdSenseUrl { get; set; }
        public string hookLogicBeaconSupportURL { get; set; }
        public int tpid { get; set; }
        public int eapid { get; set; }
        public string guid { get; set; }
    }

    public class Adsensemodel
    {
        public string channel { get; set; }
        public string client { get; set; }
        public string header { get; set; }
        public string test { get; set; }
        public string lang { get; set; }
        public string query { get; set; }
    }

    public class Adtargetingmodel
    {
        public string[] d { get; set; }
        public string[] pd { get; set; }
        public string ets { get; set; }
        public string ete { get; set; }
        public int regionid { get; set; }
        public int numadults { get; set; }
        public int kid { get; set; }
        public string[] dta { get; set; }
        public string elts { get; set; }
        public string elte { get; set; }
    }

    public class Travelad
    {
    }

    public class Doubleclick
    {
        public string opmDcQueryString { get; set; }
        public string msDcQueryString { get; set; }
    }

    public class Intentmedia
    {
    }

    public class Universaldataobject
    {
        public Context context { get; set; }
        public long utcTimestamp { get; set; }
        public Entity entity { get; set; }
        public Pageinfo pageInfo { get; set; }
        public string version { get; set; }
        public string domain { get; set; }
        public string action { get; set; }
        public Channeltracking channelTracking { get; set; }
        public Tvylchanneltracking tvylChannelTracking { get; set; }
        public string logSourceType { get; set; }
    }

    public class Context
    {
        //public User user { get; set; }
        public Site site { get; set; }

        public Clientinfo clientInfo { get; set; }
        public string parentRequestId { get; set; }
        public Marketingattribution marketingAttribution { get; set; }
    }

    //public class User
    //{
    //    public string guid { get; set; }
    //    public string tuid { get; set; }
    //}

    public class Site
    {
        public int siteId { get; set; }
        public string siteName { get; set; }
        public int eapid { get; set; }
    }

    public class Clientinfo
    {
        public string userAgent { get; set; }
        public string ipAddress { get; set; }
        public Coords coords { get; set; }
        public bool requestMadeByBot { get; set; }
        public Devicecharacteristics deviceCharacteristics { get; set; }
        public string fingerprintId { get; set; }
    }

    public class Coords
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int confidence { get; set; }
    }

    public class Devicecharacteristics
    {
        public string deviceOs { get; set; }
        public string deviceOsVersion { get; set; }
        public string mobileBrowser { get; set; }
        public string mobileBrowserVersion { get; set; }
        public string brandName { get; set; }
        public string modelName { get; set; }
        public bool tablet { get; set; }
        public bool wirelessDevice { get; set; }
        public int physicalScreenHeight { get; set; }
        public int physicalScreenWidth { get; set; }
        public int resolutionHeight { get; set; }
        public int resolutionWidth { get; set; }
        public bool mobile { get; set; }
    }

    public class Marketingattribution
    {
        public string campaignId { get; set; }
        public string campaignIdVisit { get; set; }
        public string searchEngineMarketingCode { get; set; }
        public string affiliateMarketingCode { get; set; }
        public string restrictedLastTouch { get; set; }
        public string searchEngineOrganicCode { get; set; }
        public long campaignIdTimestamp { get; set; }
        public long campaignIdVisitTimestamp { get; set; }
        public int emailIdTimestamp { get; set; }
        public int distributionPartnersTimestamp { get; set; }
        public long searchEngineMarketingCodeTimestamp { get; set; }
        public long affiliateMarketingCodeTimestamp { get; set; }
        public int onlineAdvertisingCodeTimestamp { get; set; }
        public int intraCompanyMarketingCodeTimestamp { get; set; }
        public long restrictedLastTouchTimestamp { get; set; }
        public long searchEngineOrganicCodeTimestamp { get; set; }
    }

    public class Entity
    {
        public object[] productTypes { get; set; }
        public Hotels hotels { get; set; }
    }

    public class Hotels
    {
        public Search search { get; set; }
        public Results results { get; set; }
        public Resultssummary resultsSummary { get; set; }
    }

    public class Search
    {
        public int numberOfRooms { get; set; }
        public string starRating { get; set; }
        public Hotelparameters hotelParameters { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
    }

    public class Hotelparameters
    {
        public int hotelId { get; set; }
        public int regionId { get; set; }
        public string checkInDate { get; set; }
        public string checkOutDate { get; set; }
        public int lengthOfStay { get; set; }
        public Room1[] rooms { get; set; }
        public int numberOfGuests { get; set; }
        public int countOfRoomNights { get; set; }
        public bool containsMixedRates { get; set; }
    }

    public class Room1
    {
        public int numAdults { get; set; }
        public int numChildren { get; set; }
        public object[] childAges { get; set; }
        public int numSeniors { get; set; }
        public int numberOfRoomsAvailable { get; set; }
        public object[] listOfPricesForDates { get; set; }
    }

    public class Results
    {
        public HotelResult[] results { get; set; }
    }

    public class HotelResult
    {
        public int hotelId { get; set; }
        public int regionId { get; set; }
        public int lengthOfStay { get; set; }
        public Room2[] rooms { get; set; }
        public Reviewsummary reviewSummary { get; set; }
        public int numberOfGuests { get; set; }
        public int countOfRoomNights { get; set; }
        public bool containsMixedRates { get; set; }
        public string hotelCountryCode { get; set; }
        public string hotelProvinceCode { get; set; }
    }

    public class Reviewsummary
    {
        public int totalReviews { get; set; }
        public float guestRating { get; set; }
    }

    public class Room2
    {
        public string roomTypeCode { get; set; }
        public int numAdults { get; set; }
        public int numChildren { get; set; }
        public object[] childAges { get; set; }
        public int numSeniors { get; set; }
        public Averageprice averagePrice { get; set; }
        public int numberOfRoomsAvailable { get; set; }
        public object[] listOfPricesForDates { get; set; }
        public Strikethruprice strikeThruPrice { get; set; }
    }

    public class Averageprice
    {
        public string currency { get; set; }
        public float amount { get; set; }
    }

    public class Strikethruprice
    {
        public string currency { get; set; }
        public float amount { get; set; }
    }

    public class Resultssummary
    {
        public int numberOfResults { get; set; }
        public Summaryprice summaryPrice { get; set; }
        public int unfilteredCount { get; set; }
        public int totalCount { get; set; }
        public int availCount { get; set; }
    }

    public class Summaryprice
    {
        public string currency { get; set; }
        public float amount { get; set; }
    }

    public class Pageinfo
    {
        public string pageName { get; set; }
        public object[] errorCodes { get; set; }
        public string lineOfBusiness { get; set; }
    }

    public class Channeltracking
    {
        public string company { get; set; }
        public string country { get; set; }
        public string network { get; set; }
        public string product { get; set; }
        public string parterName { get; set; }
        public string placement { get; set; }
        public string affcid { get; set; }
        public string channel { get; set; }
        public string channelExpiry { get; set; }
        public string channelSpecificCode { get; set; }
        public string conversionId { get; set; }
        public string rawCookie { get; set; }
    }

    public class Tvylchanneltracking
    {
    }

    public class Result1
    {
        public Retailhotelinfomodel retailHotelInfoModel { get; set; }
        public Retailhotelpricingmodel retailHotelPricingModel { get; set; }

        public string hotelId { get; set; }
        public string cityName { get; set; }

        public string normalizedHotelName { get; set; }
        public bool isFreeCancel { get; set; }
        public bool isPayLater { get; set; }
        public string infositeUrl { get; set; }
        public bool isSponsoredListing { get; set; }
        public bool isSponsoredLinkOffListing { get; set; }
        public string sponsoredListingClickTrackingRedirectUrl { get; set; }
        public string sponsoredListingImpressionTrackingUrl { get; set; }
        public string sponsoredListingExternalUrl { get; set; }
        public bool isDealOfTheDayListing { get; set; }
        public bool isCouponEligible { get; set; }
        public bool isSelectedListing { get; set; }
        public bool isGpgHotel { get; set; }
        public bool isLastStayedAt { get; set; }
        public bool isVacationRental { get; set; }
        public long freeCancelDate { get; set; }
        public int supplierScore { get; set; }
        public bool isTopHotel { get; set; }
        public bool isTravelAdCopyAvailable { get; set; }
        public int listingPosition { get; set; }
        public int listingTotal { get; set; }
        public string decoration { get; set; }
    }

    public class Retailhotelinfomodel
    {
        public string searchDestination { get; set; }
        public string searchType { get; set; }
        public bool datelessSearch { get; set; }
        public string hotelId { get; set; }
        public string hotelName { get; set; }
        public string localizedHotelName { get; set; }
        public string normalizedHotelName { get; set; }
        public string cityName { get; set; }
        public string twoLetterCountry { get; set; }
        public string threeLetterCountry { get; set; }
        public string provinceName { get; set; }
        public string neighborhood { get; set; }
        public string hotelDescription { get; set; }
        public string structureType { get; set; }
        public string cityAndNeighborhood { get; set; }
        public string shortneighborhood { get; set; }
        public string thumbnailURL { get; set; }
        public string largeThumbnailURL { get; set; }
        public string hotelStarRating { get; set; }
        public string hotelStarRatingCss { get; set; }
        public bool isOfficialStarRating { get; set; }
        public bool showDistanceInfo { get; set; }
        public float distanceInMiles { get; set; }
        public float distanceInKilometers { get; set; }
        public bool showMile { get; set; }
        public string distanceFormat { get; set; }
        public string localizedDistanceInMiles { get; set; }
        public string localizedDistanceInKilometers { get; set; }
        public bool hasLatitudeLongitudeInfo { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string automationId { get; set; }
        public string hotelType { get; set; }
        public string woodpeckerHotelType { get; set; }
        public bool aDudleyHotel { get; set; }
        public bool esrHotel { get; set; }
        public bool opaqueHotel { get; set; }
        public bool venereHotel { get; set; }
        public bool gdsHotel { get; set; }
        public bool daHotel { get; set; }
        public bool wotifHotel { get; set; }
        public bool jumboHotel { get; set; }
        public string reviewOverall { get; set; }
        public string reviewOverallCss { get; set; }
        public int reviewTotal { get; set; }
        public bool showRatingAndReviews { get; set; }
        public bool showReviews { get; set; }
        public float reviewPercentage { get; set; }
        public float cleanlinessRating { get; set; }
        public float serviceAndStaffRating { get; set; }
        public float roomComfortRating { get; set; }
        public float hotelConditionRating { get; set; }
        public bool showPhoneNumber { get; set; }
        public bool showPhoneTooltip { get; set; }
        public string phoneTooltipURL { get; set; }
        public string telephoneNumber { get; set; }
        public int numberOfRoomsLeftForUrgencyMsg { get; set; }
        public bool isNumOfRoomsLeftForLeadPrice { get; set; }
        public bool isVipAccess { get; set; }
        public bool isElitePlus { get; set; }
        public bool isNewHotel { get; set; }
        public bool isInsidersSelect { get; set; }
        public string sponsoredListingDescription { get; set; }
        public string sponsoredListingHeadline { get; set; }
        public object[] hotelExtraTexts { get; set; }
        public Familyfriendlyamenity[] familyFriendlyAmenities { get; set; }
        public bool familyFriendly { get; set; }
        public string superlativeMessage { get; set; }
    }

    public class Familyfriendlyamenity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Retailhotelpricingmodel
    {
        public bool isShowPricePopup { get; set; }
        public bool isShowPriceDisclaimer { get; set; }
        public float priceWithoutDrr { get; set; }
        public float price { get; set; }
        public int taxesAndFee { get; set; }
        public string priceWithoutDrrFormatted { get; set; }
        public float percentageSavings { get; set; }
        public string priceFormatted { get; set; }
        public string currencySymbol { get; set; }
        public bool showCurrencyAsSuffix { get; set; }
        public string ratePlanId { get; set; }
        public bool isMultiRatePlan { get; set; }
        public bool isBurnApplied { get; set; }
        public string packageSavingsFormatted { get; set; }
        public string referencePriceFormatted { get; set; }
        public bool isPackageSavingsSignificant { get; set; }
        public string pricePerNightFormatted { get; set; }
        public string referencePricePerNightFormatted { get; set; }
        public bool isDynamicPrice { get; set; }
        public bool isDrrDiscount { get; set; }
        public bool isDisplayDrrTooltip { get; set; }
        public string drrMessage { get; set; }
        public bool isMemberDiscount { get; set; }
        public int hotmipExpiration { get; set; }
        public int hotmipSecondsLeft { get; set; }
        public int hotmipPercentage { get; set; }
        public bool isHotmipThirdParty { get; set; }
        public string unavailableDescriptionRoom { get; set; }
        public string pricingStartDate { get; set; }
        public string pricingEndDate { get; set; }
        public int pricingNumberOfNightStay { get; set; }
        public int numOfRetailHotelRooms { get; set; }
        public int availabilityRoomCount { get; set; }
        public string continueButtonDesc { get; set; }
        public int pricingWindowRange { get; set; }
        public string pricingInfositeQueryString { get; set; }
        public int priceBucket { get; set; }
        public bool isETP { get; set; }
        public bool isPriceModified { get; set; }
        public float surveyPriceHigh { get; set; }
        public bool isChannelTypeMobile { get; set; }
        public bool isPointOfSupplyCurrency { get; set; }
        public string hotelId { get; set; }
        public string hotelType { get; set; }
        public string automationId { get; set; }
        public bool esrHotel { get; set; }
        public int drrTagID { get; set; }
        public int drrDescriptionID { get; set; }
        public int drrSecondsLeft { get; set; }
        public string drrExpirationDate { get; set; }
        public bool isSrcTypeRestricted { get; set; }
        public Restrictiontype restrictionType { get; set; }
        public string[] errorMessages { get; set; }
        public string errorCode { get; set; }
        public bool showClickMarkerForPrice { get; set; }
    }

    public class Restrictiontype
    {
        public bool isPOSRestricted { get; set; }
        public bool isMarketingChannelTypeRestricted { get; set; }
        public bool isSourceTypeRestricted { get; set; }
    }
}