# Write your MySQL query statement below
SELECT 
#*
    p.product_id,
    IFNULL(ROUND(SUM(p.price * sold.units)/SUM(sold.units),2),0) AS average_price
FROM Prices p 
LEFT JOIN  UnitsSold sold 
ON sold.product_id = p.product_id
    AND sold.purchase_date BETWEEN p.start_date AND p.end_date
GROUP BY p.product_id