Feature: Itinerary

As a user, I want to manage my itinerary,So that I can plan my activities effectively.

@itinerary
Scenario: View Itinerary Title
    Given I am on the itinerary page
    Then I should see a title of “Itinerary“

@itinerary
Scenario: Edit Itinerary Title placeholder
    Given I am on the itinerary page
    Then I should see a placeholder Title
    And I can edit the title placeholder

@itinerary
Scenario: I can open and edit the checklist section
    Given I am on the itinerary page
	Then I should see an expand button right of the title placeholder
    When I select the expand button
    Then I should see a section expand below the title
    And I can edit the title and the opened section

#@itinerary
#Scenario: Create Checklist Section
#    Given I am on the itinerary page
#    When I click on the checklist button
#    Then a checklist section is created
#    And I can add the title and the items of the checklist.
#
#@itinerary
#Scenario: View Changes in Checklist
#    Given I am on the itinerary page
#    When I add the title and the items of the checklist
#    Then I can see the changes.
#
#@itinerary
#Scenario: Delete Checklist Section
#    Given I am on the itinerary page
#    When I delete the checklist section
#    Then I don’t see the checklist section
#
#Scenario: Remove Checklist Item
#    Given I am on the itinerary page
#    When I click the “x” button in the checklist’s items
#    Then I see one less item in the checklist.
#    
#@itinerary
#Scenario: Add New Item to Checklist
#    Given I am on the itinerary page
#    When I click add items in the checklist section
#    Then I see a new item that I entered.

@itinerary
Scenario: Add New Day Section
    Given I am on the itinerary page
    When I click add items in the checklist section
    Then I see a new day placeholder title.
