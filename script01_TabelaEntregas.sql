IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Entregas] (
    [Id] int NOT NULL IDENTITY,
    [Local_Entrega] nvarchar(max) NOT NULL,
    [Tipo_Entrega] nvarchar(max) NOT NULL,
    [Hr_Entrega] nvarchar(max) NOT NULL,
    [Dt_Entrega] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Entregas] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dt_Entrega', N'Hr_Entrega', N'Local_Entrega', N'Tipo_Entrega') AND [object_id] = OBJECT_ID(N'[Entregas]'))
    SET IDENTITY_INSERT [Entregas] ON;
INSERT INTO [Entregas] ([Id], [Dt_Entrega], [Hr_Entrega], [Local_Entrega], [Tipo_Entrega])
VALUES (1, N'01/05/1760', N'10:10', N'Rua São João', N'Sedex'),
(2, N'02/05/1760', N'11:11', N'Rua Santo Antônio', N'ONG'),
(3, N'03/05/1760', N'22:22', N'Rua Santa Maria', N'Sedex'),
(4, N'04/05/1760', N'09:09', N'Rua Josino', N'ONG'),
(5, N'05/05/1760', N'08:08', N'Rua do Vieira', N'Retirada');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dt_Entrega', N'Hr_Entrega', N'Local_Entrega', N'Tipo_Entrega') AND [object_id] = OBJECT_ID(N'[Entregas]'))
    SET IDENTITY_INSERT [Entregas] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230619115516_InitialCreate', N'7.0.8');
GO

COMMIT;
GO

