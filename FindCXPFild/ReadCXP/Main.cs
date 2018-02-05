using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;

namespace ReadCXP
{
    public partial class Main : Form
    {
        private string fildURL;
        private string getURL;

        public string tempInt { get; set; }
        public string tempString { get; set; }
        public string tempFloat1 { get; set; }
        public string tempFloat2 { get; set; }
        public string tempFloat3 { get; set; }

        public string txtName ="position";



        public string namePoint1 = "PhotoArchive";
        public string namePoint2 = "FileName";

        public string xPoint1 = "Xs";
        public string xpoint2 = "Value";

        public string yPoint1 = "Ys";
        public string yPoint2 = "Value";

        public string zPoint1 = "Zs";
        public string zPoint2 = "Value";

        public Main()
        {
            InitializeComponent();

            textName.Text = "position";

            txtName = textName.Text;
        }

        /// <summary>
        /// 获取路径text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textURL_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 生成位置text按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetermineButton_Click(object sender, EventArgs e)
        {
 

            try
            {
                fildURL = @textURL.Text.ToString();
                txtName = textName.Text;
                GetFild(fildURL);
                GetFildXML(fildURL);
            }
            catch(ExecutionEngineException)
            {
                testtextBox.Text = "路径为空";
            }
          
        }

        /// <summary>
        /// 获得文件夹下所有的物体，更改后缀为xml
        /// </summary>
        /// <param name="path"></param>
        private void GetFild(string path)
        {

            DirectoryInfo folder = new DirectoryInfo(path);
   
            foreach (FileInfo file in folder.GetFiles("*.cxp"))
            {
               //更改文件后缀名
                getURL = System.IO.Path.ChangeExtension(file.FullName, ".xml");

                File.Move(file.FullName, getURL);
            }
        }

        /// <summary>
        /// 获取文件夹下所有的物体，更改后缀为cxp
        /// </summary>
        /// <param name="path"></param>
        private void GetFildCXP(string path)
        {

            DirectoryInfo folder = new DirectoryInfo(path);

            foreach (FileInfo file in folder.GetFiles("*.xml"))
            {
                //更改文件后缀名
                getURL = System.IO.Path.ChangeExtension(file.FullName, ".cxp");

                File.Move(file.FullName, getURL);


            }
        }

        /// <summary>
        /// 读取xml
        /// </summary>
        /// <param name="path"></param>
        private void GetFildXML(string path)
        {
            DirectoryInfo folder = new DirectoryInfo(path);

            foreach(FileInfo file in folder.GetFiles("*.xml"))
            {

                testtextBox.Text = file.FullName;
            
              //  LoadXml(file.FullName);
                GetXMLInfro(file.FullName);
            }

            
        }

        public void GetXMLInfro(string path)
        {
            GetXML getxml = new GetXML(path);

            NameXML namexml = new NameXML(namePoint1, namePoint2,path);
            XPoint xp = new XPoint(xPoint1, xpoint2,path);
            YPoint yp = new YPoint(yPoint1, yPoint2,path);
            ZPoint zp = new ZPoint(zPoint1, zPoint2,path);

            namexml.Decorator(getxml);
            xp.Decorator(namexml);
            yp.Decorator(xp);
            zp.Decorator(yp);
            zp.GetXMLs();

            CreateText(namexml.GetZPoint(), xp.GetZPoint(), yp.GetZPoint(), zp.GetZPoint());
        }

        //void LoadXml(string path)
        //{

        // //   string path = @"C:\Users\Administrator\Desktop\filds\BJ0627AR0001.xml";
         
        //    XmlReader reader = new XmlTextReader(@path);


        //    while (reader.Read())
        //    {
        //        if (reader.NodeType == XmlNodeType.Element)
        //        {
        //            if (reader.LocalName == "PhotoArchive")
        //            {
        //                for (int i = 0; i < reader.AttributeCount; i++)
        //                {
        //                    reader.MoveToAttribute(i);
        //                    if (reader.Name == "FileName")
        //                    {
        //                        tempInt = reader.Value;
        //                        Console.Write("   FileName:" + tempInt);
        //                       // CreateText(tempInt);
        //                    }

        //                }
        //            }

        //            if (reader.LocalName == "Xs")
        //            {
        //                for (int i = 0; i < reader.AttributeCount; i++)
        //                {
        //                    reader.MoveToAttribute(i);
        //                    if (reader.Name == "Value")
        //                    {
        //                        tempString = reader.Value;
        //                        Console.Write("   FileName:" + tempString);
        //                      //  CreateText(tempString);
        //                    }

        //                }
        //            }


        //            if (reader.LocalName == "Ys")
        //            {
        //                for (int i = 0; i < reader.AttributeCount; i++)
        //                {
        //                    reader.MoveToAttribute(i);
        //                    if (reader.Name == "Value")
        //                    {
        //                        tempFloat1 = reader.Value;
        //                        Console.Write("   FileName:" + tempFloat1);
        //                       // CreateText(tempFloat1);
        //                    }

        //                }
        //            }


        //            if (reader.LocalName == "Zs")
        //            {
        //                for (int i = 0; i < reader.AttributeCount; i++)
        //                {
        //                    reader.MoveToAttribute(i);
        //                    if (reader.Name == "Value")
        //                    {
        //                        tempFloat2 = reader.Value;
        //                        Console.Write("   FileName:" + tempFloat2);
        //                        //CreateText(tempFloat2);
        //                    }

        //                }
        //            }
        //        }
    
        //    }
        //    CreateText(tempInt, tempString, tempFloat1, tempFloat2);


        //}




        void CreateText(string writes1,string writes2,string writers3,string writers4)
        {
            if (!File.Exists(@"C:\Users\Administrator\Desktop\filds\" + txtName + ".txt"))
            {
                FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\filds\" + txtName + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(writes1+"\t"+writes2+"\t"+writers3+"\t"+writers4);
                sw.Close();
                fs.Close();

            }
            else
            {
                // FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\filds\position.txt",FileMode.Open, FileAccess.Write);

                //StreamWriter sw = new StreamWriter(fs,true,Encoding.Default);
                StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Desktop\filds\" + txtName + ".txt", true, Encoding.Default);//实例化StreamWriter

                sw.WriteLine(writes1 + "\t" + writes2 + "\t" + writers3 + "\t" + writers4);
                sw.Flush();
                sw.Close();
            }
        }

        private void GetInformation1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
      
           // testtextBox.Text = txtName;
        }
    }
}
