using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjContas.classes
{
    public static class execucao
    {
        private static string LinhaCodigo = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=prjcontas";
        public static string GetConexao()
        {
            return LinhaCodigo;
        }
    }
}