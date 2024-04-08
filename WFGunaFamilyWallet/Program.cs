using System;
using System.ComponentModel;
using System.Windows.Forms;
using WFGunaFamilyWallet.ChildForm;
using OfficeOpenXml;
using System.Data.Entity;
using WFGunaFamilyWallet.models;

namespace WFGunaFamilyWallet
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

 

            // Встановлення LicenseContext
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm()); 
            Application.Run(new AddFormUser());
        }
    }
}
