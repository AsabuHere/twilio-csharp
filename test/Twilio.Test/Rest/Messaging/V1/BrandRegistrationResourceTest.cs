/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Messaging.V1;

namespace Twilio.Tests.Rest.Messaging.V1
{

    [TestFixture]
    public class BrandRegistrationTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations/BNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                BrandRegistrationResource.Fetch("BNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"BN0044409f7e067e279523808d267e2d85\",\"account_sid\": \"AC78e8e67fc0246521490fb9907fd0c165\",\"customer_profile_bundle_sid\": \"BU3344409f7e067e279523808d267e2d85\",\"a2p_profile_bundle_sid\": \"BU3344409f7e067e279523808d267e2d85\",\"date_created\": \"2021-01-27T14:18:35Z\",\"date_updated\": \"2021-01-27T14:18:36Z\",\"status\": \"IN_PROGRESS\",\"tcr_id\": \"BXXXXXX\",\"failure_reason\": \"Registration error\",\"url\": \"https://messaging.twilio.com/v1/a2p/BrandRegistrations/BN0044409f7e067e279523808d267e2d85\"}"
                                     ));

            var response = BrandRegistrationResource.Fetch("BNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                BrandRegistrationResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://messaging.twilio.com/v1/a2p/BrandRegistrations?PageSize=50&Page=0\",\"previous_page_url\": null,\"next_page_url\": null,\"key\": \"data\",\"url\": \"https://messaging.twilio.com/v1/a2p/BrandRegistrations?PageSize=50&Page=0\"},\"data\": [{\"sid\": \"BN0044409f7e067e279523808d267e2d85\",\"account_sid\": \"AC78e8e67fc0246521490fb9907fd0c165\",\"customer_profile_bundle_sid\": \"BU3344409f7e067e279523808d267e2d85\",\"a2p_profile_bundle_sid\": \"BU3344409f7e067e279523808d267e2d85\",\"date_created\": \"2021-01-27T14:18:35Z\",\"date_updated\": \"2021-01-27T14:18:36Z\",\"status\": \"IN_PROGRESS\",\"tcr_id\": \"BXXXXXX\",\"failure_reason\": \"Registration error\",\"url\": \"https://messaging.twilio.com/v1/a2p/BrandRegistrations/BN0044409f7e067e279523808d267e2d85\"}]}"
                                     ));

            var response = BrandRegistrationResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations",
                ""
            );
            request.AddPostParam("CustomerProfileBundleSid", Serialize("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            request.AddPostParam("A2PProfileBundleSid", Serialize("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                BrandRegistrationResource.Create("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"BN0044409f7e067e279523808d267e2d85\",\"account_sid\": \"AC78e8e67fc0246521490fb9907fd0c165\",\"customer_profile_bundle_sid\": \"BU0000009f7e067e279523808d267e2d90\",\"a2p_profile_bundle_sid\": \"BU1111109f7e067e279523808d267e2d85\",\"date_created\": \"2021-01-28T10:45:51Z\",\"date_updated\": \"2021-01-28T10:45:51Z\",\"status\": \"PENDING\",\"tcr_id\": \"BXXXXXX\",\"failure_reason\": \"Registration error\",\"url\": \"https://messaging.twilio.com/v1/a2p/BrandRegistrations/BN0044409f7e067e279523808d267e2d85\"}"
                                     ));

            var response = BrandRegistrationResource.Create("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}