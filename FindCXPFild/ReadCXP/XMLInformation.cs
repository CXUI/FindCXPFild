using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCXP
{
    class XMLInformation:GetXML
    {

        public GetXML getXML;

 
  
        public void Decorator(GetXML getxml) 
        {

            getXML = getxml;

        }

        public override void GetXMLs( )
        {
            if(getXML!=null)
            {
                getXML.GetXMLs( );
            }
            
        }

      
    }
}
