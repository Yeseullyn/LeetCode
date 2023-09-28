-- Write a solution to find the employees who earn more than 
-- their managers.
-- Return the result table in any order.

-- # Write your MySQL query statement below

SELECT name AS Employee
FROM Employee e1
WHERE managerId IS NOT NULL 
AND salary > (select salary from employee where Id = e1.managerId)
