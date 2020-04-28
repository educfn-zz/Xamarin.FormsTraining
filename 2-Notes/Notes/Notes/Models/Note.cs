using System;
using SQLite;

namespace Notes.Models
{
    class Note
    {
        [PrimaryKey, AutoIncrement]
        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
