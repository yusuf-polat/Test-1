var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddControllersWithViews(); // S
builder.Services.AddRazorPages(); //Sadece Razor Page Çalýþtýrmak Ýçin
var app = builder.Build();

//app.MapGet("/", () =>
//{
//    var s1 = 10;
//    var s2 = 20;
//    var toplam = s1 + s2;
//    return $"Sayýlarýn Toplamý : {toplam}";
//});


app.MapControllerRoute(
    name: "defult",
    pattern: "{controller}/{action}"
    );
app.Run();
