using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace A23_TP1
{
    // TODO: Ajouter init pour les attributs ne pouvant être modifiées par l'application
    // TODO: Ajouter [JsonIgnore] devant chaque getter qui ne doit pas être enregitsré dans les fichiers
    public class Group
    {
        public int Id { get; set; } = -1;
        public int CourseId { get; set; } = -1;
        public int TeacherId { get; set; } = -1;
        public Semester Semester { get; set; } = Semester.All;
        public int GroupNumber { get; set; } = 0;
        public List<int> StudentIds { get; set; } = new List<int>();


        // TODO : Compléter les getters
        [JsonIgnore] public Course? Course => null;
        [JsonIgnore] public Teacher? Teacher => null;
        [JsonIgnore] public IEnumerable<Evaluation> Evaluations => null;
        [JsonIgnore] public IEnumerable<Lesson> Lessons => null;
        [JsonIgnore] public IEnumerable<Student> Students => null;
        [JsonIgnore] public int EvaluationsWeightSum => 0;

        public IEnumerable<Result> GetResults(int studentId)
        {
            return null;
        }

        public int GetGradeSum(int studentId)
        {
            return 0;
        }

        // TODO: Ajouter une fonction ToString dans le même format que le corrigé
    }
}
