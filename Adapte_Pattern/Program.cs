using Adapte_Pattern.Game_Description;
using Adapte_Pattern.Interfices;
using Adapte_Pattern;

public class Program
{
    public static void Main()
    {
        // Создаем объект ComputerGame
        ComputerGame game = new ComputerGame(
            name: "Epic Adventure",
            pegiAgeRating: PegiAgeRating.P12,
            budgetInMillionsOfDollars: 60,
            minimumGpuMemoryInMegabytes: 4096,
            diskSpaceNeededInGB: 50,
            ramNeededInGb: 16,
            coresNeeded: 4,
            coreSpeedInGhz: 3.5
        );

        // Используем адаптер для работы с PCGame
        PCGame gameAdapter = new ComputerGameAdapter(game);

        // Выводим информацию о игре
        Console.WriteLine($"Title: {gameAdapter.getTitle()}");
        Console.WriteLine($"PEGI Allowed Age: {gameAdapter.getPegiAllowedAge()}");
        Console.WriteLine($"Is Triple A Game: {gameAdapter.isTripleAGame()}");

        // Получаем требования к системе
        Requirements requirements = gameAdapter.getRequirements();
        Console.WriteLine($"System Requirements:");
        Console.WriteLine($"GPU: {requirements.getGpuGb()} GB");
        Console.WriteLine($"HDD: {requirements.getHDDGb()} GB");
        Console.WriteLine($"RAM: {requirements.getRAMGb()} GB");
        Console.WriteLine($"CPU Speed: {requirements.getCpuGhz()} GHz");
        Console.WriteLine($"Cores: {requirements.getCoresNum()}");
    }
}