CREATE PROCEDURE GetBillsByDateRangeProcedure
    @fromDate DATETIME,
    @toDate   DATETIME
AS
BEGIN
    SELECT ID, Name, TableID, Amount, Discount, Tax, Status, CheckoutDate
    FROM   Bills
    WHERE  CheckoutDate >= @fromDate AND CheckoutDate < @toDate;
END;

