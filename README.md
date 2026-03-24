# Fraud Detection Service (C# / .NET 8)

## Overview

This project is a fraud detection service that processes transaction events, applies rule-based checks, and flags potentially fraudulent activity. The system exposes REST APIs for creating and retrieving transactions.

---

## Features

- Rule-based fraud detection engine (strategy pattern)
- Pluggable fraud rules
- ASP.NET Core Web API
- PostgreSQL database
- Docker-based setup
- Swagger API documentation

---

## Architecture

Client -> Controller -> Fraud Engine -> Rules -> Database -> Response

Components:

- Controllers: Handle HTTP requests
- Fraud Engine: Executes fraud detection rules
- Rules: Independent fraud checks
- Database: PostgreSQL for persistence

---

## Prerequisites

- Docker
- Docker Compose

---

## Build and Run (Docker)

1. Navigate to the project directory:

```bash
cd fraud_detection_enterprise

2. Start the system:

docker-compose up

3. Wait for containers to start, then open:

http://localhost:5000/swagger

4. Create Transaction

POST /api/transactions

Example request:

{
  "transactionId": "tx1001",
  "userId": "user1",
  "amount": 15000,
  "category": "crypto",
  "timestamp": "2026-03-23T10:00:00",
  "location": "Cape Town"
}

5. Get All Transactions

GET /api/transactions

6. Get Fraudulent Transactions

GET /api/transactions/fraud

7. Testing the System

You can test the system using Swagger.

Steps
Open:
http://localhost:5000/swagger
Select an endpoint
Click "Try it out"
Execute the request

Test Scenarios
High Amount Fraud
Amount greater than 10000
Expected: flagged as fraud
High Frequency Fraud
Send multiple transactions quickly for same user
Expected: flagged as fraud
Risky Category
Category = crypto or gambling
Expected: flagged as fraud
Normal Transaction
Small amount, normal category
Expected: not fraud

8. Stopping the System
 docker-compose down
