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
idpermisos ENUM('ADMIN','GENERAL') PRIMARY KEY);

CREATE TABLE usuario(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
rfc VARCHAR(50),
nombre VARCHAR(50),
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fdn DATE,
fkidpermisos ENUM('ADMIN','GENERAL'),
FOREIGN KEY(fkidpermisos) REFERENCES permisos(idpermisos));