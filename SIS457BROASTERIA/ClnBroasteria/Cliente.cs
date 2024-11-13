﻿using CadBroasteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnBroasteria
{
    public class ClienteCln
    {
        public static int insertar(Cliente cliente)
        {
            using (var context = new LabBroasteriaEntities())
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
                return cliente.id;
            }
        }

        public static int actualizar(Cliente cliente)
        {
            using (var context = new LabBroasteriaEntities())
            {
                var existente = context.Cliente.Find(cliente.id);
                existente.documento = cliente.documento;
                existente.nombreCompleto = cliente.nombreCompleto;
                existente.email = cliente.email;
                existente.telefono = cliente.telefono;
                existente.usuarioRegistro = cliente.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabBroasteriaEntities())
            {
                var cliente = context.Cliente.Find(id);
                cliente.estado = -1;
                cliente.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Cliente obtenerUno(int id)
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.Cliente.Find(id);
            }
        }

        public static List<Cliente> listar()
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.Cliente.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paClienteListar_Result> listarPa(string parametro)
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.paClienteListar(parametro).ToList();
            }
        }

        public static bool ExisteDocumento(string documento)
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.Cliente.Any(c => c.documento == documento && c.estado != -1);
            }
        }
        public static List<paListarCliente_Result> listarCli(string parametro)
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.paListarCliente(parametro).ToList();
            }
        }

    }
}
