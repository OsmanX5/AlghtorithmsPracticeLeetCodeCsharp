WITH filter AS (SELECT 
    *,
    CASE 
        WHEN SUM(weight) OVER (ORDER BY turn) <=1000 
            THEN SUM(weight) OVER (ORDER BY turn) 
        ELSE
            '-'
    END AS AccumSum
FROM Queue
ORDER BY turn
)
SELECT DISTINCT
    LAST_VALUE(person_name) 
        OVER(
            ORDER BY turn 
            ROWS BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING
        ) AS person_name
FROM filter
where AccumSum != '-'