using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232410102022_Fabian_Nabil_PBO_A_UTS.Models
{
    public class DosenContext
    {
        string consStr = "Server=localhost;Port=5432;User Id=postgres;Password=010105;Database=DataWargaFakultas;CommandTimeout=10";
        public List<Dosen> Read()
        {
            List<Dosen> listmahasiswa = new List<Dosen>();
            string query = "SELECT nik_dosen,nama_dosen,email,no_hp_dosen,password_dosen";
            using(NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using(NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dosen dosen = new Dosen();
                            dosen.NIK_dosen = (int)reader["nik_dosen"];
                            dosen.nama_dosen = (string)reader["nama_dosen"];
                            dosen.email_dosen = (string)reader["email"];
                            dosen.nomor_hp_dosen = (int)reader["nomor_hp_dosen"];
                            dosen.password_dosen = (string)reader["password_dosen"];
                            listmahasiswa.Add(dosen);

                        }
                    }
                }
                return listmahasiswa;
            }
        }
        public bool insert(Dosen dosen)
        {
            bool isSuccess = false;
            string query = "INSERT INTO Barang (nik_dosen,nama_dosen,email,no_hp_dosen,password_dosen) VALUES (@nik, @nama,@email,@no_ho,@password)";

            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nik", dosen.nama_dosen);
                    cmd.Parameters.AddWithValue("@nama", dosen.nama_dosen);
                    cmd.Parameters.AddWithValue("@email", dosen.email_dosen);
                    cmd.Parameters.AddWithValue("@no_hp", dosen.nomor_hp_dosen);
                    cmd.Parameters.AddWithValue("@password", dosen.password_dosen);


                    int eksekusi = cmd.ExecuteNonQuery();
                    isSuccess = eksekusi > 0;
                }
            }
            return isSuccess;
        }
        public bool login(int nik, string password)
        {

            bool isSuccess = false;
            string query = $"SELECT nik_dosen,password_dosen from data_dosen WHERE nik_dosen ={nik} AND password_dosen ={password}";
            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((int)reader["nik_dosen"] == nik && (string)reader["password_dosen"] == password)
                            {
                                isSuccess = true;
                            }
                            else
                            {
                                isSuccess = false;
                            }

                        }
                    }
                }
                return isSuccess;

            }
        }
    }

}
