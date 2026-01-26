# Write your MySQL query statement below
SELECT name
FROM
(
    SELECT managerId
    FROM Employee
    GROUP BY managerId
    HAVING COUNT(managerId) >= 5
) as e1
JOIN Employee e2
ON e2.id = e1.managerId