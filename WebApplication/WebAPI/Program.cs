var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ controllers vào container DI
builder.Services.AddControllers();

var app = builder.Build();

// Sử dụng đường dẫn để map các controller
app.MapControllers();

app.Run();
