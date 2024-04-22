using Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Lstr_PathDLL = "F:\\Trabalho\\Testes\\ErroAwait\\ErroAwait\\LoadedByReflection\\bin\\Debug\\net48\\LoadedByReflection.dll";                   
            Assembly Lobj_Assembly = Assembly.LoadFile(Lstr_PathDLL);            
            IAwaitErrorNetFrameworkASPNET Lobj_Error = (IAwaitErrorNetFrameworkASPNET)Lobj_Assembly.CreateInstance("LoadedByReflection.AwaitErrorNetFrameworkASPNET");
            Lobj_Error.Test();
            
        }
    }
}