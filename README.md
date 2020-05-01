Language : [Turkish](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/README(Turkish).md) / English

# weather Forecast Application

### SUMMARY

Weather forecasting is at the heart of meteorology, many young people engaged in this work try to accurately predict and explain the weather events affecting the life of millions of people. Weather forecasts affect many people and many countries.Therefore, the subject of weather forecasting in our project is carried out through the database and algorithms and the internet server. Weather forecast with some algorithms using database and historical data has been realized in the project.

Keywords: weather, forecast, database, algorithm, web, server.

```
Project creation date: November 2019
```

### LOGIN

The weather forecast; Forecasting studies using subjective or objective methods based on observations and analysis of meteorological events that can be seen within a time period in a particular country, region or center are called weather forecasting.

The Weather Forecast has Three Stages:
- Observations             
- Analysis             
- Guess             

In this project, the results of the analysis and prediction were obtained. Observation data was taken from the systems prepared by the General Directorate of Meteorology. Because the observation step is done with physical materials, it would be more logical to take it ready for the project. In the data we received from the General Directorate of Meteorology, average weather values ​​were taken daily from stations located in 5 districts of Kütahya between 01.01.2018 and 01.01.2019. These districts are Kütahya (Center), Emet, Simav, Gediz and Altıntaş respectively. Average temperature, average current pressure and average humidity values ​​were taken from these stations daily.White and blue shades are used on the website.

In the upper right corner of the pages for site transitions, there are Home page, About Us and Contact buttons respectively. On the main page, there is the area where the estimates of the temperature, pressure and humidity values ​​of the days from the current day to one week later. In the About Us section, the project team members have their names, surnames, photographs and duties in the project. The contact page includes the address, e-mail information and contact form of Kütahya Dumlupınar University.

### CONTENT
#### WEB SITE DESIGN

This project uses HTML, CSS, Javascript, Bootstrap, ASP .Net MVC C #, LinQ, Github, SQL server and SQL Server Management Studio technologies. A simple and understandable design has been created by removing the unnecessary parts for this project in the existing Bootstrap library. After the visual parts are created on the design, the weather icons are shown in the table so that the user can understand the weather values. As Asp .NET MVC suggested, by transferring the transactions to be made between the head tags of the html code to the layout page, the ease of use of both the layout of the code and the fixed parts were emphasized. At the same time, necessary page redirects for the phone are added to the layout page and the website is provided to support the phone screens.

#### Home page:

![Screenshot Home Page](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Homepage.png)

There are daily areas for one week weather values ​​for the city of Kütahya. These values ​​are presented to users, respectively, average temperature, average current pressure and average humidity. Values ​​are shown in daily fields. With these values, a new estimation algorithm has been created by analyzing the algorithm structures of similar works and using regression equations. In this way, forward weather forecast values ​​are created. The values ​​created show the values ​​of that day.

#### Contact:

![Screenshot Contact Page](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/ContactPage.png)

On the last page, there is a location section on the left side of the communication page. From here, the location of Kütahya Dumlupınar University is accessed. Kütahya Dumlupınar University also has contact information such as full address, phone number and email address. On the right, there is a form for users to contact us. Thanks to this form, users can submit their complaints, suggestions, questions, or whatever they find, such as e-mail, company, website and message, and send them to us.

### RECEIVING THE WEATHER DATA OF PAST YEARS

In this project, it has been determined that 1 year data for 1 region must be present in order to analyze the weather data. This conclusion was made after research from the registration database is passed in the weather over the internet provinces of Turkey. The website for this project in the Republic of Turkey in the direction of research of Agriculture and Forestry Ministry data provided by the General Directorate of Meteorology is appropriate.

The General Directorate of Meteorology gives these data to the users with a material response. These data are provided free of charge for university research. In this case, by applying the necessary regulation, a petition approved by the head of the Computer Engineering Department of Kütahya Dumlupınar University and a database containing the necessary data and dates for the project were requested to the General Directorate of Meteorology. This database contains daily average weather values ​​from stations located in 5 districts of Kütahya between 01.01.2018 and 01.01.2019. These districts are Kütahya (Center), Emet, Simav, Gediz and Altıntaş respectively. Average temperature, average current pressure and average humidity values ​​were taken daily from these stations.

### CREATING TABLES FOR THE DATABASE AND ADDING DATA

Since the data received from the General Directorate of Meteorology is independent and Excel-based, it has been converted to SQL-based and .mdf extension with the help of an Internet-based Tool. Arrangements were made with the MsSQL program. The database has been established.

![Screenshot DataBase1](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Database0.png)

![Screenshot DataBase2](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Database.png)

![Screenshot DataBase3](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/Screenshots/Database2.png)

### WEATHER FORECAST ALGORITHM

Literature scanning was done. Similar projects have been examined. Solution methods and algorithms have been tested. The successful algorithm has been adapted to the project. The algorithm has been tested on the data from MsSQL and the newly created data has been transferred to the field on the website.

### RESULTS

Weather forecast requires a complex and comprehensive study. In this project, new estimates were obtained with historical data and various algorithms. It was created using Bootstrap for web page design, and the design was completed by writing the required codes. While the database was being designed, it was taken ready from the systems prepared by the General Directorate of Meteorology. For this, a petition was sent to the General Directorate of Meteorology by the head of the Computer Engineering department of Kütahya Dumlupınar University. Suitable databases and tables have been created for the incoming data . The data has been added to the created fields. The HomeController class has been created in accordance with the Asp.net MVC structure. Database connection has been made within this class. With the connection provided, the weather, date, temperature, pressure and humidity were taken with necessary queries.

Regression analysis was used among various algorithms. Regression shows the functional form of the linear relationship between two (or more) variables, one as a dependent equation and the other as an independent variable, and provides predictions about the other when the value of one variable is known. In this way, weather values ​​(temperature, pressure and humidity) that will come with the past weather data are estimated.

## Getting Started

Download a copy of the project files to your local machine to run the project. Get the necessary environments. Create the database and process the necessary information. You can start using the connection between the database and the project.

### Requirements

- Microsoft Visual Studio
- Microsoft SQL server
- Microsoft SQL Server Management Studio

To run the project, you must first obtain any version of the software suitable for your system from [Microsoft Visual Studio](https://visualstudio.microsoft.com/) and install it on your local machine. As a next step, create a new database by obtaining a database at [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2019). Enter the necessary data into the database you have created. Then, it will be enough to introduce the project to IDE environment and perform the debug operation. During this process, you should test the connection between the database and the project and make the necessary adjustments.

## Authors

* **Batuhan Güneş**  - [BatuhanGunes](https://github.com/BatuhanGunes)

See also the list of contributors [contributors](https://github.com/BatuhanGunes/weatherForecastApplication/graphs/contributors) who participated in this project.

## License

his project is licensed under the Apache License - see the [LICENSE.md](https://github.com/BatuhanGunes/weatherForecastApplication/blob/master/LICENSE) file for details.

