using Medismart_Tools.Models;
using Medismart_Tools.Views;
using System;
using System.Collections;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Medismart_Tools.Presenters
{
    public class PBukaTransaksi
    {
        private FormBukaTransaksi formBukaTransaksi;

        private string namaForm;

        private PASIEN pasien;

        public PBukaTransaksi()
        {
            formBukaTransaksi = new FormBukaTransaksi();
        }

        public FormBukaTransaksi FormBukaTransakasi
        {
            get { return formBukaTransaksi; }
            set { formBukaTransaksi = value; }
        }

        public string NamaForm
        {
            get { return namaForm; }
            set { namaForm = value; }
        }

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
                case "Buka Transaksi RWJ":
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

                case "Buka Transaksi RWI":
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

                case "Buka Transaksi IGD":
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

                case "Buka Transaksi Laboratorium":
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

                case "Buka Transaksi Radiologi":
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

        public void BukaTransaksiNonRWI(string kodeUnit, string nomorTransaksi, DateTime tglKunjungan)
        {
            Koneksi koneksi = new Koneksi();
            DCMedismartToolsDataContext context = koneksi.DataContext;
            TransactionScope transactionScope = new TransactionScope();

            using (transactionScope)
            {
                try
                {
                    var selectedKunjungan = (from k in context.KUNJUNGANs
                                             where k.KD_PASIEN == pasien.KD_PASIEN &&
                                                   k.TGL_MASUK == tglKunjungan
                                             select k
                                                      ).FirstOrDefault();

                    var selectedTransaksi = (from transaksi in context.TRANSAKSIs
                                             where transaksi.KD_PASIEN == pasien.KD_PASIEN &&
                                                   transaksi.NO_TRANSAKSI == nomorTransaksi
                                             select transaksi
                                        ).FirstOrDefault();

                    selectedKunjungan.TGL_KELUAR = null;
                    selectedKunjungan.JAM_KELUAR = null;

                    selectedTransaksi.CO_STATUS = false;
                    selectedTransaksi.TGL_CO = null;

                    context.SubmitChanges();

                    transactionScope.Complete();

                    MessageBox.Show("Transaksi sudah dibuka", "Information");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    context.Dispose();
                    transactionScope.Dispose();
                }
            }
        }

        public void BukaTransaksiRWI(string kodeUnit, string nomorTransaksi, DateTime tanggalMasuk)
        {
            Koneksi koneksi = new Koneksi();
            DCMedismartToolsDataContext context = koneksi.DataContext;
            TransactionScope transactionScope = new TransactionScope();

            KUNJUNGAN selectedKunjungan;
            TRANSAKSI selectedTransaksi;
            NGINAP selectedNginap;

            using (transactionScope)
            {
                try
                {
                    selectedKunjungan = (from k in context.KUNJUNGANs
                                         where k.KD_PASIEN == pasien.KD_PASIEN &&
                                               k.TGL_MASUK.Date == tanggalMasuk.Date
                                         select k
                                                      ).FirstOrDefault();

                    selectedTransaksi = (from transaksi in context.TRANSAKSIs
                                         where transaksi.KD_PASIEN == pasien.KD_PASIEN &&
                                               transaksi.KD_UNIT == kodeUnit &&
                                               transaksi.NO_TRANSAKSI == nomorTransaksi && transaksi.CO_STATUS == true
                                         select transaksi
                                        ).FirstOrDefault();

                    selectedNginap = (from nginap in context.NGINAPs
                                      where nginap.KD_PASIEN == pasien.KD_PASIEN &&
                                            nginap.TGL_INAP == selectedTransaksi.TGL_TRANSAKSI &&
                                            nginap.TGL_KELUAR == selectedTransaksi.TGL_CO
                                      select nginap
                                    ).FirstOrDefault();

                    KAMAR_INDUK selectedKamarInduk = (from kamarInduk in context.KAMAR_INDUKs
                                                      where kamarInduk.NO_KAMAR == selectedNginap.NO_KAMAR
                                                      select kamarInduk
                                                     ).FirstOrDefault();

                    selectedKunjungan.TGL_KELUAR = null;
                    selectedKunjungan.JAM_KELUAR = null;

                    selectedTransaksi.CO_STATUS = false;
                    selectedTransaksi.TGL_CO = null;

                    selectedNginap.TGL_KELUAR = null;
                    selectedNginap.JAM_KELUAR = null;
                    selectedNginap.AKHIR = true;

                    PASIEN_INAP pasienInap = new PASIEN_INAP();
                    pasienInap.KD_KASIR = "02";
                    pasienInap.KD_UNIT = kodeUnit;
                    pasienInap.NO_TRANSAKSI = selectedTransaksi.NO_TRANSAKSI;
                    pasienInap.NO_KAMAR = selectedNginap.NO_KAMAR;
                    pasienInap.KD_SPESIAL = selectedNginap.KD_SPESIAL;

                    context.PASIEN_INAPs.InsertOnSubmit(pasienInap);

                    selectedKamarInduk.DIGUNAKAN++;

                    context.SubmitChanges();

                    transactionScope.Complete();

                    MessageBox.Show("Transaksi sudah dibuka", "Information");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    context.Dispose();
                    transactionScope.Dispose();
                }
            }
        }
    }
}