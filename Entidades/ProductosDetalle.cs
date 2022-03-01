using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
    public class ProductosDetalle
    {
        [Key]

        
    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string? Descripcion { get; set; }
    public decimal Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Ganancia { get; set; }

        public ProductosDetalle()
    {
        Id = ProductoId = 0;
        Cantidad = Precio = 0;
    }
    public ProductosDetalle(int id, int productoId, string descripcion, decimal cantidad, decimal precio, decimal ganancia)
    {
        Id = id;
        ProductoId = productoId;
        Descripcion= descripcion;
        Cantidad = cantidad;
        Precio = precio;
        Ganancia = ganancia;
    }
}