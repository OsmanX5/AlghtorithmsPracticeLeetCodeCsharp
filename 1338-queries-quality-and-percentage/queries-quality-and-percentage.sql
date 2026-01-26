# Write your MySQL query statement below
WITH quality_times AS (SELECT 
query_name,
CASE WHEN rating <3 THEN 'low' ELSE 'high' END AS quality,
COUNT(rating) AS times
FROM Queries q
GROUP BY 1,2),
total_time AS(
    SELECT query_name,SUM(times) As times
    FROM quality_times
    GROUP BY query_name
),
low_quality AS (
    SELECT *
    FROM quality_times
    WHERE quality = "low"
),
quality_precentage AS(
SELECT total_time.query_name AS qn , ROUND(100 *IFNULL(low_quality.times,0) / (IFNULL(total_time.times,1)),2) AS poor_query_percentage
FROM total_time
LEFT JOIN low_quality
ON total_time.query_name = low_quality.query_name
),
quality AS(
    SELECT DISTINCT
        query_name,
        ROUND(AVG(rating/position) OVER (PARTITION BY query_name),2) AS quality
    FROM Queries
)
SELECT query_name,quality,poor_query_percentage 
FROM quality_precentage
JOIN quality
ON quality.query_name = quality_precentage.qn
