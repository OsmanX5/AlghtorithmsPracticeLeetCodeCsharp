WITH filter AS(
    SELECT DISTINCT
        account_id,
        CASE 
            WHEN income <20000 then 'Low Salary'
            WHEN income BETWEEN 20000 AND 50000 then 'Average Salary'
            ELSE 'High Salary'
        END AS 'category'
    FROM
        Accounts
    UNION 
    SELECT 0,'Low Salary'
    UNION
    SELECT 0,'Average Salary'
    UNION
    SELECT 0,'High Salary'
)
SELECT 
    category,
    COUNT(*)-1 As accounts_count
FROM filter
GROUP BY category