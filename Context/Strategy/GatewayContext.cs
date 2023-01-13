﻿using CORE.Interfaces.Strategy;

namespace Infraestructura.Strategy
{
    /// <summary>
    /// MIDDLWARE...
    /// </summary>
    /// 
    //Referencia las propiedades(métodos, get, set)
    //que tienen la referencia al objeto estrategia.
    public class GatewayContext
    {
        private IGatewayBase _gateway;
        public GatewayContext(IGatewayBase gateway)
        {
            _gateway = gateway;
        }

        //MÉTODOS DE GESTIÓN...
        public void GestionPasarela(string pasarela)
        {
            _gateway.setProveedorGateway(pasarela);
        }

         public void SetStrategyPasarela(IGatewayBase setGateway)
        {
            _gateway = setGateway;
        }

        public void gettingProveedor()
        {
            _gateway.getProveedor();
        }

        public void gettingEstado()
        {
            _gateway.getEstadoGateway();
        }
    }
}
