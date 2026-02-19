WITH ranked AS (
    SELECT 
    name,
    departmentid,
    salary,
    DENSE_RANK() OVER(
        PARTITION BY departmentId 
        ORDER BY salary DESC
    )
    FROM Employee
),

top_ranked AS (
    SELECT name,departmentid,salary
    FROM ranked
    WHERE dense_rank<=3
)
SELECT 
    department.name AS Department,
    top_ranked.name AS Employee,
    top_ranked.salary AS Salary
FROM top_ranked
JOIN department
ON department.id = top_ranked.departmentid