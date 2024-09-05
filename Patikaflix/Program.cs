class Series
{
    static void Main()
    {
        List<Series> seriesList = new List<Series>
        {
            new Series { SeriesName = "Avrupa Yakası", ProductionYear = 2004, Genre = "Comedy", ReleaseYear = 2004, Director = "Yüksel Aksu", Platform = "Kanal D" },
            new Series { SeriesName = "Yalan Dünya", ProductionYear = 2012, Genre = "Comedy", ReleaseYear = 2012, Director = "Gülseren Buda Başkaya", Platform = "Fox TV" },
            new Series { SeriesName = "Jet Sosyete", ProductionYear = 2018, Genre = "Comedy", ReleaseYear = 2018, Director = "Gülseren Buda Başkaya", Platform = "TV8" },
            new Series { SeriesName = "Dadı", ProductionYear = 2006, Genre = "Comedy", ReleaseYear = 2006, Director = "Yusuf Pirhasan", Platform = "Kanal D" },
            new Series { SeriesName = "Belalı Baldız", ProductionYear = 2007, Genre = "Comedy", ReleaseYear = 2007, Director = "Yüksel Aksu", Platform = "Kanal D" },
            new Series { SeriesName = "Arka Sokaklar", ProductionYear = 2004, Genre = "Crime, Drama", ReleaseYear = 2004, Director = "Orhan Oğuz", Platform = "Kanal D" },
            new Series { SeriesName = "Aşk-ı Memnu", ProductionYear = 2008, Genre = "Drama, Romance", ReleaseYear = 2008, Director = "Hilal Saral", Platform = "Kanal D" },
            new Series { SeriesName = "Muhteşem Yüzyıl", ProductionYear = 2011, Genre = "Historical, Drama", ReleaseYear = 2011, Director = "Mercan Çilingiroğlu", Platform = "Star TV" },
            new Series { SeriesName = "Yaprak Dökümü", ProductionYear = 2006, Genre = "Drama", ReleaseYear = 2006, Director = "Serdar Akar", Platform = "Kanal D" }
        };

        // Filtering comedy series
        List<ComedySeries> comedySeriesList = seriesList
            .Where(s => s.Genre.Contains("Comedy", StringComparison.OrdinalIgnoreCase))
            .Select(s => new ComedySeries
            {
                SeriesName = s.SeriesName,
                Genre = s.Genre,
                Director = s.Director
            })
            .ToList();

        // Sorting comedy series by name and then by director
        var sortedComedySeriesList = comedySeriesList
            .OrderBy(s => s.SeriesName)
            .ThenBy(s => s.Director)
            .ToList();

        // Displaying the sorted list
        Console.WriteLine("\nComedy Series:");
        foreach (var series in sortedComedySeriesList)
        {
            Console.WriteLine($"Series Name: {series.SeriesName}, Genre: {series.Genre}, Director: {series.Director}");
        }
    }
}





