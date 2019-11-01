using NUnit.Framework;

using StandardUtils.Enumerations;
using StandardUtils.Enumerations.Base;

namespace StandardUtils.Unit.Tests.Enumerations
{
    [TestFixture]
    public class ResponseStatusTests
    {
        [Test]
        public void ResponseStatus_Unknown()
        {
            var item = ResponseStatus.Unknown;

            Assert.AreEqual(1, item.Value);
            Assert.AreEqual("Unknown", item.Name);
            Assert.AreEqual("not_informed_reason", item.Description);
        }

        [Test]
        public void ResponseStatus_Success()
        {
            var item = ResponseStatus.Success;

            Assert.AreEqual(2, item.Value);
            Assert.AreEqual("Success", item.Name);
            Assert.AreEqual("worked_successfully", item.Description);
        }

        [Test]
        public void ResponseStatus_Failed()
        {
            var item = ResponseStatus.Failed;

            Assert.AreEqual(3, item.Value);
            Assert.AreEqual("Failed", item.Name);
            Assert.AreEqual("request_failed", item.Description);
        }

        [Test]
        public void ResponseStatus_Invalid()
        {
            var item = ResponseStatus.Invalid;

            Assert.AreEqual(4, item.Value);
            Assert.AreEqual("Invalid", item.Name);
            Assert.AreEqual("request_not_valid", item.Description);
        }

        [Test]
        public void ResponseStatus_SuccessWithProblems()
        {
            var item = ResponseStatus.SuccessWithProblems;

            Assert.AreEqual(5, item.Value);
            Assert.AreEqual("SuccessWithProblems", item.Name);
            Assert.AreEqual("worked_successfully_but_some_parts_are_missing_check_messages", item.Description);
        }

        [Test]
        public void ResponseStatus_Has_5_Items()
        {
            var items = Enumeration.GetAll<ResponseStatus>();

            Assert.AreEqual(5, items.Count);
            Assert.True(items.Contains(ResponseStatus.Unknown));
            Assert.True(items.Contains(ResponseStatus.Success));
            Assert.True(items.Contains(ResponseStatus.Failed));
            Assert.True(items.Contains(ResponseStatus.Invalid));
            Assert.True(items.Contains(ResponseStatus.SuccessWithProblems));
        }
    }
}