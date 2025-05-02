
# 🛡️ Self-Auditing Integration Proxy

## Overview

The **Self-Auditing Integration Proxy** is a minimal .NET-based proxy that provides dynamic auditing and validation for integration pipelines. It allows you to ensure **data integrity**, **security**, and **observability** by logging each request, verifying its content, and validating JSON payloads on the fly.

This is especially useful for enterprises with microservices or API-based integrations, where ensuring data contracts are met and ensuring request logs are properly audited is critical.

## 🚀 Features

- **Middleware-based transparent auditing**: Logs every incoming request and validates JSON payload.
- **Request body validation**: Basic JSON schema validation to ensure data integrity.
- **Pluggable**: Can be integrated into any API gateway, service mesh, or microservice architecture.

## 🧑‍💻 How to Run

To run the Self-Auditing Integration Proxy locally, follow the steps below:

### 1. Clone the Repository
Clone the repository to your local machine:
```bash
git clone https://github.com/MahendhiranK/SelfAuditingProxy.git
cd SelfAuditingProxy
```

### 2. Run the Application

Ensure you have [.NET 8.0 SDK](https://dotnet.microsoft.com/download) installed. Run the following command:
```bash
dotnet run
```

### 3. Test the Proxy
You can test the proxy by sending a POST request using `curl`:

```bash
curl -X POST http://localhost:5000/proxy -H "Content-Type: application/json" -d '{"key": "value"}'
```

This will trigger the proxy to log the request and validate the JSON body.

---

## 📂 Project Structure

- **Program.cs**: This is the main entry point of the application. It sets up the web server and configures middleware.
- **AuditMiddleware.cs**: This is a custom middleware that audits each incoming request, validates the JSON body, and logs the results.
- **SelfAuditingProxy.csproj**: The project file for .NET 8.0.
- **README.md**: This documentation.

---

## 🧠 Extensible Ideas

This project is intended as a starting point for integrating dynamic auditing and validation into your API-driven systems. Some ideas to extend the functionality include:

- **OpenAPI schema validation**: Validate incoming requests against OpenAPI specifications to ensure the contract is respected.
- **Logging to external stores**: Log the audit data to an external logging system like **Azure Log Analytics**, **ElasticSearch**, or **Splunk**.
- **Role-based access policy**: Implement role-based access control (RBAC) in the middleware to ensure that only authorized users can interact with the proxy.
- **Rate limiting**: Add rate limiting to prevent abuse of the proxy service.
- **Request tracing**: Implement distributed tracing (using something like **OpenTelemetry**) to trace requests across microservices.

---

## 🔧 Requirements

- .NET 8.0 SDK or later
- Basic knowledge of API gateways and microservices architecture

---

## 📜 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

**Mahendhiran K**  
[LinkedIn](https://www.linkedin.com/in/mahendhiran-k/) | [GitHub](https://github.com/MahendhiranK)
