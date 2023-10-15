        // Tres matrices básicas
        int[] numeros = new int[10];
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = i;
        }

        string[] nombres = { "Tim", "Martin", "Nikki", "Sara" };

        bool[] alternar = new bool[10];
        for (int i = 0; i < 10; i++)
        {
            alternar[i] = i % 2 == 0;
        }

        // Lista de Sabores
        List<string> saboresHelado = new List<string>
        {
            "Chocolate", "Vainilla", "Fresa", "Mango", "Menta", "Café"
        };

        Console.WriteLine("Longitud de la lista de sabores: " + saboresHelado.Count);

        if (saboresHelado.Count > 2)
        {
            Console.WriteLine("Tercer sabor: " + saboresHelado[2]);
            saboresHelado.RemoveAt(2);
            Console.WriteLine("Nueva longitud de la lista: " + saboresHelado.Count);
        }

        // Diccionario de Información del Usuario
        string[] nombresArray = { "Tim", "Martin", "Nikki", "Sara" };
        Dictionary<string, string> informacionUsuarios = new Dictionary<string, string>();

        Random random = new Random();

        foreach (string nombre in nombresArray)
        {
            int indiceSabor = random.Next(saboresHelado.Count);
            string saborAsignado = saboresHelado[indiceSabor];
            informacionUsuarios[nombre] = saborAsignado;
        }

        Console.WriteLine("Diccionario de Información del Usuario:");
        foreach (var kvp in informacionUsuarios)
        {
            Console.WriteLine($"Usuario: {kvp.Key}, Sabor de Helado: {kvp.Value}");
        }
