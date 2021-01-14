using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DbCoreCompare
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCompare_Click(object sender, EventArgs e)
		{

		}
		private XmlMap ConvertToInline(XmlElementMap map)
		{
			XmlMap xml = new XmlMap();
			int count = map.Tables.Count();
			int index = 0;
			int colIndex;
			int xmlIndexCol;

			xml.MainTables = new MainTable();
			xml.MainTables.Tables = new Table[count];
			xml.Name = map.Name;

			foreach (var table in map.Tables)
			{
				xml.MainTables.Tables[index] = new Table();
				xml.MainTables.Tables[index].Name = table.Name;
				xml.MainTables.Tables[index].MainColumn = new MainColumn();
				xml.MainTables.Tables[index].MainIndex = new MainIndex();
				xml.MainTables.Tables[index].MainColumn.Columns = new Column[table.Columns.Count()];
				xml.MainTables.Tables[index].MainIndex.Indexes = new Index[table.Indexes.Count()];
				colIndex = 0;
				foreach (var c in table.Columns)
				{
					xml.MainTables.Tables[index].MainColumn.Columns[colIndex] = new Column();
					xml.MainTables.Tables[index].MainColumn.Columns[colIndex].AutoIncrement = c.AutoIncrement;
					xml.MainTables.Tables[index].MainColumn.Columns[colIndex].DefaultValue = c.DefaultValue;
					xml.MainTables.Tables[index].MainColumn.Columns[colIndex].IsNullable = c.IsNullable;
					xml.MainTables.Tables[index].MainColumn.Columns[colIndex].IsPrimary = c.IsPrimary;
					xml.MainTables.Tables[index].MainColumn.Columns[colIndex].Name = c.Name;
					xml.MainTables.Tables[index].MainColumn.Columns[colIndex].Type = c.Type;
					colIndex++;
				}
				colIndex = 0;
				foreach (var i in table.Indexes)
				{
					xml.MainTables.Tables[index].MainIndex.Indexes[colIndex] = new Index();
					xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].FillFactor = i.FillFactor;
					xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].IsPrimary = i.IsPrimary;
					xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].Name = i.Name;
					xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].SQLScript = i.SQLScript;
					xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].Unique = i.Unique;

					xmlIndexCol = 0;
					if (i.Columns != null)
					{
						xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].Columns = new IndexColumn[i.Columns.Count()];
						foreach (var ixc in i.Columns)
						{
							xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].Columns[xmlIndexCol] = new IndexColumn();
							xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].Columns[xmlIndexCol].IsDescending = ixc.IsDescending;
							xml.MainTables.Tables[index].MainIndex.Indexes[colIndex].Columns[xmlIndexCol].Name = ixc.Name;
							xmlIndexCol++;
						}
					}
					colIndex++;
				}
				index++;
			}

			return xml;
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			XmlRootAttribute xRoot = new XmlRootAttribute();
			xRoot.ElementName = "xmldata";
			xRoot.IsNullable = true;

			// read standard format file
			XmlSerializer reader = new XmlSerializer(typeof(XmlElementMap), xRoot);
			System.IO.StreamReader file = new System.IO.StreamReader(@"c:\Temp\ConToXML.xml");
			XmlElementMap overview = (XmlElementMap)reader.Deserialize(file);
			file.Close();

			// write out the conversion to inline 
			var b = ConvertToInline(overview);
			var writer = new XmlSerializer(typeof(XmlMap));
			var wfile = new System.IO.StreamWriter(@"c:\Temp\XMLfinal.xml");
			writer.Serialize(wfile, b);
			wfile.Close();

			string text = System.IO.File.ReadAllText(@"c:\Temp\XMLfinal.xml");

			txtXML.Text = text;
		}
	}
}
