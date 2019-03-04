using OpenQA.Selenium;
using System;

namespace TestProject.PageFunctions
{
    public class RetirementCalculatorPage : BaseFunctions
    {
        #region ObjectRepository
        
        By iFrame
        {
            get
            {
                return By.XPath("//*[@id='calculator-embed']/iframe");
            }
        }
        By icon_CurrentAge
        {
            get
            {
                return By.XPath("//div[@label='Current age']//button");
            }
        }
        By icon_EmpStatus
        {
            get
            {
                return By.XPath("//div[@help-id='EmploymentStatus']//button");
            }
        }
        By icon_PIR
        {
            get
            {
                return By.XPath("//div[@help-id='PIRRate']//button");
            }
        }
        By icon_CurrentBalance
        {
            get
            {
                return By.XPath("//div[@help-id='KiwiSaverBalance']//button");
            }
        }
        By icon_VoluntaryContributions
        {
            get
            {
                return By.XPath("//div[@help-id='VoluntaryContributions']//button");
            }
        }
        By icon_RiskProfile
        {
            get
            {
                return By.XPath("//div[@help-id='RiskProfile']//button");
            }
        }
        By icon_SavingsGoal
        {
            get
            {
                return By.XPath("//div[@help-id='SavingsGoal']//button");
            }
        }
        By msg_CurrentAge
        {
            get
            {
                return By.XPath("//p[contains(text(),'This calculator has an age limit of 64 years')]");
            }
        }
        By msg_EmpStatus
        {
            get
            {
                return By.XPath("//p[contains(text(),'If you are earning a salary or wage')]");
            }
        }
        By msg_PIR
        {
            get
            {
                return By.XPath("//p[contains(text(),'This is your prescribed investor rate (PIR)')]");
            }
        }
        By msg_CurrentBalance
        {
            get
            {
                return By.XPath("//p[contains(text(),'If you do not have a KiwiSaver account,')]");
            }
        }
        By msg_VoluntaryContributions
        {
            get
            {
                return By.XPath("//p[contains(text(),'you can make direct contributions to your KiwiSaver account')]");
            }
        }   
        By msg_RiskProfile
        {
            get
            {
                return By.XPath("//p[contains(text(),'The risk profile affects your potential investment returns:')]");
            }
        }
        By msg_SavingsGoal
        {
            get
            {
                return By.XPath("//p[contains(text(),'Enter the amount you would like to have saved')]");
            }
        }
        By btn_ViewProjections
        {
            get
            {
                return By.XPath("//button[@ng-click='ctrl.showResultsPanel()']");
            }
        }
        By txt_CurrentAge
        {
            get
            {
                return By.XPath("//div[@label='Current age']//input");
            }
        }
        By txt_EmpStatus
        {
            get
            {
                return By.XPath("//div[@label='Employment status']//span[text()='Select']");
            }
        }
        By txt_Employed
        {
            get
            {
                return By.XPath("//span[text()='Employed']");
            }
        }
        By txt_Salary
        {
            get
            {
                return By.XPath("//div[@help-id='AnnualIncome']//input");
            }
        }        
        By txt_SelfEmployed
        {
            get
            {
                return By.XPath("//span[text()='Self-employed']");
            }
        }
        By txt_NotEmployed
        {
            get
            {
                return By.XPath("//span[text()='Not employed']");
            }
        }
        By txt_PIR
        {
            get
            {
                return By.XPath("//div[@help-id='PIRRate']//span[text()='Select']");
            }
        }
        By txt_PIR1
        {
            get
            {
                return By.XPath("//span[text()='10.5%']");
            }
        }
        By txt_PIR2
        {
            get
            {
                return By.XPath("//span[text()='17.5%']");
            }
        }
        By txt_PIR3
        {
            get
            {
                return By.XPath("//span[text()='28%']");
            }
        }
        By txt_MediumRisk
        {
            get
            {
                return By.XPath("//input[@id='radio-option-01Y']");
            }
        }
        By txt_HighRisk
        {
            get
            {
                return By.XPath("//input[@id='radio-option-021']");
            }
        }
        By txt_CurrentBalance   
        {
            get
            {
                return By.XPath("//div[@label='Current KiwiSaver balance']//input");
            }
        }
        By txt_Contributions
        {
            get
            {
                return By.XPath("//div[@label='Voluntary contributions']//input");
            }
        }
        By txt_Frequency
        {
            get
            {
                return By.XPath("//span[text()='Frequency']");
            }
        }
        By txt_Fortnightly
        {
            get
            {
                return By.XPath("//span[text()='Fortnightly']");
            }
        }
        By txt_Annually
        {
            get
            {
                return By.XPath("//span[text()='Annually']");
            }
        }
        By txt_SavingsGoal
        {
            get
            {
                return By.XPath("//div[@label='Savings goal at retirement']//input");
            }
        }
        By msg_ProjectedBalance
        {
            get
            {
                return By.XPath("//span[contains(text(),'At age 65, your KiwiSaver balance is estimated to be:')]");
            }
        }
        By rdb_KiviSaverContribution3
        {
            get
            {
                return By.XPath("//input[@value='3']");
            }
        }
        By rdb_KiviSaverContribution4
        {
            get
            {
                return By.XPath("//input[@value='4']");
            }
        }
        By rdb_KiviSaverContribution8
        {
            get
            {
                return By.XPath("//input[@value='8']");
            }
        }

