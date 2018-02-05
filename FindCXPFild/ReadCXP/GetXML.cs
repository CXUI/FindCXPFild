using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace ReadCXP
{
     class GetXML
    {
      public string path;
      public string pointOne;
      public string point1;
      public string point2;
      public GetXML()
      {

      }

      public GetXML(string path)
      {
          this.path = path; 
      }


      /// <summary>
      /// 得到xml表中的信息
      /// </summary>
      /// 

      public virtual void GetXMLs()
      {
        XmlReader reader = new XmlTextReader(@path);

        while (reader.Read())
        {
            if (reader.NodeType == XmlNodeType.Element)
            {
                if (reader.LocalName == point1)
                {
                    for (int i = 0; i < reader.AttributeCount; i++)
                    {
                        reader.MoveToAttribute(i);
                        if (reader.Name == point2)
                        {
                            pointOne = reader.Value;
                            //Console.Write("   FileName:" + tempInt);
                            // CreateText(tempInt);
                        }

                    }
                }
            }
        }
      }
    }
}
