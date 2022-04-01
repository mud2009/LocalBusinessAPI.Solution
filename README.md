# Local Business API

#### API for local businesses

#### By Will Greenberg

## Technologies Used

* HTML
* CSS
* Bootstrap
* C#
* .NET
* SQL
* Entity
* Identity

## Description

This API functions as an archive of local shops and restaurants in Washington, DC.

## Setup/Installation Requirements

* Clone this repository to your desktop.
* Navigate to directory `TreatShop.Solution` in your terminal.
* Add an `appsettings.json` file to the directory `TreatShop`.
* Add the following code to the `appsettings.json` file, with your password in the appropriate location:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=will_greenberg;uid=root;pwd=[YOUR-PASSWORD];"
    }
  }
  ```
* Run `dotnet ef database update --project TreatShop/` to build the database from the Migrations files.
* To run the application, run `dotnet run --project TreatShop/`.
* Navigate to `http://localhost:5000` in your browser.

## Known Bugs

* None so far.

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2022 Will Greenberg