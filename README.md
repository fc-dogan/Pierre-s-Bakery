# _Pierre's Bakery_

#### _C# console application for bakery , Feb 28 2020_

#### By _**Fatma C. Dogan**_

## Description

Console application for a bakery where a user can order a specific amount of loaves of bread and pastries.

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|When the user runs the application, they receive a prompt with a welcome message along with the cost for both Bread and Pastry.|  | Welcome to the Pierre's Bakery <br>Bread: Buy 2, get 1 free. A single loaf costs $5. <br>Pastry: Buy 1 for $2 or 3 for $5. |
|The user enters the number of loaves of bread they'd like. The application returns the total cost of order.| 1  | 1 loaves of Bread = $5 |
|The user enters the number of pastries they'd like. The application returns the total cost of order. | 2 | 2 pastry = $4 |
|If the user order more than 2 loaves of bread, the application returns discounted price | 3 | 3 loaves of Bread = $10 |
|If the user order more than 2 pastries, the application returns discounted price | 3 | 3 pastry = $5 |
|The user receives the following message to add more to the order<br> "Would you like to add more to your order? ('yes' or 'no')" | yes | What would you like to add? ('bread' or 'pastry')|
|The user can order both bread and pastry |  Bread: 2<br> Pastry: 2 | $14 |
|If the user doesn't want to add more to the order receives "Total Price" | no | Total Price = $14|




## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/fc-dogan/Pierre-s-Bakery.git ```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} ```
* On Windows: ```Pierre-s-Bakery```

_Download Manually:_

* Navigate to https://github.com/fc-dogan/Pierre-s-Bakery.git.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Pierre-s-Bakery".


_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* .Net Core
