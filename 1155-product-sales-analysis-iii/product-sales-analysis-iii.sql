WITH min_years AS(
    SELECT 
        product_id, 
        MIN(s.year) AS min_year
    FROM Sales s
    GROUP BY product_id
)

SELECT Sales.product_id , min_years.min_year AS first_year,quantity,price
FROM Sales
JOIN min_years
ON Sales.year = min_years.min_year AND Sales.product_id = min_years.product_id