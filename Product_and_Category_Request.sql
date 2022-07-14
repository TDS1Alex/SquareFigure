SELECT Product.ProductName, Category.CategoryName
FROM Product_Category
JOIN Product on Product.Id = Product_Category.ProductId
JOIN Category on Category.Id = Product_Category.CategoryId