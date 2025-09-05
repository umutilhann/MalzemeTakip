📋 Project Overview
This project was developed to create an integrated data management system between the production line, logistics processes, and management units of a manufacturing company.

✨ Features
🏭 Production Module: Recording of produced material information

🚚 Logistics Module: Approval and rejection of materials

👔 Administration Module: Monitoring and reporting of all processes

🗃️ Dual Database Architecture: Two separate databases for data security

🔐 Role-Based Access: Personnel, HR, and Admin roles

🛡️ Security: Parameterized queries (SQL Injection protection)

🛠️ Technologies
Frontend: C# Windows Forms (.NET Framework)

Backend: MSSQL

Security: Parameterized queries (SQL Injection protection)

💾 Installation Requirements
.NET Framework 4.8 or later

MSSQL Server 2012 or later

Visual Studio 2019 or later

🗄️ Database Setup
+ -- Temporary database for Production and Logistics
CREATE DATABASE UretimLojistikDB;

+ -- Main database (For administration)
CREATE DATABASE AnaVeritabaniDB;

+ -- Run the SQL files in the DatabaseScripts folder to create the tables

⚙️ Configuration
Configure connection strings in the app.config file:
+ <configuration>
  <connectionStrings>
    <.add name="UretimLojistikDB" 
         connectionString="Data Source=.;Initial Catalog=UretimLojistikDB;Integrated Security=True"/>
    <.add name="AnaVeritabaniDB" 
         connectionString="Data Source=.;Initial Catalog=AnaVeritabaniDB;Integrated Security=True"/>
  </connectionStrings>
</configuration>

🚀 Usage
Production Module:
Enter the material name, quantity, and production date

Save the data to the temporary database with the Save button

Logistics Module:
List pending records

Approve or reject records

Approved records are transferred to the main database

Administration Module:
View all approved records

Create reports

View system statistics

📊 System Architecture
The system utilizes a dual-database architecture for enhanced security:

UretimLojistikDB: Temporary database for production and logistics operations

AnaVeritabaniDB: Main database for administrative functions and reporting

🔐 Security Features
Parameterized queries to prevent SQL injection attacks

Role-based access control with three distinct user roles

Separate database connections for different security contexts

Input validation and sanitization

* 📁 Project Structure
+ 📦 IntegratedProductionSystem
+ ├── 📂 ProductionModule
+ │   ├── ProductionForm.cs
+ │   └── ProductionController.cs
+ ├── 📂 LogisticsModule
+ │   ├── LogisticsForm.cs
+ │   └── LogisticsController.cs
+ ├── 📂 AdministrationModule
+ │   ├── AdminForm.cs
+ │   └── ReportGenerator.cs
+ ├── 📂 DatabaseScripts
+ │   ├── CreateTables.sql
+ │   └── SampleData.sql
+ ├── 📂 Models
+ │   ├── Material.cs
+ │   ├── ProductionRecord.cs
+ │   └── User.cs
+ └── app.config
