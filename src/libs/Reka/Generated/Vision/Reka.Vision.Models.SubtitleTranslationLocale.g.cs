
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Allowed locale codes (underscore BCP-47 style) for subtitle translation.
    /// </summary>
    public enum SubtitleTranslationLocale
    {
        /// <summary>
        /// 
        /// </summary>
        ArSa,
        /// <summary>
        /// 
        /// </summary>
        CsCz,
        /// <summary>
        /// 
        /// </summary>
        DaDk,
        /// <summary>
        /// 
        /// </summary>
        DeDe,
        /// <summary>
        /// 
        /// </summary>
        ElGr,
        /// <summary>
        /// 
        /// </summary>
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        EsMx,
        /// <summary>
        /// 
        /// </summary>
        FiFi,
        /// <summary>
        /// 
        /// </summary>
        FilPh,
        /// <summary>
        /// 
        /// </summary>
        FrCa,
        /// <summary>
        /// 
        /// </summary>
        FrFr,
        /// <summary>
        /// 
        /// </summary>
        HeIl,
        /// <summary>
        /// 
        /// </summary>
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        HuHu,
        /// <summary>
        /// 
        /// </summary>
        IdId,
        /// <summary>
        /// 
        /// </summary>
        ItIt,
        /// <summary>
        /// 
        /// </summary>
        JaJp,
        /// <summary>
        /// 
        /// </summary>
        KoKr,
        /// <summary>
        /// 
        /// </summary>
        MsMy,
        /// <summary>
        /// 
        /// </summary>
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        NoNo,
        /// <summary>
        /// 
        /// </summary>
        PlPl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        RoRo,
        /// <summary>
        /// 
        /// </summary>
        RuRu,
        /// <summary>
        /// 
        /// </summary>
        SvSe,
        /// <summary>
        /// 
        /// </summary>
        ThTh,
        /// <summary>
        /// 
        /// </summary>
        TrTr,
        /// <summary>
        /// 
        /// </summary>
        UkUa,
        /// <summary>
        /// 
        /// </summary>
        ViVn,
        /// <summary>
        /// 
        /// </summary>
        ZhCn,
        /// <summary>
        /// 
        /// </summary>
        ZhTw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubtitleTranslationLocaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubtitleTranslationLocale value)
        {
            return value switch
            {
                SubtitleTranslationLocale.ArSa => "ar_SA",
                SubtitleTranslationLocale.CsCz => "cs_CZ",
                SubtitleTranslationLocale.DaDk => "da_DK",
                SubtitleTranslationLocale.DeDe => "de_DE",
                SubtitleTranslationLocale.ElGr => "el_GR",
                SubtitleTranslationLocale.EnGb => "en_GB",
                SubtitleTranslationLocale.EnUs => "en_US",
                SubtitleTranslationLocale.EsEs => "es_ES",
                SubtitleTranslationLocale.EsMx => "es_MX",
                SubtitleTranslationLocale.FiFi => "fi_FI",
                SubtitleTranslationLocale.FilPh => "fil_PH",
                SubtitleTranslationLocale.FrCa => "fr_CA",
                SubtitleTranslationLocale.FrFr => "fr_FR",
                SubtitleTranslationLocale.HeIl => "he_IL",
                SubtitleTranslationLocale.HiIn => "hi_IN",
                SubtitleTranslationLocale.HuHu => "hu_HU",
                SubtitleTranslationLocale.IdId => "id_ID",
                SubtitleTranslationLocale.ItIt => "it_IT",
                SubtitleTranslationLocale.JaJp => "ja_JP",
                SubtitleTranslationLocale.KoKr => "ko_KR",
                SubtitleTranslationLocale.MsMy => "ms_MY",
                SubtitleTranslationLocale.NlNl => "nl_NL",
                SubtitleTranslationLocale.NoNo => "no_NO",
                SubtitleTranslationLocale.PlPl => "pl_PL",
                SubtitleTranslationLocale.PtBr => "pt_BR",
                SubtitleTranslationLocale.PtPt => "pt_PT",
                SubtitleTranslationLocale.RoRo => "ro_RO",
                SubtitleTranslationLocale.RuRu => "ru_RU",
                SubtitleTranslationLocale.SvSe => "sv_SE",
                SubtitleTranslationLocale.ThTh => "th_TH",
                SubtitleTranslationLocale.TrTr => "tr_TR",
                SubtitleTranslationLocale.UkUa => "uk_UA",
                SubtitleTranslationLocale.ViVn => "vi_VN",
                SubtitleTranslationLocale.ZhCn => "zh_CN",
                SubtitleTranslationLocale.ZhTw => "zh_TW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubtitleTranslationLocale? ToEnum(string value)
        {
            return value switch
            {
                "ar_SA" => SubtitleTranslationLocale.ArSa,
                "cs_CZ" => SubtitleTranslationLocale.CsCz,
                "da_DK" => SubtitleTranslationLocale.DaDk,
                "de_DE" => SubtitleTranslationLocale.DeDe,
                "el_GR" => SubtitleTranslationLocale.ElGr,
                "en_GB" => SubtitleTranslationLocale.EnGb,
                "en_US" => SubtitleTranslationLocale.EnUs,
                "es_ES" => SubtitleTranslationLocale.EsEs,
                "es_MX" => SubtitleTranslationLocale.EsMx,
                "fi_FI" => SubtitleTranslationLocale.FiFi,
                "fil_PH" => SubtitleTranslationLocale.FilPh,
                "fr_CA" => SubtitleTranslationLocale.FrCa,
                "fr_FR" => SubtitleTranslationLocale.FrFr,
                "he_IL" => SubtitleTranslationLocale.HeIl,
                "hi_IN" => SubtitleTranslationLocale.HiIn,
                "hu_HU" => SubtitleTranslationLocale.HuHu,
                "id_ID" => SubtitleTranslationLocale.IdId,
                "it_IT" => SubtitleTranslationLocale.ItIt,
                "ja_JP" => SubtitleTranslationLocale.JaJp,
                "ko_KR" => SubtitleTranslationLocale.KoKr,
                "ms_MY" => SubtitleTranslationLocale.MsMy,
                "nl_NL" => SubtitleTranslationLocale.NlNl,
                "no_NO" => SubtitleTranslationLocale.NoNo,
                "pl_PL" => SubtitleTranslationLocale.PlPl,
                "pt_BR" => SubtitleTranslationLocale.PtBr,
                "pt_PT" => SubtitleTranslationLocale.PtPt,
                "ro_RO" => SubtitleTranslationLocale.RoRo,
                "ru_RU" => SubtitleTranslationLocale.RuRu,
                "sv_SE" => SubtitleTranslationLocale.SvSe,
                "th_TH" => SubtitleTranslationLocale.ThTh,
                "tr_TR" => SubtitleTranslationLocale.TrTr,
                "uk_UA" => SubtitleTranslationLocale.UkUa,
                "vi_VN" => SubtitleTranslationLocale.ViVn,
                "zh_CN" => SubtitleTranslationLocale.ZhCn,
                "zh_TW" => SubtitleTranslationLocale.ZhTw,
                _ => null,
            };
        }
    }
}