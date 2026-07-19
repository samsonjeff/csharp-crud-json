# Medical Records Management System

&gt; A C# WinForms CRUD application with Firebase Realtime Database integration for managing student and employee medical records.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Firebase](https://img.shields.io/badge/Firebase-FFCA28?style=for-the-badge&logo=firebase&logoColor=black)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

---

## Table of Contents

- [Overview](#overview)
- [Features & Capabilities](#features--capabilities)
- [Security](#security)
- [Screenshots](#screenshots)
- [Prerequisites](#prerequisites)
- [Installation & Setup](#installation--setup)
- [Environment Configuration](#environment-configuration)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Firebase Database Schema](#firebase-database-schema)
- [Troubleshooting](#troubleshooting)
- [Contributing](#contributing)
- [License](#license)
- [Author](#author)

---

## Overview

This Medical Records Management System is a desktop application built with **C# WinForms** and **Firebase Realtime Database**. It provides a complete CRUD interface for tracking medical visits of students and employees within an institution.

The application supports dual patient types (Students & Employees), features live search with auto-highlighting, and maintains secure credential management through environment files.

---

## Features & Capabilities

### Core CRUD Operations
| Operation | Description |
|-----------|-------------|
| **Create** | Add new medical records with auto-generated IDs (`MR-0001`, `MR-0002`, ...) |
| **Read** | Fetch and display all records with left-join logic (shows patients even without medical history) |
| **Update** | Edit existing medical records in-place |
| **Delete** | Remove records with confirmation dialog |

### Patient Management
- **Dual Patient Types**: Toggle between **Student** and **Employee** modes
- **Auto-populated Fields**: Patient info (Name, Department) auto-fills from the database
- **Medical Record Tracking**: Date, Purpose, Remarks, Time In/Out, Status

### Advanced Features
- **Live Search**: Type in the search box to instantly find and promote matching records to the top row
- **Smart Highlighting**: Matching rows are highlighted in amber and scrolled into view
- **Auto-Refresh**: Grid automatically reloads after Create, Update, or Delete operations
- **DataGridView Integration**: Sortable, selectable rows with cell-click editing

### UI/UX
- Clean WinForms interface with panel layouts
- Read-only fields for auto-populated data (prevents accidental edits)
- Confirmation dialogs for destructive actions
- Status indicators and user feedback via MessageBox

---

## Security

### Credential Protection
| Layer | Implementation |
|-------|---------------|
| **Environment Variables** | Firebase secrets stored in `.env` file (never committed) |
| **Git Ignore** | `.env` and `appsettings.json` excluded from version control |
| **No Hardcoded Secrets** | AuthSecret & BasePath loaded at runtime from environment |

### Best Practices
- `.env` file uses `Copy to Output Directory: Copy if newer`
- `.gitignore` explicitly excludes sensitive configuration files
- Custom `LoadEnv()` parser strips quotes and handles whitespace safely

---

## Screenshot

&gt; <img width="1918" height="1078" alt="image" src="https://github.com/user-attachments/assets/c9989db1-c062-49f2-a06f-bd98258254d4" />


