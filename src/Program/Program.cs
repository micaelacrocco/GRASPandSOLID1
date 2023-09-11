//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Clase principal del programa.
    /// </summary>
    public class Program
    {
        private static ArrayList productCatalog = new ArrayList();

        private static ArrayList equipmentCatalog = new ArrayList();

        /// <summary>
        /// Punto de entrada al programa.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            PopulateCatalogs();
            Recipe recipe = new Recipe();
            recipe.FinalProduct = GetProduct("Café con leche");
            recipe.AddStep(new Step(GetProduct("Café"), 100, GetEquipment("Cafetera"), 120));
            recipe.AddStep(new Step(GetProduct("Leche"), 200, GetEquipment("Hervidor"), 60));

            // Creo una instancia de ProductionCostCalculator para calcular el costo total de producción.
            ProductionCostCalculator costCalculator = new ProductionCostCalculator();
            double totalProductionCost = costCalculator.CalculateTotalProductionCost(recipe);

            // Imprimo la receta y el costo total de producción.
            recipe.PrintRecipe();
            Console.WriteLine($"Costo total de producción: {totalProductionCost}");
        }

        /// <summary>
        /// Llena los catálogos de productos y equipos.
        /// </summary>
        private static void PopulateCatalogs()
        {
            AddProductToCatalog("Café", 100);
            AddProductToCatalog("Leche", 200);
            AddProductToCatalog("Café con leche", 300);

            AddEquipmentToCatalog("Cafetera", 1000);
            AddEquipmentToCatalog("Hervidor", 2000);
        }

        /// <summary>
        /// Agrega un producto al catálogo.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="unitCost"></param> <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="unitCost"></param>
        private static void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        /// <summary>
        /// Agrega un equipo al catálogo.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="hourlyCost"></param>
        private static void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private static Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private static Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        /// <summary>
        /// Obtiene un producto del catálogo.
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        private static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        /// <summary>
        /// Obtiene un equipo del catálogo.
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        private static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}
