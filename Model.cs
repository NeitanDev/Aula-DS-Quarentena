using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms; // carrega os componentes visuais do C#

namespace Aula_DS {
    class Model {
        public void NonQuery( String sql ) {
            try {
                MySqlConnection conectar = new MySqlConnection( "server=localhost;database=db_ds; Uid=root; pwd=root;" );
                conectar.Open();
                MySqlCommand ExecutaSQL = new MySqlCommand();
                ExecutaSQL.Connection = conectar;
                ExecutaSQL.CommandText = sql;
                ExecutaSQL.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show( "Operação realizada com sucesso!" );
            } catch ( Exception ex ) {
                MessageBox.Show( "Erro" + ex );
            }
        }
    }
}
