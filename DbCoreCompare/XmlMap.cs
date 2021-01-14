using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DbCoreCompare
{
	public class XmlMap
	{
		[XmlAttribute("Name")]
		public string Name;
		[XmlElement("Tables")]
		public MainTable MainTables;
	}
	public class MainTable
	{
		[XmlElement("Table")]
		public Table[] Tables;
	}
	public class Table
	{
		[XmlAttribute("Name")]
		public string Name;
		[XmlElement("Columns")]
		public MainColumn MainColumn;
		[XmlElement("Indexes")]
		public MainIndex MainIndex;
	}
	public class MainColumn
	{
		[XmlElement("Column")]
		public Column[] Columns;
	}
	public class Column
	{
		[XmlAttribute("Name")]
		public string Name;
		[XmlAttribute("Type")]
		public string Type;
		[XmlAttribute("IsNullable")]
		public bool IsNullable;
		[XmlAttribute("DefaultValue")]
		public string DefaultValue;
		[XmlAttribute("IsPrimary")]
		public bool IsPrimary;
		[XmlAttribute("AutoIncrement")]
		public bool AutoIncrement;
	}
	public class MainIndex
	{
		[XmlElement("Index")]
		public Index[] Indexes;
	}

	public class Index
	{
		[XmlAttribute("Name")]
		public string Name;
		[XmlElement("Columns")]
		public IndexColumn[] Columns;
		[XmlAttribute("Unique")]
		public bool Unique;
		[XmlAttribute("IsPrimary")]
		public bool IsPrimary;
		[XmlAttribute("SQLScript")]
		public string SQLScript;
		[XmlAttribute("FillFactor")]
		public int FillFactor;

	}
	public class IndexColumn
	{
		[XmlAttribute("Name")]
		public string Name;
		[XmlAttribute("IsDescending")]
		public bool IsDescending;
	}
}
