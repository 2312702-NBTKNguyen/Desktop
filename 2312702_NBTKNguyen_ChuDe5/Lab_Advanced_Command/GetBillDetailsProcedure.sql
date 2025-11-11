CREATE PROCEDURE GetBillDetailsProcedure
    @invoiceID INT
AS
BEGIN
    SELECT bd.ID, bd.InvoiceID, bd.FoodID, f.Name AS FoodName, f.Unit,
           f.Price, bd.Quantity, (bd.Quantity * f.Price) AS TotalPrice
    FROM   BillDetails bd
           INNER JOIN Food f ON bd.FoodID = f.ID
    WHERE  bd.InvoiceID = @invoiceID;
END;
