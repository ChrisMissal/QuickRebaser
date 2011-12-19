using NUnit.Framework;

namespace QuickRebaser.Tests
{
    public class StringExtensionsTests
    {
        [Test]
        public void SubstringAfter_should_return_expected_value_from_middle()
        {
            var result = "0123 abc".SubstringAfter(' ');

            result.ShouldBe("abc");
        }

        [Test]
        public void SubstringAfter_should_return_expected_value_from_middle_with_last_found()
        {
            var result = "aaa-bbb-ccc-ddd".SubstringAfter('-', 3);

            result.ShouldBe("ddd");
        }

        [Test]
        public void SubstringAfter_should_return_expected_value_from_start()
        {
            var result = " zzzz ".SubstringAfter(' ');

            result.ShouldBe("zzzz ");
        }

        [Test]
        public void SubstringAfter_should_return_expected_value_from_end()
        {
            var result = " zzzz ".SubstringAfter(' ', 2);

            result.ShouldBe("");
        }

        [Test]
        public void SubstringAfter_should_return_expected_value_from_end_with_no_match()
        {
            var result = "abcdefg+".SubstringAfter('+', 5);

            result.ShouldBe("");
        }

        [Test]
        public void SubstringAfter_should_return_expected_value_when_delimiter_is_not_found()
        {
            var result = "first name, last name".SubstringAfter('.');

            result.ShouldBe("");
        }
    }
}
