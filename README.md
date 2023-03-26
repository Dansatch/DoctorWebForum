# DoctorWebForum
This is a website that has been designed to connnect doctors round the world for the purpose of getting guidance from each other.
It has been designed with ASP.NET MVC 5 framework together with various packages such as Entity Framework 6 and .jitbit .NET forum.

In order to run this project on your development device, some steps has to be followed
1. Edit the connection strings on the Web.config files in the root directory and in the ./forum/ directory.
2. Run the update-database command in the package manager console of the root directory to run the required migrations.
3. Run the app on your browser and login with the default admin account with password "Abc123.."
4. Under the administrator panel/Configuration settings:     
--set EnableEmailActivation to false     
--set the AdminUsername to admin           
--set the IntegratedAuthentication to true
 
With every commit the various issues and problems would be solved one at a time.
