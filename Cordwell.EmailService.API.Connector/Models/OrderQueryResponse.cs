using System.Xml.Serialization;

namespace Cordwell.EmailService.API.Connector.Models {
    [XmlRoot(ElementName = "OrderQueryRs")]
    public class OrderQueryRs
    {

        [XmlElement(ElementName = "OrderRet")]
        public List<OrderRet> OrderRet { get; set; }

        [XmlAttribute(AttributeName = "statusCode")]
        public string StatusCode { get; set; }

        [XmlAttribute(AttributeName = "statusSeverity")]
        public string StatusSeverity { get; set; }

        [XmlAttribute(AttributeName = "statusMessage")]
        public string StatusMessage { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
    
    
    
    [XmlRoot(ElementName = "TicketRet")]
    public class OrderRet {
        [XmlElement(ElementName = "OrderID")]
        public int OrderID { get; set; }
        
        [XmlElement(ElementName = "OrderCode")]
        public int OrderCode { get; set; }

        [XmlElement(ElementName = "CreatedDate")]
        public string _CreatedDate { get; set; }
        
        [XmlIgnore]
        public DateTime? CreatedDate
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_CreatedDate, out dt))
                {
                    return dt;
                }
                return null;
            }
        }
        
        [XmlElement(ElementName = "OrderDate")]
        public string _OrderDate { get; set; }

        [XmlIgnore]
        public DateTime? OrderDate
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(_OrderDate, out dt))
                {
                    return dt;
                }
                return null;
            }
        }
        
        [XmlElement(ElementName = "RemovedBy")]
        public string RemovedBy { get; set; }
        
        [XmlElement(ElementName = "Removed")]
        public bool Removed { get; set; }
        
        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; }

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; }
        
        [XmlElement(ElementName = "RecipientEmail")]
        public string RecipientEmail { get; set; }
        
        [XmlElement(ElementName = "JobNumber")]
        public string JobNumber { get; set; }
        
        
        [XmlElement(ElementName = "UserDefinedFields")]
        public List<UserDefinedFields> UserDefinedFields { get; set; }
        
    }

    [XmlRoot(ElementName = "UserDefinedFields")]
    public class UserDefinedFields {
        [XmlElement(ElementName = "UserDefinedField")]
        public List<UserDefinedField> UserDefinedField { get; set; }
    }
    
    
    [XmlRoot(ElementName = "UserDefinedField")]
    public class UserDefinedField {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
        
    }
    
    
    
    
}

