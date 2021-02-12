/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Trusthub.V1.CustomerProfiles
{

    /// <summary>
    /// Create a new Evaluation
    /// </summary>
    public class CreateCustomerProfilesEvaluationsOptions : IOptions<CustomerProfilesEvaluationsResource>
    {
        /// <summary>
        /// The unique string that identifies the resource.
        /// </summary>
        public string PathCustomerProfileSid { get; }
        /// <summary>
        /// The unique string of a policy
        /// </summary>
        public string PolicySid { get; }

        /// <summary>
        /// Construct a new CreateCustomerProfilesEvaluationsOptions
        /// </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that identifies the resource. </param>
        /// <param name="policySid"> The unique string of a policy </param>
        public CreateCustomerProfilesEvaluationsOptions(string pathCustomerProfileSid, string policySid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
            PolicySid = policySid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PolicySid != null)
            {
                p.Add(new KeyValuePair<string, string>("PolicySid", PolicySid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of Evaluations associated to the customer_profile resource.
    /// </summary>
    public class ReadCustomerProfilesEvaluationsOptions : ReadOptions<CustomerProfilesEvaluationsResource>
    {
        /// <summary>
        /// The unique string that identifies the resource.
        /// </summary>
        public string PathCustomerProfileSid { get; }

        /// <summary>
        /// Construct a new ReadCustomerProfilesEvaluationsOptions
        /// </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that identifies the resource. </param>
        public ReadCustomerProfilesEvaluationsOptions(string pathCustomerProfileSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch specific Evaluation Instance.
    /// </summary>
    public class FetchCustomerProfilesEvaluationsOptions : IOptions<CustomerProfilesEvaluationsResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathCustomerProfileSid { get; }
        /// <summary>
        /// The unique string that identifies the Evaluation resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCustomerProfilesEvaluationsOptions
        /// </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that identifies the resource </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource </param>
        public FetchCustomerProfilesEvaluationsOptions(string pathCustomerProfileSid, string pathSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}