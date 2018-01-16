using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateEntityAndMapping
{
    public class CreateEntityClass
    {
        public void ToEntityClass(string txtPath)
        {
            if (string.IsNullOrEmpty(txtPath) || !File.Exists(txtPath))
                return;

            StreamReader streamReader = new StreamReader(txtPath, Encoding.Default);
            string txtEndStr = streamReader.ReadToEnd();
            streamReader.Close();
            if (string.IsNullOrEmpty(txtEndStr))
                return;

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var allCs = txtEndStr.Split('%');
                for (int i = 0; i < allCs.Length; i++)
                {
                    var everyCs = allCs[i];
                    var line = everyCs.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string className = line[1].Split(',')[0];
                    using (StreamWriter streamWriter = new StreamWriter(System.IO.Path.Combine(folderBrowserDialog.SelectedPath, className + ".cs"), false, Encoding.Default))
                    {
                        streamWriter.WriteLine("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;");
                        streamWriter.WriteLine("\r\n");
                        streamWriter.WriteLine($"namespace {line[0].Split(',')[1]}");
                        streamWriter.WriteLine("{");
                        streamWriter.WriteLine("   [Serializable]");
                        streamWriter.WriteLine($"   public class {className}");
                        streamWriter.WriteLine("   {");
                        //add ID property
                        streamWriter.WriteLine("      /// <summary>");
                        streamWriter.WriteLine("      /// ID");
                        streamWriter.WriteLine("      /// <summary>");
                        streamWriter.WriteLine("      public virtual Guid ID { get; set; }");
                        //add other property
                        for (int j = 2; j < line.Length; j++)
                        {
                            streamWriter.WriteLine("     /// <summary>");
                            streamWriter.WriteLine($"     /// {line[j].Split(',')[0]}");
                            streamWriter.WriteLine("     /// <summary>");
                            streamWriter.WriteLine($"     public virtual {ConvertType(line[j].Split(',')[2])} {line[j].Split(',')[1]}" + "{ get; set; }");
                        }

                        streamWriter.WriteLine("   }");
                        streamWriter.WriteLine("}");
                    }
                }
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
                    convert = "DateTime";
                    break;
                case "Int":
                case "INT":
                    convert = "int";
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
    }
}
