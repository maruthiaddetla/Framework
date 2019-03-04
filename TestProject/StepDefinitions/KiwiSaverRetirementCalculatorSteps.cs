using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestProject.PageFunctions;

namespace TestProject.StepDefinitions
{
    [Binding]
   public class KiwiSaverRetirementCalculatorSteps
    {  
        Navigation navigationPg = new Navigation();
        RetirementCalculatorPage retirementCalculatorPg = new RetirementCalculatorPage();
              

        [Given(@"I have launched the application")]
        public void GivenIHaveLaunchedTheApplication()
        {            
            navigationPg.LaunchApplication();
        }

        [When(@"I navigate to '(.*)' page")]
        public void WhenINavigateToPage(string p0)
        {
            navigationPg.navigateToRetirementCalculator();
        }

        [Then(@"I should see information icon present for all fields in the calculator")]
        public void ThenIShouldSeeInformationIconPresentForAllFieldsInTheCalculator()
        {
            retirementCalculatorPg.verifyMessageIsDispalyedByClickingInfoIconForAllFields();
        }
        [When(@"I enter (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*) and (.*)")]
        public void WhenIEnterEmployedAndHigh(string currentAge, string empStatus, string salary,string kiviSaverContribution,string PIR,string currentBalance,string voluntarycontribution,string frequency,string risk,string savings)
        {
            retirementCalculatorPg.enterValuesinRetirementCalculator(currentAge, empStatus, salary, kiviSaverContribution, PIR, currentBalance, voluntarycontribution,frequency, risk, savings);
        }

        [When(@"I click View Projections button")]
        public void WhenIClickViewProjectionsButton()
        {
            retirementCalculatorPg.clickonViewProjectionsButton();
        }
        
        [Then(@"I should able to calculate my projected balance at retirement")]
        public void ThenIShouldAbleToCalculateMyProjectedBalanceAtRetirement()
        {
            retirementCalculatorPg.verifyProjectedBalanceAtRetirement();
        }

    }
}
