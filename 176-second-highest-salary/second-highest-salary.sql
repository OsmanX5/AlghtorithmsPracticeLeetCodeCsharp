WITH ranked AS (
    SELECT 
        salary,
        DENSE_RANK() OVER (ORDER BY salary DESC) AS rank
    FROM (SELECT DISTINCT salary FROM Employee)
)
SELECT *
FROM(
SELECT 
    salary AS SecondHighestSalary
FROM ranked
WHERE rank =2
UNION
SELECT null
)
LIMIT 1

