﻿using CORE.Interfaces.Adapter;

namespace CORE.Servicios.Adapter
{
    // OBJETOS ADAPTADOS DEL SISTEMA ACTUAL

    //Cliente objetivo.
    //Sistema actual que presta el servicio.
    //El cliente es una clase que contiene
    //la lógica de negocios existente del programa.
    public class ProfesorPlanta : ITargetBase
    {
        public override void Cursos()
        {
            Console.WriteLine("PROCESANDO .... asignación de cursos profesor de PLANTA");
        }
        public override void Salones()
        {
            Console.WriteLine("PROCESANDO .... asignación de salones profesor de PLANTA");
        }
        public override void AgendaHorarios()
        {
            Console.WriteLine("PROCESANDO .... horarios del profesor de PLANTA");
        }
        public override void AtencionEstudiantes()
        {
            Console.WriteLine("PROCESANDO .... Atención a estudiantes del profesor de PLANTA");
        }

        public override void ServiciosVarios()
        {
            Console.WriteLine("PROCESANDO .... Servicios varios del profesor de PLANTA");
        }
    }
}
