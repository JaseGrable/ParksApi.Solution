### US Parks API

&nbsp;&nbsp;&nbsp;&nbsp;An API of National and Oregon State parks

&nbsp;&nbsp;&nbsp;&nbsp;_By_ Jase Grable

## **Technologies Used**

- C#
- .NET 6
- Entity Framework Core version 6.0
- EFCore Design
- EFCore Migration
- Razor
- MySql
- Git
- Swagger
- Postman

## **Description**

A Searchable Park Api that contains a list of US National Parks and Oregon State Parks.
Use a tool like Postman or Swagger to access the Api. See below for documentation and endpoints.
<br>

## **Setup/Installation Requirements** &#x1F4BB;

<details>
<summary> Initial Setup </summary>

- Clone this repository to your local machine.
  ```bash
  $ git clone https://github.com/jasegrable/ParksApi
  ```
- Open VS Code (or your IDE of choice).
- Open the top level directory you just cloned.
</details>

<details>
<summary> Database Setup </summary>

- In your ParksApi Directory, create a file with the name `appsettings.json` and copy and past the following code into this file:

  <pre><code>{
      "Logging": {
          "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
          }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;parks_api;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
      }
  }</code></pre>

- Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.
</details>

<details>
<summary> Finish Setup </summary>

- In your terminal:

  Change directory (cd) to ParksApi.

  ```bash
  $ dotnet build
  ```

  ```bash
  $ dotnet ef migrations add Initial
  ```

  ```bash
  $ dotnet ef database update
  ```

  ```bash
  $ dotnet run
  ```

  (or `dotnet watch run` to avoid reloading with edits in real time, and have Swagger open).

- A web page will automatically open in your browser at port 5000 or 5001
</details>

<br>

## API

### Query Parameters

- `parkId`
- `name`
- `state`
- `type` (this is either 'State' or 'National')
- `description`

<br>

### Endpoints

<details>
<summary><span style="color: rgb(3, 132, 252); font-style: italic;">GET</span></summary>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks <br>

- Returns all parks (10 responses per page)
- To edit the amount of objects per page or get a different page use `page` and/or `pageSize`. Example: `http://localhost:5000/api/parks?page=2&pageSize=5`

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks/random <br>

- Returns one Park object at random

#### Query by parameter:

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?name={name} <br>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?state={state} <br>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?type={type} <br>

#### <span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?description={keyword} <br>

Search for parks by name, state, type, and description. The program will search using keyword and return any Park where the keyword is found in the parameter query. <br>For example,<span style="color: rgb(3, 132, 252); font-style: italic;">&nbsp;GET&nbsp;</span> `https://localhost:5001/api/Parks?description=murder` will return the result:

</details>

<details>
<summary><span style="color: green; font-style: italic;">POST</span></summary>
<br>
<span style="color: green; font-style: italic;">POST</span> /api/parks
<br><br>Create a new Park object in the body in JSON format:
<br><br>
**Check for error messages that might fail validation
<br><br>
</details>

<details>
<summary><span style="color: orange; font-style: italic;">PUT</span></summary>
<br>
<span style="color: orange; font-style: italic;">PUT</span> /api/parks/{parkId}
<br><br>

Edit the details of a Park object.
Always signify the `parkId` of the targeted object <br>For example, to edit Park object with `parkId` 1:<br><span style="color: orange; font-style: italic;">&nbsp;PUT&nbsp;</span> `http://localhost:5000/api/parks/1`:

<br><br>

</details>
<details>
<summary><span style="color: red; font-style: italic;">DELETE</span></summary>
<br>
<span style="color: red; font-style: italic;">DELETE</span> /api/parks/{parkId}
<br><br>

Delete a Park object.
Enter the value of the target Park object's `parkId`. For example to delete object with parkId 16:
<br><span style="color: red; font-style: italic;">&nbsp;DELETE&nbsp;</span> `http://localhost:5000/api/parks/16`:
<br><br>

</details>

<br>

## Debugging

<details>
<summary> If the program does not run...</summary>

- Make sure you have the appropriate packages installed to run dotnet

  - In your Terminal, enter the following commands:<br>
    ```bash
    $ dotnet tool install --global dotnet-ef --version 6.0.0
    ```
    ```bash
    $ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
    ```
    ```bash
    $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
    ```
    ```bash
    $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
    ```

- To overwrite a different version of .NET to .NET 6, Try creating a `global.json` file in the Factory dir that contains the following code to override the default version, if your version exceeds .NET 6.0:<br>
  <pre><code>{
      "sdk": {
          "version": "6.0.402"
      }
  }
  </code></pre>

</details>
<details>
<br>
<summary> If 404 Bad Request...</summary>

- Check the error message in response body. Parameters are bound to validation. The error type will tell you if you need to follow a standard.
<br>
</details>

## **Known Bugs**

- This program does not currently use authorization and authentication to access API. Be cautious when using and sharing this program.

<br>

## License

<details>
<summary>Copyright (c) 2023 Jase Grable</summary>
<br>
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

</details>
