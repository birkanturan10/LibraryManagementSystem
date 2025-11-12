using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.Business.Concrete;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.DataAccess.Concrete.EntityFramework;
using LibraryManagementSystem.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekle
builder.Services.AddControllersWithViews();

// Veritabaný baðlantýsý (EF Core)
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryDbConnection")));

// Dependency Injection (Business ve DataAccess katmanlarý)
builder.Services.AddScoped<IBookService, BookManager>();
builder.Services.AddScoped<IMemberService, MemberManager>();
builder.Services.AddScoped<IBorrowRecordService, BorrowRecordManager>();

builder.Services.AddScoped<IBookDal, EfBookDal>();
builder.Services.AddScoped<IMemberDal, EfMemberDal>();
builder.Services.AddScoped<IBorrowRecordDal, EfBorrowRecordDal>();

var app = builder.Build();

// Hata yönetimi
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Middleware pipeline
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Varsayýlan route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Book}/{action=Index}/{id?}");

app.Run();
