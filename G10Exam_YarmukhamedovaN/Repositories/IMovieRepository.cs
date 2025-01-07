using G10Exam_YarmukhamedovaN.DataAccess.Entities;

namespace G10Exam_YarmukhamedovaN.Repositories
{
    public interface IMovieRepository
    {
        Guid WriteMovie(Movie movie);
        List<Movie> ReadAllMovies();

        void RemoveMovie(Guid movieId);
        Movie GetMovieById(Guid movieId);

        void UpdateMovie(Movie movie);


    }
}