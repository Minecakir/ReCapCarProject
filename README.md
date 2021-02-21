# ReCapCarProject

<h3 align="center">Car Rental System</h3> 
This project is being developed step by step throughout the C # camp I attended.

#### First Step
Business, DataAccess, ConsoleUI and Entities layers were created for the first step of the car rental project. Then the car object is created and the Property: Id, BrandId, ColorId, ModelYear, DailyPrice, Description fields are added. 
GetById, GetAll, Add, Update, Delete operations were also included in the project by writing the necessary operations on the layers.

* A sample output before adding the real database to the system 

  ![image](https://user-images.githubusercontent.com/67970973/108624499-58c13a80-7456-11eb-8a65-e0fc7ca0e70c.png)
  
  
#### Second Step
Apart from the car object, brand and color objects are also added to the system.

A new database has been established on the Sql Server side. The Cars, Brands, Colors tables are created as shown below.


![image](https://user-images.githubusercontent.com/67970973/108640819-d748c700-74ac-11eb-9635-c4dae787b82b.png)
  
![image](https://user-images.githubusercontent.com/67970973/108640808-c4ce8d80-74ac-11eb-8677-d79eb5d95e18.png)

Generic IEntityRepository infrastructure was written to the system. 
In addition, Entity Framework infrastructure was written for Car, Brand and Color objects.

![image](https://user-images.githubusercontent.com/67970973/108640944-a5843000-74ad-11eb-9c00-e445428a46d9.png)

GetCarsByBrandId, GetCarsByColorId services were written.
When a new car was added to the system, the following rules were followed.
* The car name must be at least 2 characters

* The car's daily price must be greater than 0.

Sample output about Second Step of the Car Rental Project

![image](https://user-images.githubusercontent.com/67970973/108640917-86859e00-74ad-11eb-9411-44d167557f5d.png)
