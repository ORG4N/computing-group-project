using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

using Ecobadge_Website.Model;

namespace Ecobadge_Website.Services
{
    public class BusinessService
    {
        private static List<Business> data = new List<Business>();

        public static void Init()
        {
            BusinessService service = new BusinessService();

            List<string> lines = new List<string>();

            try
            {
                using (FileStream fs = File.Open("wwwroot/values/ECO_Badge_Database.csv", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            lines.Add(sr.ReadLine());
                        }
                    }
                }
            }

            catch (IOException) { }

            // Create each object by reading each field from each line in from the users.csv file
            foreach (string field in lines)
            {
                string[] split = field.Split(',');

                Business business = new Business();

                business.Name = split[0];
                business.Address = split[1];
                business.Postcode = split[2];
                business.Tel = split[3];
                business.Email = split[4];
                business.Website = split[5];
                business.Picture = split[6];
                business.Cuisine = split[7];
                business.Tier = split[8];
                business.Vegan = split[9];
                business.Plastic = split[10];
                business.Foodwaste = split[11];
                business.Local = split[12].Replace("/r","");

                data.Add(business);
            }
        }

        public static List<Business> GetData()
        {
            return data;
        }

    }
}