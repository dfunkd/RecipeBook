namespace RecipeBook.API.Models.DomainObjects
{
    public class IngredientResult
    {
        #region Integers
        public int Id { get; set; }
        public int MeasurementId { get; set; }
        public int Quantity { get; set; }
        public int RecipeId { get; set; }
        #endregion

        #region Strings
        public string Name { get; set; }
        #endregion

        public MeasurementResult Measurement { get; set; }
    }
}