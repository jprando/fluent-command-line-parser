﻿using Fclp.Tests.FluentCommandLineParser.TestContext;
using Machine.Specifications;

namespace Fclp.Tests.FluentCommandLineParser
{
    namespace when_setting_up_a_new_option
    {
        public class with_a_short_name : SettingUpAShortOptionTestContext
        {
            Establish context = AutoMockAll;

            Because of = () => SetupOptionWith(valid_short_name);

            It should_return_a_new_option = () => option.ShouldNotBeNull();
            It should_have_the_given_short_name = () => option.ShortName.ShouldMatch(valid_short_name);
            It should_have_no_long_name = () => option.HasLongName.ShouldBeFalse();
            It should_not_be_a_required_option = () => option.IsRequired.ShouldBeFalse();
            It should_have_no_callback = () => option.HasCallback.ShouldBeFalse();
            It should_have_no_description = () => option.Description.ShouldBeNull();
            It should_have_no_default_value = () => option.HasDefault.ShouldBeFalse();
        }
    }
}