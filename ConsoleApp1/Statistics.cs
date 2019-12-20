using System;

namespace ConsoleApp1
{
    public class Statistics
    {
        public string SplitName { get; set; }

        public DateTime? Day { get; set; }

        public int? Hour { get; set; }

        public DateTime? Week { get; set; }

        public DateTime? Month { get; set; }

        public TrafficType? TrafficType { get; set; }

        public DeviceType? DeviceType { get; set; }

        public Os? Os { get; set; }

        public Browser? Browser { get; set; }

        public int? OrderId { get; set; }

        public int? SspId { get; set; }

        public int? AdWidth { get; set; }

        public int? AdHeight { get; set; }

        public ConnectionType? ConnectionType { get; set; }

        public Gender? Gender { get; set; }

        public int? AidataSegmentId { get; set; }

        public int? WeboramaSegmentId { get; set; }

        public int? DigisegSegmentId { get; set; }

        public int? OnaudienceSegmentId { get; set; }

        public int? AdexSegmentId { get; set; }

        public int? AvitoSegmentId { get; set; }

        public int? CleverDataSegmentId { get; set; }

        public int? AmberDataSegmentId { get; set; }

        public int? BetCount { get; set; }

        public double? BetSum { get; set; }

        public double? TotalSum { get; set; }

        public double?  SumWinningPrice {get; set;}

        public int? WinCount { get; set; }

        public int? ImpressionCount { get; set; }

        public int? ClickCount { get; set; }

        public int? CloseEventsCount { get; set; }

        public int? Reach { get; set; }

        public double? CTR { get; set; }

        public double? SellCPI { get; set; }

        public double? SellCPM { get; set; }

        public double? SellCPC { get; set; }

        public double? SellCostPer25Video { get; set; }

        public double? SellCostPer50Video { get; set; }

        public double? SellCostPer75Video { get; set; }

        public double? SellCostPer100Video { get; set; }

        public double? SellCostOfPostClickConversion { get; set; }

        public double? SellCostOfPostViewConversion { get; set; }

        public double? RejectedClicksCount { get; set; }


        public double? PostClickConversionsCount { get; set; }


        public double? PostViewConversionsCount { get; set; }


        public double? PixelVisitCount { get; set; }


        public double? ActivePixelVisitCount { get; set; }


        public double? PostBackEventsCount { get; set; }


        public double? PostInstallEventCount { get; set; }

        public double? StartEventsCount { get; set; }


        public double? SkipEventsCount { get; set; }

        public double? FirstQuartileEventsCount { get; set; }

        public double? MidpointEventsCount { get; set; }

        public double? ThirdQuartileEventsCount { get; set; }

        public double? CompleteEventsCount { get; set; }


        public double? MuteEventsCount { get; set; }

        public double? UnmuteEventsCount { get; set; }

        public double? PauseEventsCount { get; set; }

        public double? RewindEventsCount { get; set; }

        public double? ResumeEventsCount { get; set; }

        public double? FullscreenEventsCount { get; set; }

        public double? ExpandEventsCount { get; set; }

        public double? CollapseEventsCount { get; set; }

        public double? AcceptInvitationEventsCount { get; set; }

        public double? CanvasView10S { get; set; }

        public double? CanvasView20S { get; set; }

        public double? CanvasView30S { get; set; }

        public double? CanvasView60S { get; set; }

        public double? CanvasView90S { get; set; }

        public double? CanvasView120S { get; set; }

        public double? CanvasView150S { get; set; }

        public double? CanvasView180S { get; set; }

        public double? CanvasView300S { get; set; }

        public double? CanvasView25P { get; set; }

        public double? CanvasView50P { get; set; }

        public double? CanvasView75P { get; set; }

        public double? CanvasView100P { get; set; }

        public double? CanvasFormComplete { get; set; }

        public double? CanvasCallCount { get; set; }

        public double? YandexMetricVisits { get; set; }

        public double? YandexMetricBounceRate { get; set; }

        public double? YandexMetricPageDepth { get; set; }

        public double? YandexMetricVisitDuration { get; set; }

        public double? CPI { get; set; }

        public double? Denial { get; set; }

        public double? ECPM { get; set; }

        public double? ECPC { get; set; }

        public double? Viewability { get; set; }

