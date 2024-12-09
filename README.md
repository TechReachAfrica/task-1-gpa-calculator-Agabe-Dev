Task 1 - GPA Calculator 

Intro: 

This task is aimed at evaluating your understanding of programming with C# language and the fundamental syntax and structures. 

Challenge 

You are required to write a console application that models a Grade Point Average (GPA) calculator and prints the result. 

The result should be displayed in a tabular form as shown below: 

|----------------------------|-----------------------|------------|---------------------|------------------|-------------------| 

| COURSE & CODE   | COURSE UNIT | GRADE | GRADE-UNIT | WEIGHT Pt.  | REMARK       | 

|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------| 

| MTH101	           |   5                       |   B         |   4                    |        20           | Very Good    | 

| GS101                     |   3                       |   A         |   5                     |        15          | Excellent       | 

| NET101	           |   5                       |   C         |   3                    |        15          | Good             | 

| C#101	           |   5                       |   B         |   4                    |        20          | Very Good     | 

| HCI101	           |   3                       |   F         |   0                     |          0          | Fail               | 

|---------------------------------------------------------------------------------------|------------------|-------------------| 

  

Total Course Unit Registered is 21 

Total Course Unit Passed is 18 

Total Weight Point is 70 

Your GPA is = 4.10 to 2 decimal places. 

 

For reference, GPA is calculated as follows:  

GPA = (total weight point) / (total course unit);  

where: 

(Weight point) = (course unit) * (grade unit); 

 

See grading system below: 

Score           	Grade          	Grade Unit      	Remark 

70-100         	A                  	5                  	Excellent 

60-69           	B                  	4                  	Very Good 

50-59           	C                 	3                  	Good 

45-49              D                 	2                  	Fair 

40-44              E                  	1                  	Pass 

0-39 	          F                  	0                  	Fail 

  

Task requirements  

- All stories should be completed. 

Submission should be made to this GitHub classroom link: https://classroom.github.com/a/3aTj_mee  

 

Functional requirements  

- The calculator should have a grading system that grades the score dynamically 

  

Task Story  

As a ** User **  

I want to be able to input course name and code, course unit, course score; one after the other 

so that the calculator will calculate the score grade and record it before the total result and GPA is displayed. 

  

Acceptance criteria 

- The grade should be calculated using the grading system given above 

- The GPA should be calculated using the formula given above 

- A Class “PrintTable” should be created to handle printing of the tabular result. 



[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/3aTj_mee)
