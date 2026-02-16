-- Write your PostgreSQL query statement below
WITH _filter AS (
    SELECT 
        visited_on  ,
        SUM(amount) AS day_amount
    FROM
        Customer
    GROUP BY
        visited_on
),
allDays AS (
    SELECT 
        visited_on ,
        SUM(day_amount) OVER (
            ORDER BY visited_on
            RANGE BETWEEN INTERVAL '6' DAY PRECEDING AND CURRENT ROW
        ) AS amount,
        ROUND (AVG(day_amount) OVER (
            ORDER BY visited_on
            RANGE BETWEEN INTERVAL '6' DAY PRECEDING AND CURRENT ROW
        ) ,2)AS average_amount
    FROM _filter
)
SELECT * 
FROM
    allDays
WHERE visited_on >= (SELECT MIN(visited_on) FROM  Customer) + INTERVAL '6' DAY