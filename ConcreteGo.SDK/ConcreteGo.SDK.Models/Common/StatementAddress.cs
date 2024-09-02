﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common
{
    [XmlRoot(ElementName = "StatementAddress")]
    public class StatementAddress
    {

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName = "Addr1")]
        public string Addr1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Addr2")]
        public string Addr2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "City")]
        public string City { get; set; } = string.Empty;

        [XmlElement(ElementName = "State")]
        public string State { get; set; } = string.Empty;

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; } = string.Empty;
    }
}
