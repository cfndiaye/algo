
/*
Query the list of CITY names from STATION that do not end with vowels. Your result cannot contain duplicates.
*/
SELECT DISTINCT CITY FROM STATION WHERE RIGHT(CITY,1) NOT IN ('a','e','i','o','u');
-- AND

/*
Query the list of CITY names from STATION that either do not start with vowels or do not end with vowels. Your result cannot contain duplicates.
*/
SELECT DISTINCT CITY FROM STATION WHERE NOT LEFT(CITY,1) IN ('a','e','i','o','u') 
OR NOT RIGHT(CITY,1) IN ('a','e','i','o','u');
--END

/*
Query the list of CITY names from STATION that do not start with vowels and do not end with vowels. Your result cannot contain duplicates.
*/
SELECT DISTINCT CITY FROM STATION WHERE NOT LEFT(CITY,1) IN ('a','e','i','o','u') 
AND NOT RIGHT(CITY,1) IN ('a','e','i','o','u');
--END

/*
Query the Name of any student in STUDENTS who scored higher than  Marks. Order your output by the last three characters of each name. 
If two or more students both have names ending in the same last three characters (i.e.: Bobby, Robby, etc.), 
secondary sort them by ascending ID.
*/
SELECT NAME FROM STUDENTs WHERE MARKS > 75 ORDER BY RIGHT(NAME,3), ID;
--END

/*
Write a query that prints a list of employee names (i.e.: the name attribute) from the Employee table in alphabetical order.
*/
SELECT NAME FROM EMPLOYEE ORDER BY NAME;
--END

/*
Write a query that prints a list of employee names (i.e.: the name attribute) for employees in Employee having a salary greater than  per month who have been employees for less than  months. Sort your result by ascending employee_id.
*/
SELECT NAME FROM EMPLOYEE WHERE SALARY > 2000 AND MONTHS <10 ORDER BY EMPLOYEE_ID;
--END

/*
You are given three tables: Students, Friends and Packages. 
Students contains two columns: ID and Name. 
Friends contains two columns: ID and Friend_ID (ID of the ONLY best friend). 
Packages contains two columns: ID and Salary (offered salary in $ thousands per month).
*/
SELECT  NAME FROM STUDENTS S
JOIN FRIENDS F ON S.ID = F.ID
JOIN PACKAGES P ON S.ID = P.ID
WHERE P.SALARY < (SELECT SALARY FROM PACKAGES P2 WHERE P2.ID = F.FRIEND_ID)
ORDER BY (SELECT SALARY FROM PACKAGES P3 WHERE P3.ID = F.FRIEND_ID) ASC;
--END

Select X, Y
From Functions 
Where X = Y
Group By X, Y
Having Count(*) > 1
Union
SELECT A.x, A.y
FROM Functions A, Functions B
WHERE A.x = B.y AND A.y = B.x AND A.x < A.y
Order By 1;