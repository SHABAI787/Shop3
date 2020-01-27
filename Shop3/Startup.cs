using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop3.Data;
using Shop3.Data.Interfaces;
using Shop3.Data.Mocks;
using Shop3.Data.Repository;

namespace Shop3
{
    public class Startup
    {
        //������ ���������� �� dbsettings.json ����� �������� � ��� ����������
        private IConfigurationRoot _confString;

        /// <summary>
        /// �������� ������ �� ����� dbsettings.json
        /// </summary>
        /// <param name="hostEnv"></param>
        public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //��������� ����� SQL ������ �� ����������. ������ ���� �� dbsettings.json
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

            //����������� ������ � ����������
            services.AddTransient<IAllCars, CarsRepository>();

            //����������� ������ � ����������
            services.AddTransient<ICarsCategory, CategoryRepository>();

            //���������� ��������� MVC
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //���������� ������
            app.UseDeveloperExceptionPage();

            //���������� ���� ���������(����� ��� 404 ��� 200)
            app.UseStatusCodePages();

            //��������� ���������� ����������� ������
            app.UseStaticFiles();

            //��������� ���� ������� �� ������ ����������� URL ������
            app.UseMvcWithDefaultRoute();

           
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DbObjects.Initial(content);
            }
        }
    }
}
