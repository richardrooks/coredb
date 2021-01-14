using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DbCoreCompare
{
	[XmlTypeAttribute(AnonymousType = true)]
	public class XmlElementMap
	{
		[XmlElement("Name")]
		public string Name;
		[XmlElement("Tables")]
		public XMLTable[] Tables;
	}
	public class XMLTable
	{
		[XmlElement("Name")]
		public string Name;
		[XmlElement("Columns")]
		public XMLColumn[] Columns;
		[XmlElement("Indexes")]
		public XMLIndex[] Indexes;

	}
	public class XMLColumn
	{
		[XmlElement("Name")]
		public string Name;
		[XmlElement("Type")]
		public string Type;
		[XmlElement("IsNullable")]
		public bool IsNullable;
		[XmlElement("DefaultValue")]
		public string DefaultValue;
		[XmlElement("IsPrimary")]
		public bool IsPrimary;
		[XmlElement("AutoIncrement")]
		public bool AutoIncrement;
	}
	public class XMLIndex
	{
		[XmlElement("Name")]
		public string Name;
		[XmlElement("Columns")]
		public XMLIndexColumn[] Columns;
		[XmlElement("Unique")]
		public bool Unique;
		[XmlElement("IsPrimary")]
		public bool IsPrimary;
		[XmlElement("SQLScript")]
		public string SQLScript;
		[XmlElement("FillFactor")]
		public int FillFactor;

	}
	public class XMLIndexColumn
	{
		[XmlElement("Name")]
		public string Name;
		[XmlElement("IsDescending")]
		public bool IsDescending;
	}
}
