# 761_VEL
The project for VEL@SE761

Project Name: GetSkills

Project Organization:
`GetSkills`
  `App_Data`The data which will be run by this app should be  saved here. Normally, it's database.
  `App_Start`The configurations to start this app should be saved here.
    `BundleConfig.cs`This file defines how to include css and scripts in project as an object.
    `RouteConfig.cs`This file defines how will urls be parsed.
  `Content`The files to modify the content of pages should be saved here. Usually, they are css files.  
  `Controllers`Controller classes which response to clients should be saved here.
    `SuccessStoryController.cs`>The control class of all the pages of success story.
  `fonts`The fonts used in this app should be saved here.
  `Models`Model classes which pull and push data from database should be saved here.
    `Tables`This folder hold all the classes which are transformed from database tables.
    `GetSkills.edmx`This file defines the connection and design of database.
    `Repository.cs`This file defines a generic class to access to table classes.
    `CategoryCheckBoxModel.cs`Data model class for the view of success story, show the check list of all success story category.
    `CourseCheckboxModel.cs`Data model class for the view of success story, show the check list of course.
    `StoryCategoryViewModel.cs`Data model class for the view of success story, show the category list of one success story.
    `StoryCourseViewModel.cs`Data model class for the view of success story, show the course list of one success story.
    `success_story.cs`Data model class for the table (success_story) with additional setting for data validation.
  `Scripts`All the JavaScript files used in this app should be saved here.
  `StaticPages`Static html templates used in this app should be saved here.
  `Views`Dynamic htmls, which also known as views, should be saved here
		`SuccessStory`All the pages of success story is saved in this folder.
			`Create.cshtml`Add page of the success story admin function.
			`Delete.cshtml`Delete page of the success story admin function.
			`Detail.cshtml`Detail page of the success story for client view.
			`Edit.cshtml`Edit page of the success story admin function.
			`Index.cshtml`List page of the success story admin function.
			`List.cshtml`List page of the success story for client view.
		`TeamProfile`All the pages of team profile is saved in this folder.
			`Create.cshtml`Add page of the team profile admin function.
			`Delete.cshtml`Delete page of the team profile admin function.
			`Edit.cshtml`Edit page of the success team profile function.
			`Index.cshtml`List page of the team profile admin function.
			`List.cshtml`List page of the team profile for client view.
	`Global.asax`The entrance of this web app.
  `packages.config`All the plug-in packages this web used are included here.
  `Readme.html`The explaination of the project organization.

`GetSkills.Tests`NUnit Test Project Organization
    `Controllers`Sub folder for NUnit test of controller classes.
				`AccountControllerTest.cs`NUnit test class.
				`HomeControllerTest.cs`NUnit test class.
				`ManageControllerTest.cs`NUnit test class.
				`SuccessStoryControllerTests.cs`NUnit test class for the controller of success story pages.
				`TeamProfilesControllersTest.cs`NUnit test class for the controller of team profile pages.
		`App.config`The configuration file for NUnit test.
