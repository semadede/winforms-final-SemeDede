using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Reports
{
    public static class PdfRaporHelper
    {
        // Musteri nihai fatura PDF
        public static void FaturaOlustur(Etkinlik etkinlik, Butce butce, decimal gerceklesenToplam, List<GerceklesenMaliyet> maliyetler)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF Dosyasi|*.pdf";
            dialog.FileName = $"Fatura_{etkinlik.MusteriAdi}_{DateTime.Now:yyyyMMdd}";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font baslikFont = new Font(baseFont, 18, Font.BOLD);
            Font altBaslikFont = new Font(baseFont, 12, Font.BOLD);
            Font normalFont = new Font(baseFont, 10, Font.NORMAL);

            Paragraph baslik = new Paragraph("ETKİNLİK YONETİM SİSTEMİ", baslikFont);
            baslik.Alignment = Element.ALIGN_CENTER;
            doc.Add(baslik);

            Paragraph altBaslik = new Paragraph("MUSTERİ NİHAİ FATURA", altBaslikFont);
            altBaslik.Alignment = Element.ALIGN_CENTER;
            doc.Add(altBaslik);

            doc.Add(new Paragraph(" "));

            // Musteri ve etkinlik bilgileri
            PdfPTable bilgiTablosu = new PdfPTable(2);
            bilgiTablosu.WidthPercentage = 100;

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Musteri Adi:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.MusteriAdi, normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Musteri Telefon:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.MusteriTelefon, normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Etkinlik Adi:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.EtkinlikAdi, normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Etkinlik Tarihi:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.BaslangicTarihi.ToString("dd.MM.yyyy HH:mm"), normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Mekan:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.MekanAdi, normalFont)));

            doc.Add(bilgiTablosu);
            doc.Add(new Paragraph(" "));

            // Saglanan hizmetler - sadece isim, fiyat yok
            Paragraph hizmetBaslik = new Paragraph("Saglanan Hizmetler", altBaslikFont);
            doc.Add(hizmetBaslik);
            doc.Add(new Paragraph(" "));

            PdfPTable hizmetTablosu = new PdfPTable(1);
            hizmetTablosu.WidthPercentage = 100;
            hizmetTablosu.AddCell(new PdfPCell(new Phrase("Hizmet", altBaslikFont)));

            foreach (var maliyet in maliyetler)
            {
                hizmetTablosu.AddCell(new PdfPCell(new Phrase(maliyet.Aciklama, normalFont)));
            }

            doc.Add(hizmetTablosu);
            doc.Add(new Paragraph(" "));

            // Sadece sozlesme bedeli
            PdfPTable ozetTablosu = new PdfPTable(2);
            ozetTablosu.WidthPercentage = 50;
            ozetTablosu.HorizontalAlignment = Element.ALIGN_RIGHT;

            ozetTablosu.AddCell(new PdfPCell(new Phrase("Sozlesme Bedeli:", altBaslikFont)));
            ozetTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.SozlesmeBedeli.ToString("N2") + " TL", normalFont)));

            doc.Add(ozetTablosu);
            doc.Add(new Paragraph(" "));

            // İmza alani
            doc.Add(new Paragraph("_______________________          _______________________", normalFont));
            doc.Add(new Paragraph("Musteri Imzasi                           Yetkili Imzasi", normalFont));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Duzenleme Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}", normalFont));

            doc.Close();

            MessageBox.Show("Fatura PDF olusturuldu.", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Butce-gerceklesme raporu PDF
        public static void ButceRaporuOlustur(Etkinlik etkinlik, Butce butce, decimal gerceklesenToplam, List<GerceklesenMaliyet> maliyetler)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF Dosyasi|*.pdf";
            dialog.FileName = $"ButceRaporu_{etkinlik.EtkinlikAdi}_{DateTime.Now:yyyyMMdd}";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font baslikFont = new Font(baseFont, 18, Font.BOLD);
            Font altBaslikFont = new Font(baseFont, 12, Font.BOLD);
            Font normalFont = new Font(baseFont, 10, Font.NORMAL);

            Paragraph baslik = new Paragraph("ETKİNLİK BUTCE RAPORU", baslikFont);
            baslik.Alignment = Element.ALIGN_CENTER;
            doc.Add(baslik);
            doc.Add(new Paragraph(" "));

            // Etkinlik bilgileri
            PdfPTable bilgiTablosu = new PdfPTable(2);
            bilgiTablosu.WidthPercentage = 100;

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Etkinlik:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.EtkinlikAdi, normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Tarih:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(etkinlik.BaslangicTarihi.ToString("dd.MM.yyyy"), normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Planlanan Butce:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(butce.PlanlananButce.ToString("N2") + " TL", normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Gerceklesen Toplam:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(gerceklesenToplam.ToString("N2") + " TL", normalFont)));

            decimal fark = butce.PlanlananButce - gerceklesenToplam;
            decimal oran = butce.PlanlananButce > 0 ? (gerceklesenToplam / butce.PlanlananButce) * 100 : 0;

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Fark:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase(fark.ToString("N2") + " TL", normalFont)));

            bilgiTablosu.AddCell(new PdfPCell(new Phrase("Kullanim Orani:", altBaslikFont)));
            bilgiTablosu.AddCell(new PdfPCell(new Phrase($"%{oran:F1}", normalFont)));

            doc.Add(bilgiTablosu);
            doc.Add(new Paragraph(" "));

            // Maliyet detaylari
            Paragraph maliyetBaslik = new Paragraph("Maliyet Detaylari", altBaslikFont);
            doc.Add(maliyetBaslik);
            doc.Add(new Paragraph(" "));

            PdfPTable maliyetTablosu = new PdfPTable(3);
            maliyetTablosu.WidthPercentage = 100;
            maliyetTablosu.SetWidths(new float[] { 3, 1, 1 });

            maliyetTablosu.AddCell(new PdfPCell(new Phrase("Aciklama", altBaslikFont)));
            maliyetTablosu.AddCell(new PdfPCell(new Phrase("Tarih", altBaslikFont)));
            maliyetTablosu.AddCell(new PdfPCell(new Phrase("Tutar", altBaslikFont)));

            foreach (var maliyet in maliyetler)
            {
                maliyetTablosu.AddCell(new PdfPCell(new Phrase(maliyet.Aciklama, normalFont)));
                maliyetTablosu.AddCell(new PdfPCell(new Phrase(maliyet.Tarih.ToString("dd.MM.yyyy"), normalFont)));
                maliyetTablosu.AddCell(new PdfPCell(new Phrase(maliyet.Tutar.ToString("N2") + " TL", normalFont)));
            }

            doc.Add(maliyetTablosu);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}", normalFont));

            doc.Close();

            MessageBox.Show("Butce raporu PDF olusturuldu.", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}