class Producto
{
    decimal tdc = 18.86m;
    public string? Descripcion;
    public string? Codigo;
    public decimal Precio;

    public void Imprime()
    {
        Console.WriteLine($" {Codigo} {Descripcion} dólares: ${decimal.Round(GetPrecioDolar(tdc), 2, MidpointRounding.AwayFromZero)} pesos: {Precio}");
    }
    public decimal GetPrecioDolar(decimal tipodecambio) {return Precio/tipodecambio;}
}


internal class Tienda
{
    
    private static void Main(string[] args)
    {
        int n = 5;
        Producto[] productos = new Producto[n];
        for (int i=0 ; i<n ; i++)
        {
            productos[i] = new Producto();
        }
        productos[0].Codigo = "A001"; productos[0].Descripcion = "soda cola coca 659ml"; productos[0].Precio = 1m;
        productos[1].Codigo = "A002"; productos[1].Descripcion = "sanguich 4g"; productos[1].Precio = 50.99m;
        productos[2].Codigo = "A003"; productos[2].Descripcion = "pez 10g"; productos[2].Precio = 199.99m;
        productos[3].Codigo = "A004"; productos[3].Descripcion = "mota 1kg"; productos[3].Precio = 200m;
        productos[4].Codigo = "A005"; productos[4].Descripcion = "celular ryzon a900"; productos[4].Precio = 1889.5m;
        
        foreach (Producto p in productos)
        {
            p.Imprime();
        }

    }
}

