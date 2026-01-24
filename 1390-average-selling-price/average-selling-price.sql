# Write your MySQL query statement below
SELECT 
#*
    p.product_id,
    CASE
        WHEN sold.units IS NULL THEN 0
        ELSE ROUND(SUM(p.price * sold.units)/SUM(sold.units),2) 
        END AS average_price
FROM Prices p 
LEFT JOIN  UnitsSold sold 
ON sold.product_id = p.product_id
WHERE sold.purchase_date BETWEEN p.start_date AND p.end_date or sold.units IS NULL
GROUP BY p.product_id