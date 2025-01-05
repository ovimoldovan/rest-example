# rest-example
 REST Communication between a Python Application and an ASP.NET Web App created as an example to help students understand communication between different types of applications.

# Running the apps

1. Start the Python app: 
```python3 PythonApp.py```
2. Check that it is working by accessing the URL from the terminal (e.g. http://127.0.0.1:5000/hello).
3. Run the ASP.NET Application from an IDE (Rider, Visual Studio)
4. From the Web Application menu select ```Python App``` and test the solution.

# Troubleshoot

If there are errors, firstly check that the Python App URL is the same as the one in WebApp/Views/Home/PythonApp.cshtml.cs (line 19).

# Understanding the example

You can check the commits: [Python App](https://github.com/ovimoldovan/rest-example/commit/5e84e950997ee5f53cea9ca727b804f3f5f7b13e) and [Web App modifications](https://github.com/ovimoldovan/rest-example/commit/bc9bcc3d10348206007e188df4518e70dbf5c80d).

# Exercises

1. Change the text in the Python app to see how the app changes.
2. The Python App has 2 endpoints: ```hello``` and ```hello-name```, but only one of them is used in the web app. Following the example from the commits, create a new page that uses the other endpoint.
3. The message is received as a JSON and not formatted in any way. Find out why the web page looks like this, format it and apply some styles to make it look better.
  
Optional: 
1. The Web Application example is created from a template with Authentication and SQLite. Figure out a way to access the Python App only if you are logged in.
2. Use Entity Framework Core to save all the inputs in the database. 
