


show databases;

create database Livres;

use Livres;


CREATE TABLE Category(
   Id_Categorie INT AUTO_INCREMENT,
   Nom_Categorie VARCHAR(50)  NOT NULL,
   PRIMARY KEY(Id_Categorie)
);

CREATE TABLE author(
   Id_Auteur INT AUTO_INCREMENT,
   Nom VARCHAR(50)  NOT NULL,
   Prenom VARCHAR(50)  NOT NULL,
   PRIMARY KEY(Id_Auteur)
);

CREATE TABLE Book(
   ISBN VARCHAR(50) ,
   Titre VARCHAR(50)  NOT NULL,
   Description VARCHAR(50)  NOT NULL,
   Id_Categorie INT NOT NULL,
   PRIMARY KEY(ISBN),
   FOREIGN KEY(Id_Categorie) REFERENCES Category(Id_Categorie)
);

CREATE TABLE Author_Wrote(
   ISBN VARCHAR(50) ,
   Id_Auteur INT,
   PRIMARY KEY(ISBN, Id_Auteur),
   FOREIGN KEY(ISBN) REFERENCES Book(ISBN),
   FOREIGN KEY(Id_Auteur) REFERENCES author(Id_Auteur)
);
