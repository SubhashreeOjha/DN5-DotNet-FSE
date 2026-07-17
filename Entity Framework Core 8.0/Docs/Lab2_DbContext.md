# Lab 2 - Creating DbContext

## Objective
Create a DbContext class to establish communication between the application and SQL Server.

## Models Created

### Category
- Id
- Name
- Products (Navigation Property)

### Product
- Id
- Name
- Price
- CategoryId
- Category (Navigation Property)

## AppDbContext

Created AppDbContext inside the Data folder.

DbSets:

```csharp
public DbSet<Product> Products { get; set; }

public DbSet<Category> Categories { get; set; }
```

Connection String:

```csharp
optionsBuilder.UseSqlServer(
@"Server=DESKTOP-Q9JDFMI;
Database=RetailInventoryDB;
Trusted_Connection=True;
TrustServerCertificate=True;");
```

## Outcome

Successfully configured Entity Framework Core to communicate with SQL Server using DbContext.