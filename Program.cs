class Banco
{
    private string nombre;
    private string cuenta;
    private double saldo;
    private double Tipointeres;

    public void asignarNombre(string nom)
    {
        if (nom.Length == 0)
        {
            Console.WriteLine("Error: cadena vacía");
            return;
        }

        nombre = nom;
    }

    public string obtenerNombre()
    {
        return nombre;
    }

    public void asignarCuenta(string cta)
    {
        if (cta.Length == 0)
        {
            Console.WriteLine("Error: cuenta no válida");
            return;
        }

        cuenta = cta;
    }

    public string obtenerCuenta()
    {
        return cuenta;
    }

    public double estado()
    {
        return saldo;
    }

    public void ingreso(double cantidad)
    {
        if (cantidad < 0)
        {
            Console.WriteLine("Error: cantidad negativa");
            return;
        }

        saldo += cantidad;
        Console.WriteLine("Ingreso exitoso Saldo actual:"+ saldo);
       
    }

    public void reintegro(double cantidad)
    {
        if (saldo - cantidad < 0)
        {
            Console.WriteLine("Error: saldo insuficiente");
            return;
        }

        saldo -= cantidad;
        Console.WriteLine("Reintegro exitoso  Saldo actual:"+ saldo);
        
    }

    public void asignarTipoDeInteres(double tipo)
    {
        if (tipo < 0)
        {
            Console.WriteLine("Error: tipo de interés inválido");
            return;
        }

        Tipointeres = tipo;
        Console.WriteLine("Tipo de interés asignado:"+ Tipointeres);
        
    }

    public double obtenerTipoDeInteres()
    {
        return Tipointeres;
    }

    public static void Main(string[] args)
    {
        Banco banco01 = new Banco();

        Console.WriteLine("Ingrese el nombre del cliente:");
        string nombre = Console.ReadLine();
        banco01.asignarNombre(nombre);

        Console.WriteLine("Ingrese el número de cuenta:");
        string cuenta = Console.ReadLine();
        banco01.asignarCuenta(cuenta);

        Console.WriteLine("Ingrese el tipo de interés:");
        double tipoInteres = Convert.ToDouble(Console.ReadLine());
        banco01.asignarTipoDeInteres(tipoInteres);

        Console.WriteLine("Ingrese la cantidad a ingresar:");
        double cantidadIngreso = Convert.ToDouble(Console.ReadLine());
        banco01.ingreso(cantidadIngreso);

        Console.WriteLine("Ingrese la cantidad a reintegrar:");
        double cantidadReintegro = Convert.ToDouble(Console.ReadLine());
        banco01.reintegro(cantidadReintegro);


        System.Console.WriteLine("Tu nombre es " + banco01.obtenerNombre());
        System.Console.WriteLine("Tu cuenta es " + banco01.obtenerCuenta());
        System.Console.WriteLine("Tu estado es " + banco01.estado());
        System.Console.WriteLine("Tu tipo de interes es " + banco01.obtenerTipoDeInteres());
        
    }
}