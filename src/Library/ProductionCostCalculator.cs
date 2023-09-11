namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa un equipo.
    /// </summary> <summary>
    /// 
    /// </summary>
    public class ProductionCostCalculator
    {
        /// <summary>
        /// Calcula el costo total de producción siguiendo el SRP.
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        public double CalculateTotalProductionCost(Recipe recipe)
        {
            double totalCostOfInputs = CalculateCostOfInputs(recipe);
            double totalCostOfEquipment = CalculateCostOfEquipment(recipe);
            return totalCostOfInputs + totalCostOfEquipment;
        }

        /// <summary>
        /// Calcula el costo total de los insumos siguiendo el SRP.
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        private double CalculateCostOfInputs(Recipe recipe)
        {
            double totalCost = 0;
            foreach (Step step in recipe.GetSteps())
            {
                totalCost += step.Quantity * step.Input.UnitCost;
            }
            return totalCost;
        }

        /// <summary>
        /// Calcula el costo total de los equipos siguiendo el SRP.
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        private double CalculateCostOfEquipment(Recipe recipe)
        {
            double totalCost = 0;
            foreach (Step step in recipe.GetSteps())
            {
                totalCost += (step.Time / 60.0) * step.Equipment.HourlyCost;
            }
            return totalCost;
        }
    }
}