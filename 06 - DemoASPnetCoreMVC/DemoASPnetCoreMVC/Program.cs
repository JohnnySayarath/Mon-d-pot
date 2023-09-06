// builder => sert à construire et configurer l'application
using DemoASPnetCoreMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Ajout de services au conteneur de dépendances
builder.Services.AddControllersWithViews();

//Injection de dépences
// pour enregistrer un service dans le conteneur de dépendances une service est une instance d'une classe qui a des méthodes utiles pour notre app
// exemple : applicationDbContext, UploadService, ContactRepository, une fausse base de données (FakeDb)
builder.Services.AddSingleton<FakeContactDb>();

var app = builder.Build(); //méthode qui passe d'une application "en construction" à une application prête

// Ajout de Middlewares et configuration post build

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ajout de la route par défaut (default)
// elle définit un pattern de base pour l'accès à nos controllers => /<nom du controller>/<nom de l'action>
// Si les valeur ne sont pas saisies on utilise les valeur par défaut Home et Index
// cela permet donc de définir les équivalences
// "/" == "/Home/" == "/Home/Index"
// "/Contact" == "/Contact/Index"
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "customRoute",
//    pattern: "test",
//    new
//    {
//        Controller = "Home",
//        Action = "Privacy"
//    });


app.Run();
