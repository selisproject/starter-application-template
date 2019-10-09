using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DemonstratorApp.ExternalStructs.KnowledgeGraph
{
    [XmlRoot("KnowledgeGraphRoot")]
    public class KnowledgeGraphRoot
    {
        [XmlElement("columns")]
        [Newtonsoft.Json.JsonProperty("columns")]
        public string[] columns
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
        [XmlElement("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public string[][] data
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
                                           columns?.ToList()?.Count().ToString() +
                                           type?.ToString() +
                                           data?.ToList()?.Count().ToString();
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
    [XmlRoot("NodeRoot")]
    public class NodeRoot
    {
        [XmlElement("extensions")]
        [Newtonsoft.Json.JsonProperty("extensions")]
        public DemonstratorApp.ExternalStructs.KnowledgeGraph.extensions extensions
        {
            get;
            set;
        }
        [XmlElement("metadata")]
        [Newtonsoft.Json.JsonProperty("metadata")]
        public DemonstratorApp.ExternalStructs.KnowledgeGraph.metadata metadata
        {
            get;
            set;
        }
        [XmlElement("paged_traverse")]
        [Newtonsoft.Json.JsonProperty("paged_traverse")]
        public string paged_traverse
        {
            get;
            set;
        }
        [XmlElement("outgoing_relationships")]
        [Newtonsoft.Json.JsonProperty("outgoing_relationships")]
        public string outgoing_relationships
        {
            get;
            set;
        }
        [XmlElement("outgoing_typed_relationships")]
        [Newtonsoft.Json.JsonProperty("outgoing_typed_relationships")]
        public string outgoing_typed_relationships
        {
            get;
            set;
        }
        [XmlElement("create_relationship")]
        [Newtonsoft.Json.JsonProperty("create_relationship")]
        public string create_relationship
        {
            get;
            set;
        }
        [XmlElement("labels")]
        [Newtonsoft.Json.JsonProperty("labels")]
        public string labels
        {
            get;
            set;
        }
        [XmlElement("traverse")]
        [Newtonsoft.Json.JsonProperty("traverse")]
        public string traverse
        {
            get;
            set;
        }
        [XmlElement("all_relationships")]
        [Newtonsoft.Json.JsonProperty("all_relationships")]
        public string all_relationships
        {
            get;
            set;
        }
        [XmlElement("all_typed_relationships")]
        [Newtonsoft.Json.JsonProperty("all_typed_relationships")]
        public string all_typed_relationships
        {
            get;
            set;
        }
        [XmlElement("property")]
        [Newtonsoft.Json.JsonProperty("property")]
        public string property
        {
            get;
            set;
        }
        [XmlElement("self")]
        [Newtonsoft.Json.JsonProperty("self")]
        public string self
        {
            get;
            set;
        }
        [XmlElement("incoming_relationships")]
        [Newtonsoft.Json.JsonProperty("incoming_relationships")]
        public string incoming_relationships
        {
            get;
            set;
        }
        [XmlElement("properties")]
        [Newtonsoft.Json.JsonProperty("properties")]
        public string properties
        {
            get;
            set;
        }
        [XmlElement("incoming_typed_relationships")]
        [Newtonsoft.Json.JsonProperty("incoming_typed_relationships")]
        public string incoming_typed_relationships
        {
            get;
            set;
        }
        [XmlElement("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public DemonstratorApp.ExternalStructs.KnowledgeGraph.data data
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
                                           extensions?._CalculatedKey?.ToString() +
                                           metadata?._CalculatedKey?.ToString() +
                                           paged_traverse?.ToString() +
                                           outgoing_relationships?.ToString() +
                                           outgoing_typed_relationships?.ToString() +
                                           create_relationship?.ToString() +
                                           labels?.ToString() +
                                           traverse?.ToString() +
                                           all_relationships?.ToString() +
                                           all_typed_relationships?.ToString() +
                                           property?.ToString() +
                                           self?.ToString() +
                                           incoming_relationships?.ToString() +
                                           properties?.ToString() +
                                           incoming_typed_relationships?.ToString() +
                                           data?._CalculatedKey?.ToString();
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
    [XmlRoot("extensions")]
    public class extensions
    {
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-";
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
    [XmlRoot("metadata")]
    public class metadata
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public int? id
        {
            get;
            set;
        }
        [XmlElement("labels")]
        [Newtonsoft.Json.JsonProperty("labels")]
        public System.Object[] labels
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
                                           id?.ToString() +
                                           labels?.ToList()?.Count().ToString();
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
    public class data
    {
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-";
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
