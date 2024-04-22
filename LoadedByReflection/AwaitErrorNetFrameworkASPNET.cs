using Dominio;
using System.Threading.Tasks;

namespace LoadedByReflection
{
    public class AwaitErrorNetFrameworkASPNET : IAwaitErrorNetFrameworkASPNET
    {


        public void Test()
        {
            Teste2().GetAwaiter().GetResult();
        }



        private async Task Teste2()
        {
            await Task.Delay(1000);
        }
    }
}
