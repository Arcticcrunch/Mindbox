-- Предпологается что в БД есть 3 таблицы: products (столбцы ID и Name), categories (столбцы ID и Category) и
-- products_and_categories (столбцы ID, ProductID и CategoryID).
-- Предпологается что те продукты у которых нет категории не имеют записии в таблице products_and_categories (только в products).
-- Исходя из поставленной цели запрос должен выводить все пары продукт-категория, а так же продукты без категории.
-- Только категории выводить не нужно. 

-- SQL код для MySQL (в данный момент нет возможности установить MS SQL Server и переписать под него):

(SELECT products.Name, categories.Category
FROM products, products_and_categories, categories
WHERE (products.ID = products_and_categories.ProductID AND products_and_categories.CategoryID = categories.ID))

UNION

(SELECT products.Name, NULL AS 'Category'
FROM products
WHERE (NOT EXISTS (SELECT * FROM products_and_categories WHERE products_and_categories.ProductID = products.ID)))

-- В первой части юниона запрашиваются все пары продукт-категория.
-- Во второй части юниона к ним добавляются продукты без категории (нет записи в таблице products_and_categories)
-- NULL AS 'Category' - создание столбца-пустышк
-- без которой юнион работать не будет т.к. нет выборки из таблицы categories в которой находится столбец Category.