DROP DATABASE IF EXISTS JDBC;
GO
CREATE DATABASE JDBC;
GO
USE JDBC;

CREATE TABLE alumnos (
  [id] int NOT NULL,
  [nombre] varchar(20) DEFAULT NULL,
  [apellidos] varchar(20) DEFAULT NULL,
  [telefono] varchar(20) DEFAULT NULL
) ;

INSERT INTO alumnos ([id], [nombre], [apellidos], [telefono]) VALUES
(1, 'Cristiano', 'Ronaldo', '987452154'),
(2, 'Iker', 'Casillas', '989654125'),
(3, 'Sergio', 'Ramos', '985321478');

CREATE TABLE empleados (
  [numemp] int NOT NULL,
  [nombre] varchar(100) NOT NULL,
  [apellidos] varchar(100) NOT NULL,
  [edad] int NOT NULL,
  [contrato] datetime NOT NULL
) ;

INSERT INTO empleados ([numemp], [nombre], [apellidos], [edad], [contrato]) VALUES
(1, 'Martin', 'Garcia', 29, '01/01/1990'),
(2, 'Ramon', 'Rios', 31, '01/01/1980'),
(3, 'Fran', 'Rocha', 32, '01/01/1970'),
(4, 'Enrique', 'Enrique', 33, '01/01/1960');

CREATE TABLE oficinas (
  [oficina] int NOT NULL,
  [region] varchar(100) NOT NULL,
  [ciudad] varchar(100) NOT NULL
) ;

INSERT INTO oficinas ([oficina], [region], [ciudad]) VALUES
(1, 'Galicia', 'Vigo'),
(2, 'Galicia', 'Santiago'),
(3, 'Madrid', 'Madrid'),
(4, 'Cataluña', 'Barcelona');

CREATE TABLE pedidos (
  [numpedido] int NOT NULL,
  [fab] int NOT NULL,
  [producto] varchar(100) NOT NULL,
  [cantidad] int NOT NULL,
  [importe] float NOT NULL
) ;

INSERT INTO pedidos ([numpedido], [fab], [producto], [cantidad], [importe]) VALUES
(1, 1, 'Cocacolas', 10, 3.5),
(2, 2, 'Pepsis', 10, 3),
(3, 1, 'Kases', 10, 2.8),
(4, 2, 'Fantas', 10, 2.7),
(5, 3, 'Aguas', 10, 1.5),
(5, 2, 'Fantas', 10, 2.7);

CREATE TABLE productos (
  [idfab] int NOT NULL,
  [idproducto] int NOT NULL,
  [descripcion] varchar(100) NOT NULL DEFAULT '',
  [precio] float NOT NULL
) ;

INSERT INTO productos ([idfab], [idproducto], [descripcion], [precio]) VALUES
(1, 1, 'Coca-Cola', 0.35),
(2, 2, 'Pepsi', 0.3),
(1, 3, 'Kas', 0.28),
(2, 4, 'Fanta', 0.27),
(3, 5, 'Agua de Mondariz', 0.15),
(4, 6, 'Agua', 0.55),
(4, 7, 'Agua', 0.55);

ALTER TABLE [alumnos]
  ADD PRIMARY KEY ([id]);
  

DROP TABLE IF EXISTS EMP;
DROP TABLE IF EXISTS DEPT;
DROP TABLE IF EXISTS BONUS;
DROP TABLE IF EXISTS SALGRADE;
DROP TABLE IF EXISTS DUMMY;

CREATE TABLE EMP
       (EMPNO INT NOT NULL,
        ENAME VARCHAR(10),
        JOB VARCHAR(9),
        MGR INT,
        HIREDATE DATE,
        SAL NUMERIC(7, 2),
        COMM NUMERIC(7, 2),
        DEPTNO INT,
	PRIMARY KEY (EMPNO));

INSERT INTO EMP VALUES
        (7369, 'SMITH',  'CLERK',     7902,
        '1980/12/17',  800, NULL, 20);
INSERT INTO EMP VALUES
        (7499, 'ALLEN',  'SALESMAN',  7698,
        '1981/02/20', 1600,  300, 30);
INSERT INTO EMP VALUES
        (7521, 'WARD',   'SALESMAN',  7698,
        '1981/02/22',  1250,  500, 30);
INSERT INTO EMP VALUES
        (7566, 'JONES',  'MANAGER',   7839,
        '1981/04/02',  2975, NULL, 20);
INSERT INTO EMP VALUES
        (7654, 'MARTIN', 'SALESMAN',  7698,
        '1981/09/28', 1250, 1400, 30);
INSERT INTO EMP VALUES
        (7698, 'BLAKE',  'MANAGER',   7839,
        '1981/05/01',  2850, NULL, 30);
INSERT INTO EMP VALUES
        (7782, 'CLARK',  'MANAGER',   7839,
        '1981/06/09',  2450, NULL, 10);
INSERT INTO EMP VALUES
        (7788, 'SCOTT',  'ANALYST',   7566,
        '1982/12/09', 3000, NULL, 20);
INSERT INTO EMP VALUES
        (7839, 'KING',   'PRESIDENT', NULL,
        '1981/11/17', 5000, NULL, 10);
INSERT INTO EMP VALUES
        (7844, 'TURNER', 'SALESMAN',  7698,
        '1981/09/08',  1500,    0, 30);
INSERT INTO EMP VALUES
        (7876, 'ADAMS',  'CLERK',     7788,
        '1983/01/12', 1100, NULL, 20);
INSERT INTO EMP VALUES
        (7900, 'JAMES',  'CLERK',     7698,
        '1981/12/03',   950, NULL, 30);
INSERT INTO EMP VALUES
        (7902, 'FORD',   'ANALYST',   7566,
        '1981/12/03',  3000, NULL, 20);
INSERT INTO EMP VALUES
        (7934, 'MILLER', 'CLERK',     7782,
        '1982/01/23', 1300, NULL, 10);

CREATE TABLE DEPT
       (DEPTNO INT,
        DNAME VARCHAR(14),
        LOC VARCHAR(13),
		PRIMARY KEY (DEPTNO));

INSERT INTO DEPT VALUES (10, 'ACCOUNTING', 'NEW YORK');
INSERT INTO DEPT VALUES (20, 'RESEARCH',   'DALLAS');
INSERT INTO DEPT VALUES (30, 'SALES',      'CHICAGO');
INSERT INTO DEPT VALUES (40, 'OPERATIONS', 'BOSTON');

CREATE TABLE BONUS
        (ENAME VARCHAR(10),
         JOB   VARCHAR(9),
         SAL   INT,
         COMM  INT,
		 PRIMARY KEY (ENAME));

CREATE TABLE SALGRADE
        (GRADE INT,
         LOSAL INT,
         HISAL INT,
		 PRIMARY KEY (GRADE));

INSERT INTO SALGRADE VALUES (1,  700, 1200);
INSERT INTO SALGRADE VALUES (2, 1201, 1400);
INSERT INTO SALGRADE VALUES (3, 1401, 2000);
INSERT INTO SALGRADE VALUES (4, 2001, 3000);
INSERT INTO SALGRADE VALUES (5, 3001, 9999);

CREATE TABLE DUMMY
        (DUMMY INT PRIMARY KEY);

INSERT INTO DUMMY VALUES (0);