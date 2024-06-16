using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "tipo_paquete_tipo_actividad")]
    public partial class TipoPaqueteTipoActividad
    {
        #region variables locales
        private int _CodTipoPaquete;
        private int _CodTipoActividad;
        private TipoPaquete _tipoPaquete = null;
        private TipoActividad _tipoActividad = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "cod_tipo_paquete", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodTipoPaquete
        {
            get { return _CodTipoPaquete; }
            set { _CodTipoPaquete = value; }
        }

        [Propiedad(Name = "cod_tipo_actividad", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodTipoActividad
        {
            get { return _CodTipoActividad; }
            set { _CodTipoActividad = value; }
        }
        #endregion     
       
        // -- TODO --        
        #region Relaciones con otras entidades
        public TipoPaquete TipoPaqueteObj
        {
            get {
                if (_tipoPaquete == null && _CodTipoPaquete != 0)
                    _tipoPaquete = TipoPaquete.FindByKeyStatic(_CodTipoPaquete);
                return _tipoPaquete;
            }
        }

        public TipoActividad TipoActividadObj
        {
            get {
                if (_tipoActividad == null && _CodTipoActividad != 0)
                    _tipoActividad = TipoActividad.FindByKeyStatic(_CodTipoActividad);
                return _tipoActividad;
            }
        }

        #endregion
    }

}
