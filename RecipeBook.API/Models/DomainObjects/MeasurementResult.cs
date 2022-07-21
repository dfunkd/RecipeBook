namespace RecipeBook.API.Models.DomainObjects
{
    public class MeasurementResult
    {
        #region Integers
        public int Id { get; set; }
        #endregion

        #region Strings
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        #endregion
    }
}