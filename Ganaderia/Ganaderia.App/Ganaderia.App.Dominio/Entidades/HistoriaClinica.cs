namespace Ganaderia.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id { get; set; }
        public float FrecuenciaCardiaca { get; set; }
        public float FrecuenciaRespiratoria { get; set; }
        public float Temperatura { get; set; }
        public string Constitucion { get; set; }
        public string CondicionCorporal { get; set; }
        public string EstadoHidratacion { get; set; }
        public string Mucosas { get; set; }
        public string NodulosLinfaticos { get; set; }
        public string MusculoEsqueletico { get; set; }
        public string SistemaNervioso { get; set; }
        public string ListaProblemas { get; set; }
        public string ImpresionDiagnostica { get; set; }
    }
}