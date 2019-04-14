using System.Linq;

namespace MVCCorePuzzle.Data
{
    public static class ProjectData
    {
        public static Genre[] genreData = new []
        {
            new Genre { GenreId = 1, Name = "Jisaw" },
            new Genre { GenreId = 2, Name = "Math" },
            new Genre { GenreId = 3, Name = "Spot the Diff." },
            new Genre { GenreId = 4, Name = "Combination" },
            new Genre { GenreId = 5, Name = "Paper & Pencil" },
            new Genre { GenreId = 6, Name = "3D" },
            new Genre { GenreId = 7, Name = "Situational" },
            new Genre { GenreId = 8, Name = "Logic" },
        };

        public static Author[] authorData = new []
        {
            new Author { AuthorId = 1, Name = "Raymond Smullyan" },
            new Author { AuthorId = 2, Name = "Jon Postel" },
            new Author { AuthorId = 3, Name = "Ernő Rubik" },
            new Author { AuthorId = 4, Name = "Martin Gardner" },
            new Author { AuthorId = 5, Name = "Will Shortz" },
            new Author { AuthorId = 6, Name = "David J. Bodycombe" },
            new Author { AuthorId = 7, Name = "Boris Kordemsky" },
            new Author { AuthorId = 8, Name = "Henry Dudeney" },
            new Author { AuthorId = 9, Name = "John Smith" },
            new Author { AuthorId = 10, Name = "Greg Ismadeup" },
            new Author { AuthorId = 11, Name = "Norbert Fakename" },
            new Author { AuthorId = 12, Name = "Peter Falsety" },
        };

        public static Puzzle[] puzzleData = new[]
        {
            new Puzzle { PuzzleId = 1, Title = "Rubix Cube", GenreId = 8, Price = 8.99M, AuthorId = 9, AlbumArtUrl = "/Content/Images/placeholder.gif" },
        };
    }
}
