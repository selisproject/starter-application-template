using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DemonstratorApp.ExternalStructs.BDALayerDataAPI
{
    [XmlRoot("recipe")]
    public class recipe
    {
        [XmlElement("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string name
        {
            get;
            set;
        }
        [XmlElement("description")]
        [Newtonsoft.Json.JsonProperty("description")]
        public string description
        {
            get;
            set;
        }
        [XmlElement("executablePath")]
        [Newtonsoft.Json.JsonProperty("executablePath")]
        public string executablePath
        {
            get;
            set;
        }
        [XmlElement("engineId")]
        [Newtonsoft.Json.JsonProperty("engineId")]
        public int? engineId
        {
            get;
            set;
        }
        [XmlElement("args")]
        [Newtonsoft.Json.JsonProperty("args")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.args args
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
                                           name?.ToString() +
                                           description?.ToString() +
                                           executablePath?.ToString() +
                                           engineId?.ToString() +
                                           args?._CalculatedKey?.ToString();
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
    [XmlRoot("args")]
    public class args
    {
        [XmlElement("intarg")]
        [Newtonsoft.Json.JsonProperty("intarg")]
        public int? intarg
        {
            get;
            set;
        }
        [XmlElement("strarg")]
        [Newtonsoft.Json.JsonProperty("strarg")]
        public string strarg
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
                                           intarg?.ToString() +
                                           strarg?.ToString();
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
    [XmlRoot("msgtype")]
    public class msgtype
    {
        [XmlElement("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string name
        {
            get;
            set;
        }
        [XmlElement("description")]
        [Newtonsoft.Json.JsonProperty("description")]
        public string description
        {
            get;
            set;
        }
        [XmlElement("active")]
        [Newtonsoft.Json.JsonProperty("active")]
        public bool active
        {
            get;
            set;
        }
        [XmlElement("format")]
        [Newtonsoft.Json.JsonProperty("format")]
        public string format
        {
            get;
            set;
        }
        [XmlElement("externalConnectorId")]
        [Newtonsoft.Json.JsonProperty("externalConnectorId")]
        public int? externalConnectorId
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
                                           name?.ToString() +
                                           description?.ToString() +
                                           (active == true).ToString() +
                                           format?.ToString() +
                                           externalConnectorId?.ToString();
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
    [XmlRoot("newscn")]
    public class newscn
    {
        [XmlElement("slug")]
        [Newtonsoft.Json.JsonProperty("slug")]
        public string slug
        {
            get;
            set;
        }
        [XmlElement("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string name
        {
            get;
            set;
        }
        [XmlElement("description")]
        [Newtonsoft.Json.JsonProperty("description")]
        public string description
        {
            get;
            set;
        }
        [XmlElement("dbname")]
        [Newtonsoft.Json.JsonProperty("dbname")]
        public string dbname
        {
            get;
            set;
        }
        [XmlElement("connectorId")]
        [Newtonsoft.Json.JsonProperty("connectorId")]
        public int? connectorId
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
                                           slug?.ToString() +
                                           name?.ToString() +
                                           description?.ToString() +
                                           dbname?.ToString() +
                                           connectorId?.ToString();
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
    [XmlRoot("msg")]
    public class msg
    {
        [XmlElement("entries")]
        [Newtonsoft.Json.JsonProperty("entries")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.entry[] entries
        {
            get;
            set;
        }
        [XmlElement("nested")]
        [Newtonsoft.Json.JsonProperty("nested")]
        public System.Object[] nested
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
                                           entries?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           nested?.ToList()?.Count().ToString();
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
    [XmlRoot("entries")]
    [Newtonsoft.Json.JsonObject(Title = "entries")]
    public class entry
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
        {
            get;
            set;
        }
        [XmlElement("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public string value
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
                                           value?.ToString();
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
    [XmlRoot("job")]
    public class job
    {
        [XmlElement("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string name
        {
            get;
            set;
        }
        [XmlElement("description")]
        [Newtonsoft.Json.JsonProperty("description")]
        public string description
        {
            get;
            set;
        }
        [XmlElement("messageTypeId")]
        [Newtonsoft.Json.JsonProperty("messageTypeId")]
        public int? messageTypeId
        {
            get;
            set;
        }
        [XmlElement("recipeId")]
        [Newtonsoft.Json.JsonProperty("recipeId")]
        public int? recipeId
        {
            get;
            set;
        }
        [XmlElement("active")]
        [Newtonsoft.Json.JsonProperty("active")]
        public bool active
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
                                           name?.ToString() +
                                           description?.ToString() +
                                           messageTypeId?.ToString() +
                                           recipeId?.ToString() +
                                           (active == true).ToString();
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
    [XmlRoot("master_data")]
    public class master_data
    {
        [XmlElement("tables")]
        [Newtonsoft.Json.JsonProperty("tables")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.table_entry[] tables
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
                                           tables?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("tables")]
    [Newtonsoft.Json.JsonObject(Title = "tables")]
    public class table_entry
    {
        [XmlElement("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string name
        {
            get;
            set;
        }
        [XmlElement("schema")]
        [Newtonsoft.Json.JsonProperty("schema")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.schema[] schema
        {
            get;
            set;
        }
        [XmlElement("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.data[] data
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
                                           name?.ToString() +
                                           schema?.Sum(x => x?._CalculatedKey)?.ToString() +
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
    [XmlRoot("schema")]
    public class schema
    {
        [XmlElement("columnNames")]
        [Newtonsoft.Json.JsonProperty("columnNames")]
        public string[] columnNames
        {
            get;
            set;
        }
        [XmlElement("columnTypes")]
        [Newtonsoft.Json.JsonProperty("columnTypes")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.columnTypes[] columnTypes
        {
            get;
            set;
        }
        [XmlElement("primaryKey")]
        [Newtonsoft.Json.JsonProperty("primaryKey")]
        public string primaryKey
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
                                           columnNames?.ToList()?.Count().ToString() +
                                           columnTypes?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           primaryKey?.ToString();
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
    [XmlRoot("columnTypes")]
    public class columnTypes
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
        {
            get;
            set;
        }
        [XmlElement("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public string value
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
                                           value?.ToString();
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
        [XmlElement("tuple")]
        [Newtonsoft.Json.JsonProperty("tuple")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.tuple[] tuple
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
                                           tuple?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("tuple")]
    public class tuple
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
        {
            get;
            set;
        }
        [XmlElement("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public string value
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
                                           value?.ToString();
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
    [XmlRoot("response")]
    public class response
    {
        [XmlElement("details")]
        [Newtonsoft.Json.JsonProperty("details")]
        public string details
        {
            get;
            set;
        }
        [XmlElement("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public string status
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
                                           details?.ToString() +
                                           status?.ToString();
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
    [XmlRoot("connector")]
    public class connector
    {
        [XmlElement("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string name
        {
            get;
            set;
        }
        [XmlElement("metadata")]
        [Newtonsoft.Json.JsonProperty("metadata")]
        public DemonstratorApp.ExternalStructs.BDALayerDataAPI.connector_metadata metadata
        {
            get;
            set;
        }
        [XmlElement("address")]
        [Newtonsoft.Json.JsonProperty("address")]
        public string address
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
        [XmlElement("external")]
        [Newtonsoft.Json.JsonProperty("external")]
        public bool external
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
                                           name?.ToString() +
                                           metadata?._CalculatedKey?.ToString() +
                                           address?.ToString() +
                                           port?.ToString() +
                                           (external == true).ToString();
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
    [XmlRoot("connector_metadata")]
    public class connector_metadata
    {
        [XmlElement("username")]
        [Newtonsoft.Json.JsonProperty("username")]
        public string username
        {
            get;
            set;
        }
        [XmlElement("password")]
        [Newtonsoft.Json.JsonProperty("password")]
        public string password
        {
            get;
            set;
        }
        [XmlElement("datasources")]
        [Newtonsoft.Json.JsonProperty("datasources")]
        public string[] datasources
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
                                           username?.ToString() +
                                           password?.ToString() +
                                           datasources?.ToList()?.Count().ToString();
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
