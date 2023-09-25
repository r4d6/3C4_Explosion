using System.Collections.Generic;

namespace A23_TP1
{
    // TODO: Ajouter init pour les attributs ne pouvant être modifiées par l'application
    // TODO: Ajouter [JsonIgnore] devant chaque getter qui ne doit pas être enregitsré dans les fichiers
    public class Evaluation
    {
        public int Id { get; set; } = -1;
        public int GroupId { get; set; } = 0;
        public string Name { get; set; } = "";
        public int Weight { get; set; } = 0;
        public Dictionary<int, Result> Results { get; set; } = new Dictionary<int, Result>(); // <Student Id, Result>


        // TODO: Compléter les getters
        public double Average => 0;
        public Group? Group => null;

        // TODO: Ajouter init pour les attributs ne pouvant être modifiées par l'application
    }
}
