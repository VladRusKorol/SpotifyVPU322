using SpotifyVPU322.DataBase;
using SpotifyVPU322.Repositories;
using SpotifyVPU322.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDBContext>();
builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();

/*
    Прежде всего надо отметить, что функциональность MVC, в частности, 
    поддержка контроллеров и представлений, подключается в приложение в виде сервиса - 
    в данном случае с помощью вызова services.AddControllersWithViews(). 
    После этого мы можем использовать функциональность фреймворка MVC.
 */
builder.Services.AddControllersWithViews();
var app = builder.Build();
/*
    Кроме того, чтобы связать приходящие от пользователей запросы с контроллерами 
    применяется метод MapControllerRoute(). Через перевый параметр - name в метод передается название маршрута - в данном случае "default". 
    Через второй параметр - параметр pattern передается шаблон маршрута, которому должен соответствовать запрос. 
    В качестве шаблона маршрута применяется шаблон "{controller=Home}/{action=Index}/{id?}", 
    который представляет трехсегментный запрос. В нем первый сегмент представляет контроллер, 
    второй сегмент - метод контроллера, а третий - необязательный параметр. 
    При этом если в запросе не указаны сегменты (например, обращение идет к корню веб-приложения), 
    то в качестве контроллера по умолчанию применяется HomeController, а в качестве его метода - метод Index.
 */
app.MapControllerRoute( name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
