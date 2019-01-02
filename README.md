# Vet-To-Go

While getting my AAS in Computer Programming & Application Development, I created this for my Capstone Project. It's a 'total-solution' desktop application for use in a veterinary office. The application was built using C# & connects to a cloud-hosted Azure database.

It includes various functionalities, including the ability to:

* Create & save customers to the database.
* Search for customers with any combination of first name, last name, or phone number.
* Create, view, & delete notes about customers.
* Create, view, & edit multiple animals for each customer.
* Add notes for each individual animal.
* Create, view, & edit invoices for each customer.

I also added various queries that pull up useful data, such as:

* Email list: A list of all customer emails for use in newsletters.
* Species list: Ability to show all animals of a specified species, with links to their notes & owners.
* Lists of unlicensed or unsterilized animals, optionally filtered by species, with links to their owners.
* List of all unpaid invoices.
* List of visits by calendar date.
* List of all currently active customers.

The code is fully functional; however, due to the Azure database no longer having an active subscription, the data is inaccessible. 
