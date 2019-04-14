using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCorePuzzle.Data
{
    public class Puzzle
    {
        [Key]
        public int PuzzleId { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Pieces { get; set; }
        public string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Author Author { get; set; }
    }
}