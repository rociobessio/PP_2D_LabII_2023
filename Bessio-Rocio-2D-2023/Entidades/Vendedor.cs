﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {
        #region ATRIBUTOS
        private int _id;
        private DateTime _fechaIngreso;
        private List<Cliente> _listaClientes;
        private List<Producto> _listaProducto;
        private Usuario _usuario;
        #endregion

        #region PROPIEDADES
        public int ID { get { return this._id; } }
        public List<Cliente> ListaClientes { get { return this._listaClientes; } }
        public List<Producto> ListaProductos { get { return this._listaProducto; } }
        public Usuario Usuario { get { return this._usuario; } }
        public DateTime FechaIngreso { get { return this._fechaIngreso; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado de la clase Vendedor.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        /// <param name="domicilio"></param>
        /// <param name="id"></param>
        /// <param name="fechaIngreso"></param>
        /// <param name="clientes"></param>
        /// <param name="productos"></param>
        /// <param name="user"></param>
        public Vendedor(string nombre, string apellido, Sexo sexo, Nacionalidad nacionalidad, DateTime fechaNacimiento,
                       string dni, string domicilio,
                       int id,DateTime fechaIngreso,List<Cliente> clientes,List<Producto> productos, Usuario user)
            : base(nombre, apellido, sexo, nacionalidad, fechaNacimiento, dni, domicilio)
        {
            this._id = id;
            this._fechaIngreso = fechaIngreso;
            this._listaClientes = clientes;
            this._listaProducto = productos;
            this._usuario = user;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos vendedores seran iguales is comparten usuario y contraseña (sobrecarga)
        /// y si tienen el mismo ID.
        /// </summary>
        /// <param name="vendedor1"></param>
        /// <param name="vendedor2"></param>
        /// <returns>True si son iguales, false sino.</returns>
        public static bool operator ==(Vendedor vendedor1 , Vendedor vendedor2)
        {
            bool sonIguales = false;
            if (!(vendedor1 is null) && !(vendedor2 is null))
            {
                sonIguales = (vendedor1._usuario == vendedor2._usuario) &&
                                (vendedor1._id == vendedor2._id);  
            }
            return sonIguales;
        }

        public static bool operator !=(Vendedor vendedor1, Vendedor vendedor2)
        {
            return !(vendedor1 == vendedor2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Compara si el objeto this actual es igual al pasaddo por parametro
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Vendedor)
            {
                retorno = this == ((Vendedor)obj);
            }
            return retorno;
        }

        /// <summary>
        /// Valor Hash del objeto
        /// </summary>
        /// <returns>Valor Hash del objeto</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Retorna un string con el estado del objeto
        /// </summary>
        /// <returns>string con el estado del objeto</returns>
        public override string ToString()
        {
            return $"{base.ToString()}-{this._id}-{this._fechaIngreso.ToShortDateString()}";
        }
        #endregion
    }
}
