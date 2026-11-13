namespace calculadora_dotnet_mvc.Models
{
    public class CalculadoraModel
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operacion { get; set; } = "suma";
        public string? Resultado { get; set; }

        public void Calcular()
        {
            Console.WriteLine($"[MODELO] Calculando: {Num1} {Operacion} {Num2}");
            Resultado = Operacion switch
            {
                "suma" => (Num1 + Num2).ToString(),
                "resta" => (Num1 - Num2).ToString(),
                "multiplicacion" => (Num1 * Num2).ToString(),
                "division" => Num2 == 0 ? "Error: División por cero" : Math.Round(Num1 / Num2, 4).ToString(),
                _ => "Operación no válida"
            };
        }
    }
}
