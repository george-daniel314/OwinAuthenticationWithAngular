## OwinAuthenticationWithAngular

This repository helps to create an ASP.NET application with various features like token-based authentication, entity framework, angular etc. There will be different versions for adding the features one by one. You can clone this repository and checkout with the commit branch mentioned here to get its corresponding version.

## Initial template: 

As we are going to begin with token-based authentication, we can start our application by choosing ASP.NET Web Application project from Visual Studio 2017 with framework 4.6.1.  We can make the folder clean with necessary files only by choosing ‘Empty’ project template and check on the ‘Web API’ to get the folders and core reference. We will be having our on option for authentication, so set the authentication option to ‘No Authentication’. And finally, name our project ‘OwinAuthenticationWithAngular.API’.

## Version 1 : b00bd9f28b72694ac167d6a6c04c5bff8c54fac8

This version is a base API project with option for registration. 

# PM commands for references required.

Install-Package Microsoft.AspNet.WebApi.Owin 
Install-Package Microsoft.Owin.Host.SystemWeb 

Install-Package Microsoft.AspNet.Identity.Owin
Install-Package Microsoft.AspNet.Identity.EntityFramework

Finish the rest of code as in the commit version mentioned above to practice the same.

## Version 2 : 419b9e64910738395d061e777121f58e084f649c

This version is to enable token based authentication. As it is an API project, you can debug it with Postman like tool.

# PM commands for references required.

Install-Package Microsoft.Owin.Cors

Finish the rest of code as in the commit version mentioned above to practice the same.

# Postman debugging parameters

URL to get token :- http://localhost:<port>/token
Request Type :- POST
Header :- Content-Type : application/json
Body : (in raw tab) grant_type=password&username=<your username> &password=<your password>
Alternatively the Header and Body send in the below format also.
Header :- Content-Type : application/x-www-form-urlencoded
Body : (in x-www-form-urlencoded tab) add the 3 keys and its values

## Version 3 : bf75fc55e4472b2bc38663b710d64c660694c838

Added web project with angular js

## NOTE: Documentation will be updated soon with detailed code description in each version. But this repository is updated with ready to run code which demonstrates Owin Authentication With Angular. Clone, open with VS 2017, build and hit F5. There you go.!!!
