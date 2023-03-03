using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Net.Sockets;
using System.Text;
using ZhaoxiFlower.Common;
using ZhaoxiFlower.Model;
using ZhaoxiFlower.Service;
using ZhaoxiFlower.Service.Config;
using ZhaoxiFlower.Service.Jwt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
//����JSON�������ڸ�ʽ
builder.Services.AddControllers().AddNewtonsoftJson(Options => 
{
    Options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    Options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
}); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//ע�Ỻ�����
builder.Services.AddMemoryCache();

//��ӿ������
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", opt => opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().WithExposedHeaders("X-Pagination"));
});
//ע����־
builder.Logging.AddLog4Net("Config/log4net.Config");
//ע��Automapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfigs));
//ע��JWT
builder.Services.Configure<JWTTokenOptions>(builder.Configuration.GetSection("JWTTokenOptions"));

//ע��service��ķ���
//builder.Services.AddTransient<IFlowerService, FlowerService>();
//builder.Services.AddTransient<IUserService, UserService>();
//builder.Services.AddTransient<IOrderService, OrderService>();
//builder.Services.AddTransient<ICustomJWTService, CustomJWTService>();
//ͨ��Autofacע��
builder.Host
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacModuleRegister());
    });

//jwtУ��
{
    //���Ӽ�Ȩ�߼�
    JWTTokenOptions tokenOptions = new JWTTokenOptions();
    builder.Configuration.Bind("JWTTokenOptions", tokenOptions);
    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)//Scheme
     .AddJwtBearer(options =>  //���������õļ�Ȩ���߼�
     {
         options.TokenValidationParameters = new TokenValidationParameters
         {
             //JWT��һЩĬ�ϵ����ԣ����Ǹ���Ȩʱ�Ϳ���ɸѡ��
             ValidateIssuer = true,//�Ƿ���֤Issuer
             ValidateAudience = true,//�Ƿ���֤Audience
             ValidateLifetime = true,//�Ƿ���֤ʧЧʱ��
             ValidateIssuerSigningKey = true,//�Ƿ���֤SecurityKey
             ValidAudience = tokenOptions.Audience,//
             ValidIssuer = tokenOptions.Issuer,//Issuer���������ǰ��ǩ��jwt������һ��
             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))//�õ�SecurityKey 
         };
     });
}

//����CORS�������������
//string[] urls = new[] { "http://localhost:8080/" };  //������ʺ�˽ӿڵ�ǰ������

//builder.Services.AddCors(options =>
//options.AddDefaultPolicy(builder =>
//builder.WithOrigins(urls)
//    .AllowAnyMethod()
//    .AllowAnyHeader()
//    .AllowCredentials()));

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("cors", builder =>
//    {
//        builder.WithMethods("GET", "POST", "HEAD", "PUT", "DELETE", "OPTIONS")
//    //.AllowCredentials()//ָ������cookie
//    .AllowAnyOrigin(); //�����κ���Դ����������
//    });
//});


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#region ��Ȩ��Ȩ
app.UseAuthentication();
app.UseAuthorization();
#endregion
//app.UseCors();
//app.UseHttpsRedirection();

//app.UseRouting();
//app.UseAuthorization();
//app.UseAuthentication();
//����Cors
//app.UseCors("cors");
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});


app.MapControllers();
//ʹ�ÿ������
app.UseCors("CorsPolicy");

app.Run();
