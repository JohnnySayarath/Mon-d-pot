DROP TABLE [personne];

CREATE TABLE [personne] (
    [Id]         INT     IDENTITY(1,1)     NOT NULL PRIMARY KEY,
    [nom]        VARCHAR (50) NULL,
    [prenom]     VARCHAR (50) NULL,
    [telephone] VARCHAR (50) NULL
);

