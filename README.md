<a name="readme-top"></a>

<!-- TABLE OF CONTENTS -->

# 📗 Table of Contents

- [📖 About the Project](#about-project)
  - [🛠 Built With](#built-with)
    - [Tech Stack](#tech-stack)
    - [Key Features](#key-features)
  <!-- - [🚀 Live Demo](#live-demo) -->
- [💻 Getting Started](#getting-started)
  - [Setup](#setup)
  - [Prerequisites](#prerequisites)
  - [Install](#install)
  - [Usage](#usage)
  - [Run tests](#run-tests)
  <!-- - [Deployment](#triangular_flag_on_post-deployment) -->
- [👥 Authors](#authors)
<!-- - [🔭 Future Features](#future-features) -->
- [🤝 Contributing](#contributing) 
- [⭐️ Show your support](#support)
<!-- - [🙏 Acknowledgements](#acknowledgements) -->
- [❓ FAQ](#faq)
- [📝 License](#license)

<!-- PROJECT DESCRIPTION -->

# 📖 Students Web App <a name="about-project"></a>

**Students Web App** is a Fullstack application that implements an Angular App consumming a Minimal API service to manage the CRUD of a Sqlite database with a Student table.

## 🛠 Built With <a name="built-with">.NET/VS Code</a>

### Tech Stack <a name="tech-stack">Angular + Minimal API</a>

<details>
  <summary>Client</summary>
  <ul>
    <li><a href="https://learn.microsoft.com/en-us/visualstudio/javascript/tutorial-asp-net-core-with-angular?view=vs-2022">ASP.NET Core app with Angular</a></li>
    <li><a href="https://getbootstrap.com/docs/5.2/getting-started/introduction/">Bootstrap</a></li>
    <li><a href="https://angular.io/guide/form-validation">Angular Form Validation</a></li>
  </ul>
  </details>

<details>
  <summary>Server</summary>
  <ul>
    <li><a href="https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0">Minimal API</a></li>
    <li><a href="https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/openapi?view=aspnetcore-7.0">Open API Support(Swagger)</a></li>
    </ul>
</details>

<details>
<summary>Database</summary>
  <ul>
    <li><a href="https://learn.microsoft.com/en-us/ef/core/providers/sqlite/?tabs=dotnet-core-cli">SQLite EF Core Database Provider</a></li>
    <li><a href="https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli">SQLite Scaffolding</a></li>
  </ul>
</details>

<!-- Features -->

### Key Features <a name="key-features"></a>

- **GenericRepository**
- **Dependency Injection**
- **Unit Testing**
- **Git Flow**
- **CORS**

<!-- <p align="right">(<a href="#readme-top">back to top</a>)</p> -->

<!-- LIVE DEMO -->

<!-- ## 🚀 Live Demo <a name="live-demo"></a> -->


<!-- - [Live Demo Link](https://yourdeployedapplicationlink.com) -->

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->

## 💻 Getting Started <a name="getting-started"></a>

To get a local copy up and running, follow these steps.

### Prerequisites

In order to run this project you need:

Option 1: Visual Studio .NET 2022 
1. Open the solution StudentsWebApp.sln
2. Configure Multiple Startup Projects as shown in the image:
[Image Multiple Startup Projects]()
3. Rebuild Solution to assure that all projects are compiling
4. Click Start of F5 

Option 2: Visual Studio Code with extensions:
- C# for Visual Studio Code
- vscode-solution-explorer
1. Open the folder StudentsWebApp containning the solution 
2. Enter `code .` command to open VS Code
3. Open folder \SWA.WebAPIService in Terminal and run `dotnet build` and `dotnet run` commands
4. Open folder \SWA.StudentsApp in Terminal and run `dotnet build` and `dotnet run` commands

Common steps:
5. Api Service and Angular App start simultaneosly
6. Wait until Angular App loads Students data

### Setup

Clone this repository to your desired folder:


Example commands:

  `cd [Desired_Folder]`
  `git clone https://github.com/NeckerFree/StudentsWebApp`
  `cd StudentsWebApp`

### Install

Install this project with:
 
If necessary configure Base API Service URL in 
SWA.StudentsApp\ClientApp\proxy.conf.js 
variable: `target: 'https://localhost:7210/'`

Step 2,3 in Option 1 (VS.NET)
Steps 3,4 in Option 2 (VS Code)

Copy the database to a any different folder of this solution 
- Default folder (C:\Temp\): 
- Config file: SWA.WebAPIService\appsettings.json
- String connection: "StudentsDBConnection": "Data Source=C:\\Temp\\sample_DB.db3"

### Usage

To run the project, execute the following command:

Step 4 in Option 1 (VS.NET)
Steps 3,4 in Option 2 (VS Code)

### Run tests

To run tests, run the following command:

<!--
Example command:

```sh
  bin/rails test test/models/article_test.rb
```
--->

<!-- ### Deployment

You can deploy this project using: -->


<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- AUTHORS -->

## 👥 Authors <a name="authors"></a>

👤 **Elio Cortés**

- GitHub: [@NeckerFree](https://github.com/NeckerFree)
- Twitter: [@ElioCortesM](https://twitter.com/ElioCortesM)
- LinkedIn: [elionelsoncortes](https://www.linkedin.com/in/elionelsoncortes/)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- FUTURE FEATURES -->

<!-- ## 🔭 Future Features <a name="future-features"></a> -->

<!-- - [ ] **[new_feature_1]**
- [ ] **[new_feature_2]**
- [ ] **[new_feature_3]** -->

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTRIBUTING -->

## 🤝 Contributing <a name="contributing"></a>

Contributions, issues, and feature requests are welcome!

Feel free to check the [issues page](../../issues/).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- SUPPORT -->

## ⭐️ Show your support <a name="support"></a>

If you like this project please start my project

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGEMENTS -->
<!-- 
## 🙏 Acknowledgments <a name="acknowledgements"></a>

> Give credit to everyone who inspired your codebase.

I would like to thank... -->

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- FAQ (optional) -->

## ❓ FAQ <a name="faq"></a>

> Add at least 2 questions new developers would ask when they decide to use your project.

- **What commands are required to Scaffold SQLite database?**

  - `dotnet add package Microsoft.EntityFrameworkCore.Design`
  - `dotnet tool install --global dotnet-ef`
  - `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`
  - `dotnet ef dbcontext scaffold "data source=C:\Temp\sample_DB.db3" Microsoft.EntityFrameworkCore.Sqlite --output-dir Models --context-dir Data --namespace SWA.DataAccess.Models --context-namespace SWA.DataAccess.Data --context StudentsContext -f --no-onconfiguring`

- **How can I generate and/or modifies files based on a schematic.**

  - [Angular Generate](https://angular.io/cli/generate)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->

## 📝 License <a name="license"></a>

This project is [MIT](./LICENSE) licensed.

<p align="right">(<a href="#readme-top">back to top</a>)</p>
