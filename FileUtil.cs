namespace CrossplatformMKR_1;

public static class FileUtil
{

    public static readonly string ReadPath = Path.Combine(Path.GetFullPath("Files"), "INPUT.TXT");
    public static readonly string WritePath = Path.Combine(Path.GetFullPath("Files"), "OUTPUT.TXT");
    
    
    public static string[] Read(string inputFilePath)
    {
        if (!File.Exists(inputFilePath))
        {
            throw new FileNotFoundException($"Cannot found file: {inputFilePath}");
        }

        return File.ReadAllLines(inputFilePath);
    }
    
    public static void Write(string outputFilePath, object output)
    {
        try
        {
            File.WriteAllText(outputFilePath, output.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Cannot write to file: {ex.Message}");
        }
    }
}