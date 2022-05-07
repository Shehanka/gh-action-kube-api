# Cashflow API
[![Build and deploy an app to AKS](https://github.com/Shehanka/cashflow-api/actions/workflows/azure-kubernetes-service.yml/badge.svg)](https://github.com/Shehanka/cashflow-api/actions/workflows/azure-kubernetes-service.yml)
### Learning

- [Persist and retrieve relational data with Entity Framework Core](https://docs.microsoft.com/en-us/learn/modules/persist-data-ef-core/)

#### DB Scripts

##### Generate Table Create DB Migration

```shell
dotnet ef migrations add InitialCreate --context DbConnection
```

#### Apply Initial Migration to DB

```shell
dotnet ef database update --context DbConnection
```
