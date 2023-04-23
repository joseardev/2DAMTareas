use tienda;
/*1. Lista los nombres de los productos ordenados en primer lugar por el nombre de
forma ascendente y en segundo lugar por el precio de forma descendente.*/

SELECT p.nombre as nombre from producto p
order by nombre ASC,p.precio desc;

/*2. Lista todos los productos que tengan un precio entre 60€ y 200€.*/

SELECT * 
  FROM producto p
 WHERE precio BETWEEN 60 AND 200;

 /*3. Lista los nombres de los fabricantes cuyo nombre sea de 4 caracteres.*/

 SELECT nombre from fabricante
 where len(nombre) = 4 ;

 /*4. Devuelve una lista con el nombre del producto, precio y nombre de fabricante de
todos los productos de la base de datos.*/

SELECT p.nombre,p.precio,f.nombre 
  FROM producto p INNER JOIN fabricante f 
	on p.codigo_fabricante = f.codigo;
	

/*5. Devuelve un listado con todos los productos de los fabricantes Asus, Hewlett-
Packard y Seagate*/

SELECT p.nombre,p.precio,f.nombre 
  FROM producto p INNER JOIN fabricante f 
	on p.codigo_fabricante = f.codigo
 WHERE f.nombre in ('Asus','Hewlett-Packard','Seagate');


 /*6. Lista los nombres de los fabricantes ordenados de forma ascendente*/

 SELECT f.nombre
 from fabricante f
 order by f.nombre asc;
 

 /*7. Calcula el número total de productos que hay en la tabla productos.*/

 SELECT count(*) as "numero total de productos"
 from producto;

 /*8. Devuelve un listado con los nombres de los fabricantes donde la suma del precio de
todos sus productos es superior a 1000 €.*/

SELECT f.nombre
  FROM fabricante f INNER JOIN  producto p 
	on f.codigo = p.codigo_fabricante
	GROUP BY f.nombre
	HAVING sum(p.precio) > 1000;
	

/*9. Devuelve un listado donde sólo aparezcan aquellos fabricantes que no tienen ningún
producto asociado.*/
SELECT f.nombre
  FROM fabricante f
 WHERE f.codigo not in (SELECT p.codigo_fabricante 
						  FROM producto p);

/*10. Devuelve un listado con los nombres de los fabricantes y el número de productos
que tiene cada uno con un precio superior o igual a 220 €. El listado debe mostrar el
nombre de todos los fabricantes, es decir, si hay algún fabricante que no tiene
productos con un precio superior o igual a 220€ deberá aparecer en el listado con un
valor igual a 0 en el número de productos.*/

SELECT f.nombre,SUM(CASE WHEN p.precio >= 220 THEN 1 ELSE 0 END) as numero_productos
  FROM fabricante f LEFT JOIN  producto p 
	on f.codigo = p.codigo_fabricante
GROUP BY f.nombre;
