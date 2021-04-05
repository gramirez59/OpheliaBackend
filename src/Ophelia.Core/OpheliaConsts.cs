using System;

namespace Ophelia
{
    public class OpheliaConsts
    {
        public const string LocalizationSourceName = "Ophelia";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        public const int MINIMUM_STOCK = 5;
        public const byte AGE_CLIENT = 35;
        public static DateTime INIT_DATE = new DateTime(2000, 2, 1);
        public static DateTime LAST_DATE = new DateTime(2000, 5, 25);
        public const string QUERY_TOTAL_SOLD = "SELECT AR.IdProducto as Id, PR.Nombre, COUNT(AR.IdProducto) as CantidadVendida, TRY_CAST((COUNT(AR.IdProducto) * PR.PrecioUnitario) AS BIGINT) as TotalVendido FROM [ophelia].[ArticulosVenta] AR INNER JOIN [ophelia].[Productos] PR ON AR.IdProducto = PR.Id GROUP BY AR.IdProducto, PR.Nombre, PR.PrecioUnitario";
    }
}
