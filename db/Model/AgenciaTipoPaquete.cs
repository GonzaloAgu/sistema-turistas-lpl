using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "agencia_tipo_paquete")]
    public partial class AgenciaTipoPaquete

    {
        #region variables locales
        private int _cod_agencia;
        private int _cod_tipo_paquete;
        private Agencia _agencia = null;
        private TipoPaquete _tipoPaquete = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "cod_agencia", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodAgencia
        {
            get { return _cod_agencia; }
            set { _cod_agencia = value; }
        }

        [Propiedad(Name = "cod_tipo_paquete", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int CodTipoPaquete
        {
            get { return _cod_tipo_paquete; }
            set { _cod_tipo_paquete = value; }
        }
        
        #endregion        
        // -- TODO --
        #region Relaciones con otras entidades

        public Agencia AgenciaObj {
            get {
                if (_agencia == null && _cod_agencia != 0)
                    _agencia = Agencia.FindByKeyStatic(_cod_agencia);
                return _agencia;
            }
        }

        public TipoPaquete TipoPaqueteObj {
            get {
                if (_tipoPaquete == null && _cod_tipo_paquete != 0)
                    _tipoPaquete = TipoPaquete.FindByKeyStatic(_cod_tipo_paquete);
                return _tipoPaquete;
            }
        }

        #endregion

    }

}
