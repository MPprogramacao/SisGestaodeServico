--
-- File generated with SQLiteStudio v3.3.3 on ter abr 12 23:13:00 2022
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: tb_login
DROP TABLE IF EXISTS tb_login;

CREATE TABLE tb_login (
    id      INTEGER      PRIMARY KEY AUTOINCREMENT,
    usuario VARCHAR (50) NOT NULL,
    senha   VARCHAR (10),
    ativo   BOOLEAN
);

INSERT INTO tb_login (
                         id,
                         usuario,
                         senha,
                         ativo
                     )
                     VALUES (
                         1,
                         'MATHEUS',
                         '123',
                         1
                     );

INSERT INTO tb_login (
                         id,
                         usuario,
                         senha,
                         ativo
                     )
                     VALUES (
                         2,
                         'CIBELE',
                         '1234',
                         1
                     );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
