using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Program>());

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

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");





// baseurl/index/salam/home
// baseurl/{action}/salam/{controller}
// baseurl/anasehife
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("custom2", "anasehife", new { Controller = "Home", Action = "Index" });
    endpoints.MapControllerRoute("custom1", "{action}/salam/{controller}/{a?}/{b?}");
    endpoints.MapControllers();
    endpoints.MapDefaultControllerRoute();
});

app.Run();
