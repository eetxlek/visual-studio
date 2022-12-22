using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_UT4_2_Binding_con_objeto
{
    internal class Superheroe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set {_nombre = value; NotifyPropertyChanged("Nombre");}
        }
        private string _imagen;
        public string Imagen
        {
            get { return _imagen; }
            set{ _imagen = value; this.NotifyPropertyChanged("Imagen");}
        }
        private bool _vengador;
        public bool Vengador
        {
            get { return _vengador; }
            set{_vengador = value; this.NotifyPropertyChanged("Vengador");}
        }
        private bool _xmen;
        public bool Xmen
        {
            get { return _xmen; }
            set
            {_xmen = value; this.NotifyPropertyChanged("Xmen"); }
        }
        private bool _heroe;
        public bool Heroe
        {
            get { return _heroe; }
            set {_heroe = value; this.NotifyPropertyChanged("Heroe");}
        }
        private bool _villano;
        public bool Villano {
            get { return _villano;} 
            set { _villano =  value; this.NotifyPropertyChanged("Villano"); } }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe, bool villano)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
            Villano = villano;
        }

        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe viuda = new Superheroe("Viuda Negra", @"https://images6.alphacoders.com/105/1056296.jpg", true, false, true, false);
            Superheroe ironman = new Superheroe("Ironman", @"https://as01.epimg.net/meristation/imagenes/2019/09/11/noticias/1568191257_590129_1568191310_noticia_normal_recorte1.jpg", true, false, true, false);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false, true);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true, false);

            ejemplos.Add(viuda);
            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }

    }
}
