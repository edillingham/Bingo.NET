using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime;
using System.Xml;
using System.Xml.Serialization;

namespace BingoLib
{
    public static class PatternSerializer
    {
        public static WinPatternSet DeserializePatternSet(string path, string typ)
        {
            object wps;

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("invalid ");
            }
            else
            {
                path = Path.Combine(path, typ + ".xml");

                XmlSerializer xs = new XmlSerializer(typeof(WinPatternSet));
                XmlTextReader xtr = new XmlTextReader(path);

                try
                {
                    wps = xs.Deserialize(xtr, "");
                }
                catch (Exception ex)
                {
                    //throw ex;
                    wps = null;
                }
                finally
                {
                    xtr.Close();
                }
            }

            return (WinPatternSet)wps;
        }

    }
}
