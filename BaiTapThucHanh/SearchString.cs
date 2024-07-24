namespace BaiTapThucHanh;

public class SearchString
{
    public void searchString()
    {
        Console.WriteLine("Enter a string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("Enter a word to search ");
        string searchWord = Console.ReadLine();
        int count = 0;
        int index = 0;
        while ((index = inputString.IndexOf(searchWord, index)) != -1)
        {
            count++;
            index += searchWord.Length;
        }   
        Console.WriteLine("Word found "+count+" times in the string");
    }
}