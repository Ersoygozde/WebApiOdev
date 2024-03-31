/*
SQL NEDÝR? (Structured Query Language)
Sql bir veritabaný sorgulama dilidir. Sql ile veritabanýna yeni tablolar, kayýtlar ekleyip silebilir, var olanlar üzerinde duzenlemeler ve filtrelemeler yapabiliriz. 

Sql ile Oracle, db2, Sybase, Informix, Microsoft Sql Server, MS Access gibi veritabaný yönetim sistemlerinde çalýþabiliriz. Sql, standart bir veritabaný sorgu dilidir, bütün geliþmiþ veritabaný uygulamalarýnda kullanýlýr. 

T-SQL (Transact SQL)	PL-SQL

SQL'de kullanýlan komutlar 3 ana baþlýkta toplanýr.

DDL(data definition language)
Create, alter, drop

DML (data manipulation language)
Select, Delete, Update, Insert 

DCL (data control language)
Grant, Deny, Revoke
*/

--Sql Server bir RDBMS (Relational DataBase Management System)

--Select Ýfadesi
--tüm sutunlarý getir
Select * from Employees
Select * from Customers

--belirli sutunlarý getir
Select CustomerID,CompanyName,City,Fax 
from Customers

--WHERE (filtreleme)
Select *
from Customers
where Country='Canada'

--Birim fiyatý(UnitPrice) 40 dolardan fazla olan ürünler hangileridir?
Select *
from Products
where UnitPrice>40

--Hangi sipariþlerin içerisinde 11 numaralý üründen alýnmýþtýr?
Select * from [Order Details]
where ProductID=11

--sütun isimlendirme
Select EmployeeID,FirstName+' '+LastName as NameSurname,Address
from Employees

Select EmployeeID,FirstName+' '+LastName as [Name Surname],Address
from Employees

Select EmployeeID,FirstName+' '+LastName NameSurname,Address
from Employees

--1 numaralý tedarikçiye (supplier) ait olan urunler hangileridir?
Select * from Products
where SupplierID=1

--AND , OR, NOT Mantýksal Operatörleri
--5 numaralý personelin 1998 yýlýndan itibaren aldýðý sipariþleri listeleyelim.

Select *
from Orders
where EmployeeID=5 AND OrderDate>'01/01/1998'

--Berlindeki veya Amerikadaki üreticileri listelemek istiyoruz.
select *
from Suppliers
where Country='USA'or City='Berlin'

--1 veya 2 nolu üreticilerin 20$ dan pahalý olan ürünlerini listeleyelim.
select *
from Products
where (SupplierID=1 OR SupplierID=2) AND UnitPrice>20

--Kayýtlarý employeeID ye göre artan ve azalan olarak sýralama:
select * from Orders
order by EmployeeID asc

select * from Orders
order by EmployeeID desc

--Stok miktarý (UintsInStock) 50 den fazla olan ürünleri sýralayalým.
select * 
from Products
where UnitsInStock>50
order by UnitsInStock desc

--Between ... And
--iki deðer aralýðýndaki tüm kayýtlarý getirir
Select * from Customers
where CustomerID BETWEEN 'ALFKI' AND 'CACTU'

--LÝKE ifadesi
--Sutundaki deðerlerin joker karakterler kullanarak oluþturduðumuz bir arama kosulu ile karþýlaþtýrýlmasýný saðlar.
--Joker Karakter: %(herhangi uzunlukta karakter), [], -
select * from Customers
where CompanyName LIKE '%hungry%'

/*
lIKE 'K%' --k ile baþlayan tüm kayýtlar
LIKE 'Tr%'--Tr ile baþlayan tüm kayýtlar
lIKE ' en' --toplam 3 karakter olan ve son iki karakteri en olan
LIKE '[CK]%' --C veya K ile baþlayan tüm kayýtlar
LIKE '[S-V]ing' --ing ile biten ve ilk harfi s ile v arasýnda olan dört harfli tüm kayýtlar
*/

--Bir listedeki elemanlarýn aramasý (IN)

--Japonya ve Italyadaki üreticileri listeleyiniz
Select *
from Suppliers
where Country='Japan' or Country='Italy'
--verilen listede olanlar
Select *
from Suppliers
where Country IN ('Japan','Italy')

--verilen listede olmayanlar
Select *
from Suppliers
where Country  NOT IN ('Japan','Italy')

--Boþ deðerlerin görüntülenmesi (NULL)
--Herhangi bir alana bir deðer girilmezse ve alan için herhangi bir varsayýlan deðer yoksa bu alanýn deðeri NULL olur. Null deðeri boþluk '' ve 0 (sýfýr) dan farklýdýr.
--IS NULL

Select * from Suppliers
where region IS NULL

Select * from Suppliers
where region IS NOT NULL

--Benzersiz kayýtlarýn görüntülenmesi
--Hangi ülkelerden üreticilerle çalýþtýðýmýzý görmek istiyoruz.

select DISTINCT Country from Suppliers

