﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;

namespace Universidad.Infraestructura.Datos.Servicios.Sexos
{
    public interface ISexoServicio
    {
        Sexo ObtenerPorId(int id);
        IEnumerable<Sexo> ObtenerTodos();
    }
}
