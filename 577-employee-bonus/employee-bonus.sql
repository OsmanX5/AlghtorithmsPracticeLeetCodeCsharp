# Write your MySQL query statement below
SELECT name,bonus
FROM Employee e
LEFT JOIN Bonus b
ON b.empId = e.empId
WHERE IFNULL(b.bonus,0) <1000
