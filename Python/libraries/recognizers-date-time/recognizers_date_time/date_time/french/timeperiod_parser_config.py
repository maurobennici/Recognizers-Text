from typing import Pattern, Dict

from recognizers_text.utilities import RegExpUtility
from recognizers_text.extractor import Extractor
from recognizers_number.number.french.extractors import FrenchIntegerExtractor
from ...resources.french_date_time import FrenchDateTime
from ..extractors import DateTimeExtractor
from ..parsers import DateTimeParser
from ..base_configs import BaseDateParserConfiguration, DateTimeUtilityConfiguration
from ..base_timeperiod import TimePeriodParserConfiguration, MatchedTimeRegex

class FrenchTimePeriodParserConfiguration(TimePeriodParserConfiguration):
    @property
    def time_extractor(self) -> DateTimeExtractor:
        return self._time_extractor

    @property
    def time_parser(self) -> DateTimeParser:
        return self._time_parser

    @property
    def integer_extractor(self) -> Extractor:
        return self._integer_extractor

    @property
    def pure_number_from_to_regex(self) -> Pattern:
        return self._pure_number_from_to_regex

    @property
    def pure_number_between_and_regex(self) -> Pattern:
        return self._pure_number_between_and_regex

    @property
    def time_of_day_regex(self) -> Pattern:
        return self._time_of_day_regex

    @property
    def till_regex(self) -> Pattern:
        return self._till_regex

    @property
    def numbers(self) -> Dict[str, int]:
        return self._numbers

    @property
    def utility_configuration(self) -> DateTimeUtilityConfiguration:
        return self._utility_configuration

    def __init__(self, config: BaseDateParserConfiguration):
        self._time_extractor = config.time_extractor
        self._time_parser = config.time_parser
        self._integer_extractor = config.integer_extractor
        self._numbers = config.numbers
        self._utility_configuration = config.utility_configuration
        self._pure_number_from_to_regex = RegExpUtility.get_safe_reg_exp(FrenchDateTime.PureNumFromTo)
        self._pure_number_between_and_regex = RegExpUtility.get_safe_reg_exp(FrenchDateTime.PureNumBetweenAnd)
        self._time_of_day_regex = RegExpUtility.get_safe_reg_exp(FrenchDateTime.TimeOfDayRegex)
        self._till_regex = RegExpUtility.get_safe_reg_exp(FrenchDateTime.TillRegex)

    def get_matched_timex_range(self, source: str) -> MatchedTimeRegex:
        source = source.strip().lower()
        if source.endswith('s'):
            source = source[:-1]

        timex = ''
        begin_hour = 0
        end_hour = 0
        end_min = 0

        if source.endswith('matinee') or source.endswith('matin') or source.endswith('matinée'):
            timex = 'TMO'
            begin_hour = 8
            end_hour = 12
        elif source.endswith('apres-midi') or source.endswith('apres midi') or source.endswith('après midi') or source.endswith('après-midi'):
            timex = 'TAF'
            begin_hour = 12
            end_hour = 16
        elif source.endswith('soir') or source.endswith('soiree') or source.endswith('soirée'):
            timex = 'TEV'
            begin_hour = 16
            end_hour = 20
        elif source == 'jour' or source.endswith('journee') or source.endswith('journée'):
            timex = 'TDT'
            begin_hour = 8
            end_hour = 18
        elif source.endswith('nuit'):
            timex = 'TNI'
            begin_hour = 20
            end_hour = 23
            end_min = 59
        else:
            return MatchedTimeRegex(
                matched=False,
                timex='',
                begin_hour=0,
                end_hour=0,
                end_min=0
            )

        return MatchedTimeRegex(
            matched=True,
            timex=timex,
            begin_hour=begin_hour,
            end_hour=end_hour,
            end_min=end_min
        )
