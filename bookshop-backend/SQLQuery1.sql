select * from Books

select * from Categories

select * from Books b join Categories c on b.CategoryId = c.Id


select Books.Id, Books.Title, Books.Description, Books.Author, Books.Price, Categories.Name as CategoryName from Books join Categories on Books.CategoryId = Categories.Id where Books.Id = 1

select Books.Id, Books.Title, Books.Author, Books.Price, Books.CategoryId, Books.Description, Categories.Name as CategoryName from Books join Categories on Books.CategoryId = Categories.Id





--insert into Categories (Name) values ('Fiction')

--EXEC sp_help 'Categories'
--EXEC sp_help 'Books'

--DROP TABLE Books
--DROP TABLE Categories