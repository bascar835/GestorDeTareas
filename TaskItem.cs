using System;

namespace GestorTareasWinForms
{
    /// <summary>
    /// Representa una tarea con nombre, descripción, fecha de vencimiento y estado.
    /// </summary>
    public class TaskItem
    {
        /// <summary>
        /// Nombre de la tarea.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción detallada de la tarea.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Fecha límite de la tarea.
        /// </summary>
        public DateTime FechaVencimiento { get; set; }

        /// <summary>
        /// Indica si la tarea está completada.
        /// </summary>
        public bool Completada { get; set; }

        public string Categoria { get; set; }

        /// <summary>
        /// Devuelve una representación de la tarea para mostrar en la lista.
        /// </summary>
        /// <returns>Cadena con nombre, estado y fecha de vencimiento.</returns>
        public override string ToString()
        {
            return $"{Nombre} - {Categoria} - {(Completada ? "[COMPLETADA]" : "Pendiente")} -  - Vence: {FechaVencimiento.ToShortDateString()} - Descripción: {Descripcion}";
        }
    }
}