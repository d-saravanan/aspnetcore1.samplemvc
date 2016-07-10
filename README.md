Getting Started with ASP.Net Core 1.0

Today, I got started with the asp.net core 1.0. I have been using the .net version 4.6.1. Since, the official release is out, I thought that it may help me in learning and getting accustomed to this model so that I can migrate the code that I work day in and day out to reflect the latest

The following are the steps that I did

1. Downloaded the asp.net core 1.0 for windows [Not visual studio one, though I have VS 2015]
2. Installed the Visual Studio Code
3. created a new folder as per mentioned in the microsoft document 
	mkdir aspnetcore
	cd aspnetcore
	dotnet new
	
4. The step3 was completed with a couple of files like project.json and program.cs etc
5. I added the Kestrel Web Server and then registered the same in json file
	"Microsoft.AspNetCore.Server.Kestrel": "1.0.0",
6. I created a new dummy middleware to test out the OWIN pipeline
	app.Run(context =>
	{
		return context.Response.WriteAsync("Hello from ASP.NET Core!");
	});
	
7. now i called dotnet build from the same command prompt
8. Then, I need to call dotnet run so that the source code is built and run in a port, typically port # 5000.
9. Things went well. I thought, it was enough for a hello world
10. I had to really create a WebApi and test. I created a new Folder for storing the models, controllers
11. Once the code for the above are done, I am still using VSCode, as expected, there will be build errors when running "dotnet build"
12. I had to add MVC somehow to the project, I guessed it should be within the project.json file, so googled and added 
	"Microsoft.AspNetCore.Mvc":"1.0.0"
13. Then it seemed that I had to add MVC to the request pipeline so that I can access the above built in Api
14. I tried app.UseMvc() within startup > Configuration as I usually do in the previous versions [No googling done so far]
15. I got the message that AddMvc should be within ConfigureServices and as part of the IServiceCollection
16. Added that and the routes as well
17. Built and ran the app, viola, things were working fine!!!

Got a good start with ASP.Net Core 1.0
