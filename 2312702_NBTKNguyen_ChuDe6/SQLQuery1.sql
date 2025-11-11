CREATE PROCEDURE [dbo].[Category_GetAll]
AS

	SELECT * FROM Category
	
GO

CREATE PROCEDURE [dbo].[Food_GetAll]
AS
	
	SELECT * FROM Food

GO
CREATE PROCEDURE [dbo].[Category_InsertUpdateDelete]
    @ID int output,
    @Name nvarchar(200),
    @Type int,
    @Action int
AS
IF @Action = 0
BEGIN
    INSERT INTO [Category] ([Name], [Type])
    VALUES (@Name, @Type)
    SET @ID = @@IDENTITY
END
ELSE IF @Action = 1
BEGIN
    UPDATE [Category]
    SET [Name] = @Name, [Type] = @Type
    WHERE [ID] = @ID
END
ELSE IF @Action = 2
BEGIN
    DELETE FROM [Category]
    WHERE [ID] = @ID
END
GO
CREATE PROCEDURE [dbo].[Food_InsertUpdateDelete]
    @ID int output,
    @Name nvarchar(1000),
    @Unit nvarchar(100),
    @FoodCategoryID int,
    @Price int,
    @Notes nvarchar(3000),
    @Action int
AS
IF @Action = 0
BEGIN
    INSERT INTO [Food] ([Name], [Unit], [FoodCategoryID], [Price], [Notes])
    VALUES (@Name, @Unit, @FoodCategoryID, @Price, @Notes)
    SET @ID = @@IDENTITY
END
ELSE IF @Action = 1
BEGIN
    UPDATE [Food]
    SET [Name] = @Name,
        [Unit] = @Unit,
        [FoodCategoryID] = @FoodCategoryID,
        [Price] = @Price,
        [Notes] = @Notes
    WHERE [ID] = @ID
END
ELSE IF @Action = 2
BEGIN
    DELETE FROM [Food]
    WHERE [ID] = @ID
END
GO
