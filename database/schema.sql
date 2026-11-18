-- Database schema for the Smart Home Management Panel (SQL Server).
-- Reconstructed from the queries used in the forms (FrmOdalar.cs, FrmCihazlar.cs).
CREATE DATABASE AkilliEvDb;
GO
USE AkilliEvDb;
GO

-- Rooms
CREATE TABLE Odalar (
    OdaID   INT IDENTITY(1,1) PRIMARY KEY,
    OdaAdi  NVARCHAR(50) NOT NULL
);

-- Devices: each device belongs to a room
CREATE TABLE Cihazlar (
    CihazID   INT IDENTITY(1,1) PRIMARY KEY,
    CihazAdi  NVARCHAR(50) NOT NULL,
    Tuketim   INT NOT NULL,                 -- power consumption in watts
    Durum     NVARCHAR(10) NOT NULL,        -- 'Açık' (on) or 'Kapalı' (off)
    OdaID     INT NOT NULL REFERENCES Odalar(OdaID)
);
