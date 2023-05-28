Feature: Profile

As a Seller in Mars Application
I want to add, update and delete Certifications in  my Profile Details 
So that
The people seeking for some skills can look into my details.

@tag1
Scenario: Add Certificate with valid details on Profile Page 
	Given I logged into Mars application successfully
	When I add Certficate, Certificatefrom and Year
	Then Certificate record should be successfully added on profile page


