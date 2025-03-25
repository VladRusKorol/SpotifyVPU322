using SpotifyVPU322.DataBase;
using SpotifyVPU322.Repositories;
using SpotifyVPU322.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDBContext>();
builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();

/*
    ������ ����� ���� ��������, ��� ���������������� MVC, � ���������, 
    ��������� ������������ � �������������, ������������ � ���������� � ���� ������� - 
    � ������ ������ � ������� ������ services.AddControllersWithViews(). 
    ����� ����� �� ����� ������������ ���������������� ���������� MVC.
 */
builder.Services.AddControllersWithViews();
var app = builder.Build();
/*
    ����� ����, ����� ������� ���������� �� ������������� ������� � ������������� 
    ����������� ����� MapControllerRoute(). ����� ������� �������� - name � ����� ���������� �������� �������� - � ������ ������ "default". 
    ����� ������ �������� - �������� pattern ���������� ������ ��������, �������� ������ ��������������� ������. 
    � �������� ������� �������� ����������� ������ "{controller=Home}/{action=Index}/{id?}", 
    ������� ������������ �������������� ������. � ��� ������ ������� ������������ ����������, 
    ������ ������� - ����� �����������, � ������ - �������������� ��������. 
    ��� ���� ���� � ������� �� ������� �������� (��������, ��������� ���� � ����� ���-����������), 
    �� � �������� ����������� �� ��������� ����������� HomeController, � � �������� ��� ������ - ����� Index.
 */
app.MapControllerRoute( name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
