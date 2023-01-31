Select p."Name" as ProductName, 
	      c."Name" as CategoryName
     from products p
left join productcategory  pc on pc.productid  = p.Id
left join categories c on pc.categoryid = c.Id
 order by p."Name" , c."Name" 
 
 /*

 productname|categoryname|
-----------+------------+
a          |a           |
a          |aa          |
b          |            |
c          |c           |

 */