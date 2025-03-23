// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class SayaTubeVideo {
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        Debug.Assert(title.Length <= 100, "Judul video maksimal 100 karakter");
        Debug.Assert(title != null, "Judul tidak boleh kosong");

        Random acak = new Random();
        this.id = acak.Next(10000,99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        try
        {
            if (count <= 0 || count > 10000000)
            {
                throw new ArgumentException("Error: Input play count harus antara 1 hingga 10.000.000.");
            }

            checked
            {
                this.playCount += count;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void PrintVideoDetail()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
}

class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design by Contract - Haafizd Alhabib Azwir");
        video1.IncreasePlayCount(99999999);
        video1.IncreasePlayCount(9999999);
        video1.IncreasePlayCount(-1000);
        video1.IncreasePlayCount(2330089);

        video1.PrintVideoDetail();
    }
}
