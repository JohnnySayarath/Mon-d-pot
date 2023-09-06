// builder => sert � construire et configurer l'application
using DemoASPnetCoreMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Ajout de services au conteneur de d�pendances
builder.Services.AddControllersWithViews();

//Injection de d�pences
// pour enregistrer un service dans le conteneur de d�pendances une service est une instance d'une classe qui a des m�thodes utiles pour notre app
// exemple : applicationDbContext, UploadService, ContactRepository, une fausse base de donn�es (FakeDb)
builder.Services.AddSingleton<FakeContactDb>();

var app = builder.Build(); //m�thode qui passe d'une application "en construction" � une application pr�te

// Ajout de Middlewares et configuration post build

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ajout de la route par d�faut (default)
// elle d�finit un pattern de base pour l'acc�s � nos controllers => /<nom du controller>/<nom de l'action>
// Si les valeur ne sont pas saisies on utilise les valeur par d�faut Home et Index
// cela permet donc de d�finir les �quivalences
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
