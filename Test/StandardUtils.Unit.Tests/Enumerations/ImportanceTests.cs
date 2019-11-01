using System;

using NUnit.Framework;

using StandardUtils.Enumerations;
using StandardUtils.Enumerations.Base;

namespace StandardUtils.Unit.Tests.Enumerations
{
    [TestFixture]
    public class ImportanceTests
    {
        [Test]
        public void Importance_Unknown()
        {
            var item = Importance.Unknown;

            Assert.AreEqual(1, item.Value);
            Assert.AreEqual(new Guid("3B0F5D3C642D4E8C87C0846AFEF9D054"), item.Uid);
            Assert.AreEqual("Unknown", item.Name);
            Assert.AreEqual(null, item.Description);
        }

        [Test]
        public void Importance_High()
        {
            var item = Importance.High;

            Assert.AreEqual(2, item.Value);
            Assert.AreEqual(new Guid("6D20562C0ADE4B9C98DCF2219B6EC7CE"), item.Uid);
            Assert.AreEqual("High", item.Name);
            Assert.AreEqual(null, item.Description);
        }

        [Test]
        public void Importance_Normal()
        {
            var item = Importance.Normal;

            Assert.AreEqual(3, item.Value);
            Assert.AreEqual(new Guid("99FFA9314B4442718BEFF1B49F19DC24"), item.Uid);
            Assert.AreEqual("Normal", item.Name);
            Assert.AreEqual(null, item.Description);
        }

        [Test]
        public void Importance_Low()
        {
            var item = Importance.Low;

            Assert.AreEqual(4, item.Value);
            Assert.AreEqual(new Guid("1D4AF332A20C4602B53D744AFA1887C1"), item.Uid);
            Assert.AreEqual("Low", item.Name);
            Assert.AreEqual(null, item.Description);
        }

        [Test]
        public void Importance_Has_4_Items()
        {
            var items = Enumeration.GetAll<Importance>();

            Assert.AreEqual(4, items.Count);
            Assert.True(items.Contains(Importance.Unknown));
            Assert.True(items.Contains(Importance.High));
            Assert.True(items.Contains(Importance.Normal));
            Assert.True(items.Contains(Importance.Low));
        }
    }
}