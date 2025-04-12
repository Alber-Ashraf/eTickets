# 🎫 eTickets

**eTickets** is a full-stack ASP.NET Core MVC web application designed for managing event ticketing. It allows users to browse events, view details, and purchase tickets, while administrators can manage events, venues, and ticket sales.

---

## 🚀 Features

- 🧑‍💼 **User Authentication**: Register, login, and manage user profiles.
- 🎟️ **Event Listings**: Browse upcoming events with detailed information.
- 🛒 **Ticket Purchasing**: Add tickets to a shopping cart and proceed to checkout.
- 📊 **Admin Dashboard**: Create, update, and delete events and manage ticket sales.
- 🔒 **Role-Based Access Control**: Differentiate between regular users and administrators.
- 📧 **Email Notifications**: Receive confirmations and updates via email.
- 📈 **Responsive Design**: Optimized for both desktop and mobile devices.

---

## 🛠️ Tech Stack

| Technology           | Description                          |
|----------------------|--------------------------------------|
| ASP.NET Core MVC     | Web application framework            |
| Entity Framework Core| Object-relational mapping (ORM)      |
| SQL Server           | Relational database management system|
| Bootstrap            | Front-end component library          |
| Identity             | Authentication and authorization     |
| Razor Pages          | Dynamic page generation              |

---

## 🧱 Project Structure
eTickets/
├── Controllers/
├── Models/ 
├── Views/ 
├── Data/ 
│ 
└── ApplicationDbContext.cs 
├── wwwroot/ 
├── appsettings.json 
└── Program.cs

---

## ⚙️ Setup Instructions

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/Alber-Ashraf/eTickets.git
   cd eTickets
