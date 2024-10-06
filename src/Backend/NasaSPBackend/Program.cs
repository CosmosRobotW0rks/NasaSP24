
using NasaSPBackend.Chatbot;
using NasaSPBackend.Chatbot.ChatbotSessionTracker;

namespace NasaSPBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            InitChatbotService(builder);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }


        private static void InitChatbotService(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ChatbotService>();
            builder.Services.AddSingleton<ChatbotSessionTrackerService>();
        }
    }
}
