Select ContactName Adi, CompanyName Sirket, City Sehir from Customers
Select * from Customers where City='London' --Şehri londra olan customers getir

select *from Products where CategoryID='1' or CategoryID='2' --categori id 1 veya 2 olanları getir

select *from Products where CategoryID='1' and UnitPrice>=10 --UnitPrice<>10 10dan farklı olanları getirir

select *from Products order by ProductName -- ürün ismine göre sıralar

select *from Products order by ProductName, CategoryID --ilk başta isimlerine göre sonra ıdye göre sıralar

select *from Products order by UnitPrice desc --asc artana göre desc azalana göre sıralar

select *from Products where CategoryID='1' order by UnitPrice desc

select count(*) Adet from Products --toplam product sayısını verir(sutun adı adet oldu)

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 --toplam sayısı 10dan küçük unitpriceı20den büyük olanları kategori id ye göre grupladı

select Products.ProductId,Products.CategoryID ,Categories.CategoryId,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10 --fiyatı ondan büyük olanlar için
--categori idleri aynı olan iki tabloyu joinledik 

select *from Products p inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o 
on o.OrderID= od.OrderID

--**left join soldaki tabloda olup sağdakinde olmayanları DA getirir
--**right join leftin tam tersi
--**inner join iki tabloda da aynı olan sütunları getirir

select *from Customers c left join Orders o on c.CustomerID= o.CustomerID 
where o.CustomerID is null --sorgu hiç alışveriş yapmamış müşterileri getirir


