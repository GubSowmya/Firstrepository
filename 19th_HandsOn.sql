use Shopping

/*create table customer having custid,custname,city,state

b) create table products having
     prodid,prodname,unitprice,UnitOfMeasurement,QtyinStock
c) Create a table sales_header
             invno,invdate,invamt,disPercent
d) create a table sales_detail
           invno,custid,prodid,qtysold
d) create primary key for 
        custid,prodid,invno in the sales_header table.
e) Create foreign key of 
          invno in the sales_detail table.*/

create table customer (
custid int,
custname varchar(20),
city varchar(20),
cusstate varchar(20)
)

	 create table products (
	 prodid int,
	 prodname varchar(20),
	 uniprice varchar(20),
	 UnitOfMeasurement varchar(20),
	 QtyinStock varchar(20)
	 )
create table sales_header
(
invno int,
invadate varchar(20),
invamt varchar(20),
dispercent varchar(20)
) 

create table sales_detail
(
 invno int ,
 custid varchar(20),
 prodid varchar(20),
 qtysold varchar(20)
 )

 /*create primary key for custid,prodid,invno in the sales_header table.

 alter table sales_header
 add primary key(invno)*/

 /*e) Create foreign key of 
      invno in the sales_detail table.
	  
	  Create table sales_header 
( Custid int, prodid int, invno int, primary key(Custid ,prodid,invno))
	  */

	  /*alter the sales_detail to apply a foreign key to custid and prodid.

alter table sales_detail
add foreign key (custid) references customer(custid);
add foreign key(prodid) references product(prodid);*/

/*
4) Drop a column qtySold.
*/

alter table sales_detail
drop column qtySold;
add  qty int;



/*5) Add a column Qty.*/
/*6) rename qty to Quantity(InNos)*/

EXEC sp_rename 'sales_detail.qty', 'Quantity(InNos)'





select * from sales_detail

/*create primary key for custid,prodid,invno in the sales_header table.

 alter table sales_header
 add primary key(invno)*/

ALTER TABLE sales_header
   ADD PRIMARY KEY (invno);