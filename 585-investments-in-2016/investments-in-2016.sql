WITH lonlat_filter AS (
    SELECT
        lon::TEXT || lat::TEXT
    FROM Insurance
    GROUP BY lon,lat
    HAVING COUNT(*) = 1
),
has_same_2015 AS (
    SELECT tiv_2015
    FROM Insurance
    GROUP BY tiv_2015
    HAVING COUNT(*) >1
),
filter1 AS (
    SELECT *
    FROM Insurance
    WHERE tiv_2015  in (SELECT * FROM has_same_2015)
),
filter2 AS (
    SELECT 
        *
    FROM filter1
    WHERE (lon::TEXT || lat::TEXT) IN (SELECT * FROM lonlat_filter)
)

SELECT 
    ROUND(SUM(tiv_2016)::NUMERIC,2) AS tiv_2016
FROM filter2

