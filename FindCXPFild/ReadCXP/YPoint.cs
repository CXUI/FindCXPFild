using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadCXP
{
    class YPoint:XMLInformation
    {
        public string point2;
        public string point1;
        public string path;
        public YPoint(string point1,string point2,string path)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.path = path;

        }
        public override void GetXMLs()
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
            base.GetXMLs();
        }

        public string GetZPoint()
        {
            return pointOne;
        }

    }
}
