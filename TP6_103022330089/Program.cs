// See https://aka.ms/new-console-template for more information
class SayaTubeVideo {
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        Random acak = new Random();
        this.id = acak.Next(10000,99999);
        this.title = title;
        this.playCount = 0;
    }

    public void increasePlayCount(int count)
    {
        if (count < 0)
        {
            throw new Exception("jumlah tidak boleh negatif");
        }
        this.playCount += count;
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
        video1.increasePlayCount(100);
        video1.PrintVideoDetail();
    }
}
