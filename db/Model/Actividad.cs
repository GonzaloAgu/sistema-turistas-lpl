﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TurApp.db
{
    [Table(Name = "actividad")]
    public partial class Actividad
    {
        #region variables locales
        private int _Codigo;
        private int _cod_tipo_actividad;
        private int _cod_transporte;
        private float _importe;
        private int _nivel;
        private TipoActividad _tipoActividad = null;
        private Transporte _transporte = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        [Propiedad(Name = "cod_tipo_actividad", Tipo = typeof(int))]
        public int CodTipoActividad
        {
            get { return _cod_tipo_actividad; }
            set { _cod_tipo_actividad = value; }
        }

        [Propiedad(Name = "cod_transporte", Tipo = typeof(int))]
        public int CodTransporte
        {
            get { return _cod_transporte; }
            set { _cod_transporte = value; }
        }

        [Propiedad(Name = "importe", Tipo = typeof(float))]
        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        [Propiedad(Name = "nivel", Tipo = typeof(int))]
        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
        #endregion        
        
        // -- TODO --
        #region Relaciones con otras entidades
        //TipoActividadObj
        public TipoActividad TipoActividadObj {
            get {
                if (_tipoActividad == null && this._cod_tipo_actividad != 0) {
                    _tipoActividad = TipoActividad.FindByKeyStatic(this._cod_tipo_actividad);
                }
                return _tipoActividad;
            }
        }
        //TransporteObj
        public Transporte TransporteObj {
            get {
                if (_transporte == null && this._cod_transporte != 0) {
                    _transporte = Transporte.FindByKeyStatic(this._cod_transporte);
                }
                return _transporte;
            }
        }
        #endregion

        public override string ToString()
        {
            return String.Format("{0}: {1} - {2}", Codigo, TipoActividadObj.Nombre, TipoActividadObj.Descripcion);
        }
    }

    
}
