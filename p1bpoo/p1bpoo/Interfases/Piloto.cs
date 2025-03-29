namespace p1bpoo.Interfases
{
    public enum TipoLicencia
    {
        A,B,C,M,E
    }

    internal interface Piloto
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        TipoLicencia TipoLicencia { get; set; }

        void MostrarInformacion();
    }
}
