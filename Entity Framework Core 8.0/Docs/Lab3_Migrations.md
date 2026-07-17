# Lab 3 - Entity Framework Core Migrations

## Objective

Create the database schema using Entity Framework Core Migrations.

## Commands Executed

Create Migration

```bash
dotnet ef migrations add InitialCreate
```

Update Database

```bash
dotnet ef database update
```

## Database Created

Database Name:

```
RetailInventoryDB
```

Tables Generated

- Categories
- Products
- __EFMigrationsHistory

## Purpose of Migrations

Entity Framework Core Migrations keep the database schema synchronized with the C# model classes.

Benefits:

- Version control for database schema
- Automatic table creation
- Automatic schema updates
- Easy database deployment

## Outcome

Successfully generated SQL Server database and tables using Entity Framework Core Migrations.