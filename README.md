*** Project Description ***

The goal of the project is to create a To Do List web application that allows users to manage their personal activities by creating to do lists. The web application should work correctly on a desktop computer and a mobile phone. You may use the domain model from the Week #10 assignment as a starting point for your design. However, this application should be more functional.

You are encouraged to check out this application as an example [https://www.microsoft.com/en-us/microsoft-365/microsoft-to-do-list-app] in order to get a general understanding of the desired result. However, please do not copy the design of the Microsoft application. Try to create your own design and functionality.

To guide you through the process, the project implementation is divided into three stages:

*** Stage 1. Creating an App Prototype ***

The solution should be multi-project containing at least three VS projects:

1. A class library project which contains classes that represent the domain model for the To Do List application.
2. A client ASP.NET Core MVC application that end users can use to interact with the To Do List application.
3. A unit test project that provides unit tests for the To Do List class library.

All the To Do List application data should be stored in the database.
The EF Core or other ORMs to save and read data from the database can be used.
The unit test project and unit tests must be created for the domain model.
You may use this application as your portfolio project, so it is highly recommended to deploy it to the Azure Cloud.

At this stage, you are expected to build the functionalities that will enable your users to:

- view all To Do lists at the application's list view
- create new To Do lists
- add To Do entries (items) to a To Do list
- enter a title, a description, a due date, a creation date to each To Do item
- change To Do items status to: Completed, In Progress, Not Started
- modify a To Do list or a To Do entry

*** Stage 2. Building the Final Version ***

At this stage, you are expected to create the functionalities that will enable your users to:

- store all To Do List application data in a database
- show/hide completed items in a To Do list
- copy the existing To Do list
- remove/hide a list from the application's list view
- add additional fields/notes to To Do items
- hide a To Do list from the list view or remove it completely from the TODO list database
- see the To Do items that are due today
- create a reminder for a To Do item

You are also offered to create your UI design for the web application. Here is a reference UI design: [img/ui-design.PNG]

*** Stage 3. Presenting the Final Solution ***

The next step after you have created the app is preparing its presentation (demo).
As a result, you should have a 15-minute demo video uploaded and shared by the link with your Instructor.

Your demo video will be graded in accordance with the requirements listed below. 

Here is a list of deployment requirements:

- Commit and push your latest working version to GitLab to present the application to your mentor in live mode by sharing your screen. Create a free user account at Microsoft Azure, deploy your project to the MS Azure Cloud, and provide a URL to your mentor (optional).

Before recording the demo:

- Commit and push your latest working version to GitLab to be able to demonstrate the application from your computer.
- Create a release build and share it with your mentor.
Take your time to get ready for making a recording. While creating your demo video, you may show your phone screen or its emulator, prepare slides with screenshots and screencasts of the working application. Please check the plan below to make sure that your video corresponds to the required structure:

Introduction

1. Briefly introduce yourself.

2. Provide a brief description of the application, including:
   - purpose
   - target users
   - major features
   - implemented user stories

Main Part

3. Share the screen:
	- Demonstrate user stories and explain how they were implemented.
	- Describe what was not implemented and what was improved/added.
	- Show the live version in the Azure Cloud if this step was implemented.

4. Explain the application architecture:
	- Explain the solution architecture (the list of components, the purposes of components, technologies used in each component).
	- Elaborate on the major domain logic classes and entities.
	- Explain the structure and the architecture of the data access layer and its classes.
	- Explain the architecture of the user interface and the presentation logic (types, views, controllers, view models, UI design).
	- Demonstrate unit tests if they are implemented.