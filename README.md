### C# App
<h1 align="center">CommercialSales - An eCommerce App
  <a href="https://github.com/QuietEvolver/eCommerce.Solution.git">     
  </a>
</h1>

<p align="center">
  <strong></strong><br>
</p>

<p align="center">

  <a href="https://github.blog/category/community/">
    <img src="https://github.blog/wp-content/uploads/2019/01/Community@2x.png" width=100px alt="GH-Community" />
  </a>
   <a href="https://github.com/arynsh/eCommerce.Solution.git">
    <img src="https://avatars1.githubusercontent.com/u/53847662?s=400&v=4" width=100px alt="arynsh" />
  </a>
  <a href="https://github.com/adilet312/eCommerce.Solution.git">
    <img src="https://avatars2.githubusercontent.com/u/55602501?s=460&v=4" width=100px alt="adilet312" />
  </a>
  <a href="https://github.com/ratta2ii/eCommerce.Solution.git">
    <img src="https://avatars1.githubusercontent.com/u/53847662?s=400&v=4" width=100px alt="ratta2ii" />
  </a>
  <a href="https://github.com/QuietEvolver/eCommerce.Solution.git">
    <img src="https://avatars0.githubusercontent.com/u/34698193?s=40&v=4" width=100px alt="quietevolver" />
  </a>
  <a href="https://github.blog/2016-08-22-publish-your-project-documentation-with-github-pages/">
    <img src="https://raw.githubusercontent.com/github/explore/80688e429a7d4ef2fca1e82350fe8e3517d3494d/collections/github-pages-examples/github-pages-examples.png" width=100px alt="gh-pages" />
  </a>
</p>

<h3 align="center">

  [Epicodus](https://www.epicodus.com/)
  <span> · </span>
  [QE's GH](https://github.com/QuietEvolver/eCommerce.Solution.git)

</h3>

- **Deployed.** a version control system used to implement development workflows; allows code deployment to application from git repositories.
- **GitHub-Pages.** the default publishing source for GitHub Pages site so site will publish automatically.
- **Docs.** See local changes in seconds; Docs (GitHub) Pages helps you share your published work; Create a /docs/index.md file on your repository's master branch.


#### A website for an ecommerce app.

#### By **Sharon Lee, Trevor Mackin, Adilet Momunaliev, and Vera Weikel**
## 🎉 Contents

- [Description](#-description)
- [Specifications](#-specifications)
- [Requirements](#-requirements)
- [Contact](#-contact)
- [License](#-license)

## Description
A website where you can enter an order you've been creating after logging in.

A target customer should be an interested in browsing and/or purchases. Begin by giving it your proper Name.

Application, will have customer client model include individualized properties for their order, size, amout, and so on. App supports front end MVC RESTful Index, New, Create, and Show routes.

### Steps/Use Case:
| Spec | Input | Output |
| :-------------     | :------------ | :------------- |
| **Homepage** | User accesses:http://localhost:5000/| User:Landing Homepage |
| **User enters in an order list customer | I: Get galoshes | None;|
| **User clicks button and order for customer is populated | I: (click button) | O: customer on the list :"Hunter Boots"|

### Specifications

- Clone this repository: https://github.com/QuietEvolver/eCommerce.Solution.git
-  Open the command line--and navigate into the repository.
database Initialization:
- run in terminal: dotnet ef database update If an error occurs prior to GitCommit, the following command reverts the migration:
- dotnet ef migrations remove
- delete contents of Migrations folder
- keep the following files:
--[Timestamp]_Initial.cs
--[Timestamp]_Initial.Designer.cs
--MyContextModelSnapshot.cs
- The replacement code belongs in the last file:
using Microsoft.EntityFrameworkCore.Migrations;
- namespace YourProjectFolderNameHere.Migrations { public partial class Initial : Migration { protected override void Up(MigrationBuilder migrationBuilder) { } protected override void Down(MigrationBuilder migrationBuilder) { } } }
- run in terminal: dotnet ef migrations add Initial After Initial is implemented, run the following to update any made changes:
-  On your browser, open the index.html and enjoy!

## Known Bugs
* No known bugs at this time.

## 📋 Technologies Requirements
 You may use Windows, macOS, or Linux as your development operating system, though building and running apps may be limited.
 Tools used:  
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.Net](https://dotnet.microsoft.com/apps/aspnet)
* Microsoft.NET.Sdk.Web
* Microsoft.NET.Test.Sdk
* [Visual Studio](https://www.visualstudiocommunity.com)
* [GitHub](https://www.github.com)
* HTML
 
### Support and Contact details
| Author | GitHub | Email |
|--------|:------:|:-----:|
| Sharon Lee| [arynsh](https://github.com/arynsh) |  [sharonlee714@gmail.com](mailto:sharonlee714@gmail.com) 
Adilet Momunaliev| [Adilet312](https://github.com/Adilet312) |  [adiletm@hotmail.com](mailto:adiletm@hotmail.com)
Trevor Mackin| [ratta2ii](https://github.com/Ratta2ii) |  [tismetrm@gmail.com](mailto:tismetrm@gmail.com)
Vera Weikel| [quietevolver](https://github.com/quietevolver) |  [quiet.evolver@gmail.com](mailto:quietevolver@gmail.com)

_Please contact with questions and/or comments._

## 📖 Documentation

The full documentation for [GH-Pages](https://github.blog/2016-08-22-publish-your-project-documentation-with-github-pages/)

The source for the Shoppe: eCommerce documentation and website is hosted on a separate repo: [**quietevolver**][repo-website]. The deployed version is at [**quietevolver**](https://quietevolver.github.io/eCommerce.Solution/).

[docs]: https://github.com/QuietEvolver/eCommerce.Solution.git
[repo-website]: https://github.com/QuietEvolver/eCommerce.Solution.git


### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **Sharon Lee, Trevor Mackin, Adilet Momunaliev, and Vera Weikel** 