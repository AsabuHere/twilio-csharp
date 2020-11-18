/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// ChallengeResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Verify.V2.Service.Entity
{

    public class ChallengeResource : Resource
    {
        public sealed class ChallengeStatusesEnum : StringEnum
        {
            private ChallengeStatusesEnum(string value) : base(value) {}
            public ChallengeStatusesEnum() {}
            public static implicit operator ChallengeStatusesEnum(string value)
            {
                return new ChallengeStatusesEnum(value);
            }

            public static readonly ChallengeStatusesEnum Pending = new ChallengeStatusesEnum("pending");
            public static readonly ChallengeStatusesEnum Expired = new ChallengeStatusesEnum("expired");
            public static readonly ChallengeStatusesEnum Approved = new ChallengeStatusesEnum("approved");
            public static readonly ChallengeStatusesEnum Denied = new ChallengeStatusesEnum("denied");
        }

        public sealed class ChallengeReasonsEnum : StringEnum
        {
            private ChallengeReasonsEnum(string value) : base(value) {}
            public ChallengeReasonsEnum() {}
            public static implicit operator ChallengeReasonsEnum(string value)
            {
                return new ChallengeReasonsEnum(value);
            }

            public static readonly ChallengeReasonsEnum None = new ChallengeReasonsEnum("none");
            public static readonly ChallengeReasonsEnum NotNeeded = new ChallengeReasonsEnum("not_needed");
            public static readonly ChallengeReasonsEnum NotRequested = new ChallengeReasonsEnum("not_requested");
        }

        public sealed class FactorTypesEnum : StringEnum
        {
            private FactorTypesEnum(string value) : base(value) {}
            public FactorTypesEnum() {}
            public static implicit operator FactorTypesEnum(string value)
            {
                return new FactorTypesEnum(value);
            }

            public static readonly FactorTypesEnum Push = new FactorTypesEnum("push");
        }

        private static Request BuildCreateRequest(CreateChallengeOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Challenges",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Challenge for the Factor
        /// </summary>
        /// <param name="options"> Create Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ChallengeResource Create(CreateChallengeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Challenge for the Factor
        /// </summary>
        /// <param name="options"> Create Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ChallengeResource> CreateAsync(CreateChallengeOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Challenge for the Factor
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="factorSid"> Factor Sid. </param>
        /// <param name="expirationDate"> The date-time when this Challenge expires </param>
        /// <param name="detailsMessage"> Shown to the user when the push notification arrives </param>
        /// <param name="detailsFields"> A list of objects that describe the Fields included in the Challenge </param>
        /// <param name="hiddenDetails"> Hidden details provided to contextualize the Challenge </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ChallengeResource Create(string pathServiceSid,
                                               string pathIdentity,
                                               string factorSid,
                                               DateTime? expirationDate = null,
                                               string detailsMessage = null,
                                               List<object> detailsFields = null,
                                               object hiddenDetails = null,
                                               ITwilioRestClient client = null)
        {
            var options = new CreateChallengeOptions(pathServiceSid, pathIdentity, factorSid){ExpirationDate = expirationDate, DetailsMessage = detailsMessage, DetailsFields = detailsFields, HiddenDetails = hiddenDetails};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Challenge for the Factor
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="factorSid"> Factor Sid. </param>
        /// <param name="expirationDate"> The date-time when this Challenge expires </param>
        /// <param name="detailsMessage"> Shown to the user when the push notification arrives </param>
        /// <param name="detailsFields"> A list of objects that describe the Fields included in the Challenge </param>
        /// <param name="hiddenDetails"> Hidden details provided to contextualize the Challenge </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ChallengeResource> CreateAsync(string pathServiceSid,
                                                                                       string pathIdentity,
                                                                                       string factorSid,
                                                                                       DateTime? expirationDate = null,
                                                                                       string detailsMessage = null,
                                                                                       List<object> detailsFields = null,
                                                                                       object hiddenDetails = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreateChallengeOptions(pathServiceSid, pathIdentity, factorSid){ExpirationDate = expirationDate, DetailsMessage = detailsMessage, DetailsFields = detailsFields, HiddenDetails = hiddenDetails};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchChallengeOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Challenges/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific Challenge.
        /// </summary>
        /// <param name="options"> Fetch Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ChallengeResource Fetch(FetchChallengeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Challenge.
        /// </summary>
        /// <param name="options"> Fetch Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ChallengeResource> FetchAsync(FetchChallengeOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Challenge.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Challenge. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ChallengeResource Fetch(string pathServiceSid,
                                              string pathIdentity,
                                              string pathSid,
                                              ITwilioRestClient client = null)
        {
            var options = new FetchChallengeOptions(pathServiceSid, pathIdentity, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Challenge.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Challenge. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ChallengeResource> FetchAsync(string pathServiceSid,
                                                                                      string pathIdentity,
                                                                                      string pathSid,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new FetchChallengeOptions(pathServiceSid, pathIdentity, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadChallengeOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Challenges",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieve a list of all Challenges for a Factor.
        /// </summary>
        /// <param name="options"> Read Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ResourceSet<ChallengeResource> Read(ReadChallengeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ChallengeResource>.FromJson("challenges", response.Content);
            return new ResourceSet<ChallengeResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Challenges for a Factor.
        /// </summary>
        /// <param name="options"> Read Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ChallengeResource>> ReadAsync(ReadChallengeOptions options,
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ChallengeResource>.FromJson("challenges", response.Content);
            return new ResourceSet<ChallengeResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Challenges for a Factor.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="factorSid"> Factor Sid. </param>
        /// <param name="status"> The Status of theChallenges to fetch </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ResourceSet<ChallengeResource> Read(string pathServiceSid,
                                                          string pathIdentity,
                                                          string factorSid = null,
                                                          ChallengeResource.ChallengeStatusesEnum status = null,
                                                          int? pageSize = null,
                                                          long? limit = null,
                                                          ITwilioRestClient client = null)
        {
            var options = new ReadChallengeOptions(pathServiceSid, pathIdentity){FactorSid = factorSid, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Challenges for a Factor.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="factorSid"> Factor Sid. </param>
        /// <param name="status"> The Status of theChallenges to fetch </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ChallengeResource>> ReadAsync(string pathServiceSid,
                                                                                                  string pathIdentity,
                                                                                                  string factorSid = null,
                                                                                                  ChallengeResource.ChallengeStatusesEnum status = null,
                                                                                                  int? pageSize = null,
                                                                                                  long? limit = null,
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new ReadChallengeOptions(pathServiceSid, pathIdentity){FactorSid = factorSid, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ChallengeResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ChallengeResource>.FromJson("challenges", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ChallengeResource> NextPage(Page<ChallengeResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<ChallengeResource>.FromJson("challenges", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ChallengeResource> PreviousPage(Page<ChallengeResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<ChallengeResource>.FromJson("challenges", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateChallengeOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Challenges/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Verify a specific Challenge.
        /// </summary>
        /// <param name="options"> Update Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ChallengeResource Update(UpdateChallengeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Verify a specific Challenge.
        /// </summary>
        /// <param name="options"> Update Challenge parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ChallengeResource> UpdateAsync(UpdateChallengeOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Verify a specific Challenge.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Challenge. </param>
        /// <param name="authPayload"> Optional payload to verify the Challenge </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Challenge </returns>
        public static ChallengeResource Update(string pathServiceSid,
                                               string pathIdentity,
                                               string pathSid,
                                               string authPayload = null,
                                               ITwilioRestClient client = null)
        {
            var options = new UpdateChallengeOptions(pathServiceSid, pathIdentity, pathSid){AuthPayload = authPayload};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Verify a specific Challenge.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Challenge. </param>
        /// <param name="authPayload"> Optional payload to verify the Challenge </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Challenge </returns>
        public static async System.Threading.Tasks.Task<ChallengeResource> UpdateAsync(string pathServiceSid,
                                                                                       string pathIdentity,
                                                                                       string pathSid,
                                                                                       string authPayload = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new UpdateChallengeOptions(pathServiceSid, pathIdentity, pathSid){AuthPayload = authPayload};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ChallengeResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ChallengeResource object represented by the provided JSON </returns>
        public static ChallengeResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ChallengeResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Challenge.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// Entity Sid.
        /// </summary>
        [JsonProperty("entity_sid")]
        public string EntitySid { get; private set; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// Factor Sid.
        /// </summary>
        [JsonProperty("factor_sid")]
        public string FactorSid { get; private set; }
        /// <summary>
        /// The date this Challenge was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Challenge was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The date this Challenge was responded
        /// </summary>
        [JsonProperty("date_responded")]
        public DateTime? DateResponded { get; private set; }
        /// <summary>
        /// The date-time when this Challenge expires
        /// </summary>
        [JsonProperty("expiration_date")]
        public DateTime? ExpirationDate { get; private set; }
        /// <summary>
        /// The Status of this Challenge
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChallengeResource.ChallengeStatusesEnum Status { get; private set; }
        /// <summary>
        /// The Reason of this Challenge `status`
        /// </summary>
        [JsonProperty("responded_reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChallengeResource.ChallengeReasonsEnum RespondedReason { get; private set; }
        /// <summary>
        /// Details about the Challenge.
        /// </summary>
        [JsonProperty("details")]
        public object Details { get; private set; }
        /// <summary>
        /// Hidden details about the Challenge
        /// </summary>
        [JsonProperty("hidden_details")]
        public object HiddenDetails { get; private set; }
        /// <summary>
        /// The Factor Type of this Challenge
        /// </summary>
        [JsonProperty("factor_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChallengeResource.FactorTypesEnum FactorType { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private ChallengeResource()
        {

        }
    }

}