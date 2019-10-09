using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DemonstratorApp.ExternalStructs.PubSub
{
    [XmlRoot("SubscriptionRequest")]
    public class SubscriptionRequest
    {
        [XmlElement("authHash")]
        [Newtonsoft.Json.JsonProperty("authHash")]
        public string authHash
        {
            get;
            set;
        }
        [XmlElement("subscriptionId")]
        [Newtonsoft.Json.JsonProperty("subscriptionId")]
        public string subscriptionId
        {
            get;
            set;
        }
        [XmlElement("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public DemonstratorApp.ExternalStructs.PubSub.SubscriptionRule[] data
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           authHash?.ToString() +
                                           subscriptionId?.ToString() +
                                           data?.Sum(x => x?._CalculatedKey)?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("data")]
    [Newtonsoft.Json.JsonObject(Title = "data")]
    public class SubscriptionRule
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
        {
            get;
            set;
        }
        [XmlElement("val")]
        [Newtonsoft.Json.JsonProperty("val")]
        public string val
        {
            get;
            set;
        }
        [XmlElement("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string type
        {
            get;
            set;
        }
        [XmlElement("op")]
        [Newtonsoft.Json.JsonProperty("op")]
        public string op
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           key?.ToString() +
                                           val?.ToString() +
                                           type?.ToString() +
                                           op?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("SubscriptionInfo")]
    public class SubscriptionInfo
    {
        [XmlElement("wsport")]
        [Newtonsoft.Json.JsonProperty("wsport")]
        public int? wsport
        {
            get;
            set;
        }
        [XmlElement("host")]
        [Newtonsoft.Json.JsonProperty("host")]
        public string host
        {
            get;
            set;
        }
        [XmlElement("port")]
        [Newtonsoft.Json.JsonProperty("port")]
        public int? port
        {
            get;
            set;
        }
        [XmlElement("subscriptionId")]
        [Newtonsoft.Json.JsonProperty("subscriptionId")]
        public string subscriptionId
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           wsport?.ToString() +
                                           host?.ToString() +
                                           port?.ToString() +
                                           subscriptionId?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("UnsubscribeRequest")]
    public class UnsubscribeRequest
    {
        [XmlElement("authHash")]
        [Newtonsoft.Json.JsonProperty("authHash")]
        public string authHash
        {
            get;
            set;
        }
        [XmlElement("subscriptionId")]
        [Newtonsoft.Json.JsonProperty("subscriptionId")]
        public string subscriptionId
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           authHash?.ToString() +
                                           subscriptionId?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
}
