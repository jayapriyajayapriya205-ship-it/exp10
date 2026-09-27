using System;
using System.Data;

class Program
{
    static void Main()
    {
        // 1. மெமரியிலேயே DataSet மற்றும் DataTable உருவாக்குதல்
        DataSet ds = new DataSet("CollegeDB");
        DataTable studentTable = new DataTable("Student");

        // 2. Columns அமைத்தல்
        studentTable.Columns.Add("Id", typeof(int));
        studentTable.Columns.Add("Name", typeof(string));
        studentTable.Columns.Add("Department", typeof(string));

        // 3. Rows (டேட்டா) சேர்த்தல்
        studentTable.Rows.Add(1, "Abdul", "IT");
        studentTable.Rows.Add(2, "Chandru", "CSE");
        studentTable.Rows.Add(3, "Reshma", "ECE");

        // 4. Table-ஐ DataSet-க்குள் சேர்த்தல்
        ds.Tables.Add(studentTable);

        Console.WriteLine("--- Student Details (Disconnected Memory Mode) ---");

        // 5. Warning வராமல் இருக்க studentTable-ஐ நேரடியாக loop செய்கிறோம்
        foreach (DataRow row in studentTable.Rows)
        {
            Console.WriteLine($"ID: {row["Id"]} | Name: {row["Name"]} | Dept: {row["Department"]}");
        }
    }
}