using ProyectoFinal.Context;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoFinal.Services
{
    public class RegistrarRepository
    {   

        //LISTAR
        public List<Empleado> ListadoEmpleados()
        {
            using (var db = new GestionContext())
            {
                return db.Empleados.ToList();
            }
        }

        public List<Departamento> ListadoDepartamentos() {

            using (var db = new GestionContext()) {
                return db.Departamentos.ToList();
            }
        }

        public List<Cargo> ListadoCargos()
        {

            using (var db = new GestionContext())
            {
                return db.Cargos.ToList();
            }
        }


        //REGISTRAR
        public void RegistrarEmpleado(Empleado model)
        {
            using (var db = new GestionContext())
            {
                db.Empleados.Add(model);
                db.SaveChanges();
            }
        }

        public void RegistrarSalida(Salida_Empleado model)
        {
            using (var db = new GestionContext())
            {
                db.Salidas_Empleados.Add(model);
                db.SaveChanges();
            }
        }

        public void RegistrarPermiso(Permiso model)
        {
            using (var db = new GestionContext())
            {
                db.Permisos.Add(model);
                db.SaveChanges();
            }
        }

        public void RegistrarLicencia(Licencia model)
        {
            using (var db = new GestionContext())
            {
                db.Licencias.Add(model);
                db.SaveChanges();
            }
        }


        // EDITAR
        public Empleado editEmpleado(Empleado model) {

            using (var db = new GestionContext()) {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return model;
            }
        }

        public Departamento editDepartamento(Departamento model)
        {

            using (var db = new GestionContext())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return model;
            }
        }





        //Delete


    }
}