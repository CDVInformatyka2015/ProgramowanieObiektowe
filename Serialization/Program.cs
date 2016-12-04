using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        private static object oPersonsList;

        static void Main(string[] args)
        {
            int[] age;
            string[] name, surname;

            do
            {

            } while (true);

            if (renderXML(age,name,surname))
            {
                Console.WriteLine("UDAŁO SIĘ!");
                Console.ReadKey();
            }
        }

        static bool renderXML(int[] age, string[] name, string[] surname)
        {
            List<Person> oPersonsList = new List<Person>();
            int nCounter = 0;
            for (int i = 0; i < age.Length; i++)
            {
                oPersonsList.Add(new Person(++nCounter, name[i], surname[i], age[i]));
            }


        }

        static bool toXML(string fileName, List<Person> oPersonList)
        {
            XmlRootAttribute oRootAttr = new XmlRootAttribute();
            oRootAttr.ElementName = fileName;
            oRootAttr.IsNullable = true;
            XmlSerializer oSerializer = new XmlSerializer(typeof(List<Person>), oRootAttr);
            StreamWriter oStreamWriter = null;
            try
            {
                oStreamWriter = new StreamWriter(fileName + ".xml");
                oSerializer.Serialize(oStreamWriter, oPersonsList);
            }
            catch (Exception oException)
            {
                Console.WriteLine("ERROR: " + oException.Message);
                return false;
            }
            finally
            {
                if (oStreamWriter != null)
                {
                    oStreamWriter.Dispose();
                }
            }
            return true;
        }
    }
}
