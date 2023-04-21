using Microsoft.EntityFrameworkCore;
using PatientAPI.Context;
using PatientAPI.Repositary;
using PatientAPI.Services;

namespace PatientAPI
{
    public class Program
    {
       public static object JwtBearerDefaults { get; private set; }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddScoped<IDoctorRepositary, DoctorRepositary>();
            builder.Services.AddScoped<IDoctorService, DoctorService>();
            builder.Services.AddScoped<IPatientRepositary, PatientRepositary>();
            builder.Services.AddScoped<IPatientService, Patientservice>();
            builder.Services.AddScoped<IAdminRepositary, AdminRepositary>();
            builder.Services.AddScoped<IAdminService,AdminService>();
            builder.Services.AddCors();
            string LocalDConnection = builder.Configuration.GetConnectionString("WebApiConnection");
            builder.Services.AddDbContext<Dbcontext>(options => options.UseSqlServer(LocalDConnection));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            /*builder.Services.AddAuthentication(u =>
               {
                   u.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationSchme;
                   u.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               }).AddJwtBearer(u => u.TokenValidationParameters = tokenValidationParameters);
*/
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(
                c => c.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            app.UseHttpsRedirection();

            app.UseAuthorization();
              

            app.MapControllers();

            app.Run();
        }
    }
}