using ChiefRabbinateQueries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ChiefRabbinateQueries.Configuration.AppConfiguration;
using static ChiefRabbinateQueries.Model.DateModel;

namespace ChiefRabbinateQueries.Service
{
    internal static class DateService
    {
        public static void CreateXmlIfNotExist()
        {
            if (!File.Exists(filePath))
            {
                XDocument xmlDoc = new();
                XElement queries = new("Queries");
                xmlDoc.Add(queries);
                xmlDoc.Save(filePath);
            }
        }

        public static DateModel AddNewDate(DateModel? newDate) 
        {
            if (newDate == null) { return null; }

            try
            {
                XDocument? xmlDoc = XDocument.Load(filePath);
                XElement? queries = xmlDoc.Descendants("Queries").First();


                XElement? date = new(
                    "Query",
                    new XElement("Day", newDate.Day),
                    new XElement("DayMonth", newDate.DayMonth),
                    new XElement("Month", newDate.Month),
                    new XElement("Year", newDate.Year),
                    new XElement("Result", newDate.Result)
                    );

                queries.Add(date);
                xmlDoc.Save(filePath);

                return newDate;
            }
            catch (Exception ex) { return null; }
        }
    }
}
