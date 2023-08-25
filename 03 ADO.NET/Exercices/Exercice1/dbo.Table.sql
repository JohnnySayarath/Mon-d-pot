CREATE TABLE [dbo].[etudiant]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nom] VARCHAR(50) NULL, 
    [prenom] VARCHAR(50) NULL, 
    [numero_classe] VARCHAR(50) NULL, 
    [date_diplome] DATE NULL
)
