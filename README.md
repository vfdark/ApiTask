# SimpleApiDemo API (ApiTask)

A **simple .NET 10 API** for managing **Students** and **Courses**, built with Controllers and Swagger UI for testing.

---

## 🌟 Features

- **StudentsController:** Manage students (GET, POST, DELETE)  
- **CoursesController:** Manage courses (GET, POST, DELETE)  
- **Swagger UI:** Test APIs easily  
- In-memory string-based storage (no models required)

---

## ⚡ Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)  
- Code editor (Visual Studio, VS Code, Rider)  
- Terminal / Command Prompt  

---

## 🚀 How to Run Locally

1. Clone the repository:

```bash
git clone https://github.com/vfdark/ApiTask.git
cd ApiTask
Restore dependencies:

dotnet restore


Build the project:

dotnet build


Run the API:

dotnet run


You should see:

Now listening on: http://localhost:5127
🌐 Test the API
1️⃣ Swagger UI

Open your browser:

http://localhost:5127/swagger

2️⃣ Using curl

Get all students:

curl http://localhost:5127/api/students


Add a student:

curl -X POST http://localhost:5127/api/students -H "Content-Type: application/json" -d "\"Sami\""


Delete a student:

curl -X DELETE http://localhost:5127/api/students/Sara


Get all courses:

curl http://localhost:5127/api/courses


Add a course:

curl -X POST http://localhost:5127/api/courses -H "Content-Type: application/json" -d "\"AI\""


Delete a course:

curl -X DELETE http://localhost:5127/api/courses/Math

3️⃣ Using Postman

Open Postman

Create a request:

URL: http://localhost:5127/api/students or /api/courses

Method: GET, POST, or DELETE

For POST: Body → raw → JSON → "StudentName" or "CourseName"

📌 API Endpoints
Controller	Method	Route	Description
StudentsController	GET	/api/students	Get all students
StudentsController	POST	/api/students	Add a new student
StudentsController	DELETE	/api/students/{name}	Delete a student by name
CoursesController	GET	/api/courses	Get all courses
CoursesController	POST	/api/courses	Add a new course
CoursesController	DELETE	/api/courses/{course}	Delete a course by name
⚠️ Notes

Uses in-memory storage, so data is lost when the server stops.

No models required; everything uses simple strings.

Swagger UI works out-of-the-box.


