using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrinterText printerText)
        {
            File.WriteAllText("Recipe.txt", printerText.GetTextToPrint());
        }
    }
}