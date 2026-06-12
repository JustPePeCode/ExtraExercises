namespace TheCourse.M03_CSharp101.Exercises.M07_Classes;

public class MoreClassesTests
{
    [Fact(Skip = "To Do")]
    public void Counter_starts_at_zero()
    {
        var counter = new Counter();

        Assert.Equal(0, counter.Value);
    }

    [Fact(Skip = "To Do")]
    public void Counter_increment_increases_value_by_one()
    {
        var counter = new Counter();

        counter.Increment();
        counter.Increment();

        Assert.Equal(2, counter.Value);
    }

    [Fact(Skip = "To Do")]
    public void Counter_decrement_decreases_value_by_one()
    {
        var counter = new Counter();
        counter.Increment();
        counter.Increment();

        counter.Decrement();

        Assert.Equal(1, counter.Value);
    }

    [Fact(Skip = "To Do")]
    public void Counter_reset_sets_value_back_to_zero()
    {
        var counter = new Counter();
        counter.Increment();
        counter.Increment();
        counter.Increment();

        counter.Reset();

        Assert.Equal(0, counter.Value);
    }

    [Fact(Skip = "To Do")]
    public void Rectangle_constructor_sets_width_and_height()
    {
        var rectangle = new Rectangle(4, 5);

        Assert.Equal(4, rectangle.Width);
        Assert.Equal(5, rectangle.Height);
    }

    [Fact(Skip = "To Do")]
    public void GetArea_returns_width_times_height()
    {
        var rectangle = new Rectangle(4, 5);

        var result = rectangle.GetArea();

        Assert.Equal(20, result);
    }

    [Fact(Skip = "To Do")]
    public void GetPerimeter_returns_sum_of_all_sides()
    {
        var rectangle = new Rectangle(4, 5);

        var result = rectangle.GetPerimeter();

        Assert.Equal(18, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(4, 4, true)]
    [InlineData(4, 5, false)]
    public void IsSquare_returns_true_only_when_width_equals_height(int width, int height, bool expected)
    {
        var rectangle = new Rectangle(width, height);

        var result = rectangle.IsSquare();

        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void ShoppingCart_starts_empty()
    {
        var cart = new ShoppingCart();

        Assert.Equal(0, cart.ItemCount);
        Assert.Equal(0m, cart.Total);
        Assert.True(cart.IsEmpty());
    }

    [Fact(Skip = "To Do")]
    public void AddItem_increases_item_count_and_total()
    {
        var cart = new ShoppingCart();

        cart.AddItem(10m);
        cart.AddItem(5.5m);

        Assert.Equal(2, cart.ItemCount);
        Assert.Equal(15.5m, cart.Total);
    }

    [Fact(Skip = "To Do")]
    public void IsEmpty_returns_false_after_adding_an_item()
    {
        var cart = new ShoppingCart();

        cart.AddItem(10m);

        Assert.False(cart.IsEmpty());
    }

    [Fact(Skip = "To Do")]
    public void Clear_resets_cart_to_empty()
    {
        var cart = new ShoppingCart();
        cart.AddItem(10m);
        cart.AddItem(20m);

        cart.Clear();

        Assert.Equal(0, cart.ItemCount);
        Assert.Equal(0m, cart.Total);
        Assert.True(cart.IsEmpty());
    }

    [Fact(Skip = "To Do")]
    public void Playlist_starts_empty()
    {
        var playlist = new Playlist();

        Assert.Equal(0, playlist.Count);
    }

    [Fact(Skip = "To Do")]
    public void AddSong_increases_count_and_can_be_found_with_contains()
    {
        var playlist = new Playlist();

        playlist.AddSong("Bohemian Rhapsody");

        Assert.Equal(1, playlist.Count);
        Assert.True(playlist.Contains("Bohemian Rhapsody"));
    }

    [Fact(Skip = "To Do")]
    public void RemoveSong_removes_an_existing_song_and_returns_true()
    {
        var playlist = new Playlist();
        playlist.AddSong("Bohemian Rhapsody");

        var result = playlist.RemoveSong("Bohemian Rhapsody");

        Assert.True(result);
        Assert.Equal(0, playlist.Count);
        Assert.False(playlist.Contains("Bohemian Rhapsody"));
    }

    [Fact(Skip = "To Do")]
    public void RemoveSong_returns_false_when_song_is_not_in_the_playlist()
    {
        var playlist = new Playlist();
        playlist.AddSong("Bohemian Rhapsody");

        var result = playlist.RemoveSong("Stairway to Heaven");

        Assert.False(result);
        Assert.Equal(1, playlist.Count);
    }

    [Fact(Skip = "To Do")]
    public void PlayNext_returns_songs_in_the_order_they_were_added()
    {
        var playlist = new Playlist();
        playlist.AddSong("Song A");
        playlist.AddSong("Song B");

        var first = playlist.PlayNext();
        var second = playlist.PlayNext();

        Assert.Equal("Song A", first);
        Assert.Equal("Song B", second);
    }

    [Fact(Skip = "To Do")]
    public void PlayNext_returns_null_when_no_songs_are_left()
    {
        var playlist = new Playlist();
        playlist.AddSong("Song A");
        playlist.PlayNext();

        var result = playlist.PlayNext();

        Assert.Null(result);
    }
}