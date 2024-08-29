using Cordwell.ConcreteGo.API.Connector.Models;
using System.Xml.Serialization;

namespace Cordwell.EmailService.API.Connector.Models {
        [XmlRoot(ElementName = "WebcreteXMLMsgsRs")]
        public  class WebcreteXMLMsgsRs
        {

            [XmlElement(ElementName = "TicketQueryRs")]
            public TicketQueryRs TicketQueryRs { get; set; }
        
            // TODO move Orders out of tickets
            [XmlElement(ElementName = "OrderQueryRs")]
            public OrderQueryRs OrderQueryRs { get; set; }
        }


        [XmlRoot(ElementName = "WebcreteXML")]
        public class TicketQueryResponse
        {

            [XmlElement(ElementName = "WebcreteXMLMsgsRs")]
            public WebcreteXMLMsgsRs WebcreteXMLMsgsRs { get; set; }
        }
}