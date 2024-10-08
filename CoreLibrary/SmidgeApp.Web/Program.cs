using Smidge;

var builder = WebApplication.CreateBuilder(args);

// Smidge ayarlar?n? yap?land?r
builder.Services.AddSmidge(builder.Configuration.GetSection("smidge"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting(); // Routing middleware'ini ekliyoruz

app.UseSmidge(bundle =>
{
    // JavaScript bundle'ini tan?ml?yoruz
    bundle.CreateJs("my-js-bundle", "~/js/site.js", "~/js/site2.js");
});

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