--birden fazla alan için sýralama yapýlabilir:
Select ProductID,ProductName,CategoryID,UnitPrice
from Products
order by CategoryID desc, UnitPrice asc


--
Select * from Suppliers
Select * from Orders
Select * from Products
Select * from Customers
Select * from [Order Details]


--Adres bilgisi içerisinde St. geçen tedarikcileri listeleyiniz.
Select *
from Suppliers
where Address LIKE '%St.%'
--VINET id li müþteri yapmýþ olduðu tüm siparisleri listeleyiniz.
Select *
from Orders
where CustomerID='VINET'

--Londra veya Tokyo da bulunan tedarikçilerden region bilgisi null olanlarý listeleyiniz.
Select *
from Suppliers
where City IN ('London','Tokyo') AND Region IS NULL

--Birim fiyatý 10 dolar ile 45 dolar arasýnda olan ürünlerden kategorisi 2 olanlarý listeleyiniz.
Select *
from Products
where CategoryID=2 AND (UnitPrice BETWEEN 10 AND 45)
order by UnitPrice

--Stoklarý tükenen ürünleri listeleyiniz.
Select *
from Products
where UnitsInStock=0

--Kategori Idsi 5 olan Birim fiyatý 20 ile 35 dolara arasýnda olan ve Ürün adý içerisinde 'gute' karakterleri geçen kayýtlarý listeleyiniz.

Select *
from Products
Where CategoryID=5 AND (UnitPrice BETWEEN 20 AND 35) AND ProductName LIKE '%gute%'

--Matematiksel Ýþlemler
Select 10+5
Select 'Caner '+'Mollaoðlu'

select * from [Order Details]

--Birim Fiyat ile Miktar çarpýlarak ürün bazlý olarak toplam maliyet hesaplanýyor.

Select OrderID,ProductID,(UnitPrice*Quantity) as TotalCost
from [Order Details]
order by TotalCost desc

--TotalCost 15000 dolardan fazla olan sipariþleri listele.
Select OrderID,ProductID,(UnitPrice*Quantity) as TotalCost
from [Order Details]
where (UnitPrice*Quantity)>15000
order by TotalCost desc

--STRING FONKSIYONLARI
Select LTRIM('            Ýstanbul Eðitim Akademi')
Select RTRIM('Ýstanbul Eðitim Akademi            ')
Select UPPER('Ýstanbul Eðitim Akademi')
Select LOWER ('ÝSTANBUL');

SELECT LEFT(CompanyName,4) FROM Customers
SELECT UPPER(RIGHT(CompanyName,4)) FROM Customers
SELECT SUBSTRING('Ýstanbul Eðitim Akademi',2,10)
SELECT SUBSTRING(LastName,1,3) AS ID
from Employees
SELECT REVERSE('Ýstanbul Eðitim Akademi')
SELECT REPLACE('Ýstanbul Eðitim Akademi','Eðitim','Deneme')
SELECT REPLACE('Ýstanbul Eðitim Akademi',' ','')

SELECT 10+15
SELECT '10'+'15'
SELECT CAST('12' AS INT) +  CAST('54' AS INT) [Toplam Sonuç]

--MATH METODLARI
SELECT COS(23)
SELECT TAN(23)
SELECT ABS(-23)
SELECT SQRT(49)
SELECT POWER(2,5)

SELECT AVG(UnitPrice)
from Products
SELECT MIN(UnitPrice)
from Products
SELECT MAX(UnitPrice)
from Products

--DATETIME FONKSÝYONLARI
Select GETDATE()
Select YEAR(GETDATE())
Select MONTH(GETDATE())
Select DAY(GETDATE())

Select DATENAME(DW,'06.24.1985') --dayofweek
Select DATENAME(M,'06.24.1985')--month
Select DATENAME(D,'06.24.1985') --day

Select DATEDIFF(YEAR,'06.24.1985',GETDATE())
Select DATEDIFF(MONTH,'06.24.1985',GETDATE())
Select DATEDIFF(DAY,'06.24.1985',GETDATE())

Select DATEADD(DAY,15,GETDATE())
Select DATEADD(MINUTE,-15,GETDATE())	

--15 hafta sonra bugün hangi güne denk gelmektedir.
Select DATENAME(DW,(DATEADD(WEEK,15,GETDATE())))

select * from Employees
--Çalýþanlar için n.davolio@istanbulegitimakademi.com formatýnda mail adresleri oluþturulacaktýr. Ad Soyad ve Mail Adresi olarak görüntüleyiniz.

SELECT FirstName+' '+LastName as [Ad Soyad], LOWER(LEFT(FirstName,1)+'.'+LastName)+'@istanbulegitimakademi.com' as [E-mail]
FROM Employees

--Ürünlerin adlarýný, fiyatlarýný ve %20 kdv li fiyatlarýný raporlayýnýz.

--Çalýþanlarýn ad, soyad ve yaþlarýný görüntüleyiniz.

--Ortalama fiyattan pahalý olan ürünler hangileridir.