CREATE TABLE food (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name varchar(20) NOT NULL,
    prot float NOT NULL,
    prot_total AS (prot*(typSize*0.01)) PERSISTED,
    carbs float NOT NULL,
    carbs_sugars float NULL,
    carbs_total AS (carbs*(typSize*0.01)) PERSISTED,
    fats float NOT NULL,
    fats_sat float NULL,
    fats_total AS (fats*(typSize*0.01)) PERSISTED,
    type varchar(15) NOT NULL,
    KCal100 int NOT NULL,
    typSize int NOT NULL,
    kCalTotal AS (KCal100*(typSize*0.01)) PERSISTED
);

