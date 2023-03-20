CREATE TABLE food (
    id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre varchar(20) NOT NULL,
    Proteinas float NOT NULL,
    Hidratos float NOT NULL,
    azucares float NULL,
    Grasas float NOT NULL,
    saturadas float NULL,
    tipo varchar(15) NOT NULL,
    KCal100 int NOT NULL,
    porcionTipica int NOT NULL,
    kCalTotales AS (KCal100*(porcionTipica*0.01)) PERSISTED
);

