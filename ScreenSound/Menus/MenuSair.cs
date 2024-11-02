using ScreenSound.Modelos;
namespace ScreenSound.Menus;

public class MenuSair: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Obrigado por usar o ScreenSound!");
    }
}