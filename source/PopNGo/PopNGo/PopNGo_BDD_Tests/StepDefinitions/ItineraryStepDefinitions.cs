using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PopNGo_BDD_Tests.PageObjects;
using Reqnroll;
using OpenQA.Selenium.Edge; // Add this line
using OpenQA.Selenium.Firefox;
using PopNGo_BDD_Tests.Shared; // Add this line


namespace PopNGo_BDD_Tests.StepDefinitions
{
    [Binding]
    public class ItineraryStepDefinitions
    {
        private IWebDriver _driver;
        private ItineraryPage _itineraryPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new FirefoxDriver();
            _itineraryPage = new ItineraryPage(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        [Given("I am on the itinerary page")]
        public void GivenIAmOnTheItineraryPage()
        {
            // Navigate to the itinerary page
            _driver.Navigate().GoToUrl(Common.UrlFor("Itinerary"));
        }

        [Then("I should see a title of “Itinerary“")]
        public void ThenIShouldSeeATitleOfItinerary()
        {
            Assert.IsTrue(_driver.Title.Contains("Itinerary"), "Expected to see a title of 'Itinerary'");
        }

        [Then("I should see a placeholder Title")]
        public bool ThenIShouldSeeAPlaceholderTitle()
        {
            // Implement logic to verify the presence of the placeholder title
            bool isPlaceholderTitleVisible = false;
            // Add logic here to check if the placeholder title is visible
            // For example:
            isPlaceholderTitleVisible = _itineraryPage.IsPlaceholderTitleVisible();

            return isPlaceholderTitleVisible;
        }

        [Then("I can edit the title placeholder")]
        public bool ThenICanEditTheTitle()
        {
            // Implement logic to verify if the title placeholder is editable
            bool isTitleEditable = false;
            // Add logic here to check if the title placeholder is editable
            // For example:
            isTitleEditable = _itineraryPage.IsTitleEditable();

            return isTitleEditable;
        }

        [Then("I should see an expand button right of the title placeholder")]
        public bool ThenIShouldSeeAnExpandButtonRightOfTheTitlePlaceholder()
        {
            // Implement logic to verify if the expand button is visible
            bool isExpandButtonVisible = false;
            // Add logic here to check if the expand button is visible
            // For example:
            isExpandButtonVisible = _itineraryPage.IsExpandButtonVisible();

            return isExpandButtonVisible;
        }

        [When("I select the expand button")]
        public void WhenISelectTheExpandButton()
        {
            _itineraryPage.ClickExpandButton();
        }

        [Then("I should see a section expand below the title")]
        public bool ThenIShouldSeeASectionExpandBelowTheTitle()
        {
            // Implement logic to verify if the section is expanded below the title
            bool isSectionExpanded = false;
            // Add logic here to check if the section is expanded
            // For example:
            isSectionExpanded = _itineraryPage.IsSectionExpanded();

            return isSectionExpanded;
        }

        [Then("I can edit the title and the opened section")]
        public void ThenICanEditTheTitleAndTheOpenedSection()
        {
            // Add logic here to edit the title and the opened section
            // For example:
             _itineraryPage.EditTitle("New Title");
             _itineraryPage.EditOpenedSection("New Section Content");
        }



        //[When("I click on the checklist button")]
        //public void WhenIClickOnTheChecklistButton()
        //{
        //    throw new PendingStepException();
        //}

        //[Then("a checklist section is created")]
        //public void ThenAChecklistSectionIsCreated()
        //{
        //    throw new PendingStepException();
        //}

        //[Then("I can add the title and the items of the checklist.")]
        //public void ThenICanAddTheTitleAndTheItemsOfTheChecklist_()
        //{
        //    throw new PendingStepException();
        //}

        //[When("I add the title and the items of the checklist")]
        //public void WhenIAddTheTitleAndTheItemsOfTheChecklist()
        //{
        //    throw new PendingStepException();
        //}

        //[Then("I can see the changes.")]
        //public void ThenICanSeeTheChanges_()
        //{
        //    throw new PendingStepException();
        //}

        //[When("I delete the checklist section")]
        //public void WhenIDeleteTheChecklistSection()
        //{
        //    throw new PendingStepException();
        //}

        //[Then("I don’t see the checklist section")]
        //public void ThenIDonTSeeTheChecklistSection()
        //{
        //    throw new PendingStepException();
        //}

        //[When("I click the “x” button in the checklist’s items")]
        //public void WhenIClickTheXButtonInTheChecklistSItems()
        //{
        //    throw new PendingStepException();
        //}

        //[Then("I see one less item in the checklist.")]
        //public void ThenISeeOneLessItemInTheChecklist_()
        //{
        //    throw new PendingStepException();
        //}

        [When("I click add items in the checklist section")]
        public void WhenIClickAddItemsInTheChecklistSection()
        {
            // Assuming 'addItemsButton' is the ID for the "Add items" button
            var addButton = _driver.FindElement(By.Id("addNewDayButton"));
            addButton.Click();
        }

        [Then("I see a new day placeholder title.")]
        public void ThenISeeANewItemThatIEntered_()
        {
            // Assuming 'newItemField' is the ID for the input field where new items are shown
            var newItem = _driver.FindElement(By.Id("headingDay2"));
            Assert.IsTrue(newItem.Displayed, "New item is not displayed on the page.");
        }

    }
}
