# Browse to dotnet folder 
cd D:\MyProject\dotnet

# Rebuild the solutions 
dotnet build ./ECommerce.Domain/ECommerce.Domain.csproj
dotnet build ./ECommerce.Persistence/ECommerce.Persistence.csproj
dotnet build ./ECommerce.ApiServices/ECommerce.ApiServices.csproj


# Create migration
dotnet ef migrations add InitialCreate --project ./ECommerce.DAL/ECommerce.DAL.csproj --startup-project ./ECommerce.ApiServices/ECommerce.ApiServices.csproj

# Rebuild the solutions 
dotnet build ./ECommerce.Domain/ECommerce.Domain.csproj
dotnet build ./ECommerce.Persistence/ECommerce.Persistence.csproj
dotnet build ./ECommerce.ApiServices/ECommerce.ApiServices.csproj
dotnet build ./ECommerce.Seeding/ECommerce.Seeding.csproj


# Update database
dotnet ef database update --project ./ECommerce.Persistence/ECommerce.Persistence.csproj --startup-project ./ECommerce.ApiServices/ECommerce.ApiServices.csproj

# Run seeding process
dotnet ./lib/Debug/Ecommerce.Seeding.dll