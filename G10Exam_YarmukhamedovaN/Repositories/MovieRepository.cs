using G10Exam_YarmukhamedovaN.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace G10Exam_YarmukhamedovaN.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly string _path;
    private List<Movie> _movies;

    public MovieRepository()
    {
        _path = "../../../DataAccess/Data/Movie.json";
        _movies = new List<Movie>();

        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }

        _movies = ReadAllMovies();
    }
    public Movie GetMovieById(Guid movieId)
    {
        foreach (var movie in _movies)
        {
            if (movie.Id == movieId)

            {
                return movie;
            }
        }
        throw new Exception($"Bunday Id :{movieId} film yoq");
            }

    public List<Movie> ReadAllMovies()
    {
        var movieJson = File.ReadAllText(_path);
        var movies = JsonSerializer.Deserialize<List<Movie>>(movieJson);
        return movies;
    }

    public void RemoveMovie(Guid movieId)
    {
        var movie = GetMovieById(movieId);
        _movies.Remove(movie);
        SaveData();
    }

    public void UpdateMovie(Movie movie)
    {
        var updatingMovie = GetMovieById(movie.Id);
        var index = _movies.IndexOf(updatingMovie);
        _movies[index] = movie;
        SaveData();
       
        
    }

    public Guid WriteMovie(Movie movie)
    {
        _movies.Add(movie);
        SaveData(); 
       return  movie.Id;
    }
    private void SaveData()
    {
        var movieJson = JsonSerializer.Serialize(_movies);
        File.WriteAllText(_path, movieJson);
    }
}

