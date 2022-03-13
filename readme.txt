dotnet ef migrations add IntialCreate --startup-project web --project data --context ShopContext


dotnet ef migrations add IntialCreate --startup-project web --project web--context ApplicationContext


dotnet ef database update --project web --context ShopContext

dotnet ef database update --project web --context ApplicationContext
