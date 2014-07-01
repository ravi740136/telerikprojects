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
        

    public class Create_JNDI_Server : BaseWebAiiTest
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
    
        //[CodedStep(@"Enter text 'as' in 'TxtUserIDEmail' - DataDriven: [$(ORGS)]")]
        //public void ConnectEjbActivity_CodedStep()
        //{
            //// Enter text 'as' in 'TxtUserIDEmail'
            //Actions.SetText(Pages.WelcomeToPegaRULES.TxtUserIDEmail, ((string)("Admin@" + System.Convert.ChangeType(Data["ORGS"], typeof(string)))));
            
        //}
    
        //[CodedStep(@"Enter text 'ra' in 'PyLabelText' - DataDriven: [$(ORGS)]")]
        //public void ConnectEjbActivity_CodedStep1()
        //{
            //// Enter text 'ra' in 'PyLabelText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget0Ifr.PyLabelText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget0Ifr.PyLabelText.Focus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget0Ifr.PyLabelText.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(((string)("JNDI_" + System.Convert.ChangeType(Data["ORGS"], typeof(string)))), 50, 100);
            
        //}
    
        //[CodedStep(@"Enter text 'asd' in 'PyServerNameText' - DataDriven: [$(ORGS)]")]
        //public void ConnectEjbActivity_CodedStep2()
        //{
            //// Enter text 'asd' in 'PyServerNameText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget0Ifr.PyServerNameText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget0Ifr.PyServerNameText.Focus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget0Ifr.PyServerNameText.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(((string)("JNDI_" + System.Convert.ChangeType(Data["ORGS"], typeof(string)))), 50, 100);
            
        //}
    
        //[CodedStep(@"Enter text 'asd' in 'PyLabelText' - DataDriven: [$(ORGS)]")]
        //public void ConnectEjbActivity_CodedStep()
        //{
            //// Enter text 'asd' in 'PyLabelText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget1Ifr.OwnerBrowser.Actions.SetText(Pages.WelcomeToPegaRULES.FramePegaGadget1Ifr.PyLabelText, ((string)("JNDI_" + System.Convert.ChangeType(Data["ORGS"], typeof(string)))));
            
        //}
    
        //[CodedStep(@"Enter text 'JNDI_KinughtAndDayMa' in 'PyLabelText' - DataDriven: [$(ORGS)]")]
        //public void ConnectEjbActivity_CodedStep()
        //{
            //// Enter text 'JNDI_KinughtAndDayMa' in 'PyLabelText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.Focus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(((string)("JNDI_" + System.Convert.ChangeType(Data["ORGS"], typeof(string)))), 50, 100);
            
        //}
    
        //[CodedStep(@"Enter text 'KinughtAndDayMa' in 'PyServerNameText' - DataDriven: [$(ORGS)]")]
        //public void ConnectEjbActivity_CodedStep1()
        //{
            //// Enter text 'KinughtAndDayMa' in 'PyServerNameText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget.OwnerBrowser.Actions.SetText(Pages.WelcomeToPegaRULES.FramePegaGadget.PyServerNameText, ((string)("JNDI_" + System.Convert.ChangeType(Data["ORGS"], typeof(string)))));
            
        //}
    
        //[CodedStep(@"Enter text 'as' in 'PyLabelText' - DataDriven: [$(ORGS)]")]
        //public void ConnectEjbActivity_CodedStep()
        //{
            //// Enter text 'as' in 'PyLabelText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.Focus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["ORGS"], typeof(string)))), 50, 100);
            
        //}
    
        //[CodedStep(@"Enter text 'JndiServer2' in 'PyLabelText' - DataDriven: [$(ORGS)]")]
        //public void Create_JNDI_Server_CodedStep()
        //{
            //// Enter text 'JndiServer2' in 'PyLabelText'
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.Focus();
            //Pages.WelcomeToPegaRULES.FramePegaGadget.PyLabelText.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["ORGS"], typeof(string)))), 50, 100);
            
        //}
    }
}
