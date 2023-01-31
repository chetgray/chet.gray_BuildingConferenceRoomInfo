BuildingConferenceRoomInfo
==========================

User Story #211912: MVC: Update "Building and Conference Room
Information" Site to add Data Access
------------------------------------

> Update our Building and Conference Room Information app (US 211908,
> 211909, 211910, 211911) to talk to a database.
>
> - [ ] Within the database, create:
>   - [x] New table:  BuildingInformation
>     - [x] Id
>     - [x] Building Name
>     - [x] Building Address - Street
>     - [x] Build Address - City
>     - [x] Building Address - State
>     - [x] Building Address - Zip
>     - [x] Building Address - Country
>     - [x] Build Main Phone Number
>     - [x] Number of Floors
>     - [x] Number of Conference Rooms
>   - [x] New Table:  ConferenceRoomInformation
>     - [x] Id
>     - [x] Conference Room Name
>     - [x] Conference Room Building
>     - [x] Conference Room Phone Number
>     - [x] Conference Room - A/V Capable (true / false)
>     - [x] Conference Room Capacity
>   - [ ] New Stored Procedure:  Get all Building Information
>   - [ ] New Stored Procedure:  Get all Conference Room Information
> - [ ] Create SQL to INSERT new data into both tables.  Let's have at
>   least 5 buildings and at least 20 conference rooms.
> - [ ] Change the app to add Data Access as we discussed.
>   - [ ] You'll want to have a new class library with a DataAccess
>     namespace, a Repository namespace, and a DTOs namespace.
> - [ ] Update the functionality of your app as follows:
>   - [ ] When the user clicks the "Building Information" link, show
>     them the View with all of the building information - but no longer
>     get it from hardcode - get it from the database.
>   - [ ] When the user clicks the "Conference RoomInformation" link,
>     show them the View with all of the conference room information -
>     but no longer get it from hardcode - get it from the database.

User Story #211911: MVC: Update "Building and Conference Room
Information" Site to add Business Logic
---------------------------------------

> Update your "Building and Conference Room Information" application (US
> 211908, 211909, 211910) to:
>
> - [x] For Buildings, we want to know if the building is considered a
>   campus or a satellite office (let's call this the building
>   classification). We also want to know if the building is considered
>   standard or a tower (we can call this our building type). Show both
>   of these determinations in the success message on the data entry
>   page.
>   - [x] After the user enters building information, call a Business
>     Logic method to determine whether it's a campus or a satellite
>     office. Here are the requirements:
>     - [x] A campus is located in Louisville.
>     - [x] A satellite office is located anywhere else.
>   - [x] Also call a Business Logic method to determine whether the
>     building is standard or a tower. Here are the requirements:
>     - [x] A building with more than 5 floors is considered a tower.
>     - [x] A building with 5 or fewer floors is considered standard.
> - [x] For Conference Rooms, we want to know if a newly added room is
>   considered small, medium, or large.
>   - [x] After a user enters conference room information, call a
>     Business Logic method to determine the room size. Show the size
>     along with the success message on the data entry page.
>   - [x] Here are the requirements:
>     - [x] Small: 10 or fewer people capacity
>     - [x] Medium: Between 11 and 20 people capacity
>     - [x] Large: More than 20 people capacity

User Story #211910: MVC: Update "Building and Conference Room
Information" Site to add better routing
---------------------------------------

> Update your "Building and Conference Room Information" application (US
> 211908 and 211909) to:
>
> - [x] For each of your new data entry pages, instead of routing to a
>   new page, route back to the same page.
> - [x] Add validation to the "Enter New Building Information" page as
>   follows:
>   - [x] The user must enter all fields.
> - [x] Add validation to the "Enter New Conference Room Information"
>   page as follows:
>   - [x] The user must enter all fields.
> - [x] On each page, after the user submits the form, take them back to
>   the same page.
> - [x] If the entry was successful - i.e. they entered all the needed
>   fields - send a message stating so.
>   - [x] The message should include the Building Name and City for the
>     "Enter New Building Information" page.
>   - [x] The message should include the Room Name and Room Building for
>     the "Enter New Conference Room Information" page.
> - [x] If the entry was not successful - i.e. the user did not enter
>   all the required fields - send a message stating so.
>   - [x] The message should list the required fields.
>     - [x] Bonus points if you can list ONLY the fields that had a
>       problem!
> - [x] Be sure to use a domain model and multiple View Models!

