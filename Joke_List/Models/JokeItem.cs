using System;
using SQLite;

namespace Joke_List.Models
{
    public class JokeItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string JokeContent { get; set; }

      
    }
}
