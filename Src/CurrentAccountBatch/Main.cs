using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCBS.Services;
using OpenCBS.CoreDomain;
using OpenCBS.ExceptionsHandler;
using OpenCBS.CoreDomain.Products;
using System.IO;

namespace CurrentAccountBatch
{
    public partial class Main : Form
    {


         public static StreamWriter LogWriter = null;
        static string contractcode = "";
        static string statuscode = "";
        static string passOrFail = "";
        static string codes;
      

        public Main()
        {
            InitializeComponent();
            


        }

        private void btnSubmit_Click(object sender, EventArgs ex)
        {

            CurrentAccountProductHoldingServices currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
            List<CurrentAccountProductHoldings> currentAccountProductHoldingList = currentAccountProductHoldingServices.FetchProduct(false);
            
            string excludedAccountList = txtExcludedNumbers.Text;

            string[] accounts = excludedAccountList.Split(',');

            for (int i = 0; i < accounts.Length; i++)
            {
                CurrentAccountProductHoldings currentAccountProductHoldings = new CurrentAccountProductHoldings();
                currentAccountProductHoldings.CurrentAccountContractCode = accounts[i];
                if (currentAccountProductHoldingList.Contains(currentAccountProductHoldings))
                {
                    currentAccountProductHoldingList.Remove(currentAccountProductHoldings);
                }



            }



            int batchMode = 0;
            DateTime calculationDate = DateTime.Today;
            string inputLogFile = "";
            string outputLogFile = "";

            if (batchMode == 0)
            {
               

                string status = "";
                if (currentAccountProductHoldingList != null)
                {
                    foreach (CurrentAccountProductHoldings currentAccountProductHoldings in currentAccountProductHoldingList)
                    {
                        try
                        {
                            currentAccountProductHoldingServices.CalculateFixedOverdraftFees(calculationDate, currentAccountProductHoldings);
                            status = status + "0";

                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            currentAccountProductHoldingServices.CalculateManagementFees(calculationDate, currentAccountProductHoldings);
                            status = status + "1";
                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            currentAccountProductHoldingServices.CurrentAccountCommitmentFeeCalculation(calculationDate, currentAccountProductHoldings);
                            status = status + "2";
                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            currentAccountProductHoldingServices.CurrentAccountInterestCalculation(calculationDate, currentAccountProductHoldings);
                            status = status + "3";
                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            currentAccountProductHoldingServices.CurrentAccountOverdraftInterestCalculation(calculationDate, currentAccountProductHoldings);
                            status = status + "4";
                        }
                        catch (Exception e)
                        {
                        }

                        //Write Contract code and status code to output log file in format contractcode,statuscode

                        OpenLog();
                        checkPassOrFail(status);
                        ChangeStatus();
                        WriteToLog(codes);
                        CloseLog();
                    }
                }
            }
            else if (batchMode == 1)
            {
                //Analyse the inputlog file and fetch the records for which status code is not success, reexecute the remaining methods for failed contractCode.
                string folderPath = Path.Combine(Environment.CurrentDirectory, "Log Files");
                DirectoryInfo logFolder = new DirectoryInfo(folderPath);
                string filePath = Path.Combine(folderPath, DateTime.Now.ToString("yyyy-MM-dd-hhmmss"));
                string path = filePath+".txt";

                //read path code start

                //DirectoryInfo d = new DirectoryInfo(@"D:\Developement\BatchJob\BatchJob\bin\Debug\Log Files");//Assuming Test is your Folder
                //FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                //foreach (FileInfo file in Files)
                //{
                //    //string str = str + ", " + file.Name;
                //    //Console.WriteLine(str);
                //}
                //read patch code end

                // Open the file to read from. 
                string[] readText = File.ReadAllLines(path);
                //Console.WriteLine(readText[0]);



                //for (int i = 0; i < (readText[0].Length); i++)
                //{
                for (int i = 0; i < readText.Length; i++)
                {
                    var values = readText[i].Split(',');


                    string contractCode = values[0];
                    string status = values[1];
                    string passOrFail = values[2];
                    currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
                    CurrentAccountProductHoldings currentAccountProductHoldings = currentAccountProductHoldingServices.FetchProduct(contractCode);
                    if (passOrFail == "0")
                    {
                        

                        try
                        {
                            if (!status.Contains("0"))
                            {
                                currentAccountProductHoldingServices.CalculateFixedOverdraftFees(calculationDate, currentAccountProductHoldings);
                                status = status + "0";
                            }

                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            if (!status.Contains("1"))
                            {
                                currentAccountProductHoldingServices.CalculateManagementFees(calculationDate, currentAccountProductHoldings);
                                status = status + "1";
                            }
                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            if (!status.Contains("2"))
                            {
                                currentAccountProductHoldingServices.CurrentAccountCommitmentFeeCalculation(calculationDate, currentAccountProductHoldings);
                                status = status + "2";
                            }
                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            if (!status.Contains("3"))
                            {
                                currentAccountProductHoldingServices.CurrentAccountInterestCalculation(calculationDate, currentAccountProductHoldings);
                                status = status + "3";
                            }
                        }
                        catch (Exception e)
                        {
                        }

                        try
                        {
                            if (!status.Contains("4"))
                            {
                                currentAccountProductHoldingServices.CurrentAccountOverdraftInterestCalculation(calculationDate, currentAccountProductHoldings);
                                status = status + "4";
                            }
                        }
                        catch (Exception e)
                        {
                        }

                        //Write Contract code and status code to a output log file in format contractcode,statuscode
                        OpenLog();
                        checkPassOrFail(status);
                        ChangeStatus();
                        WriteToLog(codes);
                        CloseLog();
                    }
                }
            }
            
            }

