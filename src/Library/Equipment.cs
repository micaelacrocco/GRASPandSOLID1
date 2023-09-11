//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase que representa un equipo.
    /// </summary> <summary>
    /// 
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// Constructor de la clase Equipment.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="hourlyCost"></param> <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="hourlyCost"></param>
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
    }
}