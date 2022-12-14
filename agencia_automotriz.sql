CREATE DATABASE agencia_automotriz;
USE agencia_automotriz;

CREATE TABLE producto(
codigobarras VARCHAR(100) PRIMARY KEY,
nombre VARCHAR(100),
descripcion VARCHAR(200),
marca VARCHAR(100));

CREATE TABLE herramienta(
codigoherramienta VARCHAR(100) PRIMARY KEY,
nombre VARCHAR(100),
medida VARCHAR(100),
marca VARCHAR(100),
descripcion VARCHAR(200));

CREATE TABLE permisos(
idpermisos ENUM('ADMIN','GENERAL','PRODUCTOS','HERRAMIENTAS') PRIMARY KEY);

CREATE TABLE usuario(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
rfc VARCHAR(50),
contrasena VARCHAR(50),
nombre VARCHAR(50),
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fdn DATE,
fkidpermisos ENUM('ADMIN','GENERAL','PRODUCTOS','HERRAMIENTAS'),
FOREIGN KEY(fkidpermisos) REFERENCES permisos(idpermisos));

SELECT * FROM usuario;
SELECT * FROM permisos;
INSERT INTO permisos VALUES('1');
INSERT INTO permisos VALUES('2');
INSERT INTO permisos VALUES('3');
INSERT INTO permisos VALUES('4');

INSERT INTO usuario VALUES(NULL,'a','a','a','a','a','2020/10/10',2);
INSERT INTO usuario VALUES(NULL,'b','b','a','a','a','2020/10/10',1);