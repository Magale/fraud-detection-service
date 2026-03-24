# Fraud Detection Service (C# / .NET 8)

A production-ready fraud detection system that processes transaction events, applies rule-based fraud detection, and exposes APIs for retrieval and analysis.

---

## Overview

This system ingests financial transactions, evaluates them against configurable fraud rules, and flags suspicious activity.

It is designed with scalability, extensibility, and clean architecture principles in mind.

---

## Features

- Rule-based fraud detection engine (Strategy Pattern)
- Pluggable fraud rules (easy to extend)
- RESTful API (ASP.NET Core)
- PostgreSQL database (EF Core)
- Dockerized environment
- JWT Authentication (configurable)
- Swagger API documentation

