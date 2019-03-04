using OpenQA.Selenium;
using System;


namespace TestProject.PageFunctions
{
    public class Navigation : BaseFunctions
    { 
        #region ObjectRepository
        By menu_KiwiSaver
        {
            get
            {
                return By.LinkText("KiwiSaver");
            }
        }
        By btn_KiwiSaverCalculators
        {
            get
            {
                return By.LinkText("KiwiSaver calculators");
            }
        }
        By btn_GetStarted
        {
            get
            {
                return By.LinkText("Click here to get started.");
            }
        }
        By lbl_Calculator
        {
            get
            {
                return By.XPath("//h1[text()='KiwiSaver Retirement Calculator']");
            }
        }
        
        #endregion

        //The below method does the navigation to KiviSaver Retirement Calculation page
       public void navigateToRetirementCalculator()
       {
            try
            {
                mouseOverOnObject(menu_KiwiSaver);
                objectClick(btn_KiwiSaverCalculators);
                objectClick(btn_GetStarted);
                checkIfObjectExists(lbl_Calculator);                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
       }
        
    }
}
