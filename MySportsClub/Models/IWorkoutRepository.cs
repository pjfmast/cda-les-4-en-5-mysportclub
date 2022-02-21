namespace MySportsClub.Models
{
    public interface IWorkoutRepository : IRepository<Workout>
    {

        //Task<bool> TryEnroll(Workout workout, Member member);
        // Voor complexere applicaties: SaveChanges in Unit of Work 

    }
}
