BuildingConferenceRoomInfo
==========================

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
> - [ ] If the user clicks on the "Building Information" link, it should
>   take them to the "Building Information" page.
> - [ ] If they click on the "Conference Room Information" link, it
>   should take them to the "Conference Room Information" page.
> - [ ] You should have a Building Information Model with the following
>   information:
>   - [ ] Building ID
>   - [ ] Building Name
>   - [ ] Building Address - Street
>   - [ ] Build Address - City
>   - [ ] Building Address - State
>   - [ ] Building Address - Zip
>   - [ ] Building Address - Country
>   - [ ] Build Main Phone Number
>   - [ ] Number of Floors
>   - [ ] Number of Conference Rooms
> - [ ] You should also have a Building Information ViewModel.
> - [ ] You should have a Conference Room Information Model with the
>   following information:
>   - [ ] Conference Room ID
>   - [ ] Conference Room Name
>   - [ ] Conference Room Building
>   - [ ] Conference Room Phone Number
>   - [ ] Conference Room - A/V Capable (true / false)
>   - [ ] Conference Room Capacity
> - [ ] You should also have a Conference Room Information ViewModel.
> - [ ] When the user clicks the "Building Information" link, load up
>   the Building Information Model with 5 buildings.
>   - [ ] Use the Waystar offices at this link for the building info.
>   Load all except the Boston office (that closed) - you can make up
>   the zip, phone, number of floors, and number of conference rooms:
>   <https://craft.co/waystar/locations>
> - [ ] After loading the `Model` and converting to the `ViewModel`,
>   take the user to the Building Information page and show the 5
>   buildings and their information in list form.
> - [ ] The list should not be editable nor delete-able.
> - [ ] When the user clicks the "Conference Room Information" link,
>   load up the Conference Room Information Model with 20 conference
>   rooms.
>   - [ ] You can just make this stuff up, but please DO put the Waystar
>   buildings in your `RoomBuilding` fields!
> - [ ] After loading the `Model` and converting to the `ViewModel`,
>   take the user to the Conference Room Information page and show the
>   20 conference rooms and their information in list form.
> - [ ] The list should not be editable nor delete-able.
>
> NOTE: Any direct links must be done the MVC way, with
> `@html.ActionLink`, NOT the `<a href=>` HTML way.
