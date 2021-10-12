using System;
namespace Ganaderia.App.Dominio
{
    public class Tratamiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string PlanDiagnostico { get; set; }
        public string PlanTerapeutico { get; set; }
    }
}