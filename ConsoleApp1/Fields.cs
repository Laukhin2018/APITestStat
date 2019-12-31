using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Fields
    {
        WinsSumWithComission = 1,


        ImpressionsCount = 2,

        
       // ViewsCount = 3,


        ClicksCount = 4,


        //rejectedclickscount = 5,


        //postclickconversionscount = 6,


        //postviewconversionscount = 7,


        //pixelvisitcount = 8,


        //ActivePixelVisitCount = 9,


        /*PostBackEventsCount = 10,


        PostInstallEventCount = 11,

        StartEventsCount = 12,


        SkipEventsCount = 13,

        FirstQuartileEventsCount = 14,

        MidpointEventsCount = 15,

        ThirdQuartileEventsCount = 16,

        CompleteEventsCount = 17,


        MuteEventsCount = 18,

        UnmuteEventsCount = 19,

        PauseEventsCount = 20,

        RewindEventsCount = 21,

        ResumeEventsCount = 22,

        FullscreenEventsCount = 23,

        ExpandEventsCount = 24,

        CollapseEventsCount = 25,

        AcceptInvitationEventsCount = 26,

        CloseEventsCount = 27,

        CanvasView10S = 28,

        CanvasView20S = 29,

        CanvasView30S = 30,

        CanvasView60S = 31,

        CanvasView90S = 32,


        CanvasView120S = 33,


        CanvasView150S = 34,


        CanvasView180S = 35,


        CanvasView300S = 36,

        CanvasView25P = 37,

        CanvasView50P = 38,

        CanvasView75P = 39,


        CanvasView100P = 40,

        CanvasFormComplete = 41,

        CanvasCallCount = 42,*/

        Reach = 43,

        /*YandexMetricVisits = 46,

        YandexMetricBounceRate = 47,

        YandexMetricPageDepth = 48,

        YandexMetricVisitDuration = 49,

        //BetCount = 54, //выдает 500-ку

        //BetSum = 55, //выдает 500-ку

        CPI = 56,

        Denial = 57,

        CTR = 58,

        ECPM = 59,

        ECPC = 60,

        Viewability = 61,

        Frequency = 62,

        CostPer25Video = 63,

        CostPer50Video = 64,

        CostPer75Video = 65,

        CostPer100Video = 66,

        CostOfPostClickConversion = 67,

        CostOfPostViewConversion = 68,

        WinsCount = 69,

        Calls = 70,

        UnsupportedViewsCount = 71,

        GoogleAnalyticsVisits = 72,

        GoogleAnalyticsBounceRate = 73,

        GoogleAnalyticsPageDepth = 74,

        GoogleAnalyticsVisitDuration = 75,

        SegmentsPrice = 76,*/

        //TotalSum = 77,
/*
        #region Adloox

        /// <summary>
        /// Процент роботного трафика (фрода) (givt + sivt)
        /// </summary>
        AdlooxFraudPercent = 78,

        /// <summary>
        /// Процент неэффективного трафика (Inefficient)
        /// </summary>
        AdlooxInefficientPercent = 79,

        /// <summary>
        /// Процент просмотров
        /// </summary>
        AdlooxViewPercent = 80,

        /// <summary>
        /// Среднее время взаимодействия
        /// </summary>
        AdlooxExposureTime = 81,

        #endregion

        #region Event Api

        /// <summary>
        /// Отклоненные установки
        /// </summary>
        RejInstall = 82,

        /// <summary>
        /// Стоимость установки
        /// </summary>
        InstallCost = 83,

        /// <summary>
        /// Отклоненный звонок
        /// </summary>
        RejCall = 84,

        /// <summary>
        /// Стоимость звонка
        /// </summary>
        CallCost = 85,

        /// <summary>
        /// Сессия
        /// </summary>
        Session = 86,

        /// <summary>
        /// Отклоненная сессия
        /// </summary>
        RejSession = 87,

        /// <summary>
        /// Стоимость сессии
        /// </summary>
        SessionCost = 88,

        /// <summary>
        /// Удаление
        /// </summary>
        Unistall = 89,

        /// <summary>
        /// Отклоненное удаление
        /// </summary>
        RejUnistall = 90,

        /// <summary>
        /// Стоимость удаления
        /// </summary>
        UnistallCost = 91,

        /// <summary>
        /// Переустановка
        /// </summary>
        Reinstall = 92,

        /// <summary>
        /// Отклоненная переустановка
        /// </summary>
        RejReinstall = 93,

        /// <summary>
        /// Стоимость переустановки
        /// </summary>
        ReinstallCost = 94,

        /// <summary>
        /// Обновление
        /// </summary>
        Update = 95,

        /// <summary>
        /// Отклоненное обновление
        /// </summary>
        RejUpdate = 96,

        /// <summary>
        /// Стоимость обновления
        /// </summary>
        UpdateCost = 97,

        /// <summary>
        /// Повторная установка
        /// </summary>
        RepeatedInstall = 98,

        /// <summary>
        /// Отклоненная повторная установка
        /// </summary>
        RejRepeatedInstall = 99,

        /// <summary>
        /// Стоимость повторной установки
        /// </summary>
        RepeatedInstallCost = 100,

        /// <summary>
        /// Регистрация
        /// </summary>
        Registration = 101,

        /// <summary>
        /// Отклоненная регистрация
        /// </summary>
        RejRegistration = 102,

        /// <summary>
        /// Стоимость регистрации
        /// </summary>
        RegistrationCost = 103,

        /// <summary>
        /// Подписка
        /// </summary>
        Subscribe = 104,

        /// <summary>
        /// Отклоненная подписка
        /// </summary>
        RejSubscribe = 105,

        /// <summary>
        /// Стоимость подписки
        /// </summary>
        SubscribeCost = 106,

        /// <summary>
        /// Заказ
        /// </summary>
        Order = 107,

        /// <summary>
        /// Отклоненный заказ
        /// </summary>
        RejOrder = 108,

        /// <summary>
        /// Стоимость заказа
        /// </summary>
        OrderCost = 109,

        /// <summary>
        /// Событие 1
        /// </summary>
        Event1 = 110,

        /// <summary>
        /// Отклоненное событие 1
        /// </summary>
        RejEvent1 = 111,

        /// <summary>
        /// Стоимость события 1
        /// </summary>
        Event1Cost = 112,

        /// <summary>
        /// Событие 2
        /// </summary>
        Event2 = 113,

        /// <summary>
        /// Отклоненное событие 2
        /// </summary>
        RejEvent2 = 114,

        /// <summary>
        /// Стоимость события 2
        /// </summary>
        Event2Cost = 115,

        /// <summary>
        /// Событие 3
        /// </summary>
        Event3 = 116,

        /// <summary>
        /// Отклоненное событие 3
        /// </summary>
        RejEvent3 = 117,

        /// <summary>
        /// Стоимость события 3
        /// </summary>
        Event3Cost = 118,

        /// <summary>
        /// Событие 4
        /// </summary>
        Event4 = 119,

        /// <summary>
        /// Отклоненное событие 4
        /// </summary>
        RejEvent4 = 120,

        /// <summary>
        /// Стоимость события 4
        /// </summary>
        Event4Cost = 121,

        /// <summary>
        /// Событие 5
        /// </summary>
        Event5 = 122,

        /// <summary>
        /// Отклоненное событие 5
        /// </summary>
        RejEvent5 = 123,

        /// <summary>
        /// Стоимость события 5
        /// </summary>
        Event5Cost = 124,

        #endregion

        #region Creative API

        /// <summary>
        /// Остановка анимации
        /// </summary>
        StopAnimation = 125,

        /// <summary>
        /// Отклонённая остановка анимации
        /// </summary>
        RejStopAnimation = 126,

        /// <summary>
        /// Закрытие баннера
        /// </summary>
        CloseBanner = 127,

        /// <summary>
        /// Отклонённое закрытие баннера
        /// </summary>
        RejCloseBanner = 128,

        /// <summary>
        /// Наведение курсора на баннер
        /// </summary>
        MouseOver = 129,

        /// <summary>
        /// Среднне время взаимодействия с баннеров
        /// </summary>
        TimeExposure = 130,

        /// <summary>
        /// Среднее время до клика баннера
        /// </summary>
        TimeToClick = 131,

        /// <summary>
        /// Среднее время до просмотра баннера
        /// </summary>
        TimeToView = 132,

        /// <summary>
        /// Среднее время до закрытия баннера
        /// </summary>
        TimeToClose = 133,

        /// <summary>
        /// Раскрытие баннера
        /// </summary>
        ExpandBanner = 134,

        /// <summary>
        /// Старт игры
        /// </summary>
        StartGame = 135,

        /// <summary>
        /// Кастомное событие 1 баннера
        /// </summary>
        CustomBannerEvent1 = 136,

        /// <summary>
        /// Кастомное событие 2 баннера
        /// </summary>
        CustomBannerEvent2 = 137,

        SellCPI = 138,

        SellCPM = 139,

        SellCPC = 140,

        SellCostPer25Video = 141,

        SellCostPer50Video = 142,

        SellCostPer75Video = 143,

        SellCostPer100Video = 144,

        SellCostOfPostClickConversion = 145,

        SellCostOfPostViewConversion = 146,

        SellCost = 147,

        CostPerUnit = 148,

        #endregion

        /// <summary>
        /// Видимый показ
        /// </summary>
        StartVisibility = 149,

        /// <summary>
        /// Отклонённый видимый показ
        /// </summary>
        RejStartVisibility = 150,

        /// <summary>
        /// Загрузка баннера
        /// </summary>
        LoadBanner = 151,

        /// <summary>
        /// Отклонённая загрузка баннера
        /// </summary>
        RejLoadBanner = 152,

        /// <summary>
        /// Кастомное событие 3 баннера
        /// </summary>
        CustomBannerEvent3 = 153,

        /// <summary>
        /// Кастомное событие 4 баннера
        /// </summary>
        CustomBannerEvent4 = 154,

        /// <summary>
        /// Кастомное событие 5 баннера
        /// </summary>
        CustomBannerEvent5 = 155,

        /// <summary>
        /// Отклоненное кастомное событие 1 баннера
        /// </summary>
        RejCustomBannerEvent1 = 156,

        /// <summary>
        /// Отклоненное кастомное событие 2 баннера
        /// </summary>
        RejCustomBannerEvent2 = 157,

        /// <summary>
        /// Отклоненное кастомное событие 3 баннера
        /// </summary>
        RejCustomBannerEvent3 = 158,

        /// <summary>
        /// Отклоненное кастомное событие 4 баннера
        /// </summary>
        RejCustomBannerEvent4 = 159,

        /// <summary>
        /// Отклоненное кастомное событие 5 баннера
        /// </summary>
        //RejCustomBannerEvent5 = 160*/
    }
}
