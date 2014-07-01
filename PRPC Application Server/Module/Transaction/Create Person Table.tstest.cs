using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using CustomFunc;
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
        

    public class Create_Person_Table : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;
        
        public String appWork;

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
    
        //[CodedStep(@"New Coded Step")]
        //public void Create_DataTable_CodedStep()
        //{
            
        //}
    
        //[CodedStep(@"New Coded Step")]
        //public void Create_DataTable_CodedStep()
        //{
            
            //appWork= GetExtractedValue("ScruCoreEngiLink").ToString();
            //Log.WriteLine(appWork);
           //String Path=this.ExecutionContext.DeploymentDirectory+"\\Data\\AppWork.txt";
           //Func.DataToTxt(Path,appWork);
        //}
    
        //[CodedStep(@"Enter text 'testtest' in 'PySearchTextText'")]
        //public void Create_DataTable_CodedStep1()
        //{
            //// Enter text 'testtest' in 'PySearchTextText'
            //String appName = Func.DataFromTxt(this.ExecutionContext.DeploymentDirectory+"\\Data\\AppWork.txt");
            //Pages.PegaDesignerStudio.PySearchTextText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            //ActiveBrowser.Window.SetFocus();
            //Pages.PegaDesignerStudio.PySearchTextText.Focus();
            //Pages.PegaDesignerStudio.PySearchTextText.MouseClick();
            //Manager.Desktop.KeyBoard.TypeText(appName, 150, 150);
            
        //}
    
        [CodedStep(@"New Coded Step")]
        public void Create_DataTable_CodedStep()
        {
            String appName = GetExtractedValue("ScruCoreEngiLink").ToString();
            Log.WriteLine(appName);
            String Path=this.ExecutionContext.DeploymentDirectory+"\\Data\\AppName.txt";
           Func.DataToTxt(Path,appName);
        }
    
        [CodedStep(@"Enter text '' in 'PyDerivesFromText'")]
        public void Create_DataTable_CodedStep1()
        {
            // Enter text '' in 'PyDerivesFromText'
            String deriveFrom=Func.DataFromTxt(this.ExecutionContext.DeploymentDirectory+"\\Data\\AppName.txt");
            Pages.Http101501111.FrameEditor.PyDerivesFromText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
            ActiveBrowser.Window.SetFocus();
            Pages.Http101501111.FrameEditor.PyDerivesFromText.Focus();
            Pages.Http101501111.FrameEditor.PyDerivesFromText.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(deriveFrom.Replace("Work","Data"), 50, 100);
            
        }
    }
}
