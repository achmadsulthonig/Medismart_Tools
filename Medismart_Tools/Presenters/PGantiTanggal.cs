using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medismart_Tools.Models;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;

namespace Medismart_Tools.Presenters
{
    class PGantiTanggal
    {
        private string namaForm;

        public string NamaForm
        {
            get { return namaForm; }
            set { namaForm = value; }
        }

        private PASIEN pasien;

        public PASIEN Pasien
        {
            get { return pasien; }
            set { pasien = value; }
        }

        public void cariPasien(string nomorMR)
        {
            Koneksi koneksi = new Koneksi();

            DCMedismartToolsDataContext context = koneksi.DataContext;

            try
            {
                pasien = (from pasien_ in context.PASIENs
                          where pasien_.KD_PASIEN == nomorMR
                          select pasien_).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ArrayList cariKunjungan()
        {
            Koneksi koneksi = new Koneksi();

            DCMedismartToolsDataContext context = koneksi.DataContext;

            ArrayList nilaiBalikan = new ArrayList();

            switch (namaForm)
            {
                case "Ganti Tanggal Kunjungan RWJ":
                    var selectedKunjunganRWJ = (from selectedKunjungan_ in context.KUNJUNGANs
                                                join selectedTransaksi in context.TRANSAKSIs on new { selectedKunjungan_.KD_PASIEN, selectedKunjungan_.TGL_MASUK.Date, selectedKunjungan_.KD_UNIT }
                                                equals new { selectedTransaksi.KD_PASIEN, selectedTransaksi.TGL_TRANSAKSI.Date, selectedTransaksi.KD_UNIT }
                                                join selectedUnit in context.UNITs on selectedKunjungan_.KD_UNIT equals selectedUnit.KD_UNIT
                                                join selectedCustomer in context.CUSTOMERs on selectedKunjungan_.KD_CUSTOMER equals selectedCustomer.KD_CUSTOMER
                                                join selectedDokter in context.DOKTERs on selectedKunjungan_.KD_DOKTER equals selectedDokter.KD_DOKTER
                                                where selectedKunjungan_.KD_PASIEN == pasien.KD_PASIEN
                                                      && selectedUnit.KD_BAGIAN == 2
                                                orderby selectedKunjungan_.TGL_MASUK descending, selectedKunjungan_.JAM_MASUK descending
                                                select new
                                                {
                                                    selectedTransaksi.NO_TRANSAKSI,
                                                    selectedUnit.NAMA_UNIT,
                                                    selectedKunjungan_.TGL_MASUK,
                                                    selectedKunjungan_.JAM_MASUK,
                                                    selectedKunjungan_.TGL_KELUAR,
                                                    selectedKunjungan_.JAM_KELUAR,
                                                    selectedCustomer.CUSTOMER1,
                                                    selectedDokter.NAMA,
                                                    selectedUnit.KD_UNIT,
                                                }).ToList();

                    foreach (var nilai in selectedKunjunganRWJ)
                    {
                        nilaiBalikan.Add(nilai);
                    }

                    break;

                case "Ganti Tanggal Kunjungan RWI":
                    var selectedKunjunganRWI = (from selectedKunjungan_ in context.KUNJUNGANs
                                                join selectedTransaksi in context.TRANSAKSIs on new { selectedKunjungan_.KD_PASIEN, selectedKunjungan_.TGL_MASUK.Date, selectedKunjungan_.KD_UNIT }
                                                equals new { selectedTransaksi.KD_PASIEN, selectedTransaksi.TGL_TRANSAKSI.Date, selectedTransaksi.KD_UNIT }
                                                join selectedUnit in context.UNITs on selectedKunjungan_.KD_UNIT equals selectedUnit.KD_UNIT
                                                join selectedCustomer in context.CUSTOMERs on selectedKunjungan_.KD_CUSTOMER equals selectedCustomer.KD_CUSTOMER
                                                join selectedDokter in context.DOKTERs on selectedKunjungan_.KD_DOKTER equals selectedDokter.KD_DOKTER
                                                where selectedKunjungan_.KD_PASIEN == pasien.KD_PASIEN
                                                      && selectedUnit.KD_BAGIAN == 1
                                                orderby selectedKunjungan_.TGL_MASUK descending, selectedKunjungan_.JAM_MASUK descending
                                                select new
                                                {
                                                    selectedTransaksi.NO_TRANSAKSI,
                                                    selectedUnit.NAMA_UNIT,
                                                    selectedKunjungan_.TGL_MASUK,
                                                    selectedKunjungan_.JAM_MASUK,
                                                    selectedKunjungan_.TGL_KELUAR,
                                                    selectedKunjungan_.JAM_KELUAR,
                                                    selectedCustomer.CUSTOMER1,
                                                    selectedDokter.NAMA,
                                                    selectedUnit.KD_UNIT,
                                                }).ToArray();

                    foreach (var nilai in selectedKunjunganRWI)
                    {
                        nilaiBalikan.Add(nilai);
                    }

                break;

                case "Ganti Tanggal Kunjungan IGD":
                    var selectedKunjunganIGD = (from selectedKunjungan_ in context.KUNJUNGANs
                                                join selectedTransaksi in context.TRANSAKSIs on new { selectedKunjungan_.KD_PASIEN, selectedKunjungan_.TGL_MASUK.Date, selectedKunjungan_.KD_UNIT }
                                                equals new { selectedTransaksi.KD_PASIEN, selectedTransaksi.TGL_TRANSAKSI.Date, selectedTransaksi.KD_UNIT }
                                                join selectedUnit in context.UNITs on selectedKunjungan_.KD_UNIT equals selectedUnit.KD_UNIT
                                                join selectedCustomer in context.CUSTOMERs on selectedKunjungan_.KD_CUSTOMER equals selectedCustomer.KD_CUSTOMER
                                                join selectedDokter in context.DOKTERs on selectedKunjungan_.KD_DOKTER equals selectedDokter.KD_DOKTER
                                                where selectedKunjungan_.KD_PASIEN == pasien.KD_PASIEN
                                                      && selectedUnit.KD_BAGIAN == 3
                                                orderby selectedKunjungan_.TGL_MASUK descending, selectedKunjungan_.JAM_MASUK descending
                                                select new
                                                {
                                                    selectedTransaksi.NO_TRANSAKSI,
                                                    selectedUnit.NAMA_UNIT,
                                                    selectedKunjungan_.TGL_MASUK,
                                                    selectedKunjungan_.JAM_MASUK,
                                                    selectedKunjungan_.TGL_KELUAR,
                                                    selectedKunjungan_.JAM_KELUAR,
                                                    selectedCustomer.CUSTOMER1,
                                                    selectedDokter.NAMA,
                                                    selectedUnit.KD_UNIT,
                                                }).ToArray();

                    foreach (var nilai in selectedKunjunganIGD)
                    {
                        nilaiBalikan.Add(nilai);
                    }

                    break;

                case "Ganti Tanggal Kunjungan Laboratorium":
                    var selectedKunjunganLAB = (from selectedKunjungan_ in context.KUNJUNGANs
                                                join selectedTransaksi in context.TRANSAKSIs on new { selectedKunjungan_.KD_PASIEN, selectedKunjungan_.TGL_MASUK.Date, selectedKunjungan_.KD_UNIT }
                                                equals new { selectedTransaksi.KD_PASIEN, selectedTransaksi.TGL_TRANSAKSI.Date, selectedTransaksi.KD_UNIT }
                                                join selectedUnit in context.UNITs on selectedKunjungan_.KD_UNIT equals selectedUnit.KD_UNIT
                                                join selectedCustomer in context.CUSTOMERs on selectedKunjungan_.KD_CUSTOMER equals selectedCustomer.KD_CUSTOMER
                                                join selectedDokter in context.DOKTERs on selectedKunjungan_.KD_DOKTER equals selectedDokter.KD_DOKTER
                                                where selectedKunjungan_.KD_PASIEN == pasien.KD_PASIEN
                                                      && selectedUnit.KD_BAGIAN == 4
                                                orderby selectedKunjungan_.TGL_MASUK descending, selectedKunjungan_.JAM_MASUK descending
                                                select new
                                                {
                                                    selectedTransaksi.NO_TRANSAKSI,
                                                    selectedUnit.NAMA_UNIT,
                                                    selectedKunjungan_.TGL_MASUK,
                                                    selectedKunjungan_.JAM_MASUK,
                                                    selectedKunjungan_.TGL_KELUAR,
                                                    selectedKunjungan_.JAM_KELUAR,
                                                    selectedCustomer.CUSTOMER1,
                                                    selectedDokter.NAMA,
                                                    selectedUnit.KD_UNIT,
                                                }).ToArray();

                    foreach (var nilai in selectedKunjunganLAB)
                    {
                        nilaiBalikan.Add(nilai);
                    }

                    break;

                case "Ganti Tanggal Kunjungan Radiologi":
                    var selectedKunjunganRAD = (from selectedKunjungan_ in context.KUNJUNGANs
                                                join selectedTransaksi in context.TRANSAKSIs on new { selectedKunjungan_.KD_PASIEN, selectedKunjungan_.TGL_MASUK.Date, selectedKunjungan_.KD_UNIT }
                                                equals new { selectedTransaksi.KD_PASIEN, selectedTransaksi.TGL_TRANSAKSI.Date, selectedTransaksi.KD_UNIT }
                                                join selectedUnit in context.UNITs on selectedKunjungan_.KD_UNIT equals selectedUnit.KD_UNIT
                                                join selectedCustomer in context.CUSTOMERs on selectedKunjungan_.KD_CUSTOMER equals selectedCustomer.KD_CUSTOMER
                                                join selectedDokter in context.DOKTERs on selectedKunjungan_.KD_DOKTER equals selectedDokter.KD_DOKTER
                                                where selectedKunjungan_.KD_PASIEN == pasien.KD_PASIEN
                                                      && selectedUnit.KD_BAGIAN == 5
                                                orderby selectedKunjungan_.TGL_MASUK descending, selectedKunjungan_.JAM_MASUK descending
                                                select new
                                                {
                                                    selectedTransaksi.NO_TRANSAKSI,
                                                    selectedUnit.NAMA_UNIT,
                                                    selectedKunjungan_.TGL_MASUK,
                                                    selectedKunjungan_.JAM_MASUK,
                                                    selectedKunjungan_.TGL_KELUAR,
                                                    selectedKunjungan_.JAM_KELUAR,
                                                    selectedCustomer.CUSTOMER1,
                                                    selectedDokter.NAMA,
                                                    selectedUnit.KD_UNIT,
                                                }).ToArray();

                    foreach (var nilai in selectedKunjunganRAD)
                    {
                        nilaiBalikan.Add(nilai);
                    }

                    break;

                default:
                    break;
            }

            return nilaiBalikan;
        }
        public void GantiTanggalKunjungan(string kodeUnit, string nomorTransaksi, DateTime tglKunjunganLama, DateTime tglKunjunganBaru)
        {
            Koneksi koneksi = new Koneksi();
            
            using (SqlConnection connection = new SqlConnection(koneksi.Connection))
            {
                try
                {
                    connection.Open();

                    SqlTransaction sqlTransaction = connection.BeginTransaction();

                    SqlCommand command = new SqlCommand("update kunjungan set tgl_masuk = '" + tglKunjunganBaru.Date.ToString() +
                                                           "' where kd_pasien  = '" + pasien.KD_PASIEN +
                                                           "' and tgl_masuk = '" + tglKunjunganLama.Date.ToString() + "'", connection, sqlTransaction);

                    try
                    {
                        command.CommandTimeout = 300;
                        command.ExecuteNonQuery();

                        sqlTransaction.Commit();

                        MessageBox.Show("Tanggal kunjungan dan tanggal transaksi berhasil diganti", "Information");
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlTransaction.Dispose();
                        command.Dispose();
                        connection.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
