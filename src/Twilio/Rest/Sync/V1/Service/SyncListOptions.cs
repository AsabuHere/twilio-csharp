/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service
{

    /// <summary>
    /// FetchSyncListOptions
    /// </summary>
    public class FetchSyncListOptions : IOptions<SyncListResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List resource to fetch
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSyncListOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to fetch </param>
        /// <param name="pathSid"> The SID of the Sync List resource to fetch </param>
        public FetchSyncListOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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

    /// <summary>
    /// DeleteSyncListOptions
    /// </summary>
    public class DeleteSyncListOptions : IOptions<SyncListResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List resource to delete
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSyncListOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to delete </param>
        /// <param name="pathSid"> The SID of the Sync List resource to delete </param>
        public DeleteSyncListOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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

    /// <summary>
    /// CreateSyncListOptions
    /// </summary>
    public class CreateSyncListOptions : IOptions<SyncListResource>
    {
        /// <summary>
        /// The SID of the Sync Service  to create the new Sync List in
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Alias for collection_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// How long, in seconds, before the Sync List expires and is deleted
        /// </summary>
        public int? CollectionTtl { get; set; }

        /// <summary>
        /// Construct a new CreateSyncListOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service  to create the new Sync List in </param>
        public CreateSyncListOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateSyncListOptions
    /// </summary>
    public class UpdateSyncListOptions : IOptions<SyncListResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List resource to update
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// An alias for collection_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// How long, in seconds, before the Sync List expires and is deleted
        /// </summary>
        public int? CollectionTtl { get; set; }

        /// <summary>
        /// Construct a new UpdateSyncListOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to update </param>
        /// <param name="pathSid"> The SID of the Sync List resource to update </param>
        public UpdateSyncListOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadSyncListOptions
    /// </summary>
    public class ReadSyncListOptions : ReadOptions<SyncListResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List resources to read
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadSyncListOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resources to read </param>
        public ReadSyncListOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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

}