Feature: Soft Delete Analysis
	In order to phase out analyses that are unused
	As a Solutions Developer
	I want to be able to delete analyses with the option of restoring it even after I upgrade to a later version of IF. 

	Background: 
	Given a developer "John The IF user" with a dataset "Umbrella Corp" with profile "Development"

	@landing_page
	Scenario: Developer looks for the page pointing to the deleted page definition in Insights Framework
		When I navigate to "Analytics->Showcase->Pages->Decommissioned Landing Page" Landing Page
		Then I should not see the "Orphan" page 

	@landing_page_definitions
	Scenario: John the IF User looks for the soft deleted Landing page in Publisher Definitions
		 When I visit the Landing page "Definitions"
		  And I enable "Show Deleted Items"
		 Then I should see the "ToBeDeleted" landing page with a strikethrough 
		 		 	
	@landing_page_definitions
	Scenario: John the IF User interacts with the soft deleted Landing page in Publisher Definitions
		When I visit the Landing page "Definitions" and I enable "Show Deleted Items"
		  And I hover over the "ToBeDeleted" landing page
		 Then I should see the option "Undelete"
	
	@landing_page_builder
	Scenario: John the IF User looks for the soft deleted Landing page in Publisher Landing Page Builder
		When I visit the Landing page builder for the "Decommssioned" section of the "Playground" landing page
		 Then I should see the "ToBeDeleted" landing page with a strikethrough
		  And The state of the "ToBeDeleted" page should be "On"

	@landing_page_builder
	Scenario: John the IF User interacts with the soft deleted Landing page in Publisher Landing Page Builder
		When I visit the Landing page builder for the "Decommssioned" section of the "Playground" landing page
		  And I hover over the "ToBeDeleted" landing page 
		 Then I should see a tooltip with the message "The page definition linked to this page has been decommissioned."

	@landing_page_builder
	Scenario: John the IF User selects the soft deleted Landing page in Publisher Landing Page Builder
		When I visit the Landing page builder for the "Decommssioned" section of the "Playground" landing page
		  And I select the "ToBeDeleted" landing page 
		 Then the "ToBeDeleted" page definition in the page detail dropdown is prefixed with "Decommissioned"
		 		
	@landing_page_configurator
	Scenario: John the IF User looks for the soft deleted Landing page in Publisher Landing Page Configurator
		When I visit the Landing page configurator for the "Playground" landing page with "Umbrella" Dataset and "Developer" profile
		 Then I should see the "ToBeDeleted" landing page with a strikethrough 
		  And The state of the "ToBeDeleted" page should be "On"
	
	@story_board, @usage_analytics
	Scenario: John the IF User opens and edits the page pointing to the deleted page definition in the stale Story Board
		When I open and edit the "Stale" analysis in the "Decommissioned" folder
		 Then I should see an ok alert titled "Discontinued analysis" with the message "This analysis has been discontinued and cannot be edited.  Contact support for more information"
		  And "OpenAndEditDecommissionedAnalysis" event is raised in Usage Analytics

	@story_board, @usage_analytics
	Scenario: John the IF User refreshes the page pointing to the deleted page definition in the stale Story Board
		When I refresh the "Orphan" page of the "Stale" analysis in the "Decommissioned" folder
		 Then I should see an ok alert titled "Discontinued analysis" with the message "This analysis has been discontinued and cannot be refreshed.  Contact support for more information"
		  And The storyboard is marked out of sync with a decommissioned watermark on the thumbnail
		  And "RefreshDecommissionedAnalysis" event is raised in Usage Analytics

	@story_board
	Scenario: John the IF User refreshes all pages in the stale Story Board
		When I refresh the "Stale" analysis in the "Decommissioned" folder
		 Then I should see an Yes/No alert titled "Discontinued analysis" with the message "Following analysis are decommissioned. Would you like to continue refreshing the remaining analysis..."
		  And The storyboard is marked out of sync with a decommissioned watermark on the thumbnail

	@story_board
	Scenario: John the IF User slideviews the stale Story Board
		When I slideview the "Stale" analysis in the "Decommissioned" folder
		 Then I should see the storyboard slideview with no decommissioned watermark 

	@migration_tool
	Scenario: Migration tool scenarios need to be fleshed out.
		

