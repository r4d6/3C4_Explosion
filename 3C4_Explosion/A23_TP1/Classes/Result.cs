namespace A23_TP1
{
    // TODO: Ajouter init pour les attributs ne pouvant être modifiées par l'application
    // TODO: Ajouter [JsonIgnore] devant chaque getter qui ne doit pas être enregitsré dans les fichiers

    public class Result
    {
        public int StudentId { get; set; }
        public int EvaluationId { get; set; }
        public int Grade { get; set; }

        // TODO: Compléter les getters
        public Student? Student => App.Users.ContainsKey(StudentId) ? App.Users[StudentId] as Student : null;
        public Evaluation? Evaluation => App.Evaluations.ContainsKey(EvaluationId) ? App.Evaluations[EvaluationId] : null;

        // TODO: Ajouter une fonction ToString dans le même format que le corrigé
    }
}