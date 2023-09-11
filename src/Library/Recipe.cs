//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa una receta.
    /// </summary>
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        /// <summary>
        /// Anade un paso a la receta.
        /// </summary>
        /// <param name="step"></param>
        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        /// <summary>
        /// Elimina un paso de la receta.
        /// </summary>
        /// <param name="step"></param>
        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /// <summary>
        /// Imprime la receta.
        /// </summary> <summary>
        /// 
        /// </summary>
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
        // Agrego el método GetSteps() para obtener la lista de pasos, que se utiliza en ProductionCostCalculator.
        /// <summary>
        /// Obtiene la lista de pasos.
        /// </summary>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ArrayList GetSteps()
        {
            return this.steps;
        }
    }
}