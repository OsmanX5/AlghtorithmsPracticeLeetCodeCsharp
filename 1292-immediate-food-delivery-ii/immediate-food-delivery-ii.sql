# Write your MySQL query statement below
with filter AS (SELECT 
    customer_id,
    order_date,
    (CASE WHEN order_date = customer_pref_delivery_date THEN 'immediate' ELSE 'scheduled' END )AS im
FROM Delivery),
firstORder AS(
SELECT DISTINCT
    customer_id,
    FIRST_VALUE(im) OVER(PARTITION BY customer_id ORDER BY order_date) AS first_order_type
FROM filter
)
SELECT ROUND(100*SUM(first_order_type = 'immediate') / COUNT(*),2) AS immediate_percentage
FROM firstORder
