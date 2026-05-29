using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

/// <summary>
/// Summary description for resimislem
/// </summary>
public class resimislem
{
    public Image ResimOlustur(int MaxBoy, string orjResim)
    {

        int boy, yuk;
        Image resim = Image.FromFile(orjResim);
        Size boyut = resim.Size;
        if (MaxBoy >= boyut.Height || MaxBoy >= boyut.Width)

            MaxBoy = boyut.Width;

        double oran = (double)boyut.Width / boyut.Height;
        if (boyut.Width >= boyut.Height)
        {
            boy = MaxBoy;
            yuk = (int)(boy / oran);
        }
        else
        {
            yuk = MaxBoy;
            boy = (int)(yuk * oran);
        }

        Image th = new Bitmap(boy, yuk, resim.PixelFormat);
        Graphics g = Graphics.FromImage(th);
        g.CompositingQuality = CompositingQuality.HighQuality;
        g.SmoothingMode = SmoothingMode.HighQuality;
        //g.InterpolationMode = InterpolationMode.High;
        Rectangle dikdortgen = new Rectangle(0, 0, boy, yuk);
        g.DrawImage(resim, dikdortgen);

        resim.Dispose();
        return th;

    }
}
