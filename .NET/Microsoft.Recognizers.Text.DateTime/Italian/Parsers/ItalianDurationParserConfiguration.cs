﻿using System.Collections.Immutable;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Text.Number;

namespace Microsoft.Recognizers.Text.DateTime.Italian
{
    public class ItalianDurationParserConfiguration : BaseOptionsConfiguration, IDurationParserConfiguration
    {
        public IExtractor CardinalExtractor { get; }

        public IExtractor DurationExtractor { get; }

        public IParser NumberParser { get; }

        public Regex NumberCombinedWithUnit { get; }

        public Regex AnUnitRegex { get; }

        public Regex AllDateUnitRegex { get; }

        public Regex HalfDateUnitRegex { get; }

        public Regex SuffixAndRegex { get; }

        public Regex FollowedUnit { get; }

        public Regex ConjunctionRegex { get; }

        public Regex InExactNumberRegex { get; }

        public Regex InExactNumberUnitRegex { get; }

        public Regex DurationUnitRegex { get; }

        public IImmutableDictionary<string, string> UnitMap { get; }

        public IImmutableDictionary<string, long> UnitValueMap { get; }

        public IImmutableDictionary<string, double> DoubleNumbers { get; }

        public ItalianDurationParserConfiguration(ICommonDateTimeParserConfiguration config) : base(config.Options)
        {
            CardinalExtractor = config.CardinalExtractor;
            NumberParser = config.NumberParser;
            DurationExtractor = new BaseDurationExtractor(new ItalianDurationExtractorConfiguration(), false);
            NumberCombinedWithUnit = ItalianDurationExtractorConfiguration.NumberCombinedWithDurationUnit;
            AnUnitRegex = ItalianDurationExtractorConfiguration.AnUnitRegex;
            AllDateUnitRegex = ItalianDurationExtractorConfiguration.AllRegex;
            HalfDateUnitRegex = ItalianDurationExtractorConfiguration.HalfRegex;
            SuffixAndRegex = ItalianDurationExtractorConfiguration.SuffixAndRegex;
            FollowedUnit = ItalianDurationExtractorConfiguration.DurationFollowedUnit;
            ConjunctionRegex = ItalianDurationExtractorConfiguration.ConjunctionRegex;
            InExactNumberRegex = ItalianDurationExtractorConfiguration.InExactNumberRegex;
            InExactNumberUnitRegex = ItalianDurationExtractorConfiguration.InExactNumberUnitRegex;
            DurationUnitRegex = ItalianDurationExtractorConfiguration.DurationUnitRegex;
            UnitMap = config.UnitMap;
            UnitValueMap = config.UnitValueMap;
            DoubleNumbers = config.DoubleNumbers;
        }
    }
}