        public double? Frequency { get; set; }

        public double? CostPer25Video { get; set; }

        public double? CostPer50Video { get; set; }

        public double? CostPer75Video { get; set; }

        public double? CostPer100Video { get; set; }

        public double? CostOfPostClickConversion { get; set; }

        public double? CostOfPostViewConversion { get; set; }

        public double? WinsCount { get; set; }

        public double? Calls { get; set; }

        public double? UnsupportedViewsCount { get; set; }

        public double? GoogleAnalyticsVisits { get; set; }

        public double? GoogleAnalyticsBounceRate { get; set; }

        public double? GoogleAnalyticsPageDepth { get; set; }

        public double? GoogleAnalyticsVisitDuration { get; set; }

        public double? SegmentsPrice { get; set; }

        public double? AdlooxFraudPercent { get; set; }


        public double? AdlooxInefficientPercent { get; set; }


        public double? AdlooxViewPercent { get; set; }


        public double? AdlooxExposureTime { get; set; }


        public double? RejInstall { get; set; }


        public double? InstallCost { get; set; }

        public double? RejCall { get; set; }


        public double? CallCost { get; set; }


        public double? Session { get; set; }


        public double? RejSession { get; set; }


        public double? SessionCost { get; set; }


        public double? Unistall { get; set; }


        public double? RejUnistall { get; set; }


        public double? UnistallCost { get; set; }

        public double? Reinstall { get; set; }


        public double? RejReinstall { get; set; }


        public double? ReinstallCost { get; set; }

        public double? Update { get; set; }


        public double? RejUpdate { get; set; }


        public double? UpdateCost { get; set; }


        public double? RepeatedInstall { get; set; }


        public double? RejRepeatedInstall { get; set; }


        public double? RepeatedInstallCost { get; set; }


        public double? Registration { get; set; }

        public double? RejRegistration { get; set; }


        public double? RegistrationCost { get; set; }


        public double? Subscribe { get; set; }


        public double? RejSubscribe { get; set; }


        public double? SubscribeCost { get; set; }



        public double? Order { get; set; }


        public double? RejOrder { get; set; }



        public double? OrderCost { get; set; }


        public double? Event1 { get; set; }



        public double? RejEvent1 { get; set; }



        public double? Event1Cost { get; set; }



        public double? Event2 { get; set; }


        public double? RejEvent2 { get; set; }


        public double? Event2Cost { get; set; }



        public double? Event3 { get; set; }



        public double? RejEvent3 { get; set; }



        public double? Event3Cost { get; set; }


        public double? Event4 { get; set; }



        public double? RejEvent4 { get; set; }



        public double? Event4Cost { get; set; }


        public double? Event5 { get; set; }


        public double? RejEvent5 { get; set; }

        public double? Event5Cost { get; set; }

        public double? StopAnimation { get; set; }


        public double? RejStopAnimation { get; set; }


        public double? CloseBanner { get; set; }

        public double? RejCloseBanner { get; set; }

        public double? MouseOver { get; set; }


        public double? TimeExposure { get; set; }


        public double? TimeToClick { get; set; }


        public double? TimeToView { get; set; }


        public double? TimeToClose { get; set; }



        public double? ExpandBanner { get; set; }


        public double? StartGame { get; set; }


        public double? CustomBannerEvent1 { get; set; }

        public double? CustomBannerEvent2 { get; set; }      

        public double? SellCost { get; set; }

        public double? CostPerUnit { get; set; }

        public double? StartVisibility { get; set; }

        public double? RejStartVisibility { get; set; }

        public double? LoadBanner { get; set; }

        public double? RejLoadBanner { get; set; }

        public double? CustomBannerEvent3 { get; set; }

        public double? CustomBannerEvent4 { get; set; }

        public double? CustomBannerEvent5 { get; set; }

        public double? RejCustomBannerEvent1 { get; set; }

        public double? RejCustomBannerEvent2 { get; set; }

        public double? RejCustomBannerEvent3 { get; set; }

        public double? RejCustomBannerEvent4 { get; set; }







        //public override string ToString()
        //{
        //    return "SellCPM " + SellCPM.ToString() + "SellCostOfPostViewConversion " + SellCostOfPostViewConversion.ToString();
        //}
    }
}
