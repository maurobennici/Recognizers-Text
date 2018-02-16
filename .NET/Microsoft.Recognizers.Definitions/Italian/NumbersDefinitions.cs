﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Italian\Italian-Numbers.yaml
//     - Language: Italian
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Italian
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = "It";
		public const string RoundNumberIntegerRegex = @"(cento|mille|milione|milioni|miliardo|miliardi|trilione|trilioni)";
		public const string ZeroToNineIntegerRegex = @"(e uno|un|uno|una|due|tre|quattro|cinque|sei|sette|otto|nove|zero)";
		public const string TenToNineteenIntegerRegex = @"(diciassette|tredici|quattordici|diciotto|diciannove|quindici|sedici|undici|dodici|dieci)";
		public const string TensNumberIntegerRegex = @"(settanta|venti|trenta|ottanta|novanta|quaranta|cinquanta|sessanta)";
		public const string DigitsNumberRegex = @"\d|\d{1,3}(\.\d{3})";
		public static readonly string HundredsNumberIntegerRegex = $@"(({ZeroToNineIntegerRegex}(\s+cento))|cento|((\s+cento\s)+{TensNumberIntegerRegex}))";
		public static readonly string BelowHundredsRegex = $@"(({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\W+{ZeroToNineIntegerRegex})?))|{ZeroToNineIntegerRegex})";
		public static readonly string BelowThousandsRegex = $@"(({HundredsNumberIntegerRegex}(\s+{BelowHundredsRegex})?|{BelowHundredsRegex}|{TenToNineteenIntegerRegex})|cento\s+{TenToNineteenIntegerRegex})";
		public static readonly string SupportThousandsRegex = $@"(({BelowThousandsRegex}|{BelowHundredsRegex})\s+{RoundNumberIntegerRegex}(\s+{RoundNumberIntegerRegex})?)";
		public static readonly string SeparaIntRegex = $@"({SupportThousandsRegex}(\s+{SupportThousandsRegex})*(\s+{BelowThousandsRegex})?|{BelowThousandsRegex})";
		public static readonly string AllIntRegex = $@"({SeparaIntRegex}|mille(\s+{BelowThousandsRegex})?)";
		public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<=\W|^)-\s*)|(?<=\b))\d+(?!(,\d+[a-zA-Z]))(?={placeholder})";
		public const string NumbersWithSuffix = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*(k|M|T|G)(?=\b)";
		public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)({DigitsNumberRegex})+\s+{RoundNumberIntegerRegex}(?=\b)";
		public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+dozzina(e)?(?=\b)";
		public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
		public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((half\s+)?a\s+dozzina)|({AllIntRegex}\s+dozzina(e)?))(?=\b)";
		public const string SimpleRoundOrdinalRegex = @"(centesim[oa]|millesim[oa]|milionesim[oa]|miliardesim[oa]|trilionesim[oa])";
		public const string OneToNineOrdinalRegex = @"(prim[oa]|secondo[oa]|terz[oa]|quart[oa]|quint[oa]|sest[oa]|settim[oa]|ottav[oa]|non[oa])";
		public const string SpecialUnderHundredOrdinalRegex = @"(onzi[eè]me|douzi[eè]me)";
		public const string TensOrdinalRegex = @"(|decim[oa]|undicesim[oa]|dodicesim[oa]|tredicesim[oa]|quattordicesim[oa]|quindicesim[oa]|sedicesim[oa]|diciassettesim[oa]|diciottesim[oa]|diciannovesim[oa]|ventesim[oa]|trentesim[oa]|quarantesim[oa]|cinquantesim[oa]|sessantesim[oa]|settantesim[oa]|otantesim[oa]|novantesim[oa])";
		public static readonly string HundredOrdinalRegex = $@"({AllIntRegex}(\s+(centesim[oa]\s)))";
		public static readonly string UnderHundredOrdinalRegex = $@"((({AllIntRegex}(\W)?)?{OneToNineOrdinalRegex})|({TensNumberIntegerRegex}(\W)?)?{OneToNineOrdinalRegex}|{TensOrdinalRegex}|{SpecialUnderHundredOrdinalRegex})";
		public static readonly string UnderThousandOrdinalRegex = $@"((({HundredOrdinalRegex}(\s)?)?{UnderHundredOrdinalRegex})|(({AllIntRegex}(\W)?)?{SimpleRoundOrdinalRegex})|{HundredOrdinalRegex})";
		public static readonly string OverThousandOrdinalRegex = $@"(({AllIntRegex})(i[eè]me))";
		public static readonly string ComplexOrdinalRegex = $@"(({OverThousandOrdinalRegex}(\s)?)?{UnderThousandOrdinalRegex}|{OverThousandOrdinalRegex}|{UnderHundredOrdinalRegex})";
		public static readonly string SuffixOrdinalRegex = $@"(({AllIntRegex})({SimpleRoundOrdinalRegex}))";
		public static readonly string ComplexRoundOrdinalRegex = $@"((({SuffixOrdinalRegex}(\s)?)?{ComplexOrdinalRegex})|{SuffixOrdinalRegex})";
		public static readonly string AllOrdinalRegex = $@"({ComplexOrdinalRegex}|{SimpleRoundOrdinalRegex}|{ComplexRoundOrdinalRegex})";
		public const string PlaceHolderPureNumber = @"\b";
		public const string PlaceHolderDefault = @"\D|\b";
		public const string OrdinalSuffixRegex = @"(?<=\b)((\d*(1°|2°|3°|4°|5°|6°|7°|8°|9°|0°))|(11°|12°))(?=\b)";
		public static readonly string OrdinalFrenchRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
		public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
		public const string FractionNotationRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
		public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+(e\s+)?)?({AllIntRegex})(\s+|\s*-\s*)((({AllOrdinalRegex})|({SuffixOrdinalRegex}))s|mezzo|quarto)(?=\b)";
		public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(e\s+)?)?(un|uno|una)(\s+|\s*-\s*)(({AllOrdinalRegex})|({SuffixOrdinalRegex})|mezzo|quarto)(?=\b)";
		public static readonly string FractionPrepositionRegex = $@"(?<=\b)(({AllIntRegex})|((?<!\.)\d+))\s+over\s+(({AllIntRegex})|(\d+)(?!\.))(?=\b)";
		public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
		public static readonly string AllFloatRegex = $@"({AllIntRegex}(\s+(virgule|point)){AllPointRegex})";
		public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))\d+,\d+(?!(,\d+))(?={placeholder})";
		public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+)),\d+(?!(,\d+))(?={placeholder})";
		public const string DoubleWithMultiplierRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\,)))\d+,\d+\s*(K|k|M|G|T)(?=\b)";
		public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\,)))\d+,\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
		public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)e([+-]*[1-9]\d*)(?=\b)";
		public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
		public const string CurrencyRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*(B|b|m|t|g)(?=\b)";
		public static readonly string NumberWithSuffixPercentage = $@"({BaseNumbers.NumberReplaceToken})(\s*)(%|percento|per cento)";
		public static readonly string NumberWithPrefixPercentage = $@"(percento di|per cento di)(\s*)({BaseNumbers.NumberReplaceToken})";
		public const char DecimalSeparatorChar = ',';
		public const string FractionMarkerToken = "su";
		public const char NonDecimalSeparatorChar = '.';
		public const string HalfADozenText = "sei";
		public const string WordSeparatorToken = "e";
		public static readonly string[] WrittenDecimalSeparatorTexts = { "virgule" };
		public static readonly string[] WrittenGroupSeparatorTexts = { "point", "points" };
		public static readonly string[] WrittenIntegerSeparatorTexts = { "e", "-" };
		public static readonly string[] WrittenFractionSeparatorTexts = { "e", "su" };
		public const string HalfADozenRegex = @"mezza\s+dozzina";
		public const string DigitalNumberRegex = @"((?<=\b)(cento|mille|milione|milioni|miliardo|miliardi|trilione|trilioni|dozzina|dozzine)(?=\b))|((?<=(\d|\b))(k|t|m|g|b)(?=\b))";
		public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
		{
			{ "zero", 0 },
			{ "un", 1 },
			{ "una", 1 },
			{ "uno", 1 },
			{ "due", 2 },
			{ "tre", 3 },
			{ "quattro", 4 },
			{ "cinque", 5 },
			{ "sei", 6 },
			{ "sette", 7 },
			{ "otto", 8 },
			{ "nove", 9 },
			{ "dieci", 10 },
			{ "undici", 11 },
			{ "dodici", 12 },
			{ "dozzina", 12 },
			{ "dozzine", 12 },
			{ "tredici", 13 },
			{ "quattordici", 14 },
			{ "quindici", 15 },
			{ "sedici", 16 },
			{ "diciassette", 17 },
			{ "diciotto", 18 },
			{ "diciannove", 19 },
			{ "venti", 20 },
			{ "trenta", 30 },
			{ "quaranta", 40 },
			{ "cinquanta", 50 },
			{ "sessanta", 60 },
			{ "settanta", 70 },
			{ "ottanta", 80 },
			{ "novanta", 90 },
			{ "cento", 100 },
			{ "mille", 1000 },
			{ "un milione", 1000000 },
			{ "milione", 1000000 },
			{ "milioni", 1000000 },
			{ "un miliardo", 1000000000 },
			{ "miliardo", 1000000000 },
			{ "miliardi", 1000000000 },
			{ "un trilione", 1000000000000 },
			{ "trilione", 1000000000000 },
			{ "trilioni", 1000000000000 }
		};
		public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
		{
			{ "primo", 1 },
			{ "prima", 1 },
			{ "secondo", 2 },
			{ "seconda", 2 },
			{ "metà", 2 },
			{ "terzo", 3 },
			{ "terza", 3 },
			{ "quarto", 4 },
			{ "quarta", 4 },
			{ "quinto", 5 },
			{ "quinta", 5 },
			{ "sesto", 6 },
			{ "sesta", 6 },
			{ "settimo", 7 },
			{ "settima", 7 },
			{ "ottavo", 8 },
			{ "ottava", 8 },
			{ "nono", 9 },
			{ "nona", 9 },
			{ "decimo", 10 },
			{ "decima", 10 },
			{ "undicesimo", 11 },
			{ "undicesima", 11 },
			{ "dodicesimo", 12 },
			{ "dodicesima", 12 },
			{ "tredicesimo", 13 },
			{ "tredicesima", 13 },
			{ "quattordicesimo", 14 },
			{ "quattordicesima", 14 },
			{ "quindicisimo", 15 },
			{ "quindicisima", 15 },
			{ "sedicesimo", 16 },
			{ "sedicesima", 16 },
			{ "diciassettesimo", 17 },
			{ "diciassettesima", 17 },
			{ "diciottesimo", 18 },
			{ "diciottesima", 18 },
			{ "diciannovesimo", 19 },
			{ "diciannovesima", 19 },
			{ "ventesimo", 20 },
			{ "ventesima", 20 },
			{ "ventunesimo", 21 },
			{ "ventunesima", 21 },
			{ "trentesimo", 30 },
			{ "trentesima", 30 },
			{ "quarantesimo", 40 },
			{ "quarantesima", 40 },
			{ "cinquantesimo", 50 },
			{ "cinquantesima", 50 },
			{ "sessantesimo", 60 },
			{ "sessantesima", 60 },
			{ "settantesimo", 70 },
			{ "settantesima", 70 },
			{ "ottantesimo", 80 },
			{ "ottantesima", 80 },
			{ "novantesimo", 90 },
			{ "novantesima", 90 },
			{ "centesimo", 100 },
			{ "centesima", 100 },
			{ "millesimo", 1000 },
			{ "millesima", 1000 },
			{ "milionesimo", 1000000 },
			{ "milionesima", 1000000 },
			{ "miliardesimo", 1000000000 },
			{ "miliardesima", 1000000000 },
			{ "trilionesimo", 1000000000000 },
			{ "trilionesima", 1000000000000 },
			{ "primi", 1 },
			{ "prime", 1 },
			{ "secondi", 2 },
			{ "seconde", 2 },
			{ "terzi", 3 },
			{ "terze", 3 },
			{ "quarti", 4 },
			{ "quarte", 4 },
			{ "quinti", 5 },
			{ "quinte", 5 },
			{ "sesti", 6 },
			{ "seste", 6 },
			{ "settimi", 7 },
			{ "settime", 7 },
			{ "ottavi", 8 },
			{ "ottave", 8 },
			{ "noni", 9 },
			{ "none", 9 },
			{ "decimi", 10 },
			{ "decime", 10 },
			{ "undicesimi", 11 },
			{ "undicesime", 11 },
			{ "dodicesimi", 12 },
			{ "dodicesime", 12 },
			{ "tredicesimi", 13 },
			{ "tredicesime", 13 },
			{ "quattordicesimi", 14 },
			{ "quattordicesime", 14 },
			{ "quindicesimi", 15 },
			{ "quindicesime", 15 },
			{ "sedicesimi", 16 },
			{ "sedicesime", 16 },
			{ "diciassettesimi", 17 },
			{ "diciassettesime", 17 },
			{ "diciottesimi", 18 },
			{ "diciottesime", 18 },
			{ "diciannovesimi", 19 },
			{ "diciannovesime", 19 },
			{ "ventesimi", 20 },
			{ "ventesime", 20 },
			{ "trentesimi", 30 },
			{ "trentesime", 30 },
			{ "quarantesimi", 40 },
			{ "quarantesime", 40 },
			{ "cinquantesimi", 50 },
			{ "cinquantesime", 50 },
			{ "sessantesimi", 60 },
			{ "sessantesime", 60 },
			{ "settantesimi", 70 },
			{ "settantesime", 70 },
			{ "ottantesimi", 80 },
			{ "ottantesime", 80 },
			{ "novantesimi", 90 },
			{ "novantesime", 90 },
			{ "centesimi", 100 },
			{ "centesime", 100 },
			{ "millesimi", 1000 },
			{ "millesime", 1000 },
			{ "milionesimi", 1000000 },
			{ "milionesime", 1000000 },
			{ "miliardersimi", 1000000000 },
			{ "miliardersime", 1000000000 },
			{ "trilioneisimi", 1000000000000 },
			{ "trilionesime", 1000000000000 }
		};
		public static readonly Dictionary<string, long> PrefixCardinalDictionary = new Dictionary<string, long>
		{
			{ "due", 2 },
			{ "tre", 3 },
			{ "quattro", 4 },
			{ "cinque", 5 },
			{ "sei", 6 },
			{ "sette", 7 },
			{ "otto", 8 },
			{ "nove", 9 },
			{ "dieci", 10 },
			{ "undici", 11 },
			{ "dodici", 12 },
			{ "tredici", 13 },
			{ "quattordici", 14 },
			{ "quindici", 15 },
			{ "sedici", 16 },
			{ "diciassette", 17 },
			{ "diciotto", 18 },
			{ "diciannove", 19 },
			{ "venti", 20 },
			{ "ventuno", 21 },
			{ "ventidue", 22 },
			{ "ventitre", 23 },
			{ "ventiquattro", 24 },
			{ "venticinque", 25 },
			{ "ventisei", 26 },
			{ "ventisette", 27 },
			{ "ventotto", 28 },
			{ "ventinove", 29 },
			{ "trenta", 30 },
			{ "trentuno", 31 },
			{ "quaranta", 40 },
			{ "cinquanta", 50 },
			{ "sessanta", 60 },
			{ "settanta", 70 },
			{ "ottanta", 80 },
			{ "novanta", 90 },
			{ "cento", 100 },
			{ "due cento", 200 },
			{ "duecento", 200 },
			{ "tre cento", 300 },
			{ "trecento", 300 },
			{ "quattro cento", 400 },
			{ "quattrocento", 400 },
			{ "cinque cento", 500 },
			{ "cinquecento", 500 },
			{ "sei cento", 600 },
			{ "seicento", 600 },
			{ "sette cento", 700 },
			{ "settecento", 700 },
			{ "otto cento", 800 },
			{ "ottocento", 800 },
			{ "nove cento", 900 },
			{ "novecento", 900 }
		};
		public static readonly Dictionary<string, long> SufixOrdinalDictionary = new Dictionary<string, long>
		{
			{ "mille", 1000 },
			{ "milione", 1000000 },
			{ "miliardo", 1000000000 }
		};
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ "cento", 100 },
			{ "mille", 1000 },
			{ "milione", 1000000 },
			{ "milioni", 1000000 },
			{ "miliardo", 1000000000 },
			{ "miliardi", 1000000000 },
			{ "trilione", 1000000000000 },
			{ "trilioni", 1000000000000 },
			{ "centinaio", 100 },
			{ "centinai", 100 },
			{ "centinaie", 100 },
			{ "millesimo", 1000 },
			{ "milionesimo", 1000000 },
			{ "miliardersimo", 1000000000 },
			{ "trilioneisimo", 1000000000000 },
			{ "millesima", 1000 },
			{ "milionesima", 1000000 },
			{ "miliardersima", 1000000000 },
			{ "trilioneisima", 1000000000000 },
			{ "millesimi", 1000 },
			{ "milionesimi", 1000000 },
			{ "miliardersimi", 1000000000 },
			{ "trilioneisimi", 1000000000000 },
			{ "millesime", 1000 },
			{ "milionesime", 1000000 },
			{ "miliardersime", 1000000000 },
			{ "trilioneisime", 1000000000000 },
			{ "centinaia", 100 },
			{ "migliaia", 1000 },
			{ "milionata", 1000000 },
			{ "miliardata", 1000000000 },
			{ "trilionata", 1000000000000 },
			{ "dozzina", 12 },
			{ "dozzine", 12 },
			{ "k", 1000 },
			{ "m", 1000000 },
			{ "g", 1000000000 },
			{ "b", 1000000000 },
			{ "t", 1000000000000 }
		};
	}
}