            //Logic for account to be dormant have to be written here
            //If there are no activities recorded that are initiated by the customer for 2 years, 
            //we will classify the account as dormant. Interest or management fees automatically posted 
            //should not be taken into consideration. We will be referring to deposit or transfer out activities initiated by customer.


            static private void OpenLog()
        {
            // Create log folder if it doesn't exist
            string folderPath = Path.Combine(Environment.CurrentDirectory, "Log Files");
            DirectoryInfo logFolder = new DirectoryInfo(folderPath);

            if (!logFolder.Exists)
                logFolder.Create();

            // Clear out old logs
            //string appSetting = ConfigurationManager.AppSettings["DaysToStoreLogFiles"];
            int days = 5;//int.Parse(appSetting);
            TimeSpan span = new TimeSpan(days, 0, 0, 0);

            foreach (FileInfo logFile in logFolder.GetFiles())
            {
                if (logFile.CreationTime < DateTime.Now - span)
                    logFile.Delete();
            }

            // Create new log file
            string filePath = Path.Combine(folderPath, DateTime.Now.ToString("yyyy-MM-dd-hhmmss"));

            if (File.Exists(filePath + ".txt"))
            {
                bool exitApplication = true;
                for (int x = 1; x <= 10; x++)
                {
                    string newPath = filePath + "(" + x.ToString() + ")";

                    if (!File.Exists(newPath + ".txt"))
                    {
                        filePath = newPath;
                        exitApplication = false;
                        break;
                    }
                }

                // If someone has really launched the batch job more than 10 times in 
                // a single second, something is wrong.
                if (exitApplication)
                    Environment.Exit(1);
            }

            LogWriter = File.CreateText(filePath + ".txt");
            //WriteToLog("Begin processing:  " + DateTime.Now.ToString("yyyy-MM-dd-hh:mm:ss"));
            //WriteToLog("-----------------------------------------------------------");
            //WriteToLog("");
        }

        static private void CloseLog()
        {
            //WriteToLog("");
            //WriteToLog("------------------------------------------------------------");
            //WriteToLog("Finish processing:  " + DateTime.Now.ToString("yyyy-MM-dd-hh:mm:ss"));

            LogWriter.Close();
        }

        static private void checkPassOrFail(string statuscode)
        {
            if (statuscode == "01234")
                passOrFail = "1";
            else
                passOrFail = "0";
        }
        static private void WriteToLog(string logEntry)
        {
            LogWriter.WriteLine(logEntry);
        }
        static private void ChangeStatus()
        {
            //statuscode = "Tanvee";
            codes = contractcode + "," + statuscode + "," + passOrFail;
        }

        // Read the file as one string.
       
               
            //}
        }
            
}