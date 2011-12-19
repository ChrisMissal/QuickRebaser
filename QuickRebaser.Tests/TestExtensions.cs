using System.Diagnostics;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [DebuggerStepThrough]
    public static class TestExtensions
    {
        public static void ShouldBe(this object @this, object expected)
        {
            Assert.AreEqual(expected, @this);
        }

        public static void ShouldBeNull(this object @this)
        {
            Assert.IsNull(@this);
        }

        public static void ShouldBeAssignableTo<T>(this T @this)
        {
            Assert.That(@this, Is.AssignableTo<T>());
        }

        public static void ShouldBe<T>(this T @this)
        {
            Assert.That(@this, Is.TypeOf<T>());
        }
    }
}