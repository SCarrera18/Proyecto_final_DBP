using Repromusica.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repromusica.Datos
{
    public class Dmusica
    {

        public async Task <List<Mmusica>> Listarmusica()
        {
            var lista = new List<Mmusica>()
            {
                new Mmusica
                {
                    Nombre ="Inevitable",
                    Autor ="M2H ft. Franco Banda",
                    Icono= "https://i.postimg.cc/B6qgtQH7/m2h-inevitable.jpg",
                    Url= "https://firebasestorage.googleapis.com/v0/b/final-musicaapp.appspot.com/o/M2H%20-%20Inevitable%20Feat.%20Franco%20Banda%20(by%20Biscarrita).mp3?alt=media&token=5ec0eade-d365-467f-ab6e-c8b79ea91a47"
                },
                new Mmusica
                {
                    Nombre = "Fruto",
                    Autor = "Bizarap ft MiloJ",
                    Icono = "https://i.postimg.cc/vHzh5yqJ/fruto-miloj.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/final-musicaapp.appspot.com/o/Fruto.mp3?alt=media&token=05d27757-04de-4175-9621-642415b6e6e7"
                },
                new Mmusica
                {
                    Nombre = "hARAkiRi",
                    Autor = "Duki - C.R.O",
                    Icono = "https://i.postimg.cc/cLZdvRgx/harakiri-duki.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/final-musicaapp.appspot.com/o/Duki%2C%20C.R.O%20-%20%20hARAkiRi%20(Video%20Oficial).mp3?alt=media&token=9b953cb8-3d7b-4b37-8c06-a8476b186dd6"
                },
                new Mmusica
                {
                    Nombre = "Flechazo en el centro",
                    Autor = "Ysy A x Bhavi ft MiloJ",
                    Icono = "https://i.postimg.cc/QtR3h1Zr/flechazo-en-el-centro.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/final-musicaapp.appspot.com/o/08%20%20-%20YSY%20A%20x%20BHAVI%20ft.%20MILO%20J%20-%20FLECHAZO%20EN%20EL%20CENTRO%20(PROD.%20ONIRIA).mp3?alt=media&token=fa6cc377-7821-49be-a8af-d6eeaba97136"
                }

            };
            return lista;
        }
    }
}
