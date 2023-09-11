//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa un producto.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Constructor de la clase Product.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="unitCost"></param>
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}