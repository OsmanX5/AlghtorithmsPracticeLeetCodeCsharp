WITH reports AS (
    SELECT 
        reports_to,
        COUNT(*) AS reports_count , 
        ROUND(AVG(age),0) AS average_age
    FROM Employees
    GROUP BY reports_to
)

SELECT employee_id,name,reports_count,average_age
FROM Employees
JOIN reports 
ON reports.reports_to = employee_id
ORDER BY Employees.employee_id