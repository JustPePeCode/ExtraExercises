namespace TheCourse.M03_CSharp101.Exercises.M07_Classes;

// 1-3. Easy: a simple counter
public class Counter
{
    public int Value { get; private set; }

    public Counter()
    {
        var counter = new Counter();
        counter.Value = 0;
    }

    public void Increment()
    {
        throw new NotImplementedException();
    }

    public void Decrement()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}

// 4-7. Medium: a rectangle with width and height
public class Rectangle
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int width, int height)
    {
        throw new NotImplementedException();
    }

    public int GetArea()
    {
        throw new NotImplementedException();
    }

    public int GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public bool IsSquare()
    {
        throw new NotImplementedException();
    }
}

// 8-11. Medium/Hard: a shopping cart that keeps track of items and their total price
public class ShoppingCart
{
    public int ItemCount { get; private set; }
    public decimal Total { get; private set; }

    public ShoppingCart()
    {
        throw new NotImplementedException();
    }

    public void AddItem(decimal price)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        throw new NotImplementedException();
    }
}

// 12-15. Hard: a playlist that keeps songs in order and can play through them
public class Playlist
{
    public int Count { get; private set; }

    public Playlist()
    {
        throw new NotImplementedException();
    }

    public void AddSong(string title)
    {
        throw new NotImplementedException();
    }

    public bool RemoveSong(string title)
    {
        throw new NotImplementedException();
    }

    // Returns the title of the next song, and advances the playlist.
    // Returns null if there are no more songs.
    public string? PlayNext()
    {
        throw new NotImplementedException();
    }

    public bool Contains(string title)
    {
        throw new NotImplementedException();
    }
}