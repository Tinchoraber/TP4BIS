public class Pais
{
    public string Nombre{get; private set;}
    public string imgBandera{get;private set;}
    public int Poblacion{get; private set;}
    public DateTime FechaIndependencia{get; private set;}
    public string AtractivosTuristicos{get; private set;}
    public Pais()
    {

    }
    public Pais(string Nom, string Img, int Pob, DateTime FInd, string AT)
    {
        Nombre = Nom;
        imgBandera = Img;
        Poblacion = Pob;
        FechaIndependencia = FInd;
        AtractivosTuristicos = AT;
    }
    
}