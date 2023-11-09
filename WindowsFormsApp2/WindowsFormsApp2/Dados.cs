using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Dados
    {
        public static string conexao()
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SGR; Integrated Security=true";
        }
    }
}
