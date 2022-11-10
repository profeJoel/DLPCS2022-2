
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/09/2022 17:18:05
-- Generated from EDMX file: C:\Users\joelm\Desktop\respaldo\Ulagos\2022\2022-2\DLPCS\DLPCS2022-2\Modulo 4\Clase 3\EjemploModelFirst\BDprueba.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [escuela];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EstudianteCurso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CursoSet] DROP CONSTRAINT [FK_EstudianteCurso];
GO
IF OBJECT_ID(N'[dbo].[FK_AsignaturaCurso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CursoSet] DROP CONSTRAINT [FK_AsignaturaCurso];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Estudiantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estudiantes];
GO
IF OBJECT_ID(N'[dbo].[AsignaturaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AsignaturaSet];
GO
IF OBJECT_ID(N'[dbo].[CursoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CursoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Estudiantes'
CREATE TABLE [dbo].[Estudiantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AsignaturaSet'
CREATE TABLE [dbo].[AsignaturaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CursoSet'
CREATE TABLE [dbo].[CursoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EstudianteId] int  NOT NULL,
    [AsignaturaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Estudiantes'
ALTER TABLE [dbo].[Estudiantes]
ADD CONSTRAINT [PK_Estudiantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AsignaturaSet'
ALTER TABLE [dbo].[AsignaturaSet]
ADD CONSTRAINT [PK_AsignaturaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CursoSet'
ALTER TABLE [dbo].[CursoSet]
ADD CONSTRAINT [PK_CursoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EstudianteId] in table 'CursoSet'
ALTER TABLE [dbo].[CursoSet]
ADD CONSTRAINT [FK_EstudianteCurso]
    FOREIGN KEY ([EstudianteId])
    REFERENCES [dbo].[Estudiantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstudianteCurso'
CREATE INDEX [IX_FK_EstudianteCurso]
ON [dbo].[CursoSet]
    ([EstudianteId]);
GO

-- Creating foreign key on [AsignaturaId] in table 'CursoSet'
ALTER TABLE [dbo].[CursoSet]
ADD CONSTRAINT [FK_AsignaturaCurso]
    FOREIGN KEY ([AsignaturaId])
    REFERENCES [dbo].[AsignaturaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AsignaturaCurso'
CREATE INDEX [IX_FK_AsignaturaCurso]
ON [dbo].[CursoSet]
    ([AsignaturaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------