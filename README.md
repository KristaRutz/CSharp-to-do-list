# ToDoList

#### An Errands Organizer, 03.10.2020\_

#### By _**Steven Fleming, Krista Rutz, Andrew Philpott**_

## Description

This application allows you to add and keep track of different errands. Master branch contains webapp and console_app branch contains the console version.

## Specs

- _Spec: Item constructor should be able to make an item._

  - Input: new Item()
  - Output: Item

  - _Spec: An item should be created with a description when a string is passed into the item constructor._

  - Input: new Item("Walk the dog.")
  - Output: Item Description: "Walk the dog."

    - _Spec: Item List should be created with an empty list._

  - Input: No items created
  - Output: returns empty list

  - _Spec: A list of all the items should be maintained._

  - Input: new Item("Walk the dog."), new Item("Go to grocery store")
  - Output: List: Item("Walk the dog."), Item("Go to grocery store")

## Setup/Installation Requirements

- Clone this repository.
- \$dotnet restore in tests
- \$dotnet build in main

## Known Bugs

- No known bugs

## Support and contact details

- Issues or concerns? Contact us at andrewphilpott92@gmail.com

## Technologies Used

- C#
- .NET Core 2.2

### License

Copyright (c) 2020 **_Andrew Philpott, Krista Rutz_**

_This software is licensed under the MIT license._
