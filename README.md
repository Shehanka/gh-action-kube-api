# Cashflow API

#### DB Scripts
##### Generate Table Create DB Migration
```shell
dotnet ef migrations add InitialCreate --context DbConnection
```

#### Apply Initial Migration to DB
```shell
dotnet ef database update --context DbConnection
```