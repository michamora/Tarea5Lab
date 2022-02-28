using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
    public class ProductosDetalle
    {
        [Key]

        public int ProductoId {get; set;}

        public string? Descripcion {get; set;}

        public double Cantidad {get; set;}

        public double Precio {get; set;}

        

    }