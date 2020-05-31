IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    CREATE TABLE [Categories] (
        [Id] int NOT NULL IDENTITY,
        [Category] int NOT NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    CREATE TABLE [Sex] (
        [Id] int NOT NULL IDENTITY,
        [Sexe] int NOT NULL,
        CONSTRAINT [PK_Sex] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    CREATE TABLE [Team] (
        [Id] int NOT NULL IDENTITY,
        [CategoryId] int NULL,
        [TeamName] nvarchar(max) NULL,
        CONSTRAINT [PK_Team] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Team_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    CREATE TABLE [Player] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [NumMember] int NOT NULL,
        [Adress] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [TelNumber] nvarchar(max) NULL,
        [SexId] int NULL,
        [TeamId] int NULL,
        CONSTRAINT [PK_Player] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Player_Sex_SexId] FOREIGN KEY ([SexId]) REFERENCES [Sex] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Player_Team_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [Team] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([Id], [Category])
    VALUES (1, 0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([Id], [Category])
    VALUES (2, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([Id], [Category])
    VALUES (3, 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    CREATE INDEX [IX_Player_SexId] ON [Player] ([SexId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    CREATE INDEX [IX_Player_TeamId] ON [Player] ([TeamId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    CREATE INDEX [IX_Team_CategoryId] ON [Team] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516130400_init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200516130400_init', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    ALTER TABLE [Player] DROP CONSTRAINT [FK_Player_Sex_SexId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    ALTER TABLE [Team] DROP CONSTRAINT [FK_Team_Categories_CategoryId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Team]') AND [c].[name] = N'TeamName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Team] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Team] ALTER COLUMN [TeamName] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    DROP INDEX [IX_Team_CategoryId] ON [Team];
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Team]') AND [c].[name] = N'CategoryId');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Team] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Team] ALTER COLUMN [CategoryId] int NOT NULL;
    CREATE INDEX [IX_Team_CategoryId] ON [Team] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    DROP INDEX [IX_Player_SexId] ON [Player];
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'SexId');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Player] ALTER COLUMN [SexId] int NOT NULL;
    CREATE INDEX [IX_Player_SexId] ON [Player] ([SexId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'Name');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Player] ALTER COLUMN [Name] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'LastName');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Player] ALTER COLUMN [LastName] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'Adress');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Player] ALTER COLUMN [Adress] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Sexe') AND [object_id] = OBJECT_ID(N'[Sex]'))
        SET IDENTITY_INSERT [Sex] ON;
    INSERT INTO [Sex] ([Id], [Sexe])
    VALUES (1, 0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Sexe') AND [object_id] = OBJECT_ID(N'[Sex]'))
        SET IDENTITY_INSERT [Sex] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Sexe') AND [object_id] = OBJECT_ID(N'[Sex]'))
        SET IDENTITY_INSERT [Sex] ON;
    INSERT INTO [Sex] ([Id], [Sexe])
    VALUES (2, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Sexe') AND [object_id] = OBJECT_ID(N'[Sex]'))
        SET IDENTITY_INSERT [Sex] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    ALTER TABLE [Player] ADD CONSTRAINT [FK_Player_Sex_SexId] FOREIGN KEY ([SexId]) REFERENCES [Sex] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    ALTER TABLE [Team] ADD CONSTRAINT [FK_Team_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200517154045_hommeAndfemme')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200517154045_hommeAndfemme', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    ALTER TABLE [Player] DROP CONSTRAINT [FK_Player_Sex_SexId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    ALTER TABLE [Team] DROP CONSTRAINT [FK_Team_Categories_CategoryId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Team]') AND [c].[name] = N'CategoryId');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Team] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Team] ALTER COLUMN [CategoryId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    ALTER TABLE [Team] ADD [Pouleid] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Player]') AND [c].[name] = N'SexId');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Player] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Player] ALTER COLUMN [SexId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    CREATE TABLE [Poules] (
        [id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Poules] PRIMARY KEY ([id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    CREATE INDEX [IX_Team_Pouleid] ON [Team] ([Pouleid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    ALTER TABLE [Player] ADD CONSTRAINT [FK_Player_Sex_SexId] FOREIGN KEY ([SexId]) REFERENCES [Sex] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    ALTER TABLE [Team] ADD CONSTRAINT [FK_Team_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    ALTER TABLE [Team] ADD CONSTRAINT [FK_Team_Poules_Pouleid] FOREIGN KEY ([Pouleid]) REFERENCES [Poules] ([id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200518154206_ThePoulesMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200518154206_ThePoulesMigration', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [Field] (
        [Id] int NOT NULL IDENTITY,
        [FieldCategoryId] int NULL,
        CONSTRAINT [PK_Field] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Field_Categories_FieldCategoryId] FOREIGN KEY ([FieldCategoryId]) REFERENCES [Categories] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [Level] (
        [Id] int NOT NULL IDENTITY,
        [LevelConfrotation] int NOT NULL,
        CONSTRAINT [PK_Level] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [State] (
        [Id] int NOT NULL IDENTITY,
        [StateMatch] int NOT NULL,
        CONSTRAINT [PK_State] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE TABLE [Matches] (
        [Id] int NOT NULL IDENTITY,
        [TerrainId] int NULL,
        [levelId] int NULL,
        [Team1Id] int NULL,
        [Team2Id] int NULL,
        [ArbitreId] int NULL,
        [Team1Set1] int NOT NULL,
        [Team1Set2] int NOT NULL,
        [Team2Set1] int NOT NULL,
        [Team2Set2] int NOT NULL,
        [StateId] int NULL,
        [StartTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Matches] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Matches_Team_ArbitreId] FOREIGN KEY ([ArbitreId]) REFERENCES [Team] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Matches_State_StateId] FOREIGN KEY ([StateId]) REFERENCES [State] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Matches_Team_Team1Id] FOREIGN KEY ([Team1Id]) REFERENCES [Team] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Matches_Team_Team2Id] FOREIGN KEY ([Team2Id]) REFERENCES [Team] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Matches_Field_TerrainId] FOREIGN KEY ([TerrainId]) REFERENCES [Field] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Matches_Level_levelId] FOREIGN KEY ([levelId]) REFERENCES [Level] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FieldCategoryId') AND [object_id] = OBJECT_ID(N'[Field]'))
        SET IDENTITY_INSERT [Field] ON;
    INSERT INTO [Field] ([Id], [FieldCategoryId])
    VALUES (1, 1),
    (2, 1),
    (3, 1),
    (4, 1),
    (5, 2),
    (6, 2),
    (7, 2),
    (8, 2),
    (9, 3),
    (10, 3),
    (11, 3),
    (12, 3);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FieldCategoryId') AND [object_id] = OBJECT_ID(N'[Field]'))
        SET IDENTITY_INSERT [Field] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'LevelConfrotation') AND [object_id] = OBJECT_ID(N'[Level]'))
        SET IDENTITY_INSERT [Level] ON;
    INSERT INTO [Level] ([Id], [LevelConfrotation])
    VALUES (6, 5),
    (4, 3),
    (5, 4),
    (2, 1),
    (1, 0),
    (3, 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'LevelConfrotation') AND [object_id] = OBJECT_ID(N'[Level]'))
        SET IDENTITY_INSERT [Level] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'StateMatch') AND [object_id] = OBJECT_ID(N'[State]'))
        SET IDENTITY_INSERT [State] ON;
    INSERT INTO [State] ([Id], [StateMatch])
    VALUES (1, 0),
    (2, 1),
    (3, 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'StateMatch') AND [object_id] = OBJECT_ID(N'[State]'))
        SET IDENTITY_INSERT [State] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryId', N'Pouleid', N'TeamName') AND [object_id] = OBJECT_ID(N'[Team]'))
        SET IDENTITY_INSERT [Team] ON;
    INSERT INTO [Team] ([Id], [CategoryId], [Pouleid], [TeamName])
    VALUES (10, 1, NULL, N'Equipe10'),
    (9, 1, NULL, N'Equipe9'),
    (8, 1, NULL, N'Equipe8'),
    (7, 1, NULL, N'Equipe7'),
    (6, 1, NULL, N'Equipe6'),
    (3, 1, NULL, N'Equipe3'),
    (4, 1, NULL, N'Equipe4'),
    (2, 1, NULL, N'Equipe2'),
    (1, 1, NULL, N'Equipe1'),
    (11, 1, NULL, N'Equipe11'),
    (5, 1, NULL, N'Equipe5'),
    (12, 1, NULL, N'Equipe12');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryId', N'Pouleid', N'TeamName') AND [object_id] = OBJECT_ID(N'[Team]'))
        SET IDENTITY_INSERT [Team] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Adress', N'Email', N'LastName', N'Name', N'NumMember', N'SexId', N'TeamId', N'TelNumber') AND [object_id] = OBJECT_ID(N'[Player]'))
        SET IDENTITY_INSERT [Player] ON;
    INSERT INTO [Player] ([Id], [Adress], [Email], [LastName], [Name], [NumMember], [SexId], [TeamId], [TelNumber])
    VALUES (1, N'Rue', N'a@hatmail.com', N'D', N'C', 2, 1, 1, N'03430 34'),
    (21, N'Rue', NULL, N'X', N'W', 22, 2, 7, NULL),
    (22, N'Rue', N'a@hatmail.com', N'Y', N'X', 23, 1, 8, N'03430 34'),
    (23, N'Rue', NULL, N'Z', N'Y', 24, 1, 8, NULL),
    (24, N'Rue', NULL, N'[', N'Z', 25, 2, 8, NULL),
    (25, N'Rue', N'a@hatmail.com', N'\', N'[', 26, 1, 9, N'03430 34'),
    (26, N'Rue', NULL, N']', N'\', 27, 1, 9, NULL),
    (20, N'Rue', NULL, N'W', N'V', 21, 1, 7, NULL),
    (27, N'Rue', NULL, N'^', N']', 28, 2, 9, NULL),
    (29, N'Rue', NULL, N'`', N'_', 30, 1, 10, NULL),
    (30, N'Rue', NULL, N'a', N'`', 31, 2, 10, NULL),
    (31, N'Rue', N'a@hatmail.com', N'b', N'a', 32, 1, 11, N'03430 34'),
    (32, N'Rue', NULL, N'c', N'b', 33, 1, 11, NULL),
    (33, N'Rue', NULL, N'd', N'c', 34, 2, 11, NULL),
    (34, N'Rue', N'a@hatmail.com', N'e', N'd', 35, 1, 12, N'03430 34'),
    (28, N'Rue', N'a@hatmail.com', N'_', N'^', 29, 1, 10, N'03430 34'),
    (19, N'Rue', N'a@hatmail.com', N'V', N'U', 20, 1, 7, N'03430 34'),
    (18, N'Rue', NULL, N'U', N'T', 19, 2, 6, NULL),
    (17, N'Rue', NULL, N'T', N'S', 18, 1, 6, NULL),
    (2, N'Rue', NULL, N'E', N'D', 3, 1, 1, NULL),
    (3, N'Rue', NULL, N'F', N'E', 4, 2, 1, NULL),
    (4, N'Rue', N'a@hatmail.com', N'G', N'F', 5, 1, 2, N'03430 34'),
    (5, N'Rue', NULL, N'H', N'G', 6, 1, 2, NULL),
    (6, N'Rue', NULL, N'I', N'H', 7, 2, 2, NULL),
    (7, N'Rue', N'a@hatmail.com', N'J', N'I', 8, 1, 3, N'03430 34'),
    (8, N'Rue', NULL, N'K', N'J', 9, 1, 3, NULL),
    (9, N'Rue', NULL, N'L', N'K', 10, 2, 3, NULL),
    (10, N'Rue', N'a@hatmail.com', N'M', N'L', 11, 1, 4, N'03430 34'),
    (11, N'Rue', NULL, N'N', N'M', 12, 1, 4, NULL),
    (12, N'Rue', NULL, N'O', N'N', 13, 2, 4, NULL),
    (13, N'Rue', N'a@hatmail.com', N'P', N'O', 14, 1, 5, N'03430 34'),
    (14, N'Rue', NULL, N'Q', N'P', 15, 1, 5, NULL),
    (15, N'Rue', NULL, N'R', N'Q', 16, 2, 5, NULL),
    (16, N'Rue', N'a@hatmail.com', N'S', N'R', 17, 1, 6, N'03430 34'),
    (35, N'Rue', NULL, N'f', N'e', 36, 1, 12, NULL),
    (36, N'Rue', NULL, N'g', N'f', 37, 2, 12, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Adress', N'Email', N'LastName', N'Name', N'NumMember', N'SexId', N'TeamId', N'TelNumber') AND [object_id] = OBJECT_ID(N'[Player]'))
        SET IDENTITY_INSERT [Player] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_Field_FieldCategoryId] ON [Field] ([FieldCategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_Matches_ArbitreId] ON [Matches] ([ArbitreId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_Matches_StateId] ON [Matches] ([StateId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_Matches_Team1Id] ON [Matches] ([Team1Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_Matches_Team2Id] ON [Matches] ([Team2Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_Matches_TerrainId] ON [Matches] ([TerrainId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    CREATE INDEX [IX_Matches_levelId] ON [Matches] ([levelId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200525183710_StarTime')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200525183710_StarTime', N'3.1.4');
END;

GO

