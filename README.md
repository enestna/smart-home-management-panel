# Smart Home Management Panel

A Windows Forms desktop application for managing the rooms and devices of a smart home, backed by Microsoft SQL Server. The user interface is in Turkish.

## Features
- **Room management:** add, update, delete and list rooms
- **Device management:** add, update and delete devices with their room, power consumption (watts) and status (on/off)
- **Status views:** separate screens for devices that are currently on and devices that are off
- **Safe queries:** all database queries are parameterized, which protects against SQL injection

## Tech stack
C# · .NET Framework 4.7.2 · Windows Forms · Microsoft SQL Server (ADO.NET)

## Getting started
1. **Requirements:** Windows, Visual Studio 2017 or newer with the ".NET desktop development" workload, SQL Server Express.
2. **Create the database:** run [`database/schema.sql`](database/schema.sql) in SQL Server Management Studio.
3. **Set your server name:** the forms connect with
   `Data Source=ENES\SQLEXPRESS01;Initial Catalog=AkilliEvDb;Integrated Security=True`.
   Replace `ENES\SQLEXPRESS01` with your own SQL Server instance in `FrmOdalar.cs`, `FrmCihazlar.cs`, `FrmAcikCihazlar.cs` and `FrmKapaliCihazlar.cs`.
4. Open `AkilliEvOtomasyonu.csproj`, build and run (F5).

## Project structure
| File | Purpose |
|---|---|
| `FrmAnaMenu` | Main menu |
| `FrmOdalar` | Room management |
| `FrmCihazlar` | Device management |
| `FrmAcikCihazlar` / `FrmKapaliCihazlar` | Devices that are on / off |
| `database/schema.sql` | Database tables |

## What I learned
- Designing a small relational schema where devices belong to rooms (foreign key) and joining the two tables
- Writing CRUD operations with ADO.NET and parameterized queries
- Building a multi-form desktop interface with Windows Forms

**Next improvement:** move the connection string into `App.config` so it is defined in one place instead of four.
