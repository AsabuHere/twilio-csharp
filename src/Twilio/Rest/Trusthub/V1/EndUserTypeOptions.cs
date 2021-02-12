/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Trusthub.V1
{

    /// <summary>
    /// Retrieve a list of all End-User Types.
    /// </summary>
    public class ReadEndUserTypeOptions : ReadOptions<EndUserTypeResource>
    {
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
    /// Fetch a specific End-User Type Instance.
    /// </summary>
    public class FetchEndUserTypeOptions : IOptions<EndUserTypeResource>
    {
        /// <summary>
        /// The unique string that identifies the End-User Type resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchEndUserTypeOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the End-User Type resource </param>
        public FetchEndUserTypeOptions(string pathSid)
        {
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