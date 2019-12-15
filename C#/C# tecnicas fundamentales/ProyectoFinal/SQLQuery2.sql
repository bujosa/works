CREATE TABLE [dbo].[Estudiante4] (
    [Id]             INT           NOT NULL,
    [NombreCompleto] NVARCHAR (50) NOT NULL,
	[Carrera] NVARCHAR (50) NOT NULL,
    [Password]       NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


insert into Estudiante4 values (1074460, 'davidbujosa', '
Ingeniería de Software (IDS)' , 'bujosa2018')