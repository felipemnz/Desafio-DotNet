using System;
using BusinessLogic.CategoriaBll;
using BusinessLogic.ClienteBll;
using BusinessLogic.ColaboradorBll;
using BusinessLogic.ExpedidorBll;
using BusinessLogic.FornecedorBll;
using BusinessLogic.PedidoBll;
using BusinessLogic.ProdutoBll;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DepencyInjection
{
    public class Initialize
    {
        public static void InjectDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProdutoBll, ProdutoBll>();
            services.AddScoped<IFornecedorBll, FornecedorBll>();
            services.AddScoped<ICategoriaBll, CategoriaBll>();
            services.AddScoped<IExpedidorBll, ExpedidorBll>();
            services.AddScoped<IClienteBll, ClienteBll>();
            services.AddScoped<IPedidoBll, PedidoBll>();
            services.AddScoped<IColaboradoresBll, ColaboradoresBll>();
        }
    }
}
