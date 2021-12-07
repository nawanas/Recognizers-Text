//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\English\English-Numbers.yaml
//     - Language: English
//     - ClassName: NumbersDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.English
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDefinitions
    {
      public const string LangMarker = @"Eng";
      public const bool CompoundNumberLanguage = false;
      public const bool MultiDecimalSeparatorCulture = true;
      public static readonly IList<string> NonStandardSeparatorVariants = new List<string>
        {
            @"en-za",
            @"en-na",
            @"en-zw"
        };
      public const string RoundNumberIntegerRegex = @"(?:hundred|thousand|million|mln|billion|bln|trillion|tln|lakh|crore)s?";
      public const string ZeroToNineIntegerRegex = @"(?:three|seven|eight|four|five|zero|nine|one|two|six)";
      public const string TwoToNineIntegerRegex = @"(?:three|seven|eight|four|five|nine|two|six)";
      public const string NegativeNumberTermsRegex = @"(?<negTerm>(minus|negative)\s+)";
      public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}.*";
      public const string AnIntRegex = @"(an?)(?=\s)";
      public const string TenToNineteenIntegerRegex = @"(?:seventeen|thirteen|fourteen|eighteen|nineteen|fifteen|sixteen|eleven|twelve|ten)";
      public const string TensNumberIntegerRegex = @"(?:seventy|twenty|thirty|eighty|ninety|forty|fifty|sixty)";
      public static readonly string SeparaIntRegex = $@"(?:(({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})(\s+{RoundNumberIntegerRegex})*))|(({AnIntRegex}(\s+{RoundNumberIntegerRegex})+))";
      public static readonly string AllIntRegex = $@"(?:((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\s+{RoundNumberIntegerRegex})+)\s+(and\s+)?)*{SeparaIntRegex})";
      public const string PlaceHolderPureNumber = @"\b";
      public const string PlaceHolderDefault = @"(?=\D)|\b";
      public const string PlaceHolderMixed = @"\D|\b";
      public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!(\d+(\s*(K|k|MM?|mil|G|T|B|b))?\s*|\p{{L}}))-\s*)|(?<={placeholder}))\d+(?!([\.,]\d+[a-zA-Z]))(?={placeholder})";
      public const string IndianNumberingSystemRegex = @"(?<=\b)((?:\d{1,2},(?:\d{2},)*\d{3})(?=\b))";
      public static readonly string NumbersWithSuffix = $@"(((?<!\d+(\s*{BaseNumbers.NumberMultiplierRegex})?\s*)-\s*)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)\d+\s+{RoundNumberIntegerRegex}(?=\b)";
      public static readonly string NumbersWithDozenSuffix = $@"(((?<!\d+(\s*{BaseNumbers.NumberMultiplierRegex})?\s*)-\s*)|(?<=\b))\d+\s+dozen(s)?(?=\b)";
      public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
      public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((half\s+)?a\s+dozen)|({AllIntRegex}\s+dozen(s)?))(?=\b)";
      public const string RoundNumberOrdinalRegex = @"(?:hundredth|thousandth|millionth|billionth|trillionth)";
      public const string NumberOrdinalRegex = @"(?:first|second|third|fourth|fifth|sixth|seventh|eighth|nine?th|tenth|eleventh|twelfth|thirteenth|fourteenth|fifteenth|sixteenth|seventeenth|eighteenth|nineteenth|twentieth|thirtieth|fortieth|fiftieth|sixtieth|seventieth|eightieth|ninetieth)";
      public const string RelativeOrdinalRegex = @"(?<relativeOrdinal>(next|previous|current)\s+one|(the\s+second|next)\s+to\s+last|the\s+one\s+before\s+the\s+last(\s+one)?|the\s+last\s+but\s+one|(ante)?penultimate|last|next|previous|current)";
      public static readonly string BasicOrdinalRegex = $@"({NumberOrdinalRegex}|{RelativeOrdinalRegex})";
      public static readonly string SuffixBasicOrdinalRegex = $@"(?:(((({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\s+{RoundNumberIntegerRegex})+)\s+(and\s+)?)*({TensNumberIntegerRegex}(\s+|\s*-\s*))?{BasicOrdinalRegex})";
      public static readonly string SuffixRoundNumberOrdinalRegex = $@"(?:({AllIntRegex}\s+){RoundNumberOrdinalRegex})";
      public static readonly string AllOrdinalRegex = $@"(?:{SuffixBasicOrdinalRegex}|{SuffixRoundNumberOrdinalRegex})";
      public const string OrdinalSuffixRegex = @"(?<=\b)(?:(\d*(1st|2nd|3rd|[4-90]th))|(1[1-2]th))(?=\b)";
      public const string OrdinalNumericRegex = @"(?<=\b)(?:\d{1,3}(\s*,\s*\d{3})*\s*th)(?=\b)";
      public static readonly string OrdinalRoundNumberRegex = $@"(?<!an?\s+){RoundNumberOrdinalRegex}";
      public static readonly string OrdinalEnglishRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
      public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
      public static readonly string FractionNotationRegex = $@"{BaseNumbers.FractionNotationRegex}";
      public static readonly string RoundMultiplierRegex = $@"\b\s*((of\s+)?a\s+)?(?<multiplier>{RoundNumberIntegerRegex})$";
      public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+(and\s+)?)?(({AllIntRegex})(\s+|\s*-\s*)((({AllOrdinalRegex})|({RoundNumberOrdinalRegex}))s|halves|quarters)((\s+of\s+a)?\s+{RoundNumberIntegerRegex})?|(half(\s+a)?|quarter(\s+of\s+a)?)\s+{RoundNumberIntegerRegex})(?=\b)";
      public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)((({AllIntRegex}\s+(and\s+)?)?(an?|one)(\s+|\s*-\s*)(?!\bfirst\b|\bsecond\b)(({AllOrdinalRegex})|({RoundNumberOrdinalRegex})|(half|quarter)(((\s+of)?\s+a)?\s+{RoundNumberIntegerRegex})?))|(half))(?=\b)";
      public static readonly string FractionPrepositionRegex = $@"(?<!{BaseNumbers.CommonCurrencySymbol}\s*)(?<=\b)(?<numerator>({AllIntRegex})|((?<![\.,])\d+))\s+(over|(?<ambiguousSeparator>in|out\s+of))\s+(?<denominator>({AllIntRegex})|(\d+)(?![\.,]))(?=\b)";
      public static readonly string FractionPrepositionWithinPercentModeRegex = $@"(?<!{BaseNumbers.CommonCurrencySymbol}\s*)(?<=\b)(?<numerator>({AllIntRegex})|((?<![\.,])\d+))\s+over\s+(?<denominator>({AllIntRegex})|(\d+)(?![\.,]))(?=\b)";
      public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
      public static readonly string AllFloatRegex = $@"{AllIntRegex}(\s+point){AllPointRegex}";
      public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+(\s*{BaseNumbers.NumberMultiplierRegex})?\s*)-\s*)|((?<=\b)(?<!\d+[\.,])))(\d{{1,3}}(,\d{{3}})+(\.\d+)?|\d+[\.,]\d+)\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string DoubleExponentialNotationRegex = $@"(((?<!\d+(\s*{BaseNumbers.NumberMultiplierRegex})?\s*)-\s*)|((?<=\b)(?<!\d+[\.,])))(\d+([\.,]\d+)?)(e|x10\^)([+-]*[1-9]\d*)(?=\b)";
      public static readonly string DoubleCaretExponentialNotationRegex = $@"(((?<!\d+(\s*{BaseNumbers.NumberMultiplierRegex})?\s*)-\s*)|((?<=\b)(?<!\d+[\.,])))(\d+([\.,]\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
      public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!(\d+(\s*(K|k|MM?|mil|G|T|B|b))?\s*|\p{{L}}))-\s*)|((?<={placeholder})(?<!\d+[\.,])))(\d{{1,3}}(,\d{{3}})+(\.\d+)?|\d+[\.,]\d+)(?!([\.,]\d+))(?={placeholder})";
      public const string DoubleIndianDecimalPointRegex = @"(?<=\b)((?:\d{1,2},(?:\d{2},)*\d{3})(?:\.\d{2})(?=\b))";
      public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))[\.,]\d+(?!([\.,]\d+))(?={placeholder})";
      public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+(\s*{BaseNumbers.NumberMultiplierRegex})?\s*)-\s*)|((?<=\b)(?<!\d+[\.,])))(\d{{1,3}}(,\d{{3}})+(\.\d+)?|\d+[\.,]\d+)\s+{RoundNumberIntegerRegex}(?=\b)";
      public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
      public const string ConnectorRegex = @"(?<spacer>and)";
      public static readonly string NumberWithSuffixPercentage = $@"(?<!%({BaseNumbers.NumberReplaceToken})?)({BaseNumbers.NumberReplaceToken}(\s*))?(%(?!{BaseNumbers.NumberReplaceToken})|(per\s*cents?|percentage|cents?)\b)";
      public static readonly string FractionNumberWithSuffixPercentage = $@"(({BaseNumbers.FractionNumberReplaceToken})\s+of)";
      public static readonly string NumberWithPrefixPercentage = $@"(per\s*cents?\s+of)(\s*)({BaseNumbers.NumberReplaceToken})";
      public static readonly string NumberWithPrepositionPercentage = $@"({BaseNumbers.NumberReplaceToken})\s*(in|out\s+of)\s*({BaseNumbers.NumberReplaceToken})";
      public const string TillRegex = @"((?<!\bequal\s+)to|through|--|-|—|——|~|–)";
      public const string MoreRegex = @"(?:(bigger|greater|more|higher|larger)(\s+than)?|above|over|beyond|exceed(ed|ing)?|surpass(ed|ing)?|(?<!<|=)>)";
      public const string LessRegex = @"(?:(less|lower|smaller|fewer)(\s+than)?|below|under|(?<!>|=)<)";
      public const string EqualRegex = @"(equal(s|ing)?(\s+(to|than))?|(?<!<|>)=)";
      public static readonly string MoreOrEqualPrefix = $@"((no\s+{LessRegex})|(at\s+least))";
      public static readonly string MoreOrEqual = $@"(?:({MoreRegex}\s+(or)?\s+{EqualRegex})|({EqualRegex}\s+(or)?\s+{MoreRegex})|{MoreOrEqualPrefix}(\s+(or)?\s+{EqualRegex})?|({EqualRegex}\s+(or)?\s+)?{MoreOrEqualPrefix}|>\s*=|≥)";
      public const string MoreOrEqualSuffix = @"((and|or)\s+(((more|greater|higher|larger|bigger)((?!\s+than)|(\s+than(?!((\s+or\s+equal\s+to)?\s*\d+)))))|((over|above)(?!\s+than))))";
      public static readonly string LessOrEqualPrefix = $@"((no\s+{MoreRegex})|(at\s+most)|(up\s+to))";
      public static readonly string LessOrEqual = $@"(({LessRegex}\s+(or)?\s+{EqualRegex})|({EqualRegex}\s+(or)?\s+{LessRegex})|{LessOrEqualPrefix}(\s+(or)?\s+{EqualRegex})?|({EqualRegex}\s+(or)?\s+)?{LessOrEqualPrefix}|<\s*=|≤)";
      public const string LessOrEqualSuffix = @"((and|or)\s+(less|lower|smaller|fewer)((?!\s+than)|(\s+than(?!(\s*\d+)))))";
      public static readonly string NumberSplitMark = $@"(?![,.](?!\d+))(?!\s*\b(and\s+({LessRegex}|{MoreRegex})|but|or|to)\b)";
      public const string MoreRegexNoNumberSucceed = @"((bigger|greater|more|higher|larger)((?!\s+than)|\s+(than(?!(\s*\d+))))|(above|over)(?!(\s*\d+)))";
      public const string LessRegexNoNumberSucceed = @"((less|lower|smaller|fewer)((?!\s+than)|\s+(than(?!(\s*\d+))))|(below|under)(?!(\s*\d+)))";
      public const string EqualRegexNoNumberSucceed = @"(equal(s|ing)?((?!\s+(to|than))|(\s+(to|than)(?!(\s*\d+)))))";
      public static readonly string OneNumberRangeMoreRegex1 = $@"({MoreOrEqual}|{MoreRegex})\s*(the\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeMoreRegex1LB = $@"(?<!no\s+){OneNumberRangeMoreRegex1}";
      public static readonly string OneNumberRangeMoreRegex2 = $@"(?<number1>({NumberSplitMark}.)+)\s*{MoreOrEqualSuffix}";
      public static readonly string OneNumberRangeMoreSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+or\s+){MoreRegexNoNumberSucceed})|({MoreRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+or\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeLessRegex1 = $@"({LessOrEqual}|{LessRegex})\s*(the\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeLessRegex1LB = $@"(?<!no\s+){OneNumberRangeLessRegex1}";
      public static readonly string OneNumberRangeLessRegex2 = $@"(?<number2>({NumberSplitMark}.)+)\s*{LessOrEqualSuffix}";
      public static readonly string OneNumberRangeLessSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+or\s+){LessRegexNoNumberSucceed})|({LessRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+or\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeEqualRegex = $@"(?<!\bthan\s+or\s+){EqualRegex}\s*(the\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex1 = $@"between\s*(the\s+)?(?<number1>({NumberSplitMark}.)+)\s*and\s*(the\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex2 = $@"({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\s*(and|but|,)\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})";
      public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})\s*(and|but|,)\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})";
      public static readonly string TwoNumberRangeRegex4 = $@"(from\s+)?(?<number1>({NumberSplitMark}(?!\bfrom\b).)+)\s*{TillRegex}\s*(the\s+)?(?<number2>({NumberSplitMark}.)+)";
      public const string AmbiguousFractionConnectorsRegex = @"(\bin\b)";
      public const char DecimalSeparatorChar = '.';
      public const string FractionMarkerToken = @"over";
      public const char NonDecimalSeparatorChar = ',';
      public const string HalfADozenText = @"six";
      public const string WordSeparatorToken = @"and";
      public static readonly string[] WrittenDecimalSeparatorTexts = { @"point" };
      public static readonly string[] WrittenGroupSeparatorTexts = { @"punto" };
      public static readonly string[] WrittenIntegerSeparatorTexts = { @"and" };
      public static readonly string[] WrittenFractionSeparatorTexts = { @"and" };
      public const string HalfADozenRegex = @"half\s+a\s+dozen";
      public static readonly string DigitalNumberRegex = $@"((?<=\b)(hundred|thousand|[mb]illion|trillion|[mbt]ln|lakh|crore|dozen(s)?)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
      public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
        {
            { @"a", 1 },
            { @"zero", 0 },
            { @"an", 1 },
            { @"one", 1 },
            { @"two", 2 },
            { @"three", 3 },
            { @"four", 4 },
            { @"five", 5 },
            { @"six", 6 },
            { @"seven", 7 },
            { @"eight", 8 },
            { @"nine", 9 },
            { @"ten", 10 },
            { @"eleven", 11 },
            { @"twelve", 12 },
            { @"dozen", 12 },
            { @"dozens", 12 },
            { @"thirteen", 13 },
            { @"fourteen", 14 },
            { @"fifteen", 15 },
            { @"sixteen", 16 },
            { @"seventeen", 17 },
            { @"eighteen", 18 },
            { @"nineteen", 19 },
            { @"twenty", 20 },
            { @"thirty", 30 },
            { @"forty", 40 },
            { @"fifty", 50 },
            { @"sixty", 60 },
            { @"seventy", 70 },
            { @"eighty", 80 },
            { @"ninety", 90 },
            { @"hundred", 100 },
            { @"thousand", 1000 },
            { @"million", 1000000 },
            { @"mln", 1000000 },
            { @"billion", 1000000000 },
            { @"bln", 1000000000 },
            { @"trillion", 1000000000000 },
            { @"tln", 1000000000000 },
            { @"lakh", 100000 },
            { @"crore", 10000000 }
        };
      public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
        {
            { @"first", 1 },
            { @"second", 2 },
            { @"secondary", 2 },
            { @"half", 2 },
            { @"third", 3 },
            { @"fourth", 4 },
            { @"quarter", 4 },
            { @"fifth", 5 },
            { @"sixth", 6 },
            { @"seventh", 7 },
            { @"eighth", 8 },
            { @"ninth", 9 },
            { @"nineth", 9 },
            { @"tenth", 10 },
            { @"eleventh", 11 },
            { @"twelfth", 12 },
            { @"thirteenth", 13 },
            { @"fourteenth", 14 },
            { @"fifteenth", 15 },
            { @"sixteenth", 16 },
            { @"seventeenth", 17 },
            { @"eighteenth", 18 },
            { @"nineteenth", 19 },
            { @"twentieth", 20 },
            { @"thirtieth", 30 },
            { @"fortieth", 40 },
            { @"fiftieth", 50 },
            { @"sixtieth", 60 },
            { @"seventieth", 70 },
            { @"eightieth", 80 },
            { @"ninetieth", 90 },
            { @"hundredth", 100 },
            { @"thousandth", 1000 },
            { @"millionth", 1000000 },
            { @"billionth", 1000000000 },
            { @"trillionth", 1000000000000 },
            { @"firsts", 1 },
            { @"halves", 2 },
            { @"thirds", 3 },
            { @"fourths", 4 },
            { @"quarters", 4 },
            { @"fifths", 5 },
            { @"sixths", 6 },
            { @"sevenths", 7 },
            { @"eighths", 8 },
            { @"ninths", 9 },
            { @"nineths", 9 },
            { @"tenths", 10 },
            { @"elevenths", 11 },
            { @"twelfths", 12 },
            { @"thirteenths", 13 },
            { @"fourteenths", 14 },
            { @"fifteenths", 15 },
            { @"sixteenths", 16 },
            { @"seventeenths", 17 },
            { @"eighteenths", 18 },
            { @"nineteenths", 19 },
            { @"twentieths", 20 },
            { @"thirtieths", 30 },
            { @"fortieths", 40 },
            { @"fiftieths", 50 },
            { @"sixtieths", 60 },
            { @"seventieths", 70 },
            { @"eightieths", 80 },
            { @"ninetieths", 90 },
            { @"hundredths", 100 },
            { @"thousandths", 1000 },
            { @"millionths", 1000000 },
            { @"billionths", 1000000000 },
            { @"trillionths", 1000000000000 }
        };
      public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
        {
            { @"hundred", 100 },
            { @"thousand", 1000 },
            { @"million", 1000000 },
            { @"mln", 1000000 },
            { @"billion", 1000000000 },
            { @"bln", 1000000000 },
            { @"trillion", 1000000000000 },
            { @"tln", 1000000000000 },
            { @"lakh", 100000 },
            { @"crore", 10000000 },
            { @"hundredth", 100 },
            { @"thousandth", 1000 },
            { @"millionth", 1000000 },
            { @"billionth", 1000000000 },
            { @"trillionth", 1000000000000 },
            { @"hundredths", 100 },
            { @"thousandths", 1000 },
            { @"millionths", 1000000 },
            { @"billionths", 1000000000 },
            { @"trillionths", 1000000000000 },
            { @"dozen", 12 },
            { @"dozens", 12 },
            { @"k", 1000 },
            { @"m", 1000000 },
            { @"mm", 1000000 },
            { @"mil", 1000000 },
            { @"g", 1000000000 },
            { @"b", 1000000000 },
            { @"t", 1000000000000 }
        };
      public static readonly Dictionary<string, string> AmbiguityFiltersDict = new Dictionary<string, string>
        {
            { @"\bone\b", @"\b(the|this|that|which)\s+(one)\b" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceOffsetMap = new Dictionary<string, string>
        {
            { @"last", @"0" },
            { @"next one", @"1" },
            { @"current", @"0" },
            { @"current one", @"0" },
            { @"previous one", @"-1" },
            { @"the second to last", @"-1" },
            { @"the one before the last one", @"-1" },
            { @"the one before the last", @"-1" },
            { @"next to last", @"-1" },
            { @"penultimate", @"-1" },
            { @"the last but one", @"-1" },
            { @"antepenultimate", @"-2" },
            { @"next", @"1" },
            { @"previous", @"-1" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceRelativeToMap = new Dictionary<string, string>
        {
            { @"last", @"end" },
            { @"next one", @"current" },
            { @"previous one", @"current" },
            { @"current", @"current" },
            { @"current one", @"current" },
            { @"the second to last", @"end" },
            { @"the one before the last one", @"end" },
            { @"the one before the last", @"end" },
            { @"next to last", @"end" },
            { @"penultimate", @"end" },
            { @"the last but one", @"end" },
            { @"antepenultimate", @"end" },
            { @"next", @"current" },
            { @"previous", @"current" }
        };
    }
}