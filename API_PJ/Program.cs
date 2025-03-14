using API_PJ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ MVC vào container
builder.Services.AddControllers();

// Bật Swagger để kiểm tra API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Kết nối Database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Cấu hình CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

// Chỉ bật HTTPS Redirection khi chạy local
if (app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_PJ v1"));
}

// Bật CORS
app.UseCors("AllowAll");

// Bật Authorization
app.UseAuthorization();

// Cấu hình Kestrel để lắng nghe trên mọi địa chỉ IP
builder.WebHost.ConfigureKestrel(options =>
{
    var port = Environment.GetEnvironmentVariable("PORT") ?? "5000"; // Lấy PORT từ biến môi trường
    options.ListenAnyIP(int.Parse(port)); // Cho phép lắng nghe trên tất cả địa chỉ IP
});


app.MapControllers();

app.Run();
