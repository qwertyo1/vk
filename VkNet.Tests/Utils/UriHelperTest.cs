using System;
using NUnit.Framework;
using VkNet.Utils;
using UriPartial = VkNet.Utils.UriPartial;

namespace VkNet.Tests.Utils
{
    [TestFixture]
    public class UriHelperTest
    {
        private readonly Uri _uri1 = new Uri("https://oauth.vk.com/authorize?client_id=4268118&scope=notify,friends,photos,audio,video,pages,status,notes,messages,wall,ads,docs,groups,notifications,stats,email,market&redirect_uri=https://oauth.vk.com/blank.html&display=wap&response_type=token");

        [Test]
        public void UriPartialAuthorityTest()
        {
            var result = _uri1.GetLeftPart(UriPartial.Authority);
            Assert.That(result, Is.EqualTo("https://oauth.vk.com"));
        }

        [Test]
        public void UriPartialPathTest()
        {
            Assert.Throws<NotImplementedException>(() => _uri1.GetLeftPart(UriPartial.Path));
        }

        [Test]
        public void UriPartialQueryTest()
        {
            Assert.Throws<NotImplementedException>(() => _uri1.GetLeftPart(UriPartial.Query));
        }

        [Test]
        public void UriPartialSchemeTest()
        {
            Assert.Throws<NotImplementedException>(() => _uri1.GetLeftPart(UriPartial.Scheme));
        }
    }
}