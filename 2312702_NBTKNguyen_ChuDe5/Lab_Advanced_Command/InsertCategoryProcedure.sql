CREATE PROCEDURE InsertCategory
    @ID    INT OUTPUT,        
    @Name  NVARCHAR(1000),    
    @Type  INT                
AS
BEGIN
    INSERT INTO Category(Name, [Type]) VALUES(@Name, @Type);
    SET @ID = SCOPE_IDENTITY();  
END