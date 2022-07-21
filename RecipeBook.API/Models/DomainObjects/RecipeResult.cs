namespace RecipeBook.API.Models.DomainObjects
{
    public class RecipeResult
    {
        #region DateTimes
        public DateTime DateAdded { get; set; }
        #endregion

        #region Integers
        public int? CookTime { get; set; }
        public int Id { get; set; }
        public int IsGood { get; set; }
        public int? PrepTime { get; set; }
        public int? Servings { get; set; }
        #endregion

        #region Strings
        public string CookTimeString => CookTime.HasValue ? CalculateTime(new TimeSpan(0, CookTime.Value, 0)) : string.Empty;
        public string Directions { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string PrepTimeString => PrepTime.HasValue ? CalculateTime(new TimeSpan(0, PrepTime.Value, 0)) : string.Empty;
        public string Tips { get; set; }
        public string TotalTimeString => CalculateTime(new TimeSpan(0, CookTime ?? 0 + PrepTime ?? 0, 0));
        public string Url { get; set; }
        #endregion

        public List<IngredientResult> Ingredients { get; set; }

        public string CalculateTime(TimeSpan timeSpan)
        {
            string result = string.Empty;
            if (timeSpan.Days > 0)
            {
                result = timeSpan.Days > 1 ? $"{timeSpan.Days} Days" : $"{timeSpan.Days} Day";
                if (timeSpan.Hours > 0)
                    result += timeSpan.Hours > 1 ? $" {timeSpan.Hours} Hours" : $" {timeSpan.Hours} Hour";
                if (timeSpan.Minutes > 0)
                    result += timeSpan.Minutes > 1 ? $" {timeSpan.Minutes} Minutes" : $" {timeSpan.Minutes} Minute";
            }
            else if (timeSpan.Hours > 0)
            {
                result = timeSpan.Hours > 1 ? $"{timeSpan.Hours} Hours" : $"{timeSpan.Hours} Hour";
                if (timeSpan.Minutes > 0)
                    result += timeSpan.Minutes > 1 ? $" {timeSpan.Minutes} Minutes" : $" {timeSpan.Minutes} Minute";
            }
            else if (timeSpan.Minutes > 0)
                result = timeSpan.Minutes > 1 ? $"{timeSpan.Minutes} Minutes" : $"{timeSpan.Minutes} Minute";

            return result;
        }
    }
}