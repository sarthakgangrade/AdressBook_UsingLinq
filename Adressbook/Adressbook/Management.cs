using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    public class Management
    {
        DataTable dt = new DataTable();
        public void CreateDataTable()
        {


            dt.Columns.Add("firstName").DataType = typeof(string);
            dt.Columns.Add("lastName").DataType = typeof(string);
            dt.Columns.Add("address").DataType = typeof(string);
            dt.Columns.Add("city").DataType = typeof(string);
            dt.Columns.Add("state").DataType = typeof(string);
            dt.Columns.Add("zip").DataType = typeof(int);
            dt.Columns.Add("phoneNumber").DataType = typeof(string);
            dt.Columns.Add("email").DataType = typeof(string);
            DataRow Rows = dt.NewRow();
            dt.Rows.Add("sam", "gupta", "Rambagh", "indore", "M.P.","452111","1234567890","sg@gmail.com");
            dt.Rows.Add("ram", "verma", "krishna nagar", "Khandwa", "M.P.","432156","0123456789","rv@gmail.com");
            dt.Rows.Add("Samarth", "meena", "murrai mahulla", "Kanpur", "U.P.","234567","2345678901","sm@rediffmail.com");
            dt.Rows.Add("Sarthak", "gangrade", "chawani", "Rishikesh", "H.P.","345678","345678901","sarthakgangrade0@gmail.com");
            dt.Rows.Add("Sara", "sharma", "nipaniya", "gajiyabad", "delhi","452011","4567890123","sarash..ma@gmail.com");
            dt.Rows.Add("vishal", "singh", "kanchanbagh", "shrinagar", "j&k","567890","5678901234","vish@yahoo.com");

            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine("firstName::" + r["firstName"] + " " + "lastName::" + r["lastName"] + " " + "address::" + r["address"] + " " + "city::" + r["city"] + " " + "state::" + r["state"] + " " + "zip::" + r["zip"] + " " + "phoneNumber::" + r["phoneNumber"] + " " + "email::" + r["email"]);

            }
        }

    }
}
