# Medical Clinic
## Description
The main idea of this project is to create a Patient Management System for Medical Clinic. The system should be able to:
- Add a new patient
- Remove a patient
- Update patient information
- Display all patients (including pagination)
- Sort patients
## Motivation
This project is part of the recruitment process for Esatto Poland. The main goal, obviously, was to fulfill the requirements of the task. 
## Technologies
- C#
- .NET Core 8.0
- Entity Framework
- Docker
- PostgreSQL
## How to run
In order to run the project, you need to have Docker (and Docker Compose) installed on your machine. After that, you can simply run the following command in the /Docker directory:
```bash
docker-compose up
```
With the database up and running, you can now run the project. To do so, you need to navigate to the /MedicalClinic directory and run the following command:
```bash
dotnet run
```
This will start the application on the `http://localhost:5111`.

## Screenshots
Patient list:
![patient list](image-3.png)
Add patient:
![add patient](image-2.png)