        #endregion
        //The below method clicks on the info incon for all fields and validated the message
        public void verifyMessageIsDispalyedByClickingInfoIconForAllFields()
        {
            try
            {
                switchToiFrame();
                objectClick(icon_CurrentAge);
                checkIfObjectExists(msg_CurrentAge);                
                objectClick(icon_EmpStatus);
                checkIfObjectExists(msg_EmpStatus);                
                objectClick(icon_PIR);
                checkIfObjectExists(msg_PIR);                
                objectClick(icon_CurrentBalance);
                checkIfObjectExists(msg_CurrentBalance);                
                objectClick(icon_VoluntaryContributions);
                checkIfObjectExists(msg_VoluntaryContributions);                
                objectClick(icon_RiskProfile);
                checkIfObjectExists(msg_RiskProfile);                
                objectClick(icon_SavingsGoal);
                checkIfObjectExists(msg_SavingsGoal);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        
        //The below method will enter the values into Retirement Calculator screen
        public void enterValuesinRetirementCalculator(string currentAge, string empStatus, string salary, string kiviSaverContribution, string PIR, string currentBalance, string voluntarycontribution, string frequency, string risk, string savings)
        {
            try
            {
                switchToiFrame();
                enterValueInTextField(txt_CurrentAge, currentAge);
                objectClick(txt_EmpStatus);
                switch(empStatus.ToLower().Trim())
                {
                    case "employed": objectClick(txt_Employed);
                        break;
                    case "self-employed":
                        objectClick(txt_SelfEmployed);
                        break;
                    case "not employed":
                        objectClick(txt_NotEmployed);
                        break;
                }
                if(empStatus.ToLower().Trim().Equals("employed"))
                {
                    enterValueInTextField(txt_Salary, salary);
                    switch (kiviSaverContribution.Trim())
                    {
                        case "3":
                            objectClick(rdb_KiviSaverContribution3);
                            break;
                        case "4":
                            objectClick(rdb_KiviSaverContribution4);
                            break;
                        case "8":
                            objectClick(rdb_KiviSaverContribution8);
                            break;
                    }
                }
                objectClick(txt_PIR);
                switch (PIR.Trim())
                {
                    case "10.5%": objectClick(txt_PIR1);
                        break;
                    case "17.5%": objectClick(txt_PIR2);
                        break;
                    case "28%":   objectClick(txt_PIR3);
                        break;
                }
                enterValueInTextField(txt_CurrentBalance, currentBalance);
                enterValueInTextField(txt_Contributions, voluntarycontribution);
                if(frequency!="")
                {
                    objectClick(txt_Frequency);
                    switch (frequency.Trim().ToLower())
                    {
                        case "fortnightly":
                            objectClick(txt_Fortnightly);
                            break;
                        case "annually":
                            objectClick(txt_Annually);
                            break;
                    }
                }
                switch (risk.Trim().ToLower())
                {
                    case "medium":
                        objectClick(txt_MediumRisk);
                        break;
                    case "high":
                        objectClick(txt_HighRisk);
                        break;
                }                
                enterValueInTextField(txt_SavingsGoal, savings);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //The below method will click on View Projections button
        public void clickonViewProjectionsButton()
        {
            try
            {
                checkIfObjectExists(btn_ViewProjections);
                objectClick(btn_ViewProjections);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //The below method will verify the Projected Balance
        public void verifyProjectedBalanceAtRetirement()
        {
            try
            {
                checkIfObjectExists(msg_ProjectedBalance);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
