using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Microsoft.AspNetCore.Hosting;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace StudioPilates
{
    public static class AppUtils
    {
        public static async Task ProcessPhotoFile(int id_customer, IFormFile customerPhoto, IWebHostEnvironment whe)
        {
            //copia a imagem para um stream em memória
            var ms = new MemoryStream();
            await customerPhoto.CopyToAsync(ms);

            //carrega o stream em memória para o objeto de processamento de imagem
            ms.Position = 0;
            var img = await Image.LoadAsync(ms);            
            JpegEncoder jpegEnc = new JpegEncoder();
            jpegEnc.Quality = 100;
            img.SaveAsJpeg(ms, jpegEnc);
            ms.Position = 0;
            img = await Image.LoadAsync(ms);
            ms.Close();
            ms.Dispose();

            //cria um retângulo de recorte para deixar a imagem quadrada
            var size = img.Size();
            Rectangle rectangleCut;
            if (size.Width > size.Height)
            {
                float x = (size.Width - size.Height) / 2.0F;
                rectangleCut = new Rectangle((int)x, 0, size.Height, size.Height);
            }
            else
            {
                float y = (size.Height - size.Width) / 2.0F;
                rectangleCut = new Rectangle(0, (int)y, size.Width, size.Width);
            }
            //recorta a imagem usando o retângulo computado
            img.Mutate(i => i.Crop(rectangleCut));
            //monta o caminho da imagem (~/img/produto/000000.jpg)"
            var photoFilepath = Path.Combine(whe.WebRootPath,
                "Photo", id_customer.ToString("D6") + ".jpeg");
            //cria um arquivo de imagem sobrescrevendo o existente, caso exista
            await img.SaveAsync(photoFilepath);            
        }
    }
}
