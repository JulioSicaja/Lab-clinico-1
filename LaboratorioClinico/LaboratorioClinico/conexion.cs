﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LaboratorioClinico
{
    class conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=192.168.1.20;database=labclinico;Uid=grupo;pwd=2018;");
            conectar.Open();
            //MessageBox.Show("Conexion Exitosa");
            return conectar;
        }
    }
}
