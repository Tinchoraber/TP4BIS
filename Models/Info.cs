public static class Info
{
    private static List<Pais> ListaPaises = new List<Pais>();
    private static void InicializarLista()
    {
        Pais unPais = new Pais("Argentina", "argentina.JPG", 45000000, new DateTime(1816, 7, 9), "Cataratas");
        ListaPaises.Add(unPais);
        unPais = new Pais("Brasil", "brasil.JPG", 145000000, new DateTime(1816, 7, 10), "Cristo Redentor");
        ListaPaises.Add(unPais);
        unPais = new Pais("Chile", "chile.JPG", 25000000, new DateTime(1816, 7, 11), "Pucon");
        ListaPaises.Add(unPais);
        unPais = new Pais("Uruguay", "uruguay.JPG", 5000000, new DateTime(1816, 7, 12), "Punta del Este");
        ListaPaises.Add(unPais);
        unPais = new Pais("Paraguay", "paraguay.JPG", 35000000, new DateTime(1816, 7, 13), "Asuncion");
        ListaPaises.Add(unPais);
    }
    public static List<Pais> ListarPaises()
    {
        if(ListaPaises.Count == 0)
        {
            InicializarLista();
        }
        return ListaPaises;
    }
    public static Pais DetallePais(string Nombre)
    {
        Pais PaisBuscado = new Pais();
        foreach (Pais item in ListaPaises)
        {
            if(item.Nombre == Nombre)
            {
                PaisBuscado = item;
            }
        }
        return PaisBuscado;
    }
}