User Story #211909: MVC: Update "Building and Conference Room
Information" Site to add Data Entry
-----------------------------------

> Update your "Building and Conference Room Information" application (US
> 211908) to add new data entry pages:
>
> - [x] One page will allow the user to "Enter New Building
>   Information." It should allow the user to enter all the building
>   fields.
> - [x] One page will allow the user to "Enter New Conference Room
>   Information." It should allow the user to enter all the conference
>   room fields.
> - [x] These 2 data entry pages should each have a link from the
>   Welcome page.
> - [x] Upon submission of the "Enter New Building Information" page,
>   take the user to a new page where you'll simply display "Building
>   Information Entry Successful!"
> - [x] Upon submission of the "Enter New Conference Room Information"
>   page, take the user to a new page where you'll simply display
>   "Conference Room Information Entry Successful!"
> - [x] Don't worry about validation for now (don't worry -we will
>   later!)

User Story #211908: MVC: Building and Conference Room Information Site
----------------------------------------------------------------------

> Create a basic MVC web application that will allow you to get
> experience with the basics of routing and the key components of MVC.
> This will be a Building and Conference Room Information application.
> The application's purpose is to show information about a company's
> buildings and their conference rooms. Here are the details:
>
> - [x] The application should have a Welcome page with links to
>   "Building Information" and "Conference Room Information".
> - [x] If the user clicks on the "Building Information" link, it should
>   take them to the "Building Information" page.
> - [x] If they click on the "Conference Room Information" link, it
>   should take them to the "Conference Room Information" page.
> - [x] You should have a Building Information Model with the following
>   information:
>   - [x] Building ID
>   - [x] Building Name
>   - [x] Building Address - Street
>   - [x] Build Address - City
>   - [x] Building Address - State
>   - [x] Building Address - Zip
>   - [x] Building Address - Country
>   - [x] Build Main Phone Number
>   - [x] Number of Floors
>   - [x] Number of Conference Rooms
> - [x] You should also have a Building Information ViewModel.
> - [x] You should have a Conference Room Information Model with the
>   following information:
>   - [x] Conference Room ID
>   - [x] Conference Room Name
>   - [x] Conference Room Building
>   - [x] Conference Room Phone Number
>   - [x] Conference Room - A/V Capable (true / false)
>   - [x] Conference Room Capacity
> - [x] You should also have a Conference Room Information ViewModel.
> - [x] When the user clicks the "Building Information" link, load up
>   the Building Information Model with 5 buildings.
>   - [x] Use the Waystar offices at this link for the building info.
>   Load all except the Boston office (that closed) - you can make up
>   the zip, phone, number of floors, and number of conference rooms:
>   <https://craft.co/waystar/locations>
> - [x] After loading the `Model` and converting to the `ViewModel`,
>   take the user to the Building Information page and show the 5
>   buildings and their information in list form.
> - [x] The list should not be editable nor delete-able.
> - [x] When the user clicks the "Conference Room Information" link,
>   load up the Conference Room Information Model with 20 conference
>   rooms.
>   - [x] You can just make this stuff up, but please DO put the Waystar
>   buildings in your `RoomBuilding` fields!
> - [x] After loading the `Model` and converting to the `ViewModel`,
>   take the user to the Conference Room Information page and show the
>   20 conference rooms and their information in list form.
> - [x] The list should not be editable nor delete-able.
>
> NOTE: Any direct links must be done the MVC way, with
> `@html.ActionLink`, NOT the `<a href=>` HTML way.
