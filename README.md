# ProjectCanary Coding Exercise

## Description
This project uses a React frontend and a .NET backend. It converts a number from seven segment form to integer form. It then outputs the user input on the home page. 

The app only accepts input in a certain format. For example, the following would output 3.   
 _   
 _|  
 _|  

Each number has three spaces horizontally (making a 3x3 grid). Sections that do not have a "_" or "|" should indicate the absense of a character with a space. For example, the top line of the number 3 would be " _ ". If there spaces aren't included, it will not work. If there are consecutive numbers, there shouldn't be spaces in between the numbers. 

## To Run
* Clone the repo
* Run the app  
`cd Canary`  
`cd Canary`  
`dotnet run`  
* Open your browser, and navigate to the first localhost link displayed in the console output

## Notes
* Due to time constraints, I was not able to address everything to the extent that I would have liked to. While the basic functionality works, I did not have a chance to add error handling.
* Additionally, I did not have time to add unit tests. However, I do have experience with unit testing, and would be happy to discuss my skills more. 
* I converted the application from Javascript to Typescript, and from what I understand there are some files that can't be converted to .ts or .tsx. From my research, I found that the .setupProxy cannot be in Typescript (https://github.com/facebook/create-react-app/issues/8273). I left the main files (index.js, App.js, etc) in Javascript because I got a lot of errors when trying to convert them. Given more time, I would research more what was causing these errors, and whether or not they could be resolved.


Thank you for your time and consideration. 
