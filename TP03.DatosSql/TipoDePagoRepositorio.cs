using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP03.Entidades;

namespace TP03.DatosSql
{
    public class TipoDePagoRepositorio
    {
        private readonly bool _usarCache;
        private List<TipoDePago> tiposDePagoCache = new();
        private readonly string _connectionString = null!;
        public TipoDePagoRepositorio(bool usarCache = false)
        {
            _usarCache = usarCache;
            _connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            if (_usarCache)
            {
                LeerDatos();

            }
        }
        private void LeerDatos()
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    var query = @"SELECT TipoDePagoId, Descripcion FROM TiposDePago ORDER BY Descripcion";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TipoDePago pago = ConstruirTipoDePago(reader);
                                tiposDePagoCache.Add(pago);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar leer los tiposDePagoCache", ex);
            }
        }

        private TipoDePago ConstruirTipoDePago(SqlDataReader reader)
        {
            return new TipoDePago
            {
                TipoDePagoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }
        public List<TipoDePago> GetLista()
        {
            if (_usarCache)
            {
                return tiposDePagoCache;

            }
            List<TipoDePago> lista = new List<TipoDePago>();
            using (var cnn = new SqlConnection(_connectionString))
            {
                cnn.Open();
                string query = @"SELECT TipoDePagoId, Descripcion
                        FROM TiposDePago ORDER BY Descripcion";
                using (var cmd = new SqlCommand(query, cnn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TipoDePago pago = ConstruirTipoDePago(reader);
                            lista.Add(pago);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Existe(TipoDePago pago)
        {
            if (_usarCache)
            {
                return pago.TipoDePagoId == 0 ? tiposDePagoCache
                    .Any(c => c.Descripcion.ToLower() == pago.Descripcion.ToLower())
                    : tiposDePagoCache.Any(c => c.Descripcion.ToLower() == pago.Descripcion.ToLower()
                    && c.TipoDePagoId != pago.TipoDePagoId);
            }

            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query = pago.TipoDePagoId == 0 ? @"SELECT COUNT(*) FROM TiposDePago
                                WHERE LOWER(Descripcion)=@Descripcion"
                        : @"SELECT COUNT(*) FROM TiposDePago
                                WHERE LOWER(Descripcion)=@Descripcion
                                AND TipoDePagoId<>@TipoDePagoId";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", pago.Descripcion);
                        if (pago.TipoDePagoId > 0)
                        {
                            cmd.Parameters.AddWithValue("@FrutoSecoId", pago.TipoDePagoId);
                        }
                        return (int)cmd.ExecuteScalar() > 0;
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar ver si existe un Tipo de Pago", ex);
            }
        }

        public void Agregar(TipoDePago pago)
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query = @"INSERT INTO TiposDePago (Descripcion) VALUES (@Descripcion);
                                SELECT SCOPE_IDENTITY();";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", pago.Descripcion);
                        int id = (int)(decimal)cmd.ExecuteScalar();
                        pago.TipoDePagoId = id;
                    }
                }
                if (_usarCache)
                {
                    tiposDePagoCache.Add(pago);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar agregar un Tipo de Pago", ex);
            }
        }

        public void Borrar(int tipoDePagoId)
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query = @"DELETE FROM TiposDePago WHERE TipoDePagoId=@TipoDePagoId";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@TipoDePagoId", tipoDePagoId);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (_usarCache)
                {
                    TipoDePago? tpBorrar = tiposDePagoCache.FirstOrDefault(f => f.TipoDePagoId == tipoDePagoId);
                    if (tpBorrar is null) return;
                    tiposDePagoCache.Remove(tpBorrar);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar borrar un Tipo de Pago", ex);
            }
        }

        public void Editar(TipoDePago pago)
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query = @"UPDATE TiposDePago SET Descripcion=@Descripcion
                    WHERE TipoDePagoId=@TipoDePagoId";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", pago.Descripcion);
                        cmd.Parameters.AddWithValue("@TipoDePagoId", pago.TipoDePagoId);
                        cmd.ExecuteNonQuery();
                    }

                }
                if (_usarCache)
                {
                    TipoDePago? tpEditar = tiposDePagoCache.FirstOrDefault(t => t.TipoDePagoId == pago.TipoDePagoId);
                    if (tpEditar is null) return;
                    tpEditar.Descripcion = pago.Descripcion;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar editar un Tipo de Pago", ex);
            }
        }

    }
}
