# 🛡️ Self-Auditing Integration Proxy

A minimal .NET-based proxy that performs dynamic auditing and JSON validation for integration pipelines. Ideal for observability, security, and data integrity in enterprise APIs.

## 🔧 Features
- Middleware-based transparent auditing
- Request body validation (basic schema check)
- Pluggable into any API gateway or integration system

## 🚀 Run It
```bash
dotnet run
```

Send a test request:
```bash
curl -X POST http://localhost:5000/proxy -H "Content-Type: application/json" -d '{"key": "value"}'
```

## 📂 Structure
- `Program.cs`: Entry point
- `AuditMiddleware.cs`: Custom middleware for auditing and validation

## 🧠 Extensible Ideas
- Add OpenAPI schema validation
- Log to external store (e.g., Azure Log Analytics)
- Apply role-based access policy during proxying

---
MIT License © Mahendhiran K
