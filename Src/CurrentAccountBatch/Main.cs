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

namespace CurrentAccountBatch
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            int batchMode = 0;
            DateTime calculationDate = DateTime.Today;
            string inputLogFile = "";
            string outputLogFile = "";

            if(batchMode == 0)
            {
            CurrentAccountProductHoldingServices currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
            List<CurrentAccountProductHoldings> currentAccountProductHoldingList = currentAccountProductHoldingServices.FetchProduct(false);
            
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

                }
            }
            }
            else if(batchMode == 1)
            {
                //Analyse the inputlog file and fetch the records for which status code is not success, reexecute the remaining methods for failed contractCode.
                string contractCode = "";
            CurrentAccountProductHoldingServices currentAccountProductHoldingServices = ServicesProvider.GetInstance().GetCurrentAccountProductHoldingServices();
            CurrentAccountProductHoldings currentAccountProductHoldings = currentAccountProductHoldingServices.FetchProduct(contractCode);
            
            string status = "";
            
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

            }

            //Logic for account to be dormant have to be written here
            //If there are no activities recorded that are initiated by the customer for 2 years, 
            //we will classify the account as dormant. Interest or management fees automatically posted 
            //should not be taken into consideration. We will be referring to deposit or transfer out activities initiated by customer.


        }
    }
}
