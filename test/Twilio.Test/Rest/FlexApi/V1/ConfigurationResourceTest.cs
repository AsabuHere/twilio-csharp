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
using Twilio.Rest.FlexApi.V1;

namespace Twilio.Tests.Rest.FlexApi.V1
{

    [TestFixture]
    public class ConfigurationTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Configuration",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ConfigurationResource.Fetch(client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"attributes\": {\"main_attribute\": \"some_attribute\"},\"status\": \"ok\",\"taskrouter_workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_target_workflow_sid\": \"WWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_target_taskqueue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_taskqueues\": [{\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"targettable\": true},{\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaac\",\"targettable\": false}],\"taskrouter_skills\": [{\"name\": \"sales\",\"multivalue\": false,\"minimum\": 0,\"maximum\": 0},{\"name\": \"support\",\"multivalue\": true,\"minimum\": 0,\"maximum\": 10}],\"taskrouter_worker_channels\": {\"agent\": [{\"name\": \"default\",\"availability\": true,\"capacity\": 1},{\"name\": \"voice\",\"availability\": false,\"capacity\": 2}],\"supervisor\": [{\"name\": \"default\",\"availability\": true,\"capacity\": 2}]},\"taskrouter_worker_attributes\": {\"agent\": {\"region\": \"us-east\"},\"supervisor\": {\"region\": \"us\"}},\"taskrouter_offline_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"runtime_domain\": \"https://flex.twilio.com\",\"messaging_service_instance_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"chat_service_instance_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"flex_service_instance_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ui_language\": \"en\",\"ui_attributes\": {},\"ui_dependencies\": {},\"ui_version\": \"1.0\",\"service_version\": \"1.0\",\"call_recording_enabled\": true,\"call_recording_webhook_url\": \"https://www.example.com/call-recording\",\"crm_enabled\": true,\"crm_type\": \"custom\",\"crm_callback_url\": \"https://crm.com/a\",\"crm_fallback_url\": \"https://crm.com/b\",\"crm_attributes\": {\"crm_attribute\": \"some_crm\"},\"public_attributes\": {\"public\": \"test\"},\"plugin_service_enabled\": true,\"plugin_service_attributes\": {\"agent-logger\": \"^3.10.5\",\"typewriter\": \"^7.0.1\"},\"integrations\": [{\"name\": \"twilio\",\"type\": \"http\",\"active\": true,\"config\": \"{\\\"callback\\\":\\\"twilio.com/cb\\\",\\\"allowed_methods\\\":[\\\"GET\\\",\\\"POST\\\"]}\",\"logo\": \"logo1\",\"author\": \"somebody1\"},{\"name\": \"twilio-stage\",\"type\": \"http\",\"active\": false,\"config\": \"{\\\"callback\\\":\\\"twilio.com/cb\\\",\\\"allowed_methods\\\":[\\\"GET\\\",\\\"POST\\\"]}\"}],\"outbound_call_flows\": {\"default\": {\"caller_id\": \"+12345\",\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"location\": \"EE\",\"workflow_sid\": \"WWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}},\"queue_stats_configuration\": {\"default\": {\"service_level_threshold\": 20,\"short_abandoned_threshold\": 5,\"reset_timezone\": \"America/New_York\",\"reset_time\": \"00:00\"},\"queue_configurations\": [{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reset_timezone\": \"Europe/Tallinn\",\"reset_time\": \"01:00\"},{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"reset_timezone\": \"Europe/Paris\",\"reset_time\": \"02:00\"}],\"queue_channel_configurations\": [{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"channel_sid\": \"TCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_level_threshold\": 10,\"short_abandoned_threshold\": 10},{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"channel_sid\": \"TCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"service_level_threshold\": 30,\"short_abandoned_threshold\": 15}]},\"serverless_service_sids\": [\"ZSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ZSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\"],\"notifications\": {\"enabled\": true,\"mode\": \"whenNotInFocus\"},\"markdown\": {\"enabled\": false,\"mode\": \"readOnly\"},\"url\": \"https://flex-api.twilio.com/v1/Configuration\"}"
                                     ));

            var response = ConfigurationResource.Fetch(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Configuration",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ConfigurationResource.Create(client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"attributes\": {\"main_attribute\": \"some_attribute\"},\"status\": \"ok\",\"taskrouter_workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_target_workflow_sid\": \"WWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_target_taskqueue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_taskqueues\": [{\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"targettable\": true},{\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaac\",\"targettable\": false}],\"taskrouter_skills\": [{\"name\": \"sales\",\"multivalue\": false,\"minimum\": 0,\"maximum\": 0},{\"name\": \"support\",\"multivalue\": true,\"minimum\": 0,\"maximum\": 10}],\"taskrouter_worker_channels\": {\"agent\": [{\"name\": \"default\",\"availability\": true,\"capacity\": 1},{\"name\": \"voice\",\"availability\": false,\"capacity\": 2}],\"supervisor\": [{\"name\": \"default\",\"availability\": true,\"capacity\": 2}]},\"taskrouter_worker_attributes\": {\"agent\": {\"region\": \"us-east\"},\"supervisor\": {\"region\": \"us\"}},\"taskrouter_offline_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"runtime_domain\": \"https://flex.twilio.com\",\"messaging_service_instance_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"chat_service_instance_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"flex_service_instance_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ui_language\": \"en\",\"ui_attributes\": {},\"ui_dependencies\": {},\"ui_version\": \"1.0\",\"service_version\": \"1.0\",\"call_recording_enabled\": true,\"call_recording_webhook_url\": \"https://www.example.com/call-recording\",\"crm_enabled\": true,\"crm_type\": \"custom\",\"crm_callback_url\": \"https://crm.com/a\",\"crm_fallback_url\": \"https://crm.com/b\",\"crm_attributes\": {\"crm_attribute\": \"some_crm\"},\"public_attributes\": {\"public\": \"test\"},\"plugin_service_enabled\": true,\"plugin_service_attributes\": {\"agent-logger\": \"^3.10.5\",\"typewriter\": \"^7.0.1\"},\"integrations\": [{\"name\": \"twilio\",\"type\": \"http\",\"active\": true,\"config\": \"{\\\"callback\\\":\\\"twilio.com/cb\\\",\\\"allowed_methods\\\":[\\\"GET\\\",\\\"POST\\\"]}\",\"logo\": \"logo1\",\"author\": \"somebody1\"},{\"name\": \"twilio-stage\",\"type\": \"http\",\"active\": false,\"config\": \"{\\\"callback\\\":\\\"twilio.com/cb\\\",\\\"allowed_methods\\\":[\\\"GET\\\",\\\"POST\\\"]}\"}],\"outbound_call_flows\": {\"default\": {\"caller_id\": \"+12345\",\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"location\": \"EE\",\"workflow_sid\": \"WWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}},\"queue_stats_configuration\": {\"default\": {\"service_level_threshold\": 20,\"short_abandoned_threshold\": 5,\"reset_timezone\": \"America/New_York\",\"reset_time\": \"00:00\"},\"queue_configurations\": [{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reset_timezone\": \"Europe/Tallinn\",\"reset_time\": \"01:00\"},{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"reset_timezone\": \"Europe/Paris\",\"reset_time\": \"02:00\"}],\"queue_channel_configurations\": [{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"channel_sid\": \"TCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_level_threshold\": 10,\"short_abandoned_threshold\": 10},{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"channel_sid\": \"TCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"service_level_threshold\": 30,\"short_abandoned_threshold\": 15}]},\"serverless_service_sids\": [\"ZSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ZSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\"],\"notifications\": {\"enabled\": true,\"mode\": \"whenNotInFocus\"},\"markdown\": {\"enabled\": false,\"mode\": \"readOnly\"},\"url\": \"https://flex-api.twilio.com/v1/Configuration\"}"
                                     ));

            var response = ConfigurationResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Configuration",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ConfigurationResource.Update(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"attributes\": {\"main_attribute\": \"some_attribute\"},\"status\": \"ok\",\"taskrouter_workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_target_workflow_sid\": \"WWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_target_taskqueue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"taskrouter_taskqueues\": [{\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"targettable\": true},{\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaac\",\"targettable\": false}],\"taskrouter_skills\": [{\"name\": \"sales\",\"multivalue\": false,\"minimum\": 0,\"maximum\": 0},{\"name\": \"support\",\"multivalue\": true,\"minimum\": 0,\"maximum\": 10}],\"taskrouter_worker_channels\": {\"agent\": [{\"name\": \"default\",\"availability\": true,\"capacity\": 1},{\"name\": \"voice\",\"availability\": false,\"capacity\": 2}],\"supervisor\": [{\"name\": \"default\",\"availability\": true,\"capacity\": 2}]},\"taskrouter_worker_attributes\": {\"agent\": {\"region\": \"us-east\"},\"supervisor\": {\"region\": \"us\"}},\"taskrouter_offline_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"runtime_domain\": \"https://flex.twilio.com\",\"messaging_service_instance_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"chat_service_instance_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"flex_service_instance_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ui_language\": \"en\",\"ui_attributes\": {},\"ui_dependencies\": {},\"ui_version\": \"1.0\",\"service_version\": \"1.0\",\"call_recording_enabled\": true,\"call_recording_webhook_url\": \"https://www.example.com/call-recording\",\"crm_enabled\": true,\"crm_type\": \"custom\",\"crm_callback_url\": \"https://crm.com/a\",\"crm_fallback_url\": \"https://crm.com/b\",\"crm_attributes\": {\"crm_attribute\": \"some_crm\"},\"public_attributes\": {\"public\": \"test\"},\"plugin_service_enabled\": false,\"plugin_service_attributes\": {\"agent-logger\": \"^3.10.5\",\"typewriter\": \"^7.0.1\"},\"integrations\": [{\"name\": \"twilio\",\"type\": \"http\",\"active\": true,\"config\": \"{\\\"callback\\\":\\\"twilio.com/cb\\\",\\\"allowed_methods\\\":[\\\"GET\\\",\\\"POST\\\"]}\",\"logo\": \"logo1\",\"author\": \"somebody1\"},{\"name\": \"twilio-stage\",\"type\": \"http\",\"active\": false,\"config\": \"{\\\"callback\\\":\\\"twilio.com/cb\\\",\\\"allowed_methods\\\":[\\\"GET\\\",\\\"POST\\\"]}\"}],\"outbound_call_flows\": {\"default\": {\"caller_id\": \"+12345\",\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"location\": \"EE\",\"workflow_sid\": \"WWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}},\"queue_stats_configuration\": {\"default\": {\"service_level_threshold\": 20,\"short_abandoned_threshold\": 5,\"reset_timezone\": \"America/New_York\",\"reset_time\": \"00:00\"},\"queue_configurations\": [{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reset_timezone\": \"Europe/Tallinn\",\"reset_time\": \"01:00\"},{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"reset_timezone\": \"Europe/Paris\",\"reset_time\": \"02:00\"}],\"queue_channel_configurations\": [{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"channel_sid\": \"TCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_level_threshold\": 10,\"short_abandoned_threshold\": 10},{\"queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"channel_sid\": \"TCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"service_level_threshold\": 30,\"short_abandoned_threshold\": 15}]},\"serverless_service_sids\": [\"ZSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ZSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\"],\"notifications\": {\"enabled\": true,\"mode\": \"whenNotInFocus\"},\"markdown\": {\"enabled\": false,\"mode\": \"readOnly\"},\"url\": \"https://flex-api.twilio.com/v1/Configuration\"}"
                                     ));

            var response = ConfigurationResource.Update(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}