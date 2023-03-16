INSERT INTO food
VALUES (Hamburguesa, 16.2, 8.7, 2.7, 13.3, 5.7, 219, 240, Carne)
GO
ALTER TABLE food
ADD kCalPiece AS (kCal100*(tipSize/100));

