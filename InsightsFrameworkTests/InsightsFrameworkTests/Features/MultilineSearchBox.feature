Feature: Multiline Search Box
	In order to be able to search for multiple items 
	As a PAA user
	I should be able to enter multiple input in Filter/Focus/Time controls for Huge and Non Huge Dimensions

@filter_control
Scenario: Search for Huge Dimensions accepts multiline input
	Given I select a huge dimension for filtering
	  And I have entered "multiline input" into the Search bar
	 Then I should see the "multiline input" items in the Search bar

@focus_control
Scenario: Search for Huge Dimensions accepts multiline input
	Given I select a huge dimension for focus
	  And I have entered "multiline input" into the Search bar
	 Then I should see the "multiline input" items in the Search bar

@single_time_control
Scenario: Search for Huge Dimensions accepts multiline input
	Given I select a huge dimension for single-time filtering
	  And I have entered "multiline input" into the Search bar
	 Then I should see the "multiline input" items in the Search bar

@filter_control
Scenario: Search for Non-Huge Dimensions accepts multiline input
	Given I select a non huge dimension for filtering
	  And I have entered "multiline input" into the Search bar
	 Then I should see the "multiline input" items in the Search bar

@focus_control
Scenario: Search for Non-Huge Dimensions accepts multiline input
	Given I select a non huge dimension for focus
	  And I have entered "multiline input" into the Search bar
	 Then I should see the "multiline input" items in the Search bar

@single_time_control
Scenario: Search for Non-Huge Dimensions accepts multiline input
	Given I select a non huge dimension for single-time filtering
	 When I have entered "multiline input" into the Search bar
	 Then I should see the "multiline input" items in the Search bar

Scenario: Clear button available for Non-Huge Dimensions
	Given I search for "multiline input" in a non huge dimension for filtering
	 When I clear the search box using the clear button
	 Then The search box is cleared
	  And The entire dataset is visible

Scenario: Clear button available for Huge Dimensions
	Given I search for "multiline input" in a huge dimension for filtering
	 When I clear the search box using the clear button
	 Then The search box is cleared
	  And The entire dataset is visible

Scenario: Multiline input uses Ctrl+Enter for new line in Huge/Non Huge Dimensions
	Given I search for "single line of input" in huge dimension for filtering
	 When I key in "Ctrl+Enter"
	 Then I should be able to enter data in a newline
	
Scenario: Pressing Enter key when focus is on Search Box causes manual search to be triggered for Huge Dimensions
	Given I search for "multiline input" in huge dimension for filtering
	 When I key in "Enter"
	 Then Nothing happens?

@manual
Scenario: Entering <maximum number of lines allowed> does not crash the control