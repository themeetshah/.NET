var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ============ Add authentication services ============
builder.Services.AddAuthentication("MyCookiesAuth").AddCookie("MyCookiesAuth", options =>
{
    options.Cookie.Name = "MyCookiesAuth";
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

// ============ Add authorization policies ============
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("PEONPolicy", policy => policy.RequireClaim("Department", "PEON"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// ============ Added authentication middleware ===========
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
