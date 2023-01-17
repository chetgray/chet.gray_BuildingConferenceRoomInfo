BuildingConferenceRoomInfo
==========================

User Story #211909: MVC: Update "Building and Conference Room
Information" Site to add Data Entry
-----------------------------------

> Update your "Building and Conference Room Information" application (US
> 211908) to add new data entry pages:
>
> - [x] One page will allow the user to "Enter New Building
>   Information." It should allow the user to enter all the building
>   fields.
> - [ ] One page will allow the user to "Enter New Conference Room
>   Information." It should allow the user to enter all the conference
>   room fields.
> - [ ] These 2 data entry pages should each have a link from the
>   Welcome page.
> - [ ] Upon submission of the "Enter New Building Information" page,
>   take the user to a new page where you'll simply display "Building
>   Information Entry Successful!"
> - [ ] Upon submission of the "Enter New Conference Room Information"
>   page, take the user to a new page where you'll simply display
>   "Conference Room Information Entry Successful!"
> - [ ] Don't worry about validation for now (don't worry -we will
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
