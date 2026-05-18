Project Overview:
This is a web-based Audiobook application built using ASP.NET Core MVC and SQL Server.
Users can upload PDF books, read them online, and listen to the content using text-to-speech functionality.

Features
📄 Upload PDF books
💾 Store book details in SQL Server
📚 View list of uploaded books
🔊 Read PDF content inside browser
🎧 Text-to-Speech (Listen Book feature)
🌐 Simple and user-friendly UI

Tech Stack:
ASP.NET Core MVC (.NET 8)
C#
Entity Framework Core
SQL Server
HTML, CSS, JavaScript
iText7 (PDF reading)

Project Structure:
Controllers → Handles application logic
Models → Database entities (AudioBook)
Views → UI pages (Create, Index, ReadPdf)
wwwroot → Stores uploaded PDF files
Data → DbContext for database

Clone repository:
git clone https://github.com/Rachanakm1311/Audiobook.git

Open project in Visual Studio
Update connection string in appsettings.json

Run migrations
Add-Migration InitialCreate
Update-Database
Run project
Ctrl + F5

How It Works:
Upload a PDF book
Data is saved in database
PDF stored in wwwroot/pdfs
Click Listen Book
App extracts text and reads aloud 🎧

Future Improvements
🔐 Login/Register system
☁️ Cloud PDF storage
🤖 AI voice narration
📱 Mobile responsive UI
🔍 Book search feature



