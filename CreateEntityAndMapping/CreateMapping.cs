using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace CreateEntityAndMapping
{
    public class CreateMapping
    {
        byte[] byData = new byte[100];
        char[] charData = new char[1000];
        string txtContent = string.Empty;

        public void ToMappingXml(string txtPath)
        {
            if (string.IsNullOrEmpty(txtPath) || !File.Exists(txtPath))
                return;

            //FileStream fileStream = new FileStream(txtPath, FileMode.Open);
            //fileStream.Seek(0, SeekOrigin.Begin);
            //fileStream.Read(byData, 0, 100);
            //Decoder decoder = Encoding.Default.GetDecoder();
            //decoder.GetChars(byData, 0, byData.Length, charData, 0);
            //fileStream.Close();
            StreamReader streamReader = new StreamReader(txtPath, Encoding.Default);
            txtContent = streamReader.ReadToEnd();
            streamReader.Close();

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Title = "save path";
            //saveFileDialog.Filter = "(Mapping).xml|*.xml";
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ToProcedure(folderBrowserDialog.SelectedPath);
            }
        }

        private void ToProcedure(string xmlSavePath)
        {
            if (string.IsNullOrEmpty(txtContent))
                return;

            string[] allXmls = txtContent.Split('%');
            string everyXml = null;
            for (int i = 0; i < allXmls.Length; i++)
            {
                everyXml = allXmls[i];
                var line = everyXml.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                string xmlName = line[1].Split(',')[0];
                XmlTextWriter xmlTextWrite = new XmlTextWriter(System.IO.Path.Combine(xmlSavePath, xmlName + ".hbm.xml"), Encoding.UTF8);
                xmlTextWrite.Formatting = Formatting.Indented;
                //xmlTextWrite.IndentChar
                xmlTextWrite.Indentation = 3;
                xmlTextWrite.WriteStartDocument();
                xmlTextWrite.WriteStartElement("hibernate-mapping"); //start hibernate-mapping
                xmlTextWrite.WriteAttributeString("xmlns", "urn:nhibernate-mapping-2.2");
                xmlTextWrite.WriteAttributeString("assembly", line[0].Split(',')[0]);
                xmlTextWrite.WriteAttributeString("namespace", line[0].Split(',')[1]);
                xmlTextWrite.WriteStartElement("class"); //start class
                xmlTextWrite.WriteAttributeString("name", xmlName);
                xmlTextWrite.WriteAttributeString("table", line[1].Split(',')[1]);
                xmlTextWrite.WriteAttributeString("lazy", "true");
                xmlTextWrite.WriteStartElement("id"); //start id
                xmlTextWrite.WriteAttributeString("name", "ID");
                xmlTextWrite.WriteAttributeString("column", "ID");
                xmlTextWrite.WriteAttributeString("type", "Guid");
                xmlTextWrite.WriteStartElement("generator"); //start generator
                xmlTextWrite.WriteAttributeString("class", "assigned");
                xmlTextWrite.WriteEndElement(); //end generator
                xmlTextWrite.WriteEndElement(); //end ID
                for (int j = 2; j < line.Length; j++)
                {
                    //every line
                    xmlTextWrite.WriteStartElement("property"); //start property
                    xmlTextWrite.WriteAttributeString("name", line[j].Split(',')[1]);
                    string type = ConvertType(line[j].Split(',')[2]);
                    xmlTextWrite.WriteAttributeString("type", type);
                    xmlTextWrite.WriteStartElement("column"); //start column
                    xmlTextWrite.WriteAttributeString("name", line[j].Split(',')[1]);
                    if (type == "float")
                    {
                        //(15 2)
                        var split = line[j].Split(',')[3].Split(' ');
                        string precision = split[0].Substring(1, split[0].Length - 1).Trim();
                        string scale = split[1].Substring(0, split[1].Length - 1).Trim();
                        xmlTextWrite.WriteAttributeString("precision", precision);
                        xmlTextWrite.WriteAttributeString("scale", scale);
                    }
                    else
                    {
                        string le = line[j].Split(',')[3];
                        if (!string.IsNullOrEmpty(le))
                            xmlTextWrite.WriteAttributeString("length", le);
                    }
                    if (IsNotNull(line[j].Split(',')[4]))
                    {
                        //不能为空
                        xmlTextWrite.WriteAttributeString("not-null", "true");
                    }
                    xmlTextWrite.WriteEndElement(); //end column
                    xmlTextWrite.WriteEndElement(); //end property
                }

                xmlTextWrite.WriteEndElement(); //end class
                xmlTextWrite.WriteEndElement(); //end hibernate-mapping
                xmlTextWrite.WriteEndDocument();
                xmlTextWrite.Close();
            }
        }

        private string ConvertType(string type)
        {
            string convert = string.Empty;
            switch (type)
            {
                case "Char":
                case "VarChar":
                    convert = "string";
                    break;
                case "Float":
                    convert = "float";
                    break;
                case "Date":
                    convert = "date";
                    break;
                case "Int":
                case "INT":
                    convert = "integer";
                    break;
                case "Varbin":
                    convert = "string";
                    break;
                default:
                    convert = "";
                    break;
            }
            return convert;
        }

        private bool IsNotNull(string conditon)
        {
            bool isNotNull = false;
            if (conditon == "M" || conditon == "m")
                isNotNull = true;
            return isNotNull;
        }

    }
}
