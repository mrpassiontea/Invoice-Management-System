#Inventory Management System
#### Developed in C#, a Windows form application
The invoice management system allows the end-user to create employees and invoices. And provides the ability
to generate reports based on the employees and invoices.

The following concepts are incorporated in this application:
* OOP (Object Oriented Programming)
* Dependency Injection (The SQL database connection throughout the application)
* Inheritance
* Classes
* Polymorphism

## Requirements
* SQL Server Express 2019
* SQL Server Management Studio 18
* Latest version of .NET Core

## Features include
* Log in system
* Adding/Modifying/Deleting employees and invoices
* Filtering/searching employees and invoices
* Generating reports for the by user, employees, and type of employee  

## Screenshots of the application in use
![Login window](./readme-images/login.png?raw=true)  
*The application's login screen. This window's text is rendered using a Resource Manager reading from Login.en-US.resx. In previous versions of the application, there was a button which allowed the end-user to switch between an English version of the login page and a Korean version. This was made possible by including a resource file in Korean.*  

![Error appearing when attempting to log in with invalid credentials](./readme-images/login-error.png?raw=true)  
*A notification window appears when the user enters invalid credentials.*  
  
![Successful login displays the application's dashboard](./readme-images/dashboard.png?raw=true)
*Upon successful login, the application's main dashboard appears.*  
  
![Error occurs when attempting to create or modify an invoice when an employee doesn't exist](./readme-images/invoice-error-handling.png?raw=true)  
*If the user attempts to add or modify an invoice before creating an employee, an error will appear.*

![Employee create window](./readme-images/employee-create.png?raw=true)  
*When the user attempts to add or modify an employee, the following window appears. The "Type" has the following options: Full-time, Part-time, and Contract.*  

![The list of employees updates when an employee is created](./readme-images/employee-created.png?raw=true)  
*After creating the employee, John, the user is redirected back to the dashboard and the list of employees is updated.*  

![Invoice create window](./readme-images/invoice-create.png?raw=true)  
*When pressing the Add Invoice button, a new window will appearing asking which employee you are creating an invoice for and then properties regarding the invoice. 
There is specific error handling logic in the create/modify invoice windows to ensure that all input fields have the correct type of data inputed. For example, 
when creating an invoice, no alphabetical characters will be allowed in the "Hours Worked" input.*  

![The list of invoices updates when an invoice is created](./readme-images/invoice-created.png?raw=true)  
*The user is redirected back to the dashboard after adding an invoice or pressing the "Exit" button.*  

![The reports window showing reports generated for the existing employees and invoices](./readme-images/reports-generating.png?raw=true)  
*The reports window allows the end-user to generate multiple reports on either the invoices, employees, or both.*   

![Confirmation window for deleting an invoice](./readme-images/invoice-delete.png?raw=true)  
*A confirmation window appears when the user attempts to delete an invoice.*  
![Confirmation window for deleting an employee](./readme-images/employee-delete.png?raw=true)  
*A confirmation window appears when the user attempts to delete an employee.*

## Database
This application uses SQL and stores its data in a local SQL Server Express database named *imsdb*.

This repository does not have an database import file. For reference, here is the ERD-diagram of the database.
![ERD Diagram of the imsdb Database](./readme-images/erd-diagram.png?raw=true)

## SDLC Method Used
Since all of the project's requirements and project scope could be gathered in a short time and upfront, the waterfall life cycle method was used in the development of this application.  

## Low-fidelity Wireframes
Created in the design stage of the waterfall lifecycle here are low-fidelity wireframes of the application created using Figma.
![Low-fidelity wireframe of the login page which also showcased the Korean language option.](./readme-images/login-figma.png?raw=true)  
*Note: While initially implemented, the Korean resource file was taken out of the application in the end.*  

![Low-fidelity wireframe of the main dashboard.](./readme-images/dashboard-figma.png?raw=true)  

![Low-fidelity wireframe of the employees window.](./readme-images/employee-figma.png?raw=true)  

![Low-fidelity wireframe of the invoices window.](./readme-images/invoices-figma.png?raw=true)

![Low-fidelity wireframe of the reports window.](./readme-images/reports-figma.png?raw=true)



## Testing
Manual testing was conducted in this application. If interested in which test cases were used, please download the following PDF:
[IMS Manual Test Cases (PDF)](./testing/IMS%20Manual%20Test%20Cases.pdf)

### If you'd like to run this application
You will need to create a new imsdb in SQL Server Management Studio and add your own server connection data source information within the App.config file. 

## License
[MIT](https://choosealicense.com/licenses/mit/)