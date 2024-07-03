using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "paquete")]
    public partial class Paquete
    {
        #region variables locales
        private int _Codigo;
        private int _cod_tipo_paquete;
        private TipoPaquete _tipoPaquete = null;
        private int _cod_agencia;
        private Agencia _agencia = null;
        private DateTime _fecha;
        private int _nivel;
        private int _dniTurista;
        private Turista _turista = null;
        private int _cod_destino;
        private Destino _destino = null;
        //instancias internas de destino, tipo paquete, turista, agencia
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        [Propiedad(Name = "cod_tipo_paquete", Tipo = typeof(int))]
        public int CodTipoPaquete
        {
            get { return _cod_tipo_paquete; }
            set { _cod_tipo_paquete = value; }
        }

        [Propiedad(Name = "cod_agencia", Tipo = typeof(int))]
        public int CodAgencia
        {
            get { return _cod_agencia; }
            set { _cod_agencia = value; }
        }

        [Propiedad(Name = "fecha", Tipo = typeof(DateTime))]
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        [Propiedad(Name = "dni_turista", Tipo = typeof(int))]
        public int DniTurista
        {
            get { return _dniTurista; }
            set { _dniTurista = value; }
        }

        [Propiedad(Name = "nivel", Tipo = typeof(int))]
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        [Propiedad(Name = "cod_destino", Tipo = typeof(int))]
        public int CodDestino
        {
            get { return _cod_destino; }
            set { _cod_destino = value; }
        }
        #endregion        

        // -- TODO --
        #region Relaciones con otras entidades

        public TipoPaquete TipoPaqueteObj {
            get {
                if (_tipoPaquete == null && _cod_tipo_paquete != 0)
                    _tipoPaquete = TipoPaquete.FindByKeyStatic(_cod_tipo_paquete);
                return _tipoPaquete;
            }
        }

        public Agencia AgenciaObj {
            get {
                if (_agencia == null && _cod_agencia != 0)
                    _agencia = Agencia.FindByKeyStatic(_cod_agencia);
                return _agencia;
            }
        }

        public Turista TuristaObj {
            get {
                if (_turista == null && _dniTurista != 0)
                    _turista = Turista.FindByKeyStatic(_dniTurista);
                return _turista;
            }
        }

        public Destino DestinoObj {
            get {
                if (_destino == null && _cod_destino != 0)
                    _destino = Destino.FindByKeyStatic(_cod_destino);
                return _destino;
            }
        }

        #endregion

        public override string ToString() {
            return String.Format("{0}: {1} - {2}", Codigo, TipoPaqueteObj.Nombre, TipoPaqueteObj.Descripcion);
        }
    }

}
