var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Đọc cấu hình Kestrel từ appsettings
// builder.WebHost.ConfigureKestrel(options =>
// {
//     var kestrelConfig = builder.Configuration.GetSection("Kestrel");
//     if (kestrelConfig.Exists())
//     {
//         options.Configure(kestrelConfig);
//     }
// });
builder.WebHost.UseUrls("http://0.0.0.0:5158");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
