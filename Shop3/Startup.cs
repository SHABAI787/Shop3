using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Shop3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Подключаем поддержку MVC
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //отображаем ошибки
            app.UseDeveloperExceptionPage();

            //отображать коды страничек(таких как 404 или 200)
            app.UseStatusCodePages();

            //разрешаем подлючение статических файлов
            app.UseStaticFiles();

            //Благодаря этой функции мы сможем отслеживать URL адресс
            app.UseMvcWithDefaultRoute();
        }
    }
}
