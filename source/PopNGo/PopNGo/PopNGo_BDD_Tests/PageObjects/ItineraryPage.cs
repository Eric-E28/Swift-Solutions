using OpenQA.Selenium;

public class ItineraryPage
{
    private readonly IWebDriver _webDriver;

    public ItineraryPage(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public IWebElement expandBtn => _webDriver.FindElement(By.Id("collapse-section"));
    public void ClickExpandButton()
    {
        expandBtn.Click();
    }
    public bool IsPlaceholderTitleVisible()
    {
        try
        {
            // Find the placeholder title element using the data-placeholder attribute
            IWebElement placeholderTitle = _webDriver.FindElement(By.CssSelector("[data-placeholder='Title']"));

            // Check if the placeholder title element is displayed
            return placeholderTitle.Displayed;
        }
        catch (NoSuchElementException)
        {
            // Placeholder title element not found
            return false;
        }
    }

    public bool IsTitleEditable()
    {
        try
        {
            // Find the input field associated with the title placeholder
            IWebElement titleInputField = _webDriver.FindElement(By.CssSelector("editable-text"));

            // Check if the input field is enabled (editable)
            return titleInputField.Enabled;
        }
        catch (NoSuchElementException)
        {
            // Title input field element not found
            return false;
        }
    }

    public bool IsOpenedSectionVisible()
    {
        try
        {
            IWebElement openedSection = _webDriver.FindElement(By.XPath("//div[@class='panel-body']"));
            return openedSection.Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public bool IsEditableHeaderTitlePresent()
    {
        try
        {
            IWebElement headerTitle = _webDriver.FindElement(By.CssSelector(".editable-header-title"));
            return headerTitle.Enabled;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public bool IsExpandButtonVisible()
    {
        try
        {
            // Find the expand button element
            IWebElement expandButton = _webDriver.FindElement(By.CssSelector(".collapse-section"));

            // Check if the expand button element is displayed
            return expandButton.Displayed;
        }
        catch (NoSuchElementException)
        {
            // Expand button element not found
            return false;
        }
    }

    public bool IsSectionExpanded()
    {
        try
        {
            // Find the expanded section element
            IWebElement expandedSection = _webDriver.FindElement(By.CssSelector(".expanded-section"));

            // Check if the expanded section element is displayed
            return expandedSection.Displayed;
        }
        catch (NoSuchElementException)
        {
            // Expanded section element not found
            return false;
        }
    }

    public void EditTitle(string newTitle)
    {
        try
        {
            // Find the title input field
            IWebElement titleInputField = _webDriver.FindElement(By.CssSelector("[data-placeholder='Title']"));

            // Clear the existing title content
            titleInputField.Clear();

            // Enter the new title content
            titleInputField.SendKeys(newTitle);
        }
        catch (NoSuchElementException ex)
        {
            // Placeholder element not found
            throw new NoSuchElementException("Title input field placeholder element not found", ex);
        }
    }

    public void EditOpenedSection(string newSectionContent)
    {
        try
        {
            // Find the opened section element
            IWebElement openedSection = _webDriver.FindElement(By.CssSelector("[data-placeholder='Checklist Header']"));

            // Clear the existing section content
            openedSection.Clear();

            // Enter the new section content
            openedSection.SendKeys(newSectionContent);
        }
        catch (NoSuchElementException ex)
        {
            // Placeholder element not found
            throw new NoSuchElementException("Opened section placeholder element not found", ex);
        }
    }
}