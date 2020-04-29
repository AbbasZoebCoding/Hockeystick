The Client side code is written in React.js and the Server Side code is written in .NET Core 2.1

Please follow the steps below to setup this project to run:
*Server: Run the HockeyStickWebAPI application in VS 2017 (from the HockeyStickWebAPI folder)
*Make sure your default browser is set to Chrome or FireFox.
*Client: In VS Code, open up the hockeystick project (from the hockeystick folder) (run using "npm start")


Summary:
This Client/Server Application allows you to upload an image to the server and supply a destination conversion type.
In this verison of the application, the response get's the image in the expected format, however, the code to download the response file is incomplete.
To view the response, you can do so by going on developer tools in the browser and look at the response.

Notes:
I have never used React before and this project has helped me learn a lot in such a short span of time.
I chose .NET Core for the server to showcase my understanding of this framework as Benoit revealed to me the prospect of exploring the .NET stack in the company.

Blockers:
Cors: Althrough I did add Cors related settings in the server, I did not realize I needed to add it to the client side aswell.
Sending the response as an image to the cient: This part took me some time to research the best way to go about this.
Extracting the response image to be downloaded on client side: I was unable to follow through with developing this, even after a lot fo time researching and trying different techniques. If this would happen to me during a work project, after doing sufficient research, I would reach out to another team member for their insight. 
