using System;
using System.IO;

namespace HQPTParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //file set up and init
            string path = "C:/sp/may120.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            string day = "";
            int lineCount = 0;

            string outpath = "C:/sp/output.csv";
            using (StreamWriter writer = new StreamWriter(outpath))
            {

                //write headers for columns.
                writer.Write("Journal,");
                writer.Write("Date,");
                writer.Write("Description,");
                writer.Write("Line_no,");
                writer.Write("ACCT_NO,");
                writer.Write("Location_ID,");
                writer.Write("Memo,");
                writer.Write("Debit,");
                writer.Write("Credit,");
                writer.Write("Source_Entity,");
                writer.Write("Currency,");
                writer.Write("Exch_rate_date,");
                writer.Write("Exch_rate_type_ID,");
                writer.Write("Exchange_rate,");
                writer.Write("State,");
                writer.Write("Allocation_ID,");
                writer.Write("Billable,");
                writer.Write("Glentry_Customer_ID,");
                writer.Write("Glentry_Vendor_ID,");
                writer.Write("Glentry_Class_ID,");
                writer.WriteLine("Glentry_Project_ID,");





                //loop for iterating though each row

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] columns = lines[i].Split(',');
                    if (day != columns[7])
                    {
                        day = columns[7];
                        lineCount = 0;
                    }
                    lineCount += 1;
                    
                    //journal
                    writer.Write(",");
                    
                    //Date
                    writer.Write(columns[7] +",");

                    //Description
                    writer.Write(",");

                    //Line_no
                    writer.Write(lineCount +",");

                    //accnt_no
                    writer.Write(columns[2].Substring(columns[2].Length-5) + ",");
                    

                    //Location_ID
                    writer.Write(" ,");

                    //Memo
                    writer.Write(columns[12]+",");


                    //Debit and credit
                    if (columns[0] == "Debit")
                    {
                        writer.Write(columns[5]+",");
                        writer.Write(" ,");
                    }
                    else 
                    {
                        writer.Write(" ,");
                        writer.Write(columns[5]+",");
                    }

                    //Source entity
                    writer.Write(" ,");

                    //currency
                    writer.Write(columns[6] +",");

                    //Exch_rate_date
                    writer.Write(" ,");

                    //Exch_rate_date
                    writer.Write(" ,");

                    //Exch_rate_Type_ID
                    writer.Write(" ,");

                    //Exchange_rate
                    writer.Write(" ,");

                    //State
                    writer.Write(" ,");

                    //Allocation_ID
                    writer.Write(" ,");

                    //Billable
                    writer.Write(" ,");

                    //Glentry_CustomerID
                    writer.Write(" ,");

                    //Glentry_vendorID
                    writer.Write(" ,");

                    //Glentry_ClassID
                    writer.Write(" ,");

                    //Glentry_ProjectID
                    writer.WriteLine(" ,");



                }
            }
        }
    }
}
