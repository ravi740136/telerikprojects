using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace PRPC_Application_Server
{

    //
    // You can add custom execution steps by simply
    // adding a void function and decorating it with the [CodedStep] 
    // attribute to the test method. 
    // Those steps will automatically show up in the test steps on save.
    //
    // The BaseWebAiiTest exposes all key objects that you can use
    // to access the current testcase context. [i.e. ActiveBrowser, Find ..etc]
    //
    // Data driven tests can use the Data[columnIndex] or Data["columnName"] 
    // to access data for a specific data iteration.
    //
    // Example:
    //
    // [CodedStep("MyCustom Step Description")]
    // public void MyCustomStep()
    // {
    //        // Custom code goes here
    //      ActiveBrowser.NavigateTo("http://www.google.com");
    //
    //        // Or
    //        ActiveBrowser.NavigateTo(Data["url"]);
    // }
    //
        

    public class TestLocale : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Enter text 'asd' in 'TxtUserIDEmail' - DataDriven: [$(ORGS)]")]
        public void TestLocale_CodedStep()
        {
            // Enter text 'asd' in 'TxtUserIDEmail'
            Pages.WelcomeToPegaRULES.TxtUserIDEmail.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            ActiveBrowser.Window.SetFocus();
            Pages.WelcomeToPegaRULES.TxtUserIDEmail.Focus();
            Pages.WelcomeToPegaRULES.TxtUserIDEmail.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(((string)("Admin@" + System.Convert.ChangeType(Data["ORGS"], typeof(string)))), 50, 100);
            
        }
    
        //[CodedStep(@"Enter text '' in 'PyLabelText' - DataDriven: [$(Activity_Name)]")]
        //public void TestLocale_CodedStep1()
        //{
            //// Enter text '' in 'PyLabelText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText1.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText1.Focus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText1.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(((string)("Admin@" + System.Convert.ChangeType(Data["Activity_Name"], typeof(string)))), 50, 100);
            
        //}
    
        //[CodedStep(@"Enter text '' in 'PyLabelText1' - DataDriven: [$(Locale_Activity_name)]")]
        //public void TestLocale_CodedStep1()
        //{
            //// Enter text '' in 'PyLabelText1'
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText1.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText1.Focus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText1.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(((string)("Locale_" + System.Convert.ChangeType(Data["Locale_Activity_name"], typeof(string)))), 50, 100);
            
        //}
    }
}
