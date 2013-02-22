﻿using Fclp.Tests.FluentCommandLineParser.Behaviour;
using Fclp.Tests.FluentCommandLineParser.TestContext;
using Machine.Specifications;

namespace Fclp.Tests.FluentCommandLineParser
{
    namespace when_setting_up_a_new_option
    {
        public class with_a_long_name_that_is_whitespace : SettingUpALongOptionTestContext
        {
            Establish context = AutoMockAll;

            Because of = () => SetupOptionWith(valid_short_name, invalid_long_name_that_is_whitespace);

            Behaves_like<InvalidOptionSetupBehaviour> a_failed_setup_option;
        }
    }
}