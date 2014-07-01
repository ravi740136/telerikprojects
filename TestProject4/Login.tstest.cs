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

namespace TestProject4
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
        

    public class Login : BaseWebAiiTest
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
    
        [CodedStep(@"Enter text 'administrator' in 'TxtUserIDEmail'")]
        public void Login_CodedStep()
        {
            // Enter text 'administrator' in 'TxtUserIDEmail'
            Actions.SetText(Pages.WelcomeToPegaRULES.TxtUserIDEmail, "administrator");
            
        }
    
        [CodedStep(@"Enter text '@pega.com' in 'TxtPasswordPassword'")]
        public void Login_CodedStep1()
        {
            // Enter text '@pega.com' in 'TxtPasswordPassword'
            Actions.SetText(Pages.WelcomeToPegaRULES.TxtPasswordPassword, "@pega.com");
            
        }
    
        [CodedStep(@"Keyboard (KeyPress) - Tab (1 times) on 'TxtPasswordPassword'")]
        public void Login_CodedStep2()
        {
            ActiveBrowser.ContentWindow.SetFocus();
            Pages.WelcomeToPegaRULES.TxtPasswordPassword.ScrollToVisible();
            Pages.WelcomeToPegaRULES.TxtPasswordPassword.Focus();
            ActiveBrowser.Manager.Desktop.KeyBoard.KeyPress(ArtOfTest.WebAii.Win32.KeyBoard.KeysFromString("Tab"), 150, 1);
            ActiveBrowser.WaitUntilReady();
            
        }
    
        [CodedStep(@"Wait '5000' msec for url:'Enter URL in properties'")]
        public void Login_CodedStep3()
        {
            // Wait '5000' msec for url:'Enter URL in properties'
            ActiveBrowser.WaitForUrl("Enter URL in properties", true, 5000);
            
        }
    
        [CodedStep(@"Custom Annotation : <Set text in properties window>")]
        public void Login_CodedStep4()
        {
            // Custom Annotation : <Set text in properties window>
            ActiveBrowser.Annotator.Annotate("<Set text in properties window>", 1000, ArtOfTest.Common.OffsetReference.TopCenter);
            
        }
    }
}
