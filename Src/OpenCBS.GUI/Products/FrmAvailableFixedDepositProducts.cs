using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Enums;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Services;
using System.Security.Permissions;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.Shared.Settings;
using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Products
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FrmAvailableFixedDepositProducts : Form
    {
        private int _idPackage;
        private LoanProduct _package;
        public FrmAvailableFixedDepositProducts()
        {
            
            InitializeComponent();
            _package = new LoanProduct();
            InitializePackages();
            webBrowserPackage.ObjectForScripting = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int PackageFormId
        {
            set { _idPackage = value; }
            get { return _idPackage; }
        }
        private bool _showDeletedPackage = false;
        private void InitializePackages()
        {
            string templatePath = UserSettings.GetTemplatePath;

            string text = string.Format(
                @"<html>
                  <head>
                  <link href='{0}\cover.css' type='text/css' rel='stylesheet'/>
                  <meta http-equiv='pragma' content='no-cache'/>
                  <title>Covers list</title>
                  </head>
                  <script type='text/javascript' src='{0}\cover.js'></script>
                  <body><h1>Tanuj Agarwal</h1></body></html>", templatePath);

          

            var tempPath = Path.GetTempPath();
            tempPath = Path.Combine(tempPath, "packages_list.html");
            File.WriteAllText(tempPath, text, Encoding.UTF8);

            webBrowserPackage.Url = new Uri(tempPath, UriKind.Absolute);
        }

        private string _CreateHtmlForShowingPackage(LoanProduct pPackage)
        {
           

            return "text";
        }

        private void buttonAddProduct_Click(object sender, System.EventArgs e)
        {
            FrmAddFixedDepositProduct _frmAddFixedDepositProduct = new FrmAddFixedDepositProduct();
            _frmAddFixedDepositProduct.Show();
        }

        private void buttonEditProduct_Click(object sender, System.EventArgs e)
        {
            FrmAddFixedDepositProduct _frmAddFixedDepositProduct = new FrmAddFixedDepositProduct();
            _frmAddFixedDepositProduct.Show();
        }

    }
}
