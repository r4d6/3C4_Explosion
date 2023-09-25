namespace A23_TP1
{
    // TODO: Ajouter init pour les attributs ne pouvant être modifiées par l'application
    // TODO: Ajouter [JsonIgnore] devant chaque getter qui ne doit pas être enregitsré dans les fichiers
    public abstract class User
    {
        public int Id { get; set; } = -1;
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Password { get; set; } = "";

        // TODO : Compléter les getters
        public string DefaultPassword => ""; // ex : Mael Perreault = mperreault
        public string FullName => "";

        // TODO: Ajouter une fonction ToString dans le même format que le corrigé
    }
}
