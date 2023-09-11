namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCostCalculator
    {
        // Calcula el costo total de producción siguiendo el SRP. 
        public double CalculateTotalProductionCost(Recipe recipe)
        {
            double totalCostOfInputs = CalculateCostOfInputs(recipe);
            double totalCostOfEquipment = CalculateCostOfEquipment(recipe);
            return totalCostOfInputs + totalCostOfEquipment;
        }

        private double CalculateCostOfInputs(Recipe recipe)
        {
            double totalCost = 0;
            foreach (Step step in recipe.GetSteps())
            {
                totalCost += step.Quantity * step.Input.UnitCost;
            }
            return totalCost;
        }

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